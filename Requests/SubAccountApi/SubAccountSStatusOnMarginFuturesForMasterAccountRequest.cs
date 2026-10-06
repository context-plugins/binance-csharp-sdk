namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the SubAccountSStatusOnMarginFuturesForMasterAccount operation.
/// </summary>
public sealed record SubAccountSStatusOnMarginFuturesForMasterAccountRequest
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
    /// Sub-account email
    /// </summary>
    public string? Email { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
