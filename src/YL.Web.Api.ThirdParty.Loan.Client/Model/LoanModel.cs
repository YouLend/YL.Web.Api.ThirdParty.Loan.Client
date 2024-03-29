/* 
 * Third Party Loan API
 *
 * Through this API you can can retrieve loan data
 *
 * The version of the OpenAPI document: v1.0
 * Contact: mark.ufland@youlend.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = YL.Web.Api.ThirdParty.Loan.Client.Client.OpenAPIDateConverter;

namespace YL.Web.Api.ThirdParty.Loan.Client.Model
{
    /// <summary>
    /// A model representing the details of an individual loan
    /// </summary>
    [DataContract]
    public partial class LoanModel :  IEquatable<LoanModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanModel" /> class.
        /// </summary>
        /// <param name="autoRepaymentSweep">Gets or sets a value indicating whether an Auto Repayment Sweep is to be used - this feature automatically directs a chosen proportion, the Sweep, of transaction income towards repaying the loan.</param>
        /// <param name="borrowerId">Gets or sets the Borrower ID.</param>
        /// <param name="borrowerName">Gets or sets the Borrower Name.</param>
        /// <param name="creditRating">Gets or sets the Credit Rating.</param>
        /// <param name="currencyISOCode">Gets or sets the Currency ISO Code.</param>
        /// <param name="currentAmount">Gets or sets the Current Amount, the amount yet to be repaid.</param>
        /// <param name="currentServiceChargeRate">Gets or sets the Current Service Charge Rate.</param>
        /// <param name="defaultDetails">defaultDetails.</param>
        /// <param name="discount">Gets or sets the loan&#39;s discount rate.</param>
        /// <param name="id">Gets or sets the loan&#39;s unique identifier.</param>
        /// <param name="lenderId">Gets or sets the lender&#39;s unique identifier.</param>
        /// <param name="lenderName">Gets or sets the lender&#39;s full name.</param>
        /// <param name="maturityDate">Gets or sets the date on which the loan is due to mature, and by which it should be fully repaid.</param>
        /// <param name="originalAmount">Gets or sets the Original Amount, the total amount due to be repaid on maturity.</param>
        /// <param name="originalProjectedAnnualisedReturn">Gets or sets the Original Projected Annualised Return.</param>
        /// <param name="originalServiceChargeRate">Gets or sets the Original Service Charge Rate.</param>
        /// <param name="projectedRepaymentDate">Gets or sets the Projected Repayment Date.</param>
        /// <param name="securityAndGuarantees">Gets or sets a value indicating whether the Security and Guarantees are in place.</param>
        /// <param name="loanType">Gets or sets the Loan Type - \&quot;Initial\&quot;, \&quot;Refinanced\&quot; or \&quot;Renewal\&quot;.</param>
        /// <param name="status">Gets or sets the loan&#39;s Status - \&quot;Deleted\&quot;, \&quot;Funded\&quot;, \&quot;Funded (Pending Settlement)\&quot;, \&quot;Refinanced\&quot;, \&quot;Repaid\&quot;, \&quot;Written Off\&quot;.</param>
        /// <param name="sweep">Gets or sets the Sweep, the decimal out of 100 representing the proportion of transaction income to be used to repay the loan.</param>
        /// <param name="useOfProceeds">Gets or sets the Use Of Proceeds, i.e. to what end the loaned funds will be used.</param>
        /// <param name="loanNumber">Gets or sets the Loan Number, an ordinal value indicating which of a customer&#39;s loans is here detailed.</param>
        /// <param name="refinancingDetails">refinancingDetails.</param>
        /// <param name="earlyRenewalDetails">earlyRenewalDetails.</param>
        /// <param name="fundingDetails">fundingDetails.</param>
        /// <param name="writeOffDetails">writeOffDetails.</param>
        /// <param name="owners">Gets or sets a collection detailing the loan&#39;s Owners YL.Web.Api.ThirdParty.Loan.Models.LoanOwnerModel.</param>
        /// <param name="thirdPartyReferences">Gets or sets the loan&#39;s Third Party References YL.Web.Api.ThirdParty.Loan.Models.ThirdPartyReferenceModel.</param>
        /// <param name="documents">Gets or sets the Documents YL.Web.Api.ThirdParty.Loan.Models.LoanDocumentModel supporting the loan application.</param>
        public LoanModel(bool autoRepaymentSweep = default(bool), Guid borrowerId = default(Guid), string borrowerName = default(string), string creditRating = default(string), string currencyISOCode = default(string), double currentAmount = default(double), double currentServiceChargeRate = default(double), DefaultDetailsModel defaultDetails = default(DefaultDetailsModel), double discount = default(double), Guid id = default(Guid), Guid lenderId = default(Guid), string lenderName = default(string), DateTime maturityDate = default(DateTime), double originalAmount = default(double), double originalProjectedAnnualisedReturn = default(double), double originalServiceChargeRate = default(double), DateTime projectedRepaymentDate = default(DateTime), bool securityAndGuarantees = default(bool), string loanType = default(string), string status = default(string), double sweep = default(double), string useOfProceeds = default(string), int loanNumber = default(int), LoanRefinancingDetailsModel refinancingDetails = default(LoanRefinancingDetailsModel), EarlyRenewalDetailsModel earlyRenewalDetails = default(EarlyRenewalDetailsModel), LoanFundingDetailsModel fundingDetails = default(LoanFundingDetailsModel), LoanWriteOffDetailsModel writeOffDetails = default(LoanWriteOffDetailsModel), List<LoanOwnerModel> owners = default(List<LoanOwnerModel>), List<ThirdPartyReferenceModel> thirdPartyReferences = default(List<ThirdPartyReferenceModel>), List<LoanDocumentModel> documents = default(List<LoanDocumentModel>))
        {
            this.AutoRepaymentSweep = autoRepaymentSweep;
            this.BorrowerId = borrowerId;
            this.BorrowerName = borrowerName;
            this.CreditRating = creditRating;
            this.CurrencyISOCode = currencyISOCode;
            this.CurrentAmount = currentAmount;
            this.CurrentServiceChargeRate = currentServiceChargeRate;
            this.DefaultDetails = defaultDetails;
            this.Discount = discount;
            this.Id = id;
            this.LenderId = lenderId;
            this.LenderName = lenderName;
            this.MaturityDate = maturityDate;
            this.OriginalAmount = originalAmount;
            this.OriginalProjectedAnnualisedReturn = originalProjectedAnnualisedReturn;
            this.OriginalServiceChargeRate = originalServiceChargeRate;
            this.ProjectedRepaymentDate = projectedRepaymentDate;
            this.SecurityAndGuarantees = securityAndGuarantees;
            this.LoanType = loanType;
            this.Status = status;
            this.Sweep = sweep;
            this.UseOfProceeds = useOfProceeds;
            this.LoanNumber = loanNumber;
            this.RefinancingDetails = refinancingDetails;
            this.EarlyRenewalDetails = earlyRenewalDetails;
            this.FundingDetails = fundingDetails;
            this.WriteOffDetails = writeOffDetails;
            this.Owners = owners;
            this.ThirdPartyReferences = thirdPartyReferences;
            this.Documents = documents;
        }
        
        /// <summary>
        /// Gets or sets a value indicating whether an Auto Repayment Sweep is to be used - this feature automatically directs a chosen proportion, the Sweep, of transaction income towards repaying the loan
        /// </summary>
        /// <value>Gets or sets a value indicating whether an Auto Repayment Sweep is to be used - this feature automatically directs a chosen proportion, the Sweep, of transaction income towards repaying the loan</value>
        [DataMember(Name="autoRepaymentSweep", EmitDefaultValue=false)]
        public bool AutoRepaymentSweep { get; set; }

        /// <summary>
        /// Gets or sets the Borrower ID
        /// </summary>
        /// <value>Gets or sets the Borrower ID</value>
        [DataMember(Name="borrowerId", EmitDefaultValue=false)]
        public Guid BorrowerId { get; set; }

        /// <summary>
        /// Gets or sets the Borrower Name
        /// </summary>
        /// <value>Gets or sets the Borrower Name</value>
        [DataMember(Name="borrowerName", EmitDefaultValue=false)]
        public string BorrowerName { get; set; }

        /// <summary>
        /// Gets or sets the Credit Rating
        /// </summary>
        /// <value>Gets or sets the Credit Rating</value>
        [DataMember(Name="creditRating", EmitDefaultValue=false)]
        public string CreditRating { get; set; }

        /// <summary>
        /// Gets or sets the Currency ISO Code
        /// </summary>
        /// <value>Gets or sets the Currency ISO Code</value>
        [DataMember(Name="currencyISOCode", EmitDefaultValue=false)]
        public string CurrencyISOCode { get; set; }

        /// <summary>
        /// Gets or sets the Current Amount, the amount yet to be repaid
        /// </summary>
        /// <value>Gets or sets the Current Amount, the amount yet to be repaid</value>
        [DataMember(Name="currentAmount", EmitDefaultValue=false)]
        public double CurrentAmount { get; set; }

        /// <summary>
        /// Gets or sets the Current Service Charge Rate
        /// </summary>
        /// <value>Gets or sets the Current Service Charge Rate</value>
        [DataMember(Name="currentServiceChargeRate", EmitDefaultValue=false)]
        public double CurrentServiceChargeRate { get; set; }

        /// <summary>
        /// Gets or Sets DefaultDetails
        /// </summary>
        [DataMember(Name="defaultDetails", EmitDefaultValue=false)]
        public DefaultDetailsModel DefaultDetails { get; set; }

        /// <summary>
        /// Gets or sets the loan&#39;s discount rate
        /// </summary>
        /// <value>Gets or sets the loan&#39;s discount rate</value>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public double Discount { get; set; }

        /// <summary>
        /// Gets or sets the loan&#39;s unique identifier
        /// </summary>
        /// <value>Gets or sets the loan&#39;s unique identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the lender&#39;s unique identifier
        /// </summary>
        /// <value>Gets or sets the lender&#39;s unique identifier</value>
        [DataMember(Name="lenderId", EmitDefaultValue=false)]
        public Guid LenderId { get; set; }

        /// <summary>
        /// Gets or sets the lender&#39;s full name
        /// </summary>
        /// <value>Gets or sets the lender&#39;s full name</value>
        [DataMember(Name="lenderName", EmitDefaultValue=false)]
        public string LenderName { get; set; }

        /// <summary>
        /// Gets or sets the date on which the loan is due to mature, and by which it should be fully repaid
        /// </summary>
        /// <value>Gets or sets the date on which the loan is due to mature, and by which it should be fully repaid</value>
        [DataMember(Name="maturityDate", EmitDefaultValue=false)]
        public DateTime MaturityDate { get; set; }

        /// <summary>
        /// Gets or sets the Original Amount, the total amount due to be repaid on maturity
        /// </summary>
        /// <value>Gets or sets the Original Amount, the total amount due to be repaid on maturity</value>
        [DataMember(Name="originalAmount", EmitDefaultValue=false)]
        public double OriginalAmount { get; set; }

        /// <summary>
        /// Gets or sets the Original Projected Annualised Return
        /// </summary>
        /// <value>Gets or sets the Original Projected Annualised Return</value>
        [DataMember(Name="originalProjectedAnnualisedReturn", EmitDefaultValue=false)]
        public double OriginalProjectedAnnualisedReturn { get; set; }

        /// <summary>
        /// Gets or sets the Original Service Charge Rate
        /// </summary>
        /// <value>Gets or sets the Original Service Charge Rate</value>
        [DataMember(Name="originalServiceChargeRate", EmitDefaultValue=false)]
        public double OriginalServiceChargeRate { get; set; }

        /// <summary>
        /// Gets or sets the Projected Repayment Date
        /// </summary>
        /// <value>Gets or sets the Projected Repayment Date</value>
        [DataMember(Name="projectedRepaymentDate", EmitDefaultValue=false)]
        public DateTime ProjectedRepaymentDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Security and Guarantees are in place
        /// </summary>
        /// <value>Gets or sets a value indicating whether the Security and Guarantees are in place</value>
        [DataMember(Name="securityAndGuarantees", EmitDefaultValue=false)]
        public bool SecurityAndGuarantees { get; set; }

        /// <summary>
        /// Gets or sets the Loan Type - \&quot;Initial\&quot;, \&quot;Refinanced\&quot; or \&quot;Renewal\&quot;
        /// </summary>
        /// <value>Gets or sets the Loan Type - \&quot;Initial\&quot;, \&quot;Refinanced\&quot; or \&quot;Renewal\&quot;</value>
        [DataMember(Name="loanType", EmitDefaultValue=false)]
        public string LoanType { get; set; }

        /// <summary>
        /// Gets or sets the loan&#39;s Status - \&quot;Deleted\&quot;, \&quot;Funded\&quot;, \&quot;Funded (Pending Settlement)\&quot;, \&quot;Refinanced\&quot;, \&quot;Repaid\&quot;, \&quot;Written Off\&quot;
        /// </summary>
        /// <value>Gets or sets the loan&#39;s Status - \&quot;Deleted\&quot;, \&quot;Funded\&quot;, \&quot;Funded (Pending Settlement)\&quot;, \&quot;Refinanced\&quot;, \&quot;Repaid\&quot;, \&quot;Written Off\&quot;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the Sweep, the decimal out of 100 representing the proportion of transaction income to be used to repay the loan
        /// </summary>
        /// <value>Gets or sets the Sweep, the decimal out of 100 representing the proportion of transaction income to be used to repay the loan</value>
        [DataMember(Name="sweep", EmitDefaultValue=false)]
        public double Sweep { get; set; }

        /// <summary>
        /// Gets or sets the Use Of Proceeds, i.e. to what end the loaned funds will be used
        /// </summary>
        /// <value>Gets or sets the Use Of Proceeds, i.e. to what end the loaned funds will be used</value>
        [DataMember(Name="useOfProceeds", EmitDefaultValue=false)]
        public string UseOfProceeds { get; set; }

        /// <summary>
        /// Gets or sets the Loan Number, an ordinal value indicating which of a customer&#39;s loans is here detailed
        /// </summary>
        /// <value>Gets or sets the Loan Number, an ordinal value indicating which of a customer&#39;s loans is here detailed</value>
        [DataMember(Name="loanNumber", EmitDefaultValue=false)]
        public int LoanNumber { get; set; }

        /// <summary>
        /// Gets or Sets RefinancingDetails
        /// </summary>
        [DataMember(Name="refinancingDetails", EmitDefaultValue=false)]
        public LoanRefinancingDetailsModel RefinancingDetails { get; set; }

        /// <summary>
        /// Gets or Sets EarlyRenewalDetails
        /// </summary>
        [DataMember(Name="earlyRenewalDetails", EmitDefaultValue=false)]
        public EarlyRenewalDetailsModel EarlyRenewalDetails { get; set; }

        /// <summary>
        /// Gets or Sets FundingDetails
        /// </summary>
        [DataMember(Name="fundingDetails", EmitDefaultValue=false)]
        public LoanFundingDetailsModel FundingDetails { get; set; }

        /// <summary>
        /// Gets or Sets WriteOffDetails
        /// </summary>
        [DataMember(Name="writeOffDetails", EmitDefaultValue=false)]
        public LoanWriteOffDetailsModel WriteOffDetails { get; set; }

        /// <summary>
        /// Gets or sets a collection detailing the loan&#39;s Owners YL.Web.Api.ThirdParty.Loan.Models.LoanOwnerModel
        /// </summary>
        /// <value>Gets or sets a collection detailing the loan&#39;s Owners YL.Web.Api.ThirdParty.Loan.Models.LoanOwnerModel</value>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public List<LoanOwnerModel> Owners { get; set; }

        /// <summary>
        /// Gets or sets the loan&#39;s Third Party References YL.Web.Api.ThirdParty.Loan.Models.ThirdPartyReferenceModel
        /// </summary>
        /// <value>Gets or sets the loan&#39;s Third Party References YL.Web.Api.ThirdParty.Loan.Models.ThirdPartyReferenceModel</value>
        [DataMember(Name="thirdPartyReferences", EmitDefaultValue=false)]
        public List<ThirdPartyReferenceModel> ThirdPartyReferences { get; set; }

        /// <summary>
        /// Gets or sets the Documents YL.Web.Api.ThirdParty.Loan.Models.LoanDocumentModel supporting the loan application
        /// </summary>
        /// <value>Gets or sets the Documents YL.Web.Api.ThirdParty.Loan.Models.LoanDocumentModel supporting the loan application</value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<LoanDocumentModel> Documents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanModel {\n");
            sb.Append("  AutoRepaymentSweep: ").Append(AutoRepaymentSweep).Append("\n");
            sb.Append("  BorrowerId: ").Append(BorrowerId).Append("\n");
            sb.Append("  BorrowerName: ").Append(BorrowerName).Append("\n");
            sb.Append("  CreditRating: ").Append(CreditRating).Append("\n");
            sb.Append("  CurrencyISOCode: ").Append(CurrencyISOCode).Append("\n");
            sb.Append("  CurrentAmount: ").Append(CurrentAmount).Append("\n");
            sb.Append("  CurrentServiceChargeRate: ").Append(CurrentServiceChargeRate).Append("\n");
            sb.Append("  DefaultDetails: ").Append(DefaultDetails).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LenderId: ").Append(LenderId).Append("\n");
            sb.Append("  LenderName: ").Append(LenderName).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  OriginalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  OriginalProjectedAnnualisedReturn: ").Append(OriginalProjectedAnnualisedReturn).Append("\n");
            sb.Append("  OriginalServiceChargeRate: ").Append(OriginalServiceChargeRate).Append("\n");
            sb.Append("  ProjectedRepaymentDate: ").Append(ProjectedRepaymentDate).Append("\n");
            sb.Append("  SecurityAndGuarantees: ").Append(SecurityAndGuarantees).Append("\n");
            sb.Append("  LoanType: ").Append(LoanType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Sweep: ").Append(Sweep).Append("\n");
            sb.Append("  UseOfProceeds: ").Append(UseOfProceeds).Append("\n");
            sb.Append("  LoanNumber: ").Append(LoanNumber).Append("\n");
            sb.Append("  RefinancingDetails: ").Append(RefinancingDetails).Append("\n");
            sb.Append("  EarlyRenewalDetails: ").Append(EarlyRenewalDetails).Append("\n");
            sb.Append("  FundingDetails: ").Append(FundingDetails).Append("\n");
            sb.Append("  WriteOffDetails: ").Append(WriteOffDetails).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  ThirdPartyReferences: ").Append(ThirdPartyReferences).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoanModel);
        }

        /// <summary>
        /// Returns true if LoanModel instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoRepaymentSweep == input.AutoRepaymentSweep ||
                    this.AutoRepaymentSweep.Equals(input.AutoRepaymentSweep)
                ) && 
                (
                    this.BorrowerId == input.BorrowerId ||
                    (this.BorrowerId != null &&
                    this.BorrowerId.Equals(input.BorrowerId))
                ) && 
                (
                    this.BorrowerName == input.BorrowerName ||
                    (this.BorrowerName != null &&
                    this.BorrowerName.Equals(input.BorrowerName))
                ) && 
                (
                    this.CreditRating == input.CreditRating ||
                    (this.CreditRating != null &&
                    this.CreditRating.Equals(input.CreditRating))
                ) && 
                (
                    this.CurrencyISOCode == input.CurrencyISOCode ||
                    (this.CurrencyISOCode != null &&
                    this.CurrencyISOCode.Equals(input.CurrencyISOCode))
                ) && 
                (
                    this.CurrentAmount == input.CurrentAmount ||
                    this.CurrentAmount.Equals(input.CurrentAmount)
                ) && 
                (
                    this.CurrentServiceChargeRate == input.CurrentServiceChargeRate ||
                    this.CurrentServiceChargeRate.Equals(input.CurrentServiceChargeRate)
                ) && 
                (
                    this.DefaultDetails == input.DefaultDetails ||
                    (this.DefaultDetails != null &&
                    this.DefaultDetails.Equals(input.DefaultDetails))
                ) && 
                (
                    this.Discount == input.Discount ||
                    this.Discount.Equals(input.Discount)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LenderId == input.LenderId ||
                    (this.LenderId != null &&
                    this.LenderId.Equals(input.LenderId))
                ) && 
                (
                    this.LenderName == input.LenderName ||
                    (this.LenderName != null &&
                    this.LenderName.Equals(input.LenderName))
                ) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && 
                (
                    this.OriginalAmount == input.OriginalAmount ||
                    this.OriginalAmount.Equals(input.OriginalAmount)
                ) && 
                (
                    this.OriginalProjectedAnnualisedReturn == input.OriginalProjectedAnnualisedReturn ||
                    this.OriginalProjectedAnnualisedReturn.Equals(input.OriginalProjectedAnnualisedReturn)
                ) && 
                (
                    this.OriginalServiceChargeRate == input.OriginalServiceChargeRate ||
                    this.OriginalServiceChargeRate.Equals(input.OriginalServiceChargeRate)
                ) && 
                (
                    this.ProjectedRepaymentDate == input.ProjectedRepaymentDate ||
                    (this.ProjectedRepaymentDate != null &&
                    this.ProjectedRepaymentDate.Equals(input.ProjectedRepaymentDate))
                ) && 
                (
                    this.SecurityAndGuarantees == input.SecurityAndGuarantees ||
                    this.SecurityAndGuarantees.Equals(input.SecurityAndGuarantees)
                ) && 
                (
                    this.LoanType == input.LoanType ||
                    (this.LoanType != null &&
                    this.LoanType.Equals(input.LoanType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Sweep == input.Sweep ||
                    this.Sweep.Equals(input.Sweep)
                ) && 
                (
                    this.UseOfProceeds == input.UseOfProceeds ||
                    (this.UseOfProceeds != null &&
                    this.UseOfProceeds.Equals(input.UseOfProceeds))
                ) && 
                (
                    this.LoanNumber == input.LoanNumber ||
                    this.LoanNumber.Equals(input.LoanNumber)
                ) && 
                (
                    this.RefinancingDetails == input.RefinancingDetails ||
                    (this.RefinancingDetails != null &&
                    this.RefinancingDetails.Equals(input.RefinancingDetails))
                ) && 
                (
                    this.EarlyRenewalDetails == input.EarlyRenewalDetails ||
                    (this.EarlyRenewalDetails != null &&
                    this.EarlyRenewalDetails.Equals(input.EarlyRenewalDetails))
                ) && 
                (
                    this.FundingDetails == input.FundingDetails ||
                    (this.FundingDetails != null &&
                    this.FundingDetails.Equals(input.FundingDetails))
                ) && 
                (
                    this.WriteOffDetails == input.WriteOffDetails ||
                    (this.WriteOffDetails != null &&
                    this.WriteOffDetails.Equals(input.WriteOffDetails))
                ) && 
                (
                    this.Owners == input.Owners ||
                    this.Owners != null &&
                    input.Owners != null &&
                    this.Owners.SequenceEqual(input.Owners)
                ) && 
                (
                    this.ThirdPartyReferences == input.ThirdPartyReferences ||
                    this.ThirdPartyReferences != null &&
                    input.ThirdPartyReferences != null &&
                    this.ThirdPartyReferences.SequenceEqual(input.ThirdPartyReferences)
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.AutoRepaymentSweep.GetHashCode();
                if (this.BorrowerId != null)
                    hashCode = hashCode * 59 + this.BorrowerId.GetHashCode();
                if (this.BorrowerName != null)
                    hashCode = hashCode * 59 + this.BorrowerName.GetHashCode();
                if (this.CreditRating != null)
                    hashCode = hashCode * 59 + this.CreditRating.GetHashCode();
                if (this.CurrencyISOCode != null)
                    hashCode = hashCode * 59 + this.CurrencyISOCode.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentAmount.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentServiceChargeRate.GetHashCode();
                if (this.DefaultDetails != null)
                    hashCode = hashCode * 59 + this.DefaultDetails.GetHashCode();
                hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LenderId != null)
                    hashCode = hashCode * 59 + this.LenderId.GetHashCode();
                if (this.LenderName != null)
                    hashCode = hashCode * 59 + this.LenderName.GetHashCode();
                if (this.MaturityDate != null)
                    hashCode = hashCode * 59 + this.MaturityDate.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalAmount.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalProjectedAnnualisedReturn.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalServiceChargeRate.GetHashCode();
                if (this.ProjectedRepaymentDate != null)
                    hashCode = hashCode * 59 + this.ProjectedRepaymentDate.GetHashCode();
                hashCode = hashCode * 59 + this.SecurityAndGuarantees.GetHashCode();
                if (this.LoanType != null)
                    hashCode = hashCode * 59 + this.LoanType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Sweep.GetHashCode();
                if (this.UseOfProceeds != null)
                    hashCode = hashCode * 59 + this.UseOfProceeds.GetHashCode();
                hashCode = hashCode * 59 + this.LoanNumber.GetHashCode();
                if (this.RefinancingDetails != null)
                    hashCode = hashCode * 59 + this.RefinancingDetails.GetHashCode();
                if (this.EarlyRenewalDetails != null)
                    hashCode = hashCode * 59 + this.EarlyRenewalDetails.GetHashCode();
                if (this.FundingDetails != null)
                    hashCode = hashCode * 59 + this.FundingDetails.GetHashCode();
                if (this.WriteOffDetails != null)
                    hashCode = hashCode * 59 + this.WriteOffDetails.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.ThirdPartyReferences != null)
                    hashCode = hashCode * 59 + this.ThirdPartyReferences.GetHashCode();
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
