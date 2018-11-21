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
    /// DeploymentEnvironmentAddition
    /// </summary>
    [DataContract]
    public partial class DeploymentEnvironmentAddition :  IEquatable<DeploymentEnvironmentAddition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentEnvironmentAddition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeploymentEnvironmentAddition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentEnvironmentAddition" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Provider">Provider (required).</param>
        /// <param name="Settings">Settings (required).</param>
        public DeploymentEnvironmentAddition(string Name = default(string), DeploymentProviderType Provider = default(DeploymentProviderType), DeploymentEnvironmentSettings Settings = default(DeploymentEnvironmentSettings))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DeploymentEnvironmentAddition and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Provider" is required (not null)
            if (Provider == null)
            {
                throw new InvalidDataException("Provider is a required property for DeploymentEnvironmentAddition and cannot be null");
            }
            else
            {
                this.Provider = Provider;
            }
            // to ensure "Settings" is required (not null)
            if (Settings == null)
            {
                throw new InvalidDataException("Settings is a required property for DeploymentEnvironmentAddition and cannot be null");
            }
            else
            {
                this.Settings = Settings;
            }
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public DeploymentProviderType Provider { get; set; }
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public DeploymentEnvironmentSettings Settings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentEnvironmentAddition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DeploymentEnvironmentAddition);
        }

        /// <summary>
        /// Returns true if DeploymentEnvironmentAddition instances are equal
        /// </summary>
        /// <param name="other">Instance of DeploymentEnvironmentAddition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeploymentEnvironmentAddition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
