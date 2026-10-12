using Binance.Core.Authentication;
using Binance.Core.Authentication.ApiKey;

namespace Binance;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKeyAuth { get; }

    public AuthSchemes(BinanceClientOptions options)
    {
        ApiKeyAuth = ApiKeyHeaderScheme.Create("X-MBX-APIKEY", options.ApiKeyAuth);
    }
}
