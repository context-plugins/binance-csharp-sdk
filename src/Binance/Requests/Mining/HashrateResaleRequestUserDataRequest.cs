namespace Binance.Requests.Mining;

/// <summary>
/// The inputs of the HashrateResaleRequestUserData operation.
/// </summary>
public sealed record HashrateResaleRequestUserDataRequest
{
    /// <summary>
    /// Mining Account
    /// </summary>
    public required string UserName { get; init; }

    /// <summary>
    /// Algorithm(sha256)
    /// </summary>
    public required string Algo { get; init; }

    /// <summary>
    /// Mining Account
    /// </summary>
    public required string ToPoolUser { get; init; }

    /// <summary>
    /// Resale hashrate h/s must be transferred (BTC is greater than 500000000000 ETH is greater than 500000)
    /// </summary>
    public required string HashRate { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Search date, millisecond timestamp, while empty query all
    /// </summary>
    public string? StartDate { get; init; }

    /// <summary>
    /// Search date, millisecond timestamp, while empty query all
    /// </summary>
    public string? EndDate { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
