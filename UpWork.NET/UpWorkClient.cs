using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using TinyOAuth1;
using UpWork.NET.Clients;

namespace UpWork.NET;

public class UpWorkClient
{
    private readonly HttpClient _httpClient;

    public readonly UserClient Users;

    private const string BaseUrl = "https://www.upwork.com";
    private const string AuthorizationRequestBaseUrl = "https://www.upwork.com/ab/account-security/oauth2/authorize";
    private const string AccessTokenRequestBaseUrl = "https://www.upwork.com/api/v3/oauth2/token";
    private string AccessToken;

    public UpWorkClient()
    {
        _httpClient = new HttpClient();
        Users = new UserClient(this);
    }
    
    /// <summary>
    /// Generates a URL to redirect users to allow the app to interact with their account.
    /// </summary>
    /// <param name="clientId">UpWork client ID</param>
    /// <param name="responseType"></param>
    /// <param name="redirectUrl">URL that the authorization code will be provided to</param>
    /// <returns>string - URI for the user to authenticate their profile</returns>
    public Uri GetAuthorizationUrl(string clientId, string responseType, string redirectUrl)
    {
        var parameters = new Dictionary<string, string>()
        {
            { "client_id", clientId },
            { "response_type", responseType },
            { "redirect_url", redirectUrl },
        };
        
        return new Uri(QueryHelpers.AddQueryString(AuthorizationRequestBaseUrl, parameters));
    }

    /// <summary>
    /// Sends a request to get an access token from the OAuth Client
    /// </summary>
    /// <param name="grantType">authorization_code - only supported</param>
    /// <param name="clientId">UpWork client ID</param>
    /// <param name="clientSecret">UpWork client secret</param>
    /// <param name="redirectUri">URL used for redirects</param>
    /// <param name="code">Code generated from the GetAuthorizationUrl request after they have authenticated through the OAuth app</param>
    /// <returns></returns>
    public async Task<AccessTokenInfo> GetAccessToken(string grantType, string clientId, string clientSecret, string redirectUri, string code)
    {
        var values = new Dictionary<string, string>
        {
            { "grant_type", grantType },
            { "client_id", clientId },
            { "client_secret", clientSecret },
            { "redirect_uri", redirectUri },
            { "code", code }
        };

        var content = new FormUrlEncodedContent(values);

        var response = await _httpClient.PostAsync(AccessTokenRequestBaseUrl, content);

        var responseString = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<AccessTokenInfo>(responseString);
    }

    /// <summary>
    /// Sets the access token
    /// </summary>
    /// <param name="accessToken"></param>
    public void SetAccessToken(string accessToken)
    {
        AccessToken = accessToken;
        
        SetAuthentication();
    }

    /// <summary>
    /// Sets the authorization bearer header with an access token
    /// </summary>
    private void SetAuthentication()
    {
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {AccessToken}");
    }

    /// <summary>
    /// Sends an authenticated get request
    /// </summary>
    /// <param name="path"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    protected internal async Task<T> Get<T>(string path)
    {
        _httpClient.BaseAddress = new Uri(BaseUrl);
        var req = await _httpClient.GetAsync(path);
        var res = await req.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<T>(res);
    }
} 