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
    /// ProjectBuildNumberUpdate
    /// </summary>
    [DataContract]
    public partial class ProjectBuildNumberUpdate :  IEquatable<ProjectBuildNumberUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBuildNumberUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectBuildNumberUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBuildNumberUpdate" /> class.
        /// </summary>
        /// <param name="NextBuildNumber">NextBuildNumber (required).</param>
        public ProjectBuildNumberUpdate(int? NextBuildNumber = default(int?))
        {
            // to ensure "NextBuildNumber" is required (not null)
            if (NextBuildNumber == null)
            {
                throw new InvalidDataException("NextBuildNumber is a required property for ProjectBuildNumberUpdate and cannot be null");
            }
            else
            {
                this.NextBuildNumber = NextBuildNumber;
            }
        }
        
        /// <summary>
        /// Gets or Sets NextBuildNumber
        /// </summary>
        [DataMember(Name="nextBuildNumber", EmitDefaultValue=false)]
        public int? NextBuildNumber { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectBuildNumberUpdate {\n");
            sb.Append("  NextBuildNumber: ").Append(NextBuildNumber).Append("\n");
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
            return this.Equals(obj as ProjectBuildNumberUpdate);
        }

        /// <summary>
        /// Returns true if ProjectBuildNumberUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectBuildNumberUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectBuildNumberUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NextBuildNumber == other.NextBuildNumber ||
                    this.NextBuildNumber != null &&
                    this.NextBuildNumber.Equals(other.NextBuildNumber)
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
                if (this.NextBuildNumber != null)
                    hash = hash * 59 + this.NextBuildNumber.GetHashCode();
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
            // NextBuildNumber (int?) minimum
            if(this.NextBuildNumber < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NextBuildNumber, must be a value greater than or equal to 0.", new [] { "NextBuildNumber" });
            }

            yield break;
        }
    }

}
