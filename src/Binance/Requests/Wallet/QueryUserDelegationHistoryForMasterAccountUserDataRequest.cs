namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the QueryUserDelegationHistoryForMasterAccountUserData operation.
/// </summary>
public sealed record QueryUserDelegationHistoryForMasterAccountUserDataRequest
{
    public required string Email { get; init; }

    public required long StartTime { get; init; }

    public required long EndTime { get; init; }

    public required string Asset { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? Type { get; init; }

    /// <summary>
    /// Current querying page. Start from 1. Default:1
    /// </summary>
    public int? Current { get; init; }

    /// <summary>
    /// Default:10 Max:100
    /// </summary>
    public int? Size { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
