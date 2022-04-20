
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 19/4/2022 - 10:01 a. m.
// This is a partial class file. The other one is ContactoUsuariosEntity.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core.Exceptions;

namespace crmRules.Entities
{
    /// <summary>
    /// This class represents the ContactoUsuarios entity.
    /// </summary>
    [Serializable]
    public partial class ContactoUsuarios
        // : IValidable
    {
        public string Token { get; set; }
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
    /// This class represents a collection of ContactoUsuarios entity.
    /// </summary>
    public partial class ContactoUsuariosList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         //public override System.Data.DataSet ToDataSet()
         //{
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<ContactoUsuarios, ContactoUsuariosList> Exporter = new ObjectListHelper<ContactoUsuarios, ContactoUsuariosList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         //}
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of ContactoUsuarios entities.
    /// </summary>
    public partial class ContactoUsuariosListView
    {
    }
}

