
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 13/5/2022 - 02:18 p. m.
// This is a partial class file. The other one is PlantillasMailObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace crmRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PlantillasMailObject : BaseObject, IMappeablePlantillasMailObject, IUniqueIdentifiable, IEquatable<PlantillasMailObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public PlantillasMailObject(): base()
        {

			_IdPlantillaEmail =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public PlantillasMailObject(
			System.Int32 IdPlantillaEmail): base()
        {

			_IdPlantillaEmail = IdPlantillaEmail;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public PlantillasMailObject(
			System.Int32 IdPlantillaEmail,
			System.String Nombre,
			System.String Contenido,
			System.Boolean Activo): base()
        {

			_IdPlantillaEmail = IdPlantillaEmail;
			_Nombre = Nombre;
			_Contenido = Contenido;
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
protected System.Int32 _IdPlantillaEmail;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.String _Contenido;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activo;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdPlantillaEmail
        {
            get
            {
                return _IdPlantillaEmail;
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
        public virtual System.String Contenido
        {
            get
            {
                return _Contenido;
            }
            
            set
            {
                base.PropertyModified();
                _Contenido = value;
                
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
            PlantillasMailObject newObject;
            PlantillasMailObject newOriginalValue;

            newObject = (PlantillasMailObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (PlantillasMailObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new PlantillasMailObject OriginalValue()
        {
            return (PlantillasMailObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeablePlantillasMailObject.HydrateFields(
			System.Int32 IdPlantillaEmail,
			System.String Nombre,
			System.String Contenido,
			System.Boolean Activo)
        {
        _IdPlantillaEmail = IdPlantillaEmail;
_Nombre = Nombre;
_Contenido = Contenido;
_Activo = Activo;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeablePlantillasMailObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[4];
            _myArray[0] = _IdPlantillaEmail;
_myArray[1] = _Nombre;
_myArray[2] = _Contenido;
_myArray[3] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeablePlantillasMailObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[4];
            _myArray[0] = _IdPlantillaEmail;
_myArray[1] = _Nombre;
_myArray[2] = _Contenido;
_myArray[3] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeablePlantillasMailObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdPlantillaEmail;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeablePlantillasMailObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdPlantillaEmail = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            PlantillasMailObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdPlantillaEmail};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PlantillasMailObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeablePlantillasMailObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdPlantillaEmail, 
			System.String Nombre, 
			System.String Contenido, 
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
    public partial class PlantillasMailObjectList : ObjectList<PlantillasMailObject>
    {
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PlantillasMailObjectListView
        : ObjectListView<Objects.PlantillasMailObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public PlantillasMailObjectListView(Objects.PlantillasMailObjectList list): base(list)
        {
        }
    }
}


