namespace fundmore.DTO;
public class Input
{
    public string id { get; set; }
    public int ezidoxApplicationId { get; set; }
    public string tenantId { get; set; }
    public object filogixDealId { get; set; }
    public string externalDealId { get; set; }
    public string createdBy { get; set; }
    public object archivedByUserId { get; set; }
    public string name { get; set; }
    public object brokerNotes { get; set; }
    public object brokerNotesDate { get; set; }
    public object applicationNotes { get; set; }
    public string code { get; set; }
    public DateTime applicationDate { get; set; }
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
    public string productId { get; set; }
    public string dealType { get; set; }
    public object clonedApplicationId { get; set; }
    public string mortgageClassification { get; set; }
    public bool locked { get; set; }
    public object lineOfBusinessId { get; set; }
    public object customFields { get; set; }
    public string[] warnings { get; set; }
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
    public object ApplicationStatus { get; set; }
    public Applicationadvancedproduct1[] ApplicationAdvancedProducts { get; set; }
    public object eqMapsPostbackHistory { get; set; }
    public Applicant[] applicants { get; set; }
    public Financialliability[] FinancialLiabilities { get; set; }
    public Property1[] Properties { get; set; }
    public Financialasset[] FinancialAssets { get; set; }
    public Uiabstractpermissions uiAbstractPermissions { get; set; }
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
    public object isCurrent { get; set; }
    public string applicationId { get; set; }
    public string type { get; set; }
    public string description { get; set; }
    public string period { get; set; }
    public string incomePaymentFrequency { get; set; }
    public int amount { get; set; }
    public object startDate { get; set; }
    public object endDate { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public object[] ApplicantOtherIncomes { get; set; }
}

public class Downpayment
{
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string source { get; set; }
    public object description { get; set; }
    public int amount { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public object financialAssetId { get; set; }
}

public class Mortgage
{
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string propertyId { get; set; }
    public string loanNumber { get; set; }
    public object expandedLoanNumber { get; set; }
    public string lender { get; set; }
    public string productName { get; set; }
    public string loanType { get; set; }
    public string purpose { get; set; }
    public string mortgageType { get; set; }
    public DateTime? closingDate { get; set; }
    public DateTime? fundingDate { get; set; }
    public string paymentFrequency { get; set; }
    public int? purchaseValue { get; set; }
    public int? insurancePremium { get; set; }
    public int? insuranceAmount { get; set; }
    public bool includePremiumInMortgage { get; set; }
    public float monthlyPayment { get; set; }
    public int? totalMortgageAmount { get; set; }
    public float netRate { get; set; }
    public float originalNetRate { get; set; }
    public int? termMonths { get; set; }
    public object amortizationMonths { get; set; }
    public string repaymentType { get; set; }
    public string type { get; set; }
    public string termType { get; set; }
    public string rateType { get; set; }
    public DateTime? maturityDate { get; set; }
    public int mortgageBalance { get; set; }
    public object payoutBalance { get; set; }
    public object insured { get; set; }
    public string insurer { get; set; }
    public string insuranceAccountNum { get; set; }
    public object mortgageNum { get; set; }
    public object prepaymentType { get; set; }
    public object prepaymentAmount { get; set; }
    public int? prepaymentPenaltyPeriod { get; set; }
    public object isPrepaymentAmountInPayments { get; set; }
    public object balloonAmount { get; set; }
    public object dateOfAdvance { get; set; }
    public object interestAdjustmentDate { get; set; }
    public object firstRegularPaymentDate { get; set; }
    public DateTime? deadlineToAcceptDate { get; set; }
    public string pst { get; set; }
    public string compounding { get; set; }
    public bool? close { get; set; }
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
    public int? amountToBeAdvanced { get; set; }
    public int? interestAdjustmentAmount { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public object[] ApplicantMortgages { get; set; }
    public Applicationadvancedproduct applicationAdvancedProduct { get; set; }
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
    public object updatedAt { get; set; }
    public object deletedAt { get; set; }
}

public class Advancedproductsnapshot
{
    public string id { get; set; }
    public string name { get; set; }
    public int netRate { get; set; }
    public string tenantId { get; set; }
    public object externalId { get; set; }
    public Parameters parameters { get; set; }
    public Defaultvalue[] defaultValues { get; set; }
}

public class Parameters
{
    public bool isEdge { get; set; }
    public bool isCombo { get; set; }
    public Modules modules { get; set; }
    public bool isInsured { get; set; }
}

public class Modules
{
    public bool flipModule { get; set; }
    public bool constructionModule { get; set; }
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
    public object updatedAt { get; set; }
    public object deletedAt { get; set; }
}

public class Advancedproductsnapshot1
{
    public string id { get; set; }
    public string name { get; set; }
    public int netRate { get; set; }
    public string tenantId { get; set; }
    public object externalId { get; set; }
    public Parameters1 parameters { get; set; }
    public Defaultvalue1[] defaultValues { get; set; }
}

public class Parameters1
{
    public bool isEdge { get; set; }
    public bool isCombo { get; set; }
    public Modules1 modules { get; set; }
    public bool isInsured { get; set; }
}

public class Modules1
{
    public bool flipModule { get; set; }
    public bool constructionModule { get; set; }
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
    public object middleName { get; set; }
    public string workPhone { get; set; }
    public string cellPhone { get; set; }
    public string homePhone { get; set; }
    public object faxNumber { get; set; }
    public string email { get; set; }
    public string maritalStatus { get; set; }
    public string dateOfBirth { get; set; }
    public object placeOfBirth { get; set; }
    public object countryOfResidence { get; set; }
    public object registeredCountry { get; set; }
    public object nationality { get; set; }
    public int? dependents { get; set; }
    public object relationshipToPrimaryApplicant { get; set; }
    public object preferredContact { get; set; }
    public object sin { get; set; }
    public int? crScore { get; set; }
    public object crDescription { get; set; }
    public int ezidoxStakeholderId { get; set; }
    public bool isUploader { get; set; }
    public object createDocumentRequest { get; set; }
    public string customerType { get; set; }
    public string brokerId { get; set; }
    public string brokerage { get; set; }
    public string lawyerId { get; set; }
    public string company { get; set; }
    public bool isFirstTimeHomeBuyer { get; set; }
    public object languagePreference { get; set; }
    public object salutation { get; set; }
    public object gender { get; set; }
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
    public string applicationId { get; set; }
    public bool isCurrent { get; set; }
    public string employerName { get; set; }
    public object employerAddress { get; set; }
    public object employerCountry { get; set; }
    public object bonusOvertimeCommissions { get; set; }
    public object employerEmailAddress { get; set; }
    public object businessType { get; set; }
    public int? timeAtJobMonths { get; set; }
    public object timeAtIndustryMonths { get; set; }
    public string description { get; set; }
    public string occupation { get; set; }
    public string jobTitle { get; set; }
    public string employmentType { get; set; }
    public int annualIncome { get; set; }
    public object paymentType { get; set; }
    public string incomePaymentFrequency { get; set; }
    public object industrySector { get; set; }
    public object startDate { get; set; }
    public object endDate { get; set; }
    public string type { get; set; }
    public object phoneNumber { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
}

public class Applicantaddress
{
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicantId { get; set; }
    public string applicationId { get; set; }
    public string type { get; set; }
    public string address { get; set; }
    public string residentialType { get; set; }
    public string residentialStatus { get; set; }
    public string residentialStatusType { get; set; }
    public string timeAtResidence { get; set; }
    public int? timeAtResidenceMonths { get; set; }
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
    public string description { get; set; }
    public string liability { get; set; }
    public int value { get; set; }
    public int balance { get; set; }
    public float monthlyPayment { get; set; }
    public string payoff { get; set; }
    public object crHasWrittenOff { get; set; }
    public object crStatus { get; set; }
    public bool payout { get; set; }
    public object close { get; set; }
    public object collectionAccount { get; set; }
    public object externalAccountId { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public object[] ApplicantFinancialLiabilities { get; set; }
    public object[] FinancialLiabilityRecordTypes { get; set; }
}

public class Property1
{
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string propertyAddress { get; set; }
    public object legalDescription { get; set; }
    public object shortLegalDescription { get; set; }
    public object pid { get; set; }
    public string lot { get; set; }
    public string block { get; set; }
    public object plan { get; set; }
    public string zoningType { get; set; }
    public string propertyType { get; set; }
    public string concessionTownship { get; set; }
    public string occupancy { get; set; }
    public int yearBuilt { get; set; }
    public string heatingType { get; set; }
    public string livingSpace { get; set; }
    public string lotSize { get; set; }
    public string dwellingType { get; set; }
    public string dwellingStyle { get; set; }
    public string garageSize { get; set; }
    public string garageType { get; set; }
    public int taxationYear { get; set; }
    public string taxesPaidBy { get; set; }
    public bool isEnvironmentalHazard { get; set; }
    public bool includeExpensesInTDS { get; set; }
    public object purchasePrice { get; set; }
    public object purchaseDate { get; set; }
    public int estimatedValue { get; set; }
    public object estimatedValueDate { get; set; }
    public int heatingCost { get; set; }
    public int condoFeesPercentInCalculation { get; set; }
    public int condoFees { get; set; }
    public int annualTaxes { get; set; }
    public string improvements { get; set; }
    public object valueOfImprovements { get; set; }
    public object totalExpenses { get; set; }
    public int rpeMonthlyRentalIncome { get; set; }
    public object rpeRentalOffsetOption { get; set; }
    public object rpeOffset { get; set; }
    public int rpeInsurance { get; set; }
    public int rpeHydro { get; set; }
    public int rpeManagementExpenses { get; set; }
    public int rpeRepairs { get; set; }
    public object rpeInterestCharges { get; set; }
    public int rpeGeneralExpenses { get; set; }
    public string type { get; set; }
    public object constructionType { get; set; }
    public object tenure { get; set; }
    public object waterType { get; set; }
    public object noOfUnits { get; set; }
    public object sewageInfo { get; set; }
    public object foundationType { get; set; }
    public object nameOnTitle { get; set; }
    public object corroborations { get; set; }
    public bool isCollateralized { get; set; }
    public bool hasOtherSecurityConditions { get; set; }
    public object otherSecurityConditions { get; set; }
    public bool includeInCLTV { get; set; }
    public object locationTier { get; set; }
    public object isMlsListing { get; set; }
    public object mlsNumber { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public object[] PropertyAppraisals { get; set; }
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
    public object unit { get; set; }
    public string postalCode { get; set; }
}

public class Rawgooglegeocoderesponse
{
    public string[] types { get; set; }
    public Geometry geometry { get; set; }
    public string place_id { get; set; }
    public string formatted_address { get; set; }
    public Address_Components[] address_components { get; set; }
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

public class Address_Components
{
    public string[] types { get; set; }
    public string long_name { get; set; }
    public string short_name { get; set; }
}

public class Mortgage1
{
    public string id { get; set; }
    public string tenantId { get; set; }
    public string applicationId { get; set; }
    public string propertyId { get; set; }
    public string loanNumber { get; set; }
    public object expandedLoanNumber { get; set; }
    public string lender { get; set; }
    public string productName { get; set; }
    public string loanType { get; set; }
    public string purpose { get; set; }
    public string mortgageType { get; set; }
    public DateTime? closingDate { get; set; }
    public DateTime? fundingDate { get; set; }
    public string paymentFrequency { get; set; }
    public int? purchaseValue { get; set; }
    public int? insurancePremium { get; set; }
    public int? insuranceAmount { get; set; }
    public bool includePremiumInMortgage { get; set; }
    public float monthlyPayment { get; set; }
    public int? totalMortgageAmount { get; set; }
    public float netRate { get; set; }
    public float originalNetRate { get; set; }
    public int? termMonths { get; set; }
    public object amortizationMonths { get; set; }
    public string repaymentType { get; set; }
    public string type { get; set; }
    public string termType { get; set; }
    public string rateType { get; set; }
    public DateTime? maturityDate { get; set; }
    public int mortgageBalance { get; set; }
    public object payoutBalance { get; set; }
    public object insured { get; set; }
    public object insurer { get; set; }
    public object insuranceAccountNum { get; set; }
    public object mortgageNum { get; set; }
    public object prepaymentType { get; set; }
    public object prepaymentAmount { get; set; }
    public int? prepaymentPenaltyPeriod { get; set; }
    public object isPrepaymentAmountInPayments { get; set; }
    public object balloonAmount { get; set; }
    public object dateOfAdvance { get; set; }
    public object interestAdjustmentDate { get; set; }
    public object firstRegularPaymentDate { get; set; }
    public DateTime? deadlineToAcceptDate { get; set; }
    public object pst { get; set; }
    public string compounding { get; set; }
    public bool? close { get; set; }
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
    public int? amountToBeAdvanced { get; set; }
    public int? interestAdjustmentAmount { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public object deletedAt { get; set; }
    public object[] ApplicantMortgages { get; set; }
}

public class Financialasset
{
    public string id { get; set; }
    public DateTime createdAt { get; set; }
    public string asset { get; set; }
    public string description { get; set; }
    public int value { get; set; }
    public object[] ApplicantFinancialAssets { get; set; }
    public bool useAsDownPayment { get; set; }
}
