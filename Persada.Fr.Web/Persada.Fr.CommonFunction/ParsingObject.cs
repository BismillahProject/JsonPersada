using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.CommonFunction
{
    public static class ParsingObject
    {
        /// <summary>
        /// use for retrived data one record
        /// </summary>
        /// <param name="param"></param>
        /// <param name="controller"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static string RetrivedData(this object param, string controller, string function)
        {
            InvokeUrl url = new InvokeUrl();
            var qryString = ObjectToDictionaryHelper.GenericObjectToString(param);
            JObject jsonDes = JObject.Parse(url.ReturnJson(controller, function, qryString));

            return jsonDes["Body"]["Data"][0].ToString();
        }
    }
}

