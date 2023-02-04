# EnodeApi.Api.StatisticsApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetStatisticsCharging**](StatisticsApi.md#getstatisticscharging) | **GET** /statistics/charging | Get User Charging Statistics |
| [**GetStatisticsChargingSessions**](StatisticsApi.md#getstatisticschargingsessions) | **GET** /statistics/charging/sessions | Get User Sessions Charging Statistics |
| [**GetStatisticsProduction**](StatisticsApi.md#getstatisticsproduction) | **GET** /statistics/production | Get User Production Statistics |

<a name="getstatisticscharging"></a>
# **GetStatisticsCharging**
> List&lt;StatisticsChargingTimeseriesSample&gt; GetStatisticsCharging (string startDate, string? resolution = null, string? endDate = null, ConsumingVendorType? type = null, string? id = null, float? utcOffset = null, string? chargingLocationId = null, string? vehicleId = null)

Get User Charging Statistics

Returns a normalized time series of statistics about power consumption and price for the User.  If Smart Charging has shifted the consumption, the 'non-smart' price fields will show what the consumption would have cost if it had happened at the default time. The difference between the two is provided by the `estimatedSavings` field for convenience. `<CURRENCY>` is an ISO4217 Alpha-3 currency code that is determined by client-wide configuration or the currency code provided during price data ingestion (such as Tariffs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetStatisticsChargingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var startDate = "startDate_example";  // string | Earliest date to include in the response in ISO format. Cannot be greater than endDate. Example: `2021-03-21T00:25:43.511Z`
            var resolution = "QUARTER_HOUR";  // string? | The unit of time the data will be cut into before aggregate statistics are applied. Each entry in the response array corresponds to aggregated data of the time range specified. (optional)  (default to DAY)
            var endDate = "endDate_example";  // string? | Latest date to include in the response (defaults to current date/time) in ISO format. Example: `2021-03-21T00:25:43.511Z` (optional) 
            var type = new ConsumingVendorType?(); // ConsumingVendorType? | Get statistics for this hardware type. (optional) 
            var id = "id_example";  // string? | Filter statistics to only include a specific entity. Hardware category of the entity must match the `type` parameter. (optional) 
            var utcOffset = -8;  // float? | Offset (in hours) from UTC of the timezone from which the statistics should be viewed. By default, all returned timestamps are in UTC, and period boundaries (day, week, month, year) used in the aggregation are calculated in UTC. Providing `utcOffset` instead aligns these to the viewer's timezone so that the timestamps and period boundaries fall where the viewer expects them to. Positive, negative, and fractional values are valid. (optional) 
            var chargingLocationId = "chargingLocationId_example";  // string? | Filter statistics to only include this charging location. (optional) 
            var vehicleId = "vehicleId_example";  // string? |  (optional) 

            try
            {
                // Get User Charging Statistics
                List<StatisticsChargingTimeseriesSample> result = apiInstance.GetStatisticsCharging(startDate, resolution, endDate, type, id, utcOffset, chargingLocationId, vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticsCharging: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsChargingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Charging Statistics
    ApiResponse<List<StatisticsChargingTimeseriesSample>> response = apiInstance.GetStatisticsChargingWithHttpInfo(startDate, resolution, endDate, type, id, utcOffset, chargingLocationId, vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsChargingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string** | Earliest date to include in the response in ISO format. Cannot be greater than endDate. Example: &#x60;2021-03-21T00:25:43.511Z&#x60; |  |
| **resolution** | **string?** | The unit of time the data will be cut into before aggregate statistics are applied. Each entry in the response array corresponds to aggregated data of the time range specified. | [optional] [default to DAY] |
| **endDate** | **string?** | Latest date to include in the response (defaults to current date/time) in ISO format. Example: &#x60;2021-03-21T00:25:43.511Z&#x60; | [optional]  |
| **type** | [**ConsumingVendorType?**](ConsumingVendorType?.md) | Get statistics for this hardware type. | [optional]  |
| **id** | **string?** | Filter statistics to only include a specific entity. Hardware category of the entity must match the &#x60;type&#x60; parameter. | [optional]  |
| **utcOffset** | **float?** | Offset (in hours) from UTC of the timezone from which the statistics should be viewed. By default, all returned timestamps are in UTC, and period boundaries (day, week, month, year) used in the aggregation are calculated in UTC. Providing &#x60;utcOffset&#x60; instead aligns these to the viewer&#39;s timezone so that the timestamps and period boundaries fall where the viewer expects them to. Positive, negative, and fractional values are valid. | [optional]  |
| **chargingLocationId** | **string?** | Filter statistics to only include this charging location. | [optional]  |
| **vehicleId** | **string?** |  | [optional]  |

### Return type

[**List&lt;StatisticsChargingTimeseriesSample&gt;**](StatisticsChargingTimeseriesSample.md)

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

<a name="getstatisticschargingsessions"></a>
# **GetStatisticsChargingSessions**
> List&lt;StatisticsTimeseriesSessionSample&gt; GetStatisticsChargingSessions (string startDate, ConsumingVendorType? targetType = null, string? endDate = null, string? targetId = null, string? chargingLocationId = null)

Get User Sessions Charging Statistics

Returns a list of statistics about power consumption and price for the User binned by sessions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetStatisticsChargingSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var startDate = "startDate_example";  // string | Earliest date to include in the response in ISO format. Example: `2021-03-21T00:25:43.511Z`
            var targetType = new ConsumingVendorType?(); // ConsumingVendorType? | Get statistics for this hardware type. (optional) 
            var endDate = "endDate_example";  // string? | Latest date to include in the response (defaults to current date/time) in ISO format. Example: `2021-03-21T00:25:43.511Z` (optional) 
            var targetId = "targetId_example";  // string? | Filter statistics to only include a specific entity. (optional) 
            var chargingLocationId = "chargingLocationId_example";  // string? | Filter statistics to only include this charging location (optional) 

            try
            {
                // Get User Sessions Charging Statistics
                List<StatisticsTimeseriesSessionSample> result = apiInstance.GetStatisticsChargingSessions(startDate, targetType, endDate, targetId, chargingLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticsChargingSessions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsChargingSessionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Sessions Charging Statistics
    ApiResponse<List<StatisticsTimeseriesSessionSample>> response = apiInstance.GetStatisticsChargingSessionsWithHttpInfo(startDate, targetType, endDate, targetId, chargingLocationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsChargingSessionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string** | Earliest date to include in the response in ISO format. Example: &#x60;2021-03-21T00:25:43.511Z&#x60; |  |
| **targetType** | [**ConsumingVendorType?**](ConsumingVendorType?.md) | Get statistics for this hardware type. | [optional]  |
| **endDate** | **string?** | Latest date to include in the response (defaults to current date/time) in ISO format. Example: &#x60;2021-03-21T00:25:43.511Z&#x60; | [optional]  |
| **targetId** | **string?** | Filter statistics to only include a specific entity. | [optional]  |
| **chargingLocationId** | **string?** | Filter statistics to only include this charging location | [optional]  |

### Return type

[**List&lt;StatisticsTimeseriesSessionSample&gt;**](StatisticsTimeseriesSessionSample.md)

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

<a name="getstatisticsproduction"></a>
# **GetStatisticsProduction**
> List&lt;StatisticsProductionTimeseriesSample&gt; GetStatisticsProduction (string startDate, string? resolution = null, string? endDate = null, ProducingVendorType? type = null, string? id = null, float? utcOffset = null, string? chargingLocationId = null)

Get User Production Statistics

Returns a normalized time series of statistics about power production and price for the User.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetStatisticsProductionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var startDate = "startDate_example";  // string | Earliest date to include in the response in ISO format. Cannot be greater than endDate. Example: `2021-03-21T00:25:43.511Z`
            var resolution = "QUARTER_HOUR";  // string? | The unit of time the data will be cut into before aggregate statistics are applied. Each entry in the response array corresponds to aggregated data of the time range specified. (optional)  (default to DAY)
            var endDate = "endDate_example";  // string? | Latest date to include in the response (defaults to current date/time) in ISO format. Example: `2021-03-21T00:25:43.511Z` (optional) 
            var type = new ProducingVendorType?(); // ProducingVendorType? | Get statistics for this hardware type. (optional) 
            var id = "id_example";  // string? | Filter statistics to only include a specific entity. Hardware category of the entity must match the `type` parameter. (optional) 
            var utcOffset = -8;  // float? | Offset (in hours) from UTC of the timezone from which the statistics should be viewed. By default, all returned timestamps are in UTC, and period boundaries (day, week, month, year) used in the aggregation are calculated in UTC. Providing `utcOffset` instead aligns these to the viewer's timezone so that the timestamps and period boundaries fall where the viewer expects them to. Positive, negative, and fractional values are valid. (optional) 
            var chargingLocationId = "chargingLocationId_example";  // string? | Filter statistics to only include this charging location. (optional) 

            try
            {
                // Get User Production Statistics
                List<StatisticsProductionTimeseriesSample> result = apiInstance.GetStatisticsProduction(startDate, resolution, endDate, type, id, utcOffset, chargingLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticsProduction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsProductionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Production Statistics
    ApiResponse<List<StatisticsProductionTimeseriesSample>> response = apiInstance.GetStatisticsProductionWithHttpInfo(startDate, resolution, endDate, type, id, utcOffset, chargingLocationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsProductionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string** | Earliest date to include in the response in ISO format. Cannot be greater than endDate. Example: &#x60;2021-03-21T00:25:43.511Z&#x60; |  |
| **resolution** | **string?** | The unit of time the data will be cut into before aggregate statistics are applied. Each entry in the response array corresponds to aggregated data of the time range specified. | [optional] [default to DAY] |
| **endDate** | **string?** | Latest date to include in the response (defaults to current date/time) in ISO format. Example: &#x60;2021-03-21T00:25:43.511Z&#x60; | [optional]  |
| **type** | [**ProducingVendorType?**](ProducingVendorType?.md) | Get statistics for this hardware type. | [optional]  |
| **id** | **string?** | Filter statistics to only include a specific entity. Hardware category of the entity must match the &#x60;type&#x60; parameter. | [optional]  |
| **utcOffset** | **float?** | Offset (in hours) from UTC of the timezone from which the statistics should be viewed. By default, all returned timestamps are in UTC, and period boundaries (day, week, month, year) used in the aggregation are calculated in UTC. Providing &#x60;utcOffset&#x60; instead aligns these to the viewer&#39;s timezone so that the timestamps and period boundaries fall where the viewer expects them to. Positive, negative, and fractional values are valid. | [optional]  |
| **chargingLocationId** | **string?** | Filter statistics to only include this charging location. | [optional]  |

### Return type

[**List&lt;StatisticsProductionTimeseriesSample&gt;**](StatisticsProductionTimeseriesSample.md)

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

