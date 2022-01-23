using HomeMonitor.DAL.Models;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMonitor.DAL.Services
{
    public class BasicInfoService
    {
        public BasicInfo GetBasicInfo()
        {
            var client = new RestClient("http://85.160.71.134:6999");
            client.Authenticator = new HttpBasicAuthenticator("api", "basicauth");
            var request = new RestRequest("TecoApi/GetObject?ApiSimple", Method.GET);
            IRestResponse<List<RootInfo>> response = client.Execute<List<RootInfo>>(request);
                        
            RootInfo rootInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<RootInfo>(response.Content);
            return rootInfo.ApiSimple;
        }
    }
}
