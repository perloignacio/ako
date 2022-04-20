
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 19/4/2022 - 03:39 p. m.
// This is a partial class file. The other one is ContactosTipoAccionesMapper.cs
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
    public partial class ContactosTipoAccionesMapper : BaseGateway<ContactosTipoAcciones, ContactosTipoAccionesList>, IGenericGateway
    {


        #region "Singleton"

        static ContactosTipoAccionesMapper _instance;

        private ContactosTipoAccionesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosTipoAccionesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosTipoAccionesMapper();
                else {
                    ContactosTipoAccionesMapper inst = HttpContext.Current.Items["crmRules.ContactosTipoAccionesMapperSingleton"] as ContactosTipoAccionesMapper;
                    if (inst == null) {
                        inst = new ContactosTipoAccionesMapper();
                        HttpContext.Current.Items.Add("crmRules.ContactosTipoAccionesMapperSingleton", inst);
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
            
            string[] s ={"IdTipoAccionContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosTipoAcciones);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosTipoAcciones"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ContactosTipoAccionesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosTipoAcciones entity)
        {
            
            IMappeableContactosTipoAccionesObject ContactosTipoAcciones = (IMappeableContactosTipoAccionesObject)entity;
            ContactosTipoAcciones.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetBoolean(2));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(ContactosTipoAcciones entity)
        {

            IMappeableContactosTipoAccionesObject ContactosTipoAcciones = (IMappeableContactosTipoAccionesObject)entity;
            return ContactosTipoAcciones.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(ContactosTipoAcciones entity)
        {

            IMappeableContactosTipoAccionesObject ContactosTipoAcciones = (IMappeableContactosTipoAccionesObject)entity;
            return ContactosTipoAcciones.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(ContactosTipoAcciones entity)
        {

            IMappeableContactosTipoAccionesObject ContactosTipoAcciones = (IMappeableContactosTipoAccionesObject)entity;
            return ContactosTipoAcciones.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ContactosTipoAcciones entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableContactosTipoAccionesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(ContactosTipoAcciones entity)
        {
            
            ((IMappeableContactosTipoAcciones)entity).CompleteEntity();
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
        /// Get a ContactosTipoAcciones by execute a SQL Query Text
        /// </summary>
        public ContactosTipoAcciones GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosTipoAccionesList by execute a SQL Query Text
        /// </summary>
        public ContactosTipoAccionesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public ContactosTipoAcciones GetOne(System.Int32 IdTipoAccionContacto)
        {
            return base.GetOne(new ContactosTipoAcciones(IdTipoAccionContacto));
        }


        // GetOne By Objects and Params
            


        


        

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdTipoAccionContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosTipoAcciones_Delete", IdTipoAccionContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdTipoAccionContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosTipoAcciones_Delete", IdTipoAccionContacto);
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
    public class ContactosTipoAccionesMapperWrapper
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
        public crmRules.Mappers.ContactosTipoAccionesMapper Instance()
        {
            return crmRules.Mappers.ContactosTipoAccionesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ContactosTipoAccionesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosTipoAcciones GetOne(System.Int32 IdTipoAccionContacto) {
            return Instance().GetOne( IdTipoAccionContacto);
        }

        // GetBy Objects and Params
            

        

       

        /// <summary>
        /// Delete children for ContactosTipoAcciones
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, ContactosTipoAcciones entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        
        /// <summary>
        /// Delete ContactosTipoAcciones 
        /// </summary>
        public void Delete(System.Int32 IdTipoAccionContacto){
            Instance().Delete(IdTipoAccionContacto);
        }

        /// <summary>
        /// Delete ContactosTipoAcciones 
        /// </summary>
        public void Delete(Entities.ContactosTipoAcciones entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save ContactosTipoAcciones  
        /// </summary>
        public void Save(Entities.ContactosTipoAcciones entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosTipoAcciones 
        /// </summary>
        public void Insert(Entities.ContactosTipoAcciones entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll ContactosTipoAcciones 
        /// </summary>
        public Entities.ContactosTipoAccionesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save ContactosTipoAcciones 
        /// </summary>
        public void Save(System.Int32 IdTipoAccionContacto, System.String TipoAccion, System.Boolean Activa){
            Entities.ContactosTipoAcciones entity = Instance().GetOne(IdTipoAccionContacto);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdTipoAccionContacto", IdTipoAccionContacto));

            entity.TipoAccion = TipoAccion;
            entity.Activa = Activa;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosTipoAcciones
        /// </summary>
        public void Insert(System.String TipoAccion, System.Boolean Activa){
            Entities.ContactosTipoAcciones entity = new Entities.ContactosTipoAcciones();

            entity.TipoAccion = TipoAccion;
            entity.Activa = Activa;
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
    public partial class ContactosTipoAccionesLoader<T> : BaseLoader< T, ContactosTipoAcciones, ObjectList<T>>, IGenericGateway where T : ContactosTipoAcciones, new()
    {

        #region "Singleton"

        static ContactosTipoAccionesLoader<T> _instance;

        private ContactosTipoAccionesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosTipoAccionesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosTipoAccionesLoader<T>();
                else {
                    ContactosTipoAccionesLoader<T> inst = HttpContext.Current.Items["crmRules.ContactosTipoAccionesLoaderSingleton"] as ContactosTipoAccionesLoader<T>;
                    if (inst == null) {
                        inst = new ContactosTipoAccionesLoader<T>();
                        HttpContext.Current.Items.Add("crmRules.ContactosTipoAccionesLoaderSingleton", inst);
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
            
            string[] s ={"IdTipoAccionContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosTipoAcciones);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosTipoAcciones"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosTipoAcciones entity)
        {
            
            IMappeableContactosTipoAccionesObject ContactosTipoAcciones = (IMappeableContactosTipoAccionesObject)entity;
            ContactosTipoAcciones.HydrateFields(
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
            
            ((IMappeableContactosTipoAcciones)entity).CompleteEntity();
        }


        



        /// <summary>
        /// Get a ContactosTipoAcciones by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosTipoAccionesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdTipoAccionContacto)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosTipoAcciones_GetOne", IdTipoAccionContacto);
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





