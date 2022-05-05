using API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using crmRules;
using crmRules.Entities;
using crmRules.Mappers;
using System.IO;
using MimeKit;
using API.Clases;

namespace API.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : ApiController
    {
        [Route("Admin/Enviar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult Enviar()
        {
            try
            {
                Home obj = JsonConvert.DeserializeObject<Home>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id;

                Contactos c = ContactosMapper.Instance().GetByEmail(obj.contacto.Email);
                if (c == null)
                {
                    id = ContactosRules.Agregar(obj.contacto.Nombre, obj.contacto.Apellido, "", "","", obj.contacto.Email, "", "", "",null, obj.contacto.Whatsapp, "", "", "", "", 2);

                }
                else
                {
                    id = c.IdContacto;
                }

                ContactosRules.Direcciones(obj.contacto.Direcciones, id);
                ContactosConsultas cc = new ContactosConsultas();
                cc.Corr_canthec = obj.correccion.canthec;
                cc.Fecha = DateTime.Now;
                cc.totalako = obj.totalako;
                cc.Corr_cantidad = obj.correccion.cantidad;
                cc.Corr_costoeco = obj.correccion.costoeco;
                cc.Corr_costohec = obj.correccion.costohec;
                cc.Corr_hectareas = obj.correccion.hectareas;
                cc.Corr_litros = obj.correccion.litros;
                cc.Corr_volumen = obj.correccion.volumen;
                cc.Gli_costo = obj.glifosato.costo;
                cc.Gli_dosis = obj.glifosato.dosis;
                cc.Gli_dureza = obj.glifosato.dureza;
                cc.Gli_perdida = obj.glifosato.perdida;
                cc.Gli_porinactivacion = obj.glifosato.porinactivacion;
                cc.Gli_valinactivacion = obj.glifosato.valinactivacion;
                cc.Gli_villaseca = Glifosato.villaseca;
                cc.Gli_volumen = obj.glifosato.volumen;
                cc.IdContacto = id;
                cc.totalesta = obj.totalesta;
                ContactosConsultasMapper.Instance().Insert(cc);

                string body = String.Empty;
                var path = HttpContext.Current.Server.MapPath("~/Plantillas/Resultados.html");
                var fileStream = System.IO.File.OpenRead(path);
                StreamReader reader = new StreamReader(fileStream);
                body = reader.ReadToEnd();
                body = body.Replace("{ubicacionlogo}", "https://akoapp.web.app/assets/logo.png");
                body = body.Replace("{nombre}",obj.contacto.Nombre+" "+obj.contacto.Apellido);
                body = body.Replace("{gli_volumen}", obj.glifosato.volumen.ToString());
                body = body.Replace("{gli_dureza}", obj.glifosato.dureza.ToString());
                body = body.Replace("{gli_costo}", obj.glifosato.costo.ToString());
                body = body.Replace("{gli_dosis}", obj.glifosato.dosis.ToString());
                body = body.Replace("{gli_porinactivacion}", obj.glifosato.porinactivacion.ToString());
                body = body.Replace("{gli_valinactivacion}", obj.glifosato.valinactivacion.ToString());
                body = body.Replace("{gli_perdida}", obj.glifosato.perdida.ToString());

                body = body.Replace("{corr_volumen}", obj.correccion.volumen.ToString());
                body = body.Replace("{corr_litros}", obj.correccion.litros.ToString());
                body = body.Replace("{corr_costoeko}", obj.correccion.costoeco.ToString());
                body = body.Replace("{corr_hectareas}", obj.correccion.hectareas.ToString());
                body = body.Replace("{corr_cantidad}", obj.correccion.cantidad.ToString());
                body = body.Replace("{corr_canthec}", obj.correccion.canthec.ToString());
                body = body.Replace("{corr_costohec}", obj.correccion.costohec.ToString());

                
                body = body.Replace("{costoesta}", obj.totalesta.ToString());
                body = body.Replace("{costoako}", obj.totalako.ToString());

                body = body.Replace("{email_contacto}", "info@akoagro.com");
                MimeKit.MimeMessage message = new MimeKit.MimeMessage();
                BodyBuilder cuerpo = new BodyBuilder();





                cuerpo.HtmlBody = body;
                message.Subject = "Informe AKO";
                message.Body = cuerpo.ToMessageBody();
                message.From.Add(new MailboxAddress("", "hola@minilent.com"));
                message.To.Add(new MailboxAddress("", obj.contacto.Email));
                EnviaMail.Envia(message);

                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
    }
}
