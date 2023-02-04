# EnodeApi.Api.TariffsApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssociateChargingLocationWithTariff**](TariffsApi.md#associatecharginglocationwithtariff) | **PUT** /charging-locations/{chargingLocationId}/tariff | Associate Charging Location With Tariff |
| [**SendTariffInformation**](TariffsApi.md#sendtariffinformation) | **PUT** /tariffs/{tariffId} | Send Tariff information |

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

            var apiInstance = new TariffsApi(config);
            var chargingLocationId = "chargingLocationId_example";  // string | ID of the Charging Location
            var chargingLocationTariffInterval = new ChargingLocationTariffInterval?(); // ChargingLocationTariffInterval? |  (optional) 

            try
            {
                // Associate Charging Location With Tariff
                apiInstance.AssociateChargingLocationWithTariff(chargingLocationId, chargingLocationTariffInterval);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TariffsApi.AssociateChargingLocationWithTariff: " + e.Message);
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
    Debug.Print("Exception when calling TariffsApi.AssociateChargingLocationWithTariffWithHttpInfo: " + e.Message);
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

<a name="sendtariffinformation"></a>
# **SendTariffInformation**
> void SendTariffInformation (string tariffId, List<TariffRate>? tariffRate = null)

Send Tariff information

Set a list of rates for a given `tariffId`. If previous data exists for a given `tariffId`, it will be overwritten. These tariffs are used in our Statistics and Smart Charging features.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class SendTariffInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TariffsApi(config);
            var tariffId = "tariffId_example";  // string | ID of the Tariff
            var tariffRate = new List<TariffRate>?(); // List<TariffRate>? |  (optional) 

            try
            {
                // Send Tariff information
                apiInstance.SendTariffInformation(tariffId, tariffRate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TariffsApi.SendTariffInformation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendTariffInformationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Tariff information
    apiInstance.SendTariffInformationWithHttpInfo(tariffId, tariffRate);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TariffsApi.SendTariffInformationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tariffId** | **string** | ID of the Tariff |  |
| **tariffRate** | [**List&lt;TariffRate&gt;?**](TariffRate.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successfully updated. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

