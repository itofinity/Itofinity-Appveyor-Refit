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
    /// Defines NotificationProviderType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationProviderType
    {
        
        /// <summary>
        /// Enum Campfire for "Campfire"
        /// </summary>
        [EnumMember(Value = "Campfire")]
        Campfire,
        
        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,
        
        /// <summary>
        /// Enum GitHubPullRequest for "GitHubPullRequest"
        /// </summary>
        [EnumMember(Value = "GitHubPullRequest")]
        GitHubPullRequest,
        
        /// <summary>
        /// Enum HipChat for "HipChat"
        /// </summary>
        [EnumMember(Value = "HipChat")]
        HipChat,
        
        /// <summary>
        /// Enum Slack for "Slack"
        /// </summary>
        [EnumMember(Value = "Slack")]
        Slack,
        
        /// <summary>
        /// Enum Webhook for "Webhook"
        /// </summary>
        [EnumMember(Value = "Webhook")]
        Webhook,
        
        /// <summary>
        /// Enum VSOTeamRoom for "VSOTeamRoom"
        /// </summary>
        [EnumMember(Value = "VSOTeamRoom")]
        VSOTeamRoom
    }

}
