using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crmRules.Entities;
using crmRules.Mappers;
namespace crmRules
{
    public static class UsuariosRules
    {
        public static void Agregar(string nombre, string apellido, string email,string telefono, string usuario, string contra, int idtipo,int? idcontacto)
        {
            validar(nombre, apellido, email, usuario, contra, idtipo, "Agregar");
            ContactoUsuarios u = new ContactoUsuarios();
            u.Apellido = apellido;
            u.Activo = true;
            u.Contra = Encriptar.Encrypt(contra, "S3rv3th0m3");
            u.Email = email;
            u.Telefono = telefono;
            u.Nombre = nombre;
            u.IdTipoUsuario = idtipo;
            u.Usuario = usuario;
            if (idcontacto.HasValue)
            {
                if (ContactosMapper.Instance().GetOne(idcontacto.Value) == null)
                {
                    throw new Exception("No se encuentra el contacto");
                }
                u.IdContacto = idcontacto.Value;
            }
            
            ContactoUsuariosMapper.Instance().Insert(u);
            
        }

        public static void Modificar(int idusuario, string nombre, string apellido, string email,string telefono, string usuario, string contra, int idtipo)
        {
            validar(nombre, apellido, email, usuario, contra, idtipo, "Modificar");
            ContactoUsuarios u = ContactoUsuariosMapper.Instance().GetOne(idusuario);
            if (u == null)
            {
                throw new Exception("No se encuentra el usuario");
            }
            u.Apellido = apellido;

            if (!string.IsNullOrEmpty(contra))
            {
                u.Contra = Encriptar.Encrypt(contra, "S3rv3th0m3");
            }
            u.Email = email;
            u.Nombre = nombre;
            u.Telefono = telefono;
            u.IdTipoUsuario = idtipo;
            if (u.Usuario != usuario)
            {
                ContactoUsuarios aux = ContactoUsuariosMapper.Instance().GetByUsuario(usuario);
                if (aux != null)
                {
                    throw new Exception("Ya existe un usuario con ese nombre");
                }
            }
            u.Usuario = usuario;
            ContactoUsuariosMapper.Instance().Save(u);
           
        }

        public static void Borrar(int idusuario)
        {

            ContactoUsuarios u = ContactoUsuariosMapper.Instance().GetOne(idusuario);
            if (u == null)
            {
                throw new Exception("No se encuentra el usuario");
            }
            u.Activo = false;
            ContactoUsuariosMapper.Instance().Save(u);

        }

        public static void Activar(int idusuario)
        {

            ContactoUsuarios u = ContactoUsuariosMapper.Instance().GetOne(idusuario);
            if (u == null)
            {
                throw new Exception("No se encuentra el usuario");
            }
            u.Activo = true;
            ContactoUsuariosMapper.Instance().Save(u);

        }

        public static void validar(string nombre, string apellido, string email, string usuario, string contra, int idtipo, string operacion)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el nombre");
            }
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el apellido");
            }
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el email");
            }
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el usuario");
            }

            ContactosTipoAcciones t = ContactosTipoAccionesMapper.Instance().GetOne(idtipo);
            if (t == null){
                throw new Exception("No se encuentra el tipo");
            }

            if (operacion == "Agregar")
            {
                if (string.IsNullOrEmpty(contra))
                {
                    throw new Exception("Ingrese el contra");
                }

                ContactoUsuarios u = ContactoUsuariosMapper.Instance().GetByUsuario(usuario);
                if (u != null)
                {
                    throw new Exception("Ya existe un usuario con ese nombre");
                }
            }

        }
       
    }
}
