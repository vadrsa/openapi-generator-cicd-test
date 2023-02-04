# EnodeApi.Model.DEPRECATEDTargetTemperature
Replaced with `coolSetpoint` and `heatSetpoint`. A future release will remove this field. Target temperature for a HVAC device.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Temperature** | **decimal?** | Desired temperature | 
**Deadband** | **decimal?** | Size of the optional deadband centered around &#x60;temperature&#x60;.  For example, with a &#x60;temperature&#x60; of 22.0 and a &#x60;deadband&#x60; of 4.0, an HVAC unit will receive a heating setpoint of 20.0 and a cooling setpoint of 24.0 | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

