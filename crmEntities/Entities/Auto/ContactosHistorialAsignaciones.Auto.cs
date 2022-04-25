
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/4/2022 - 03:14 p. m.
// This is a partial class file. The other one is ContactosHistorialAsignacionesEntity.cs
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
    public partial class ContactosHistorialAsignaciones : Objects.ContactosHistorialAsignacionesObject, IMappeableContactosHistorialAsignaciones, IEquatable<ContactosHistorialAsignaciones>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignaciones()
            :base()
        {
            if (_ContactosEntity == null) _ContactosEntity = new Entities.Contactos();
if (_ContactoUsuariosEntity == null) _ContactoUsuariosEntity = new Entities.ContactoUsuarios();

        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignaciones(
			System.Int32 IdHistorialAsignacionesContacto)
            : base()
        {

			_IdHistorialAsignacionesContacto = IdHistorialAsignacionesContacto;

            if (_ContactosEntity == null) _ContactosEntity = new Entities.Contactos();
if (_ContactoUsuariosEntity == null) _ContactoUsuariosEntity = new Entities.ContactoUsuarios();

            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignaciones(
			System.Int32 IdHistorialAsignacionesContacto,
			System.Int32 IdContacto,
			System.Int32 IdUsuarioContacto,
			System.DateTime Fecha)
            : base()
        {

			_IdHistorialAsignacionesContacto = IdHistorialAsignacionesContacto;
			_IdContacto = IdContacto;
			_IdUsuarioContacto = IdUsuarioContacto;
			_Fecha = Fecha;

            if (_ContactosEntity == null) _ContactosEntity = new Entities.Contactos();
if (_ContactoUsuariosEntity == null) _ContactoUsuariosEntity = new Entities.ContactoUsuarios();

            Initialized();
        }
        
        #endregion

        #region "Fields"

        /// <summary>
/// 
/// </summary>
protected Entities.Contactos _ContactosEntity;
/// <summary>
/// 
/// </summary>
protected Entities.ContactoUsuarios _ContactoUsuariosEntity;

        #endregion

        #region "Properties"
        
bool _ContactosEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.Contactos ContactosEntity
        {
            get
            {
                if (_ContactosEntity== null  && ! _ContactosEntityFetched ) {
_ContactosEntityFetched = true;
Entities.Contactos _ContactosEntityTemp = new Entities.Contactos(this.IdContacto); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.Contactos));
 _ContactosEntity = lazyProvider.GetEntity(typeof(Entities.Contactos), _ContactosEntityTemp) as Entities.Contactos;
}

                return _ContactosEntity;
            }
            set
            {
                base.PropertyModified();
                _ContactosEntity = value;
                if (value != null) {
   _IdContacto = value.IdContacto;

} else {
   _IdContacto = System.Int32.MinValue;

}

            }
        }
        
bool _ContactoUsuariosEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.ContactoUsuarios ContactoUsuariosEntity
        {
            get
            {
                if (_ContactoUsuariosEntity== null  && ! _ContactoUsuariosEntityFetched ) {
_ContactoUsuariosEntityFetched = true;
Entities.ContactoUsuarios _ContactoUsuariosEntityTemp = new Entities.ContactoUsuarios(this.IdUsuarioContacto); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.ContactoUsuarios));
 _ContactoUsuariosEntity = lazyProvider.GetEntity(typeof(Entities.ContactoUsuarios), _ContactoUsuariosEntityTemp) as Entities.ContactoUsuarios;
}

                return _ContactoUsuariosEntity;
            }
            set
            {
                base.PropertyModified();
                _ContactoUsuariosEntity = value;
                if (value != null) {
   _IdUsuarioContacto = value.IdUsuario;

} else {
   _IdUsuarioContacto = System.Int32.MinValue;

}

            }
        }
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new ContactosHistorialAsignaciones OriginalValue()
        {
            return (ContactosHistorialAsignaciones)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ContactosHistorialAsignaciones newObject;            
            

            newObject = (ContactosHistorialAsignaciones)this.MemberwiseClone();
            // Entities
                         
            if (this._ContactosEntity != null)
            {
                newObject._ContactosEntity = (Entities.Contactos)((ICloneable)this._ContactosEntity).Clone();
            }
                         
            if (this._ContactoUsuariosEntity != null)
            {
                newObject._ContactoUsuariosEntity = (Entities.ContactoUsuarios)((ICloneable)this._ContactoUsuariosEntity).Clone();
            }
            
            // Colections
            
            // OriginalValue
            ContactosHistorialAsignaciones newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosHistorialAsignaciones)this.OriginalValue().MemberwiseClone();
                // Entities
                             
                if (this.OriginalValue()._ContactosEntity != null)
                {
                    newOriginalValue._ContactosEntity = (Entities.Contactos)((ICloneable)this.OriginalValue()._ContactosEntity).Clone();
                }
                             
                if (this.OriginalValue()._ContactoUsuariosEntity != null)
                {
                    newOriginalValue._ContactoUsuariosEntity = (Entities.ContactoUsuarios)((ICloneable)this.OriginalValue()._ContactoUsuariosEntity).Clone();
                }
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosHistorialAsignaciones.CompleteEntity(Entities.Contactos ContactosEntity, Entities.ContactoUsuarios ContactoUsuariosEntity)
        {
        _ContactosEntity = ContactosEntity;
_ContactoUsuariosEntity = ContactoUsuariosEntity;
        }
        
        bool IMappeableContactosHistorialAsignaciones.IsContactosEntityNull()
        {
            return (_ContactosEntity == null);
        }
        
        bool IMappeableContactosHistorialAsignaciones.IsContactoUsuariosEntityNull()
        {
            return (_ContactoUsuariosEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosHistorialAsignaciones.SetFKValuesForChilds(ContactosHistorialAsignaciones entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosHistorialAsignaciones other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosHistorialAsignaciones
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity(Entities.Contactos ContactosEntity, Entities.ContactoUsuarios ContactoUsuariosEntity);
        
        /// <summary>
        /// 
        /// </summary>
        bool IsContactosEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        bool IsContactoUsuariosEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(ContactosHistorialAsignaciones entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosHistorialAsignacionesList : ObjectList<ContactosHistorialAsignaciones>
    {
    }
}
namespace crmRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosHistorialAsignacionesListView
        : ObjectListView<Entities.ContactosHistorialAsignaciones>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesListView(Entities.ContactosHistorialAsignacionesList list): base(list)
        {
        }
    }
}


