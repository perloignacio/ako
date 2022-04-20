
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 19/4/2022 - 03:39 p. m.
// This is a partial class file. The other one is ContactosDireccionesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace crmRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosDireccionesObject : BaseObject, IMappeableContactosDireccionesObject, IUniqueIdentifiable, IEquatable<ContactosDireccionesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosDireccionesObject(): base()
        {

			_IdContactoDireccion =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosDireccionesObject(
			System.Int32 IdContactoDireccion): base()
        {

			_IdContactoDireccion = IdContactoDireccion;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ContactosDireccionesObject(
			System.Int32 IdContactoDireccion,
			System.Int32 IdContacto,
			System.String Nombre,
			System.String Calle,
			System.String Nro,
			System.String Localidad,
			System.String Provincia,
			System.Boolean Activo): base()
        {

			_IdContactoDireccion = IdContactoDireccion;
			_IdContacto = IdContacto;
			_Nombre = Nombre;
			_Calle = Calle;
			_Nro = Nro;
			_Localidad = Localidad;
			_Provincia = Provincia;
			_Activo = Activo;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdContactoDireccion;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdContacto;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.String _Calle;
/// <summary>
/// 
/// </summary>
protected System.String _Nro;
/// <summary>
/// 
/// </summary>
protected System.String _Localidad;
/// <summary>
/// 
/// </summary>
protected System.String _Provincia;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activo;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdContactoDireccion
        {
            get
            {
                return _IdContactoDireccion;
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
        public virtual System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            
            set
            {
                base.PropertyModified();
                _Nombre = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Calle
        {
            get
            {
                return _Calle;
            }
            
            set
            {
                base.PropertyModified();
                _Calle = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Nro
        {
            get
            {
                return _Nro;
            }
            
            set
            {
                base.PropertyModified();
                _Nro = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Localidad
        {
            get
            {
                return _Localidad;
            }
            
            set
            {
                base.PropertyModified();
                _Localidad = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Provincia
        {
            get
            {
                return _Provincia;
            }
            
            set
            {
                base.PropertyModified();
                _Provincia = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean Activo
        {
            get
            {
                return _Activo;
            }
            
            set
            {
                base.PropertyModified();
                _Activo = value;
                
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
            ContactosDireccionesObject newObject;
            ContactosDireccionesObject newOriginalValue;

            newObject = (ContactosDireccionesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosDireccionesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ContactosDireccionesObject OriginalValue()
        {
            return (ContactosDireccionesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosDireccionesObject.HydrateFields(
			System.Int32 IdContactoDireccion,
			System.Int32 IdContacto,
			System.String Nombre,
			System.String Calle,
			System.String Nro,
			System.String Localidad,
			System.String Provincia,
			System.Boolean Activo)
        {
        _IdContactoDireccion = IdContactoDireccion;
_IdContacto = IdContacto;
_Nombre = Nombre;
_Calle = Calle;
_Nro = Nro;
_Localidad = Localidad;
_Provincia = Provincia;
_Activo = Activo;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosDireccionesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[8];
            _myArray[0] = _IdContactoDireccion;
_myArray[1] = _IdContacto;
_myArray[2] = _Nombre;
if (!System.String.IsNullOrEmpty(_Calle)) _myArray[3] = _Calle;
if (!System.String.IsNullOrEmpty(_Nro)) _myArray[4] = _Nro;
if (!System.String.IsNullOrEmpty(_Localidad)) _myArray[5] = _Localidad;
if (!System.String.IsNullOrEmpty(_Provincia)) _myArray[6] = _Provincia;
_myArray[7] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosDireccionesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[8];
            _myArray[0] = _IdContactoDireccion;
_myArray[1] = _IdContacto;
_myArray[2] = _Nombre;
if (!System.String.IsNullOrEmpty(_Calle)) _myArray[3] = _Calle;
if (!System.String.IsNullOrEmpty(_Nro)) _myArray[4] = _Nro;
if (!System.String.IsNullOrEmpty(_Localidad)) _myArray[5] = _Localidad;
if (!System.String.IsNullOrEmpty(_Provincia)) _myArray[6] = _Provincia;
_myArray[7] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosDireccionesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdContactoDireccion;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosDireccionesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdContactoDireccion = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ContactosDireccionesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdContactoDireccion};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosDireccionesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosDireccionesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdContactoDireccion, 
			System.Int32 IdContacto, 
			System.String Nombre, 
			System.String Calle, 
			System.String Nro, 
			System.String Localidad, 
			System.String Provincia, 
			System.Boolean Activo);

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
    public partial class ContactosDireccionesObjectList : ObjectList<ContactosDireccionesObject>
    {
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosDireccionesObjectListView
        : ObjectListView<Objects.ContactosDireccionesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosDireccionesObjectListView(Objects.ContactosDireccionesObjectList list): base(list)
        {
        }
    }
}


