namespace Binance.Requests.Nft;

/// <summary>
/// The inputs of the GetNftTransactionHistoryUserData operation.
/// </summary>
public sealed record GetNftTransactionHistoryUserDataRequest
{
    /// <summary>
    /// 0: purchase order, 1: sell order, 2: royalty income, 3: primary market order, 4: mint fee
    /// </summary>
    public required int OrderType { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Default 50, Max 50
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Default 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
