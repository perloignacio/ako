
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 19/4/2022 - 03:39 p. m.
// This is a partial class file. The other one is ContactosTipoAccionesGateway.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using System;
using crmRules.Objects;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using Cooperator.Framework.Core;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Web;




namespace crmRules.Gateways
{

    public partial class ContactosTipoAccionesGateway : BaseGateway<ContactosTipoAccionesObject, ContactosTipoAccionesObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ContactosTipoAccionesGateway _instance;

        private ContactosTipoAccionesGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ContactosTipoAccionesGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosTipoAccionesGateway();
                else {
                    ContactosTipoAccionesGateway inst = HttpContext.Current.Items["crmRules.ContactosTipoAccionesGatewaySingleton"] as ContactosTipoAccionesGateway;
                    if (inst == null) {
                        inst = new ContactosTipoAccionesGateway();
                        HttpContext.Current.Items.Add("crmRules.ContactosTipoAccionesGatewaySingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }

        #endregion

        /// <summary>
        /// Return the mapped table name
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosTipoAcciones"; }
        }

        protected override string RuleName
        {
            get {return typeof(ContactosTipoAccionesGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosTipoAccionesObject entity)
        {
            
            IMappeableContactosTipoAccionesObject ContactosTipoAcciones = (IMappeableContactosTipoAccionesObject)entity;
            ContactosTipoAcciones.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetBoolean(2));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ContactosTipoAccionesObject entity)
        {

            IMappeableContactosTipoAccionesObject ContactosTipoAcciones = (IMappeableContactosTipoAccionesObject)entity;
            return ContactosTipoAcciones.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ContactosTipoAccionesObject entity)
        {

            IMappeableContactosTipoAccionesObject ContactosTipoAcciones = (IMappeableContactosTipoAccionesObject)entity;
            return ContactosTipoAcciones.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ContactosTipoAccionesObject entity)
        {

            IMappeableContactosTipoAccionesObject ContactosTipoAcciones = (IMappeableContactosTipoAccionesObject)entity;
            return ContactosTipoAcciones.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ContactosTipoAccionesObject row, object[] parameters)
        {
            ((IMappeableContactosTipoAccionesObject) row).UpdateObjectFromOutputParams(parameters);
            ((IObject)row).State = ObjectState.Restored;
        }

        /// <summary>
        /// StoredProceduresPrefix, for example: coop_
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        /// <summary>
        /// Get a ContactosTipoAccionesObject by execute a SQL Query Text
        /// </summary>
        public ContactosTipoAccionesObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosTipoAccionesObjectList by execute a SQL Query Text
        /// </summary>
        public ContactosTipoAccionesObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ContactosTipoAccionesObject by calling a Stored Procedure
        /// </summary>
        public ContactosTipoAccionesObject GetOne(System.Int32 IdTipoAccionContacto)
        {
            return base.GetOne(new ContactosTipoAccionesObject(IdTipoAccionContacto));
        }


        // GetBy Objects and Params
            


        

        

        /// <summary>
        /// Delete ContactosTipoAcciones
        /// </summary>
        public void Delete(System.Int32 IdTipoAccionContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosTipoAcciones_Delete", IdTipoAccionContacto);
        }

        /// <summary>
        /// Delete ContactosTipoAcciones
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdTipoAccionContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosTipoAcciones_Delete", IdTipoAccionContacto);
        }

            

        


        //Database Queries 
        



        #region IGenericGateway

        object IGenericGateway.GetOne(IUniqueIdentifiable identifier)
        {
            return base.GetOne(identifier);
        }

        object IGenericGateway.GetAll()
        {
            return base.GetAll();
        }

        object IGenericGateway.GetByParent(IUniqueIdentifiable parentEntity)
        {
            return base.GetByParent(parentEntity);
        }

        #endregion


    }

}







