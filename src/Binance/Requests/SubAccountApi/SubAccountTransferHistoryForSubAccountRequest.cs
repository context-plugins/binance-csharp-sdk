namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the SubAccountTransferHistoryForSubAccount operation.
/// </summary>
public sealed record SubAccountTransferHistoryForSubAccountRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? Asset { get; init; }

    /// <summary>
    /// <list type="bullet">
    ///   <item><description><c>1</c> - transfer in</description></item>
    ///   <item><description><c>2</c> - transfer out</description></item>
    /// </list>
    /// </summary>
    public int? Type { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
