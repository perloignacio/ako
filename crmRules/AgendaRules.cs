using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crmRules.Entities;
using crmRules.Mappers;
namespace crmRules
{
    public static class AgendaRules
    {
        public static void Agregar(DateTime desde,DateTime hasta,string asunto,string descripcion,string link,int? idcontacto,int idusuario)
        {
            validar(desde, hasta, asunto, idcontacto, idusuario,0);
            Agenda ag = new Agenda();
            ag.Activo = true;
            ag.Asunto = asunto;
            ag.Descripcion = descripcion;
            ag.Fecha = DateTime.Now;
            ag.FechaDesde = desde;
            ag.FechaHasta = hasta;
            if (idcontacto.HasValue)
            {
                ag.IdContacto = idcontacto.Value;
            }
            ag.IdUsuario = idusuario;
            ag.Link = link;
            AgendaMapper.Instance().Insert(ag);

        }

        public static void Modificar(int idagenda,DateTime desde, DateTime hasta, string asunto, string descripcion, string link, int? idcontacto, int idusuario)
        {
            validar(desde, hasta, asunto, idcontacto, idusuario, idagenda);
            Agenda ag = AgendaMapper.Instance().GetOne(idagenda);
            if (ag == null)
            {
                throw new Exception("No se encuentra el evento");
            }
            
            ag.Asunto = asunto;
            ag.Descripcion = descripcion;
           
            ag.FechaDesde = desde;
            ag.FechaHasta = hasta;
            if (idcontacto.HasValue)
            {
                ag.IdContacto = idcontacto.Value;
            }
            ag.IdUsuario = idusuario;
            ag.Link = link;
            AgendaMapper.Instance().Save(ag);

        }

        public static void Borrar(int idagenda)
        {
            
            Agenda ag = AgendaMapper.Instance().GetOne(idagenda);
            if (ag == null)
            {
                throw new Exception("No se encuentra el evento");
            }

            ag.Activo = false;
            AgendaMapper.Instance().Save(ag);

        }
        public static void validar(DateTime desde, DateTime hasta, string asunto, int? idcontacto, int idusuario,int idagenda)
        {

            AgendaList agl = AgendaMapper.Instance().ControlAgenda(idusuario, desde, hasta);
            if (idagenda == 0)
            {
                if (agl.Count > 0)
                {
                    throw new Exception("Ya tiene un evento registrado para esa fecha / horario");
                }
            }
            else
            {
                if (agl.Count > 0)
                {
                    if (agl[0].IdContactoAgenda != idagenda)
                    {
                        throw new Exception("Ya tiene un evento registrado para esa fecha / horario");
                    }
                }
            }
            
            if (desde > hasta)
            {
                throw new Exception("La fecha hasta no puede ser mayor a desde");
            }
            if (string.IsNullOrEmpty(asunto)){
                throw new Exception("Ingrese un asunto");
            }
            ContactoUsuarios u = ContactoUsuariosMapper.Instance().GetOne(idusuario);
            if (u == null)
            {
                throw new Exception("Ingrese un usuario valido");
            }
            if (idcontacto.HasValue)
            {
                Contactos c = ContactosMapper.Instance().GetOne(idcontacto.Value);
                if (c == null)
                {
                    throw new Exception("Ingrese un contacto valido");
                }
            }
        }
    }
}
