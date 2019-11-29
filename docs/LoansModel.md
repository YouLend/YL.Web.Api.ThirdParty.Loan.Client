# YL.Web.Api.ThirdParty.Loan.Client.Model.LoansModel
Model representing one of a selection of loans
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the loan&#39;s unique identifier | [optional] 
**LoanNumber** | **int** | Gets or sets the Loan Number, an ordinal value indicating which of a customer&#39;s loans is here detailed | [optional] 
**LenderId** | **Guid** | Gets or sets the lender&#39;s unique identifier | [optional] 
**LenderName** | **string** | Gets or sets the lender&#39;s full name | [optional] 
**BorrowerId** | **Guid** | Gets or sets the borrower&#39;s unique identifier | [optional] 
**BorrowerName** | **string** | Gets or sets the borrower&#39;s full name | [optional] 
**CurrentAmount** | **double** | Gets or sets the Current Amount, the amount yet to be repaid | [optional] 
**LoanType** | **string** | Gets or sets the Loan Type - \&quot;Initial\&quot;, \&quot;Refinanced\&quot; or \&quot;Renewal\&quot; | [optional] 
**Status** | **string** | Gets or sets the loan&#39;s Status - \&quot;Deleted\&quot;, \&quot;Funded\&quot;, \&quot;Funded (Pending Settlement)\&quot;, \&quot;Refinanced\&quot;, \&quot;Repaid\&quot;, \&quot;Written Off\&quot; | [optional] 
**MaturityDate** | **DateTime** | Gets or sets the date on which the loan is due to mature, and by which it should be fully repaid | [optional] 
**Sweep** | **double** | Gets or sets the Sweep, the decimal out of 100 representing the proportion of transaction income to be used to repay the loan | [optional] 
**AutoRepaymentSweep** | **bool** | Gets or sets a value indicating whether an Auto Repayment Sweep is to be used - this feature automatically directs a chosen proportion, the Sweep, of transaction income towards repaying the loan | [optional] 
**CurrencyISOCode** | **string** | Gets or sets the loan&#39;s Currency ISO Code, e.g. \&quot;GBP\&quot; | [optional] 
**LendingPartnerIds** | **List&lt;Guid&gt;** | Gets or sets the unique identifiers of any lending partners associated with the loan | [optional] 
**Owners** | [**List&lt;LoanOwnerModel&gt;**](LoanOwnerModel.md) | Gets or sets a collection detailing the loan&#39;s Owners YL.Web.Api.ThirdParty.Loan.Models.LoanOwnerModel | [optional] 
**CurrentAmountAtRepay** | **double** | Gets or sets the Current Amount at the time of full loan repayment, if applicable | [optional] 
**CurrentAmountAtDelete** | **double** | Gets or sets the Current Amount at the time of loan deletion, if applicable | [optional] 
**CurrentAmountAtWriteOff** | **double** | Gets or sets the Current Amount at the time of loan write-off, if applicable | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

