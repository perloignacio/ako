
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/5/2022 - 11:33 a. m.
// This is a partial class file. The other one is ContactosHistorialAsignacionesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace crmRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosHistorialAsignacionesObject : BaseObject, IMappeableContactosHistorialAsignacionesObject, IUniqueIdentifiable, IEquatable<ContactosHistorialAsignacionesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesObject(): base()
        {

			_IdHistorialAsignacionesContacto =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesObject(
			System.Int32 IdHistorialAsignacionesContacto): base()
        {

			_IdHistorialAsignacionesContacto = IdHistorialAsignacionesContacto;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesObject(
			System.Int32 IdHistorialAsignacionesContacto,
			System.Int32 IdContacto,
			System.Int32 IdUsuarioContacto,
			System.DateTime Fecha): base()
        {

			_IdHistorialAsignacionesContacto = IdHistorialAsignacionesContacto;
			_IdContacto = IdContacto;
			_IdUsuarioContacto = IdUsuarioContacto;
			_Fecha = Fecha;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdHistorialAsignacionesContacto;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdContacto;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdUsuarioContacto;
/// <summary>
/// 
/// </summary>
protected System.DateTime _Fecha;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdHistorialAsignacionesContacto
        {
            get
            {
                return _IdHistorialAsignacionesContacto;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdContacto
        {
            get
            {
                return _IdContacto;
            }
            
            set
            {
                base.PropertyModified();
                _IdContacto = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdUsuarioContacto
        {
            get
            {
                return _IdUsuarioContacto;
            }
            
            set
            {
                base.PropertyModified();
                _IdUsuarioContacto = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            
            set
            {
                base.PropertyModified();
                _Fecha = value;
                
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
            ContactosHistorialAsignacionesObject newObject;
            ContactosHistorialAsignacionesObject newOriginalValue;

            newObject = (ContactosHistorialAsignacionesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosHistorialAsignacionesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ContactosHistorialAsignacionesObject OriginalValue()
        {
            return (ContactosHistorialAsignacionesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosHistorialAsignacionesObject.HydrateFields(
			System.Int32 IdHistorialAsignacionesContacto,
			System.Int32 IdContacto,
			System.Int32 IdUsuarioContacto,
			System.DateTime Fecha)
        {
        _IdHistorialAsignacionesContacto = IdHistorialAsignacionesContacto;
_IdContacto = IdContacto;
_IdUsuarioContacto = IdUsuarioContacto;
_Fecha = Fecha;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosHistorialAsignacionesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[4];
            _myArray[0] = _IdHistorialAsignacionesContacto;
_myArray[1] = _IdContacto;
_myArray[2] = _IdUsuarioContacto;
_myArray[3] = _Fecha;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosHistorialAsignacionesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[4];
            _myArray[0] = _IdHistorialAsignacionesContacto;
_myArray[1] = _IdContacto;
_myArray[2] = _IdUsuarioContacto;
_myArray[3] = _Fecha;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosHistorialAsignacionesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdHistorialAsignacionesContacto;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosHistorialAsignacionesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdHistorialAsignacionesContacto = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ContactosHistorialAsignacionesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdHistorialAsignacionesContacto};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosHistorialAsignacionesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosHistorialAsignacionesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdHistorialAsignacionesContacto, 
			System.Int32 IdContacto, 
			System.Int32 IdUsuarioContacto, 
			System.DateTime Fecha);

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
    public partial class ContactosHistorialAsignacionesObjectList : ObjectList<ContactosHistorialAsignacionesObject>
    {
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosHistorialAsignacionesObjectListView
        : ObjectListView<Objects.ContactosHistorialAsignacionesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesObjectListView(Objects.ContactosHistorialAsignacionesObjectList list): base(list)
        {
        }
    }
}


