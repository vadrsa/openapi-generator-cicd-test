# EnodeApi.Api.VehiclesApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetVehicles**](VehiclesApi.md#getvehicles) | **GET** /vehicles | List Vehicles |
| [**GetVehiclesAction**](VehiclesApi.md#getvehiclesaction) | **GET** /vehicles/actions/{vendorActionId} | Get Charge Action |
| [**GetVehiclesVehicleid**](VehiclesApi.md#getvehiclesvehicleid) | **GET** /vehicles/{vehicleId} | Get Vehicle |
| [**GetVehiclesVehicleidSmartchargingplans**](VehiclesApi.md#getvehiclesvehicleidsmartchargingplans) | **GET** /vehicles/{vehicleId}/smart-charging-plans/{smartChargingPlanId} | Get Smart Charging Plan |
| [**GetVehiclesVehicleidSmartchargingpolicy**](VehiclesApi.md#getvehiclesvehicleidsmartchargingpolicy) | **GET** /vehicles/{vehicleId}/smart-charging-policy | Get Vehicle Smart Charging Policy |
| [**GetVehiclesVehicleidSmartchargingstatus**](VehiclesApi.md#getvehiclesvehicleidsmartchargingstatus) | **GET** /vehicles/{vehicleId}/smart-charging-status | Get Vehicle Smart Charging Status |
| [**PostVehiclesVehicleidCharging**](VehiclesApi.md#postvehiclesvehicleidcharging) | **POST** /vehicles/{vehicleId}/charging | Control Charging |
| [**UpdateVehicleSmartChargingPolicy**](VehiclesApi.md#updatevehiclesmartchargingpolicy) | **PUT** /vehicles/{vehicleId}/smart-charging-policy | Update Vehicle Smart Charging Policy |
| [**VehicleCreateExternalStart**](VehiclesApi.md#vehiclecreateexternalstart) | **POST** /vehicles/{vehicleId}/external-start | Create External Start |
| [**VehicleCreateSmartOverride**](VehiclesApi.md#vehiclecreatesmartoverride) | **POST** /vehicles/{vehicleId}/smart-override | Create Smart Override |
| [**VehicleEndExternalStart**](VehiclesApi.md#vehicleendexternalstart) | **DELETE** /vehicles/{vehicleId}/external-start | End External Start |
| [**VehicleEndSmartOverride**](VehiclesApi.md#vehicleendsmartoverride) | **DELETE** /vehicles/{vehicleId}/smart-override | End Smart Override |

<a name="getvehicles"></a>
# **GetVehicles**
> List&lt;Vehicle&gt; GetVehicles (GetVehiclesFieldParameter? field = null)

List Vehicles

List all available Vehicles for the User.  If you already know the ID of a vehicle you want to fetch, it is recommended to fetch it using the more performant [Get Vehicle](/api/reference#getVehiclesVehicleid) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetVehiclesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var field = new GetVehiclesFieldParameter?(); // GetVehiclesFieldParameter? | If you specify any fields here, we make a request to the Vehicle's OEM APIs and return the updated data.   This will slow down your integration. In cases of vendor downtime requests with fields may take up to a minute to complete, while requests without fields will always be fast. Enode polls all devices connected to our platform, so any cached data returned will not be older than 10 minutes (unless the vendor APIs are unavailable, in which case you can consult the `lastSeen` & `isReachable` fields on the vehicle).   Note that the field values `capabilities` & `smartChargingPolicy` are deprecated and will always be returned.    If no fields are included, and the latest cached full Vehicle object will be returned. (optional) 

            try
            {
                // List Vehicles
                List<Vehicle> result = apiInstance.GetVehicles(field);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.GetVehicles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVehiclesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Vehicles
    ApiResponse<List<Vehicle>> response = apiInstance.GetVehiclesWithHttpInfo(field);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.GetVehiclesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **field** | [**GetVehiclesFieldParameter?**](GetVehiclesFieldParameter?.md) | If you specify any fields here, we make a request to the Vehicle&#39;s OEM APIs and return the updated data.   This will slow down your integration. In cases of vendor downtime requests with fields may take up to a minute to complete, while requests without fields will always be fast. Enode polls all devices connected to our platform, so any cached data returned will not be older than 10 minutes (unless the vendor APIs are unavailable, in which case you can consult the &#x60;lastSeen&#x60; &amp; &#x60;isReachable&#x60; fields on the vehicle).   Note that the field values &#x60;capabilities&#x60; &amp; &#x60;smartChargingPolicy&#x60; are deprecated and will always be returned.    If no fields are included, and the latest cached full Vehicle object will be returned. | [optional]  |

### Return type

[**List&lt;Vehicle&gt;**](Vehicle.md)

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

<a name="getvehiclesaction"></a>
# **GetVehiclesAction**
> ChargeAction GetVehiclesAction (string vendorActionId)

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
    public class GetVehiclesActionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vendorActionId = "vendorActionId_example";  // string | ID of the Action

            try
            {
                // Get Charge Action
                ChargeAction result = apiInstance.GetVehiclesAction(vendorActionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.GetVehiclesAction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVehiclesActionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Charge Action
    ApiResponse<ChargeAction> response = apiInstance.GetVehiclesActionWithHttpInfo(vendorActionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.GetVehiclesActionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendorActionId** | **string** | ID of the Action |  |

### Return type

[**ChargeAction**](ChargeAction.md)

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

<a name="getvehiclesvehicleid"></a>
# **GetVehiclesVehicleid**
> Vehicle GetVehiclesVehicleid (string vehicleId, GetVehiclesFieldParameter? field = null)

Get Vehicle

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetVehiclesVehicleidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.
            var field = new GetVehiclesFieldParameter?(); // GetVehiclesFieldParameter? | If you specify any fields here, we make a request to the Vehicle's OEM APIs and return the updated data.   This will slow down your integration. In cases of vendor downtime requests with fields may take up to a minute to complete, while requests without fields will always be fast. Enode polls all devices connected to our platform, so any cached data returned will not be older than 10 minutes (unless the vendor APIs are unavailable, in which case you can consult the `lastSeen` & `isReachable` fields on the vehicle).   Note that the field values `capabilities` & `smartChargingPolicy` are deprecated and will always be returned.    If no fields are included, and the latest cached full Vehicle object will be returned. (optional) 

            try
            {
                // Get Vehicle
                Vehicle result = apiInstance.GetVehiclesVehicleid(vehicleId, field);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.GetVehiclesVehicleid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVehiclesVehicleidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Vehicle
    ApiResponse<Vehicle> response = apiInstance.GetVehiclesVehicleidWithHttpInfo(vehicleId, field);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.GetVehiclesVehicleidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |
| **field** | [**GetVehiclesFieldParameter?**](GetVehiclesFieldParameter?.md) | If you specify any fields here, we make a request to the Vehicle&#39;s OEM APIs and return the updated data.   This will slow down your integration. In cases of vendor downtime requests with fields may take up to a minute to complete, while requests without fields will always be fast. Enode polls all devices connected to our platform, so any cached data returned will not be older than 10 minutes (unless the vendor APIs are unavailable, in which case you can consult the &#x60;lastSeen&#x60; &amp; &#x60;isReachable&#x60; fields on the vehicle).   Note that the field values &#x60;capabilities&#x60; &amp; &#x60;smartChargingPolicy&#x60; are deprecated and will always be returned.    If no fields are included, and the latest cached full Vehicle object will be returned. | [optional]  |

### Return type

[**Vehicle**](Vehicle.md)

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

<a name="getvehiclesvehicleidsmartchargingplans"></a>
# **GetVehiclesVehicleidSmartchargingplans**
> VehicleSmartChargingPlan GetVehiclesVehicleidSmartchargingplans (string vehicleId, string smartChargingPlanId)

Get Smart Charging Plan

Check status of current or historical Smart Charging Plan for a Vehicle. Returns a [Smart Charging](/docs/smart-charging/introduction) Plan for this vehicle.  To fetch the most recently created plan, call the endpoint with `smartChargingPlanId` set to `latest`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetVehiclesVehicleidSmartchargingplansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.
            var smartChargingPlanId = "smartChargingPlanId_example";  // string | ID of the Smart Charging Plan

            try
            {
                // Get Smart Charging Plan
                VehicleSmartChargingPlan result = apiInstance.GetVehiclesVehicleidSmartchargingplans(vehicleId, smartChargingPlanId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.GetVehiclesVehicleidSmartchargingplans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVehiclesVehicleidSmartchargingplansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Smart Charging Plan
    ApiResponse<VehicleSmartChargingPlan> response = apiInstance.GetVehiclesVehicleidSmartchargingplansWithHttpInfo(vehicleId, smartChargingPlanId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.GetVehiclesVehicleidSmartchargingplansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |
| **smartChargingPlanId** | **string** | ID of the Smart Charging Plan |  |

### Return type

[**VehicleSmartChargingPlan**](VehicleSmartChargingPlan.md)

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

<a name="getvehiclesvehicleidsmartchargingpolicy"></a>
# **GetVehiclesVehicleidSmartchargingpolicy**
> GetVehiclesVehicleidSmartchargingpolicy200Response GetVehiclesVehicleidSmartchargingpolicy (string vehicleId)

Get Vehicle Smart Charging Policy

Get a vehicle's [Smart Charging](/docs/smart-charging/introduction) policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetVehiclesVehicleidSmartchargingpolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.

            try
            {
                // Get Vehicle Smart Charging Policy
                GetVehiclesVehicleidSmartchargingpolicy200Response result = apiInstance.GetVehiclesVehicleidSmartchargingpolicy(vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.GetVehiclesVehicleidSmartchargingpolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVehiclesVehicleidSmartchargingpolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Vehicle Smart Charging Policy
    ApiResponse<GetVehiclesVehicleidSmartchargingpolicy200Response> response = apiInstance.GetVehiclesVehicleidSmartchargingpolicyWithHttpInfo(vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.GetVehiclesVehicleidSmartchargingpolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |

### Return type

[**GetVehiclesVehicleidSmartchargingpolicy200Response**](GetVehiclesVehicleidSmartchargingpolicy200Response.md)

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

<a name="getvehiclesvehicleidsmartchargingstatus"></a>
# **GetVehiclesVehicleidSmartchargingstatus**
> GetVehiclesVehicleidSmartchargingstatus200Response GetVehiclesVehicleidSmartchargingstatus (string vehicleId)

Get Vehicle Smart Charging Status

Every vehicle in Enode has a [SmartChargingStatus](/docs/smart-charging/introduction) object that describes the vehicle in terms of smart charging.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class GetVehiclesVehicleidSmartchargingstatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.

            try
            {
                // Get Vehicle Smart Charging Status
                GetVehiclesVehicleidSmartchargingstatus200Response result = apiInstance.GetVehiclesVehicleidSmartchargingstatus(vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.GetVehiclesVehicleidSmartchargingstatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVehiclesVehicleidSmartchargingstatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Vehicle Smart Charging Status
    ApiResponse<GetVehiclesVehicleidSmartchargingstatus200Response> response = apiInstance.GetVehiclesVehicleidSmartchargingstatusWithHttpInfo(vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.GetVehiclesVehicleidSmartchargingstatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |

### Return type

[**GetVehiclesVehicleidSmartchargingstatus200Response**](GetVehiclesVehicleidSmartchargingstatus200Response.md)

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

<a name="postvehiclesvehicleidcharging"></a>
# **PostVehiclesVehicleidCharging**
> ChargeAction PostVehiclesVehicleidCharging (string vehicleId, ChargeActionPayload chargeActionPayload)

Control Charging

Register a request for a vehicle to start or stop charging. We retry sending the command until the vehicle's `chargeStateIsCharging` field transitions to the expected state. Note that this API request will complete before any commands are sent to the vehicle. There can only be one vendor action active for any one target id at a time. If a new action is created, the old action transitions to the `CANCELLED` state. You may react to transitions by listening for the `user:vendor-action:updated` webhook event or polling the [vehicle action endpoint](/api/reference#getVehiclesAction).   This endpoint returns an error with status code 422 if the vehicle is controlled by a schedule or has an active smart charging plan. To restore user control, either disable the schedule, disable smart charging, or use our [Smart Override API](/api/reference#vehicleCreateSmartOverride) to temporarily enable charging.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PostVehiclesVehicleidChargingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.
            var chargeActionPayload = new ChargeActionPayload(); // ChargeActionPayload | 

            try
            {
                // Control Charging
                ChargeAction result = apiInstance.PostVehiclesVehicleidCharging(vehicleId, chargeActionPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.PostVehiclesVehicleidCharging: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostVehiclesVehicleidChargingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Control Charging
    ApiResponse<ChargeAction> response = apiInstance.PostVehiclesVehicleidChargingWithHttpInfo(vehicleId, chargeActionPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.PostVehiclesVehicleidChargingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |
| **chargeActionPayload** | [**ChargeActionPayload**](ChargeActionPayload.md) |  |  |

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
| **422** | Vehicle controlled by a Schedule or has active Smart Charging Plan |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevehiclesmartchargingpolicy"></a>
# **UpdateVehicleSmartChargingPolicy**
> GetVehiclesVehicleidSmartchargingpolicy200Response UpdateVehicleSmartChargingPolicy (string vehicleId, VehicleSmartChargingPolicy? vehicleSmartChargingPolicy = null)

Update Vehicle Smart Charging Policy

Updates the [Smart Charging](/docs/smart-charging/introduction) policy for a vehicle

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class UpdateVehicleSmartChargingPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.
            var vehicleSmartChargingPolicy = new VehicleSmartChargingPolicy?(); // VehicleSmartChargingPolicy? |  (optional) 

            try
            {
                // Update Vehicle Smart Charging Policy
                GetVehiclesVehicleidSmartchargingpolicy200Response result = apiInstance.UpdateVehicleSmartChargingPolicy(vehicleId, vehicleSmartChargingPolicy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.UpdateVehicleSmartChargingPolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVehicleSmartChargingPolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Vehicle Smart Charging Policy
    ApiResponse<GetVehiclesVehicleidSmartchargingpolicy200Response> response = apiInstance.UpdateVehicleSmartChargingPolicyWithHttpInfo(vehicleId, vehicleSmartChargingPolicy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.UpdateVehicleSmartChargingPolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |
| **vehicleSmartChargingPolicy** | [**VehicleSmartChargingPolicy?**](VehicleSmartChargingPolicy?.md) |  | [optional]  |

### Return type

[**GetVehiclesVehicleidSmartchargingpolicy200Response**](GetVehiclesVehicleidSmartchargingpolicy200Response.md)

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

<a name="vehiclecreateexternalstart"></a>
# **VehicleCreateExternalStart**
> SmartOverrideResponse VehicleCreateExternalStart (string vehicleId)

Create External Start

Deprecated. Replaced by [Create Smart Override](/api/reference#vehicleCreateSmartOverride). The new name better reflects the functionality this endpoint offers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class VehicleCreateExternalStartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.

            try
            {
                // Create External Start
                SmartOverrideResponse result = apiInstance.VehicleCreateExternalStart(vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.VehicleCreateExternalStart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleCreateExternalStartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create External Start
    ApiResponse<SmartOverrideResponse> response = apiInstance.VehicleCreateExternalStartWithHttpInfo(vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.VehicleCreateExternalStartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |

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

<a name="vehiclecreatesmartoverride"></a>
# **VehicleCreateSmartOverride**
> SmartOverrideResponse VehicleCreateSmartOverride (string vehicleId)

Create Smart Override

Overrides an active smart feature by forcing the vehicle to start charging. This feature is meant to be used in situations where the user wants to charge immediately without disabling other smart features. The override remains active until the vehicle stops charging, or until the [Delete Smart Override](/api/reference#vehicleEndSmartOverride) endpoint is called. When the override ends, the overriden smart feature will regain control of the vehicle. This endpoint should not be used for standard charge control, use the [Control Charging](/api/reference#postVehiclesVehicleidCharging) endpoint instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class VehicleCreateSmartOverrideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.

            try
            {
                // Create Smart Override
                SmartOverrideResponse result = apiInstance.VehicleCreateSmartOverride(vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.VehicleCreateSmartOverride: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleCreateSmartOverrideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Smart Override
    ApiResponse<SmartOverrideResponse> response = apiInstance.VehicleCreateSmartOverrideWithHttpInfo(vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.VehicleCreateSmartOverrideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |

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

<a name="vehicleendexternalstart"></a>
# **VehicleEndExternalStart**
> SmartOverrideResponse VehicleEndExternalStart (string vehicleId)

End External Start

Deprecated. Replaced by [Delete Smart Override](/api/reference#vehicleEndSmartOverride). The new name better reflects the functionality this endpoint offers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class VehicleEndExternalStartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.

            try
            {
                // End External Start
                SmartOverrideResponse result = apiInstance.VehicleEndExternalStart(vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.VehicleEndExternalStart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleEndExternalStartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // End External Start
    ApiResponse<SmartOverrideResponse> response = apiInstance.VehicleEndExternalStartWithHttpInfo(vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.VehicleEndExternalStartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |

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

<a name="vehicleendsmartoverride"></a>
# **VehicleEndSmartOverride**
> SmartOverrideResponse VehicleEndSmartOverride (string vehicleId)

End Smart Override

Ends any active Smart Override for the vehicle specified by `vehicleId`. If previously configured, Schedules or Smart Charging will resume control over the target vehicle. Note that this does not mean the vehicle will stop charging, only that it will return to the state expected by the active Schedule or Smart Charging Plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class VehicleEndSmartOverrideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VehiclesApi(config);
            var vehicleId = "vehicleId_example";  // string | ID of the Vehicle.

            try
            {
                // End Smart Override
                SmartOverrideResponse result = apiInstance.VehicleEndSmartOverride(vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehiclesApi.VehicleEndSmartOverride: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleEndSmartOverrideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // End Smart Override
    ApiResponse<SmartOverrideResponse> response = apiInstance.VehicleEndSmartOverrideWithHttpInfo(vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehiclesApi.VehicleEndSmartOverrideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **string** | ID of the Vehicle. |  |

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
| **404** | No Active Smart Override Exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

