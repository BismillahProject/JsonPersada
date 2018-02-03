using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.CommonFunction
{
    public class InvokeUrl
    {
        public string ReturnJson(string controller, string function, string param)
        {
            string res = string.Empty;
            using (var client = new WebClient())
            {
                //testing
                client.Headers.Add("content-type", "application/json"); 
                if ((!string.IsNullOrEmpty(param)) || param != null)
                {
                    res = client.DownloadString("http://localhost/Persada.Fr.Web.Api/api/" + controller + "/" + function + "" + param);
                }
                else
                {
                    res = client.DownloadString("http://localhost/Persada.Fr.Web.Api/api/" + controller + "/" + function + "");
                }
            }
            return res;
        }
    }
}
