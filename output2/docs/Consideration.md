# EnodeApi.Model.Consideration
`null` by default, but during the `CONSIDERING` state, the value is populated with a list of all the requirements that must be true before a plan will be created

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSmartChargeCapable** | **bool** | Vehicle has the capability &#39;smartCharging&#39; | 
**IsPluggedIn** | **bool** | The vehicle is plugged in | 
**IsCharging** | **bool** | The vehicle is charging | 
**RecentlyAtChargingLocation** | **bool** | The vehicle is located at a configured Charging Location | 
**HasTimeEstimate** | **bool** | A good estimate is available of how much time it will take to charge. | 
**NeedsSignificantCharge** | **bool** | The charge needed is greater than 60 minutes and greater than 5% of total battery capacity | 
**HasChargeAboveThreshold** | **bool** | The vehicle&#39;s &#x60;batteryLevel&#x60; is above the configured &#x60;minimumChargeLimit&#x60;. &#x60;minimumChargeLimit&#x60; defaults to zero. | 
**SingleUser** | **bool** | Only one user has this vehicle actively connected to Enode. Nearly always true in real use cases, but can be an issue for vehicles used in testing/development/integration. | 
**WontStopExistingChargingSession** | **bool** | If charging started before the previous deadline, we assume vehicle should be left charging, and we will not create a charge plan. For example, if you start charging a vehicle at 03:00 with a deadline of 06:00 and 6 hours remaining, &#x60;wontStopExistingChargingSession&#x60; will be false once the deadline is passed. It resets to true the next time you plug in your car. | 
**LikelyToGenerateSavings** | **bool** | The price data available indicates that shifting the charging window will  result in price savings, or is likely to result in price savings. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

