# Itofinity.Appveyor.Refit.Api.DeploymentApi

All URIs are relative to *https://ci.appveyor.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelDeployment**](DeploymentApi.md#canceldeployment) | **Delete** /deployments/stop | Cancel deployment
[**GetDeployment**](DeploymentApi.md#getdeployment) | **Get** /deployments/{deploymentId} | Get deployment
[**StartDeployment**](DeploymentApi.md#startdeployment) | **Post** /deployments | Start deployment


<a name="canceldeployment"></a>
# **CancelDeployment**
> void CancelDeployment (DeploymentCancellation body)

Cancel deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class CancelDeploymentExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DeploymentApi();
            var body = new DeploymentCancellation(); // DeploymentCancellation | 

            try
            {
                // Cancel deployment
                apiInstance.CancelDeployment(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.CancelDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeploymentCancellation**](DeploymentCancellation.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeployment"></a>
# **GetDeployment**
> ProjectDeployment GetDeployment (int? deploymentId)

Get deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetDeploymentExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DeploymentApi();
            var deploymentId = 56;  // int? | Deployment ID (`deploymentId` property of `Deployment`)

            try
            {
                // Get deployment
                ProjectDeployment result = apiInstance.GetDeployment(deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentId** | **int?**| Deployment ID (&#x60;deploymentId&#x60; property of &#x60;Deployment&#x60;) | 

### Return type

[**ProjectDeployment**](ProjectDeployment.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startdeployment"></a>
# **StartDeployment**
> Deployment StartDeployment (DeploymentStartRequest body)

Start deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class StartDeploymentExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DeploymentApi();
            var body = new DeploymentStartRequest(); // DeploymentStartRequest | 

            try
            {
                // Start deployment
                Deployment result = apiInstance.StartDeployment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.StartDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeploymentStartRequest**](DeploymentStartRequest.md)|  | 

### Return type

[**Deployment**](Deployment.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

