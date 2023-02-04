# EnodeApi.Model.VendorAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**TargetId** | **string** |  | [optional] 
**TargetType** | **VendorType** |  | [optional] 
**Kind** | **ChargingAction** |  | [optional] 
**Target** | [**VendorActionTarget**](VendorActionTarget.md) |  | [optional] 
**TargetState** | [**VendorActionTargetState**](VendorActionTargetState.md) |  | [optional] 
**CreatedAt** | **string** |  | 
**UpdatedAt** | **string** |  | 
**CompletedAt** | **string** | ISO8601 UTC timestamp at which the action transitioned to a non-pending state. If this value is set, then we are no longer sending commands to the chargeable. | 
**State** | [**VendorActionState**](VendorActionState.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

