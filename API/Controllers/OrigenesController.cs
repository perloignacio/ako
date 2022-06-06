using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using crmRules.Entities;
using crmRules.Mappers;
using API.Clases;
using crmRules;

namespace API.Controllers
{
    [RoutePrefix("origenes")]
    public class OrigenesController : ApiController
    {
        [Route("Admin/tipos")]
        [HttpGet]
        
        public IHttpActionResult tipos()
        {
            try
            {
                return Ok(ContactosOrigenMapper.Instance().GetAll().Where(t => t.Activo).OrderBy(t => t.Nombre));
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
                return Ok(ContactosOrigenMapper.Instance().GetAll().OrderBy(t => t.Nombre));
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
                OrigenesRules.Borrar(id);
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
                OrigenesRules.Activar(id);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
    }
}
