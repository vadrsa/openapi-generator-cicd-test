# EnodeApi.Model.Charger

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Charger ID | 
**Vendor** | **ChargerVendor** |  | 
**LastSeen** | **DateTime?** | The last time the charger was successfully communicated with | 
**IsReachable** | **bool** | Whether live data from the charger is currently fetchable from Enode&#39;s perspective. This &#39;reachability&#39; may refer to reading from a cache operated by the charger&#39;s cloud service if that service has determined that its cache is valid. | 
**ChargingLocationId** | **string** | ID of the charging location the charger is currently positioned at (if any). | 
**ChargeState** | [**ChargerChargeState**](ChargerChargeState.md) |  | 
**Information** | [**ChargerInformation**](ChargerInformation.md) |  | 
**Capabilities** | [**ChargerCapabilities**](ChargerCapabilities.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

