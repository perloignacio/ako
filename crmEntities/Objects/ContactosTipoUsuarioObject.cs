
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 19/4/2022 - 10:01 a. m.
// This is a partial class file. The other one is ContactosTipoUsuarioObject.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core;
using Cooperator.Framework.Core.Exceptions;

namespace crmRules.Objects
{
    /// <summary>
    /// This class represents a Object of ContactosTipoUsuario table.
    /// </summary>
    [Serializable]
    public partial class ContactosTipoUsuarioObject
        // : IValidable
    {

        /// <summary>
        /// Called from class constructor.
        /// </summary>
        protected override void Initialize()
        {
        }

        // /// <summary>
        // /// Called after parameterized constructor. 
        // /// </summary>
        // protected override void Initialized()
        // {       
        // //Warnging: This method is only called by parameterized contructors.
        // }

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
    /// This class represents a record set of ContactosTipoUsuario table.
    /// </summary>
    public partial class ContactosTipoUsuarioObjectList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         // public override System.Data.DataSet ToDataSet()
         // {
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<ContactosTipoUsuarioObject, ContactosTipoUsuarioObjectList> Exporter = new ObjectListHelper<ContactosTipoUsuarioObject, ContactosTipoUsuarioObjectList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         // }
    }
}

namespace crmRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of ContactosTipoUsuarioObjects.
    /// </summary>
    public partial class ContactosTipoUsuarioObjectListView
    {
    }
}


