namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the FetchDepositAddressListWithNetworkUserData operation.
/// </summary>
public sealed record FetchDepositAddressListWithNetworkUserDataRequest
{
    public required string Coin { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? Network { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
