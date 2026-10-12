namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the SubAccountDepositHistoryForMasterAccount operation.
/// </summary>
public sealed record SubAccountDepositHistoryForMasterAccountRequest
{
    /// <summary>
    /// Sub-account email
    /// </summary>
    public required string Email { get; init; }

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
    /// 0(0:pending,6: credited but cannot withdraw, 1:success)
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

    public long? Limit { get; init; }

    public int? Offset { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
