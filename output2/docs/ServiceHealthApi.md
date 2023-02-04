# EnodeApi.Api.ServiceHealthApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetHealthChargerVendors**](ServiceHealthApi.md#gethealthchargervendors) | **GET** /health/chargers | Check Available Charger Vendors |
| [**GetHealthHvacVendors**](ServiceHealthApi.md#gethealthhvacvendors) | **GET** /health/hvacs | Check Available Hvac Vendors |
| [**GetHealthInverterVendors**](ServiceHealthApi.md#gethealthinvertervendors) | **GET** /health/inverters | Check Available Inverter Vendors |
| [**GetHealthReady**](ServiceHealthApi.md#gethealthready) | **GET** /health/ready | Check Service Readiness |
| [**GetHealthVehicleVendors**](ServiceHealthApi.md#gethealthvehiclevendors) | **GET** /health/vehicles | Check Available Vehicle Vendors |

<a name="gethealthchargervendors"></a>
# **GetHealthChargerVendors**
> List&lt;GetHealthChargerVendors200ResponseInner&gt; GetHealthChargerVendors ()

Check Available Charger Vendors

Lists the available charger vendors. If you authenticate with a client or link token, we also include the activated vendors that your client has access to. Learn more about [vendors requiring activation](https://developers.enode.io/api/capabilities/vehicles?dialog=glossary&value=activation-required).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetHealthChargerVendorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            var apiInstance = new ServiceHealthApi(config);

            try
            {
                // Check Available Charger Vendors
                List<GetHealthChargerVendors200ResponseInner> result = apiInstance.GetHealthChargerVendors();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceHealthApi.GetHealthChargerVendors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHealthChargerVendorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Available Charger Vendors
    ApiResponse<List<GetHealthChargerVendors200ResponseInner>> response = apiInstance.GetHealthChargerVendorsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceHealthApi.GetHealthChargerVendorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GetHealthChargerVendors200ResponseInner&gt;**](GetHealthChargerVendors200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethealthhvacvendors"></a>
# **GetHealthHvacVendors**
> List&lt;GetHealthHvacVendors200ResponseInner&gt; GetHealthHvacVendors ()

Check Available Hvac Vendors

Lists the available HVAC vendors. If you authenticate with a client or link token, we also include the activated vendors that your client has access to. Learn more about [vendors requiring activation](https://developers.enode.io/api/capabilities/vehicles?dialog=glossary&value=activation-required).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetHealthHvacVendorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            var apiInstance = new ServiceHealthApi(config);

            try
            {
                // Check Available Hvac Vendors
                List<GetHealthHvacVendors200ResponseInner> result = apiInstance.GetHealthHvacVendors();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceHealthApi.GetHealthHvacVendors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHealthHvacVendorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Available Hvac Vendors
    ApiResponse<List<GetHealthHvacVendors200ResponseInner>> response = apiInstance.GetHealthHvacVendorsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceHealthApi.GetHealthHvacVendorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GetHealthHvacVendors200ResponseInner&gt;**](GetHealthHvacVendors200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethealthinvertervendors"></a>
# **GetHealthInverterVendors**
> List&lt;GetHealthInverterVendors200ResponseInner&gt; GetHealthInverterVendors ()

Check Available Inverter Vendors

Lists the available inverter vendors. If you authenticate with a client or link token, we also include the activated vendors that your client has access to. Learn more about [vendors requiring activation](https://developers.enode.io/api/capabilities/vehicles?dialog=glossary&value=activation-required).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetHealthInverterVendorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            var apiInstance = new ServiceHealthApi(config);

            try
            {
                // Check Available Inverter Vendors
                List<GetHealthInverterVendors200ResponseInner> result = apiInstance.GetHealthInverterVendors();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceHealthApi.GetHealthInverterVendors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHealthInverterVendorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Available Inverter Vendors
    ApiResponse<List<GetHealthInverterVendors200ResponseInner>> response = apiInstance.GetHealthInverterVendorsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceHealthApi.GetHealthInverterVendorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GetHealthInverterVendors200ResponseInner&gt;**](GetHealthInverterVendors200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethealthready"></a>
# **GetHealthReady**
> void GetHealthReady ()

Check Service Readiness

Gets the combined health status of the service and all functionalities and dependencies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetHealthReadyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            var apiInstance = new ServiceHealthApi(config);

            try
            {
                // Check Service Readiness
                apiInstance.GetHealthReady();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceHealthApi.GetHealthReady: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHealthReadyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Service Readiness
    apiInstance.GetHealthReadyWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceHealthApi.GetHealthReadyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | All functionalities are operating nominally. |  -  |
| **503** | At least one functionality of the system is not operating nominally. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethealthvehiclevendors"></a>
# **GetHealthVehicleVendors**
> List&lt;GetHealthVehicleVendors200ResponseInner&gt; GetHealthVehicleVendors ()

Check Available Vehicle Vendors

Lists the available vehicle vendors. If you authenticate with a client or link token, we also include the activated vendors that your client has access to. Learn more about [vendors requiring activation](https://developers.enode.io/api/capabilities/vehicles?dialog=glossary&value=activation-required).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetHealthVehicleVendorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            var apiInstance = new ServiceHealthApi(config);

            try
            {
                // Check Available Vehicle Vendors
                List<GetHealthVehicleVendors200ResponseInner> result = apiInstance.GetHealthVehicleVendors();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceHealthApi.GetHealthVehicleVendors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHealthVehicleVendorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Available Vehicle Vendors
    ApiResponse<List<GetHealthVehicleVendors200ResponseInner>> response = apiInstance.GetHealthVehicleVendorsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceHealthApi.GetHealthVehicleVendorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GetHealthVehicleVendors200ResponseInner&gt;**](GetHealthVehicleVendors200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

