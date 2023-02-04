# EnodeApi.Model.VehicleChargeState
Information about the electric or hybrid battery.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatteryLevel** | **decimal?** | Remaining battery in percent | 
**Range** | **decimal?** | Estimated remaining kilometers | 
**IsPluggedIn** | **bool?** | Indicates whether the vehicle is connected to a charging box (regardless of whether it is actually charging) | 
**IsCharging** | **bool?** | Current charging status of the vehicle | 
**IsFullyCharged** | **bool?** | Indicates whether the vehicle is fully charged. &#39;Fully charged&#39; may be a &#x60;batteryLevel&#x60; of less than 100 if a maximum charge ceiling has been configured in the vehicle. | 
**BatteryCapacity** | **decimal?** | Vehicle&#39;s maximum physical battery capacity in kWh. This number slowly decreases/degrades over time. | 
**ChargeLimit** | **decimal?** | Charge limit, as a percent of &#x60;batteryCapacity&#x60;. | 
**ChargeRate** | **decimal?** | The current charge rate in kW.  This property is only available when the vehicle is charging, and is &#x60;null&#x60; any other time. | 
**ChargeTimeRemaining** | **decimal?** | Estimated time until the current charging intent is completed, in minutes.  This property is only available when the vehicle is charging, and is &#x60;null&#x60; any other time. | 
**LastUpdated** | **DateTime?** | ISO8601 UTC timestamp of last received charge state update | 
**IsChargingReasons** | **List&lt;VehicleChargeState.IsChargingReasonsEnum&gt;** | Array of string constants that explain why the car is or is not charging. May contain multiple values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

