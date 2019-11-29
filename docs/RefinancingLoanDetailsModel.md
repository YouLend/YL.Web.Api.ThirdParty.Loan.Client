# YL.Web.Api.ThirdParty.Loan.Client.Model.RefinancingLoanDetailsModel
A model characterising the refinancing of a given loan, if applicable; here the \"old loan\" is that which was refinanced with the \"new\" or \"refinancing\" loan, while the \"consolidated loan\" represents the combination of these two loans
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanId** | **Guid** | Gets or sets the refinancing loan&#39;s unique identifier | [optional] 
**LoanNumber** | **int** | Gets or sets the refinancing loan&#39;s Loan Number, an ordinal value indicating which of a customer&#39;s loans is here detailed | [optional] 
**OldLoanOriginalAmount** | **double** | Gets or sets the old loan&#39;s Original Amount, the total amount due to be repaid on maturity | [optional] 
**OldLoanFundedAmount** | **double** | Gets or sets the old loan&#39;s Funded Amount, the total amount loaned to the customer | [optional] 
**OldLoanDiscount** | **double** | Gets or sets the old loan&#39;s discount rate | [optional] 
**OldLoanDiscountAmount** | **double** | Gets or sets the discount fee associated with the old loan | [optional] 
**OldLoanRepaymentAmount** | **double** | Gets or sets the amount repaid on the old loan | [optional] 
**OldLoanRepaymentFundedAmount** | **double** | Gets or sets the value of OldLoanRepaymentAmount accounted for by the Funded Amount | [optional] 
**OldLoanRepaymentDiscountAmount** | **double** | Gets or sets the value of OldLoanRepaymentAmount accounted for by the Discount Amount | [optional] 
**OldLoanUnpaidAmount** | **double** | Gets or sets the amount yet to be repaid on the old loan | [optional] 
**OldLoanUnpaidFundedAmount** | **double** | Gets or sets the value of OldLoanUnpaidAmount accounted for by the Funded Amount | [optional] 
**OldLoanUnpaidDiscountAmount** | **double** | Gets or sets the value of OldLoanUnpaidAmount accounted for by the Discount Amount | [optional] 
**NewLoanIncreaseAmount** | **double** | Gets or sets the value by which the new loan will increase the Original Amount to be repaid by the customer | [optional] 
**NewLoanIncreaseFundedAmount** | **double** | Gets or sets the value of NewLoanIncreaseAmount accounted for by the Funded Amount | [optional] 
**NewLoanIncreaseDiscount** | **double** | Gets or sets the new loan&#39;s discount rate | [optional] 
**NewLoanIncreaseDiscountAmount** | **double** | Gets or sets the value of NewLoanIncreaseAmount accounted for by the Discount Amount | [optional] 
**ConsolidatedLoanOriginalAmount** | **double** | Gets or sets the consolidated loan&#39;s Original Amount, the total amount due to be repaid on maturity | [optional] 
**ConsolidatedLoanFundedAmount** | **double** | Gets or sets the consolidated loan&#39;s Funded Amount, the total amount loaned to the customer | [optional] 
**ConsolidatedLoanDiscount** | **double** | Gets or sets the consolidated loan&#39;s discount rate | [optional] 
**ConsolidatedLoanDiscountAmount** | **double** | Gets or sets the discount fee associated with the consolidated loan | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

