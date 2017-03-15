using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using VlaamsOnderwijs.ef;
using Windows.Data.Json;

namespace VlaamsOnderwijs.DAL
{
    public class APIRequest
    {
        public async System.Threading.Tasks.Task<string> getResponse(string variable)
        {
            Uri geturi = new Uri("http://localhost:8080/" + variable);
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            System.Net.Http.HttpResponseMessage responseGet = await client.GetAsync(geturi);
            string response = await responseGet.Content.ReadAsStringAsync();
            
            return response;
        }

        //internal void sendRequest(JsonObject jsonObject)
        //{
        //    url = "http://localhost:8080/";
        //    string responseJson;

        //    WebClient wrGETURL = new WebClient();
        //    wrGETURL.Headers[HttpRequestHeader.ContentType] = "application/json";

        //    WebProxy myProxy = new WebProxy("myproxy", 80);
        //    myProxy.BypassProxyOnLocal = true;

        //    responseJson = wrGETURL.UploadString(url, "PUT", JsonParser.Serialize<Hulpverlener>(hulpverlener));
        //}
    }
}
