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
    /// BuildStartRequest
    /// </summary>
    [DataContract]
    public partial class BuildStartRequest :  IEquatable<BuildStartRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildStartRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuildStartRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildStartRequest" /> class.
        /// </summary>
        /// <param name="AccountName">AccountName (required).</param>
        /// <param name="ProjectSlug">ProjectSlug (required).</param>
        /// <param name="Branch">Branch.</param>
        /// <param name="CommitId">CommitId.</param>
        /// <param name="PullRequestId">Can not be used with &#x60;branch&#x60; or &#x60;commitId&#x60;.</param>
        /// <param name="EnvironmentVariables">EnvironmentVariables.</param>
        public BuildStartRequest(string AccountName = default(string), string ProjectSlug = default(string), string Branch = default(string), string CommitId = default(string), int? PullRequestId = default(int?), Dictionary<string, string> EnvironmentVariables = default(Dictionary<string, string>))
        {
            // to ensure "AccountName" is required (not null)
            if (AccountName == null)
            {
                throw new InvalidDataException("AccountName is a required property for BuildStartRequest and cannot be null");
            }
            else
            {
                this.AccountName = AccountName;
            }
            // to ensure "ProjectSlug" is required (not null)
            if (ProjectSlug == null)
            {
                throw new InvalidDataException("ProjectSlug is a required property for BuildStartRequest and cannot be null");
            }
            else
            {
                this.ProjectSlug = ProjectSlug;
            }
            this.Branch = Branch;
            this.CommitId = CommitId;
            this.PullRequestId = PullRequestId;
            this.EnvironmentVariables = EnvironmentVariables;
        }
        
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
        /// <summary>
        /// Gets or Sets ProjectSlug
        /// </summary>
        [DataMember(Name="projectSlug", EmitDefaultValue=false)]
        public string ProjectSlug { get; set; }
        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="branch", EmitDefaultValue=false)]
        public string Branch { get; set; }
        /// <summary>
        /// Gets or Sets CommitId
        /// </summary>
        [DataMember(Name="commitId", EmitDefaultValue=false)]
        public string CommitId { get; set; }
        /// <summary>
        /// Can not be used with &#x60;branch&#x60; or &#x60;commitId&#x60;
        /// </summary>
        /// <value>Can not be used with &#x60;branch&#x60; or &#x60;commitId&#x60;</value>
        [DataMember(Name="pullRequestId", EmitDefaultValue=false)]
        public int? PullRequestId { get; set; }
        /// <summary>
        /// Gets or Sets EnvironmentVariables
        /// </summary>
        [DataMember(Name="environmentVariables", EmitDefaultValue=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildStartRequest {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ProjectSlug: ").Append(ProjectSlug).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CommitId: ").Append(CommitId).Append("\n");
            sb.Append("  PullRequestId: ").Append(PullRequestId).Append("\n");
            sb.Append("  EnvironmentVariables: ").Append(EnvironmentVariables).Append("\n");
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
            return this.Equals(obj as BuildStartRequest);
        }

        /// <summary>
        /// Returns true if BuildStartRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BuildStartRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildStartRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.ProjectSlug == other.ProjectSlug ||
                    this.ProjectSlug != null &&
                    this.ProjectSlug.Equals(other.ProjectSlug)
                ) && 
                (
                    this.Branch == other.Branch ||
                    this.Branch != null &&
                    this.Branch.Equals(other.Branch)
                ) && 
                (
                    this.CommitId == other.CommitId ||
                    this.CommitId != null &&
                    this.CommitId.Equals(other.CommitId)
                ) && 
                (
                    this.PullRequestId == other.PullRequestId ||
                    this.PullRequestId != null &&
                    this.PullRequestId.Equals(other.PullRequestId)
                ) && 
                (
                    this.EnvironmentVariables == other.EnvironmentVariables ||
                    this.EnvironmentVariables != null &&
                    this.EnvironmentVariables.SequenceEqual(other.EnvironmentVariables)
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
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.ProjectSlug != null)
                    hash = hash * 59 + this.ProjectSlug.GetHashCode();
                if (this.Branch != null)
                    hash = hash * 59 + this.Branch.GetHashCode();
                if (this.CommitId != null)
                    hash = hash * 59 + this.CommitId.GetHashCode();
                if (this.PullRequestId != null)
                    hash = hash * 59 + this.PullRequestId.GetHashCode();
                if (this.EnvironmentVariables != null)
                    hash = hash * 59 + this.EnvironmentVariables.GetHashCode();
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
            // AccountName (string) minLength
            if(this.AccountName != null && this.AccountName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountName, length must be greater than 1.", new [] { "AccountName" });
            }

            // ProjectSlug (string) minLength
            if(this.ProjectSlug != null && this.ProjectSlug.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProjectSlug, length must be greater than 1.", new [] { "ProjectSlug" });
            }

            // PullRequestId (int?) minimum
            if(this.PullRequestId < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PullRequestId, must be a value greater than or equal to 1.", new [] { "PullRequestId" });
            }

            yield break;
        }
    }

}
