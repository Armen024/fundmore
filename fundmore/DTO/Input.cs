using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundmore.DTO
{

  public class Input
  {
    public string id { get; set; }
    public int ezidoxApplicationId { get; set; }
    public string tenantId { get; set; }
    public object filogixDealId { get; set; }
    public object externalDealId { get; set; }
    public string createdBy { get; set; }
    public object archivedByUserId { get; set; }
    public string name { get; set; }
    public object brokerNotes { get; set; }
    public object brokerNotesDate { get; set; }
    public string applicationNotes { get; set; }
    public object code { get; set; }
    public object applicationDate { get; set; }
    public string status { get; set; }
    public object otherIncomeAmountTotal { get; set; }
    public object financialAssetsValueTotal { get; set; }
    public object financialLiabilitiesValueTotal { get; set; }
    public object financialLiabilitiesBalanceTotal { get; set; }
    public object financialLiabilitiesMonthlyTotal { get; set; }
    public object downPaymentTotal { get; set; }
    public object monthlyIncome { get; set; }
    public string currentStage { get; set; }
    public string previousStage { get; set; }
    public DateTime docsDueDate { get; set; }
    public object declineComment { get; set; }
    public object declineReasonId { get; set; }
    public object declineDate { get; set; }
    public string fundId { get; set; }
    public string purpose { get; set; }
    public string source { get; set; }
    public bool archived { get; set; }
    public object productId { get; set; }
    public object dealType { get; set; }
    public object clonedApplicationId { get; set; }
    public string mortgageClassification { get; set; }
    public bool locked { get; set; }
    public object lineOfBusinessId { get; set; }
    public object customFields { get; set; }
    public object[] warnings { get; set; }
    public object metadata { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public object[] ApplicationVerifications { get; set; }
    public Otherincome[] OtherIncomes { get; set; }
    public Downpayment[] DownPayments { get; set; }
    public Mortgage[] Mortgages { get; set; }
    public object[] Fees { get; set; }
    public Applicationassigneduser[] ApplicationAssignedUsers { get; set; }
    public object[] ApplicationDolphinIntegrations { get; set; }
    public object[] ConstructionSchedules { get; set; }
    public Applicationstatus ApplicationStatus { get; set; }
    public Applicationadvancedproduct1[] ApplicationAdvancedProducts { get; set; }
    public object eqMapsPostbackHistory { get; set; }
    public Applicant[] applicants { get; set; }
    public Financialliability[] FinancialLiabilities { get; set; }
    public Property1[] Properties { get; set; }
    public Financialasset[] FinancialAssets { get; set; }
    public Uiabstractpermissions uiAbstractPermissions { get; set; }
  }

  public class Applicationstatus
  {
    public string applicationId { get; set; }
    public string tenantId { get; set; }
    public string status { get; set; }
    public string underwriterId { get; set; }
    public object lenderNotes { get; set; }
    public Content content { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
  }

  public class Content
  {
    public object documentId { get; set; }
  }

  public class Uiabstractpermissions
  {
    public bool canChat { get; set; }
    public bool canFund { get; set; }
    public bool canDecline { get; set; }
    public Canmovestage[] canMoveStage { get; set; }
    public bool canBypassTasks { get; set; }
    public bool canRevertDecision { get; set; }
    public bool canUpdateBrokerNotes { get; set; }
    public bool canEdit { get; set; }
    public Candeleteapplication[] canDeleteApplication { get; set; }
    public bool canArchiveApplication { get; set; }
    public bool canEditNetRate { get; set; }
    public bool canEditPrepaymentPeriod { get; set; }
    public bool canIncludeInAPR { get; set; }
    public bool canCompleteTasks { get; set; }
    public bool canCompleteAssignedTasks { get; set; }
    public bool canEditTasks { get; set; }
    public bool canEditAssignedTasks { get; set; }
    public bool canCreateTasks { get; set; }
    public Canassignuser[] canAssignUsers { get; set; }
    public bool canAssignBroker { get; set; }
    public bool canAddApplicant { get; set; }
    public bool canUpdateApplicant { get; set; }
    public bool canDeleteApplicant { get; set; }
  }

  public class Canmovestage
  {
    public string[] from { get; set; }
    public string[] to { get; set; }
  }

  public class Candeleteapplication
  {
    public string[] stage { get; set; }
  }

  public class Canassignuser
  {
    public string id { get; set; }
    public string name { get; set; }
  }

  public class Otherincome
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public bool isCurrent { get; set; }
    public string applicationId { get; set; }
    public string type { get; set; }
    public string description { get; set; }
    public string period { get; set; }
    public object incomePaymentFrequency { get; set; }
    public int amount { get; set; }
    public DateTime startDate { get; set; }
    public object endDate { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public Applicantotherincome[] ApplicantOtherIncomes { get; set; }
  }

  public class Applicantotherincome
  {
    public string applicantId { get; set; }
    public string otherIncomeId { get; set; }
  }

  public class Downpayment
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string source { get; set; }
    public string description { get; set; }
    public int amount { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public string financialAssetId { get; set; }
  }

  public class Mortgage
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string propertyId { get; set; }
    public string loanNumber { get; set; }
    public Expandedloannumber expandedLoanNumber { get; set; }
    public string lender { get; set; }
    public object productName { get; set; }
    public string loanType { get; set; }
    public string purpose { get; set; }
    public string mortgageType { get; set; }
    public DateTime closingDate { get; set; }
    public DateTime fundingDate { get; set; }
    public string paymentFrequency { get; set; }
    public int purchaseValue { get; set; }
    public int insurancePremium { get; set; }
    public object insuranceAmount { get; set; }
    public bool includePremiumInMortgage { get; set; }
    public object monthlyPayment { get; set; }
    public int totalMortgageAmount { get; set; }
    public int netRate { get; set; }
    public object originalNetRate { get; set; }
    public int termMonths { get; set; }
    public int amortizationMonths { get; set; }
    public string repaymentType { get; set; }
    public string type { get; set; }
    public string termType { get; set; }
    public string rateType { get; set; }
    public object maturityDate { get; set; }
    public object mortgageBalance { get; set; }
    public object payoutBalance { get; set; }
    public object insured { get; set; }
    public string insurer { get; set; }
    public string insuranceAccountNum { get; set; }
    public object mortgageNum { get; set; }
    public string prepaymentType { get; set; }
    public int prepaymentAmount { get; set; }
    public int prepaymentPenaltyPeriod { get; set; }
    public object isPrepaymentAmountInPayments { get; set; }
    public object balloonAmount { get; set; }
    public object dateOfAdvance { get; set; }
    public DateTime interestAdjustmentDate { get; set; }
    public object firstRegularPaymentDate { get; set; }
    public DateTime deadlineToAcceptDate { get; set; }
    public object pst { get; set; }
    public string compounding { get; set; }
    public bool close { get; set; }
    public object affiliationProgram { get; set; }
    public object cashBackAmt { get; set; }
    public object cashBackPercentage { get; set; }
    public object marketSubmission { get; set; }
    public object miFeeAmount { get; set; }
    public object miPremiumAmount { get; set; }
    public object miPremiumPst { get; set; }
    public object discount { get; set; }
    public object buyDownRate { get; set; }
    public object rateGuaranteeLength { get; set; }
    public object privilegePayment { get; set; }
    public object customFields { get; set; }
    public bool isEdge { get; set; }
    public int amountToBeAdvanced { get; set; }
    public float interestAdjustmentAmount { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public object[] ApplicantMortgages { get; set; }
    public Applicationadvancedproduct applicationAdvancedProduct { get; set; }
  }

  public class Expandedloannumber
  {
    public int number { get; set; }
    public string prefix { get; set; }
    public string suffix { get; set; }
  }

  public class Applicationadvancedproduct
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string mortgageId { get; set; }
    public string advancedProductId { get; set; }
    public Advancedproductsnapshot advancedProductSnapshot { get; set; }
    public object metadata { get; set; }
    public bool isCurrentlyApplied { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
  }

  public class Advancedproductsnapshot
  {
    public string id { get; set; }
    public string name { get; set; }
    public object notes { get; set; }
    public bool isActive { get; set; }
    public string tenantId { get; set; }
    public DateTime createdAt { get; set; }
    public object deletedAt { get; set; }
    public string[] locations { get; set; }
    public DateTime updatedAt { get; set; }
    public object externalId { get; set; }
    public Parameters parameters { get; set; }
    public Ratematrix[] RateMatrices { get; set; }
    public Defaultvalue[] defaultValues { get; set; }
  }

  public class Parameters
  {
    public bool isEdge { get; set; }
  }

  public class Ratematrix
  {
    public string id { get; set; }
    public object notes { get; set; }
    public Credittier CreditTier { get; set; }
    public Condition[] conditions { get; set; }
    public string creditTierId { get; set; }
    public Ratematrixterm[] RateMatrixTerms { get; set; }
    public string advancedProductId { get; set; }
  }

  public class Credittier
  {
    public string id { get; set; }
    public bool isCustom { get; set; }
    public string tierName { get; set; }
    public object maximumCreditScore { get; set; }
    public object minimumCreditScore { get; set; }
  }

  public class Condition
  {
    public string id { get; set; }
    public string field { get; set; }
    public Comparison[] comparisons { get; set; }
  }

  public class Comparison
  {
    public string id { get; set; }
    public string value { get; set; }
    public string _operator { get; set; }
    public Condition1[] conditions { get; set; }
  }

  public class Condition1
  {
    public string field { get; set; }
    public string value { get; set; }
  }

  public class Ratematrixterm
  {
    public string id { get; set; }
    public Duration duration { get; set; }
    public string tenantId { get; set; }
    public Fixedrate FixedRate { get; set; }
    public DateTime createdAt { get; set; }
    public object deletedAt { get; set; }
    public DateTime updatedAt { get; set; }
    public string fixedRateId { get; set; }
    public Variablerate VariableRate { get; set; }
    public string rateMatrixId { get; set; }
    public string variableRateId { get; set; }
    public int variableRateModifier { get; set; }
  }

  public class Duration
  {
    public int[] durations { get; set; }
  }

  public class Fixedrate
  {
    public string id { get; set; }
    public string name { get; set; }
    public int value { get; set; }
    public bool isCustom { get; set; }
    public string tenantId { get; set; }
    public DateTime createdAt { get; set; }
    public object deletedAt { get; set; }
    public object updatedAt { get; set; }
  }

  public class Variablerate
  {
    public string id { get; set; }
    public string name { get; set; }
    public float value { get; set; }
    public bool isCustom { get; set; }
    public string tenantId { get; set; }
    public DateTime createdAt { get; set; }
    public object deletedAt { get; set; }
    public DateTime updatedAt { get; set; }
  }

  public class Defaultvalue
  {
    public string fieldName { get; set; }
    public string tableName { get; set; }
    public object defaultValue { get; set; }
  }

  public class Applicationassigneduser
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string userId { get; set; }
    public string roleId { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
  }

  public class Applicationadvancedproduct1
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string mortgageId { get; set; }
    public string advancedProductId { get; set; }
    public Advancedproductsnapshot1 advancedProductSnapshot { get; set; }
    public object metadata { get; set; }
    public bool isCurrentlyApplied { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
  }

  public class Advancedproductsnapshot1
  {
    public string id { get; set; }
    public string name { get; set; }
    public object notes { get; set; }
    public bool isActive { get; set; }
    public string tenantId { get; set; }
    public DateTime createdAt { get; set; }
    public object deletedAt { get; set; }
    public string[] locations { get; set; }
    public DateTime updatedAt { get; set; }
    public object externalId { get; set; }
    public Parameters1 parameters { get; set; }
    public Ratematrix1[] RateMatrices { get; set; }
    public Defaultvalue1[] defaultValues { get; set; }
  }

  public class Parameters1
  {
    public bool isEdge { get; set; }
  }

  public class Ratematrix1
  {
    public string id { get; set; }
    public object notes { get; set; }
    public Credittier1 CreditTier { get; set; }
    public Condition2[] conditions { get; set; }
    public string creditTierId { get; set; }
    public Ratematrixterm1[] RateMatrixTerms { get; set; }
    public string advancedProductId { get; set; }
  }

  public class Credittier1
  {
    public string id { get; set; }
    public bool isCustom { get; set; }
    public string tierName { get; set; }
    public object maximumCreditScore { get; set; }
    public object minimumCreditScore { get; set; }
  }

  public class Condition2
  {
    public string id { get; set; }
    public string field { get; set; }
    public Comparison1[] comparisons { get; set; }
  }

  public class Comparison1
  {
    public string id { get; set; }
    public string value { get; set; }
    public string _operator { get; set; }
    public Condition3[] conditions { get; set; }
  }

  public class Condition3
  {
    public string field { get; set; }
    public string value { get; set; }
  }

  public class Ratematrixterm1
  {
    public string id { get; set; }
    public Duration1 duration { get; set; }
    public string tenantId { get; set; }
    public Fixedrate1 FixedRate { get; set; }
    public DateTime createdAt { get; set; }
    public object deletedAt { get; set; }
    public DateTime? updatedAt { get; set; }
    public string fixedRateId { get; set; }
    public Variablerate1 VariableRate { get; set; }
    public string rateMatrixId { get; set; }
    public string variableRateId { get; set; }
    public int? variableRateModifier { get; set; }
  }

  public class Duration1
  {
    public int[] durations { get; set; }
  }

  public class Fixedrate1
  {
    public string id { get; set; }
    public string name { get; set; }
    public int value { get; set; }
    public bool isCustom { get; set; }
    public string tenantId { get; set; }
    public DateTime createdAt { get; set; }
    public object deletedAt { get; set; }
    public object updatedAt { get; set; }
  }

  public class Variablerate1
  {
    public string id { get; set; }
    public string name { get; set; }
    public float value { get; set; }
    public bool isCustom { get; set; }
    public string tenantId { get; set; }
    public DateTime createdAt { get; set; }
    public object deletedAt { get; set; }
    public DateTime? updatedAt { get; set; }
  }

  public class Defaultvalue1
  {
    public string fieldName { get; set; }
    public string tableName { get; set; }
    public object defaultValue { get; set; }
  }

  public class Applicant
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public bool isPrimary { get; set; }
    public int? templateSetId { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public string middleName { get; set; }
    public string workPhone { get; set; }
    public string cellPhone { get; set; }
    public object homePhone { get; set; }
    public object faxNumber { get; set; }
    public string email { get; set; }
    public string maritalStatus { get; set; }
    public DateTime? dateOfBirth { get; set; }
    public string placeOfBirth { get; set; }
    public string countryOfResidence { get; set; }
    public object registeredCountry { get; set; }
    public string nationality { get; set; }
    public int? dependents { get; set; }
    public string relationshipToPrimaryApplicant { get; set; }
    public object preferredContact { get; set; }
    public string sin { get; set; }
    public int? crScore { get; set; }
    public object crDescription { get; set; }
    public int? ezidoxStakeholderId { get; set; }
    public bool isUploader { get; set; }
    public bool? createDocumentRequest { get; set; }
    public string customerType { get; set; }
    public string brokerId { get; set; }
    public string brokerage { get; set; }
    public object lawyerId { get; set; }
    public object company { get; set; }
    public bool isFirstTimeHomeBuyer { get; set; }
    public string languagePreference { get; set; }
    public string salutation { get; set; }
    public string gender { get; set; }
    public object suffix { get; set; }
    public object citizenshipStatus { get; set; }
    public bool ficoScoreOverride { get; set; }
    public bool consentReceived { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object web { get; set; }
    public object deletedAt { get; set; }
    public Job[] Jobs { get; set; }
    public Applicantaddress[] ApplicantAddresses { get; set; }
    public object[] ApplicantCompanyDetails { get; set; }
    public object[] ApplicantCompanyDirectorDetails { get; set; }
  }

  public class Job
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicantId { get; set; }
    public object applicationId { get; set; }
    public bool isCurrent { get; set; }
    public string employerName { get; set; }
    public string employerAddress { get; set; }
    public string employerCountry { get; set; }
    public object bonusOvertimeCommissions { get; set; }
    public string employerEmailAddress { get; set; }
    public object businessType { get; set; }
    public int timeAtJobMonths { get; set; }
    public int timeAtIndustryMonths { get; set; }
    public string description { get; set; }
    public string occupation { get; set; }
    public string jobTitle { get; set; }
    public string employmentType { get; set; }
    public int annualIncome { get; set; }
    public string paymentType { get; set; }
    public string incomePaymentFrequency { get; set; }
    public string industrySector { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public string type { get; set; }
    public string phoneNumber { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
  }

  public class Applicantaddress
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicantId { get; set; }
    public object applicationId { get; set; }
    public string type { get; set; }
    public string address { get; set; }
    public string residentialType { get; set; }
    public string residentialStatus { get; set; }
    public string residentialStatusType { get; set; }
    public string timeAtResidence { get; set; }
    public int timeAtResidenceMonths { get; set; }
    public object unitNumber { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
  }

  public class Financialliability
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string source { get; set; }
    public object description { get; set; }
    public string liability { get; set; }
    public int? value { get; set; }
    public int? balance { get; set; }
    public int? monthlyPayment { get; set; }
    public object payoff { get; set; }
    public bool crHasWrittenOff { get; set; }
    public string crStatus { get; set; }
    public object payout { get; set; }
    public object close { get; set; }
    public object collectionAccount { get; set; }
    public object externalAccountId { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public Applicantfinancialliability[] ApplicantFinancialLiabilities { get; set; }
    public Financialliabilityrecordtype[] FinancialLiabilityRecordTypes { get; set; }
  }

  public class Applicantfinancialliability
  {
    public string id { get; set; }
    public string applicantId { get; set; }
    public string financialLiabilityId { get; set; }
  }

  public class Financialliabilityrecordtype
  {
    public string id { get; set; }
    public string type { get; set; }
    public object recordType { get; set; }
    public object reportedDate { get; set; }
  }

  public class Property1
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string propertyAddress { get; set; }
    public string legalDescription { get; set; }
    public string shortLegalDescription { get; set; }
    public string pid { get; set; }
    public string lot { get; set; }
    public object block { get; set; }
    public string plan { get; set; }
    public string zoningType { get; set; }
    public string propertyType { get; set; }
    public object concessionTownship { get; set; }
    public string occupancy { get; set; }
    public int yearBuilt { get; set; }
    public string heatingType { get; set; }
    public string livingSpace { get; set; }
    public string lotSize { get; set; }
    public string dwellingType { get; set; }
    public string dwellingStyle { get; set; }
    public string garageSize { get; set; }
    public string garageType { get; set; }
    public object taxationYear { get; set; }
    public string taxesPaidBy { get; set; }
    public bool isEnvironmentalHazard { get; set; }
    public int? purchasePrice { get; set; }
    public DateTime? purchaseDate { get; set; }
    public int estimatedValue { get; set; }
    public DateTime? estimatedValueDate { get; set; }
    public int heatingCost { get; set; }
    public int condoFees { get; set; }
    public int annualTaxes { get; set; }
    public object improvements { get; set; }
    public object valueOfImprovements { get; set; }
    public object totalExpenses { get; set; }
    public int rpeMonthlyRentalIncome { get; set; }
    public string rpeRentalOffsetOption { get; set; }
    public int rpeOffset { get; set; }
    public object rpeInsurance { get; set; }
    public object rpeHydro { get; set; }
    public object rpeManagementExpenses { get; set; }
    public object rpeRepairs { get; set; }
    public object rpeInterestCharges { get; set; }
    public object rpeGeneralExpenses { get; set; }
    public string type { get; set; }
    public string constructionType { get; set; }
    public string tenure { get; set; }
    public string waterType { get; set; }
    public int? noOfUnits { get; set; }
    public string sewageInfo { get; set; }
    public string foundationType { get; set; }
    public object nameOnTitle { get; set; }
    public Corroboration[] corroborations { get; set; }
    public bool isCollateralized { get; set; }
    public bool hasOtherSecurityConditions { get; set; }
    public object otherSecurityConditions { get; set; }
    public bool includeInCLTV { get; set; }
    public string locationTier { get; set; }
    public bool? isMlsListing { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public Propertyappraisal[] PropertyAppraisals { get; set; }
    public Mortgage1[] Mortgages { get; set; }
    public Propertyaddressexpanded propertyAddressExpanded { get; set; }
    public object[] PropertyOwners { get; set; }
    public object[] ApplicantProperties { get; set; }
  }

  public class Propertyaddressexpanded
  {
    public string id { get; set; }
    public string propertyId { get; set; }
    public string formattedAddress { get; set; }
    public object postalCodePrefix { get; set; }
    public string city { get; set; }
    public string province { get; set; }
    public string country { get; set; }
    public float lat { get; set; }
    public float lng { get; set; }
    public Rawgooglegeocoderesponse rawGoogleGeocodeResponse { get; set; }
    public string streetNumber { get; set; }
    public string streetName { get; set; }
    public object streetDirection { get; set; }
    public object streetType { get; set; }
    public string unit { get; set; }
    public string postalCode { get; set; }
  }

  public class Rawgooglegeocoderesponse
  {
    public string[] types { get; set; }
    public Geometry geometry { get; set; }
    public string place_id { get; set; }
    public string formatted_address { get; set; }
    public Address_Components[] address_components { get; set; }
    public Plus_Code plus_code { get; set; }
  }

  public class Geometry
  {
    public Bounds bounds { get; set; }
    public Location location { get; set; }
    public Viewport viewport { get; set; }
    public string location_type { get; set; }
  }

  public class Bounds
  {
    public Northeast northeast { get; set; }
    public Southwest southwest { get; set; }
  }

  public class Northeast
  {
    public float lat { get; set; }
    public float lng { get; set; }
  }

  public class Southwest
  {
    public float lat { get; set; }
    public float lng { get; set; }
  }

  public class Location
  {
    public float lat { get; set; }
    public float lng { get; set; }
  }

  public class Viewport
  {
    public Northeast1 northeast { get; set; }
    public Southwest1 southwest { get; set; }
  }

  public class Northeast1
  {
    public float lat { get; set; }
    public float lng { get; set; }
  }

  public class Southwest1
  {
    public float lat { get; set; }
    public float lng { get; set; }
  }

  public class Plus_Code
  {
    public string global_code { get; set; }
    public string compound_code { get; set; }
  }

  public class Address_Components
  {
    public string[] types { get; set; }
    public string long_name { get; set; }
    public string short_name { get; set; }
  }

  public class Corroboration
  {
    public string field { get; set; }
    public Value value { get; set; }
    public string source { get; set; }
    public DateTime addedAt { get; set; }
  }

  public class Value
  {
    public Foraddress forAddress { get; set; }
    public Propertydetails propertyDetails { get; set; }
    public Marketvaluation marketValuation { get; set; }
  }

  public class Foraddress
  {
    public string province { get; set; }
    public string postalCode { get; set; }
    public string streetName { get; set; }
    public string streetType { get; set; }
    public string municipality { get; set; }
    public string streetNumber { get; set; }
    public string optaAddressKey { get; set; }
  }

  public class Propertydetails
  {
    public string propertyType { get; set; }
    public Residentialbuilding residentialBuilding { get; set; }
    public Multiresidentialbuilding multiResidentialBuilding { get; set; }
  }

  public class Residentialbuilding
  {
    public int lotSize { get; set; }
    public string roofType { get; set; }
    public string waterType { get; set; }
    public int yearBuilt { get; set; }
    public string garageType { get; set; }
    public string sewageType { get; set; }
    public string storeyCount { get; set; }
    public string kitchenCount { get; set; }
    public string plumbingType { get; set; }
    public string bathroomCount { get; set; }
    public int squareFootage { get; set; }
    public string foundationType { get; set; }
    public string exteriorWallType { get; set; }
    public string finishedBasement { get; set; }
    public int numberOfBedrooms { get; set; }
    public string swimmingPoolType { get; set; }
    public string garageNumberOfCars { get; set; }
    public string outbuildingPresent { get; set; }
    public string primaryHeatingType { get; set; }
    public string commercialIndicator { get; set; }
    public string auxiliaryHeatingType { get; set; }
    public string architecturalStyleType { get; set; }
  }

  public class Multiresidentialbuilding
  {
    public Unitfeatures unitFeatures { get; set; }
    public Buildingfeatures buildingFeatures { get; set; }
  }

  public class Unitfeatures
  {
    public string floorLevel { get; set; }
    public int numberOfDens { get; set; }
    public int totalFloorArea { get; set; }
    public int numberOfBedrooms { get; set; }
    public string numberOfKitchens { get; set; }
    public string numberOfBathrooms { get; set; }
    public string garageNumberOfCars { get; set; }
    public string commercialIndicator { get; set; }
  }

  public class Buildingfeatures
  {
    public string waterType { get; set; }
    public int yearBuilt { get; set; }
    public string sewageType { get; set; }
    public string heatingType { get; set; }
    public string parkingType { get; set; }
    public string roofSurface { get; set; }
    public string plumbingType { get; set; }
    public int numberOfStoreys { get; set; }
    public string exteriorWallType { get; set; }
    public string multiResidentialStyleType { get; set; }
  }

  public class Marketvaluation
  {
    public string date { get; set; }
    public int value { get; set; }
    public string confidenceRating { get; set; }
  }

  public class Propertyappraisal
  {
    public string id { get; set; }
    public string propertyId { get; set; }
    public int appraisedValue { get; set; }
    public string appraiser { get; set; }
    public DateTime appraisalDate { get; set; }
    public object additionalData { get; set; }
    public string appraisalType { get; set; }
    public object appraisalNotes { get; set; }
    public bool isPropertyValue { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
  }

  public class Mortgage1
  {
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string propertyId { get; set; }
    public string loanNumber { get; set; }
    public Expandedloannumber1 expandedLoanNumber { get; set; }
    public string lender { get; set; }
    public object productName { get; set; }
    public string loanType { get; set; }
    public string purpose { get; set; }
    public string mortgageType { get; set; }
    public DateTime closingDate { get; set; }
    public DateTime fundingDate { get; set; }
    public string paymentFrequency { get; set; }
    public int purchaseValue { get; set; }
    public int insurancePremium { get; set; }
    public object insuranceAmount { get; set; }
    public bool includePremiumInMortgage { get; set; }
    public object monthlyPayment { get; set; }
    public int totalMortgageAmount { get; set; }
    public int netRate { get; set; }
    public object originalNetRate { get; set; }
    public int termMonths { get; set; }
    public int amortizationMonths { get; set; }
    public string repaymentType { get; set; }
    public string type { get; set; }
    public string termType { get; set; }
    public string rateType { get; set; }
    public object maturityDate { get; set; }
    public object mortgageBalance { get; set; }
    public object payoutBalance { get; set; }
    public object insured { get; set; }
    public string insurer { get; set; }
    public string insuranceAccountNum { get; set; }
    public object mortgageNum { get; set; }
    public string prepaymentType { get; set; }
    public int prepaymentAmount { get; set; }
    public int prepaymentPenaltyPeriod { get; set; }
    public object isPrepaymentAmountInPayments { get; set; }
    public object balloonAmount { get; set; }
    public object dateOfAdvance { get; set; }
    public DateTime interestAdjustmentDate { get; set; }
    public object firstRegularPaymentDate { get; set; }
    public DateTime deadlineToAcceptDate { get; set; }
    public object pst { get; set; }
    public string compounding { get; set; }
    public bool close { get; set; }
    public object affiliationProgram { get; set; }
    public object cashBackAmt { get; set; }
    public object cashBackPercentage { get; set; }
    public object marketSubmission { get; set; }
    public object miFeeAmount { get; set; }
    public object miPremiumAmount { get; set; }
    public object miPremiumPst { get; set; }
    public object discount { get; set; }
    public object buyDownRate { get; set; }
    public object rateGuaranteeLength { get; set; }
    public object privilegePayment { get; set; }
    public object customFields { get; set; }
    public bool isEdge { get; set; }
    public int amountToBeAdvanced { get; set; }
    public float interestAdjustmentAmount { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public object[] ApplicantMortgages { get; set; }
  }

  public class Expandedloannumber1
  {
    public int number { get; set; }
    public string prefix { get; set; }
    public string suffix { get; set; }
  }

  public class Financialasset
  {
    public string id { get; set; }
    public DateTime createdAt { get; set; }
    public string asset { get; set; }
    public string description { get; set; }
    public int value { get; set; }
    public Applicantfinancialasset[] ApplicantFinancialAssets { get; set; }
    public bool useAsDownPayment { get; set; }
  }

  public class Applicantfinancialasset
  {
    public string applicantId { get; set; }
    public string financialAssetId { get; set; }
  }

}
