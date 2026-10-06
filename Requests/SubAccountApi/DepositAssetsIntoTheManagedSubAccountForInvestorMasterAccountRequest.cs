namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount operation.
/// </summary>
public sealed record DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest
{
    /// <summary>
    /// Recipient email
    /// </summary>
    public required string ToEmail { get; init; }

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
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
