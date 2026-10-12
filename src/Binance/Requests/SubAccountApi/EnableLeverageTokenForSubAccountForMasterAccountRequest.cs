namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the EnableLeverageTokenForSubAccountForMasterAccount operation.
/// </summary>
public sealed record EnableLeverageTokenForSubAccountForMasterAccountRequest
{
    /// <summary>
    /// Sub-account email
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// Only true for now
    /// </summary>
    public required bool EnableBlvt { get; init; }

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
