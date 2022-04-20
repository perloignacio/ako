
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 19/4/2022 - 03:39 p. m.
// This is a partial class file. The other one is ContactosHistorialEstadoMapper.cs
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
    public partial class ContactosHistorialEstadoMapper : BaseGateway<ContactosHistorialEstado, ContactosHistorialEstadoList>, IGenericGateway
    {


        #region "Singleton"

        static ContactosHistorialEstadoMapper _instance;

        private ContactosHistorialEstadoMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosHistorialEstadoMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosHistorialEstadoMapper();
                else {
                    ContactosHistorialEstadoMapper inst = HttpContext.Current.Items["crmRules.ContactosHistorialEstadoMapperSingleton"] as ContactosHistorialEstadoMapper;
                    if (inst == null) {
                        inst = new ContactosHistorialEstadoMapper();
                        HttpContext.Current.Items.Add("crmRules.ContactosHistorialEstadoMapperSingleton", inst);
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
            
            string[] s ={"IdHistorialEstadoContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosHistorialEstado);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosHistorialEstado"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ContactosHistorialEstadoMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosHistorialEstado entity)
        {
            
            IMappeableContactosHistorialEstadoObject ContactosHistorialEstado = (IMappeableContactosHistorialEstadoObject)entity;
            ContactosHistorialEstado.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
reader.GetInt32(3),
reader.GetDateTime(4));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(ContactosHistorialEstado entity)
        {

            IMappeableContactosHistorialEstadoObject ContactosHistorialEstado = (IMappeableContactosHistorialEstadoObject)entity;
            return ContactosHistorialEstado.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(ContactosHistorialEstado entity)
        {

            IMappeableContactosHistorialEstadoObject ContactosHistorialEstado = (IMappeableContactosHistorialEstadoObject)entity;
            return ContactosHistorialEstado.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(ContactosHistorialEstado entity)
        {

            IMappeableContactosHistorialEstadoObject ContactosHistorialEstado = (IMappeableContactosHistorialEstadoObject)entity;
            return ContactosHistorialEstado.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ContactosHistorialEstado entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableContactosHistorialEstadoObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(ContactosHistorialEstado entity)
        {
            Entities.Contactos ContactosEntity = null; // Lazy load
Entities.ContactosEstados ContactosEstadosEntity = null; // Lazy load
Entities.ContactoUsuarios ContactoUsuariosEntity = null; // Lazy load
            ((IMappeableContactosHistorialEstado)entity).CompleteEntity(ContactosEntity, ContactosEstadosEntity, ContactoUsuariosEntity);
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
        /// Get a ContactosHistorialEstado by execute a SQL Query Text
        /// </summary>
        public ContactosHistorialEstado GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosHistorialEstadoList by execute a SQL Query Text
        /// </summary>
        public ContactosHistorialEstadoList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstado GetOne(System.Int32 IdHistorialEstadoContacto)
        {
            return base.GetOne(new ContactosHistorialEstado(IdHistorialEstadoContacto));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactosEstados(DbTransaction transaction, System.Int32 IdEstadoContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactosEstados", IdEstadoContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactosEstados(DbTransaction transaction, IUniqueIdentifiable ContactosEstados)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactosEstados", ContactosEstados.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactoUsuarios(DbTransaction transaction, System.Int32 IdUsuarioContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactoUsuarios(DbTransaction transaction, IUniqueIdentifiable ContactoUsuarios)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactoUsuarios", ContactoUsuarios.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactos(System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactos(IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactosEstados(System.Int32 IdEstadoContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactosEstados", IdEstadoContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactosEstados(IUniqueIdentifiable ContactosEstados)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactosEstados", ContactosEstados.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialEstadoList GetByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactoUsuarios", ContactoUsuarios.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdHistorialEstadoContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_Delete", IdHistorialEstadoContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdHistorialEstadoContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_Delete", IdHistorialEstadoContacto);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactos", IdContacto);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(IUniqueIdentifiable Contactos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactos", Contactos.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactos", Contactos.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactosEstados(System.Int32 IdEstadoContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactosEstados", IdEstadoContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactosEstados(DbTransaction transaction, System.Int32 IdEstadoContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactosEstados", IdEstadoContacto);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactosEstados(IUniqueIdentifiable ContactosEstados)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactosEstados", ContactosEstados.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactosEstados(DbTransaction transaction, IUniqueIdentifiable ContactosEstados)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactosEstados", ContactosEstados.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactoUsuarios(DbTransaction transaction, System.Int32 IdUsuarioContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactoUsuarios", IdUsuarioContacto);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactoUsuarios", ContactoUsuarios.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactoUsuarios(DbTransaction transaction, IUniqueIdentifiable ContactoUsuarios)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_DeleteByContactoUsuarios", ContactoUsuarios.Identifier());
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

namespace crmRules.Wrappers
{
    /// <summary>
    /// 
    /// </summary>
    public class ContactosHistorialEstadoMapperWrapper
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
        public crmRules.Mappers.ContactosHistorialEstadoMapper Instance()
        {
            return crmRules.Mappers.ContactosHistorialEstadoMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ContactosHistorialEstadoEntity by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialEstado GetOne(System.Int32 IdHistorialEstadoContacto) {
            return Instance().GetOne( IdHistorialEstadoContacto);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ContactosHistorialEstadoList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialEstadoList GetByContactos(System.Int32 IdContacto)
        {
            return Instance().GetByContactos(IdContacto);
        }

        /// <summary>
        /// Get a ContactosHistorialEstadoList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialEstadoList GetByContactos(IUniqueIdentifiable Contactos)
        {
            return Instance().GetByContactos(Contactos);
        }

    

        /// <summary>
        /// Get a ContactosHistorialEstadoList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialEstadoList GetByContactosEstados(System.Int32 IdEstadoContacto)
        {
            return Instance().GetByContactosEstados(IdEstadoContacto);
        }

        /// <summary>
        /// Get a ContactosHistorialEstadoList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialEstadoList GetByContactosEstados(IUniqueIdentifiable ContactosEstados)
        {
            return Instance().GetByContactosEstados(ContactosEstados);
        }

    

        /// <summary>
        /// Get a ContactosHistorialEstadoList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialEstadoList GetByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            return Instance().GetByContactoUsuarios(IdUsuarioContacto);
        }

        /// <summary>
        /// Get a ContactosHistorialEstadoList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialEstadoList GetByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            return Instance().GetByContactoUsuarios(ContactoUsuarios);
        }

    

       

        /// <summary>
        /// Delete children for ContactosHistorialEstado
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, ContactosHistorialEstado entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete ContactosHistorialEstado by Contactos
        /// </summary>
        public void DeleteByContactos(System.Int32 IdContacto)
        {
            Instance().DeleteByContactos(IdContacto);
        }

        /// <summary>
        /// Delete ContactosHistorialEstado by Contactos
        /// </summary>
        public void DeleteByContactos(IUniqueIdentifiable Contactos)
        {
            Instance().DeleteByContactos(Contactos);
        }

    

        /// <summary>
        /// Delete ContactosHistorialEstado by ContactosEstados
        /// </summary>
        public void DeleteByContactosEstados(System.Int32 IdEstadoContacto)
        {
            Instance().DeleteByContactosEstados(IdEstadoContacto);
        }

        /// <summary>
        /// Delete ContactosHistorialEstado by ContactosEstados
        /// </summary>
        public void DeleteByContactosEstados(IUniqueIdentifiable ContactosEstados)
        {
            Instance().DeleteByContactosEstados(ContactosEstados);
        }

    

        /// <summary>
        /// Delete ContactosHistorialEstado by ContactoUsuarios
        /// </summary>
        public void DeleteByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            Instance().DeleteByContactoUsuarios(IdUsuarioContacto);
        }

        /// <summary>
        /// Delete ContactosHistorialEstado by ContactoUsuarios
        /// </summary>
        public void DeleteByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            Instance().DeleteByContactoUsuarios(ContactoUsuarios);
        }

    
        /// <summary>
        /// Delete ContactosHistorialEstado 
        /// </summary>
        public void Delete(System.Int32 IdHistorialEstadoContacto){
            Instance().Delete(IdHistorialEstadoContacto);
        }

        /// <summary>
        /// Delete ContactosHistorialEstado 
        /// </summary>
        public void Delete(Entities.ContactosHistorialEstado entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save ContactosHistorialEstado  
        /// </summary>
        public void Save(Entities.ContactosHistorialEstado entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosHistorialEstado 
        /// </summary>
        public void Insert(Entities.ContactosHistorialEstado entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll ContactosHistorialEstado 
        /// </summary>
        public Entities.ContactosHistorialEstadoList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save ContactosHistorialEstado 
        /// </summary>
        public void Save(System.Int32 IdHistorialEstadoContacto, System.Int32 IdEstadoContacto, System.Int32 IdContacto, System.Int32 IdUsuarioContacto, System.DateTime Fecha){
            Entities.ContactosHistorialEstado entity = Instance().GetOne(IdHistorialEstadoContacto);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdHistorialEstadoContacto", IdHistorialEstadoContacto));

            entity.IdEstadoContacto = IdEstadoContacto;
            entity.IdContacto = IdContacto;
            entity.IdUsuarioContacto = IdUsuarioContacto;
            entity.Fecha = Fecha;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosHistorialEstado
        /// </summary>
        public void Insert(System.Int32 IdEstadoContacto, System.Int32 IdContacto, System.Int32 IdUsuarioContacto, System.DateTime Fecha){
            Entities.ContactosHistorialEstado entity = new Entities.ContactosHistorialEstado();

            entity.IdEstadoContacto = IdEstadoContacto;
            entity.IdContacto = IdContacto;
            entity.IdUsuarioContacto = IdUsuarioContacto;
            entity.Fecha = Fecha;
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
    public partial class ContactosHistorialEstadoLoader<T> : BaseLoader< T, ContactosHistorialEstado, ObjectList<T>>, IGenericGateway where T : ContactosHistorialEstado, new()
    {

        #region "Singleton"

        static ContactosHistorialEstadoLoader<T> _instance;

        private ContactosHistorialEstadoLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosHistorialEstadoLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosHistorialEstadoLoader<T>();
                else {
                    ContactosHistorialEstadoLoader<T> inst = HttpContext.Current.Items["crmRules.ContactosHistorialEstadoLoaderSingleton"] as ContactosHistorialEstadoLoader<T>;
                    if (inst == null) {
                        inst = new ContactosHistorialEstadoLoader<T>();
                        HttpContext.Current.Items.Add("crmRules.ContactosHistorialEstadoLoaderSingleton", inst);
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
            
            string[] s ={"IdHistorialEstadoContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosHistorialEstado);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosHistorialEstado"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosHistorialEstado entity)
        {
            
            IMappeableContactosHistorialEstadoObject ContactosHistorialEstado = (IMappeableContactosHistorialEstadoObject)entity;
            ContactosHistorialEstado.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
reader.GetInt32(3),
reader.GetDateTime(4));
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
            Entities.Contactos ContactosEntity = null; // Lazy load
Entities.ContactosEstados ContactosEstadosEntity = null; // Lazy load
Entities.ContactoUsuarios ContactoUsuariosEntity = null; // Lazy load
            ((IMappeableContactosHistorialEstado)entity).CompleteEntity(ContactosEntity, ContactosEstadosEntity, ContactoUsuariosEntity);
        }


        



        /// <summary>
        /// Get a ContactosHistorialEstado by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosHistorialEstadoList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdHistorialEstadoContacto)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetOne", IdHistorialEstadoContacto);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactosEstados(DbTransaction transaction, System.Int32 IdEstadoContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactosEstados", IdEstadoContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactosEstados(DbTransaction transaction, IUniqueIdentifiable ContactosEstados)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactosEstados", ContactosEstados.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactoUsuarios(DbTransaction transaction, System.Int32 IdUsuarioContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactoUsuarios(DbTransaction transaction, IUniqueIdentifiable ContactoUsuarios)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactoUsuarios", ContactoUsuarios.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactosEstados(System.Int32 IdEstadoContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactosEstados", IdEstadoContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactosEstados(IUniqueIdentifiable ContactosEstados)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactosEstados", ContactosEstados.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialEstado_GetByContactoUsuarios", ContactoUsuarios.Identifier());
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





