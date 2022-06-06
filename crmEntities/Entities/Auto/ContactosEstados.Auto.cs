
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/5/2022 - 11:33 a. m.
// This is a partial class file. The other one is ContactosEstadosEntity.cs
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
    public partial class ContactosEstados : Objects.ContactosEstadosObject, IMappeableContactosEstados, IEquatable<ContactosEstados>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosEstados()
            :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosEstados(
			System.Int32 IdEstadoContacto)
            : base()
        {

			_IdEstadoContacto = IdEstadoContacto;

            
            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public ContactosEstados(
			System.Int32 IdEstadoContacto,
			System.String Nombre,
			System.Int32 Orden,
			System.Boolean Activo)
            : base()
        {

			_IdEstadoContacto = IdEstadoContacto;
			_Nombre = Nombre;
			_Orden = Orden;
			_Activo = Activo;

            
            Initialized();
        }
        
        #endregion

        #region "Fields"

        
        #endregion

        #region "Properties"
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new ContactosEstados OriginalValue()
        {
            return (ContactosEstados)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ContactosEstados newObject;            
            

            newObject = (ContactosEstados)this.MemberwiseClone();
            // Entities
            
            // Colections
            
            // OriginalValue
            ContactosEstados newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosEstados)this.OriginalValue().MemberwiseClone();
                // Entities
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosEstados.CompleteEntity()
        {
        
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosEstados.SetFKValuesForChilds(ContactosEstados entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosEstados other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosEstados
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(ContactosEstados entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosEstadosList : ObjectList<ContactosEstados>
    {
    }
}
namespace crmRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosEstadosListView
        : ObjectListView<Entities.ContactosEstados>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosEstadosListView(Entities.ContactosEstadosList list): base(list)
        {
        }
    }
}


