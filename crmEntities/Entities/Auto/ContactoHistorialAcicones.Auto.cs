
        
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/4/2022 - 03:14 p. m.
// This is a partial class file. The other one is ContactoHistorialAciconesEntity.cs
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
    public partial class ContactoHistorialAcicones : Objects.ContactoHistorialAciconesObject, IMappeableContactoHistorialAcicones, IEquatable<ContactoHistorialAcicones>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactoHistorialAcicones()
            :base()
        {
            if (_ContactosEntity == null) _ContactosEntity = new Entities.Contactos();
if (_ContactosTipoAccionesEntity == null) _ContactosTipoAccionesEntity = new Entities.ContactosTipoAcciones();
if (_ContactoUsuariosEntity == null) _ContactoUsuariosEntity = new Entities.ContactoUsuarios();

        }

        /// <summary>
        /// 
        /// </summary>
        public ContactoHistorialAcicones(
			System.Int32 IdHistorialAcciones)
            : base()
        {

			_IdHistorialAcciones = IdHistorialAcciones;

            if (_ContactosEntity == null) _ContactosEntity = new Entities.Contactos();
if (_ContactosTipoAccionesEntity == null) _ContactosTipoAccionesEntity = new Entities.ContactosTipoAcciones();
if (_ContactoUsuariosEntity == null) _ContactoUsuariosEntity = new Entities.ContactoUsuarios();

            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public ContactoHistorialAcicones(
			System.Int32 IdHistorialAcciones,
			System.Int32 IdTipoAccion,
			System.String Accion,
			System.Int32 IdContacto,
			System.Int32 IdUsuario,
			System.DateTime Fecha,
			System.Boolean Activo)
            : base()
        {

			_IdHistorialAcciones = IdHistorialAcciones;
			_IdTipoAccion = IdTipoAccion;
			_Accion = Accion;
			_IdContacto = IdContacto;
			_IdUsuario = IdUsuario;
			_Fecha = Fecha;
			_Activo = Activo;

            if (_ContactosEntity == null) _ContactosEntity = new Entities.Contactos();
if (_ContactosTipoAccionesEntity == null) _ContactosTipoAccionesEntity = new Entities.ContactosTipoAcciones();
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
protected Entities.ContactosTipoAcciones _ContactosTipoAccionesEntity;
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
        
bool _ContactosTipoAccionesEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.ContactosTipoAcciones ContactosTipoAccionesEntity
        {
            get
            {
                if (_ContactosTipoAccionesEntity== null  && ! _ContactosTipoAccionesEntityFetched ) {
_ContactosTipoAccionesEntityFetched = true;
Entities.ContactosTipoAcciones _ContactosTipoAccionesEntityTemp = new Entities.ContactosTipoAcciones(this.IdTipoAccion); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.ContactosTipoAcciones));
 _ContactosTipoAccionesEntity = lazyProvider.GetEntity(typeof(Entities.ContactosTipoAcciones), _ContactosTipoAccionesEntityTemp) as Entities.ContactosTipoAcciones;
}

                return _ContactosTipoAccionesEntity;
            }
            set
            {
                base.PropertyModified();
                _ContactosTipoAccionesEntity = value;
                if (value != null) {
   _IdTipoAccion = value.IdTipoAccionContacto;

} else {
   _IdTipoAccion = System.Int32.MinValue;

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
Entities.ContactoUsuarios _ContactoUsuariosEntityTemp = new Entities.ContactoUsuarios(this.IdUsuario); 
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
   _IdUsuario = value.IdUsuario;

} else {
   _IdUsuario = System.Int32.MinValue;

}

            }
        }
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new ContactoHistorialAcicones OriginalValue()
        {
            return (ContactoHistorialAcicones)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ContactoHistorialAcicones newObject;            
            

            newObject = (ContactoHistorialAcicones)this.MemberwiseClone();
            // Entities
                         
            if (this._ContactosEntity != null)
            {
                newObject._ContactosEntity = (Entities.Contactos)((ICloneable)this._ContactosEntity).Clone();
            }
                         
            if (this._ContactosTipoAccionesEntity != null)
            {
                newObject._ContactosTipoAccionesEntity = (Entities.ContactosTipoAcciones)((ICloneable)this._ContactosTipoAccionesEntity).Clone();
            }
                         
            if (this._ContactoUsuariosEntity != null)
            {
                newObject._ContactoUsuariosEntity = (Entities.ContactoUsuarios)((ICloneable)this._ContactoUsuariosEntity).Clone();
            }
            
            // Colections
            
            // OriginalValue
            ContactoHistorialAcicones newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactoHistorialAcicones)this.OriginalValue().MemberwiseClone();
                // Entities
                             
                if (this.OriginalValue()._ContactosEntity != null)
                {
                    newOriginalValue._ContactosEntity = (Entities.Contactos)((ICloneable)this.OriginalValue()._ContactosEntity).Clone();
                }
                             
                if (this.OriginalValue()._ContactosTipoAccionesEntity != null)
                {
                    newOriginalValue._ContactosTipoAccionesEntity = (Entities.ContactosTipoAcciones)((ICloneable)this.OriginalValue()._ContactosTipoAccionesEntity).Clone();
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
        void IMappeableContactoHistorialAcicones.CompleteEntity(Entities.Contactos ContactosEntity, Entities.ContactosTipoAcciones ContactosTipoAccionesEntity, Entities.ContactoUsuarios ContactoUsuariosEntity)
        {
        _ContactosEntity = ContactosEntity;
_ContactosTipoAccionesEntity = ContactosTipoAccionesEntity;
_ContactoUsuariosEntity = ContactoUsuariosEntity;
        }
        
        bool IMappeableContactoHistorialAcicones.IsContactosEntityNull()
        {
            return (_ContactosEntity == null);
        }
        
        bool IMappeableContactoHistorialAcicones.IsContactosTipoAccionesEntityNull()
        {
            return (_ContactosTipoAccionesEntity == null);
        }
        
        bool IMappeableContactoHistorialAcicones.IsContactoUsuariosEntityNull()
        {
            return (_ContactoUsuariosEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactoHistorialAcicones.SetFKValuesForChilds(ContactoHistorialAcicones entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactoHistorialAcicones other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactoHistorialAcicones
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity(Entities.Contactos ContactosEntity, Entities.ContactosTipoAcciones ContactosTipoAccionesEntity, Entities.ContactoUsuarios ContactoUsuariosEntity);
        
        /// <summary>
        /// 
        /// </summary>
        bool IsContactosEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        bool IsContactosTipoAccionesEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        bool IsContactoUsuariosEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(ContactoHistorialAcicones entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ContactoHistorialAciconesList : ObjectList<ContactoHistorialAcicones>
    {
    }
}
namespace crmRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ContactoHistorialAciconesListView
        : ObjectListView<Entities.ContactoHistorialAcicones>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactoHistorialAciconesListView(Entities.ContactoHistorialAciconesList list): base(list)
        {
        }
    }
}


