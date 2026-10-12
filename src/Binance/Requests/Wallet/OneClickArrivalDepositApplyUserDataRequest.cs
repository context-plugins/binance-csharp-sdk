namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the OneClickArrivalDepositApplyUserData operation.
/// </summary>
public sealed record OneClickArrivalDepositApplyUserDataRequest
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
    /// Deposit record Id, priority use
    /// </summary>
    public long? DepositId { get; init; }

    /// <summary>
    /// Deposit txId, used when depositId is not specified
    /// </summary>
    public string? TxId { get; init; }

    public long? SubAccountId { get; init; }

    public long? SubUserId { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
