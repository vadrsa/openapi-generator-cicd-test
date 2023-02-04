# EnodeApi.Model.StatisticsTimeseriesSessionSample

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID for this session. | 
**TargetId** | **string** | ID of the hardware type for this session. | 
**ChargingLocationId** | **string** | Charging Location ID for this session. | 
**From** | **DateTime** | Start time. | 
**To** | **DateTime** | End time. | 
**Kw** | [**ChargeRateAggregates**](ChargeRateAggregates.md) |  | 
**KwhSum** | **decimal** | Total power consumption in kWh | 
**Price** | [**PriceAggregates**](PriceAggregates.md) |  | 
**CostSum** | **decimal** | Total cost in &#x60;&lt;CURRENCY&gt;&#x60; | 
**SmartSession** | **bool** | The values in &#x60;smartStats&#x60; will all be &#x60;null&#x60; if &#x60;smartSession&#x60; is &#x60;false&#x60; | 
**SmartStats** | [**StatisticsTimeseriesSessionSampleSmartStats**](StatisticsTimeseriesSessionSampleSmartStats.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

