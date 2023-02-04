# EnodeApi.Model.ChargerChargeState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPluggedIn** | **bool?** | Indicates whether the charger has a vehicle plugged into it (regardless of whether that vehicle is actually charging) | 
**IsCharging** | **bool?** | Current charging status | 
**ChargeRate** | **decimal?** | The current charge rate in kW.  This property is only available when the charger is actively charging a vehicle, and is &#x60;null&#x60; any other time. | 
**LastUpdated** | **DateTime?** | ISO8601 UTC timestamp of last received charge state update | 
**MaxCurrent** | **decimal?** | Desired max current in ampere, if set | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

