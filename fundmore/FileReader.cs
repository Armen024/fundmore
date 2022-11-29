using Newtonsoft.Json.Linq;
using SpreadsheetLight;
using System;

namespace fundmore
{
    public static class FileReader
    {
        public static JObject ReadJson(string stringJson)
        {
                try
                {
                    var inputJson = JObject.Parse(stringJson);
                    return inputJson;
                }
                catch (Exception)
                {
                    Console.WriteLine("Problem reading file");
                    return null;
                }
        }
        public static string ReadExcel(string path, string sheet, string address)
        {
            try
            {
                SLDocument sl = new SLDocument(path, sheet);
                var cellValue = sl.GetCellValueAsString(address);
                return cellValue;
            }
            catch (Exception)
            {
                Console.WriteLine("Problem reading file");
                return null;
            }
        }
    }
}
