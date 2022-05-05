using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using crmRules.Entities;
using crmRules.Mappers;
using crmRules;
using API.Clases;
using System.Web;
using Newtonsoft.Json;

namespace API.Controllers
{
    [RoutePrefix("contactos")]
    public class ContactosController : ApiController
    {
        [Route("Admin/todosAdmin")]
        [HttpGet]
        
        public IHttpActionResult todosAdmin()
        {
            try
            {
                ContactosList lista = ContactosMapper.Instance().GetAll();
                foreach (var item in lista)
                {
                    item.Acciones = ContactoHistorialAciconesMapper.Instance().GetByContactos(item.IdContacto);
                    item.Direcciones = ContactosDireccionesMapper.Instance().GetByContactos(item.IdContacto);
                    item.Estados = ContactosHistorialEstadoMapper.Instance().GetByContactos(item.IdContacto);
                    item.Asignaciones = ContactosHistorialAsignacionesMapper.Instance().GetByContactos(item.IdContacto);
                }
                return Ok(lista);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/todosActivos")]
        [HttpGet]
       
        public IHttpActionResult todosActivos()
        {
            try
            {
                ContactosList lista = ContactosMapper.Instance().GetAll();
                foreach (var item in lista)
                {
                    
                    item.Acciones = ContactoHistorialAciconesMapper.Instance().GetByContactos(item.IdContacto);
                    item.Direcciones = ContactosDireccionesMapper.Instance().GetByContactos(item.IdContacto);
                    item.Estados = ContactosHistorialEstadoMapper.Instance().GetByContactos(item.IdContacto);
                    item.Asignaciones = ContactosHistorialAsignacionesMapper.Instance().GetByContactos(item.IdContacto);
                }
                return Ok(lista.Where(c=>c.Activo));
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
                ContactosRules.Borrar(id);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("Admin/Activar")]
        [HttpGet]
        
        public IHttpActionResult Activar(int id)
        {
            try
            {
                ContactosRules.Activar(id);
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
                Contactos obj = JsonConvert.DeserializeObject<Contactos>(HttpContext.Current.Request.Unvalidated["obj"]);
                
                List<ContactosHistorialEstado> estados = JsonConvert.DeserializeObject<List<ContactosHistorialEstado>>(HttpContext.Current.Request.Unvalidated["estados"]);
                
                List<ContactoHistorialAcicones> acciones = JsonConvert.DeserializeObject<List<ContactoHistorialAcicones>>(HttpContext.Current.Request.Unvalidated["acciones"]);

                List<ContactosDirecciones> direcciones = JsonConvert.DeserializeObject<List<ContactosDirecciones>>(HttpContext.Current.Request.Unvalidated["direcciones"]);

                List<ContactosHistorialAsignaciones> asignaciones = JsonConvert.DeserializeObject<List<ContactosHistorialAsignaciones>>(HttpContext.Current.Request.Unvalidated["asignaciones"]);

                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);


                if (id != 0)
                {
                    ContactosRules.Modificar(id,obj.Nombre,obj.Apellido,obj.Dni,obj.Cuit,obj.Telefono,obj.Email,obj.EstadoCivil,obj.Profesion,obj.Actividad,obj.FechaNacimiento,obj.Whatsapp,obj.Empresa,obj.Facebook,obj.Linkedin,obj.Linkedin,obj.IdOrigen);
                }
                else
                {
                    id=ContactosRules.Agregar(obj.Nombre, obj.Apellido, obj.Dni, obj.Cuit, obj.Telefono, obj.Email, obj.EstadoCivil, obj.Profesion, obj.Actividad, obj.FechaNacimiento, obj.Whatsapp, obj.Empresa, obj.Facebook, obj.Linkedin, obj.Linkedin, obj.IdOrigen);
                }

                ContactosRules.Acciones(acciones, id);
                ContactosRules.Direcciones(direcciones, id);
                ContactosRules.Asignaciones(asignaciones, id);
                ContactosRules.Estados(estados, id);




                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
    }
}
