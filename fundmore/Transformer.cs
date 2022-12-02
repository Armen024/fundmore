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

            result.General = general;



            var requestedMortgage = input.Mortgages.SingleOrDefault(x => x.type == "REQUESTED");
            if (requestedMortgage != null)
            {

                var lMS360Account = new LMS360Account() { AccountID = requestedMortgage.loanNumber, AccountStatus = LMS360AccountAccountStatus.Active };
                lMS360Account.MortgageInsuranceNumber = requestedMortgage.insuranceAccountNum;
                lMS360Account.ApplicationDateTimeSpecified = true;
                lMS360Account.ApplicationDateTime = input.createdAt;


                lMS360Account.ApplicationType = LMS360AccountApplicationType.Regular;
                lMS360Account.ApplicationTypeSpecified = true;


                lMS360Account.ApplicationFeeSpecified = true;
                lMS360Account.ApplicationFee = 4;

                lMS360Account.LineOfBusiness = "A";
                lMS360Account.Channel = LMS360AccountChannel.InternalSales;

                lMS360Account.ChannelSpecified = true;

                lMS360Account.DealID = "dd";


                lMS360Account.OtherFinancing = null;
                lMS360Account.OtherFinancingSpecified = true;


                lMS360Account.ApplicationFeeSpecified = false;

                lMS360Account.TotalLoanAmountSpecified = true;
                lMS360Account.TotalLoanAmount = requestedMortgage.totalMortgageAmount;

                lMS360Account.ClosingDateSpecified = true;
                lMS360Account.ClosingDate = requestedMortgage.closingDate;

                lMS360Account.BasicLoanAmountSpecified = true;
                lMS360Account.BasicLoanAmount = requestedMortgage.totalMortgageAmount;

                lMS360Account.PremiumAmountSpecified = true;
                lMS360Account.PremiumAmount = requestedMortgage.insurancePremium;

                result.Account = new LMS360Account[1];
                result.Account[0] = lMS360Account;
            }

            return result;
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
