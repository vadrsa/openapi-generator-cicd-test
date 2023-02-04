# EnodeApi.Model.DEPRECATEDConsideration
`null` by default, but during the `CONSIDERING` state, the value is populated with a list of all the requirements that must be true before a plan will be created

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSmartChargeCapable** | **bool** | Vehicle has the capability &#39;smartCharging&#39; | [optional] 
**IsPluggedIn** | **bool** | The vehicle is plugged in | 
**IsCharging** | **bool** | The vehicle is charging | 
**HasTimeEstimate** | **bool** | A good estimate is available of how much time it will take to charge. | 
**NeedsSignificantCharge** | **bool** | The charge needed is greater than 60 minutes and greater than 5% of total battery capacity | 
**HasChargeAboveThreshold** | **bool** | The vehicle&#39;s &#x60;batteryLevel&#x60; is above the configured &#x60;minimumChargeLimit&#x60;. &#x60;minimumChargeLimit&#x60; defaults to zero. | 
**SingleUser** | **bool** | Only one user has this vehicle actively connected to Enode. Nearly always true in real use cases, but can be an issue for vehicles used in testing/development/integration. | 
**ConfidentBatteryCapacity** | **bool** |  | 
**AtChargingLocation** | **bool** |  | 
**LocationIsFresh** | **bool** |  | 
**ConfidentTimeEstimate** | **bool** |  | 
**NeedsCharge** | **bool** |  | 
**PriceDataAvailable** | **bool** |  | 
**MinimumSavings** | **bool** |  | 
**MinimumDelay** | **bool** |  | 
**IsNormalSchedule** | **bool** |  | 
**NoCommittedDelay** | **bool** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

