
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 13/5/2022 - 02:18 p. m.
// This is a partial class file. The other one is ContactosOrigenMapper.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using System;
using crmRules.Entities;
using crmRules.Objects;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using Cooperator.Framework.Core;
using System.Data.Common;
using System.Reflection;
using System.Web;
using System.Data;

namespace crmRules.Mappers
{

    
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosOrigenMapper : BaseGateway<ContactosOrigen, ContactosOrigenList>, IGenericGateway
    {


        #region "Singleton"

        static ContactosOrigenMapper _instance;

        private ContactosOrigenMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosOrigenMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosOrigenMapper();
                else {
                    ContactosOrigenMapper inst = HttpContext.Current.Items["crmRules.ContactosOrigenMapperSingleton"] as ContactosOrigenMapper;
                    if (inst == null) {
                        inst = new ContactosOrigenMapper();
                        HttpContext.Current.Items.Add("crmRules.ContactosOrigenMapperSingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            
            string[] s ={"IdOrigen"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosOrigen);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosOrigen"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ContactosOrigenMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosOrigen entity)
        {
            
            IMappeableContactosOrigenObject ContactosOrigen = (IMappeableContactosOrigenObject)entity;
            ContactosOrigen.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetBoolean(2));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(ContactosOrigen entity)
        {

            IMappeableContactosOrigenObject ContactosOrigen = (IMappeableContactosOrigenObject)entity;
            return ContactosOrigen.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(ContactosOrigen entity)
        {

            IMappeableContactosOrigenObject ContactosOrigen = (IMappeableContactosOrigenObject)entity;
            return ContactosOrigen.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(ContactosOrigen entity)
        {

            IMappeableContactosOrigenObject ContactosOrigen = (IMappeableContactosOrigenObject)entity;
            return ContactosOrigen.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ContactosOrigen entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableContactosOrigenObject) entity).UpdateObjectFromOutputParams(parameters);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        


        

        /// <summary>
        /// Complete the aggregations for this entity. 
        /// </summary>
        protected override void CompleteEntity(ContactosOrigen entity)
        {
            
            ((IMappeableContactosOrigen)entity).CompleteEntity();
        }


        # region CRUD Operations
        

        # endregion

        /// <summary>
        /// Delete children for this entity
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, IUniqueIdentifiable entity)
        {
                        
        }


          





        /// <summary>
        /// Get a ContactosOrigen by execute a SQL Query Text
        /// </summary>
        public ContactosOrigen GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosOrigenList by execute a SQL Query Text
        /// </summary>
        public ContactosOrigenList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public ContactosOrigen GetOne(System.Int32 IdOrigen)
        {
            return base.GetOne(new ContactosOrigen(IdOrigen));
        }


        // GetOne By Objects and Params
            


        


        

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdOrigen)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosOrigen_Delete", IdOrigen);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdOrigen)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosOrigen_Delete", IdOrigen);
        }


        // Delete By Objects and Params
            



        


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

namespace crmRules.Wrappers
{
    /// <summary>
    /// 
    /// </summary>
    public class ContactosOrigenMapperWrapper
    {

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            return Instance().GetPKPropertiesNames();
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return Instance().GetMappingType();
        }



        /// <summary>
        /// 
        /// </summary>
        public crmRules.Mappers.ContactosOrigenMapper Instance()
        {
            return crmRules.Mappers.ContactosOrigenMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ContactosOrigenEntity by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosOrigen GetOne(System.Int32 IdOrigen) {
            return Instance().GetOne( IdOrigen);
        }

        // GetBy Objects and Params
            

        

       

        /// <summary>
        /// Delete children for ContactosOrigen
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, ContactosOrigen entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        
        /// <summary>
        /// Delete ContactosOrigen 
        /// </summary>
        public void Delete(System.Int32 IdOrigen){
            Instance().Delete(IdOrigen);
        }

        /// <summary>
        /// Delete ContactosOrigen 
        /// </summary>
        public void Delete(Entities.ContactosOrigen entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save ContactosOrigen  
        /// </summary>
        public void Save(Entities.ContactosOrigen entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosOrigen 
        /// </summary>
        public void Insert(Entities.ContactosOrigen entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll ContactosOrigen 
        /// </summary>
        public Entities.ContactosOrigenList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save ContactosOrigen 
        /// </summary>
        public void Save(System.Int32 IdOrigen, System.String Nombre, System.Boolean Activo){
            Entities.ContactosOrigen entity = Instance().GetOne(IdOrigen);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdOrigen", IdOrigen));

            entity.Nombre = Nombre;
            entity.Activo = Activo;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosOrigen
        /// </summary>
        public void Insert(System.String Nombre, System.Boolean Activo){
            Entities.ContactosOrigen entity = new Entities.ContactosOrigen();

            entity.Nombre = Nombre;
            entity.Activo = Activo;
            Instance().Insert(entity);
        }


        //Database Queries 
        


    }
}





namespace crmRules.Loaders
{

    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosOrigenLoader<T> : BaseLoader< T, ContactosOrigen, ObjectList<T>>, IGenericGateway where T : ContactosOrigen, new()
    {

        #region "Singleton"

        static ContactosOrigenLoader<T> _instance;

        private ContactosOrigenLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosOrigenLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosOrigenLoader<T>();
                else {
                    ContactosOrigenLoader<T> inst = HttpContext.Current.Items["crmRules.ContactosOrigenLoaderSingleton"] as ContactosOrigenLoader<T>;
                    if (inst == null) {
                        inst = new ContactosOrigenLoader<T>();
                        HttpContext.Current.Items.Add("crmRules.ContactosOrigenLoaderSingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            
            string[] s ={"IdOrigen"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosOrigen);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosOrigen"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosOrigen entity)
        {
            
            IMappeableContactosOrigenObject ContactosOrigen = (IMappeableContactosOrigenObject)entity;
            ContactosOrigen.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetBoolean(2));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        
    

        

        /// <summary>
        /// Complete the aggregations for this entity. 
        /// </summary>
        protected override void CompleteEntity(T entity)
        {
            
            ((IMappeableContactosOrigen)entity).CompleteEntity();
        }


        



        /// <summary>
        /// Get a ContactosOrigen by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosOrigenList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdOrigen)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosOrigen_GetOne", IdOrigen);
        }


        // GetOne By Objects and Params
            


        


        

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





