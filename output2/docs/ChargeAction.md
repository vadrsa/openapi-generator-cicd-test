# EnodeApi.Model.ChargeAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**TargetId** | **string** |  | 
**TargetType** | **ChargeableVendorType** |  | 
**Kind** | **ChargingAction** |  | 
**CreatedAt** | **DateTime** | ISO8601 UTC timestamp | 
**UpdatedAt** | **DateTime** | ISO8601 UTC timestamp | 
**CompletedAt** | **DateTime** | ISO8601 UTC timestamp at which the action transitioned to a non-pending state. If this value is set, then we are no longer sending commands to the chargeable. | 
**State** | [**VendorActionState**](VendorActionState.md) |  | 
**EntityId** | **string** |  | 
**EntityType** | **string** |  | 
**ChargeableId** | **string** |  | 
**ChargeableType** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

