# EnodeApi.Model.TemperatureScheduleAllOfTargetState
The target state to apply when this rule is active.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldType** | **string** | The duration the setpoints and mode are expected to be held. If &#x60;SCHEDULED&#x60;, the device is being controlled by an OEM schedule configured on the device. When targeting a &#x60;SCHEDLUED&#x60; holdType, no other properties should be specified. If &#x60;PERMANENT&#x60;, at least the mode must be specified. | 
**Mode** | **string** | Desired mode. HVAC units may specify a list of &#x60;capableModes&#x60; under capabilities. No setpoints are accepted in the &#x60;OFF&#x60; state. When specifying &#x60;HEAT&#x60; or &#x60;COOL&#x60;, the associated setpoint must be specified. Additionally, when targeting the &#x60;AUTO&#x60; state, both setpoints must be specified. | [optional] 
**HeatSetpoint** | **decimal** | Desired heat setpoint, required when &#x60;mode&#x60; is &#x60;HEAT&#x60; or &#x60;AUTO&#x60;. | [optional] 
**CoolSetpoint** | **decimal** | Desired cool setpoint, required when &#x60;mode&#x60; is &#x60;COOL&#x60; or &#x60;AUTO&#x60;. If both setpoints are specified, &#x60;coolSetpoint&#x60; must be larger than &#x60;heatSetpoint&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

