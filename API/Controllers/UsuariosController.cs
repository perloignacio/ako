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
    }
}
