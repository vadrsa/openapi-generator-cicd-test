# EnodeApi.Model.PartialChargeSchedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetId** | **string** | ID of the asset (Vehicle/Charger) to which this schedule applies | [optional] 
**TargetType** | **ChargeableVendorType** |  | [optional] 
**ChargingLocationId** | **Guid?** | ID of the Charging Location to which this schedule applies. The behaviour of a null value differes based on the &#x60;targetType&#x60;. For chargers, a null value is essentially ignored and the schedule is applied even if the charger isn&#39;t at a charging location.  This is designed to prevent schedules from controlling vehicles at public chargers where the user doesn&#39;t pay for electricity. | [optional] 
**IsEnabled** | **bool** | Whether this Schedule should be attempting to control the target&#39;s charge state. | [optional] [default to true]
**DefaultShouldCharge** | **bool** | When no rule is active, the default charge state for the target. | [optional] 
**Rules** | [**List&lt;ChargeSchedule&gt;**](ChargeSchedule.md) | Each rule sets a value for &#x60;shouldCharge&#x60;, either &#x60;true&#x60; or &#x60;false&#x60;. All other properties of the rule are optional filters that limit the times to which this rule applies. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

