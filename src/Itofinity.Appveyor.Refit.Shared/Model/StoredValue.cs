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
    /// StoredValue
    /// </summary>
    [DataContract]
    public partial class StoredValue :  IEquatable<StoredValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredValue" /> class.
        /// </summary>
        /// <param name="IsEncrypted">IsEncrypted.</param>
        /// <param name="Value">Encrypted values can be created using the encryptValue operation.  Empty environment variables are represented by missing (null) value rather than an empty string..</param>
        public StoredValue(bool? IsEncrypted = default(bool?), string Value = default(string))
        {
            this.IsEncrypted = IsEncrypted;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets IsEncrypted
        /// </summary>
        [DataMember(Name="isEncrypted", EmitDefaultValue=false)]
        public bool? IsEncrypted { get; set; }
        /// <summary>
        /// Encrypted values can be created using the encryptValue operation.  Empty environment variables are represented by missing (null) value rather than an empty string.
        /// </summary>
        /// <value>Encrypted values can be created using the encryptValue operation.  Empty environment variables are represented by missing (null) value rather than an empty string.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredValue {\n");
            sb.Append("  IsEncrypted: ").Append(IsEncrypted).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as StoredValue);
        }

        /// <summary>
        /// Returns true if StoredValue instances are equal
        /// </summary>
        /// <param name="other">Instance of StoredValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsEncrypted == other.IsEncrypted ||
                    this.IsEncrypted != null &&
                    this.IsEncrypted.Equals(other.IsEncrypted)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.IsEncrypted != null)
                    hash = hash * 59 + this.IsEncrypted.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
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
