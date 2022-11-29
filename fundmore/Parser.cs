using Newtonsoft.Json.Linq;
using System.Linq;

namespace fundmore
{
    public static class Parser
    {
        public static JObject Parse(string inputField, string outputField, JObject inputJson, JObject outputJson)
        {
            if (inputField.StartsWith("\""))
            {
                ParseString(inputField, outputField, outputJson);
            }
            else if (inputField.Contains("."))
            {
                ParseObject(inputField, outputField, inputJson, outputJson);
            }
            else if (inputField.Contains("blank"))
            {
                ParseBlank(outputField, outputJson);
            }
            else if (inputField.Contains("["))
            {
                ParseArray(inputField, outputField, inputJson, outputJson);
            }
            else
            {
                outputJson.Add(outputField, inputJson[inputField]);
            }

            return outputJson;
        }

        private static void ParseString(string inputField, string outputField, JObject outputJson)
        {
            var formatedInput = inputField.Substring(1, inputField.Length - 2);
            outputJson.Add(outputField, formatedInput);
        }

        private static void ParseObject(string inputField, string outputField, JObject inputJson, JObject outputJson)
        {
            var splitedInput = inputField.Split(".");
            var query = $"$.{splitedInput[0]}";
            foreach (var d in splitedInput.Skip(1))
            {
                query = query + $".{d}";
            }

            dynamic result = inputJson.SelectTokens(query).Select(t => t).ToArray()[0];
            var splitedOutput = outputField.Split(".");
            var firstLeveljObject = new JObject();
            JProperty finalJProperty = null;

            if (!outputJson.ContainsKey(splitedOutput[splitedOutput.Length - 1]))
            {
                firstLeveljObject.Add(splitedOutput[splitedOutput.Length - 1], result);
                var iValue = splitedOutput.Length - 2;
                finalJProperty = ParseOutputAddress(firstLeveljObject, iValue, splitedOutput, outputJson);
                if (finalJProperty != null)
                {
                    outputJson.Add(finalJProperty);
                }
            }
        }

        private static void ParseBlank(string outputField, JObject outputJson)
        {
            outputJson.Add(outputField, "");
        }

        private static void ParseArray(string inputField, string outputField, JObject inputJson, JObject outputJson)
        {
            var query = $"$.{inputField}";
            dynamic result = inputJson.SelectTokens(query).Select(t => t).ToArray()[0];

            if (outputField.Contains("["))
            {
                var jArray = new JArray();
                jArray.Add(result);
                var arrayFieldName = outputField.Substring(0, outputField.Length - 3);
                var jProperty = new JProperty(arrayFieldName, jArray);
                outputJson.Add(jProperty);
            }
        }

        private static JProperty ParseOutputAddress(JObject firstLeveljObject, int iValue, string[] splitedOutput, JObject outputJson)
        {
            var secondLeveljObject = new JObject();
            JProperty jProperty = null;
            var i = iValue;
            if (i >= 0)
            {
                var secondLevelProperty = splitedOutput[i];
                if (!outputJson.ContainsKey(secondLevelProperty))
                {
                    jProperty = new JProperty(secondLevelProperty, firstLeveljObject);

                    if (i - 1 >= 0)
                    {
                        secondLeveljObject.Add(jProperty);
                        jProperty = ParseOutputAddress(secondLeveljObject, i - 1, splitedOutput, outputJson);
                    }
                }
            }

            return jProperty;
        }
    }
}
