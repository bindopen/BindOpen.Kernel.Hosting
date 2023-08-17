﻿using BindOpen.System.Data.Meta;

namespace BindOpen.System.Data.Stores
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBdoDatasource : IBdoMetaWrapper, INamed, IReferenced
    {
        public static string __ConnectionString_DatasourceKind = "datasourceKind";
        public static string __ConnectionString_Token = "connectionString";

        /// <summary>
        /// 
        /// </summary>
        DatasourceKind DatasourceKind { get; set; }


        string ConnectionString { get; set; }
    }
}