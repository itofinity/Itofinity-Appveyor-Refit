/* 
 * AppVeyor REST API
 *
 * AppVeyor is a hosted continuous integration service which runs on Microsoft Windows.  The AppVeyor REST API provides a RESTful way to interact with the AppVeyor service.  This includes managing projects, builds, deployments, and the teams that build them.  Additional help and discussion of the AppVeyor REST API is available at http://help.appveyor.com/discussions  This Swagger definition is an **unofficial** description of the AppVeyor REST API maintained at https://github.com/kevinoid/appveyor-swagger Please report any issues or suggestions for this Swagger definition at https://github.com/kevinoid/appveyor-swagger/issues/new  #### API Conventions  Fields which are missing from update operations (`PUT` requests) are typically reset to their default values.  So although most fields are not technically required, they should usually be specified in practice. 
 *
 * OpenAPI spec version: 0.20181117.0
 * Contact: team@appveyor.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Itofinity.Appveyor.Refit.Model
{
    /// <summary>
    /// Defines OSServiceName
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OSServiceName
    {
        
        /// <summary>
        /// Enum Iis for "iis"
        /// </summary>
        [EnumMember(Value = "iis")]
        Iis,
        
        /// <summary>
        /// Enum Mongodb for "mongodb"
        /// </summary>
        [EnumMember(Value = "mongodb")]
        Mongodb,
        
        /// <summary>
        /// Enum Msmq for "msmq"
        /// </summary>
        [EnumMember(Value = "msmq")]
        Msmq,
        
        /// <summary>
        /// Enum Mssql2008r2sp2 for "mssql2008r2sp2"
        /// </summary>
        [EnumMember(Value = "mssql2008r2sp2")]
        Mssql2008r2sp2,
        
        /// <summary>
        /// Enum Mssql2008r2sp2rs for "mssql2008r2sp2rs"
        /// </summary>
        [EnumMember(Value = "mssql2008r2sp2rs")]
        Mssql2008r2sp2rs,
        
        /// <summary>
        /// Enum Mssql2012sp1 for "mssql2012sp1"
        /// </summary>
        [EnumMember(Value = "mssql2012sp1")]
        Mssql2012sp1,
        
        /// <summary>
        /// Enum Mssql2012sp1rs for "mssql2012sp1rs"
        /// </summary>
        [EnumMember(Value = "mssql2012sp1rs")]
        Mssql2012sp1rs,
        
        /// <summary>
        /// Enum Mssql2014 for "mssql2014"
        /// </summary>
        [EnumMember(Value = "mssql2014")]
        Mssql2014,
        
        /// <summary>
        /// Enum Mssql2014rs for "mssql2014rs"
        /// </summary>
        [EnumMember(Value = "mssql2014rs")]
        Mssql2014rs,
        
        /// <summary>
        /// Enum Mssql2016 for "mssql2016"
        /// </summary>
        [EnumMember(Value = "mssql2016")]
        Mssql2016,
        
        /// <summary>
        /// Enum Mysql for "mysql"
        /// </summary>
        [EnumMember(Value = "mysql")]
        Mysql,
        
        /// <summary>
        /// Enum Postgresql for "postgresql"
        /// </summary>
        [EnumMember(Value = "postgresql")]
        Postgresql
    }

}
