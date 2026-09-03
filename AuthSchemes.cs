using BinancePublicSpotApi.Core.Authentication;
using BinancePublicSpotApi.Core.Authentication.ApiKey;

namespace BinancePublicSpotApi;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKeyAuth { get; }

    public AuthSchemes(BinancePublicSpotApiClientOptions options)
    {
        ApiKeyAuth = ApiKeyHeaderScheme.Create("X-MBX-APIKEY", options.ApiKeyAuth);
    }
}
