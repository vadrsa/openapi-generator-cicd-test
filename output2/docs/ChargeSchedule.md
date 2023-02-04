# EnodeApi.Model.ChargeSchedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HourMinute** | [**ScheduleFiltersHourMinute**](ScheduleFiltersHourMinute.md) |  | [optional] 
**FromTimestamp** | **DateTime** | UTC timestamp from which this rule should apply. | [optional] 
**ToTimestamp** | **DateTime** | UTC timestamp until which this rule should apply. | [optional] 
**Weekdays** | **List&lt;ChargeSchedule.WeekdaysEnum&gt;** | An array of weekdays to which this rule should apply. A weekday starts with 0 for Monday and ends with 6 for Sunday. | [optional] 
**ShouldCharge** | **bool** | Whether a chargeable asset should want to charge while this rule is active. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

