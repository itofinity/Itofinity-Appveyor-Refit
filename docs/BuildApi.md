# Itofinity.Appveyor.Refit.Api.BuildApi

All URIs are relative to *https://ci.appveyor.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelBuild**](BuildApi.md#cancelbuild) | **Delete** /builds/{accountName}/{projectSlug}/{buildVersion} | Cancel build
[**GetBuildArtifact**](BuildApi.md#getbuildartifact) | **Get** /buildjobs/{jobId}/artifacts/{artifactFileName} | Download build artifact
[**GetBuildArtifacts**](BuildApi.md#getbuildartifacts) | **Get** /buildjobs/{jobId}/artifacts | Get build artifacts
[**GetBuildLog**](BuildApi.md#getbuildlog) | **Get** /buildjobs/{jobId}/log | Download build log
[**StartBuild**](BuildApi.md#startbuild) | **Post** /builds | Start build of branch most recent commit


<a name="cancelbuild"></a>
# **CancelBuild**
> void CancelBuild (string accountName, string projectSlug, string buildVersion)

Cancel build

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class CancelBuildExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new BuildApi();
            var accountName = accountName_example;  // string | AppVeyor account name (`accountName` property of `UserAccount`)
            var projectSlug = projectSlug_example;  // string | Project Slug
            var buildVersion = buildVersion_example;  // string | Build Version (`version` property of `Build`)

            try
            {
                // Cancel build
                apiInstance.CancelBuild(accountName, projectSlug, buildVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.CancelBuild: " + e.Message );
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

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildartifact"></a>
# **GetBuildArtifact**
> System.IO.Stream GetBuildArtifact (string jobId, string artifactFileName)

Download build artifact

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetBuildArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new BuildApi();
            var jobId = jobId_example;  // string | Build ID (`jobId` property of `BuildJob`)
            var artifactFileName = artifactFileName_example;  // string | File name (or path) of a build artifact file. Corresponds to the `fileName` property of `ArtifactModel`. URL-encoding of slashes in parameter values is optional.

            try
            {
                // Download build artifact
                System.IO.Stream result = apiInstance.GetBuildArtifact(jobId, artifactFileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetBuildArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| Build ID (&#x60;jobId&#x60; property of &#x60;BuildJob&#x60;) | 
 **artifactFileName** | **string**| File name (or path) of a build artifact file. Corresponds to the &#x60;fileName&#x60; property of &#x60;ArtifactModel&#x60;. URL-encoding of slashes in parameter values is optional. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildartifacts"></a>
# **GetBuildArtifacts**
> List<ArtifactModel> GetBuildArtifacts (string jobId)

Get build artifacts

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetBuildArtifactsExample
    {
        public void main()
        {
            
            var apiInstance = new BuildApi();
            var jobId = jobId_example;  // string | Build ID (`jobId` property of `BuildJob`)

            try
            {
                // Get build artifacts
                List&lt;ArtifactModel&gt; result = apiInstance.GetBuildArtifacts(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetBuildArtifacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| Build ID (&#x60;jobId&#x60; property of &#x60;BuildJob&#x60;) | 

### Return type

[**List<ArtifactModel>**](ArtifactModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildlog"></a>
# **GetBuildLog**
> System.IO.Stream GetBuildLog (string jobId)

Download build log

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetBuildLogExample
    {
        public void main()
        {
            
            var apiInstance = new BuildApi();
            var jobId = jobId_example;  // string | Build ID (`jobId` property of `BuildJob`)

            try
            {
                // Download build log
                System.IO.Stream result = apiInstance.GetBuildLog(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetBuildLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| Build ID (&#x60;jobId&#x60; property of &#x60;BuildJob&#x60;) | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startbuild"></a>
# **StartBuild**
> Build StartBuild (BuildStartRequest body)

Start build of branch most recent commit

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class StartBuildExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new BuildApi();
            var body = new BuildStartRequest(); // BuildStartRequest | 

            try
            {
                // Start build of branch most recent commit
                Build result = apiInstance.StartBuild(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.StartBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BuildStartRequest**](BuildStartRequest.md)|  | 

### Return type

[**Build**](Build.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

