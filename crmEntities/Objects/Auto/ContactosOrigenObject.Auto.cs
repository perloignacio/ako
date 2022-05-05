
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 29/4/2022 - 06:52 p. m.
// This is a partial class file. The other one is ContactosOrigenObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace crmRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosOrigenObject : BaseObject, IMappeableContactosOrigenObject, IUniqueIdentifiable, IEquatable<ContactosOrigenObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosOrigenObject(): base()
        {

			_IdOrigen =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosOrigenObject(
			System.Int32 IdOrigen): base()
        {

			_IdOrigen = IdOrigen;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ContactosOrigenObject(
			System.Int32 IdOrigen,
			System.String Nombre,
			System.Boolean Activo): base()
        {

			_IdOrigen = IdOrigen;
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
protected System.Int32 _IdOrigen;
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
        public virtual System.Int32 IdOrigen
        {
            get
            {
                return _IdOrigen;
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
            ContactosOrigenObject newObject;
            ContactosOrigenObject newOriginalValue;

            newObject = (ContactosOrigenObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosOrigenObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ContactosOrigenObject OriginalValue()
        {
            return (ContactosOrigenObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosOrigenObject.HydrateFields(
			System.Int32 IdOrigen,
			System.String Nombre,
			System.Boolean Activo)
        {
        _IdOrigen = IdOrigen;
_Nombre = Nombre;
_Activo = Activo;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosOrigenObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[3];
            _myArray[0] = _IdOrigen;
_myArray[1] = _Nombre;
_myArray[2] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosOrigenObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[3];
            _myArray[0] = _IdOrigen;
_myArray[1] = _Nombre;
_myArray[2] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableContactosOrigenObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdOrigen;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosOrigenObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdOrigen = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ContactosOrigenObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdOrigen};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosOrigenObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosOrigenObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdOrigen, 
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
    public partial class ContactosOrigenObjectList : ObjectList<ContactosOrigenObject>
    {
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosOrigenObjectListView
        : ObjectListView<Objects.ContactosOrigenObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosOrigenObjectListView(Objects.ContactosOrigenObjectList list): base(list)
        {
        }
    }
}


