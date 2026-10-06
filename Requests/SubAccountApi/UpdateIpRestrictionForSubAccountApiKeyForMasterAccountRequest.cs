namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the UpdateIpRestrictionForSubAccountApiKeyForMasterAccount operation.
/// </summary>
public sealed record UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest
{
    /// <summary>
    /// Sub-account email
    /// </summary>
    public required string Email { get; init; }

    public required string SubAccountApiKey { get; init; }

    /// <summary>
    /// IP Restriction status. 1 = IP Unrestricted. 2 = Restrict access to trusted IPs only. 3 = Restrict access to users' trusted third party IPs only
    /// </summary>
    public required string Status { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// third party IP list name
    /// </summary>
    public string? ThirdPartyName { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
