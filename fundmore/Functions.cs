using System.Net;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using fundmore.DTO;
using System.Xml;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace fundmore {

    public class Functions
    {
        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public Functions()
        {
        }


        /// <summary>
        /// A Lambda function to respond to HTTP Get methods from API Gateway
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The API Gateway response.</returns>
        //public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
        //{
        //    context.Logger.LogInformation("Get Request\n");

        //    var input = new Input() { applicationNotes = "test note" };
        //    string jsonString = System.Text.Json.JsonSerializer.Serialize(input);

        //    var response = new APIGatewayProxyResponse
        //    {
        //        StatusCode = (int)HttpStatusCode.OK,
        //        Body = "Hello AWS Serverless" + jsonString,
        //        Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        //    };

        //    return response;
        //}

        ///// <summary>
        ///// A Lambda function to respond to HTTP Post methods from API Gateway
        ///// </summary>
        ///// <param name="request"></param>
        ///// <returns>The API Gateway response.</returns>
        //public APIGatewayProxyResponse Post(APIGatewayProxyRequest request, ILambdaContext context)
        //{
        //    var inputJson = FileReader.ReadJson(request.Body);
        //    var outputJson = new JObject();

        //    foreach (var row in Constants.excellRows)
        //    {
        //        var inputValue = FileReader.ReadExcel(Constants.excelPath, Constants.excelSheet, Constants.excellColumns[0] + row);
        //        var outputValue = FileReader.ReadExcel(Constants.excelPath, Constants.excelSheet, Constants.excellColumns[1] + row);
        //        outputJson = Parser.Parse(inputValue, outputValue, inputJson, outputJson);
        //    }

        //    XmlDocument xml = JsonConvert.DeserializeXmlNode(outputJson.ToString(), "root");
        //    var xmlString = xml.OuterXml;

        //    var response = new APIGatewayProxyResponse
        //    {
        //        StatusCode = (int)HttpStatusCode.OK,
        //        Body = "Hello AWS Serverless" + xmlString,
        //        Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        //    };

        //    return response;
        //}


        /// <summary>
        /// A Lambda function to respond to HTTP Post methods from API Gateway
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The API Gateway response.</returns>
        public string? Post(Input request, ILambdaContext context)
        {
            try
            {
                //var input = System.Text.Json.JsonSerializer.Deserialize<Input>(request.Body);

                LMS360 output = Transformer.Transform(request);


                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(output.GetType());
                string res;
                using (var textWriter = new StringWriter())
                {
                    x.Serialize(textWriter, output);
                    res = textWriter.ToString();
                }

                Transformer.ValidateXml(res);


                Console.WriteLine("Output XML: ");
                Console.WriteLine(res);

                //var response = new APIGatewayProxyResponse
                //{
                //    StatusCode = (int)HttpStatusCode.OK,
                //    Body = res,
                //    Headers = new Dictionary<string, string> { { "Content-Type", "text/xml" } }
                //};


                return res;


            }
            catch (Exception ex)
            {
                Console.Write("ERROR: ");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}