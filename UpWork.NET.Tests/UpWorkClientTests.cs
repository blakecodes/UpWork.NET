
namespace UpWork.NET.Tests;

[TestClass]
public class UpWorkClientTests : TestsBase
{
    private readonly UpWorkClient _upWorkClient;

    public UpWorkClientTests()
    {
        _upWorkClient = new UpWorkClient();
        _upWorkClient.SetAccessToken(Config.AccessToken); // Required for sending authenticated API requests
    }
    
    [TestMethod]
    public async Task ShouldGenerateAuthorizationUrl()
    {
        var uri = _upWorkClient.GetAuthorizationUrl(
            Config.ClientId, 
            "code", 
            Config.RedirectUri);
    }

    [TestMethod]
    public async Task ShouldGenerateAccessToken()
    {
        await _upWorkClient.GetAccessToken(
            "authorization_code", 
            Config.ClientId, 
            Config.ClientSecret,
            Config.RedirectUri,
            Config.AuthorizationCode);
    }

    [TestMethod]
    public async Task ShouldGetCurrentUserInfo()
    {
        var userInfo = await _upWorkClient.Users.GetCurrentUserInfo();
    }
}