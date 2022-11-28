using System.Net;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using fundmore.DTO;
using System.Text.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace fundmore;

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
    public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("Get Request\n");

    var input = new Input() { applicationNotes = "test note"};
    string jsonString = JsonSerializer.Serialize(input);

    var response = new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "Hello AWS Serverless" + jsonString,
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };

        return response;
    }
}