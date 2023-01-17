using Newtonsoft.Json;

namespace UpWork.NET.Tests.Models;

public class UnitTestConfig
{
    [JsonProperty("RedirectUri")]
    public string RedirectUri { get; set; }

    [JsonProperty("ClientId")]
    public string ClientId { get; set; }

    [JsonProperty("ClientSecret")]
    public string ClientSecret { get; set; }

    [JsonProperty("AuthorizationCode")]
    public string AuthorizationCode { get; set; }

    [JsonProperty("AccessToken")]
    public string AccessToken { get; set; }
}