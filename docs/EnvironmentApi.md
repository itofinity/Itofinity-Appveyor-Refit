# Itofinity.Appveyor.Refit.Api.EnvironmentApi

All URIs are relative to *https://ci.appveyor.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEnvironment**](EnvironmentApi.md#addenvironment) | **Post** /environments | Add environment
[**DeleteEnvironment**](EnvironmentApi.md#deleteenvironment) | **Delete** /environments/{deploymentEnvironmentId} | Delete environment
[**GetEnvironmentDeployments**](EnvironmentApi.md#getenvironmentdeployments) | **Get** /environments/{deploymentEnvironmentId}/deployments | Get environment deployments
[**GetEnvironmentSettings**](EnvironmentApi.md#getenvironmentsettings) | **Get** /environments/{deploymentEnvironmentId}/settings | Get environment settings
[**GetEnvironments**](EnvironmentApi.md#getenvironments) | **Get** /environments | Get environments
[**UpdateEnvironment**](EnvironmentApi.md#updateenvironment) | **Put** /environments | Update environment


<a name="addenvironment"></a>
# **AddEnvironment**
> DeploymentEnvironmentWithSettings AddEnvironment (DeploymentEnvironmentAddition body)

Add environment

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class AddEnvironmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentApi();
            var body = new DeploymentEnvironmentAddition(); // DeploymentEnvironmentAddition | 

            try
            {
                // Add environment
                DeploymentEnvironmentWithSettings result = apiInstance.AddEnvironment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.AddEnvironment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeploymentEnvironmentAddition**](DeploymentEnvironmentAddition.md)|  | 

### Return type

[**DeploymentEnvironmentWithSettings**](DeploymentEnvironmentWithSettings.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteenvironment"></a>
# **DeleteEnvironment**
> void DeleteEnvironment (int? deploymentEnvironmentId)

Delete environment

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class DeleteEnvironmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentApi();
            var deploymentEnvironmentId = 56;  // int? | Deployment Environment ID (`deploymentEnvironmentId` property of `DeploymentEnvironment`) 

            try
            {
                // Delete environment
                apiInstance.DeleteEnvironment(deploymentEnvironmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.DeleteEnvironment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentEnvironmentId** | **int?**| Deployment Environment ID (&#x60;deploymentEnvironmentId&#x60; property of &#x60;DeploymentEnvironment&#x60;)  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getenvironmentdeployments"></a>
# **GetEnvironmentDeployments**
> DeploymentEnvironmentDeploymentsResults GetEnvironmentDeployments (int? deploymentEnvironmentId)

Get environment deployments

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetEnvironmentDeploymentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentApi();
            var deploymentEnvironmentId = 56;  // int? | Deployment Environment ID (`deploymentEnvironmentId` property of `DeploymentEnvironment`) 

            try
            {
                // Get environment deployments
                DeploymentEnvironmentDeploymentsResults result = apiInstance.GetEnvironmentDeployments(deploymentEnvironmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.GetEnvironmentDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentEnvironmentId** | **int?**| Deployment Environment ID (&#x60;deploymentEnvironmentId&#x60; property of &#x60;DeploymentEnvironment&#x60;)  | 

### Return type

[**DeploymentEnvironmentDeploymentsResults**](DeploymentEnvironmentDeploymentsResults.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getenvironmentsettings"></a>
# **GetEnvironmentSettings**
> DeploymentEnvironmentSettingsResults GetEnvironmentSettings (int? deploymentEnvironmentId)

Get environment settings

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetEnvironmentSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentApi();
            var deploymentEnvironmentId = 56;  // int? | Deployment Environment ID (`deploymentEnvironmentId` property of `DeploymentEnvironment`) 

            try
            {
                // Get environment settings
                DeploymentEnvironmentSettingsResults result = apiInstance.GetEnvironmentSettings(deploymentEnvironmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.GetEnvironmentSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentEnvironmentId** | **int?**| Deployment Environment ID (&#x60;deploymentEnvironmentId&#x60; property of &#x60;DeploymentEnvironment&#x60;)  | 

### Return type

[**DeploymentEnvironmentSettingsResults**](DeploymentEnvironmentSettingsResults.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getenvironments"></a>
# **GetEnvironments**
> List<DeploymentEnvironmentLookupModel> GetEnvironments ()

Get environments

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetEnvironmentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentApi();

            try
            {
                // Get environments
                List&lt;DeploymentEnvironmentLookupModel&gt; result = apiInstance.GetEnvironments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.GetEnvironments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DeploymentEnvironmentLookupModel>**](DeploymentEnvironmentLookupModel.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateenvironment"></a>
# **UpdateEnvironment**
> DeploymentEnvironmentWithSettings UpdateEnvironment (DeploymentEnvironmentWithSettings body)

Update environment

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class UpdateEnvironmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentApi();
            var body = new DeploymentEnvironmentWithSettings(); // DeploymentEnvironmentWithSettings | 

            try
            {
                // Update environment
                DeploymentEnvironmentWithSettings result = apiInstance.UpdateEnvironment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.UpdateEnvironment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeploymentEnvironmentWithSettings**](DeploymentEnvironmentWithSettings.md)|  | 

### Return type

[**DeploymentEnvironmentWithSettings**](DeploymentEnvironmentWithSettings.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

