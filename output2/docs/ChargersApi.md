# EnodeApi.Api.ChargersApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChargerCreateExternalStart**](ChargersApi.md#chargercreateexternalstart) | **POST** /chargers/{chargerId}/external-start | Create External Start |
| [**ChargerCreateSmartOverride**](ChargersApi.md#chargercreatesmartoverride) | **POST** /chargers/{chargerId}/smart-override | Create Smart Override |
| [**ChargerEndExternalStart**](ChargersApi.md#chargerendexternalstart) | **DELETE** /chargers/{chargerId}/external-start | End External Start |
| [**ChargerEndSmartOverride**](ChargersApi.md#chargerendsmartoverride) | **DELETE** /chargers/{chargerId}/smart-override | End Smart Override |
| [**ControlChargerCharging**](ChargersApi.md#controlchargercharging) | **POST** /chargers/{chargerId}/charging | Control Charging |
| [**GetCharger**](ChargersApi.md#getcharger) | **GET** /chargers/{chargerId} | Get Charger |
| [**GetChargersAction**](ChargersApi.md#getchargersaction) | **GET** /chargers/actions/{vendorActionId} | Get Charge Action |
| [**ListChargers**](ChargersApi.md#listchargers) | **GET** /chargers | List Chargers |
| [**PostSetChargerMaxCurrent**](ChargersApi.md#postsetchargermaxcurrent) | **POST** /chargers/{chargerId}/max-current | Set Max Current |

<a name="chargercreateexternalstart"></a>
# **ChargerCreateExternalStart**
> SmartOverrideResponse ChargerCreateExternalStart (string chargerId)

Create External Start

Deprecated. Replaced by [Create Smart Override](/api/reference#chargerCreateSmartOverride). The new name better reflects the functionality this endpoint offers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class ChargerCreateExternalStartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargersApi(config);
            var chargerId = "chargerId_example";  // string | ID of the Charger

            try
            {
                // Create External Start
                SmartOverrideResponse result = apiInstance.ChargerCreateExternalStart(chargerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargersApi.ChargerCreateExternalStart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChargerCreateExternalStartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create External Start
    ApiResponse<SmartOverrideResponse> response = apiInstance.ChargerCreateExternalStartWithHttpInfo(chargerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargersApi.ChargerCreateExternalStartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | ID of the Charger |  |

### Return type

[**SmartOverrideResponse**](SmartOverrideResponse.md)

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

<a name="chargercreatesmartoverride"></a>
# **ChargerCreateSmartOverride**
> SmartOverrideResponse ChargerCreateSmartOverride (string chargerId)

Create Smart Override

Overrides an active smart feature by forcing the charger to start charging. This feature is meant to be used in situations where the user wants to charge immediately without disabling other smart features. The override remains active until the charger stops charging, or until the [Delete Smart Override](/api/reference#chargerEndSmartOverride) endpoint is called. When the override ends, the overriden smart feature will regain control of the charger. This endpoint should not be used for standard charge control, use the [Control Charging](/api/reference#postVehiclesVehicleidCharging) endpoint instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class ChargerCreateSmartOverrideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargersApi(config);
            var chargerId = "chargerId_example";  // string | ID of the Charger

            try
            {
                // Create Smart Override
                SmartOverrideResponse result = apiInstance.ChargerCreateSmartOverride(chargerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargersApi.ChargerCreateSmartOverride: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChargerCreateSmartOverrideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Smart Override
    ApiResponse<SmartOverrideResponse> response = apiInstance.ChargerCreateSmartOverrideWithHttpInfo(chargerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargersApi.ChargerCreateSmartOverrideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | ID of the Charger |  |

### Return type

[**SmartOverrideResponse**](SmartOverrideResponse.md)

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

<a name="chargerendexternalstart"></a>
# **ChargerEndExternalStart**
> SmartOverrideResponse ChargerEndExternalStart (string chargerId)

End External Start

Deprecated. Replaced by [Delete Smart Override](/api/reference#chargerEndSmartOverride). The new name better reflects the functionality this endpoint offers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class ChargerEndExternalStartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargersApi(config);
            var chargerId = "chargerId_example";  // string | ID of the Charger

            try
            {
                // End External Start
                SmartOverrideResponse result = apiInstance.ChargerEndExternalStart(chargerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargersApi.ChargerEndExternalStart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChargerEndExternalStartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // End External Start
    ApiResponse<SmartOverrideResponse> response = apiInstance.ChargerEndExternalStartWithHttpInfo(chargerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargersApi.ChargerEndExternalStartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | ID of the Charger |  |

### Return type

[**SmartOverrideResponse**](SmartOverrideResponse.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |
| **404** | No External Start Exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargerendsmartoverride"></a>
# **ChargerEndSmartOverride**
> SmartOverrideResponse ChargerEndSmartOverride (string chargerId)

End Smart Override

Ends any active Smart Override for the charger specified by `chargerId`. If previously configured, Schedules or Smart Charging will resume control over the target charger. Note that this does not mean the charger will stop charging, only that it will return to the state expected by the active Schedule or Smart Charging Plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class ChargerEndSmartOverrideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargersApi(config);
            var chargerId = "chargerId_example";  // string | ID of the Charger

            try
            {
                // End Smart Override
                SmartOverrideResponse result = apiInstance.ChargerEndSmartOverride(chargerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargersApi.ChargerEndSmartOverride: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChargerEndSmartOverrideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // End Smart Override
    ApiResponse<SmartOverrideResponse> response = apiInstance.ChargerEndSmartOverrideWithHttpInfo(chargerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargersApi.ChargerEndSmartOverrideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | ID of the Charger |  |

### Return type

[**SmartOverrideResponse**](SmartOverrideResponse.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |
| **404** | No Smart Override Exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="controlchargercharging"></a>
# **ControlChargerCharging**
> ChargeAction ControlChargerCharging (string chargerId, ControlChargerChargingRequest? controlChargerChargingRequest = null)

Control Charging

Register a request for a charger to start or stop charging. We retry sending the command until the charger's `chargeStateIsCharging` field transitions to the expected state. Note that this API request will complete before any commands are sent to the charger. There can only be one vendor action active for any one target id at a time. If a new action is created, the old action transitions to the `CANCELLED` state. You may react to transitions by listening for the `user:vendor-action:updated` webhook event or polling the [charger action endpoint](/api/reference#getChargersAction).   This endpoint returns an error with status code 422 if the charger is controlled by a schedule. To restore user control, either disable the schedule or use our [Smart Override API](/api/reference#chargerCreateSmartOverride) to temporarily enable charging.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class ControlChargerChargingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargersApi(config);
            var chargerId = "chargerId_example";  // string | ID of the Charger
            var controlChargerChargingRequest = new ControlChargerChargingRequest?(); // ControlChargerChargingRequest? |  (optional) 

            try
            {
                // Control Charging
                ChargeAction result = apiInstance.ControlChargerCharging(chargerId, controlChargerChargingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargersApi.ControlChargerCharging: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ControlChargerChargingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Control Charging
    ApiResponse<ChargeAction> response = apiInstance.ControlChargerChargingWithHttpInfo(chargerId, controlChargerChargingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargersApi.ControlChargerChargingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | ID of the Charger |  |
| **controlChargerChargingRequest** | [**ControlChargerChargingRequest?**](ControlChargerChargingRequest?.md) |  | [optional]  |

### Return type

[**ChargeAction**](ChargeAction.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resulting charge action |  -  |
| **422** | Charger controlled by a Schedule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharger"></a>
# **GetCharger**
> Charger GetCharger (string chargerId, GetChargerFieldParameter? field = null)

Get Charger

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetChargerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargersApi(config);
            var chargerId = "chargerId_example";  // string | ID of the Charger
            var field = new GetChargerFieldParameter?(); // GetChargerFieldParameter? | If you specify any fields here, we make a request to the Charger's OEM APIs and return the updated data.   This will slow down your integration. In cases of vendor downtime requests with fields may take up to a minute to complete, while requests without fields will always be fast. Enode polls all devices connected to our platform, so any cached data returned will not be older than 10 minutes (unless the vendor APIs are unavailable, in which case you can consult the `lastSeen` & `isReachable` fields on the charger).  By default, no fields are included, and the latest cached full Charger object will be returned. (optional) 

            try
            {
                // Get Charger
                Charger result = apiInstance.GetCharger(chargerId, field);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargersApi.GetCharger: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChargerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Charger
    ApiResponse<Charger> response = apiInstance.GetChargerWithHttpInfo(chargerId, field);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargersApi.GetChargerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | ID of the Charger |  |
| **field** | [**GetChargerFieldParameter?**](GetChargerFieldParameter?.md) | If you specify any fields here, we make a request to the Charger&#39;s OEM APIs and return the updated data.   This will slow down your integration. In cases of vendor downtime requests with fields may take up to a minute to complete, while requests without fields will always be fast. Enode polls all devices connected to our platform, so any cached data returned will not be older than 10 minutes (unless the vendor APIs are unavailable, in which case you can consult the &#x60;lastSeen&#x60; &amp; &#x60;isReachable&#x60; fields on the charger).  By default, no fields are included, and the latest cached full Charger object will be returned. | [optional]  |

### Return type

[**Charger**](Charger.md)

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

<a name="getchargersaction"></a>
# **GetChargersAction**
> DEPRECATEDVendorAction GetChargersAction (string vendorActionId)

Get Charge Action

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
    public class GetChargersActionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargersApi(config);
            var vendorActionId = "vendorActionId_example";  // string | ID of the Action

            try
            {
                // Get Charge Action
                DEPRECATEDVendorAction result = apiInstance.GetChargersAction(vendorActionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargersApi.GetChargersAction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChargersActionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Charge Action
    ApiResponse<DEPRECATEDVendorAction> response = apiInstance.GetChargersActionWithHttpInfo(vendorActionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargersApi.GetChargersActionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendorActionId** | **string** | ID of the Action |  |

### Return type

[**DEPRECATEDVendorAction**](DEPRECATEDVendorAction.md)

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

<a name="listchargers"></a>
# **ListChargers**
> List&lt;string&gt; ListChargers ()

List Chargers

List all available Chargers for the User.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class ListChargersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargersApi(config);

            try
            {
                // List Chargers
                List<string> result = apiInstance.ListChargers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargersApi.ListChargers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListChargersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Chargers
    ApiResponse<List<string>> response = apiInstance.ListChargersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargersApi.ListChargersWithHttpInfo: " + e.Message);
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

<a name="postsetchargermaxcurrent"></a>
# **PostSetChargerMaxCurrent**
> MaxCurrentAction PostSetChargerMaxCurrent (string chargerId, TargetMaxCurrent? targetMaxCurrent = null)

Set Max Current

Register a request for a change of the `maxCurrent` field on a charger. We retry sending the command until the charger's `maxCurrent` field transitions to the expected value. Note that this request will complete before any commands are sent to the charger. There can only be one vendor action active for any one target id at a time. If a new action is created, the old action transitions to the `CANCELLED` state. You may react to transitions by listening for the `user:vendor-action:updated` webhook event or polling [Charger Get Action](/api/reference#getChargersAction).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PostSetChargerMaxCurrentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChargersApi(config);
            var chargerId = "chargerId_example";  // string | ID of the Charger
            var targetMaxCurrent = new TargetMaxCurrent?(); // TargetMaxCurrent? |  (optional) 

            try
            {
                // Set Max Current
                MaxCurrentAction result = apiInstance.PostSetChargerMaxCurrent(chargerId, targetMaxCurrent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargersApi.PostSetChargerMaxCurrent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSetChargerMaxCurrentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Max Current
    ApiResponse<MaxCurrentAction> response = apiInstance.PostSetChargerMaxCurrentWithHttpInfo(chargerId, targetMaxCurrent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargersApi.PostSetChargerMaxCurrentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | ID of the Charger |  |
| **targetMaxCurrent** | [**TargetMaxCurrent?**](TargetMaxCurrent?.md) |  | [optional]  |

### Return type

[**MaxCurrentAction**](MaxCurrentAction.md)

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

