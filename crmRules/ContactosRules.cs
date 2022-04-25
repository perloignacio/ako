using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crmRules.Entities;
using crmRules.Mappers;

namespace crmRules
{
    public  class ContactosRules
    {
        public static int Agregar(string nombre,string apellido,string dni,string cuil,string telefono,string email,string estadocivil,string profesion,string actividad,DateTime? fecnac,string whatsapp,string empresa, string facebook,string linkedin,string instagram,int? idorigen)
        {
            Validar(nombre, apellido);
            Contactos obj = new Contactos();

            obj.Nombre = nombre;
            obj.Telefono = telefono;
            obj.Email = email;
            obj.Cuit = cuil;
            obj.FechaRegistro = DateTime.Now;
            obj.Activo = true;
            obj.Apellido = apellido;
            obj.Dni = dni;
            obj.EstadoCivil = estadocivil;
            obj.Profesion = profesion;
            obj.Actividad = actividad;
            obj.Whatsapp = whatsapp;
            obj.Empresa = empresa;
            obj.Facebook = facebook;
            obj.Linkedin = linkedin;
            obj.Instagram=  instagram;
            if (idorigen.HasValue)
            {
                obj.IdOrigen = idorigen.Value;
            }

            if (fecnac.HasValue)
            {
                obj.FechaNacimiento = fecnac.Value;
            }
           
           
            ContactosMapper.Instance().Insert(obj);
            return obj.IdContacto;
            

            

            

            

        }


        public static void Modificar(int idcontacto,string nombre, string apellido, string dni, string cuil, string telefono, string email, string estadocivil, string profesion, string actividad, DateTime? fecnac, string whatsapp, string empresa, string facebook, string linkedin, string instagram, int? idorigen)
        {
            Validar(nombre, apellido);
            Contactos obj = ContactosMapper.Instance().GetOne(idcontacto);
            if (obj == null) { throw new Exception("No se encontro el contacto"); }

            obj.Nombre = nombre;
            obj.Telefono = telefono;
            obj.Email = email;
            obj.Cuit = cuil;
            obj.Apellido = apellido;
            obj.Dni = dni;
            obj.EstadoCivil = estadocivil;
            obj.Profesion = profesion;
            obj.Actividad = actividad;
            obj.Whatsapp = whatsapp;
            obj.Empresa = empresa;
            obj.Facebook = facebook;
            obj.Linkedin = linkedin;
            obj.Instagram = instagram;
            if (idorigen.HasValue)
            {
                obj.IdOrigen = idorigen.Value;
            }

            if (fecnac.HasValue)
            {
                obj.FechaNacimiento = fecnac.Value;
            }


            ContactosMapper.Instance().Save(obj);
            
        }

        public static void Direcciones(List<ContactosDirecciones> direcciones, int idcontacto)
        {
            foreach (var item in direcciones)
            {
                if (item.IdObjeto > 0)
                {
                    ContactosDirecciones cd = ContactosDireccionesMapper.Instance().GetOne(item.IdObjeto);
                    cd.Ubicacion = item.Ubicacion;
                    cd.Latitud = item.Latitud;
                    cd.Longitud = item.Longitud;
                    cd.Activo = item.Activo;
                    cd.Nombre = item.Nombre;
                    ContactosDireccionesMapper.Instance().Save(cd);
                }
                else
                {
                    item.Activo = true;
                    item.IdContacto = idcontacto;
                    ContactosDireccionesMapper.Instance().Insert(item);
                }
            }
        }

        public static void Acciones(List<ContactoHistorialAcicones> acciones, int idcontacto)
        {
            foreach (var item in acciones)
            {
                if (item.IdObjeto > 0)
                {
                    ContactoHistorialAcicones ca= ContactoHistorialAciconesMapper.Instance().GetOne(item.IdObjeto);
                    ca.Accion = item.Accion;
                    ca.IdTipoAccion = item.IdTipoAccion;
                    ca.Activo = item.Activo;
                    ca.Fecha = item.Fecha; 
                    
                    ContactoHistorialAciconesMapper.Instance().Save(ca);
                }
                else
                {

                    item.IdContacto = idcontacto;
                    ContactoHistorialAciconesMapper.Instance().Insert(item);
                   
                }
            }
        }

        public static void Asignaciones(List<ContactosHistorialAsignaciones> asignaciones, int idcontacto)
        {
            foreach (var item in asignaciones)
            {
                /*if (item.IdObjeto > 0)
                {
                    ContactosHistorialAsignaciones ch = ContactosHistorialAsignacionesMapper.Instance().GetOne(item.IdObjeto);
                    ch = item;

                    ContactosHistorialAsignacionesMapper.Instance().Save(ch);
                }
                else
                {*/
                if (item.IdObjeto <= 0)
                {
                    item.IdContacto = idcontacto;
                    item.Fecha = DateTime.Now;
                    ContactosHistorialAsignacionesMapper.Instance().Insert(item);
                }
                /*}*/

            }
            
        }
        public static void Estados(List<ContactosHistorialEstado> estados, int idcontacto)
        {
            foreach (var item in estados)
            {
                /*if (item.IdObjeto > 0)
                {
                    ContactosHistorialEstado ce=ContactosHistorialEstadoMapper.Instance().GetOne(item.IdObjeto);
                    ce = item;
                    ContactosHistorialEstadoMapper.Instance().Save(ce);
                }
                else
                {*/
                if (item.IdObjeto <= 0)
                { 
                    item.IdContacto = idcontacto;
                    item.Fecha = DateTime.Now;
                    ContactosHistorialEstadoMapper.Instance().Insert(item);
                }
                /*}*/

            }
            
        }
                

        public static void Borrar(int idcontacto)
        {

            Contactos obj = ContactosMapper.Instance().GetOne(idcontacto);
            if (obj == null)
            {
                throw new Exception("No se encuntra el contacto");
            }
            obj.Activo = false;

            ContactosMapper.Instance().Save(obj);

        }

        public static void Activar(int idcontacto)
        {


            Contactos obj = ContactosMapper.Instance().GetOne(idcontacto);
            if (obj == null)
            {
                throw new Exception("No se encuntra el contacto");
            }
            obj.Activo = true;

            ContactosMapper.Instance().Save(obj);

        }
        public static void Validar(string nombre, string apellido)
        {

            
            if (string.IsNullOrEmpty(apellido))
            {
                throw new Exception("Ingrese el apellido");
            }

            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el nombre");
            }

            



        }
    }
}
