namespace Binance.Requests.TradeApi;

/// <summary>
/// The inputs of the QueryOcoUserData operation.
/// </summary>
public sealed record QueryOcoUserDataRequest
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
    /// Order list id
    /// </summary>
    public long? OrderListId { get; init; }

    /// <summary>
    /// Order id from client
    /// </summary>
    public string? OrigClientOrderId { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
