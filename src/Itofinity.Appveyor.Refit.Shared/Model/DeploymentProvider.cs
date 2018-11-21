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
    /// DeploymentProvider
    /// </summary>
    [DataContract]
    public partial class DeploymentProvider :  IEquatable<DeploymentProvider>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentProvider" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeploymentProvider() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentProvider" /> class.
        /// </summary>
        /// <param name="Provider">Provider (required).</param>
        /// <param name="ProviderSettings">ProviderSettings.</param>
        /// <param name="OnBranch">OnBranch.</param>
        /// <param name="OnEnvironmentVariables">OnEnvironmentVariables.</param>
        public DeploymentProvider(DeploymentProviderType Provider = default(DeploymentProviderType), List<StoredNameValue> ProviderSettings = default(List<StoredNameValue>), List<StringValueObject> OnBranch = default(List<StringValueObject>), List<StoredNameValue> OnEnvironmentVariables = default(List<StoredNameValue>))
        {
            // to ensure "Provider" is required (not null)
            if (Provider == null)
            {
                throw new InvalidDataException("Provider is a required property for DeploymentProvider and cannot be null");
            }
            else
            {
                this.Provider = Provider;
            }
            this.ProviderSettings = ProviderSettings;
            this.OnBranch = OnBranch;
            this.OnEnvironmentVariables = OnEnvironmentVariables;
        }
        
        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public DeploymentProviderType Provider { get; set; }
        /// <summary>
        /// Gets or Sets ProviderSettings
        /// </summary>
        [DataMember(Name="providerSettings", EmitDefaultValue=false)]
        public List<StoredNameValue> ProviderSettings { get; set; }
        /// <summary>
        /// Gets or Sets OnBranch
        /// </summary>
        [DataMember(Name="onBranch", EmitDefaultValue=false)]
        public List<StringValueObject> OnBranch { get; set; }
        /// <summary>
        /// Gets or Sets OnEnvironmentVariables
        /// </summary>
        [DataMember(Name="onEnvironmentVariables", EmitDefaultValue=false)]
        public List<StoredNameValue> OnEnvironmentVariables { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentProvider {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  ProviderSettings: ").Append(ProviderSettings).Append("\n");
            sb.Append("  OnBranch: ").Append(OnBranch).Append("\n");
            sb.Append("  OnEnvironmentVariables: ").Append(OnEnvironmentVariables).Append("\n");
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
            return this.Equals(obj as DeploymentProvider);
        }

        /// <summary>
        /// Returns true if DeploymentProvider instances are equal
        /// </summary>
        /// <param name="other">Instance of DeploymentProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeploymentProvider other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) && 
                (
                    this.ProviderSettings == other.ProviderSettings ||
                    this.ProviderSettings != null &&
                    this.ProviderSettings.SequenceEqual(other.ProviderSettings)
                ) && 
                (
                    this.OnBranch == other.OnBranch ||
                    this.OnBranch != null &&
                    this.OnBranch.SequenceEqual(other.OnBranch)
                ) && 
                (
                    this.OnEnvironmentVariables == other.OnEnvironmentVariables ||
                    this.OnEnvironmentVariables != null &&
                    this.OnEnvironmentVariables.SequenceEqual(other.OnEnvironmentVariables)
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
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                if (this.ProviderSettings != null)
                    hash = hash * 59 + this.ProviderSettings.GetHashCode();
                if (this.OnBranch != null)
                    hash = hash * 59 + this.OnBranch.GetHashCode();
                if (this.OnEnvironmentVariables != null)
                    hash = hash * 59 + this.OnEnvironmentVariables.GetHashCode();
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
