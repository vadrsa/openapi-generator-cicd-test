# EnodeApi.Model.VehicleSmartChargingPlan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the Plan | 
**ChargingLocationId** | **string** | ID of the charging location at which the plan is being executed. Null for plans started before March 2022. | 
**VehicleId** | **string** | ID of the Vehicle to which the Plan belongs | 
**UserId** | **string** | ID of the User to which the Plan belongs | 
**Vendor** | **string** | Vendor of the Vehicle to which the Plan belongs | 
**Currency** | **string** | Currency in which monetary amounts are denominated (ISO 4217 3-character Alpha code) | 
**NonSmartCost** | **decimal** |  | 
**SmartCost** | **decimal?** |  | 
**StopAt** | **DateTime** | Time at which the vehicle will stop charging | 
**StartAt** | **DateTime?** | Time at which the vehicle will start charging | 
**EstimatedFinishAt** | **DateTime** | Time at which charging is estimated to be complete | 
**StopConfirmedAt** | **DateTime?** | Time at which the vehicle&#39;s charging was confirmed as stopped. | 
**StartConfirmedAt** | **DateTime?** | Time at which the vehicle&#39;s charging was confirmed as started. | 
**EndedAt** | **DateTime?** | The actual time at which the plan ended | 
**FinalState** | **string** | The final state of the plan when it ended | 
**FailureCondition** | **string** | If the finalState was PLAN:ENDED:FAILED, failureCondition is populated with the condition in which the plan failed. | 
**ExternalStart** | [**DEPRECATEDExternalStart**](DEPRECATEDExternalStart.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

