# EnodeApi.Model.HEAT1
Target mode for an HVAC device

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldType** | **string** |  | [optional] 
**Mode** | **string** | Desired mode. HVAC units may specify a list of &#x60;capableModes&#x60; under capabilities. No setpoints are accepted in the &#x60;OFF&#x60; state. | 
**HeatSetpoint** | **decimal** | Desired heat setpoint, required when &#x60;mode&#x60; is &#x60;HEAT&#x60; or &#x60;AUTO&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

