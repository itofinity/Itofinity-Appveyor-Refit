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
    /// Script
    /// </summary>
    [DataContract]
    public partial class Script :  IEquatable<Script>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Script" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Script() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Script" /> class.
        /// </summary>
        /// <param name="Language">Language.</param>
        /// <param name="_Script">_Script (required).</param>
        public Script(ScriptLanguage Language = default(ScriptLanguage), string _Script = default(string))
        {
            // to ensure "_Script" is required (not null)
            if (_Script == null)
            {
                throw new InvalidDataException("_Script is a required property for Script and cannot be null");
            }
            else
            {
                this._Script = _Script;
            }
            this.Language = Language;
        }
        
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public ScriptLanguage Language { get; set; }
        /// <summary>
        /// Gets or Sets _Script
        /// </summary>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public string _Script { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Script {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  _Script: ").Append(_Script).Append("\n");
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
            return this.Equals(obj as Script);
        }

        /// <summary>
        /// Returns true if Script instances are equal
        /// </summary>
        /// <param name="other">Instance of Script to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Script other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this._Script == other._Script ||
                    this._Script != null &&
                    this._Script.Equals(other._Script)
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
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this._Script != null)
                    hash = hash * 59 + this._Script.GetHashCode();
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
