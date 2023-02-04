# EnodeApi.Model.Inverter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Solar inverter ID | [readonly] 
**Vendor** | **InverterVendor** |  | 
**ChargingLocationId** | **string** | ID of the charging location the solar inverter is currently positioned at (if any). | [optional] 
**LastSeen** | **DateTime** | The last time the solar inverter was successfully communicated with | [readonly] 
**IsReachable** | **bool** | Whether live data from the solar inverter is currently fetchable from Enode&#39;s perspective. This &#39;reachability&#39; may refer to reading from a cache operated by the solar inverter&#39;s cloud service if that service has determined that its cache is valid. | [readonly] 
**ProductionState** | [**InverterProductionState**](InverterProductionState.md) |  | 
**Information** | [**InverterInformation**](InverterInformation.md) |  | 
**Location** | [**InverterLocation**](InverterLocation.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

