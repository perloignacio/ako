using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crmRules.Entities;
using crmRules.Mappers;

namespace crmRules
{
    public static class OrigenesRules
    {
        public static void Agregar(string nombre)
        {
            validar(nombre);
            ContactosOrigen co = new ContactosOrigen();
            co.Nombre = nombre;
            ContactosOrigenMapper.Instance().Insert(co);

        }

        public static void Modificar(int idorigen, string nombre)
        {
            validar(nombre);
            ContactosOrigen co = ContactosOrigenMapper.Instance().GetOne(idorigen);
            if (co == null)
            {
                throw new Exception("No se encuentra el origen");
            }

            co.Nombre = nombre;
            ContactosOrigenMapper.Instance().Save(co);

        }

        public static void Borrar(int idorigen)
        {

            ContactosOrigen co = ContactosOrigenMapper.Instance().GetOne(idorigen);
            if (co == null)
            {
                throw new Exception("No se encuentra el origen");
            }
            co.Activo = false;
            ContactosOrigenMapper.Instance().Save(co);
        }

        public static void Activar(int idorigen)
        {

            ContactosOrigen co = ContactosOrigenMapper.Instance().GetOne(idorigen);
            if (co == null)
            {
                throw new Exception("No se encuentra el origen");
            }
            co.Activo = true;
            ContactosOrigenMapper.Instance().Save(co);
        }

        public static void validar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el nombre");
            }
            

        }
    }
}
