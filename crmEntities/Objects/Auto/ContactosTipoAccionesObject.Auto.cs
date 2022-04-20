
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 19/4/2022 - 03:39 p. m.
// This is a partial class file. The other one is ContactosTipoAccionesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace crmRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosTipoAccionesObject : BaseObject, IMappeableContactosTipoAccionesObject, IUniqueIdentifiable, IEquatable<ContactosTipoAccionesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoAccionesObject(): base()
        {

			_IdTipoAccionContacto =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoAccionesObject(
			System.Int32 IdTipoAccionContacto): base()
        {

			_IdTipoAccionContacto = IdTipoAccionContacto;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoAccionesObject(
			System.Int32 IdTipoAccionContacto,
			System.String TipoAccion,
			System.Boolean Activa): base()
        {

			_IdTipoAccionContacto = IdTipoAccionContacto;
			_TipoAccion = TipoAccion;
			_Activa = Activa;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdTipoAccionContacto;
/// <summary>
/// 
/// </summary>
protected System.String _TipoAccion;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activa;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdTipoAccionContacto
        {
            get
            {
                return _IdTipoAccionContacto;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String TipoAccion
        {
            get
            {
                return _TipoAccion;
            }
            
            set
            {
                base.PropertyModified();
                _TipoAccion = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean Activa
        {
            get
            {
                return _Activa;
            }
            
            set
            {
                base.PropertyModified();
                _Activa = value;
                
            }
            
        }
        
        #endregion

        
            
                
        /// <summary>
        /// 
        /// </summary>
        protected override void SetOriginalValue()
        {
            base._OriginalValue = (IObject) this.MemberwiseClone();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ContactosTipoAccionesObject newObject;
            ContactosTipoAccionesObject newOriginalValue;

            newObject = (ContactosTipoAccionesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosTipoAccionesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ContactosTipoAccionesObject OriginalValue()
        {
            return (ContactosTipoAccionesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosTipoAccionesObject.HydrateFields(
			System.Int32 IdTipoAccionContacto,
			System.String TipoAccion,
			System.Boolean Activa)
        {
        _IdTipoAccionContacto = IdTipoAccionContacto;
_TipoAccion = TipoAccion;
_Activa = Activa;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosTipoAccionesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[3];
            _myArray[0] = _IdTipoAccionContacto;
_myArray[1] = _TipoAccion;
_myArray[2] = _Activa;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosTipoAccionesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[3];
            _myArray[0] = _IdTipoAccionContacto;
_myArray[1] = _TipoAccion;
_myArray[2] = _Activa;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosTipoAccionesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdTipoAccionContacto;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosTipoAccionesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdTipoAccionContacto = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ContactosTipoAccionesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdTipoAccionContacto};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosTipoAccionesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosTipoAccionesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdTipoAccionContacto, 
			System.String TipoAccion, 
			System.Boolean Activa);

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForInsert();

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForUpdate();

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForDelete();

        /// <summary>
        /// 
        /// </summary>
        void UpdateObjectFromOutputParams(object[] parameters);
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosTipoAccionesObjectList : ObjectList<ContactosTipoAccionesObject>
    {
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosTipoAccionesObjectListView
        : ObjectListView<Objects.ContactosTipoAccionesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoAccionesObjectListView(Objects.ContactosTipoAccionesObjectList list): base(list)
        {
        }
    }
}

