
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/5/2022 - 11:33 a. m.
// This is a partial class file. The other one is ContactosTipoUsuarioObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace crmRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosTipoUsuarioObject : BaseObject, IMappeableContactosTipoUsuarioObject, IUniqueIdentifiable, IEquatable<ContactosTipoUsuarioObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoUsuarioObject(): base()
        {

			_IdTipoUsuarioContacto =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoUsuarioObject(
			System.Int32 IdTipoUsuarioContacto): base()
        {

			_IdTipoUsuarioContacto = IdTipoUsuarioContacto;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoUsuarioObject(
			System.Int32 IdTipoUsuarioContacto,
			System.String Nombre,
			System.Boolean Activo): base()
        {

			_IdTipoUsuarioContacto = IdTipoUsuarioContacto;
			_Nombre = Nombre;
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
protected System.Int32 _IdTipoUsuarioContacto;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activo;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdTipoUsuarioContacto
        {
            get
            {
                return _IdTipoUsuarioContacto;
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
            ContactosTipoUsuarioObject newObject;
            ContactosTipoUsuarioObject newOriginalValue;

            newObject = (ContactosTipoUsuarioObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosTipoUsuarioObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ContactosTipoUsuarioObject OriginalValue()
        {
            return (ContactosTipoUsuarioObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosTipoUsuarioObject.HydrateFields(
			System.Int32 IdTipoUsuarioContacto,
			System.String Nombre,
			System.Boolean Activo)
        {
        _IdTipoUsuarioContacto = IdTipoUsuarioContacto;
_Nombre = Nombre;
_Activo = Activo;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosTipoUsuarioObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[3];
            _myArray[0] = _IdTipoUsuarioContacto;
_myArray[1] = _Nombre;
_myArray[2] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosTipoUsuarioObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[3];
            _myArray[0] = _IdTipoUsuarioContacto;
_myArray[1] = _Nombre;
_myArray[2] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosTipoUsuarioObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdTipoUsuarioContacto;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosTipoUsuarioObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdTipoUsuarioContacto = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ContactosTipoUsuarioObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdTipoUsuarioContacto};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosTipoUsuarioObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosTipoUsuarioObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdTipoUsuarioContacto, 
			System.String Nombre, 
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
    public partial class ContactosTipoUsuarioObjectList : ObjectList<ContactosTipoUsuarioObject>
    {
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosTipoUsuarioObjectListView
        : ObjectListView<Objects.ContactosTipoUsuarioObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoUsuarioObjectListView(Objects.ContactosTipoUsuarioObjectList list): base(list)
        {
        }
    }
}


