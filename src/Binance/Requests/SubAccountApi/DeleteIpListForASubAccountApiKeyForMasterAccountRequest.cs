namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the DeleteIpListForASubAccountApiKeyForMasterAccount operation.
/// </summary>
public sealed record DeleteIpListForASubAccountApiKeyForMasterAccountRequest
{
    /// <summary>
    /// Sub-account email
    /// </summary>
    public required string Email { get; init; }

    public required string SubAccountApiKey { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Can be added in batches, separated by commas
    /// </summary>
    public string? IpAddress { get; init; }

    /// <summary>
    /// third party IP list name
    /// </summary>
    public string? ThirdPartyName { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
