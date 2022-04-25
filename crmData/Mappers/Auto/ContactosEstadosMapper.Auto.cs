
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/4/2022 - 03:14 p. m.
// This is a partial class file. The other one is ContactosEstadosMapper.cs
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
    public partial class ContactosEstadosMapper : BaseGateway<ContactosEstados, ContactosEstadosList>, IGenericGateway
    {


        #region "Singleton"

        static ContactosEstadosMapper _instance;

        private ContactosEstadosMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosEstadosMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosEstadosMapper();
                else {
                    ContactosEstadosMapper inst = HttpContext.Current.Items["crmRules.ContactosEstadosMapperSingleton"] as ContactosEstadosMapper;
                    if (inst == null) {
                        inst = new ContactosEstadosMapper();
                        HttpContext.Current.Items.Add("crmRules.ContactosEstadosMapperSingleton", inst);
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
            
            string[] s ={"IdEstadoContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosEstados);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosEstados"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ContactosEstadosMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosEstados entity)
        {
            
            IMappeableContactosEstadosObject ContactosEstados = (IMappeableContactosEstadosObject)entity;
            ContactosEstados.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetInt32(2),
reader.GetBoolean(3));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(ContactosEstados entity)
        {

            IMappeableContactosEstadosObject ContactosEstados = (IMappeableContactosEstadosObject)entity;
            return ContactosEstados.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(ContactosEstados entity)
        {

            IMappeableContactosEstadosObject ContactosEstados = (IMappeableContactosEstadosObject)entity;
            return ContactosEstados.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(ContactosEstados entity)
        {

            IMappeableContactosEstadosObject ContactosEstados = (IMappeableContactosEstadosObject)entity;
            return ContactosEstados.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ContactosEstados entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableContactosEstadosObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(ContactosEstados entity)
        {
            
            ((IMappeableContactosEstados)entity).CompleteEntity();
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
        /// Get a ContactosEstados by execute a SQL Query Text
        /// </summary>
        public ContactosEstados GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosEstadosList by execute a SQL Query Text
        /// </summary>
        public ContactosEstadosList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public ContactosEstados GetOne(System.Int32 IdEstadoContacto)
        {
            return base.GetOne(new ContactosEstados(IdEstadoContacto));
        }


        // GetOne By Objects and Params
            


        


        

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdEstadoContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosEstados_Delete", IdEstadoContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdEstadoContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosEstados_Delete", IdEstadoContacto);
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
    public class ContactosEstadosMapperWrapper
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
        public crmRules.Mappers.ContactosEstadosMapper Instance()
        {
            return crmRules.Mappers.ContactosEstadosMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ContactosEstadosEntity by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosEstados GetOne(System.Int32 IdEstadoContacto) {
            return Instance().GetOne( IdEstadoContacto);
        }

        // GetBy Objects and Params
            

        

       

        /// <summary>
        /// Delete children for ContactosEstados
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, ContactosEstados entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        
        /// <summary>
        /// Delete ContactosEstados 
        /// </summary>
        public void Delete(System.Int32 IdEstadoContacto){
            Instance().Delete(IdEstadoContacto);
        }

        /// <summary>
        /// Delete ContactosEstados 
        /// </summary>
        public void Delete(Entities.ContactosEstados entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save ContactosEstados  
        /// </summary>
        public void Save(Entities.ContactosEstados entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosEstados 
        /// </summary>
        public void Insert(Entities.ContactosEstados entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll ContactosEstados 
        /// </summary>
        public Entities.ContactosEstadosList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save ContactosEstados 
        /// </summary>
        public void Save(System.Int32 IdEstadoContacto, System.String Nombre, System.Int32 Orden, System.Boolean Activo){
            Entities.ContactosEstados entity = Instance().GetOne(IdEstadoContacto);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdEstadoContacto", IdEstadoContacto));

            entity.Nombre = Nombre;
            entity.Orden = Orden;
            entity.Activo = Activo;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosEstados
        /// </summary>
        public void Insert(System.String Nombre, System.Int32 Orden, System.Boolean Activo){
            Entities.ContactosEstados entity = new Entities.ContactosEstados();

            entity.Nombre = Nombre;
            entity.Orden = Orden;
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
    public partial class ContactosEstadosLoader<T> : BaseLoader< T, ContactosEstados, ObjectList<T>>, IGenericGateway where T : ContactosEstados, new()
    {

        #region "Singleton"

        static ContactosEstadosLoader<T> _instance;

        private ContactosEstadosLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosEstadosLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosEstadosLoader<T>();
                else {
                    ContactosEstadosLoader<T> inst = HttpContext.Current.Items["crmRules.ContactosEstadosLoaderSingleton"] as ContactosEstadosLoader<T>;
                    if (inst == null) {
                        inst = new ContactosEstadosLoader<T>();
                        HttpContext.Current.Items.Add("crmRules.ContactosEstadosLoaderSingleton", inst);
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
            
            string[] s ={"IdEstadoContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosEstados);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosEstados"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosEstados entity)
        {
            
            IMappeableContactosEstadosObject ContactosEstados = (IMappeableContactosEstadosObject)entity;
            ContactosEstados.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetInt32(2),
reader.GetBoolean(3));
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
            
            ((IMappeableContactosEstados)entity).CompleteEntity();
        }


        



        /// <summary>
        /// Get a ContactosEstados by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosEstadosList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdEstadoContacto)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosEstados_GetOne", IdEstadoContacto);
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





