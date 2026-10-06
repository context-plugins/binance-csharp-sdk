namespace Binance.Requests.SpotAlgo;

/// <summary>
/// The inputs of the CancelAlgoOrder operation.
/// </summary>
public sealed record CancelAlgoOrderRequest
{
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
