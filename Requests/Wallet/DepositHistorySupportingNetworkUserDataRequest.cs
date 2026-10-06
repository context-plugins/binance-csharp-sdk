namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the DepositHistorySupportingNetworkUserData operation.
/// </summary>
public sealed record DepositHistorySupportingNetworkUserDataRequest
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
    /// Coin name
    /// </summary>
    public string? Coin { get; init; }

    /// <summary>
    /// <list type="bullet">
    ///   <item><description><c>0</c> - pending</description></item>
    ///   <item><description><c>6</c> - credited but cannot withdraw</description></item>
    ///   <item><description><c>1</c> - success</description></item>
    /// </list>
    /// </summary>
    public int? Status { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    public int? Offset { get; init; }

    /// <summary>
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
