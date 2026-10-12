using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Binance.Core.Hooks;

namespace Binance.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
