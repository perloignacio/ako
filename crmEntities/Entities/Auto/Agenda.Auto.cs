
        
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 29/4/2022 - 06:52 p. m.
// This is a partial class file. The other one is AgendaEntity.cs
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
    public partial class Agenda : Objects.AgendaObject, IMappeableAgenda, IEquatable<Agenda>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public Agenda()
            :base()
        {
            if (_ContactoUsuariosEntity == null) _ContactoUsuariosEntity = new Entities.ContactoUsuarios();

        }

        /// <summary>
        /// 
        /// </summary>
        public Agenda(
			System.Int32 IdContactoAgenda)
            : base()
        {

			_IdContactoAgenda = IdContactoAgenda;

            if (_ContactoUsuariosEntity == null) _ContactoUsuariosEntity = new Entities.ContactoUsuarios();

            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public Agenda(
			System.Int32 IdContactoAgenda,
			System.DateTime Fecha,
			System.DateTime FechaDesde,
			System.DateTime FechaHasta,
			System.String Asunto,
			System.String Descripcion,
			System.String Link,
			System.Nullable<System.Int32> IdContacto,
			System.Int32 IdUsuario,
			System.Boolean Activo)
            : base()
        {

			_IdContactoAgenda = IdContactoAgenda;
			_Fecha = Fecha;
			_FechaDesde = FechaDesde;
			_FechaHasta = FechaHasta;
			_Asunto = Asunto;
			_Descripcion = Descripcion;
			_Link = Link;
			_IdContacto = IdContacto;
			_IdUsuario = IdUsuario;
			_Activo = Activo;

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
                if (_ContactosEntity== null  && this.IdContacto.HasValue && ! _ContactosEntityFetched ) {
_ContactosEntityFetched = true;
Entities.Contactos _ContactosEntityTemp = new Entities.Contactos(this.IdContacto.Value); 
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
   _IdContacto = null;

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
        public new Agenda OriginalValue()
        {
            return (Agenda)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            Agenda newObject;            
            

            newObject = (Agenda)this.MemberwiseClone();
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
            Agenda newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (Agenda)this.OriginalValue().MemberwiseClone();
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
        void IMappeableAgenda.CompleteEntity(Entities.Contactos ContactosEntity, Entities.ContactoUsuarios ContactoUsuariosEntity)
        {
        _ContactosEntity = ContactosEntity;
_ContactoUsuariosEntity = ContactoUsuariosEntity;
        }
        
        bool IMappeableAgenda.IsContactosEntityNull()
        {
            return (_ContactosEntity == null);
        }
        
        bool IMappeableAgenda.IsContactoUsuariosEntityNull()
        {
            return (_ContactoUsuariosEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableAgenda.SetFKValuesForChilds(Agenda entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Agenda other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableAgenda
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
        void SetFKValuesForChilds(Agenda entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class AgendaList : ObjectList<Agenda>
    {
    }
}
namespace crmRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class AgendaListView
        : ObjectListView<Entities.Agenda>
    {
        /// <summary>
        /// 
        /// </summary>
        public AgendaListView(Entities.AgendaList list): base(list)
        {
        }
    }
}


