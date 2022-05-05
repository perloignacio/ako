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
using Newtonsoft.Json;

namespace API.Controllers
{

    [RoutePrefix("Agenda")]
    public class AgendaController : ApiController
    {
        [Route("Admin/eventos")]
        [HttpGet]
        
        public IHttpActionResult eventos()
        {
            try
            {
                int idusuario = 1;
                AgendaList eventos = AgendaMapper.Instance().GetByContactoUsuarios(idusuario);
                foreach (var e in eventos)
                {
                    e.Desde = e.FechaDesde.Ticks;
                    e.Hasta = e.FechaHasta.Ticks;
                }
                return Ok(eventos.Where(e=>e.Activo));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Route("Admin/Borrar")]
        [HttpGet]
        
        public IHttpActionResult Borrar(int id)
        {
            try
            {
                AgendaRules.Borrar(id);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("Admin/AgregarEditar")]
        [HttpPost]
        
        public IHttpActionResult AgregarEditar()
        {
            try
            {
                int idusuario = 1;
                Agenda obj = JsonConvert.DeserializeObject<Agenda>(HttpContext.Current.Request.Unvalidated["obj"]);

                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                obj.IdUsuario = idusuario;

                if (id != 0)
                {
                    AgendaRules.Modificar(id,obj.FechaDesde,obj.FechaHasta,obj.Asunto,obj.Descripcion,obj.Link,obj.IdContacto,obj.IdUsuario);
                }
                else
                {
                    AgendaRules.Agregar(obj.FechaDesde, obj.FechaHasta, obj.Asunto, obj.Descripcion, obj.Link, obj.IdContacto, obj.IdUsuario);
                }

               
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
    }
}
