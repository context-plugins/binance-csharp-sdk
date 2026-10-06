namespace Binance.Requests.FuturesAlgo;

/// <summary>
/// The inputs of the QuerySubOrdersUserData operation.
/// </summary>
public sealed record QuerySubOrdersUserDataRequest
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
