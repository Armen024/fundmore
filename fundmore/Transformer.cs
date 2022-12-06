using fundmore.DTO;
using System.Xml.Schema;
using System.Xml;

namespace fundmore
{
    public static class Transformer
    {
        internal static LMS360 Transform(Input input)
        {
            var result = new LMS360();


            var general = new LMS360General();
            general.InstitutionName = "Rocket Mortgage";
            general.LenderName = "Rocket Mortgage";
            general.LenderCode = "Rocket Mortgage";
            general.OriginatorName = "FundMore";
            general.Action = LMS360GeneralAction.LMS360_ServicingImport;

            result.General = general;



            var requestedMortgage = input.Mortgages.SingleOrDefault(x => x.type == "REQUESTED");
            var refinancedMortgage = input.Mortgages.SingleOrDefault(x => x.type == "REFINANCE" && input.purpose == "REFINANCE");
            var subjectProperty = input.Properties.SingleOrDefault(p => p.type == "PRIMARY");


            var lMS360Account = new LMS360Account();
            if (requestedMortgage != null)
            {
                lMS360Account.AccountID = requestedMortgage.loanNumber;
                lMS360Account.AccountStatus = LMS360AccountAccountStatus.Active;

                lMS360Account.PurposeOfFundsSpecified = true;
                lMS360Account.PurposeOfFunds = AccountPurposeOfFunds(input);

                lMS360Account.ApplicationID = input.externalDealId;

                lMS360Account.ApplicationDateTimeSpecified = true;
                lMS360Account.ApplicationDateTime = input.createdAt;


                if (input.dealType != null)
                {
                    lMS360Account.ApplicationTypeSpecified = true;
                    lMS360Account.ApplicationType = (LMS360AccountApplicationType)Enum.Parse(typeof(LMS360AccountApplicationType), input.dealType);
                }

                lMS360Account.LineOfBusiness = "A";


                lMS360Account.ChannelSpecified = true;
                lMS360Account.Channel = LMS360AccountChannel.InternalSales;

                lMS360Account.DealID = requestedMortgage.loanNumber;

                lMS360Account.BasicLoanAmountSpecified = true;
                lMS360Account.BasicLoanAmount = requestedMortgage.totalMortgageAmount;

                lMS360Account.TotalLoanAmountSpecified = true;
                lMS360Account.TotalLoanAmount = requestedMortgage.totalMortgageAmount;

                lMS360Account.ClosingDateSpecified = true;
                lMS360Account.ClosingDate = requestedMortgage.closingDate;


                lMS360Account.MortgageInsuranceProviderSpecified = true;
                lMS360Account.MortgageInsuranceProvider = AccountMortgageInsuranceProvider(requestedMortgage.insurer);


                lMS360Account.MortgageInsuranceNumber = requestedMortgage.insuranceAccountNum;

                lMS360Account.PremiumAmountSpecified = true;
                lMS360Account.PremiumAmount = requestedMortgage.insurancePremium;


                lMS360Account.PremiumTax = requestedMortgage.pst;

                lMS360Account.Charge = GetMortgageRank(requestedMortgage.mortgageType);                

            }

            if (refinancedMortgage != null)
            {
                lMS360Account.OrigLender = refinancedMortgage.lender;

                lMS360Account.OrigAccountID = refinancedMortgage.mortgageNum;

                lMS360Account.OrigRemainingBalanceSpecified = true;
                lMS360Account.OrigRemainingBalance = refinancedMortgage.mortgageBalance;
            }

            if (subjectProperty != null)
            {
                lMS360Account.ImprovementAmountSpecified = true;
                lMS360Account.ImprovementAmount = subjectProperty.valueOfImprovements;

                lMS360Account.ImprovementDescription = subjectProperty.improvements;
            }

            lMS360Account.DownPayment = GetAccountDownPaymentSources(input.DownPayments);


            var externalCustomerType = new List<string>() {
                "THIRD_PARTY",
                "BROKER",
                "LAWYER",
                "SUBMITTING_AGENT",
                "SIGNING_OFFICER",
               "AGENT"
            };
            var externalStakeholders = input.applicants.Where(a => externalCustomerType.Any(ct => ct == a.customerType)).ToArray();


            lMS360Account.ExternalContacts = GetAccountExternalContacts(externalStakeholders);


            // line 69


            lMS360Account.ApplicationFeeSpecified = true;
            lMS360Account.ApplicationFee = 4;



            lMS360Account.OtherFinancing = null;
            lMS360Account.OtherFinancingSpecified = true;


            lMS360Account.ApplicationFeeSpecified = false;




            lMS360Account.Component = new LMS360AccountComponent[1] { new LMS360AccountComponent() { LoanAmount = 5, PaymentFrequencyDetails = new LMS360AccountComponentPaymentFrequencyDetails() { } } };



            result.Account = new LMS360Account[1] { lMS360Account };
            return result;
        }

        private static LMS360AccountExternalContacts[] GetAccountExternalContacts(Applicant[] externalStakeholders)
        {
            LMS360AccountExternalContacts[] result = new LMS360AccountExternalContacts[externalStakeholders.Length];

            for (int i = 0; i < externalStakeholders.Length; i++)
            {
                var applicant = externalStakeholders[i];
                var lMS360AccountExternalContacts = new LMS360AccountExternalContacts();
                lMS360AccountExternalContacts.Type = GetAccountExternalContactType(applicant.customerType);
                lMS360AccountExternalContacts.ExternalSystem = "Lendesk";
                lMS360AccountExternalContacts.CompanyName = (applicant.customerType == "BROKER" || applicant.customerType == "AGENT") ? applicant.brokerage : (applicant.customerType == "LAWYER" ? applicant.company : null);
                lMS360AccountExternalContacts.FirstName = applicant.name;
                lMS360AccountExternalContacts.LastName = applicant.surname;
                //var applicantAddress=  applicant.ApplicantAddresses.FirstOrDefault(a => a.type == "CURRENT")?.address;

                //if (applicantAddress != null)
                //{
                //    lMS360AccountExternalContacts.StreetAddress = new StreetAddress[1] { applicantAddress };
                //    }



                result[i] = lMS360AccountExternalContacts;
            }


            return result;
        }

        private static LMS360AccountExternalContactsType GetAccountExternalContactType(string customerType)
        {
            //if(customerType == "THIRD_PARTY")   todo
            //    return LMS360AccountExternalContactsType.


            if (customerType == "BROKER" || customerType == "AGENT")
                return LMS360AccountExternalContactsType.BrokerAgent;

            if (customerType == "LAWYER")
                return LMS360AccountExternalContactsType.Solicitor;

            if (customerType == "SUBMITTING_AGENT")
                return LMS360AccountExternalContactsType.SubmissionAgent;

            if (customerType == "SIGNING_OFFICER")
                return LMS360AccountExternalContactsType.VendorAgent;

            Console.WriteLine("ExternalContactsType cant be mapped");
            throw new Exception($"unexpected value received for customerType : {customerType}");
        }

        private static LMS360AccountDownPayment[] GetAccountDownPaymentSources(Downpayment[] downPayments)
        {
            LMS360AccountDownPayment[] result = new LMS360AccountDownPayment[downPayments.Length];

            for (int i = 0; i < downPayments.Length; i++)
            {
                Downpayment? downpayment = downPayments[i];
                var lMS360AccountDownPayment = new LMS360AccountDownPayment();
                lMS360AccountDownPayment.Source = GetAccountDownPaymentSource(downpayment);
                lMS360AccountDownPayment.Amount = downpayment.amount;
                lMS360AccountDownPayment.Description = downpayment.description;

                result[i] = lMS360AccountDownPayment;
            }


            return result;
        }

        private static LMS360AccountDownPaymentSource GetAccountDownPaymentSource(Downpayment downpayment)
        {
            if (downpayment.source == "SALE_OF_EXISTING_PROPERTY")
                return LMS360AccountDownPaymentSource.SaleofExistingProperty;

            if (downpayment.source == "PERSONAL_CASH")
                return LMS360AccountDownPaymentSource.PersonalCash;

            if (downpayment.source == "RRSP")
                return LMS360AccountDownPaymentSource.RRSP;

            if (downpayment.source == "SELF_DIRECTED_RRSP")
                return LMS360AccountDownPaymentSource.RRSP;

            if (downpayment.source == "BORROWED_AGAINST_LIQUID_ASSETS")
                return LMS360AccountDownPaymentSource.BorrowedAgainstLiquidAssets;

            if (downpayment.source == "GIFT")
                return LMS360AccountDownPaymentSource.Gift;

            if (downpayment.source == "SWEAT_EQUITY")
                return LMS360AccountDownPaymentSource.SweatEquity;

            if (downpayment.source == "EXISTING_EQUITY")
                return LMS360AccountDownPaymentSource.ExistingEquity;

            if (downpayment.source == "SECONDARY_FINANCING")
                return LMS360AccountDownPaymentSource.SecondaryFinancing;

            if (downpayment.source == "GRANTS")
                return LMS360AccountDownPaymentSource.Grants;

            if (downpayment.source == "LOAN")
                return LMS360AccountDownPaymentSource.BorrowedFunds;

            if (downpayment.source == "RENT")
                return LMS360AccountDownPaymentSource.RenttoOwn;

            if (downpayment.source == "OTHER")
                return LMS360AccountDownPaymentSource.Other;

            Console.WriteLine("AccountDownPaymentSource cant be mapped");
            throw new Exception($"unexpected value received for downpayment.source : {downpayment.source}");
        }

        private static LMS360AccountMortgageInsuranceProvider? AccountMortgageInsuranceProvider(string insurer)
        {

            if (insurer == "CMHC")
            {
                return LMS360AccountMortgageInsuranceProvider.CMHC;
            }
            if (insurer == "Sagen")
            {
                return LMS360AccountMortgageInsuranceProvider.Genworth;
            }
            if (insurer == "Canada Guaranty")
            {
                return LMS360AccountMortgageInsuranceProvider.CanadaGuaranty;
            }

            Console.WriteLine("AccountMortgageInsuranceProvider cant be mapped");
            return null;

        }

        private static MortgageRank? GetMortgageRank(string mortgageType)
        {

            if (mortgageType == "First")
            {
                return MortgageRank.Item1st;
            }
            if (mortgageType == "Second")
            {
                return MortgageRank.Item2nd;
            }
            if (mortgageType == "Third")
            {
                return MortgageRank.Item3rd;
            }

            Console.WriteLine("MortgageRank cant be mapped");
            return null;

        }

        private static LMS360AccountPurposeOfFunds AccountPurposeOfFunds(Input input)
        {
            if (input.purpose == "ETO")
                return LMS360AccountPurposeOfFunds.EquityTakeOut;

            if (input.purpose == "Construction")
                return LMS360AccountPurposeOfFunds.NewConstruction;

            if (input.purpose == "PURCHASE" && input.mortgageClassification == "NEW_BUILD") // todo review mortgageClassification values
                return LMS360AccountPurposeOfFunds.PurchaseNewConstruction;

            if (input.purpose == "PURCHASE" && input.mortgageClassification == "PORT")
                return LMS360AccountPurposeOfFunds.PurchasePort;


            if (input.purpose == "PURCHASE" && input.mortgageClassification == "PRIVATE")
                return LMS360AccountPurposeOfFunds.PurchasePrivate;

            if (input.purpose == "PURCHASE" && input.mortgageClassification == "Rent-to-own")
                return LMS360AccountPurposeOfFunds.PurchaseRenttoown;

            if (input.purpose == "PURCHASE" && input.mortgageClassification == "PURCHASE_PLUS_IMPROVEMENT")
                return LMS360AccountPurposeOfFunds.PurchasewithImprovements;

            if (input.purpose == "PURCHASE")
                return LMS360AccountPurposeOfFunds.Purchase;


            if (input.purpose == "REFINANCE")
                return LMS360AccountPurposeOfFunds.Refinance;


            if (input.purpose == "SWITCH_TRANSFER")
                return LMS360AccountPurposeOfFunds.Transfer;

            Console.WriteLine("PurposeOfFunds is set to Unmapped");

            return LMS360AccountPurposeOfFunds.Unmapped;
        }

        internal static void ValidateXml(string res)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add("http://www.Delta360.com/Schemas/LMS360Origination", "LMS360Servicing.xsd");
            settings.ValidationType = ValidationType.Schema;

            settings.ValidationEventHandler += SettingsValidationEventHandler;

            XmlReader xmlReader = XmlReader.Create(new StringReader(res), settings);

            while (xmlReader.Read()) { }
        }
        static void SettingsValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
            {
                Console.Write("WARNING: ");
                Console.WriteLine(e.Message);
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                Console.Write("ERROR: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
