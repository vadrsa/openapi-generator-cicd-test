# EnodeApi.Api.UserManagementApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteUsersUserid**](UserManagementApi.md#deleteusersuserid) | **DELETE** /users/{userId} | Unlink User |
| [**DeleteUsersUseridAuthorization**](UserManagementApi.md#deleteusersuseridauthorization) | **DELETE** /users/{userId}/authorization | Deauthorize User |
| [**PostUsersUseridLink**](UserManagementApi.md#postusersuseridlink) | **POST** /users/{userId}/link | Link User |

<a name="deleteusersuserid"></a>
# **DeleteUsersUserid**
> void DeleteUsersUserid (string userId)

Unlink User

Deletes a User and all of their data permanently and invalidates any associated sessions, authorization codes, and access/refresh tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class DeleteUsersUseridExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserManagementApi(config);
            var userId = "userId_example";  // string | ID of the User

            try
            {
                // Unlink User
                apiInstance.DeleteUsersUserid(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserManagementApi.DeleteUsersUserid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUsersUseridWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlink User
    apiInstance.DeleteUsersUseridWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserManagementApi.DeleteUsersUseridWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | ID of the User |  |

### Return type

void (empty response body)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusersuseridauthorization"></a>
# **DeleteUsersUseridAuthorization**
> void DeleteUsersUseridAuthorization (string userId)

Deauthorize User

Deletes the User's stored vendor authorizations and credentials, invalidates any associated sessions, authorization codes, and access/refresh tokens.  All other User data is retained, and if the User is sent through the Link User flow in the future, their account will be just as they left it.  No webhook events will be generated for a deauthorized user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class DeleteUsersUseridAuthorizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserManagementApi(config);
            var userId = "userId_example";  // string | ID of the User

            try
            {
                // Deauthorize User
                apiInstance.DeleteUsersUseridAuthorization(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserManagementApi.DeleteUsersUseridAuthorization: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUsersUseridAuthorizationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deauthorize User
    apiInstance.DeleteUsersUseridAuthorizationWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserManagementApi.DeleteUsersUseridAuthorizationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | ID of the User |  |

### Return type

void (empty response body)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusersuseridlink"></a>
# **PostUsersUseridLink**
> LinkUserResponse PostUsersUseridLink (string userId, LinkUserOptions? linkUserOptions = null)

Link User

Creates an Enode Link session attached to the provided User ID. If this User does not exist, it will be created. The returned `linkState` gives the User short-lived (24hs) access to Enode Link. A URL for Enode Link for the user to initiate asset linking is also returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PostUsersUseridLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserManagementApi(config);
            var userId = "userId_example";  // string | ID of the User
            var linkUserOptions = new LinkUserOptions?(); // LinkUserOptions? |  (optional) 

            try
            {
                // Link User
                LinkUserResponse result = apiInstance.PostUsersUseridLink(userId, linkUserOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserManagementApi.PostUsersUseridLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostUsersUseridLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Link User
    ApiResponse<LinkUserResponse> response = apiInstance.PostUsersUseridLinkWithHttpInfo(userId, linkUserOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserManagementApi.PostUsersUseridLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | ID of the User |  |
| **linkUserOptions** | [**LinkUserOptions?**](LinkUserOptions?.md) |  | [optional]  |

### Return type

[**LinkUserResponse**](LinkUserResponse.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |
| **403** | Connections limit reached for this clients |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

