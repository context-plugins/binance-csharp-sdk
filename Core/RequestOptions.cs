using Microsoft.Extensions.Logging;

namespace BinancePublicSpotApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
