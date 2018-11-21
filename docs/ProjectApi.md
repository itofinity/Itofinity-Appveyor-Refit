# Itofinity.Appveyor.Refit.Api.ProjectApi

All URIs are relative to *https://ci.appveyor.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddProject**](ProjectApi.md#addproject) | **Post** /projects | Add project
[**DeleteProject**](ProjectApi.md#deleteproject) | **Delete** /projects/{accountName}/{projectSlug} | Delete project
[**DeleteProjectBuildCache**](ProjectApi.md#deleteprojectbuildcache) | **Delete** /projects/{accountName}/{projectSlug}/buildcache | Delete project build cache
[**EncryptValue**](ProjectApi.md#encryptvalue) | **Post** /account/encrypt | Encrypt a value for use in StoredValue.
[**GetProjectArtifact**](ProjectApi.md#getprojectartifact) | **Get** /projects/{accountName}/{projectSlug}/artifacts/{artifactFileName} | Get last successful build artifact
[**GetProjectBranchStatusBadge**](ProjectApi.md#getprojectbranchstatusbadge) | **Get** /projects/status/{statusBadgeId}/branch/{buildBranch} | Get project branch status badge image
[**GetProjectBuildByVersion**](ProjectApi.md#getprojectbuildbyversion) | **Get** /projects/{accountName}/{projectSlug}/build/{buildVersion} | Get project build by version
[**GetProjectDeployments**](ProjectApi.md#getprojectdeployments) | **Get** /projects/{accountName}/{projectSlug}/deployments | Get project deployments
[**GetProjectEnvironmentVariables**](ProjectApi.md#getprojectenvironmentvariables) | **Get** /projects/{accountName}/{projectSlug}/settings/environment-variables | Get project environment variables
[**GetProjectHistory**](ProjectApi.md#getprojecthistory) | **Get** /projects/{accountName}/{projectSlug}/history | Get project history
[**GetProjectLastBuild**](ProjectApi.md#getprojectlastbuild) | **Get** /projects/{accountName}/{projectSlug} | Get project last build
[**GetProjectLastBuildBranch**](ProjectApi.md#getprojectlastbuildbranch) | **Get** /projects/{accountName}/{projectSlug}/branch/{buildBranch} | Get project last branch build
[**GetProjectSettings**](ProjectApi.md#getprojectsettings) | **Get** /projects/{accountName}/{projectSlug}/settings | Get project settings
[**GetProjectSettingsYaml**](ProjectApi.md#getprojectsettingsyaml) | **Get** /projects/{accountName}/{projectSlug}/settings/yaml | Get project settings in YAML
[**GetProjectStatusBadge**](ProjectApi.md#getprojectstatusbadge) | **Get** /projects/status/{statusBadgeId} | Get project status badge image
[**GetProjects**](ProjectApi.md#getprojects) | **Get** /projects | Get projects
[**GetPublicProjectStatusBadge**](ProjectApi.md#getpublicprojectstatusbadge) | **Get** /projects/status/{badgeRepoProvider}/{repoAccountName}/{repoSlug} | Get status badge image for a project with a public repository
[**UpdateProject**](ProjectApi.md#updateproject) | **Put** /projects | Update project
[**UpdateProjectBuildNumber**](ProjectApi.md#updateprojectbuildnumber) | **Put** /projects/{accountName}/{projectSlug}/settings/build-number | Update project build number
[**UpdateProjectEnvironmentVariables**](ProjectApi.md#updateprojectenvironmentvariables) | **Put** /projects/{accountName}/{projectSlug}/settings/environment-variables | Update project environment variables
[**UpdateProjectSettingsYaml**](ProjectApi.md#updateprojectsettingsyaml) | **Put** /projects/{accountName}/{projectSlug}/settings/yaml | Update project settings in YAML


<a name="addproject"></a>
# **AddProject**
> Project AddProject (ProjectAddition body)

Add project

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class AddProjectExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var body = new ProjectAddition(); // ProjectAddition | 

            try
            {
                // Add project
                Project result = apiInstance.AddProject(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.AddProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectAddition**](ProjectAddition.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproject"></a>
# **DeleteProject**
> void DeleteProject (string accountName, string projectSlug)

Delete project

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class DeleteProjectExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug

            try
            {
                // Delete project
                apiInstance.DeleteProject(accountName, projectSlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.DeleteProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprojectbuildcache"></a>
# **DeleteProjectBuildCache**
> void DeleteProjectBuildCache (string accountName, string projectSlug)

Delete project build cache

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class DeleteProjectBuildCacheExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug

            try
            {
                // Delete project build cache
                apiInstance.DeleteProjectBuildCache(accountName, projectSlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.DeleteProjectBuildCache: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encryptvalue"></a>
# **EncryptValue**
> string EncryptValue (EncryptRequest body)

Encrypt a value for use in StoredValue.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class EncryptValueExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var body = new EncryptRequest(); // EncryptRequest | 

            try
            {
                // Encrypt a value for use in StoredValue.
                string result = apiInstance.EncryptValue(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.EncryptValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EncryptRequest**](EncryptRequest.md)|  | 

### Return type

**string**

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectartifact"></a>
# **GetProjectArtifact**
> System.IO.Stream GetProjectArtifact (string accountName, string projectSlug, string artifactFileName, string branch = null, string tag = null, string job = null, bool? all = null, bool? pr = null)

Get last successful build artifact

The `job` parameter is mandatory if the build contains multiple jobs.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug
            var artifactFileName = artifactFileName_example;  // string | File name (or path) of a build artifact file. Corresponds to the `fileName` property of `ArtifactModel`. URL-encoding of slashes in parameter values is optional.
            var branch = branch_example;  // string | Repository Branch (optional) 
            var tag = tag_example;  // string | A git (or other VCS) tag (optional) 
            var job = job_example;  // string | Name of the build job. (optional) 
            var all = true;  // bool? | Include not only `successful`, but also jobs with `failed`, and `cancelled` status. (optional)  (default to false)
            var pr = true;  // bool? | Include PR builds in the search results? `true` - take artifact from PR builds only; `false` - do not look for artifact in PR builds; default/unspecified - look for artifact in both PR an non-PR builds.  (optional) 

            try
            {
                // Get last successful build artifact
                System.IO.Stream result = apiInstance.GetProjectArtifact(accountName, projectSlug, artifactFileName, branch, tag, job, all, pr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 
 **artifactFileName** | **string**| File name (or path) of a build artifact file. Corresponds to the &#x60;fileName&#x60; property of &#x60;ArtifactModel&#x60;. URL-encoding of slashes in parameter values is optional. | 
 **branch** | **string**| Repository Branch | [optional] 
 **tag** | **string**| A git (or other VCS) tag | [optional] 
 **job** | **string**| Name of the build job. | [optional] 
 **all** | **bool?**| Include not only &#x60;successful&#x60;, but also jobs with &#x60;failed&#x60;, and &#x60;cancelled&#x60; status. | [optional] [default to false]
 **pr** | **bool?**| Include PR builds in the search results? &#x60;true&#x60; - take artifact from PR builds only; &#x60;false&#x60; - do not look for artifact in PR builds; default/unspecified - look for artifact in both PR an non-PR builds.  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectbranchstatusbadge"></a>
# **GetProjectBranchStatusBadge**
> System.IO.Stream GetProjectBranchStatusBadge (string statusBadgeId, string buildBranch, bool? svg = null, bool? retina = null, string passingText = null, string failingText = null, string pendingText = null)

Get project branch status badge image

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectBranchStatusBadgeExample
    {
        public void main()
        {
            
            var apiInstance = new ProjectApi();
            var statusBadgeId = statusBadgeId_example;  // string | ID of the status badge (`statusBadgeId` from `ProjectWithConfiguration`).
            var buildBranch = buildBranch_example;  // string | Build Branch
            var svg = true;  // bool? | Return an SVG image instead of PNG?  Exclusive with `retina`. (optional)  (default to false)
            var retina = true;  // bool? | Return a larger image suitable for retina displays?  Exclusive with `svg`. (optional)  (default to false)
            var passingText = passingText_example;  // string | Text to show in badge when build is passing. (optional) 
            var failingText = failingText_example;  // string | Text to show in badge when build is failing. (optional) 
            var pendingText = pendingText_example;  // string | Text to show in badge when build is pending. (optional) 

            try
            {
                // Get project branch status badge image
                System.IO.Stream result = apiInstance.GetProjectBranchStatusBadge(statusBadgeId, buildBranch, svg, retina, passingText, failingText, pendingText);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectBranchStatusBadge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **statusBadgeId** | **string**| ID of the status badge (&#x60;statusBadgeId&#x60; from &#x60;ProjectWithConfiguration&#x60;). | 
 **buildBranch** | **string**| Build Branch | 
 **svg** | **bool?**| Return an SVG image instead of PNG?  Exclusive with &#x60;retina&#x60;. | [optional] [default to false]
 **retina** | **bool?**| Return a larger image suitable for retina displays?  Exclusive with &#x60;svg&#x60;. | [optional] [default to false]
 **passingText** | **string**| Text to show in badge when build is passing. | [optional] 
 **failingText** | **string**| Text to show in badge when build is failing. | [optional] 
 **pendingText** | **string**| Text to show in badge when build is pending. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: image/svg+xml, image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectbuildbyversion"></a>
# **GetProjectBuildByVersion**
> ProjectBuildResults GetProjectBuildByVersion (string accountName, string projectSlug, string buildVersion)

Get project build by version

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectBuildByVersionExample
    {
        public void main()
        {
            
            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug
            var buildVersion = buildVersion_example;  // string | Build Version (`version` property of `Build`)

            try
            {
                // Get project build by version
                ProjectBuildResults result = apiInstance.GetProjectBuildByVersion(accountName, projectSlug, buildVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectBuildByVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 
 **buildVersion** | **string**| Build Version (&#x60;version&#x60; property of &#x60;Build&#x60;) | 

### Return type

[**ProjectBuildResults**](ProjectBuildResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectdeployments"></a>
# **GetProjectDeployments**
> ProjectDeploymentsResults GetProjectDeployments (string accountName, string projectSlug, int? recordsNumber)

Get project deployments

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectDeploymentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug
            var recordsNumber = 56;  // int? | Number of results to include in the response. getProjectDeployments is documented to have a maximum of 20. It currently returns 500 Internal Server Error for recordsNumber <= 5. In the past it has returned 500 Internal Server Error for many different values which did not match the value used by the ci.appveyor.com web interface at the time.  As of 2018-09-08, the value used by the web interface is 10.

            try
            {
                // Get project deployments
                ProjectDeploymentsResults result = apiInstance.GetProjectDeployments(accountName, projectSlug, recordsNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 
 **recordsNumber** | **int?**| Number of results to include in the response. getProjectDeployments is documented to have a maximum of 20. It currently returns 500 Internal Server Error for recordsNumber &lt;&#x3D; 5. In the past it has returned 500 Internal Server Error for many different values which did not match the value used by the ci.appveyor.com web interface at the time.  As of 2018-09-08, the value used by the web interface is 10. | 

### Return type

[**ProjectDeploymentsResults**](ProjectDeploymentsResults.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectenvironmentvariables"></a>
# **GetProjectEnvironmentVariables**
> List<StoredNameValue> GetProjectEnvironmentVariables (string accountName, string projectSlug)

Get project environment variables

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectEnvironmentVariablesExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug

            try
            {
                // Get project environment variables
                List&lt;StoredNameValue&gt; result = apiInstance.GetProjectEnvironmentVariables(accountName, projectSlug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectEnvironmentVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 

### Return type

[**List<StoredNameValue>**](StoredNameValue.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojecthistory"></a>
# **GetProjectHistory**
> ProjectHistory GetProjectHistory (string accountName, string projectSlug, int? recordsNumber, int? startBuildId = null, string branch = null)

Get project history

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectHistoryExample
    {
        public void main()
        {
            
            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug
            var recordsNumber = 56;  // int? | Number of results to include in the response. getProjectDeployments is documented to have a maximum of 20. It currently returns 500 Internal Server Error for recordsNumber <= 5. In the past it has returned 500 Internal Server Error for many different values which did not match the value used by the ci.appveyor.com web interface at the time.  As of 2018-09-08, the value used by the web interface is 10.
            var startBuildId = 56;  // int? | Maximum `buildId` to include in the results (exclusive). (optional) 
            var branch = branch_example;  // string | Repository Branch (optional) 

            try
            {
                // Get project history
                ProjectHistory result = apiInstance.GetProjectHistory(accountName, projectSlug, recordsNumber, startBuildId, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 
 **recordsNumber** | **int?**| Number of results to include in the response. getProjectDeployments is documented to have a maximum of 20. It currently returns 500 Internal Server Error for recordsNumber &lt;&#x3D; 5. In the past it has returned 500 Internal Server Error for many different values which did not match the value used by the ci.appveyor.com web interface at the time.  As of 2018-09-08, the value used by the web interface is 10. | 
 **startBuildId** | **int?**| Maximum &#x60;buildId&#x60; to include in the results (exclusive). | [optional] 
 **branch** | **string**| Repository Branch | [optional] 

### Return type

[**ProjectHistory**](ProjectHistory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectlastbuild"></a>
# **GetProjectLastBuild**
> ProjectBuildResults GetProjectLastBuild (string accountName, string projectSlug)

Get project last build

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectLastBuildExample
    {
        public void main()
        {
            
            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug

            try
            {
                // Get project last build
                ProjectBuildResults result = apiInstance.GetProjectLastBuild(accountName, projectSlug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectLastBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 

### Return type

[**ProjectBuildResults**](ProjectBuildResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectlastbuildbranch"></a>
# **GetProjectLastBuildBranch**
> ProjectBuildResults GetProjectLastBuildBranch (string accountName, string projectSlug, string buildBranch)

Get project last branch build

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectLastBuildBranchExample
    {
        public void main()
        {
            
            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug
            var buildBranch = buildBranch_example;  // string | Build Branch

            try
            {
                // Get project last branch build
                ProjectBuildResults result = apiInstance.GetProjectLastBuildBranch(accountName, projectSlug, buildBranch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectLastBuildBranch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 
 **buildBranch** | **string**| Build Branch | 

### Return type

[**ProjectBuildResults**](ProjectBuildResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectsettings"></a>
# **GetProjectSettings**
> ProjectSettingsResults GetProjectSettings (string accountName, string projectSlug)

Get project settings

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug

            try
            {
                // Get project settings
                ProjectSettingsResults result = apiInstance.GetProjectSettings(accountName, projectSlug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 

### Return type

[**ProjectSettingsResults**](ProjectSettingsResults.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectsettingsyaml"></a>
# **GetProjectSettingsYaml**
> string GetProjectSettingsYaml (string accountName, string projectSlug)

Get project settings in YAML

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectSettingsYamlExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug

            try
            {
                // Get project settings in YAML
                string result = apiInstance.GetProjectSettingsYaml(accountName, projectSlug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectSettingsYaml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 

### Return type

**string**

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectstatusbadge"></a>
# **GetProjectStatusBadge**
> System.IO.Stream GetProjectStatusBadge (string statusBadgeId, bool? svg = null, bool? retina = null, string passingText = null, string failingText = null, string pendingText = null)

Get project status badge image

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectStatusBadgeExample
    {
        public void main()
        {
            
            var apiInstance = new ProjectApi();
            var statusBadgeId = statusBadgeId_example;  // string | ID of the status badge (`statusBadgeId` from `ProjectWithConfiguration`).
            var svg = true;  // bool? | Return an SVG image instead of PNG?  Exclusive with `retina`. (optional)  (default to false)
            var retina = true;  // bool? | Return a larger image suitable for retina displays?  Exclusive with `svg`. (optional)  (default to false)
            var passingText = passingText_example;  // string | Text to show in badge when build is passing. (optional) 
            var failingText = failingText_example;  // string | Text to show in badge when build is failing. (optional) 
            var pendingText = pendingText_example;  // string | Text to show in badge when build is pending. (optional) 

            try
            {
                // Get project status badge image
                System.IO.Stream result = apiInstance.GetProjectStatusBadge(statusBadgeId, svg, retina, passingText, failingText, pendingText);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectStatusBadge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **statusBadgeId** | **string**| ID of the status badge (&#x60;statusBadgeId&#x60; from &#x60;ProjectWithConfiguration&#x60;). | 
 **svg** | **bool?**| Return an SVG image instead of PNG?  Exclusive with &#x60;retina&#x60;. | [optional] [default to false]
 **retina** | **bool?**| Return a larger image suitable for retina displays?  Exclusive with &#x60;svg&#x60;. | [optional] [default to false]
 **passingText** | **string**| Text to show in badge when build is passing. | [optional] 
 **failingText** | **string**| Text to show in badge when build is failing. | [optional] 
 **pendingText** | **string**| Text to show in badge when build is pending. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: image/svg+xml, image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojects"></a>
# **GetProjects**
> List<Project> GetProjects ()

Get projects

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetProjectsExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();

            try
            {
                // Get projects
                List&lt;Project&gt; result = apiInstance.GetProjects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Project>**](Project.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpublicprojectstatusbadge"></a>
# **GetPublicProjectStatusBadge**
> System.IO.Stream GetPublicProjectStatusBadge (string badgeRepoProvider, string repoAccountName, string repoSlug, string branch = null, bool? svg = null, bool? retina = null, string passingText = null, string failingText = null, string pendingText = null)

Get status badge image for a project with a public repository

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetPublicProjectStatusBadgeExample
    {
        public void main()
        {
            
            var apiInstance = new ProjectApi();
            var badgeRepoProvider = badgeRepoProvider_example;  // string | Repository provider supported for badges
            var repoAccountName = repoAccountName_example;  // string | Account name with repository provider
            var repoSlug = repoSlug_example;  // string | Slug (URL component) of repository.
            var branch = branch_example;  // string | Repository Branch (optional) 
            var svg = true;  // bool? | Return an SVG image instead of PNG?  Exclusive with `retina`. (optional)  (default to false)
            var retina = true;  // bool? | Return a larger image suitable for retina displays?  Exclusive with `svg`. (optional)  (default to false)
            var passingText = passingText_example;  // string | Text to show in badge when build is passing. (optional) 
            var failingText = failingText_example;  // string | Text to show in badge when build is failing. (optional) 
            var pendingText = pendingText_example;  // string | Text to show in badge when build is pending. (optional) 

            try
            {
                // Get status badge image for a project with a public repository
                System.IO.Stream result = apiInstance.GetPublicProjectStatusBadge(badgeRepoProvider, repoAccountName, repoSlug, branch, svg, retina, passingText, failingText, pendingText);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetPublicProjectStatusBadge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **badgeRepoProvider** | **string**| Repository provider supported for badges | 
 **repoAccountName** | **string**| Account name with repository provider | 
 **repoSlug** | **string**| Slug (URL component) of repository. | 
 **branch** | **string**| Repository Branch | [optional] 
 **svg** | **bool?**| Return an SVG image instead of PNG?  Exclusive with &#x60;retina&#x60;. | [optional] [default to false]
 **retina** | **bool?**| Return a larger image suitable for retina displays?  Exclusive with &#x60;svg&#x60;. | [optional] [default to false]
 **passingText** | **string**| Text to show in badge when build is passing. | [optional] 
 **failingText** | **string**| Text to show in badge when build is failing. | [optional] 
 **pendingText** | **string**| Text to show in badge when build is pending. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: image/svg+xml, image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproject"></a>
# **UpdateProject**
> void UpdateProject (ProjectWithConfiguration body)

Update project

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class UpdateProjectExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var body = new ProjectWithConfiguration(); // ProjectWithConfiguration | 

            try
            {
                // Update project
                apiInstance.UpdateProject(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.UpdateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectWithConfiguration**](ProjectWithConfiguration.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprojectbuildnumber"></a>
# **UpdateProjectBuildNumber**
> void UpdateProjectBuildNumber (string accountName, string projectSlug, ProjectBuildNumberUpdate body)

Update project build number

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class UpdateProjectBuildNumberExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug
            var body = new ProjectBuildNumberUpdate(); // ProjectBuildNumberUpdate | 

            try
            {
                // Update project build number
                apiInstance.UpdateProjectBuildNumber(accountName, projectSlug, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.UpdateProjectBuildNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 
 **body** | [**ProjectBuildNumberUpdate**](ProjectBuildNumberUpdate.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprojectenvironmentvariables"></a>
# **UpdateProjectEnvironmentVariables**
> void UpdateProjectEnvironmentVariables (string accountName, string projectSlug, List<StoredNameValue> body)

Update project environment variables

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class UpdateProjectEnvironmentVariablesExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug
            var body = new List<StoredNameValue>(); // List<StoredNameValue> | 

            try
            {
                // Update project environment variables
                apiInstance.UpdateProjectEnvironmentVariables(accountName, projectSlug, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.UpdateProjectEnvironmentVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 
 **body** | [**List&lt;StoredNameValue&gt;**](StoredNameValue.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprojectsettingsyaml"></a>
# **UpdateProjectSettingsYaml**
> void UpdateProjectSettingsYaml (string accountName, string projectSlug, byte[] body)

Update project settings in YAML

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class UpdateProjectSettingsYamlExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ProjectApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug
            var body = BINARY_DATA_HERE;  // byte[] | The body of requests should contain YAML data.  It is unclear how to specify this since the OpenAPI spec requires `schema` without `type` for `in: body` parameters and does not allow `type: file` in `schema`.  See https://github.com/OAI/OpenAPI-Specification/issues/326 swagger-codegen (for Java, probably others) allows a binary string body parameter with non-application/json `consumes` to be passed through in the request body without conversion to JSON. 

            try
            {
                // Update project settings in YAML
                apiInstance.UpdateProjectSettingsYaml(accountName, projectSlug, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.UpdateProjectSettingsYaml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountName** | **string**| AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;) | 
 **projectSlug** | **string**| Project Slug | 
 **body** | **byte[]**| The body of requests should contain YAML data.  It is unclear how to specify this since the OpenAPI spec requires &#x60;schema&#x60; without &#x60;type&#x60; for &#x60;in: body&#x60; parameters and does not allow &#x60;type: file&#x60; in &#x60;schema&#x60;.  See https://github.com/OAI/OpenAPI-Specification/issues/326 swagger-codegen (for Java, probably others) allows a binary string body parameter with non-application/json &#x60;consumes&#x60; to be passed through in the request body without conversion to JSON.  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

