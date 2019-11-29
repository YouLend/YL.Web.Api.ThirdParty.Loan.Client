# YL.Web.Api.ThirdParty.Loan.Client.Model.LoanModel
A model representing the details of an individual loan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoRepaymentSweep** | **bool** | Gets or sets a value indicating whether an Auto Repayment Sweep is to be used - this feature automatically directs a chosen proportion, the Sweep, of transaction income towards repaying the loan | [optional] 
**BorrowerId** | **Guid** | Gets or sets the Borrower ID | [optional] 
**BorrowerName** | **string** | Gets or sets the Borrower Name | [optional] 
**CreditRating** | **string** | Gets or sets the Credit Rating | [optional] 
**CurrencyISOCode** | **string** | Gets or sets the Currency ISO Code | [optional] 
**CurrentAmount** | **double** | Gets or sets the Current Amount, the amount yet to be repaid | [optional] 
**CurrentServiceChargeRate** | **double** | Gets or sets the Current Service Charge Rate | [optional] 
**DefaultDetails** | [**DefaultDetailsModel**](DefaultDetailsModel.md) |  | [optional] 
**Discount** | **double** | Gets or sets the loan&#39;s discount rate | [optional] 
**Id** | **Guid** | Gets or sets the loan&#39;s unique identifier | [optional] 
**LenderId** | **Guid** | Gets or sets the lender&#39;s unique identifier | [optional] 
**LenderName** | **string** | Gets or sets the lender&#39;s full name | [optional] 
**MaturityDate** | **DateTime** | Gets or sets the date on which the loan is due to mature, and by which it should be fully repaid | [optional] 
**OriginalAmount** | **double** | Gets or sets the Original Amount, the total amount due to be repaid on maturity | [optional] 
**OriginalProjectedAnnualisedReturn** | **double** | Gets or sets the Original Projected Annualised Return | [optional] 
**OriginalServiceChargeRate** | **double** | Gets or sets the Original Service Charge Rate | [optional] 
**ProjectedRepaymentDate** | **DateTime** | Gets or sets the Projected Repayment Date | [optional] 
**SecurityAndGuarantees** | **bool** | Gets or sets a value indicating whether the Security and Guarantees are in place | [optional] 
**LoanType** | **string** | Gets or sets the Loan Type - \&quot;Initial\&quot;, \&quot;Refinanced\&quot; or \&quot;Renewal\&quot; | [optional] 
**Status** | **string** | Gets or sets the loan&#39;s Status - \&quot;Deleted\&quot;, \&quot;Funded\&quot;, \&quot;Funded (Pending Settlement)\&quot;, \&quot;Refinanced\&quot;, \&quot;Repaid\&quot;, \&quot;Written Off\&quot; | [optional] 
**Sweep** | **double** | Gets or sets the Sweep, the decimal out of 100 representing the proportion of transaction income to be used to repay the loan | [optional] 
**UseOfProceeds** | **string** | Gets or sets the Use Of Proceeds, i.e. to what end the loaned funds will be used | [optional] 
**LoanNumber** | **int** | Gets or sets the Loan Number, an ordinal value indicating which of a customer&#39;s loans is here detailed | [optional] 
**RefinancingDetails** | [**LoanRefinancingDetailsModel**](LoanRefinancingDetailsModel.md) |  | [optional] 
**EarlyRenewalDetails** | [**EarlyRenewalDetailsModel**](EarlyRenewalDetailsModel.md) |  | [optional] 
**FundingDetails** | [**LoanFundingDetailsModel**](LoanFundingDetailsModel.md) |  | [optional] 
**WriteOffDetails** | [**LoanWriteOffDetailsModel**](LoanWriteOffDetailsModel.md) |  | [optional] 
**Owners** | [**List&lt;LoanOwnerModel&gt;**](LoanOwnerModel.md) | Gets or sets a collection detailing the loan&#39;s Owners YL.Web.Api.ThirdParty.Loan.Models.LoanOwnerModel | [optional] 
**ThirdPartyReferences** | [**List&lt;ThirdPartyReferenceModel&gt;**](ThirdPartyReferenceModel.md) | Gets or sets the loan&#39;s Third Party References YL.Web.Api.ThirdParty.Loan.Models.ThirdPartyReferenceModel | [optional] 
**Documents** | [**List&lt;LoanDocumentModel&gt;**](LoanDocumentModel.md) | Gets or sets the Documents YL.Web.Api.ThirdParty.Loan.Models.LoanDocumentModel supporting the loan application | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

