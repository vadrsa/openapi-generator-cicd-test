# EnodeApi.Model.GetVehiclesVehicleidSmartchargingpolicy200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **bool?** | When enabled, this vehicle&#39;s charging status may be controlled by [Smart Charging](/docs/smart-charging/introduction) | 
**Deadline** | **string** | The hour-minute deadline for fully charging the vehicle. Smart charging does not work without setting a deadline. If a timezone is set on the charging location at which the smart charging ocurrs, the deadline is interpreted in that timezone, otherwise UTC is used. | 
**MinimumChargeLimit** | **decimal** | Immediately charge without regard for energy prices until the vehicle reaches this minimum limit. The &#x60;hasChargeAboveThreshold&#x60; Smart Charge consideration uses this value. Defaults to zero. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

