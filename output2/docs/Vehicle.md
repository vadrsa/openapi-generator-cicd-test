# EnodeApi.Model.Vehicle

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Vehicle ID | 
**Vendor** | **VehicleVendor** |  | 
**LastSeen** | **DateTime?** | ISO8601 UTC timestamp at which live data was last available from Enode&#39;s perspective. | 
**IsReachable** | **bool?** | Whether live data from the vehicle is currently available from Enode&#39;s perspective. This &#39;reachability&#39; may refer to reading from a cache operated by the vehicle&#39;s cloud service if that service has determined that its cache is valid. | 
**ChargingLocationId** | **string** | ID of the charging location the vehicle is currently positioned at (if any). | 
**Information** | [**VehicleInformation**](VehicleInformation.md) |  | 
**ChargeState** | [**VehicleChargeState**](VehicleChargeState.md) |  | 
**SmartChargingPolicy** | [**VehicleSmartChargingPolicy**](VehicleSmartChargingPolicy.md) |  | 
**Location** | [**VehicleLocation**](VehicleLocation.md) |  | 
**Odometer** | [**VehicleOdometer**](VehicleOdometer.md) |  | 
**Capabilities** | [**VehicleCapabilities**](VehicleCapabilities.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

