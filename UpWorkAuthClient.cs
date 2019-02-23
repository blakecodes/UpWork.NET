using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using OAuth;
using UpWork.NET.Models;

namespace UpWork.NET
{
    public class UpworkAuthClient
    {
        private const string Endpoint = "https://www.upwork.com/api";
        public ApiCredentials ApiCredentials { get; set; }
        public AccessCredentials AccessCredentials { get; set; }

        public async Task<string> Get(string requestUrl)
        {
            var authHead = OAuthRequest.ForProtectedResource("GET", ApiCredentials.ConsumerKey, ApiCredentials.ConsumerSecret,
                AccessCredentials.AccessToken, AccessCredentials.AccessTokenSecret);

            authHead.RequestUrl = Endpoint + requestUrl;

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", authHead.GetAuthorizationHeader());

            var req = await httpClient.GetAsync(authHead.RequestUrl);
            return await req.Content.ReadAsStringAsync();
        }

        public void Post()
        {

        }




        //public void ExampleRequest()
        //{
        //    var authHead = OAuthRequest.ForProtectedResource("GET", ApiCredentials.ConsumerKey, ApiCredentials.ConsumerSecret,
        //        accessTokenInfo.AccessToken, accessTokenInfo.AccessTokenSecret);
        //    authHead.RequestUrl = "https://www.upwork.com/api/auth/v1/info.json";

        //    HttpClient checkClient = new HttpClient();
        //    checkClient.DefaultRequestHeaders.Add("Authorization", authHead.GetAuthorizationHeader());

        //    var req = await checkClient.GetAsync("https://www.upwork.com/api/auth/v1/info.json");
        //    var res = await req.Content.ReadAsStringAsync();
        //}
    }
}
