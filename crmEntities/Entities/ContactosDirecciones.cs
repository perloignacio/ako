
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 19/4/2022 - 10:01 a. m.
// This is a partial class file. The other one is ContactosDireccionesEntity.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core.Exceptions;

namespace crmRules.Entities
{
    /// <summary>
    /// This class represents the ContactosDirecciones entity.
    /// </summary>
    [Serializable]
    public partial class ContactosDirecciones
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
    /// This class represents a collection of ContactosDirecciones entity.
    /// </summary>
    public partial class ContactosDireccionesList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         //public override System.Data.DataSet ToDataSet()
         //{
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<ContactosDirecciones, ContactosDireccionesList> Exporter = new ObjectListHelper<ContactosDirecciones, ContactosDireccionesList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         //}
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of ContactosDirecciones entities.
    /// </summary>
    public partial class ContactosDireccionesListView
    {
    }
}


