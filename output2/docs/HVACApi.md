# EnodeApi.Api.HVACApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetHVAC**](HVACApi.md#gethvac) | **GET** /hvacs/{hvacId} | Get HVAC Unit |
| [**GetHvacsAction**](HVACApi.md#gethvacsaction) | **GET** /hvacs/actions/{vendorActionId} | Get Action |
| [**ListHVACs**](HVACApi.md#listhvacs) | **GET** /hvacs | List HVAC units |
| [**PostSetHvacFollowSchedule**](HVACApi.md#postsethvacfollowschedule) | **POST** /hvacs/{hvacId}/follow-schedule | Set HVAC to follow device schedule |
| [**PostSetHvacPermanentHold**](HVACApi.md#postsethvacpermanenthold) | **POST** /hvacs/{hvacId}/permanent-hold | Set HVAC Mode as Permanent Hold |
| [**PostSetHvacTargetTemperature**](HVACApi.md#postsethvactargettemperature) | **POST** /hvacs/{hvacId}/temperature | Set HVAC Temperature |
| [**UpdateHVAC**](HVACApi.md#updatehvac) | **PUT** /hvacs/{hvacId} | Set HVAC Location |

<a name="gethvac"></a>
# **GetHVAC**
> HVAC GetHVAC (string hvacId)

Get HVAC Unit

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetHVACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HVACApi(config);
            var hvacId = "hvacId_example";  // string | ID of the HVAC

            try
            {
                // Get HVAC Unit
                HVAC result = apiInstance.GetHVAC(hvacId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HVACApi.GetHVAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHVACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get HVAC Unit
    ApiResponse<HVAC> response = apiInstance.GetHVACWithHttpInfo(hvacId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HVACApi.GetHVACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hvacId** | **string** | ID of the HVAC |  |

### Return type

[**HVAC**](HVAC.md)

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

<a name="gethvacsaction"></a>
# **GetHvacsAction**
> HvacAction GetHvacsAction (string vendorActionId)

Get Action

Returns the current state of the requested action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetHvacsActionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HVACApi(config);
            var vendorActionId = "vendorActionId_example";  // string | ID of the Action

            try
            {
                // Get Action
                HvacAction result = apiInstance.GetHvacsAction(vendorActionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HVACApi.GetHvacsAction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHvacsActionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Action
    ApiResponse<HvacAction> response = apiInstance.GetHvacsActionWithHttpInfo(vendorActionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HVACApi.GetHvacsActionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendorActionId** | **string** | ID of the Action |  |

### Return type

[**HvacAction**](HvacAction.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |
| **404** | Action not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhvacs"></a>
# **ListHVACs**
> List&lt;string&gt; ListHVACs ()

List HVAC units

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class ListHVACsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HVACApi(config);

            try
            {
                // List HVAC units
                List<string> result = apiInstance.ListHVACs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HVACApi.ListHVACs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListHVACsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List HVAC units
    ApiResponse<List<string>> response = apiInstance.ListHVACsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HVACApi.ListHVACsWithHttpInfo: " + e.Message);
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

<a name="postsethvacfollowschedule"></a>
# **PostSetHvacFollowSchedule**
> HvacAction PostSetHvacFollowSchedule (string hvacId)

Set HVAC to follow device schedule

Tell an HVAC unit to follow the schedule set on the device. Only available if `SCHEDULED` is present in the target's `capabilities.capableHoldType`. This endpoint can be used to cancel permanent holds. We retry sending the command until the HVAC unit's fields transition to the expected values. Note that this request will complete before any commands are sent to the HVAC unit. You may react to transitions by listening for the `user:vendor-action:updated` webhook event or polling the [HVAC action endpoint](/api/reference#getHvacsAction).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PostSetHvacFollowScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HVACApi(config);
            var hvacId = "hvacId_example";  // string | ID of the HVAC

            try
            {
                // Set HVAC to follow device schedule
                HvacAction result = apiInstance.PostSetHvacFollowSchedule(hvacId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HVACApi.PostSetHvacFollowSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSetHvacFollowScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set HVAC to follow device schedule
    ApiResponse<HvacAction> response = apiInstance.PostSetHvacFollowScheduleWithHttpInfo(hvacId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HVACApi.PostSetHvacFollowScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hvacId** | **string** | ID of the HVAC |  |

### Return type

[**HvacAction**](HvacAction.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resulting HVAC action |  -  |
| **422** | HVAC controlled by an Enode Schedule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsethvacpermanenthold"></a>
# **PostSetHvacPermanentHold**
> HvacAction PostSetHvacPermanentHold (string hvacId, HVACSetPermanentHoldPayload hVACSetPermanentHoldPayload)

Set HVAC Mode as Permanent Hold

Tell an HVAC unit to enter a permanent hold. Only available if `PERMANENT` is present in the target's `capabilities.capableHoldType`. We retry sending the command until the HVAC unit's `target` field transition to the expected value. Note that this request will complete before any commands are sent to the HVAC unit. You may react to transitions by listening for the `user:vendor-action:updated` webhook event or polling the [HVAC action endpoint](/api/reference#getHvacsAction).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PostSetHvacPermanentHoldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HVACApi(config);
            var hvacId = "hvacId_example";  // string | ID of the HVAC
            var hVACSetPermanentHoldPayload = new HVACSetPermanentHoldPayload(); // HVACSetPermanentHoldPayload | 

            try
            {
                // Set HVAC Mode as Permanent Hold
                HvacAction result = apiInstance.PostSetHvacPermanentHold(hvacId, hVACSetPermanentHoldPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HVACApi.PostSetHvacPermanentHold: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSetHvacPermanentHoldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set HVAC Mode as Permanent Hold
    ApiResponse<HvacAction> response = apiInstance.PostSetHvacPermanentHoldWithHttpInfo(hvacId, hVACSetPermanentHoldPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HVACApi.PostSetHvacPermanentHoldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hvacId** | **string** | ID of the HVAC |  |
| **hVACSetPermanentHoldPayload** | [**HVACSetPermanentHoldPayload**](HVACSetPermanentHoldPayload.md) |  |  |

### Return type

[**HvacAction**](HvacAction.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resulting HVAC action |  -  |
| **422** | HVAC controlled by an Enode Schedule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsethvactargettemperature"></a>
# **PostSetHvacTargetTemperature**
> HvacAction PostSetHvacTargetTemperature (string hvacId, DEPRECATEDTargetTemperature dEPRECATEDTargetTemperature)

Set HVAC Temperature

This endpoint has been replaced with the [Set Permanent Hold](/api/reference#postSetHvacPermanentHold) and [Follow Schedule] endpoints. A future release will remove this endpoint.  Register a request for a change of the `targetTemperature` field on an HVAC unit. We retry sending the command until the HVAC unit's `targetTemperature` field transitions to the expected value. Note that this request will complete before any commands are sent to the HVAC unit. There can only be one vendor action active for any one target id at a time. If a new action is created, the old action transitions to the `CANCELLED` state. You may react to transitions by listening for the `user:vendor-action:updated` webhook event or polling the [HVAC action endpoint](/api/reference#getHvacsAction).  This endpoint returns an error with status code 422 if the HVAC unit is controlled by a schedule. To restore user control you must first disable the schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PostSetHvacTargetTemperatureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HVACApi(config);
            var hvacId = "hvacId_example";  // string | ID of the HVAC
            var dEPRECATEDTargetTemperature = new DEPRECATEDTargetTemperature(); // DEPRECATEDTargetTemperature | 

            try
            {
                // Set HVAC Temperature
                HvacAction result = apiInstance.PostSetHvacTargetTemperature(hvacId, dEPRECATEDTargetTemperature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HVACApi.PostSetHvacTargetTemperature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSetHvacTargetTemperatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set HVAC Temperature
    ApiResponse<HvacAction> response = apiInstance.PostSetHvacTargetTemperatureWithHttpInfo(hvacId, dEPRECATEDTargetTemperature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HVACApi.PostSetHvacTargetTemperatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hvacId** | **string** | ID of the HVAC |  |
| **dEPRECATEDTargetTemperature** | [**DEPRECATEDTargetTemperature**](DEPRECATEDTargetTemperature.md) |  |  |

### Return type

[**HvacAction**](HvacAction.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resulting HVAC action |  -  |
| **422** | HVAC unit controlled by a Schedule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehvac"></a>
# **UpdateHVAC**
> HVAC UpdateHVAC (string hvacId, HVACUpdatePayload? hVACUpdatePayload = null)

Set HVAC Location

Update the `chargingLocationId` field on an HVAC device.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class UpdateHVACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HVACApi(config);
            var hvacId = "hvacId_example";  // string | ID of the HVAC
            var hVACUpdatePayload = new HVACUpdatePayload?(); // HVACUpdatePayload? |  (optional) 

            try
            {
                // Set HVAC Location
                HVAC result = apiInstance.UpdateHVAC(hvacId, hVACUpdatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HVACApi.UpdateHVAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateHVACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set HVAC Location
    ApiResponse<HVAC> response = apiInstance.UpdateHVACWithHttpInfo(hvacId, hVACUpdatePayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HVACApi.UpdateHVACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hvacId** | **string** | ID of the HVAC |  |
| **hVACUpdatePayload** | [**HVACUpdatePayload?**](HVACUpdatePayload?.md) |  | [optional]  |

### Return type

[**HVAC**](HVAC.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated HVAC unit |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

