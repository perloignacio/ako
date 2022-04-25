
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/4/2022 - 03:14 p. m.
// This is a partial class file. The other one is ContactosHistorialEstadoEntity.cs
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
    public partial class ContactosHistorialEstado : Objects.ContactosHistorialEstadoObject, IMappeableContactosHistorialEstado, IEquatable<ContactosHistorialEstado>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstado()
            :base()
        {
            if (_ContactosEntity == null) _ContactosEntity = new Entities.Contactos();
if (_ContactosEstadosEntity == null) _ContactosEstadosEntity = new Entities.ContactosEstados();
if (_ContactoUsuariosEntity == null) _ContactoUsuariosEntity = new Entities.ContactoUsuarios();

        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstado(
			System.Int32 IdHistorialEstadoContacto)
            : base()
        {

			_IdHistorialEstadoContacto = IdHistorialEstadoContacto;

            if (_ContactosEntity == null) _ContactosEntity = new Entities.Contactos();
if (_ContactosEstadosEntity == null) _ContactosEstadosEntity = new Entities.ContactosEstados();
if (_ContactoUsuariosEntity == null) _ContactoUsuariosEntity = new Entities.ContactoUsuarios();

            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstado(
			System.Int32 IdHistorialEstadoContacto,
			System.Int32 IdEstadoContacto,
			System.Int32 IdContacto,
			System.Int32 IdUsuarioContacto,
			System.DateTime Fecha)
            : base()
        {

			_IdHistorialEstadoContacto = IdHistorialEstadoContacto;
			_IdEstadoContacto = IdEstadoContacto;
			_IdContacto = IdContacto;
			_IdUsuarioContacto = IdUsuarioContacto;
			_Fecha = Fecha;

            if (_ContactosEntity == null) _ContactosEntity = new Entities.Contactos();
if (_ContactosEstadosEntity == null) _ContactosEstadosEntity = new Entities.ContactosEstados();
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
protected Entities.ContactosEstados _ContactosEstadosEntity;
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
        
bool _ContactosEstadosEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.ContactosEstados ContactosEstadosEntity
        {
            get
            {
                if (_ContactosEstadosEntity== null  && ! _ContactosEstadosEntityFetched ) {
_ContactosEstadosEntityFetched = true;
Entities.ContactosEstados _ContactosEstadosEntityTemp = new Entities.ContactosEstados(this.IdEstadoContacto); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.ContactosEstados));
 _ContactosEstadosEntity = lazyProvider.GetEntity(typeof(Entities.ContactosEstados), _ContactosEstadosEntityTemp) as Entities.ContactosEstados;
}

                return _ContactosEstadosEntity;
            }
            set
            {
                base.PropertyModified();
                _ContactosEstadosEntity = value;
                if (value != null) {
   _IdEstadoContacto = value.IdEstadoContacto;

} else {
   _IdEstadoContacto = System.Int32.MinValue;

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
        public new ContactosHistorialEstado OriginalValue()
        {
            return (ContactosHistorialEstado)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ContactosHistorialEstado newObject;            
            

            newObject = (ContactosHistorialEstado)this.MemberwiseClone();
            // Entities
                         
            if (this._ContactosEntity != null)
            {
                newObject._ContactosEntity = (Entities.Contactos)((ICloneable)this._ContactosEntity).Clone();
            }
                         
            if (this._ContactosEstadosEntity != null)
            {
                newObject._ContactosEstadosEntity = (Entities.ContactosEstados)((ICloneable)this._ContactosEstadosEntity).Clone();
            }
                         
            if (this._ContactoUsuariosEntity != null)
            {
                newObject._ContactoUsuariosEntity = (Entities.ContactoUsuarios)((ICloneable)this._ContactoUsuariosEntity).Clone();
            }
            
            // Colections
            
            // OriginalValue
            ContactosHistorialEstado newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosHistorialEstado)this.OriginalValue().MemberwiseClone();
                // Entities
                             
                if (this.OriginalValue()._ContactosEntity != null)
                {
                    newOriginalValue._ContactosEntity = (Entities.Contactos)((ICloneable)this.OriginalValue()._ContactosEntity).Clone();
                }
                             
                if (this.OriginalValue()._ContactosEstadosEntity != null)
                {
                    newOriginalValue._ContactosEstadosEntity = (Entities.ContactosEstados)((ICloneable)this.OriginalValue()._ContactosEstadosEntity).Clone();
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
        void IMappeableContactosHistorialEstado.CompleteEntity(Entities.Contactos ContactosEntity, Entities.ContactosEstados ContactosEstadosEntity, Entities.ContactoUsuarios ContactoUsuariosEntity)
        {
        _ContactosEntity = ContactosEntity;
_ContactosEstadosEntity = ContactosEstadosEntity;
_ContactoUsuariosEntity = ContactoUsuariosEntity;
        }
        
        bool IMappeableContactosHistorialEstado.IsContactosEntityNull()
        {
            return (_ContactosEntity == null);
        }
        
        bool IMappeableContactosHistorialEstado.IsContactosEstadosEntityNull()
        {
            return (_ContactosEstadosEntity == null);
        }
        
        bool IMappeableContactosHistorialEstado.IsContactoUsuariosEntityNull()
        {
            return (_ContactoUsuariosEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosHistorialEstado.SetFKValuesForChilds(ContactosHistorialEstado entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosHistorialEstado other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosHistorialEstado
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity(Entities.Contactos ContactosEntity, Entities.ContactosEstados ContactosEstadosEntity, Entities.ContactoUsuarios ContactoUsuariosEntity);
        
        /// <summary>
        /// 
        /// </summary>
        bool IsContactosEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        bool IsContactosEstadosEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        bool IsContactoUsuariosEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(ContactosHistorialEstado entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosHistorialEstadoList : ObjectList<ContactosHistorialEstado>
    {
    }
}
namespace crmRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosHistorialEstadoListView
        : ObjectListView<Entities.ContactosHistorialEstado>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoListView(Entities.ContactosHistorialEstadoList list): base(list)
        {
        }
    }
}


