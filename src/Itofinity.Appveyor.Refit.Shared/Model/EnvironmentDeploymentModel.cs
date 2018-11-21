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
    /// EnvironmentDeploymentModel
    /// </summary>
    [DataContract]
    public partial class EnvironmentDeploymentModel :  IEquatable<EnvironmentDeploymentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentDeploymentModel" /> class.
        /// </summary>
        /// <param name="DeploymentId">DeploymentId.</param>
        /// <param name="Build">Build.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Started">Started.</param>
        /// <param name="Finished">Finished.</param>
        /// <param name="Project">Project.</param>
        public EnvironmentDeploymentModel(int? DeploymentId = default(int?), BuildLookupModel Build = default(BuildLookupModel), Status Status = default(Status), DateTime? Started = default(DateTime?), DateTime? Finished = default(DateTime?), ProjectLookupModel Project = default(ProjectLookupModel))
        {
            this.DeploymentId = DeploymentId;
            this.Build = Build;
            this.Status = Status;
            this.Started = Started;
            this.Finished = Finished;
            this.Project = Project;
        }
        
        /// <summary>
        /// Gets or Sets DeploymentId
        /// </summary>
        [DataMember(Name="deploymentId", EmitDefaultValue=false)]
        public int? DeploymentId { get; set; }
        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public BuildLookupModel Build { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public Status Status { get; set; }
        /// <summary>
        /// Gets or Sets Started
        /// </summary>
        [DataMember(Name="started", EmitDefaultValue=false)]
        public DateTime? Started { get; set; }
        /// <summary>
        /// Gets or Sets Finished
        /// </summary>
        [DataMember(Name="finished", EmitDefaultValue=false)]
        public DateTime? Finished { get; set; }
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public ProjectLookupModel Project { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentDeploymentModel {\n");
            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
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
            return this.Equals(obj as EnvironmentDeploymentModel);
        }

        /// <summary>
        /// Returns true if EnvironmentDeploymentModel instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvironmentDeploymentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentDeploymentModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeploymentId == other.DeploymentId ||
                    this.DeploymentId != null &&
                    this.DeploymentId.Equals(other.DeploymentId)
                ) && 
                (
                    this.Build == other.Build ||
                    this.Build != null &&
                    this.Build.Equals(other.Build)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Started == other.Started ||
                    this.Started != null &&
                    this.Started.Equals(other.Started)
                ) && 
                (
                    this.Finished == other.Finished ||
                    this.Finished != null &&
                    this.Finished.Equals(other.Finished)
                ) && 
                (
                    this.Project == other.Project ||
                    this.Project != null &&
                    this.Project.Equals(other.Project)
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
                if (this.DeploymentId != null)
                    hash = hash * 59 + this.DeploymentId.GetHashCode();
                if (this.Build != null)
                    hash = hash * 59 + this.Build.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Started != null)
                    hash = hash * 59 + this.Started.GetHashCode();
                if (this.Finished != null)
                    hash = hash * 59 + this.Finished.GetHashCode();
                if (this.Project != null)
                    hash = hash * 59 + this.Project.GetHashCode();
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
            // DeploymentId (int?) minimum
            if(this.DeploymentId < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeploymentId, must be a value greater than or equal to 0.", new [] { "DeploymentId" });
            }

            yield break;
        }
    }

}
