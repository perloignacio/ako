
        
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 19/4/2022 - 10:03 a. m.
// This is a partial class file. The other one is ContactoHistorialAciconesEntity.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core.Exceptions;

namespace crmRules.Entities
{
    /// <summary>
    /// This class represents the ContactoHistorialAcicones entity.
    /// </summary>
    [Serializable]
    public partial class ContactoHistorialAcicones
        // : IValidable
    {
        public int IdObjeto { get; set; }
        // /// <summary>
        // /// When IValidable is implemented, this method is invoked by Gateway before Insert or Update to validate Object.
        // /// </summary>
        // public void Validate()
        // {
        //     //Example:
        //     if (string.IsNullOrEmpty(this.Name)) throw new RuleValidationException("Name can't be null");
        // }
    }

    /// <summary>
    /// This class represents a collection of ContactoHistorialAcicones entity.
    /// </summary>
    public partial class ContactoHistorialAciconesList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         //public override System.Data.DataSet ToDataSet()
         //{
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<ContactoHistorialAcicones, ContactoHistorialAciconesList> Exporter = new ObjectListHelper<ContactoHistorialAcicones, ContactoHistorialAciconesList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         //}
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of ContactoHistorialAcicones entities.
    /// </summary>
    public partial class ContactoHistorialAciconesListView
    {
    }
}


