# EnodeApi.Model.VendorActionTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Temperature** | **decimal?** | Desired temperature | 
**Deadband** | **decimal?** | Size of the optional deadband centered around &#x60;temperature&#x60;.  For example, with a &#x60;temperature&#x60; of 22.0 and a &#x60;deadband&#x60; of 4.0, an HVAC unit will receive a heating setpoint of 20.0 and a cooling setpoint of 24.0 | 
**Mode** | **string** | Desired mode. HVAC units may specify a list of &#x60;capableModes&#x60; under capabilities. No setpoints are accepted in the &#x60;OFF&#x60; state. | 
**HeatSetpoint** | **decimal** | Desired heat setpoint, required when &#x60;mode&#x60; is &#x60;HEAT&#x60; or &#x60;AUTO&#x60;. | 
**CoolSetpoint** | **decimal** | Desired cool setpoint, required when &#x60;mode&#x60; is &#x60;COOL&#x60; or &#x60;AUTO&#x60;. | 
**HoldType** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

