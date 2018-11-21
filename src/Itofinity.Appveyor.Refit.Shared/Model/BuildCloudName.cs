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
    /// Defines BuildCloudName
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BuildCloudName
    {
        
        /// <summary>
        /// Enum Gce for "gce"
        /// </summary>
        [EnumMember(Value = "gce")]
        Gce,
        
        /// <summary>
        /// Enum Provs2013 for "pro-vs2013"
        /// </summary>
        [EnumMember(Value = "pro-vs2013")]
        Provs2013,
        
        /// <summary>
        /// Enum Prowin2016 for "pro-win2016"
        /// </summary>
        [EnumMember(Value = "pro-win2016")]
        Prowin2016,
        
        /// <summary>
        /// Enum Provs2017 for "pro-vs2017"
        /// </summary>
        [EnumMember(Value = "pro-vs2017")]
        Provs2017,
        
        /// <summary>
        /// Enum Ubuntu for "ubuntu"
        /// </summary>
        [EnumMember(Value = "ubuntu")]
        Ubuntu
    }

}
