# EnodeApi.Model.TemperatureScheduleStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleId** | **Guid** |  | 
**ScheduleType** | **string** |  | 
**State** | **string** | An enum value that describes the current state of the Schedule | 
**ChangedAt** | **DateTime** | Time at which any value of the status last changed | 
**Current** | [**TemperatureScheduleStatusCurrent**](TemperatureScheduleStatusCurrent.md) |  | [optional] 
**Expected** | [**TemperatureScheduleStatusCurrent**](TemperatureScheduleStatusCurrent.md) |  | 
**UpcomingTransitions** | [**List&lt;TemperatureScheduleStatusUpcomingTransitionsInner&gt;**](TemperatureScheduleStatusUpcomingTransitionsInner.md) | List of upcoming transitions. A maximum of 2 items are returned. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

