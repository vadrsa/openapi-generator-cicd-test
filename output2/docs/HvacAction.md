# EnodeApi.Model.HvacAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**TargetId** | **string** |  | [optional] 
**TargetType** | **HvacVendorType** |  | [optional] 
**TargetTemperature** | [**DEPRECATEDTargetTemperature**](DEPRECATEDTargetTemperature.md) |  | [optional] 
**Target** | [**HvacTargetStateDevhub**](HvacTargetStateDevhub.md) |  | [optional] 
**CreatedAt** | **DateTime** | ISO8601 UTC timestamp | [optional] 
**UpdatedAt** | **DateTime** | ISO8601 UTC timestamp | [optional] 
**CompletedAt** | **DateTime** | ISO8601 UTC Timestamp at which the action transitioned to a non-pending state. If this value is set, then we are no longer sending temperature commands to the HVAC device. | [optional] 
**State** | [**HVACActionState**](HVACActionState.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

