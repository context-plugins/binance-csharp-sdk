namespace Binance.Requests.ConvertApi;

/// <summary>
/// The inputs of the OrderStatusUserData operation.
/// </summary>
public sealed record OrderStatusUserDataRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? OrderId { get; init; }

    public string? QuoteId { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
