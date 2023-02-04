# EnodeApi.Model.SmartOverrideStatus
This field is only populated after calling the [vehicle](/api/reference#vehicleCreateSmartOverride) or [charger](/api/reference#chargerCreateSmartOverride) smart override APIs. While this parameter is populated, the parent charge controller will remain in an overridden state and will not attempt to send actions to the target. The smart override remains in place until the target stops charging for any reason, or until the smart override is ended via the Delete [vehicle](/api/reference#vehicleEndSmartOverride) or [charger](/api/reference#chargerEndSmartOverride) smart override APIs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | ISO8601 UTC timestamp at which the smart override was created. | 
**EndedAt** | **DateTime?** | ISO8601 UTC timestamp at which the smart override was ended. If null, the smart override is still active. | 
**TargetType** | **ChargeableVendorType** |  | 
**TargetId** | **string** |  | 
**VendorActionId** | **string** | The ID of Vendor Action responsible for starting charging on the target. Use the [Vehicle Get Action](/api/reference#getVehiclesAction) or the [Charger Get Action](/api/reference#getChargersAction) endpoints to monitor action results. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

