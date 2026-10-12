using Binance.Models.Enums;

namespace Binance.Requests.C2C;

/// <summary>
/// The inputs of the GetC2CTradeHistoryUserData operation.
/// </summary>
public sealed record GetC2CTradeHistoryUserDataRequest
{
    public required TradeType TradeType { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTimestamp { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTimestamp { get; init; }

    /// <summary>
    /// Default 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// default 100, max 100
    /// </summary>
    public int? Rows { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
