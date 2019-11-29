# YL.Web.Api.ThirdParty.Loan.Client.Api.LoansApi

All URIs are relative to *https://staging.youlendapi.com/loan*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllLoans**](LoansApi.md#getallloans) | **GET** /Loans/{customerId}/loans | Get all loans associated with your Customer ID
[**GetLoan**](LoansApi.md#getloan) | **GET** /Loans/{loanId} | Get a specific loan by its Loan ID
[**GetRepayments**](LoansApi.md#getrepayments) | **GET** /Loans/{loanId}/repayments | Get the repayment information associated with a given loan&#39;s Loan ID


<a name="getallloans"></a>
# **GetAllLoans**
> List&lt;LoansModel&gt; GetAllLoans (string customerId, string apiVersion = null)

Get all loans associated with your Customer ID

Sample request:                    GET Loans/1cd09db1-e6d2-4d64-aeba-9e64b818461a/loans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Loan.Client.Api;
using YL.Web.Api.ThirdParty.Loan.Client.Client;
using YL.Web.Api.ThirdParty.Loan.Client.Model;

namespace Example
{
	public class GetAllLoansExample
	{
		public static void Main()
		{
		   var config = new Configuration
			{
				BasePath = "https://dev.youlendapi.com/prequalification"",
				AccessToken =
					"YOUR_ACCESS_TOKEN"
			};
			
			var apiInstance = new LoansApi(config);
			var customerId = customerId_example;  // string | Customer ID (a string) (default to "")
			var apiVersion = apiVersion_example;  // string |  (optional) 

			try
			{
				// Get all loans associated with your Customer ID
				List<LoansModel> result = apiInstance.GetAllLoans(customerId, apiVersion);
				Debug.WriteLine(result);
			}
			catch (ApiException  e)
			{
				Debug.Print("Exception when calling LoansApi.GetAllLoans: " + e.Message );
				Debug.Print("Status Code: "+ e.ErrorCode);
				Debug.Print(e.StackTrace);
			}
		}
	}
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| Customer ID (a string) | [default to &quot;&quot;]
 **apiVersion** | **string**|  | [optional] 

### Return type

[**List&lt;LoansModel&gt;**](LoansModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Loans successfully retrieved |  -  |
| **401** | Unauthorized request! Please check your bearer token |  -  |
| **400** | Something went wrong! Please check your Customer ID |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloan"></a>
# **GetLoan**
> List&lt;LoanModel&gt; GetLoan (string loanId, string apiVersion = null)

Get a specific loan by its Loan ID

Sample request:                    GET Loans/71abf3e6-d6a8-45d2-8394-55cc32260bee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Loan.Client.Api;
using YL.Web.Api.ThirdParty.Loan.Client.Client;
using YL.Web.Api.ThirdParty.Loan.Client.Model;

namespace Example
{
	public class GetLoanExample
	{
		public static void Main()
		{
			    var config = new Configuration
			{
				BasePath = "https://dev.youlendapi.com/prequalification"",
				AccessToken =
					"YOUR_ACCESS_TOKEN"
			};
			
            var apiInstance = new LoansApi(config);
			var loanId = loanId_example;  // string | Loan ID (a string) (default to "")
			var apiVersion = apiVersion_example;  // string |  (optional) 

			try
			{
				// Get a specific loan by its Loan ID
				List<LoanModel> result = apiInstance.GetLoan(loanId, apiVersion);
				Debug.WriteLine(result);
			}
			catch (ApiException  e)
			{
				Debug.Print("Exception when calling LoansApi.GetLoan: " + e.Message );
				Debug.Print("Status Code: "+ e.ErrorCode);
				Debug.Print(e.StackTrace);
			}
		}
	}
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Loan ID (a string) | [default to &quot;&quot;]
 **apiVersion** | **string**|  | [optional] 

### Return type

[**List&lt;LoanModel&gt;**](LoanModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Loan successfully retrieved |  -  |
| **401** | Unauthorized request! Please check your bearer token |  -  |
| **400** | Something went wrong! Please check your Loan ID |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepayments"></a>
# **GetRepayments**
> LoanRepaymentModel GetRepayments (string loanId, string apiVersion = null)

Get the repayment information associated with a given loan's Loan ID

Sample request:                    GET /Loans/71abf3e6-d6a8-45d2-8394-55cc32260bee/repayments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Loan.Client.Api;
using YL.Web.Api.ThirdParty.Loan.Client.Client;
using YL.Web.Api.ThirdParty.Loan.Client.Model;

namespace Example
{
	public class GetRepaymentsExample
	{
		public static void Main()
		{
			    var config = new Configuration
			{
				BasePath = "https://dev.youlendapi.com/prequalification"",
				AccessToken =
					"YOUR_ACCESS_TOKEN"
			};
			
            var apiInstance = new LoansApi(config);
			var loanId = loanId_example;  // string | Loan ID (a string) (default to "")
			var apiVersion = apiVersion_example;  // string |  (optional) 

			try
			{
				// Get the repayment information associated with a given loan's Loan ID
				LoanRepaymentModel result = apiInstance.GetRepayments(loanId, apiVersion);
				Debug.WriteLine(result);
			}
			catch (ApiException  e)
			{
				Debug.Print("Exception when calling LoansApi.GetRepayments: " + e.Message );
				Debug.Print("Status Code: "+ e.ErrorCode);
				Debug.Print(e.StackTrace);
			}
		}
	}
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Loan ID (a string) | [default to &quot;&quot;]
 **apiVersion** | **string**|  | [optional] 

### Return type

[**LoanRepaymentModel**](LoanRepaymentModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Loan repayments successfully retrieved |  -  |
| **401** | Unauthorized request! Please check your bearer token |  -  |
| **400** | Something went wrong! Please check your Loan ID |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

