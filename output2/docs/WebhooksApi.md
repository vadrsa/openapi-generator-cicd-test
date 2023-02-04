# EnodeApi.Api.WebhooksApi

All URIs are relative to *https://enode-api.production.enode.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteWebhooksFirehose**](WebhooksApi.md#deletewebhooksfirehose) | **DELETE** /webhooks/firehose | Delete Firehose Webhook |
| [**PostWebhooksFirehoseTest**](WebhooksApi.md#postwebhooksfirehosetest) | **POST** /webhooks/firehose/test | Test Firehose Webhook |
| [**PutWebhooksFirehose**](WebhooksApi.md#putwebhooksfirehose) | **PUT** /webhooks/firehose | Update Firehose Webhook |

<a name="deletewebhooksfirehose"></a>
# **DeleteWebhooksFirehose**
> void DeleteWebhooksFirehose (DeleteFirehoseWebhook? deleteFirehoseWebhook = null)

Delete Firehose Webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class DeleteWebhooksFirehoseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var deleteFirehoseWebhook = new DeleteFirehoseWebhook?(); // DeleteFirehoseWebhook? |  (optional) 

            try
            {
                // Delete Firehose Webhook
                apiInstance.DeleteWebhooksFirehose(deleteFirehoseWebhook);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksFirehose: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhooksFirehoseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Firehose Webhook
    apiInstance.DeleteWebhooksFirehoseWithHttpInfo(deleteFirehoseWebhook);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksFirehoseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteFirehoseWebhook** | [**DeleteFirehoseWebhook?**](DeleteFirehoseWebhook?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Webhook not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postwebhooksfirehosetest"></a>
# **PostWebhooksFirehoseTest**
> TestFirehoseWebhook PostWebhooksFirehoseTest ()

Test Firehose Webhook

Trigger a  \"enode:firehose:test\" payload to be sent to your configured Firehose Webhook URL. This will reset your webhook to a healthy state on success.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PostWebhooksFirehoseTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi(config);

            try
            {
                // Test Firehose Webhook
                TestFirehoseWebhook result = apiInstance.PostWebhooksFirehoseTest();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.PostWebhooksFirehoseTest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostWebhooksFirehoseTestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test Firehose Webhook
    ApiResponse<TestFirehoseWebhook> response = apiInstance.PostWebhooksFirehoseTestWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.PostWebhooksFirehoseTestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TestFirehoseWebhook**](TestFirehoseWebhook.md)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putwebhooksfirehose"></a>
# **PutWebhooksFirehose**
> void PutWebhooksFirehose (UpdateFirehoseWebhookPayload? updateFirehoseWebhookPayload = null)

Update Firehose Webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EnodeApi.Api;
using EnodeApi.Client;
using EnodeApi.Model;

namespace Example
{
    public class PutWebhooksFirehoseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://enode-api.production.enode.io";
            // Configure OAuth2 access token for authorization: ClientAccessToken
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var updateFirehoseWebhookPayload = new UpdateFirehoseWebhookPayload?(); // UpdateFirehoseWebhookPayload? |  (optional) 

            try
            {
                // Update Firehose Webhook
                apiInstance.PutWebhooksFirehose(updateFirehoseWebhookPayload);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.PutWebhooksFirehose: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutWebhooksFirehoseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Firehose Webhook
    apiInstance.PutWebhooksFirehoseWithHttpInfo(updateFirehoseWebhookPayload);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.PutWebhooksFirehoseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateFirehoseWebhookPayload** | [**UpdateFirehoseWebhookPayload?**](UpdateFirehoseWebhookPayload?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[ClientAccessToken](../README.md#ClientAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Webhook not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

