using System.Threading.Tasks;
using UpWork.NET.Responses.API;

namespace UpWork.NET.Clients;

public class UserClient
{
    private readonly UpWorkClient _upWorkClient;

    public UserClient(UpWorkClient upWorkClient)
    {
        _upWorkClient = upWorkClient;
    }
    
    /// <summary>
    /// This API call returns detailed information about the currently authenticated user.
    /// </summary>
    /// <returns></returns>
    public async Task<GetApiUserResponse> GetCurrentUserInfo()
    {
        return await _upWorkClient.Get<GetApiUserResponse>("/api/auth/v1/info.json");
    }
}