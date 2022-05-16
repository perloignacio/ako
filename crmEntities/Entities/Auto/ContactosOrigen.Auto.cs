
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 13/5/2022 - 02:18 p. m.
// This is a partial class file. The other one is ContactosOrigenEntity.cs
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
    public partial class ContactosOrigen : Objects.ContactosOrigenObject, IMappeableContactosOrigen, IEquatable<ContactosOrigen>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ContactosOrigen()
            :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosOrigen(
			System.Int32 IdOrigen)
            : base()
        {

			_IdOrigen = IdOrigen;

            
            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public ContactosOrigen(
			System.Int32 IdOrigen,
			System.String Nombre,
			System.Boolean Activo)
            : base()
        {

			_IdOrigen = IdOrigen;
			_Nombre = Nombre;
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
        public new ContactosOrigen OriginalValue()
        {
            return (ContactosOrigen)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ContactosOrigen newObject;            
            

            newObject = (ContactosOrigen)this.MemberwiseClone();
            // Entities
            
            // Colections
            
            // OriginalValue
            ContactosOrigen newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ContactosOrigen)this.OriginalValue().MemberwiseClone();
                // Entities
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosOrigen.CompleteEntity()
        {
        
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableContactosOrigen.SetFKValuesForChilds(ContactosOrigen entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContactosOrigen other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableContactosOrigen
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(ContactosOrigen entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosOrigenList : ObjectList<ContactosOrigen>
    {
    }
}
namespace crmRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ContactosOrigenListView
        : ObjectListView<Entities.ContactosOrigen>
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactosOrigenListView(Entities.ContactosOrigenList list): base(list)
        {
        }
    }
}


