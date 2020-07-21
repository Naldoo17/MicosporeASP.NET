﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_A5AC51_micosporeTestEntities : DbContext
    {
        public DB_A5AC51_micosporeTestEntities()
            : base("name=DB_A5AC51_micosporeTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<COMUNA> COMUNA { get; set; }
        public virtual DbSet<DETALLE_INFORMACION> DETALLE_INFORMACION { get; set; }
        public virtual DbSet<DETALLE_VENTA> DETALLE_VENTA { get; set; }
        public virtual DbSet<GRUPO_INFORMACION> GRUPO_INFORMACION { get; set; }
        public virtual DbSet<INFORMACION> INFORMACION { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<TIPO_DOCUMENTOS> TIPO_DOCUMENTOS { get; set; }
        public virtual DbSet<TIPO_INFO> TIPO_INFO { get; set; }
        public virtual DbSet<TIPO_PRODUCTO> TIPO_PRODUCTO { get; set; }
        public virtual DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public virtual DbSet<VENTA> VENTA { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    
        public virtual int SELECCIONAR_PERSONAS_TODO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SELECCIONAR_PERSONAS_TODO");
        }
    
        public virtual int SP_CREAR_CLIENTE(string rUT, string nOMBRE, string aPEPATERNO, string aPEMATERNO, string dIRECCION, Nullable<int> tELEFONO, string eMAIL, string cOMUNA, string pASSWORD)
        {
            var rUTParameter = rUT != null ?
                new ObjectParameter("RUT", rUT) :
                new ObjectParameter("RUT", typeof(string));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPEPATERNOParameter = aPEPATERNO != null ?
                new ObjectParameter("APEPATERNO", aPEPATERNO) :
                new ObjectParameter("APEPATERNO", typeof(string));
    
            var aPEMATERNOParameter = aPEMATERNO != null ?
                new ObjectParameter("APEMATERNO", aPEMATERNO) :
                new ObjectParameter("APEMATERNO", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var tELEFONOParameter = tELEFONO.HasValue ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(int));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var cOMUNAParameter = cOMUNA != null ?
                new ObjectParameter("COMUNA", cOMUNA) :
                new ObjectParameter("COMUNA", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREAR_CLIENTE", rUTParameter, nOMBREParameter, aPEPATERNOParameter, aPEMATERNOParameter, dIRECCIONParameter, tELEFONOParameter, eMAILParameter, cOMUNAParameter, pASSWORDParameter);
        }
    
        public virtual int SP_INSERT_PRODUCTO(Nullable<int> tIPO_PROD, string nOMBRE, string dESCRIPCION, Nullable<int> sTOCK, Nullable<int> pRECIO, string iMG)
        {
            var tIPO_PRODParameter = tIPO_PROD.HasValue ?
                new ObjectParameter("TIPO_PROD", tIPO_PROD) :
                new ObjectParameter("TIPO_PROD", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var sTOCKParameter = sTOCK.HasValue ?
                new ObjectParameter("STOCK", sTOCK) :
                new ObjectParameter("STOCK", typeof(int));
    
            var pRECIOParameter = pRECIO.HasValue ?
                new ObjectParameter("PRECIO", pRECIO) :
                new ObjectParameter("PRECIO", typeof(int));
    
            var iMGParameter = iMG != null ?
                new ObjectParameter("IMG", iMG) :
                new ObjectParameter("IMG", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERT_PRODUCTO", tIPO_PRODParameter, nOMBREParameter, dESCRIPCIONParameter, sTOCKParameter, pRECIOParameter, iMGParameter);
        }
    
        public virtual int SP_MANTENEDOR_CLIENTE_ADMINISTRADOR(string rUT, string nOMBRE, string aPEPATERNO, string aPEMATERNO, string dIRECCION, Nullable<int> tELEFONO, string eMAIL, Nullable<int> cOMUNA, string pASSWORD, Nullable<int> tIPO, Nullable<int> aCCION)
        {
            var rUTParameter = rUT != null ?
                new ObjectParameter("RUT", rUT) :
                new ObjectParameter("RUT", typeof(string));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPEPATERNOParameter = aPEPATERNO != null ?
                new ObjectParameter("APEPATERNO", aPEPATERNO) :
                new ObjectParameter("APEPATERNO", typeof(string));
    
            var aPEMATERNOParameter = aPEMATERNO != null ?
                new ObjectParameter("APEMATERNO", aPEMATERNO) :
                new ObjectParameter("APEMATERNO", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var tELEFONOParameter = tELEFONO.HasValue ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(int));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var cOMUNAParameter = cOMUNA.HasValue ?
                new ObjectParameter("COMUNA", cOMUNA) :
                new ObjectParameter("COMUNA", typeof(int));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            var tIPOParameter = tIPO.HasValue ?
                new ObjectParameter("TIPO", tIPO) :
                new ObjectParameter("TIPO", typeof(int));
    
            var aCCIONParameter = aCCION.HasValue ?
                new ObjectParameter("ACCION", aCCION) :
                new ObjectParameter("ACCION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MANTENEDOR_CLIENTE_ADMINISTRADOR", rUTParameter, nOMBREParameter, aPEPATERNOParameter, aPEMATERNOParameter, dIRECCIONParameter, tELEFONOParameter, eMAILParameter, cOMUNAParameter, pASSWORDParameter, tIPOParameter, aCCIONParameter);
        }
    
        public virtual int SP_MANTENEDOR_COMUNA(string iD, string nOMBRE, Nullable<int> aCCION)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aCCIONParameter = aCCION.HasValue ?
                new ObjectParameter("ACCION", aCCION) :
                new ObjectParameter("ACCION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MANTENEDOR_COMUNA", iDParameter, nOMBREParameter, aCCIONParameter);
        }
    
        public virtual int SP_MANTENEDOR_DETALLE_INFORMACION(Nullable<int> iD, string nOMBRE, string tITULO, string dESCRIPCION, string iMG, Nullable<int> eSTADO, Nullable<int> iD_GRUPO, Nullable<int> aCCION)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var tITULOParameter = tITULO != null ?
                new ObjectParameter("TITULO", tITULO) :
                new ObjectParameter("TITULO", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var iMGParameter = iMG != null ?
                new ObjectParameter("IMG", iMG) :
                new ObjectParameter("IMG", typeof(string));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(int));
    
            var iD_GRUPOParameter = iD_GRUPO.HasValue ?
                new ObjectParameter("ID_GRUPO", iD_GRUPO) :
                new ObjectParameter("ID_GRUPO", typeof(int));
    
            var aCCIONParameter = aCCION.HasValue ?
                new ObjectParameter("ACCION", aCCION) :
                new ObjectParameter("ACCION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MANTENEDOR_DETALLE_INFORMACION", iDParameter, nOMBREParameter, tITULOParameter, dESCRIPCIONParameter, iMGParameter, eSTADOParameter, iD_GRUPOParameter, aCCIONParameter);
        }
    
        public virtual ObjectResult<SP_MANTENEDOR_GRUPO_INFORMACION_Result> SP_MANTENEDOR_GRUPO_INFORMACION(Nullable<int> iD, string nOMBRE, string tITULO, string dESCRIPCION, string iMG, Nullable<int> eSTADO, Nullable<int> iD_INFO, Nullable<int> iD_TIPO_INFO, Nullable<int> aCCION)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var tITULOParameter = tITULO != null ?
                new ObjectParameter("TITULO", tITULO) :
                new ObjectParameter("TITULO", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var iMGParameter = iMG != null ?
                new ObjectParameter("IMG", iMG) :
                new ObjectParameter("IMG", typeof(string));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(int));
    
            var iD_INFOParameter = iD_INFO.HasValue ?
                new ObjectParameter("ID_INFO", iD_INFO) :
                new ObjectParameter("ID_INFO", typeof(int));
    
            var iD_TIPO_INFOParameter = iD_TIPO_INFO.HasValue ?
                new ObjectParameter("ID_TIPO_INFO", iD_TIPO_INFO) :
                new ObjectParameter("ID_TIPO_INFO", typeof(int));
    
            var aCCIONParameter = aCCION.HasValue ?
                new ObjectParameter("ACCION", aCCION) :
                new ObjectParameter("ACCION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_MANTENEDOR_GRUPO_INFORMACION_Result>("SP_MANTENEDOR_GRUPO_INFORMACION", iDParameter, nOMBREParameter, tITULOParameter, dESCRIPCIONParameter, iMGParameter, eSTADOParameter, iD_INFOParameter, iD_TIPO_INFOParameter, aCCIONParameter);
        }
    
        public virtual int SP_MANTENEDOR_INFORMACION(Nullable<int> iD, string nOMBRE, string tITULO, string dESCRIPCION, string iMG, Nullable<int> eSTADO, Nullable<int> tIPO_INFO, Nullable<int> aCCION)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var tITULOParameter = tITULO != null ?
                new ObjectParameter("TITULO", tITULO) :
                new ObjectParameter("TITULO", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var iMGParameter = iMG != null ?
                new ObjectParameter("IMG", iMG) :
                new ObjectParameter("IMG", typeof(string));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(int));
    
            var tIPO_INFOParameter = tIPO_INFO.HasValue ?
                new ObjectParameter("TIPO_INFO", tIPO_INFO) :
                new ObjectParameter("TIPO_INFO", typeof(int));
    
            var aCCIONParameter = aCCION.HasValue ?
                new ObjectParameter("ACCION", aCCION) :
                new ObjectParameter("ACCION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MANTENEDOR_INFORMACION", iDParameter, nOMBREParameter, tITULOParameter, dESCRIPCIONParameter, iMGParameter, eSTADOParameter, tIPO_INFOParameter, aCCIONParameter);
        }
    
        public virtual int SP_MANTENEDOR_PRODUCTO(Nullable<int> iD, Nullable<int> tIPO_PROD, string nOMBRE, string dESCRIPCION, Nullable<int> sTOCK, Nullable<int> pRECIO, string iMG, Nullable<int> eSTADO, Nullable<int> aCCION)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var tIPO_PRODParameter = tIPO_PROD.HasValue ?
                new ObjectParameter("TIPO_PROD", tIPO_PROD) :
                new ObjectParameter("TIPO_PROD", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var sTOCKParameter = sTOCK.HasValue ?
                new ObjectParameter("STOCK", sTOCK) :
                new ObjectParameter("STOCK", typeof(int));
    
            var pRECIOParameter = pRECIO.HasValue ?
                new ObjectParameter("PRECIO", pRECIO) :
                new ObjectParameter("PRECIO", typeof(int));
    
            var iMGParameter = iMG != null ?
                new ObjectParameter("IMG", iMG) :
                new ObjectParameter("IMG", typeof(string));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(int));
    
            var aCCIONParameter = aCCION.HasValue ?
                new ObjectParameter("ACCION", aCCION) :
                new ObjectParameter("ACCION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MANTENEDOR_PRODUCTO", iDParameter, tIPO_PRODParameter, nOMBREParameter, dESCRIPCIONParameter, sTOCKParameter, pRECIOParameter, iMGParameter, eSTADOParameter, aCCIONParameter);
        }
    
        public virtual int SP_MANTENEDOR_TIPO_INFO(Nullable<int> iD, string nOMBRE, Nullable<int> aCCION)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aCCIONParameter = aCCION.HasValue ?
                new ObjectParameter("ACCION", aCCION) :
                new ObjectParameter("ACCION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MANTENEDOR_TIPO_INFO", iDParameter, nOMBREParameter, aCCIONParameter);
        }
    
        public virtual int SP_MANTENEDOR_TIPO_PRODUCTO(Nullable<int> iD, string nOMBRE, string dESCRIPCION, string iMG, Nullable<int> aCTIVO, Nullable<int> aCCION)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var iMGParameter = iMG != null ?
                new ObjectParameter("IMG", iMG) :
                new ObjectParameter("IMG", typeof(string));
    
            var aCTIVOParameter = aCTIVO.HasValue ?
                new ObjectParameter("ACTIVO", aCTIVO) :
                new ObjectParameter("ACTIVO", typeof(int));
    
            var aCCIONParameter = aCCION.HasValue ?
                new ObjectParameter("ACCION", aCCION) :
                new ObjectParameter("ACCION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MANTENEDOR_TIPO_PRODUCTO", iDParameter, nOMBREParameter, dESCRIPCIONParameter, iMGParameter, aCTIVOParameter, aCCIONParameter);
        }
    
        public virtual ObjectResult<SP_SELECT_ALL_COMUNAS_Result> SP_SELECT_ALL_COMUNAS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SELECT_ALL_COMUNAS_Result>("SP_SELECT_ALL_COMUNAS");
        }
    
        public virtual ObjectResult<SP_SELECT_ALL_PRODUCTS_Result> SP_SELECT_ALL_PRODUCTS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SELECT_ALL_PRODUCTS_Result>("SP_SELECT_ALL_PRODUCTS");
        }
    
        public virtual ObjectResult<SP_SELECT_ALL_PRODUCTS_FILTER_ID_Result> SP_SELECT_ALL_PRODUCTS_FILTER_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SELECT_ALL_PRODUCTS_FILTER_ID_Result>("SP_SELECT_ALL_PRODUCTS_FILTER_ID", iDParameter);
        }
    
        public virtual ObjectResult<SP_SELECT_ALL_PRODUCTS_FILTER_TIPO_Result> SP_SELECT_ALL_PRODUCTS_FILTER_TIPO(Nullable<int> iD_TIPO)
        {
            var iD_TIPOParameter = iD_TIPO.HasValue ?
                new ObjectParameter("ID_TIPO", iD_TIPO) :
                new ObjectParameter("ID_TIPO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SELECT_ALL_PRODUCTS_FILTER_TIPO_Result>("SP_SELECT_ALL_PRODUCTS_FILTER_TIPO", iD_TIPOParameter);
        }
    
        public virtual ObjectResult<SP_SELECT_ALL_TIPO_PROD_Result> SP_SELECT_ALL_TIPO_PROD()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SELECT_ALL_TIPO_PROD_Result>("SP_SELECT_ALL_TIPO_PROD");
        }
    
        public virtual ObjectResult<SP_SELECT_DETALLE_USUARIO_Result> SP_SELECT_DETALLE_USUARIO(string uSUARIO, string pASSWORD)
        {
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SELECT_DETALLE_USUARIO_Result>("SP_SELECT_DETALLE_USUARIO", uSUARIOParameter, pASSWORDParameter);
        }
    
        public virtual ObjectResult<SP_SELECT_USUARIO_Result> SP_SELECT_USUARIO(string uSUARIO, string pASSWORD)
        {
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SELECT_USUARIO_Result>("SP_SELECT_USUARIO", uSUARIOParameter, pASSWORDParameter);
        }
    
        public virtual ObjectResult<SP_SELECT_USUARIO_ALL_Result> SP_SELECT_USUARIO_ALL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SELECT_USUARIO_ALL_Result>("SP_SELECT_USUARIO_ALL");
        }
    
        public virtual ObjectResult<Nullable<int>> SP_VALIDA_USUARIO(string cORREO)
        {
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_VALIDA_USUARIO", cORREOParameter);
        }
    
        public virtual ObjectResult<VALIDA_USER_Result> VALIDA_USER(string uSUARIO, string pASSWORD)
        {
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VALIDA_USER_Result>("VALIDA_USER", uSUARIOParameter, pASSWORDParameter);
        }
    }
}