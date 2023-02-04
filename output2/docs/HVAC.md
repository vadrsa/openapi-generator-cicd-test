# EnodeApi.Model.HVAC

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | HVAC device ID | 
**Vendor** | **HVACVendor** |  | 
**LastSeen** | **DateTime?** | The last time the HVAC unit was successfully communicated with | 
**IsReachable** | **bool** | Whether live data from the HVAC unit is currently fetchable from Enode&#39;s perspective. It can happen that this &#39;reachability&#39; refers to reading from a cache operated by the vendor&#39;s cloud service, if that service has determined that its cache is valid. | 
**ChargingLocationId** | **string** | ID of the charging location the HVAC unit is housed at (if any) | [optional] 
**IsActive** | **bool** | Whether the HVAC unit is actively heating or cooling. | [optional] 
**CurrentTemperature** | **decimal?** | Current air temperature reported by device in degrees Celsius. | [optional] 
**TargetTemperature** | [**DEPRECATEDTargetTemperature**](DEPRECATEDTargetTemperature.md) |  | 
**ConsumptionRate** | **decimal?** | The current rate of energy consumption in kW. An inactive HVAC will have a consumption rate of 0. This value is currently experimental and is typically estimated with a large margin of error. | [optional] 
**Mode** | **string** | The HVAC&#39;s mode. | [optional] 
**HeatSetpoint** | **decimal?** | If mode allows, heat when &#x60;currentTemperature&#x60; falls below this point. | [optional] 
**CoolSetpoint** | **decimal?** | If mode allows, cool when &#x60;currentTemperature&#x60; rises above this point. | [optional] 
**HoldType** | **string** | The duration the setpoints and mode are expected to be held. If &#x60;SCHEDULED&#x60;, the device is being controlled by an OEM schedule configured on the device. | [optional] 
**Information** | [**HVACInformation**](HVACInformation.md) |  | 
**Capabilities** | [**HVACCapabilities**](HVACCapabilities.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

