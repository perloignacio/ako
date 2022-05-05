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
    [RoutePrefix("estados")]
    public class EstadosController : ApiController
    {
        [Route("Admin/tipos")]
        [HttpGet]
        
        public IHttpActionResult tipos()
        {
            try
            {
                return Ok(ContactosEstadosMapper.Instance().GetAll().Where(e=>e.Activo).OrderBy(t => t.Nombre));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
