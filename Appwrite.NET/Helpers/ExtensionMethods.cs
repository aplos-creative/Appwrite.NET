using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite
{
    public static class ExtensionMethods
    {
        // Use System.Text.Json for this TODO
        //public static string ToJson(this Dictionary<string, object> dict)
        //{
        //    var settings = new JsonSerializerSettings
        //    {
        //        ContractResolver = new CamelCasePropertyNamesContractResolver(),
        //        Converters = new List<JsonConverter> { new StringEnumConverter() }
        //    };

        //    return JsonConvert.SerializeObject(dict, settings);
        //}

        public static string ToQueryString(this Dictionary<string, object> parameters)
        {
            List<string> query = new List<string>();

            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (parameter.Value != null)
                {
                    if (parameter.Value is List<object>)
                    {
                        foreach (object entry in (dynamic)parameter.Value)
                        {
                            query.Add(parameter.Key + "[]=" + Uri.EscapeUriString(entry.ToString()));
                        }
                    }
                    else
                    {
                        query.Add(parameter.Key + "=" + Uri.EscapeUriString(parameter.Value.ToString()));
                    }
                }
            }
            return string.Join("&", query);
        }
    }
}
