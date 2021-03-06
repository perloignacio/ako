
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/5/2022 - 11:33 a. m.
// This is a partial class file. The other one is ContactosMapper.cs
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
    public partial class ContactosMapper : BaseGateway<Contactos, ContactosList>, IGenericGateway
    {


        #region "Singleton"

        static ContactosMapper _instance;

        private ContactosMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosMapper();
                else {
                    ContactosMapper inst = HttpContext.Current.Items["crmRules.ContactosMapperSingleton"] as ContactosMapper;
                    if (inst == null) {
                        inst = new ContactosMapper();
                        HttpContext.Current.Items.Add("crmRules.ContactosMapperSingleton", inst);
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
            
            string[] s ={"IdContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Contactos);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Contactos"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ContactosMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Contactos entity)
        {
            
            IMappeableContactosObject Contactos = (IMappeableContactosObject)entity;
            Contactos.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
(reader.IsDBNull(3)) ? "" : reader.GetString(3),
(reader.IsDBNull(4)) ? "" : reader.GetString(4),
(reader.IsDBNull(5)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(5),
(reader.IsDBNull(6)) ? "" : reader.GetString(6),
(reader.IsDBNull(7)) ? "" : reader.GetString(7),
(reader.IsDBNull(8)) ? "" : reader.GetString(8),
(reader.IsDBNull(9)) ? "" : reader.GetString(9),
reader.GetBoolean(10),
(reader.IsDBNull(11)) ? "" : reader.GetString(11),
(reader.IsDBNull(12)) ? "" : reader.GetString(12),
(reader.IsDBNull(13)) ? "" : reader.GetString(13),
(reader.IsDBNull(14)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(14),
(reader.IsDBNull(15)) ? new System.Nullable<System.Int32>() : reader.GetInt32(15),
(reader.IsDBNull(16)) ? "" : reader.GetString(16),
(reader.IsDBNull(17)) ? "" : reader.GetString(17),
(reader.IsDBNull(18)) ? "" : reader.GetString(18));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Contactos entity)
        {

            IMappeableContactosObject Contactos = (IMappeableContactosObject)entity;
            return Contactos.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Contactos entity)
        {

            IMappeableContactosObject Contactos = (IMappeableContactosObject)entity;
            return Contactos.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Contactos entity)
        {

            IMappeableContactosObject Contactos = (IMappeableContactosObject)entity;
            return Contactos.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Contactos entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableContactosObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Contactos entity)
        {
            Entities.ContactosOrigen ContactosOrigenEntity = null; // Lazy load
            ((IMappeableContactos)entity).CompleteEntity(ContactosOrigenEntity);
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
        /// Get a Contactos by execute a SQL Query Text
        /// </summary>
        public Contactos GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosList by execute a SQL Query Text
        /// </summary>
        public ContactosList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Contactos GetOne(System.Int32 IdContacto)
        {
            return base.GetOne(new Contactos(IdContacto));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ContactosList GetByContactosOrigen(DbTransaction transaction, System.Int32 IdOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_GetByContactosOrigen", IdOrigen);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosList GetByContactosOrigen(DbTransaction transaction, IUniqueIdentifiable ContactosOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_GetByContactosOrigen", ContactosOrigen.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ContactosList GetByContactosOrigen(System.Int32 IdOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Contactos_GetByContactosOrigen", IdOrigen);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosList GetByContactosOrigen(IUniqueIdentifiable ContactosOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Contactos_GetByContactosOrigen", ContactosOrigen.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Contactos_Delete", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_Delete", IdContacto);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactosOrigen(System.Int32 IdOrigen)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Contactos_DeleteByContactosOrigen", IdOrigen);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactosOrigen(DbTransaction transaction, System.Int32 IdOrigen)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_DeleteByContactosOrigen", IdOrigen);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactosOrigen(IUniqueIdentifiable ContactosOrigen)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Contactos_DeleteByContactosOrigen", ContactosOrigen.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactosOrigen(DbTransaction transaction, IUniqueIdentifiable ContactosOrigen)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_DeleteByContactosOrigen", ContactosOrigen.Identifier());
        }


    


        //Database Queries 
        
            

        /// <summary>
        /// 
        /// </summary>
        public Contactos GetByEmail(System.String email) {
            
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Contactos_GetByEmail" , email);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public Contactos GetByEmail(DbTransaction transaction , System.String email) {
            
            return base.GetObjectByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_GetByEmail" , email);
            
        }


        
            

        /// <summary>
        /// 
        /// </summary>
        public ContactosList GetMios(System.Int32 idusuario) {
            
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Contactos_GetMios" , idusuario);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ContactosList GetMios(DbTransaction transaction , System.Int32 idusuario) {
            
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_GetMios" , idusuario);
            
        }


        


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
    public class ContactosMapperWrapper
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
        public crmRules.Mappers.ContactosMapper Instance()
        {
            return crmRules.Mappers.ContactosMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ContactosEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Contactos GetOne(System.Int32 IdContacto) {
            return Instance().GetOne( IdContacto);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ContactosList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosList GetByContactosOrigen(System.Int32 IdOrigen)
        {
            return Instance().GetByContactosOrigen(IdOrigen);
        }

        /// <summary>
        /// Get a ContactosList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosList GetByContactosOrigen(IUniqueIdentifiable ContactosOrigen)
        {
            return Instance().GetByContactosOrigen(ContactosOrigen);
        }

    

       

        /// <summary>
        /// Delete children for Contactos
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Contactos entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete Contactos by ContactosOrigen
        /// </summary>
        public void DeleteByContactosOrigen(System.Int32 IdOrigen)
        {
            Instance().DeleteByContactosOrigen(IdOrigen);
        }

        /// <summary>
        /// Delete Contactos by ContactosOrigen
        /// </summary>
        public void DeleteByContactosOrigen(IUniqueIdentifiable ContactosOrigen)
        {
            Instance().DeleteByContactosOrigen(ContactosOrigen);
        }

    
        /// <summary>
        /// Delete Contactos 
        /// </summary>
        public void Delete(System.Int32 IdContacto){
            Instance().Delete(IdContacto);
        }

        /// <summary>
        /// Delete Contactos 
        /// </summary>
        public void Delete(Entities.Contactos entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Contactos  
        /// </summary>
        public void Save(Entities.Contactos entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Contactos 
        /// </summary>
        public void Insert(Entities.Contactos entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Contactos 
        /// </summary>
        public Entities.ContactosList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Contactos 
        /// </summary>
        public void Save(System.Int32 IdContacto, System.String Nombre, System.String Apellido, System.String Email, System.String Telefono, System.DateTime FechaNacimiento, System.String Dni, System.String Cuit, System.String EstadoCivil, System.String Whatsapp, System.Boolean Activo, System.String Empresa, System.String Profesion, System.String Actividad, System.DateTime FechaRegistro, System.Int32 IdOrigen, System.String Facebook, System.String Linkedin, System.String Instagram){
            Entities.Contactos entity = Instance().GetOne(IdContacto);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdContacto", IdContacto));

            entity.Nombre = Nombre;
            entity.Apellido = Apellido;
            entity.Email = Email;
            entity.Telefono = Telefono;
            entity.FechaNacimiento = FechaNacimiento;
            entity.Dni = Dni;
            entity.Cuit = Cuit;
            entity.EstadoCivil = EstadoCivil;
            entity.Whatsapp = Whatsapp;
            entity.Activo = Activo;
            entity.Empresa = Empresa;
            entity.Profesion = Profesion;
            entity.Actividad = Actividad;
            entity.FechaRegistro = FechaRegistro;
            entity.IdOrigen = IdOrigen;
            entity.Facebook = Facebook;
            entity.Linkedin = Linkedin;
            entity.Instagram = Instagram;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Contactos
        /// </summary>
        public void Insert(System.String Nombre, System.String Apellido, System.String Email, System.String Telefono, System.DateTime FechaNacimiento, System.String Dni, System.String Cuit, System.String EstadoCivil, System.String Whatsapp, System.Boolean Activo, System.String Empresa, System.String Profesion, System.String Actividad, System.DateTime FechaRegistro, System.Int32 IdOrigen, System.String Facebook, System.String Linkedin, System.String Instagram){
            Entities.Contactos entity = new Entities.Contactos();

            entity.Nombre = Nombre;
            entity.Apellido = Apellido;
            entity.Email = Email;
            entity.Telefono = Telefono;
            entity.FechaNacimiento = FechaNacimiento;
            entity.Dni = Dni;
            entity.Cuit = Cuit;
            entity.EstadoCivil = EstadoCivil;
            entity.Whatsapp = Whatsapp;
            entity.Activo = Activo;
            entity.Empresa = Empresa;
            entity.Profesion = Profesion;
            entity.Actividad = Actividad;
            entity.FechaRegistro = FechaRegistro;
            entity.IdOrigen = IdOrigen;
            entity.Facebook = Facebook;
            entity.Linkedin = Linkedin;
            entity.Instagram = Instagram;
            Instance().Insert(entity);
        }


        //Database Queries 
        
            
        /// <summary>
        /// 
        /// </summary>
        public Contactos GetByEmail(System.String email) {
            
                return Instance().GetByEmail( email);
        }


        
            
        /// <summary>
        /// 
        /// </summary>
        public ContactosList GetMios(System.Int32 idusuario) {
            
                return Instance().GetMios( idusuario);
        }


        


    }
}





namespace crmRules.Loaders
{

    /// <summary>
    /// 
    /// </summary>
    public partial class ContactosLoader<T> : BaseLoader< T, Contactos, ObjectList<T>>, IGenericGateway where T : Contactos, new()
    {

        #region "Singleton"

        static ContactosLoader<T> _instance;

        private ContactosLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosLoader<T>();
                else {
                    ContactosLoader<T> inst = HttpContext.Current.Items["crmRules.ContactosLoaderSingleton"] as ContactosLoader<T>;
                    if (inst == null) {
                        inst = new ContactosLoader<T>();
                        HttpContext.Current.Items.Add("crmRules.ContactosLoaderSingleton", inst);
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
            
            string[] s ={"IdContacto"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Contactos);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Contactos"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Contactos entity)
        {
            
            IMappeableContactosObject Contactos = (IMappeableContactosObject)entity;
            Contactos.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
(reader.IsDBNull(3)) ? "" : reader.GetString(3),
(reader.IsDBNull(4)) ? "" : reader.GetString(4),
(reader.IsDBNull(5)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(5),
(reader.IsDBNull(6)) ? "" : reader.GetString(6),
(reader.IsDBNull(7)) ? "" : reader.GetString(7),
(reader.IsDBNull(8)) ? "" : reader.GetString(8),
(reader.IsDBNull(9)) ? "" : reader.GetString(9),
reader.GetBoolean(10),
(reader.IsDBNull(11)) ? "" : reader.GetString(11),
(reader.IsDBNull(12)) ? "" : reader.GetString(12),
(reader.IsDBNull(13)) ? "" : reader.GetString(13),
(reader.IsDBNull(14)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(14),
(reader.IsDBNull(15)) ? new System.Nullable<System.Int32>() : reader.GetInt32(15),
(reader.IsDBNull(16)) ? "" : reader.GetString(16),
(reader.IsDBNull(17)) ? "" : reader.GetString(17),
(reader.IsDBNull(18)) ? "" : reader.GetString(18));
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
            Entities.ContactosOrigen ContactosOrigenEntity = null; // Lazy load
            ((IMappeableContactos)entity).CompleteEntity(ContactosOrigenEntity);
        }


        



        /// <summary>
        /// Get a Contactos by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdContacto)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Contactos_GetOne", IdContacto);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactosOrigen(DbTransaction transaction, System.Int32 IdOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_GetByContactosOrigen", IdOrigen);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactosOrigen(DbTransaction transaction, IUniqueIdentifiable ContactosOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_GetByContactosOrigen", ContactosOrigen.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactosOrigen(System.Int32 IdOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Contactos_GetByContactosOrigen", IdOrigen);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactosOrigen(IUniqueIdentifiable ContactosOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Contactos_GetByContactosOrigen", ContactosOrigen.Identifier());
        }

    

        //Database Queries 
        
            
        /// <summary>
        /// 
        /// </summary>
        public T GetByEmail(System.String email) {
            
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Contactos_GetByEmail" , email);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public T GetByEmail(DbTransaction transaction , System.String email) {
            
            return base.GetObjectByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_GetByEmail" , email);
            
        }

        
            
        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetMios(System.Int32 idusuario) {
            
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Contactos_GetMios" , idusuario);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetMios(DbTransaction transaction , System.Int32 idusuario) {
            
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Contactos_GetMios" , idusuario);
            
        }

        



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





