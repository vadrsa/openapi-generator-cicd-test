# EnodeApi.Model.DEPRECATEDExternalStart
Deprecated, replaced by the smartOverride field.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | ISO8601 UTC timestamp at which the smart override was created. | 
**EndedAt** | **DateTime?** | ISO8601 UTC timestamp at which the smart override was ended. If null, the smart override is still active. | 
**TargetType** | **string** | The Vendor Type of the target entity this smart override is referencing. | 
**TargetId** | **string** |  | 
**VendorActionId** | **string** | The ID of Vendor Action responsible for starting charging on the target. Use the [Vehicle Get Action](/api/reference#getVehiclesAction) or the [Charger Get Action](/api/reference#getChargersAction) endpoints to monitor action results. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

