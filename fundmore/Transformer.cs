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
            if (requestedMortgage != null)
            {

                var lMS360Account = new LMS360Account();
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


                // line 31   Anna


                // 50 Armen


                //69





                lMS360Account.ApplicationFeeSpecified = true;
                lMS360Account.ApplicationFee = 4;



                lMS360Account.OtherFinancing = null;
                lMS360Account.OtherFinancingSpecified = true;


                lMS360Account.ApplicationFeeSpecified = false;









                lMS360Account.Component = new LMS360AccountComponent[1] { new LMS360AccountComponent() { LoanAmount = 5, PaymentFrequencyDetails = new LMS360AccountComponentPaymentFrequencyDetails() { } } };

                result.Account = new LMS360Account[1];
                result.Account[0] = lMS360Account;
            }

            return result;
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
