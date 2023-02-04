# EnodeApi.Model.PartialSchedule
A Schedule that applies to the combination of a certain Charging Location and a linked asset (Vehicle/Charger/HVAC). Read the guide to [Using Schedules](/docs/scheduling).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetId** | **string** | ID of the HVAC asset to which this schedule applies | [optional] 
**TargetType** | **HvacVendorType** |  | [optional] 
**ChargingLocationId** | **Guid?** | ID of the Charging Location to which this schedule applies. If null, the schedule is applied regardless of the HVAC&#39;s location (even if it doesn&#39;t have one). | [optional] 
**IsEnabled** | **bool** | Whether this Schedule should be attempting to control the HVAC&#39;s temperature settings. | [optional] [default to true]
**DefaultShouldCharge** | **bool** | When no rule is active, the default charge state for the target. | [optional] 
**Rules** | [**List&lt;TemperatureSchedule&gt;**](TemperatureSchedule.md) | Each rule sets a value for &#x60;holdType&#x60; and associated settings. All other properties of the rule are optional filters that limit the times to which this rule applies. | [optional] 
**DefaultTargetState** | [**PartialTemperatureScheduleDefaultTargetState**](PartialTemperatureScheduleDefaultTargetState.md) |  | [optional] 
**DefaultTarget** | [**PartialTemperatureScheduleDefaultTarget**](PartialTemperatureScheduleDefaultTarget.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

