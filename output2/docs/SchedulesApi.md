# EnodeApi.Api.SchedulesApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSchedule**](SchedulesApi.md#createschedule) | **POST** /schedules | Create Schedule |
| [**DeleteSchedule**](SchedulesApi.md#deleteschedule) | **DELETE** /schedules/{scheduleId} | Delete Schedule |
| [**GetSchedule**](SchedulesApi.md#getschedule) | **GET** /schedules/{scheduleId} | Get Schedule |
| [**GetScheduleStatus**](SchedulesApi.md#getschedulestatus) | **GET** /schedules/{scheduleId}/status | Get Schedule Status |
| [**GetSchedules**](SchedulesApi.md#getschedules) | **GET** /schedules | List Schedules |
| [**UpdateSchedule**](SchedulesApi.md#updateschedule) | **PUT** /schedules/{scheduleId} | Update Schedule |

<a name="createschedule"></a>
# **CreateSchedule**
> ScheduleResponse CreateSchedule (Schedule? schedule = null)

Create Schedule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class CreateScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var schedule = new Schedule?(); // Schedule? |  (optional) 

            try
            {
                // Create Schedule
                ScheduleResponse result = apiInstance.CreateSchedule(schedule);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.CreateSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Schedule
    ApiResponse<ScheduleResponse> response = apiInstance.CreateScheduleWithHttpInfo(schedule);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.CreateScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **schedule** | [**Schedule?**](Schedule?.md) |  | [optional]  |

### Return type

[**ScheduleResponse**](ScheduleResponse.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteschedule"></a>
# **DeleteSchedule**
> void DeleteSchedule (string scheduleId)

Delete Schedule

Delete a Schedule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class DeleteScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var scheduleId = "scheduleId_example";  // string | ID of the Schedule.

            try
            {
                // Delete Schedule
                apiInstance.DeleteSchedule(scheduleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.DeleteSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Schedule
    apiInstance.DeleteScheduleWithHttpInfo(scheduleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.DeleteScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleId** | **string** | ID of the Schedule. |  |

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

<a name="getschedule"></a>
# **GetSchedule**
> ScheduleResponse GetSchedule (string scheduleId)

Get Schedule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var scheduleId = "scheduleId_example";  // string | ID of the Schedule.

            try
            {
                // Get Schedule
                ScheduleResponse result = apiInstance.GetSchedule(scheduleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.GetSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Schedule
    ApiResponse<ScheduleResponse> response = apiInstance.GetScheduleWithHttpInfo(scheduleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.GetScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleId** | **string** | ID of the Schedule. |  |

### Return type

[**ScheduleResponse**](ScheduleResponse.md)

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

<a name="getschedulestatus"></a>
# **GetScheduleStatus**
> ScheduleStatusResponse GetScheduleStatus (string scheduleId)

Get Schedule Status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetScheduleStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var scheduleId = "scheduleId_example";  // string | ID of the Schedule.

            try
            {
                // Get Schedule Status
                ScheduleStatusResponse result = apiInstance.GetScheduleStatus(scheduleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.GetScheduleStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScheduleStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Schedule Status
    ApiResponse<ScheduleStatusResponse> response = apiInstance.GetScheduleStatusWithHttpInfo(scheduleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.GetScheduleStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleId** | **string** | ID of the Schedule. |  |

### Return type

[**ScheduleStatusResponse**](ScheduleStatusResponse.md)

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

<a name="getschedules"></a>
# **GetSchedules**
> List&lt;ScheduleResponse&gt; GetSchedules ()

List Schedules

Returns a list of Schedules registered to the User.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetSchedulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);

            try
            {
                // List Schedules
                List<ScheduleResponse> result = apiInstance.GetSchedules();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.GetSchedules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchedulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Schedules
    ApiResponse<List<ScheduleResponse>> response = apiInstance.GetSchedulesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.GetSchedulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ScheduleResponse&gt;**](ScheduleResponse.md)

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

<a name="updateschedule"></a>
# **UpdateSchedule**
> ScheduleResponse UpdateSchedule (string scheduleId, PartialSchedule? partialSchedule = null)

Update Schedule

Does a partial update of a schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class UpdateScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var scheduleId = "scheduleId_example";  // string | ID of the Schedule.
            var partialSchedule = new PartialSchedule?(); // PartialSchedule? |  (optional) 

            try
            {
                // Update Schedule
                ScheduleResponse result = apiInstance.UpdateSchedule(scheduleId, partialSchedule);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.UpdateSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Schedule
    ApiResponse<ScheduleResponse> response = apiInstance.UpdateScheduleWithHttpInfo(scheduleId, partialSchedule);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.UpdateScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleId** | **string** | ID of the Schedule. |  |
| **partialSchedule** | [**PartialSchedule?**](PartialSchedule?.md) |  | [optional]  |

### Return type

[**ScheduleResponse**](ScheduleResponse.md)

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

