using System.Collections.Generic;
using BinancePublicSpotApi.Core.Configuration;
using BinancePublicSpotApi.Core.Hooks;
using BinancePublicSpotApi.Servers;

namespace BinancePublicSpotApi;

public class BinancePublicSpotApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    /// <summary>
    /// Binance Public API Key
    /// </summary>
    public string? ApiKeyAuth { get; set; }
}
