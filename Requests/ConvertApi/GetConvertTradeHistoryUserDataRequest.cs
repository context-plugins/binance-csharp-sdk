namespace Binance.Requests.ConvertApi;

/// <summary>
/// The inputs of the GetConvertTradeHistoryUserData operation.
/// </summary>
public sealed record GetConvertTradeHistoryUserDataRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long EndTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// default 100, max 1000
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
