# EnodeApi.Model.VehicleSmartChargingStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UpdatedAt** | **DateTime** | Time at which the SmartChargingStatus object was recalculated, whether or not any values actually changed | 
**VehicleId** | **string** | Vehicle ID | 
**UserId** | **string** | User ID | 
**Vendor** | **string** | Vendor of the Vehicle | 
**State** | **string** | An enum value that describes the current SmartCharging state of the vehicle. Every vehicle is in exactly one state, at all times | 
**StateChangedAt** | **DateTime** | Time at which the the &#39;state&#39; property transitioned to its current value | 
**Consideration** | [**VehicleSmartChargingStatusConsideration**](VehicleSmartChargingStatusConsideration.md) |  | 
**Plan** | [**VehicleSmartChargingStatusPlan**](VehicleSmartChargingStatusPlan.md) |  | 
**SmartOverride** | [**SmartOverrideStatus**](SmartOverrideStatus.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

