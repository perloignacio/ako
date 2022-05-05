using crmRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using crmRules.Entities;
using crmRules.Mappers;
using API.Clases;
using Newtonsoft.Json;
using System.Web;

namespace API.Controllers
{
    [ RoutePrefix("usuarios")]
    public class UsuariosController : ApiController
    {
        [Route("login")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult login(string usuario, string contra)
        {
            try
            {
                string pass = Encriptar.Encrypt(contra, "S3rv3th0m3");
                ContactoUsuarios u = ContactoUsuariosMapper.Instance().Login(usuario, pass);
                if (u != null)
                {
                    u.Token = TokenGenerator.GenerateTokenJwt(u.IdUsuario.ToString());
                    
                    return Ok(u);
                }
                else
                {
                    return BadRequest("Usuario / contraseña incorrectas");
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("checktoken")]
        [HttpGet]
        
        public IHttpActionResult checktoken()
        {
            try
            {
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/activos")]
        [HttpGet]
       
        public IHttpActionResult activos()
        {
            try
            {
                return Ok(ContactoUsuariosMapper.Instance().GetAll().Where(t => t.Activo).OrderBy(t => t.Apellido));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/tipos")]
        [HttpGet]
        
        public IHttpActionResult tipos()
        {
            try
            {
                return Ok(ContactosTipoUsuarioMapper.Instance().GetAll().Where(t => t.Activo).OrderBy(t => t.Nombre));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/todosAdmin")]
        [HttpGet]
        
        public IHttpActionResult todosAdmin()
        {
            try
            {
                return Ok(ContactoUsuariosMapper.Instance().GetAll().OrderBy(t => t.Apellido));
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
                UsuariosRules.Borrar(id);
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
                UsuariosRules.Activar(id);
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
                
                ContactoUsuarios obj = JsonConvert.DeserializeObject<ContactoUsuarios>(HttpContext.Current.Request.Unvalidated["obj"]);

                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
               

                if (id != 0)
                {
                   UsuariosRules.Modificar(id, obj.Nombre, obj.Apellido, obj.Email, obj.Telefono, obj.Usuario, obj.Contra, obj.IdTipoUsuario);
                }
                else
                {
                    UsuariosRules.Agregar(obj.Nombre, obj.Apellido, obj.Email, obj.Telefono, obj.Usuario, obj.Contra, obj.IdTipoUsuario);
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
