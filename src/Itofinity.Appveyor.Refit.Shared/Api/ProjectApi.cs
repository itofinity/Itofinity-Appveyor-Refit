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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Refit;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Itofinity.Appveyor.Refit.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProjectApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// Add project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Project</returns>
        [Post("/projects")]
        System.Threading.Tasks.Task<Project> AddProject([Header("UserAgent")] string userAgent, [Body]ProjectAddition body);

        /// <summary>
        /// Delete project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <returns>Task of void</returns>
        [Delete("/projects/{accountName}/{projectSlug}")]
        System.Threading.Tasks.Task DeleteProject([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug);

        /// <summary>
        /// Delete project build cache
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <returns>Task of void</returns>
        [Delete("/projects/{accountName}/{projectSlug}/buildcache")]
        System.Threading.Tasks.Task DeleteProjectBuildCache([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug);

        /// <summary>
        /// Encrypt a value for use in StoredValue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of string</returns>
        [Post("/account/encrypt")]
        System.Threading.Tasks.Task<string> EncryptValue([Header("UserAgent")] string userAgent, [Body]EncryptRequest body);

        /// <summary>
        /// Get last successful build artifact
        /// </summary>
        /// <remarks>
        /// The &#x60;job&#x60; parameter is mandatory if the build contains multiple jobs.
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <param name="artifactFileName">File name (or path) of a build artifact file. Corresponds to the &#x60;fileName&#x60; property of &#x60;ArtifactModel&#x60;. URL-encoding of slashes in parameter values is optional.</param>
        /// <param name="branch">Repository Branch (optional)</param>
        /// <param name="tag">A git (or other VCS) tag (optional)</param>
        /// <param name="job">Name of the build job. (optional)</param>
        /// <param name="all">Include not only &#x60;successful&#x60;, but also jobs with &#x60;failed&#x60;, and &#x60;cancelled&#x60; status. (optional, default to false)</param>
        /// <param name="pr">Include PR builds in the search results? &#x60;true&#x60; - take artifact from PR builds only; &#x60;false&#x60; - do not look for artifact in PR builds; default/unspecified - look for artifact in both PR an non-PR builds.  (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        [Get("/projects/{accountName}/{projectSlug}/artifacts/{artifactFileName}")]
        System.Threading.Tasks.Task<System.IO.Stream> GetProjectArtifact([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug, [AliasAs("artifactFileName")]string artifactFileName, [AliasAs("branch")]string branch = null, [AliasAs("tag")]string tag = null, [AliasAs("job")]string job = null, [AliasAs("all")]bool? all = null, [AliasAs("pr")]bool? pr = null);

        /// <summary>
        /// Get project branch status badge image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusBadgeId">ID of the status badge (&#x60;statusBadgeId&#x60; from &#x60;ProjectWithConfiguration&#x60;).</param>
        /// <param name="buildBranch">Build Branch</param>
        /// <param name="svg">Return an SVG image instead of PNG?  Exclusive with &#x60;retina&#x60;. (optional, default to false)</param>
        /// <param name="retina">Return a larger image suitable for retina displays?  Exclusive with &#x60;svg&#x60;. (optional, default to false)</param>
        /// <param name="passingText">Text to show in badge when build is passing. (optional)</param>
        /// <param name="failingText">Text to show in badge when build is failing. (optional)</param>
        /// <param name="pendingText">Text to show in badge when build is pending. (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        [Get("/projects/status/{statusBadgeId}/branch/{buildBranch}")]
        System.Threading.Tasks.Task<System.IO.Stream> GetProjectBranchStatusBadge([Header("UserAgent")] string userAgent, [AliasAs("statusBadgeId")]string statusBadgeId, [AliasAs("buildBranch")]string buildBranch, [AliasAs("svg")]bool? svg = null, [AliasAs("retina")]bool? retina = null, [AliasAs("passingText")]string passingText = null, [AliasAs("failingText")]string failingText = null, [AliasAs("pendingText")]string pendingText = null);

        /// <summary>
        /// Get project build by version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <param name="buildVersion">Build Version (&#x60;version&#x60; property of &#x60;Build&#x60;)</param>
        /// <returns>Task of ProjectBuildResults</returns>
        [Get("/projects/{accountName}/{projectSlug}/build/{buildVersion}")]
        System.Threading.Tasks.Task<ProjectBuildResults> GetProjectBuildByVersion([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug, [AliasAs("buildVersion")]string buildVersion);

        /// <summary>
        /// Get project deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <param name="recordsNumber">Number of results to include in the response. getProjectDeployments is documented to have a maximum of 20. It currently returns 500 Internal Server Error for recordsNumber &lt;&#x3D; 5. In the past it has returned 500 Internal Server Error for many different values which did not match the value used by the ci.appveyor.com web interface at the time.  As of 2018-09-08, the value used by the web interface is 10.</param>
        /// <returns>Task of ProjectDeploymentsResults</returns>
        [Get("/projects/{accountName}/{projectSlug}/deployments")]
        System.Threading.Tasks.Task<ProjectDeploymentsResults> GetProjectDeployments([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug, [AliasAs("recordsNumber")]int? recordsNumber);

        /// <summary>
        /// Get project environment variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <returns>Task of List&lt;StoredNameValue&gt;</returns>
        [Get("/projects/{accountName}/{projectSlug}/settings/environment-variables")]
        System.Threading.Tasks.Task<List<StoredNameValue>> GetProjectEnvironmentVariables([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug);

        /// <summary>
        /// Get project history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <param name="recordsNumber">Number of results to include in the response. getProjectDeployments is documented to have a maximum of 20. It currently returns 500 Internal Server Error for recordsNumber &lt;&#x3D; 5. In the past it has returned 500 Internal Server Error for many different values which did not match the value used by the ci.appveyor.com web interface at the time.  As of 2018-09-08, the value used by the web interface is 10.</param>
        /// <param name="startBuildId">Maximum &#x60;buildId&#x60; to include in the results (exclusive). (optional)</param>
        /// <param name="branch">Repository Branch (optional)</param>
        /// <returns>Task of ProjectHistory</returns>
        [Get("/projects/{accountName}/{projectSlug}/history")]
        System.Threading.Tasks.Task<ProjectHistory> GetProjectHistory([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug, [AliasAs("recordsNumber")]int? recordsNumber, [AliasAs("startBuildId")]int? startBuildId = null, [AliasAs("branch")]string branch = null);

        /// <summary>
        /// Get project last build
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <returns>Task of ProjectBuildResults</returns>
        [Get("/projects/{accountName}/{projectSlug}")]
        System.Threading.Tasks.Task<ProjectBuildResults> GetProjectLastBuild([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug);

        /// <summary>
        /// Get project last branch build
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <param name="buildBranch">Build Branch</param>
        /// <returns>Task of ProjectBuildResults</returns>
        [Get("/projects/{accountName}/{projectSlug}/branch/{buildBranch}")]
        System.Threading.Tasks.Task<ProjectBuildResults> GetProjectLastBuildBranch([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug, [AliasAs("buildBranch")]string buildBranch);

        /// <summary>
        /// Get project settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <returns>Task of ProjectSettingsResults</returns>
        [Get("/projects/{accountName}/{projectSlug}/settings")]
        System.Threading.Tasks.Task<ProjectSettingsResults> GetProjectSettings([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug);

        /// <summary>
        /// Get project settings in YAML
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <returns>Task of string</returns>
        [Get("/projects/{accountName}/{projectSlug}/settings/yaml")]
        System.Threading.Tasks.Task<string> GetProjectSettingsYaml([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug);

        /// <summary>
        /// Get project status badge image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusBadgeId">ID of the status badge (&#x60;statusBadgeId&#x60; from &#x60;ProjectWithConfiguration&#x60;).</param>
        /// <param name="svg">Return an SVG image instead of PNG?  Exclusive with &#x60;retina&#x60;. (optional, default to false)</param>
        /// <param name="retina">Return a larger image suitable for retina displays?  Exclusive with &#x60;svg&#x60;. (optional, default to false)</param>
        /// <param name="passingText">Text to show in badge when build is passing. (optional)</param>
        /// <param name="failingText">Text to show in badge when build is failing. (optional)</param>
        /// <param name="pendingText">Text to show in badge when build is pending. (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        [Get("/projects/status/{statusBadgeId}")]
        System.Threading.Tasks.Task<System.IO.Stream> GetProjectStatusBadge([Header("UserAgent")] string userAgent, [AliasAs("statusBadgeId")]string statusBadgeId, [AliasAs("svg")]bool? svg = null, [AliasAs("retina")]bool? retina = null, [AliasAs("passingText")]string passingText = null, [AliasAs("failingText")]string failingText = null, [AliasAs("pendingText")]string pendingText = null);

        /// <summary>
        /// Get projects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Project&gt;</returns>
        [Get("/projects")]
        System.Threading.Tasks.Task<List<Project>> GetProjects([Header("UserAgent")] string userAgent);

        /// <summary>
        /// Get status badge image for a project with a public repository
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="badgeRepoProvider">Repository provider supported for badges</param>
        /// <param name="repoAccountName">Account name with repository provider</param>
        /// <param name="repoSlug">Slug (URL component) of repository.</param>
        /// <param name="branch">Repository Branch (optional)</param>
        /// <param name="svg">Return an SVG image instead of PNG?  Exclusive with &#x60;retina&#x60;. (optional, default to false)</param>
        /// <param name="retina">Return a larger image suitable for retina displays?  Exclusive with &#x60;svg&#x60;. (optional, default to false)</param>
        /// <param name="passingText">Text to show in badge when build is passing. (optional)</param>
        /// <param name="failingText">Text to show in badge when build is failing. (optional)</param>
        /// <param name="pendingText">Text to show in badge when build is pending. (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        [Get("/projects/status/{badgeRepoProvider}/{repoAccountName}/{repoSlug}")]
        System.Threading.Tasks.Task<System.IO.Stream> GetPublicProjectStatusBadge([Header("UserAgent")] string userAgent, [AliasAs("badgeRepoProvider")]string badgeRepoProvider, [AliasAs("repoAccountName")]string repoAccountName, [AliasAs("repoSlug")]string repoSlug, [AliasAs("branch")]string branch = null, [AliasAs("svg")]bool? svg = null, [AliasAs("retina")]bool? retina = null, [AliasAs("passingText")]string passingText = null, [AliasAs("failingText")]string failingText = null, [AliasAs("pendingText")]string pendingText = null);

        /// <summary>
        /// Update project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        [Put("/projects")]
        System.Threading.Tasks.Task UpdateProject([Header("UserAgent")] string userAgent, [Body]ProjectWithConfiguration body);

        /// <summary>
        /// Update project build number
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        [Put("/projects/{accountName}/{projectSlug}/settings/build-number")]
        System.Threading.Tasks.Task UpdateProjectBuildNumber([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug, [Body]ProjectBuildNumberUpdate body);

        /// <summary>
        /// Update project environment variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        [Put("/projects/{accountName}/{projectSlug}/settings/environment-variables")]
        System.Threading.Tasks.Task UpdateProjectEnvironmentVariables([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug, [Body]List<StoredNameValue> body);

        /// <summary>
        /// Update project settings in YAML
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        /// <param name="projectSlug">Project Slug</param>
        /// <param name="body">The body of requests should contain YAML data.  It is unclear how to specify this since the OpenAPI spec requires &#x60;schema&#x60; without &#x60;type&#x60; for &#x60;in: body&#x60; parameters and does not allow &#x60;type: file&#x60; in &#x60;schema&#x60;.  See https://github.com/OAI/OpenAPI-Specification/issues/326 swagger-codegen (for Java, probably others) allows a binary string body parameter with non-application/json &#x60;consumes&#x60; to be passed through in the request body without conversion to JSON. </param>
        /// <returns>Task of void</returns>
        [Put("/projects/{accountName}/{projectSlug}/settings/yaml")]
        System.Threading.Tasks.Task UpdateProjectSettingsYaml([Header("UserAgent")] string userAgent, [AliasAs("accountName")]string accountName, [AliasAs("projectSlug")]string projectSlug, [Body]byte[] body);
        #endregion Asynchronous Operations
    }
}
