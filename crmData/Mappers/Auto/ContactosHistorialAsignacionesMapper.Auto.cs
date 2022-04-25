
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/4/2022 - 03:14 p. m.
// This is a partial class file. The other one is ContactosHistorialAsignacionesMapper.cs
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
    public partial class ContactosHistorialAsignacionesMapper : BaseGateway<ContactosHistorialAsignaciones, ContactosHistorialAsignacionesList>, IGenericGateway
    {


        #region "Singleton"

        static ContactosHistorialAsignacionesMapper _instance;

        private ContactosHistorialAsignacionesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosHistorialAsignacionesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosHistorialAsignacionesMapper();
                else {
                    ContactosHistorialAsignacionesMapper inst = HttpContext.Current.Items["crmRules.ContactosHistorialAsignacionesMapperSingleton"] as ContactosHistorialAsignacionesMapper;
                    if (inst == null) {
                        inst = new ContactosHistorialAsignacionesMapper();
                        HttpContext.Current.Items.Add("crmRules.ContactosHistorialAsignacionesMapperSingleton", inst);
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
            
            string[] s ={"IdHistorialAsignacionesContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosHistorialAsignaciones);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosHistorialAsignaciones"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ContactosHistorialAsignacionesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosHistorialAsignaciones entity)
        {
            
            IMappeableContactosHistorialAsignacionesObject ContactosHistorialAsignaciones = (IMappeableContactosHistorialAsignacionesObject)entity;
            ContactosHistorialAsignaciones.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
reader.GetDateTime(3));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(ContactosHistorialAsignaciones entity)
        {

            IMappeableContactosHistorialAsignacionesObject ContactosHistorialAsignaciones = (IMappeableContactosHistorialAsignacionesObject)entity;
            return ContactosHistorialAsignaciones.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(ContactosHistorialAsignaciones entity)
        {

            IMappeableContactosHistorialAsignacionesObject ContactosHistorialAsignaciones = (IMappeableContactosHistorialAsignacionesObject)entity;
            return ContactosHistorialAsignaciones.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(ContactosHistorialAsignaciones entity)
        {

            IMappeableContactosHistorialAsignacionesObject ContactosHistorialAsignaciones = (IMappeableContactosHistorialAsignacionesObject)entity;
            return ContactosHistorialAsignaciones.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ContactosHistorialAsignaciones entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableContactosHistorialAsignacionesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(ContactosHistorialAsignaciones entity)
        {
            Entities.Contactos ContactosEntity = null; // Lazy load
Entities.ContactoUsuarios ContactoUsuariosEntity = null; // Lazy load
            ((IMappeableContactosHistorialAsignaciones)entity).CompleteEntity(ContactosEntity, ContactoUsuariosEntity);
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
        /// Get a ContactosHistorialAsignaciones by execute a SQL Query Text
        /// </summary>
        public ContactosHistorialAsignaciones GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosHistorialAsignacionesList by execute a SQL Query Text
        /// </summary>
        public ContactosHistorialAsignacionesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignaciones GetOne(System.Int32 IdHistorialAsignacionesContacto)
        {
            return base.GetOne(new ContactosHistorialAsignaciones(IdHistorialAsignacionesContacto));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesList GetByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesList GetByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesList GetByContactoUsuarios(DbTransaction transaction, System.Int32 IdUsuarioContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesList GetByContactoUsuarios(DbTransaction transaction, IUniqueIdentifiable ContactoUsuarios)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactoUsuarios", ContactoUsuarios.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesList GetByContactos(System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesList GetByContactos(IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesList GetByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosHistorialAsignacionesList GetByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactoUsuarios", ContactoUsuarios.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdHistorialAsignacionesContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_Delete", IdHistorialAsignacionesContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdHistorialAsignacionesContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_Delete", IdHistorialAsignacionesContacto);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_DeleteByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_DeleteByContactos", IdContacto);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(IUniqueIdentifiable Contactos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_DeleteByContactos", Contactos.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_DeleteByContactos", Contactos.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_DeleteByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactoUsuarios(DbTransaction transaction, System.Int32 IdUsuarioContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_DeleteByContactoUsuarios", IdUsuarioContacto);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_DeleteByContactoUsuarios", ContactoUsuarios.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactoUsuarios(DbTransaction transaction, IUniqueIdentifiable ContactoUsuarios)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_DeleteByContactoUsuarios", ContactoUsuarios.Identifier());
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
    public class ContactosHistorialAsignacionesMapperWrapper
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
        public crmRules.Mappers.ContactosHistorialAsignacionesMapper Instance()
        {
            return crmRules.Mappers.ContactosHistorialAsignacionesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ContactosHistorialAsignacionesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialAsignaciones GetOne(System.Int32 IdHistorialAsignacionesContacto) {
            return Instance().GetOne( IdHistorialAsignacionesContacto);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ContactosHistorialAsignacionesList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialAsignacionesList GetByContactos(System.Int32 IdContacto)
        {
            return Instance().GetByContactos(IdContacto);
        }

        /// <summary>
        /// Get a ContactosHistorialAsignacionesList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialAsignacionesList GetByContactos(IUniqueIdentifiable Contactos)
        {
            return Instance().GetByContactos(Contactos);
        }

    

        /// <summary>
        /// Get a ContactosHistorialAsignacionesList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialAsignacionesList GetByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            return Instance().GetByContactoUsuarios(IdUsuarioContacto);
        }

        /// <summary>
        /// Get a ContactosHistorialAsignacionesList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosHistorialAsignacionesList GetByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            return Instance().GetByContactoUsuarios(ContactoUsuarios);
        }

    

       

        /// <summary>
        /// Delete children for ContactosHistorialAsignaciones
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, ContactosHistorialAsignaciones entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete ContactosHistorialAsignaciones by Contactos
        /// </summary>
        public void DeleteByContactos(System.Int32 IdContacto)
        {
            Instance().DeleteByContactos(IdContacto);
        }

        /// <summary>
        /// Delete ContactosHistorialAsignaciones by Contactos
        /// </summary>
        public void DeleteByContactos(IUniqueIdentifiable Contactos)
        {
            Instance().DeleteByContactos(Contactos);
        }

    

        /// <summary>
        /// Delete ContactosHistorialAsignaciones by ContactoUsuarios
        /// </summary>
        public void DeleteByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            Instance().DeleteByContactoUsuarios(IdUsuarioContacto);
        }

        /// <summary>
        /// Delete ContactosHistorialAsignaciones by ContactoUsuarios
        /// </summary>
        public void DeleteByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            Instance().DeleteByContactoUsuarios(ContactoUsuarios);
        }

    
        /// <summary>
        /// Delete ContactosHistorialAsignaciones 
        /// </summary>
        public void Delete(System.Int32 IdHistorialAsignacionesContacto){
            Instance().Delete(IdHistorialAsignacionesContacto);
        }

        /// <summary>
        /// Delete ContactosHistorialAsignaciones 
        /// </summary>
        public void Delete(Entities.ContactosHistorialAsignaciones entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save ContactosHistorialAsignaciones  
        /// </summary>
        public void Save(Entities.ContactosHistorialAsignaciones entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosHistorialAsignaciones 
        /// </summary>
        public void Insert(Entities.ContactosHistorialAsignaciones entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll ContactosHistorialAsignaciones 
        /// </summary>
        public Entities.ContactosHistorialAsignacionesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save ContactosHistorialAsignaciones 
        /// </summary>
        public void Save(System.Int32 IdHistorialAsignacionesContacto, System.Int32 IdContacto, System.Int32 IdUsuarioContacto, System.DateTime Fecha){
            Entities.ContactosHistorialAsignaciones entity = Instance().GetOne(IdHistorialAsignacionesContacto);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdHistorialAsignacionesContacto", IdHistorialAsignacionesContacto));

            entity.IdContacto = IdContacto;
            entity.IdUsuarioContacto = IdUsuarioContacto;
            entity.Fecha = Fecha;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosHistorialAsignaciones
        /// </summary>
        public void Insert(System.Int32 IdContacto, System.Int32 IdUsuarioContacto, System.DateTime Fecha){
            Entities.ContactosHistorialAsignaciones entity = new Entities.ContactosHistorialAsignaciones();

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
    public partial class ContactosHistorialAsignacionesLoader<T> : BaseLoader< T, ContactosHistorialAsignaciones, ObjectList<T>>, IGenericGateway where T : ContactosHistorialAsignaciones, new()
    {

        #region "Singleton"

        static ContactosHistorialAsignacionesLoader<T> _instance;

        private ContactosHistorialAsignacionesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosHistorialAsignacionesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosHistorialAsignacionesLoader<T>();
                else {
                    ContactosHistorialAsignacionesLoader<T> inst = HttpContext.Current.Items["crmRules.ContactosHistorialAsignacionesLoaderSingleton"] as ContactosHistorialAsignacionesLoader<T>;
                    if (inst == null) {
                        inst = new ContactosHistorialAsignacionesLoader<T>();
                        HttpContext.Current.Items.Add("crmRules.ContactosHistorialAsignacionesLoaderSingleton", inst);
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
            
            string[] s ={"IdHistorialAsignacionesContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosHistorialAsignaciones);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosHistorialAsignaciones"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosHistorialAsignaciones entity)
        {
            
            IMappeableContactosHistorialAsignacionesObject ContactosHistorialAsignaciones = (IMappeableContactosHistorialAsignacionesObject)entity;
            ContactosHistorialAsignaciones.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
reader.GetDateTime(3));
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
Entities.ContactoUsuarios ContactoUsuariosEntity = null; // Lazy load
            ((IMappeableContactosHistorialAsignaciones)entity).CompleteEntity(ContactosEntity, ContactoUsuariosEntity);
        }


        



        /// <summary>
        /// Get a ContactosHistorialAsignaciones by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosHistorialAsignacionesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdHistorialAsignacionesContacto)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetOne", IdHistorialAsignacionesContacto);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactoUsuarios(DbTransaction transaction, System.Int32 IdUsuarioContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactoUsuarios(DbTransaction transaction, IUniqueIdentifiable ContactoUsuarios)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactoUsuarios", ContactoUsuarios.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactoUsuarios(System.Int32 IdUsuarioContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactoUsuarios", IdUsuarioContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactoUsuarios(IUniqueIdentifiable ContactoUsuarios)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosHistorialAsignaciones_GetByContactoUsuarios", ContactoUsuarios.Identifier());
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





