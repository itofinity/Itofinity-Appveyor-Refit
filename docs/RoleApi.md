# Itofinity.Appveyor.Refit.Api.RoleApi

All URIs are relative to *https://ci.appveyor.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRole**](RoleApi.md#addrole) | **Post** /roles | Add role
[**DeleteRole**](RoleApi.md#deleterole) | **Delete** /roles/{roleId} | Delete role
[**GetRole**](RoleApi.md#getrole) | **Get** /roles/{roleId} | Get role
[**GetRoles**](RoleApi.md#getroles) | **Get** /roles | Get roles
[**UpdateRole**](RoleApi.md#updaterole) | **Put** /roles | Update role


<a name="addrole"></a>
# **AddRole**
> RoleWithGroups AddRole (RoleAddition body)

Add role

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class AddRoleExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RoleApi();
            var body = new RoleAddition(); // RoleAddition | 

            try
            {
                // Add role
                RoleWithGroups result = apiInstance.AddRole(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleApi.AddRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RoleAddition**](RoleAddition.md)|  | 

### Return type

[**RoleWithGroups**](RoleWithGroups.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterole"></a>
# **DeleteRole**
> void DeleteRole (int? roleId)

Delete role

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class DeleteRoleExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RoleApi();
            var roleId = 56;  // int? | Role ID

            try
            {
                // Delete role
                apiInstance.DeleteRole(roleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleApi.DeleteRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleId** | **int?**| Role ID | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrole"></a>
# **GetRole**
> RoleWithGroups GetRole (int? roleId)

Get role

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetRoleExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RoleApi();
            var roleId = 56;  // int? | Role ID

            try
            {
                // Get role
                RoleWithGroups result = apiInstance.GetRole(roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleApi.GetRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleId** | **int?**| Role ID | 

### Return type

[**RoleWithGroups**](RoleWithGroups.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroles"></a>
# **GetRoles**
> List<Role> GetRoles ()

Get roles

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetRolesExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RoleApi();

            try
            {
                // Get roles
                List&lt;Role&gt; result = apiInstance.GetRoles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleApi.GetRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Role>**](Role.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterole"></a>
# **UpdateRole**
> RoleWithGroups UpdateRole (RoleWithGroups body)

Update role

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RoleApi();
            var body = new RoleWithGroups(); // RoleWithGroups | 

            try
            {
                // Update role
                RoleWithGroups result = apiInstance.UpdateRole(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleApi.UpdateRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RoleWithGroups**](RoleWithGroups.md)|  | 

### Return type

[**RoleWithGroups**](RoleWithGroups.md)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

