using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using BinancePublicSpotApi.Core.Hooks;

namespace BinancePublicSpotApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
