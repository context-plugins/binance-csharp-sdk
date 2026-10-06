namespace Binance.Requests.AutoInvest;

/// <summary>
/// The inputs of the QueryOneTimeTransactionStatusUserData operation.
/// </summary>
public sealed record QueryOneTimeTransactionStatusUserDataRequest
{
    public required long TransactionId { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? RequestId { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
