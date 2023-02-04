# EnodeApi.Api.SolarInvertersApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInverter**](SolarInvertersApi.md#getinverter) | **GET** /inverters/{inverterId} | Get Solar inverter |
| [**ListInverters**](SolarInvertersApi.md#listinverters) | **GET** /inverters | List Solar inverter |

<a name="getinverter"></a>
# **GetInverter**
> Inverter GetInverter (string inverterId, GetInverterFieldParameter? field = null)

Get Solar inverter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetInverterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolarInvertersApi(config);
            var inverterId = "inverterId_example";  // string | ID of the solar inverter
            var field = new GetInverterFieldParameter?(); // GetInverterFieldParameter? | If you specify any fields here, we make a request to the Solar inverter's OEM APIs and return the updated data.   This will slow down your integration. In cases of vendor downtime requests with fields may take up to a minute to complete, while requests without fields will always be fast. Enode polls all devices connected to our platform, so any cached data returned will not be older than 10 minutes (unless the vendor APIs are unavailable, in which case you can consult the `lastSeen` & `isReachable` fields on the solar inverter).  By default, no fields are included, and the latest cached full solar inverter object will be returned. (optional) 

            try
            {
                // Get Solar inverter
                Inverter result = apiInstance.GetInverter(inverterId, field);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolarInvertersApi.GetInverter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInverterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Solar inverter
    ApiResponse<Inverter> response = apiInstance.GetInverterWithHttpInfo(inverterId, field);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolarInvertersApi.GetInverterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inverterId** | **string** | ID of the solar inverter |  |
| **field** | [**GetInverterFieldParameter?**](GetInverterFieldParameter?.md) | If you specify any fields here, we make a request to the Solar inverter&#39;s OEM APIs and return the updated data.   This will slow down your integration. In cases of vendor downtime requests with fields may take up to a minute to complete, while requests without fields will always be fast. Enode polls all devices connected to our platform, so any cached data returned will not be older than 10 minutes (unless the vendor APIs are unavailable, in which case you can consult the &#x60;lastSeen&#x60; &amp; &#x60;isReachable&#x60; fields on the solar inverter).  By default, no fields are included, and the latest cached full solar inverter object will be returned. | [optional]  |

### Return type

[**Inverter**](Inverter.md)

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

<a name="listinverters"></a>
# **ListInverters**
> List&lt;string&gt; ListInverters ()

List Solar inverter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class ListInvertersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SolarInvertersApi(config);

            try
            {
                // List Solar inverter
                List<string> result = apiInstance.ListInverters();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolarInvertersApi.ListInverters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInvertersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Solar inverter
    ApiResponse<List<string>> response = apiInstance.ListInvertersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolarInvertersApi.ListInvertersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

