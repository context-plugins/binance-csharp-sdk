namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the SubAccountFuturesAssetTransferHistoryForMasterAccount operation.
/// </summary>
public sealed record SubAccountFuturesAssetTransferHistoryForMasterAccountRequest
{
    /// <summary>
    /// Sub-account email
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// 1:USDT-margined Futures, 2: Coin-margined Futures
    /// </summary>
    public required int FuturesType { get; init; }

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
    /// Default 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Default value: 50, Max value: 500
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
