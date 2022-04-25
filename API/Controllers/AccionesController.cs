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
    [RoutePrefix("acciones")]
    public class AccionesController : ApiController
    {
        [Route("tipos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult tipos()
        {
            try
            {
                return Ok(ContactosTipoAccionesMapper.Instance().GetAll().Where(t=>t.Activa).OrderBy(t=>t.TipoAccion));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
