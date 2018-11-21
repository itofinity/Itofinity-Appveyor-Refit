# Itofinity.Appveyor.Refit.Api.UserApi

All URIs are relative to *https://ci.appveyor.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUser**](UserApi.md#adduser) | **Post** /users | Add user
[**DeleteUser**](UserApi.md#deleteuser) | **Delete** /users/{userId} | Delete user
[**GetUser**](UserApi.md#getuser) | **Get** /users/{userId} | Get user
[**GetUsers**](UserApi.md#getusers) | **Get** /users | Get users
[**UpdateUser**](UserApi.md#updateuser) | **Put** /users | Update user


<a name="adduser"></a>
# **AddUser**
> void AddUser (UserAddition body)

Add user

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class AddUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var body = new UserAddition(); // UserAddition | 

            try
            {
                // Add user
                apiInstance.AddUser(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.AddUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAddition**](UserAddition.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (int? userId)

Delete user

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var userId = 56;  // int? | User ID

            try
            {
                // Delete user
                apiInstance.DeleteUser(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUser: " + e.Message );
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

<a name="getuser"></a>
# **GetUser**
> UserAccountRolesResults GetUser (int? userId)

Get user

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var userId = 56;  // int? | User ID

            try
            {
                // Get user
                UserAccountRolesResults result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUser: " + e.Message );
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

<a name="getusers"></a>
# **GetUsers**
> List<UserAccount> GetUsers ()

Get users

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                // Get users
                List&lt;UserAccount&gt; result = apiInstance.GetUsers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUsers: " + e.Message );
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

<a name="updateuser"></a>
# **UpdateUser**
> void UpdateUser (UserAccount body)

Update user

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var body = new UserAccount(); // UserAccount | 

            try
            {
                // Update user
                apiInstance.UpdateUser(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccount**](UserAccount.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

