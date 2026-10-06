namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount operation.
/// </summary>
public sealed record WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest
{
    /// <summary>
    /// Sender email
    /// </summary>
    public required string FromEmail { get; init; }

    public required string Asset { get; init; }

    public required double Amount { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Withdrawals is automatically occur on the transfer date(UTC0). If a date is not selected, the withdrawal occurs right now
    /// </summary>
    public long? TransferDate { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
