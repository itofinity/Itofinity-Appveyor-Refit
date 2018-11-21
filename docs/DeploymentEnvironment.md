# Itofinity.Appveyor.Refit.Model.DeploymentEnvironment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeploymentEnvironmentId** | **int?** |  | [optional] 
**Name** | **string** |  | [optional] 
**Provider** | [**DeploymentProviderType**](DeploymentProviderType.md) |  | [optional] 
**Created** | **DateTime?** |  | [optional] 
**Updated** | **DateTime?** |  | [optional] 
**AccountId** | **int?** |  | [optional] 
**ProjectsMode** | **int?** | 0 is \&quot;Any project can be deployed to the environment\&quot; 1 is \&quot;Only selected projects can be deployed to the environment\&quot; 2 is \&quot;All except selected projects can be deployed to the environment\&quot; | [optional] 
**SecurityDescriptor** | [**SecurityDescriptor**](SecurityDescriptor.md) |  | [optional] 
**Tags** | **string** | Comma-separated list of environment tags for dynamic grouping. Appears that any input is accepted.  The returned value only contains case-preserving but insensitive unique values where spaces around \&quot;,\&quot; are removed but otherwise preserved.  Empty values and items are allowed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

