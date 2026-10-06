namespace Binance.Requests.Mining;

/// <summary>
/// The inputs of the HashrateResaleListUserData operation.
/// </summary>
public sealed record HashrateResaleListUserDataRequest
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
    /// Page number, default is first page, start form 1
    /// </summary>
    public int? PageIndex { get; init; }

    /// <summary>
    /// Number of pages, minimum 10, maximum 200
    /// </summary>
    public string? PageSize { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
