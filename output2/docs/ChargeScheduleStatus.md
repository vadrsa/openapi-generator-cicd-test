# EnodeApi.Model.ChargeScheduleStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleId** | **Guid** |  | 
**ScheduleType** | **string** |  | 
**ChangedAt** | **DateTime** | Time at which any value of the status last changed | 
**State** | **string** | An enum value that describes the current state of the Schedule | 
**IsCharging** | **bool** | Whether the target is currently actually charging | 
**IsChargingExpected** | **bool** | Whether the target is currently expected to be charging | 
**IsChargingExpectedParts** | [**ChargeScheduleStatusIsChargingExpectedParts**](ChargeScheduleStatusIsChargingExpectedParts.md) |  | 
**UpcomingTransitions** | [**List&lt;ChargeScheduleStatusUpcomingTransitionsInner&gt;**](ChargeScheduleStatusUpcomingTransitionsInner.md) | List of upcoming transitions of the &#x60;shouldCharge&#x60; or &#x60;targetTemperature&#x60; value. A maximum of 2 items are returned. | 
**SmartOverride** | [**SmartOverrideStatus**](SmartOverrideStatus.md) |  | 
**ExternalStart** | [**DEPRECATEDExternalStart**](DEPRECATEDExternalStart.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

