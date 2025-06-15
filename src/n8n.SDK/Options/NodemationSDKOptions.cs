using RestEase.Authentication.Options;

namespace n8n.SDK.Options;

[PublicAPI]
public class NodemationSDKOptions : AuthenticatedRestEaseOptions<INodemationApi>
{
    public NodemationSDKOptions()
    {
        BaseAddress = new("http://localhost:5678/api/v1");
        AuthenticationType = AuthenticationType.Header;
        HeaderName = "X-N8N-API-KEY";
    }
}