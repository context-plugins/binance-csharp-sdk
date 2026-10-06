namespace Binance.Requests.FuturesAlgo;

/// <summary>
/// The inputs of the CancelAlgoOrderTrade operation.
/// </summary>
public sealed record CancelAlgoOrderTradeRequest
{
    /// <summary>
    /// Eg. 14511
    /// </summary>
    public required long AlgoId { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
