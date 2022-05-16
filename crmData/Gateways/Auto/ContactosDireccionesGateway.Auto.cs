
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 13/5/2022 - 02:18 p. m.
// This is a partial class file. The other one is ContactosDireccionesGateway.cs
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

    public partial class ContactosDireccionesGateway : BaseGateway<ContactosDireccionesObject, ContactosDireccionesObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ContactosDireccionesGateway _instance;

        private ContactosDireccionesGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ContactosDireccionesGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosDireccionesGateway();
                else {
                    ContactosDireccionesGateway inst = HttpContext.Current.Items["crmRules.ContactosDireccionesGatewaySingleton"] as ContactosDireccionesGateway;
                    if (inst == null) {
                        inst = new ContactosDireccionesGateway();
                        HttpContext.Current.Items.Add("crmRules.ContactosDireccionesGatewaySingleton", inst);
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
            get { return "ContactosDirecciones"; }
        }

        protected override string RuleName
        {
            get {return typeof(ContactosDireccionesGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosDireccionesObject entity)
        {
            
            IMappeableContactosDireccionesObject ContactosDirecciones = (IMappeableContactosDireccionesObject)entity;
            ContactosDirecciones.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetString(2),
(reader.IsDBNull(3)) ? "" : reader.GetString(3),
(reader.IsDBNull(4)) ? "" : reader.GetString(4),
(reader.IsDBNull(5)) ? "" : reader.GetString(5),
(reader.IsDBNull(6)) ? "" : reader.GetString(6),
reader.GetBoolean(7),
(reader.IsDBNull(8)) ? "" : reader.GetString(8),
(reader.IsDBNull(9)) ? "" : reader.GetString(9),
(reader.IsDBNull(10)) ? "" : reader.GetString(10));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ContactosDireccionesObject entity)
        {

            IMappeableContactosDireccionesObject ContactosDirecciones = (IMappeableContactosDireccionesObject)entity;
            return ContactosDirecciones.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ContactosDireccionesObject entity)
        {

            IMappeableContactosDireccionesObject ContactosDirecciones = (IMappeableContactosDireccionesObject)entity;
            return ContactosDirecciones.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ContactosDireccionesObject entity)
        {

            IMappeableContactosDireccionesObject ContactosDirecciones = (IMappeableContactosDireccionesObject)entity;
            return ContactosDirecciones.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ContactosDireccionesObject row, object[] parameters)
        {
            ((IMappeableContactosDireccionesObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a ContactosDireccionesObject by execute a SQL Query Text
        /// </summary>
        public ContactosDireccionesObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosDireccionesObjectList by execute a SQL Query Text
        /// </summary>
        public ContactosDireccionesObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ContactosDireccionesObject by calling a Stored Procedure
        /// </summary>
        public ContactosDireccionesObject GetOne(System.Int32 IdContactoDireccion)
        {
            return base.GetOne(new ContactosDireccionesObject(IdContactoDireccion));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a ContactosDireccionesObjectList by calling a Stored Procedure
        /// </summary>
        public ContactosDireccionesObjectList GetByContactos(DbTransaction transaction,System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosDirecciones_GetByContactos", IdContacto);
        }

        /// <summary>
        /// Get a ContactosDireccionesObjectList by calling a Stored Procedure
        /// </summary>
        public ContactosDireccionesObjectList GetByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosDirecciones_GetByContactos", Contactos.Identifier());
        }

    

        

        /// <summary>
        /// Get a ContactosDireccionesObjectList by calling a Stored Procedure
        /// </summary>
        public ContactosDireccionesObjectList GetByContactos(System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosDirecciones_GetByContactos", IdContacto);
        }

        /// <summary>
        /// Get a ContactosDireccionesObjectList by calling a Stored Procedure
        /// </summary>
        public ContactosDireccionesObjectList GetByContactos(IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosDirecciones_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// Delete ContactosDirecciones
        /// </summary>
        public void Delete(System.Int32 IdContactoDireccion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosDirecciones_Delete", IdContactoDireccion);
        }

        /// <summary>
        /// Delete ContactosDirecciones
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdContactoDireccion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosDirecciones_Delete", IdContactoDireccion);
        }

            

        

        /// <summary>
        /// Delete ContactosDirecciones by Contactos
        /// </summary>
        public void DeleteByContactos(System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosDirecciones_DeleteByContactos", IdContacto);
        }

        /// <summary>
        /// Delete ContactosDirecciones by Contactos
        /// </summary>
        public void DeleteByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosDirecciones_DeleteByContactos", IdContacto);
        }

        /// <summary>
        /// Delete ContactosDirecciones by Contactos
        /// </summary>
        public void DeleteByContactos(IUniqueIdentifiable Contactos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosDirecciones_DeleteByContactos", Contactos.Identifier());
        }

        /// <summary>
        /// Delete ContactosDirecciones by Contactos
        /// </summary>
        public void DeleteByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosDirecciones_DeleteByContactos", Contactos.Identifier());
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








