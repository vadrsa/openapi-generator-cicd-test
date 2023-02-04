# EnodeApi.Api.ChargingLocationsApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssociateChargingLocationWithTariff**](ChargingLocationsApi.md#associatecharginglocationwithtariff) | **PUT** /charging-locations/{chargingLocationId}/tariff | Associate Charging Location With Tariff |
| [**DeleteCharginglocationsCharginglocationid**](ChargingLocationsApi.md#deletecharginglocationscharginglocationid) | **DELETE** /charging-locations/{chargingLocationId} | Delete Charging Location |
| [**GetChargingLocationTariff**](ChargingLocationsApi.md#getcharginglocationtariff) | **GET** /charging-locations/{chargingLocationId}/tariff | Get Charging Location Tariff |
| [**GetCharginglocations**](ChargingLocationsApi.md#getcharginglocations) | **GET** /charging-locations | List Charging Locations |
| [**GetCharginglocationsCharginglocationid**](ChargingLocationsApi.md#getcharginglocationscharginglocationid) | **GET** /charging-locations/{chargingLocationId} | Get Charging Location |
| [**PostCharginglocations**](ChargingLocationsApi.md#postcharginglocations) | **POST** /charging-locations | Create Charging Location |
| [**PutCharginglocationsCharginglocationid**](ChargingLocationsApi.md#putcharginglocationscharginglocationid) | **PUT** /charging-locations/{chargingLocationId} | Update Charging Location |

<a name="associatecharginglocationwithtariff"></a>
# **AssociateChargingLocationWithTariff**
> void AssociateChargingLocationWithTariff (string chargingLocationId, ChargingLocationTariffInterval? chargingLocationTariffInterval = null)

Associate Charging Location With Tariff

Associates a tariff to a charging location and specifies time intervals for the tariff's rates at this location. Further requests will overwrite the existing intervals for the specified tariffId. Multiple tariffs can be associated with a Charging Location. To disassociate a particular tariff, send a request with the tariffId and an empty tariffInterval list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class AssociateChargingLocationWithTariffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargingLocationsApi(config);
            var chargingLocationId = "chargingLocationId_example";  // string | ID of the Charging Location
            var chargingLocationTariffInterval = new ChargingLocationTariffInterval?(); // ChargingLocationTariffInterval? |  (optional) 

            try
            {
                // Associate Charging Location With Tariff
                apiInstance.AssociateChargingLocationWithTariff(chargingLocationId, chargingLocationTariffInterval);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargingLocationsApi.AssociateChargingLocationWithTariff: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssociateChargingLocationWithTariffWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associate Charging Location With Tariff
    apiInstance.AssociateChargingLocationWithTariffWithHttpInfo(chargingLocationId, chargingLocationTariffInterval);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargingLocationsApi.AssociateChargingLocationWithTariffWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargingLocationId** | **string** | ID of the Charging Location |  |
| **chargingLocationTariffInterval** | [**ChargingLocationTariffInterval?**](ChargingLocationTariffInterval?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful |  -  |
| **400** | Invalid tariffId, invalid rate name, or incomplete interval series. |  -  |
| **404** | Charging Location not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecharginglocationscharginglocationid"></a>
# **DeleteCharginglocationsCharginglocationid**
> ChargingLocationResponse DeleteCharginglocationsCharginglocationid (string chargingLocationId)

Delete Charging Location

Delete a Charging Location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class DeleteCharginglocationsCharginglocationidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargingLocationsApi(config);
            var chargingLocationId = "chargingLocationId_example";  // string | ID of the Charging Location.

            try
            {
                // Delete Charging Location
                ChargingLocationResponse result = apiInstance.DeleteCharginglocationsCharginglocationid(chargingLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargingLocationsApi.DeleteCharginglocationsCharginglocationid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCharginglocationsCharginglocationidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Charging Location
    ApiResponse<ChargingLocationResponse> response = apiInstance.DeleteCharginglocationsCharginglocationidWithHttpInfo(chargingLocationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargingLocationsApi.DeleteCharginglocationsCharginglocationidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargingLocationId** | **string** | ID of the Charging Location. |  |

### Return type

[**ChargingLocationResponse**](ChargingLocationResponse.md)

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

<a name="getcharginglocationtariff"></a>
# **GetChargingLocationTariff**
> List&lt;ChargingLocationTariffInner&gt; GetChargingLocationTariff (string chargingLocationId)

Get Charging Location Tariff

Get Tariff intervals for a given charging location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetChargingLocationTariffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargingLocationsApi(config);
            var chargingLocationId = "chargingLocationId_example";  // string | ID of the Charging Location

            try
            {
                // Get Charging Location Tariff
                List<ChargingLocationTariffInner> result = apiInstance.GetChargingLocationTariff(chargingLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargingLocationsApi.GetChargingLocationTariff: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChargingLocationTariffWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Charging Location Tariff
    ApiResponse<List<ChargingLocationTariffInner>> response = apiInstance.GetChargingLocationTariffWithHttpInfo(chargingLocationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargingLocationsApi.GetChargingLocationTariffWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargingLocationId** | **string** | ID of the Charging Location |  |

### Return type

[**List&lt;ChargingLocationTariffInner&gt;**](ChargingLocationTariffInner.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |
| **400** | Invalid tariffId or rate name, or incomplete interval series |  -  |
| **404** | Charging Location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharginglocations"></a>
# **GetCharginglocations**
> List&lt;ChargingLocationResponse&gt; GetCharginglocations ()

List Charging Locations

Returns a list of Charging Locations registered to the User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetCharginglocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargingLocationsApi(config);

            try
            {
                // List Charging Locations
                List<ChargingLocationResponse> result = apiInstance.GetCharginglocations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargingLocationsApi.GetCharginglocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCharginglocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Charging Locations
    ApiResponse<List<ChargingLocationResponse>> response = apiInstance.GetCharginglocationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargingLocationsApi.GetCharginglocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ChargingLocationResponse&gt;**](ChargingLocationResponse.md)

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

<a name="getcharginglocationscharginglocationid"></a>
# **GetCharginglocationsCharginglocationid**
> ChargingLocationResponse GetCharginglocationsCharginglocationid (string chargingLocationId)

Get Charging Location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetCharginglocationsCharginglocationidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargingLocationsApi(config);
            var chargingLocationId = "chargingLocationId_example";  // string | ID of the Charging Location.

            try
            {
                // Get Charging Location
                ChargingLocationResponse result = apiInstance.GetCharginglocationsCharginglocationid(chargingLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargingLocationsApi.GetCharginglocationsCharginglocationid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCharginglocationsCharginglocationidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Charging Location
    ApiResponse<ChargingLocationResponse> response = apiInstance.GetCharginglocationsCharginglocationidWithHttpInfo(chargingLocationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargingLocationsApi.GetCharginglocationsCharginglocationidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargingLocationId** | **string** | ID of the Charging Location. |  |

### Return type

[**ChargingLocationResponse**](ChargingLocationResponse.md)

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

<a name="postcharginglocations"></a>
# **PostCharginglocations**
> ChargingLocationResponse PostCharginglocations (ChargingLocationCreateRequest? chargingLocationCreateRequest = null)

Create Charging Location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PostCharginglocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargingLocationsApi(config);
            var chargingLocationCreateRequest = new ChargingLocationCreateRequest?(); // ChargingLocationCreateRequest? |  (optional) 

            try
            {
                // Create Charging Location
                ChargingLocationResponse result = apiInstance.PostCharginglocations(chargingLocationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargingLocationsApi.PostCharginglocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCharginglocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Charging Location
    ApiResponse<ChargingLocationResponse> response = apiInstance.PostCharginglocationsWithHttpInfo(chargingLocationCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargingLocationsApi.PostCharginglocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargingLocationCreateRequest** | [**ChargingLocationCreateRequest?**](ChargingLocationCreateRequest?.md) |  | [optional]  |

### Return type

[**ChargingLocationResponse**](ChargingLocationResponse.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcharginglocationscharginglocationid"></a>
# **PutCharginglocationsCharginglocationid**
> ChargingLocationResponse PutCharginglocationsCharginglocationid (string chargingLocationId, ChargingLocationUpdateRequest? chargingLocationUpdateRequest = null)

Update Charging Location

Updates a charging location with new configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PutCharginglocationsCharginglocationidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargingLocationsApi(config);
            var chargingLocationId = "chargingLocationId_example";  // string | ID of the Charging Location
            var chargingLocationUpdateRequest = new ChargingLocationUpdateRequest?(); // ChargingLocationUpdateRequest? |  (optional) 

            try
            {
                // Update Charging Location
                ChargingLocationResponse result = apiInstance.PutCharginglocationsCharginglocationid(chargingLocationId, chargingLocationUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargingLocationsApi.PutCharginglocationsCharginglocationid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCharginglocationsCharginglocationidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Charging Location
    ApiResponse<ChargingLocationResponse> response = apiInstance.PutCharginglocationsCharginglocationidWithHttpInfo(chargingLocationId, chargingLocationUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargingLocationsApi.PutCharginglocationsCharginglocationidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargingLocationId** | **string** | ID of the Charging Location |  |
| **chargingLocationUpdateRequest** | [**ChargingLocationUpdateRequest?**](ChargingLocationUpdateRequest?.md) |  | [optional]  |

### Return type

[**ChargingLocationResponse**](ChargingLocationResponse.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

