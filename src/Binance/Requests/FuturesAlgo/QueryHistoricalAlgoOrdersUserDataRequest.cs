using Binance.Models.Enums;

namespace Binance.Requests.FuturesAlgo;

/// <summary>
/// The inputs of the QueryHistoricalAlgoOrdersUserData operation.
/// </summary>
public sealed record QueryHistoricalAlgoOrdersUserDataRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public string? Symbol { get; init; }

    public Side? Side { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Default 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// MIN 1, MAX 100; Default 100
    /// </summary>
    public string? PageSize { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
