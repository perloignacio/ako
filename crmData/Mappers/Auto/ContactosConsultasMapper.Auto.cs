
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 29/4/2022 - 06:52 p. m.
// This is a partial class file. The other one is ContactosConsultasMapper.cs
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
    public partial class ContactosConsultasMapper : BaseGateway<ContactosConsultas, ContactosConsultasList>, IGenericGateway
    {


        #region "Singleton"

        static ContactosConsultasMapper _instance;

        private ContactosConsultasMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosConsultasMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosConsultasMapper();
                else {
                    ContactosConsultasMapper inst = HttpContext.Current.Items["crmRules.ContactosConsultasMapperSingleton"] as ContactosConsultasMapper;
                    if (inst == null) {
                        inst = new ContactosConsultasMapper();
                        HttpContext.Current.Items.Add("crmRules.ContactosConsultasMapperSingleton", inst);
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
            
            string[] s ={"IdConsulta"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosConsultas);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosConsultas"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ContactosConsultasMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosConsultas entity)
        {
            
            IMappeableContactosConsultasObject ContactosConsultas = (IMappeableContactosConsultasObject)entity;
            ContactosConsultas.HydrateFields(
            reader.GetInt32(0),
reader.GetDateTime(1),
reader.GetInt32(2),
reader.GetDecimal(3),
reader.GetDecimal(4),
reader.GetDecimal(5),
reader.GetDecimal(6),
reader.GetDecimal(7),
reader.GetDecimal(8),
reader.GetDecimal(9),
reader.GetDecimal(10),
reader.GetDecimal(11),
reader.GetDecimal(12),
reader.GetDecimal(13),
reader.GetDecimal(14),
reader.GetDecimal(15),
reader.GetDecimal(16),
reader.GetDecimal(17),
reader.GetDecimal(18),
reader.GetDecimal(19));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(ContactosConsultas entity)
        {

            IMappeableContactosConsultasObject ContactosConsultas = (IMappeableContactosConsultasObject)entity;
            return ContactosConsultas.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(ContactosConsultas entity)
        {

            IMappeableContactosConsultasObject ContactosConsultas = (IMappeableContactosConsultasObject)entity;
            return ContactosConsultas.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(ContactosConsultas entity)
        {

            IMappeableContactosConsultasObject ContactosConsultas = (IMappeableContactosConsultasObject)entity;
            return ContactosConsultas.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ContactosConsultas entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableContactosConsultasObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(ContactosConsultas entity)
        {
            Entities.Contactos ContactosEntity = null; // Lazy load
            ((IMappeableContactosConsultas)entity).CompleteEntity(ContactosEntity);
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
        /// Get a ContactosConsultas by execute a SQL Query Text
        /// </summary>
        public ContactosConsultas GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosConsultasList by execute a SQL Query Text
        /// </summary>
        public ContactosConsultasList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public ContactosConsultas GetOne(System.Int32 IdConsulta)
        {
            return base.GetOne(new ContactosConsultas(IdConsulta));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ContactosConsultasList GetByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosConsultas_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosConsultasList GetByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosConsultas_GetByContactos", Contactos.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ContactosConsultasList GetByContactos(System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosConsultas_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContactosConsultasList GetByContactos(IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosConsultas_GetByContactos", Contactos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdConsulta)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosConsultas_Delete", IdConsulta);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdConsulta)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosConsultas_Delete", IdConsulta);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosConsultas_DeleteByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosConsultas_DeleteByContactos", IdContacto);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(IUniqueIdentifiable Contactos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ContactosConsultas_DeleteByContactos", Contactos.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosConsultas_DeleteByContactos", Contactos.Identifier());
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
    public class ContactosConsultasMapperWrapper
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
        public crmRules.Mappers.ContactosConsultasMapper Instance()
        {
            return crmRules.Mappers.ContactosConsultasMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ContactosConsultasEntity by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosConsultas GetOne(System.Int32 IdConsulta) {
            return Instance().GetOne( IdConsulta);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ContactosConsultasList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosConsultasList GetByContactos(System.Int32 IdContacto)
        {
            return Instance().GetByContactos(IdContacto);
        }

        /// <summary>
        /// Get a ContactosConsultasList by calling a Stored Procedure
        /// </summary>
        public Entities.ContactosConsultasList GetByContactos(IUniqueIdentifiable Contactos)
        {
            return Instance().GetByContactos(Contactos);
        }

    

       

        /// <summary>
        /// Delete children for ContactosConsultas
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, ContactosConsultas entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete ContactosConsultas by Contactos
        /// </summary>
        public void DeleteByContactos(System.Int32 IdContacto)
        {
            Instance().DeleteByContactos(IdContacto);
        }

        /// <summary>
        /// Delete ContactosConsultas by Contactos
        /// </summary>
        public void DeleteByContactos(IUniqueIdentifiable Contactos)
        {
            Instance().DeleteByContactos(Contactos);
        }

    
        /// <summary>
        /// Delete ContactosConsultas 
        /// </summary>
        public void Delete(System.Int32 IdConsulta){
            Instance().Delete(IdConsulta);
        }

        /// <summary>
        /// Delete ContactosConsultas 
        /// </summary>
        public void Delete(Entities.ContactosConsultas entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save ContactosConsultas  
        /// </summary>
        public void Save(Entities.ContactosConsultas entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosConsultas 
        /// </summary>
        public void Insert(Entities.ContactosConsultas entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll ContactosConsultas 
        /// </summary>
        public Entities.ContactosConsultasList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save ContactosConsultas 
        /// </summary>
        public void Save(System.Int32 IdConsulta, System.DateTime Fecha, System.Int32 IdContacto, System.Decimal Gli_volumen, System.Decimal Gli_dureza, System.Decimal Gli_costo, System.Decimal Gli_dosis, System.Decimal Gli_porinactivacion, System.Decimal Gli_valinactivacion, System.Decimal Gli_perdida, System.Decimal Gli_villaseca, System.Decimal Corr_volumen, System.Decimal Corr_litros, System.Decimal Corr_cantidad, System.Decimal Corr_costoeco, System.Decimal Corr_hectareas, System.Decimal Corr_canthec, System.Decimal Corr_costohec, System.Decimal totalesta, System.Decimal totalako){
            Entities.ContactosConsultas entity = Instance().GetOne(IdConsulta);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdConsulta", IdConsulta));

            entity.Fecha = Fecha;
            entity.IdContacto = IdContacto;
            entity.Gli_volumen = Gli_volumen;
            entity.Gli_dureza = Gli_dureza;
            entity.Gli_costo = Gli_costo;
            entity.Gli_dosis = Gli_dosis;
            entity.Gli_porinactivacion = Gli_porinactivacion;
            entity.Gli_valinactivacion = Gli_valinactivacion;
            entity.Gli_perdida = Gli_perdida;
            entity.Gli_villaseca = Gli_villaseca;
            entity.Corr_volumen = Corr_volumen;
            entity.Corr_litros = Corr_litros;
            entity.Corr_cantidad = Corr_cantidad;
            entity.Corr_costoeco = Corr_costoeco;
            entity.Corr_hectareas = Corr_hectareas;
            entity.Corr_canthec = Corr_canthec;
            entity.Corr_costohec = Corr_costohec;
            entity.totalesta = totalesta;
            entity.totalako = totalako;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ContactosConsultas
        /// </summary>
        public void Insert(System.DateTime Fecha, System.Int32 IdContacto, System.Decimal Gli_volumen, System.Decimal Gli_dureza, System.Decimal Gli_costo, System.Decimal Gli_dosis, System.Decimal Gli_porinactivacion, System.Decimal Gli_valinactivacion, System.Decimal Gli_perdida, System.Decimal Gli_villaseca, System.Decimal Corr_volumen, System.Decimal Corr_litros, System.Decimal Corr_cantidad, System.Decimal Corr_costoeco, System.Decimal Corr_hectareas, System.Decimal Corr_canthec, System.Decimal Corr_costohec, System.Decimal totalesta, System.Decimal totalako){
            Entities.ContactosConsultas entity = new Entities.ContactosConsultas();

            entity.Fecha = Fecha;
            entity.IdContacto = IdContacto;
            entity.Gli_volumen = Gli_volumen;
            entity.Gli_dureza = Gli_dureza;
            entity.Gli_costo = Gli_costo;
            entity.Gli_dosis = Gli_dosis;
            entity.Gli_porinactivacion = Gli_porinactivacion;
            entity.Gli_valinactivacion = Gli_valinactivacion;
            entity.Gli_perdida = Gli_perdida;
            entity.Gli_villaseca = Gli_villaseca;
            entity.Corr_volumen = Corr_volumen;
            entity.Corr_litros = Corr_litros;
            entity.Corr_cantidad = Corr_cantidad;
            entity.Corr_costoeco = Corr_costoeco;
            entity.Corr_hectareas = Corr_hectareas;
            entity.Corr_canthec = Corr_canthec;
            entity.Corr_costohec = Corr_costohec;
            entity.totalesta = totalesta;
            entity.totalako = totalako;
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
    public partial class ContactosConsultasLoader<T> : BaseLoader< T, ContactosConsultas, ObjectList<T>>, IGenericGateway where T : ContactosConsultas, new()
    {

        #region "Singleton"

        static ContactosConsultasLoader<T> _instance;

        private ContactosConsultasLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContactosConsultasLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ContactosConsultasLoader<T>();
                else {
                    ContactosConsultasLoader<T> inst = HttpContext.Current.Items["crmRules.ContactosConsultasLoaderSingleton"] as ContactosConsultasLoader<T>;
                    if (inst == null) {
                        inst = new ContactosConsultasLoader<T>();
                        HttpContext.Current.Items.Add("crmRules.ContactosConsultasLoaderSingleton", inst);
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
            
            string[] s ={"IdConsulta"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ContactosConsultas);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ContactosConsultas"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ContactosConsultas entity)
        {
            
            IMappeableContactosConsultasObject ContactosConsultas = (IMappeableContactosConsultasObject)entity;
            ContactosConsultas.HydrateFields(
            reader.GetInt32(0),
reader.GetDateTime(1),
reader.GetInt32(2),
reader.GetDecimal(3),
reader.GetDecimal(4),
reader.GetDecimal(5),
reader.GetDecimal(6),
reader.GetDecimal(7),
reader.GetDecimal(8),
reader.GetDecimal(9),
reader.GetDecimal(10),
reader.GetDecimal(11),
reader.GetDecimal(12),
reader.GetDecimal(13),
reader.GetDecimal(14),
reader.GetDecimal(15),
reader.GetDecimal(16),
reader.GetDecimal(17),
reader.GetDecimal(18),
reader.GetDecimal(19));
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
            ((IMappeableContactosConsultas)entity).CompleteEntity(ContactosEntity);
        }


        



        /// <summary>
        /// Get a ContactosConsultas by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ContactosConsultasList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdConsulta)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosConsultas_GetOne", IdConsulta);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(DbTransaction transaction, System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosConsultas_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(DbTransaction transaction, IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ContactosConsultas_GetByContactos", Contactos.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(System.Int32 IdContacto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosConsultas_GetByContactos", IdContacto);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByContactos(IUniqueIdentifiable Contactos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ContactosConsultas_GetByContactos", Contactos.Identifier());
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




