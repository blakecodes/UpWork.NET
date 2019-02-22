using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using OAuth;
using UpWork.NET.Models;
using TinyOAuth1;

namespace UpWork.NET
{
    public class UpWorkClient
    {
        public ApiCredentials ApiCredentials { get; set; }
        private const string BaseUrl = "https://www.upwork.com";
        private const string TokenUrl = "https://www.upwork.com/api/auth/v1/oauth/token/request";
        private const string AccessTokenUrl = "https://www.upwork.com/api/auth/v1/oauth/token/access";
        private const string AuthorizeTokenUrl = "https://www.upwork.com/services/api/auth";

        /// <summary>
        /// Returns the request token and secret from UpWork
        /// </summary>
        /// <returns></returns>
        public async Task<TokenResponse> GetRequestToken()
        {
            TokenResponse tokenResponse = new TokenResponse();
            // Set up the basic config parameters
            var config = new TinyOAuthConfig
            {
                AccessTokenUrl = AccessTokenUrl,
                AuthorizeTokenUrl = AuthorizeTokenUrl,
                RequestTokenUrl = TokenUrl,
                ConsumerKey = ApiCredentials.ConsumerKey,
                ConsumerSecret = ApiCredentials.ConsumerSecret
            };

            // Use the library
            var tinyOAuth = new TinyOAuth(config);

            // Get the request token and request token secret
            tokenResponse.RequestToken = await tinyOAuth.GetRequestTokenAsync();
            tokenResponse.AuthorizationUrl = tinyOAuth.GetAuthorizationUrl(tokenResponse.RequestToken.RequestToken);

            return tokenResponse;
        }

        /// <summary>
        /// Get the users access token
        /// </summary>
        /// <param name="requestToken"></param>
        /// <param name="requestTokenSecret"></param>
        /// <param name="verificationCode"></param>
        /// <returns></returns>
        public async Task<AccessTokenInfo> GetAccessToken(string requestToken, string requestTokenSecret, string verificationCode)
        {
            // Set up the basic config parameters
            var config = new TinyOAuthConfig
            {
                AccessTokenUrl = AccessTokenUrl,
                AuthorizeTokenUrl = AuthorizeTokenUrl,
                RequestTokenUrl = TokenUrl,
                ConsumerKey = ApiCredentials.ConsumerKey,
                ConsumerSecret = ApiCredentials.ConsumerSecret
            };

            var tinyOAuth = new TinyOAuth(config);

            return await tinyOAuth.GetAccessTokenAsync(requestToken, requestTokenSecret, verificationCode);
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
