# Itofinity.Appveyor.Refit.Api.CollaboratorApi

All URIs are relative to *https://ci.appveyor.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCollaborator**](CollaboratorApi.md#addcollaborator) | **Post** /collaborators | Add collaborator
[**DeleteCollaborator**](CollaboratorApi.md#deletecollaborator) | **Delete** /collaborators/{userId} | Delete collaborator
[**GetCollaborator**](CollaboratorApi.md#getcollaborator) | **Get** /collaborators/{userId} | Get collaborator
[**GetCollaborators**](CollaboratorApi.md#getcollaborators) | **Get** /collaborators | Get collaborators
[**UpdateCollaborator**](CollaboratorApi.md#updatecollaborator) | **Put** /collaborators | Update collaborator


<a name="addcollaborator"></a>
# **AddCollaborator**
> void AddCollaborator (CollaboratorAddition body)

Add collaborator

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class AddCollaboratorExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CollaboratorApi();
            var body = new CollaboratorAddition(); // CollaboratorAddition | 

            try
            {
                // Add collaborator
                apiInstance.AddCollaborator(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaboratorApi.AddCollaborator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CollaboratorAddition**](CollaboratorAddition.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollaborator"></a>
# **DeleteCollaborator**
> void DeleteCollaborator (int? userId)

Delete collaborator

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class DeleteCollaboratorExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CollaboratorApi();
            var userId = 56;  // int? | User ID

            try
            {
                // Delete collaborator
                apiInstance.DeleteCollaborator(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaboratorApi.DeleteCollaborator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| User ID | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollaborator"></a>
# **GetCollaborator**
> UserAccountRolesResults GetCollaborator (int? userId)

Get collaborator

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetCollaboratorExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CollaboratorApi();
            var userId = 56;  // int? | User ID

            try
            {
                // Get collaborator
                UserAccountRolesResults result = apiInstance.GetCollaborator(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaboratorApi.GetCollaborator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| User ID | 

### Return type

[**UserAccountRolesResults**](UserAccountRolesResults.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollaborators"></a>
# **GetCollaborators**
> List<UserAccount> GetCollaborators ()

Get collaborators

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetCollaboratorsExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CollaboratorApi();

            try
            {
                // Get collaborators
                List&lt;UserAccount&gt; result = apiInstance.GetCollaborators();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaboratorApi.GetCollaborators: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserAccount>**](UserAccount.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecollaborator"></a>
# **UpdateCollaborator**
> void UpdateCollaborator (CollaboratorUpdate body)

Update collaborator

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class UpdateCollaboratorExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CollaboratorApi();
            var body = new CollaboratorUpdate(); // CollaboratorUpdate | 

            try
            {
                // Update collaborator
                apiInstance.UpdateCollaborator(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaboratorApi.UpdateCollaborator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CollaboratorUpdate**](CollaboratorUpdate.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

