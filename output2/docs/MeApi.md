# EnodeApi.Api.MeApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DisconnectVendor**](MeApi.md#disconnectvendor) | **DELETE** /me/vendors/{vendor} | Disconnect Vendor |
| [**GetMe**](MeApi.md#getme) | **GET** /me | Get My User |

<a name="disconnectvendor"></a>
# **DisconnectVendor**
> void DisconnectVendor (AnyVendor vendor)

Disconnect Vendor

Disconnect a single Vendor from the User's account.  All stored data about their Vendor account will be deleted, and any vehicles that were provided by that Vendor will disappear from the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class DisconnectVendorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeApi(config);
            var vendor = new AnyVendor(); // AnyVendor | Vendor to be unlinked

            try
            {
                // Disconnect Vendor
                apiInstance.DisconnectVendor(vendor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.DisconnectVendor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisconnectVendorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disconnect Vendor
    apiInstance.DisconnectVendorWithHttpInfo(vendor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.DisconnectVendorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendor** | [**AnyVendor**](AnyVendor.md) | Vendor to be unlinked |  |

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

<a name="getme"></a>
# **GetMe**
> Me GetMe ()

Get My User

Returns metadata about the authenticated User, including a list of vendors for which the User has provided credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // Get My User
                Me result = apiInstance.GetMe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get My User
    ApiResponse<Me> response = apiInstance.GetMeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Me**](Me.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

