# EnodeApi.Model.StatisticsChargingTimeseriesSample

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kw** | [**ChargeRateAggregates**](ChargeRateAggregates.md) |  | 
**KwhSum** | **decimal** | Total power consumption in kWh | 
**Price** | [**PriceAggregates**](PriceAggregates.md) |  | 
**NonSmartPrice** | [**NonSmartPriceAggregates**](NonSmartPriceAggregates.md) |  | 
**CostSum** | **decimal** | Total cost in &#x60;&lt;CURRENCY&gt;&#x60; | 
**NonSmartCostSum** | **decimal** | Total cost for this consumption in &#x60;&lt;CURRENCY&gt;&#x60;, if it had not been shifted by Smart Charging | 
**EstimatedSavings** | **decimal** | Total estimated savings in &#x60;&lt;CURRENCY&gt;&#x60;, achieved by Smart Charging | 
**Date** | **DateTime** | The start date of this sample within the timeseries | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

