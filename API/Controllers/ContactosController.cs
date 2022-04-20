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
    [RoutePrefix("contactos")]
    public class ContactosController : ApiController
    {
        [Route("todosAdmin")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult todosAdmin()
        {
            try
            {
                return Ok(ContactosMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
