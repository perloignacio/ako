
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 13/5/2022 - 02:18 p. m.
// This is a partial class file. The other one is ContactosTipoUsuarioEntity.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using crmRules.Objects;



using Cooperator.Framework.Core;
using Cooperator.Framework.Core.LazyLoad;
using System;

namespace crmRules.Entities
{

    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosTipoUsuario : Objects.ContactosTipoUsuarioObject, IMappeableContactosTipoUsuario, IEquatable<ContactosTipoUsuario>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoUsuario()
            :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoUsuario(
			System.Int32 IdTipoUsuarioContacto)
            : base()
        {

			_IdTipoUsuarioContacto = IdTipoUsuarioContacto;

            
            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoUsuario(
			System.Int32 IdTipoUsuarioContacto,
			System.String Nombre,
			System.Boolean Activo)
            : base()
        {

			_IdTipoUsuarioContacto = IdTipoUsuarioContacto;
			_Nombre = Nombre;
			_Activo = Activo;

            
            Initialized();
        }
        
        #endregion

        #region "Fields"

        
        #endregion

        #region "Properties"
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new ContactosTipoUsuario OriginalValue()
        {
            return (ContactosTipoUsuario)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ContactosTipoUsuario newObject;            
            

            newObject = (ContactosTipoUsuario)this.MemberwiseClone();
            // Entities
            
            // Colections
            
            // OriginalValue
            ContactosTipoUsuario newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosTipoUsuario)this.OriginalValue().MemberwiseClone();
                // Entities
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosTipoUsuario.CompleteEntity()
        {
        
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosTipoUsuario.SetFKValuesForChilds(ContactosTipoUsuario entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosTipoUsuario other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosTipoUsuario
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(ContactosTipoUsuario entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosTipoUsuarioList : ObjectList<ContactosTipoUsuario>
    {
    }
}
namespace crmRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosTipoUsuarioListView
        : ObjectListView<Entities.ContactosTipoUsuario>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoUsuarioListView(Entities.ContactosTipoUsuarioList list): base(list)
        {
        }
    }
}


