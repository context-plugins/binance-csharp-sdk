namespace Binance.Requests.Mining;

/// <summary>
/// The inputs of the StatisticListUserData operation.
/// </summary>
public sealed record StatisticListUserDataRequest
{
    /// <summary>
    /// Algorithm(sha256)
    /// </summary>
    public required string Algo { get; init; }

    /// <summary>
    /// Mining Account
    /// </summary>
    public required string UserName { get; init; }

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
