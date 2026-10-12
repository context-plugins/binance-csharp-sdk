namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the QueryManagedSubAccountTransferLogForTradingTeamMasterAccount operation.
/// </summary>
public sealed record QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest
{
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
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Transfer Direction (FROM/TO)
    /// </summary>
    public string? Transfers { get; init; }

    /// <summary>
    /// Transfer function account type (SPOT/MARGIN/ISOLATED_MARGIN/USDT_FUTURE/COIN_FUTURE)
    /// </summary>
    public string? TransferFunctionAccountType { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
