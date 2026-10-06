namespace Binance.Requests.SimpleEarn;

/// <summary>
/// The inputs of the SetLockedAutoSubscribeUserData operation.
/// </summary>
public sealed record SetLockedAutoSubscribeUserDataRequest
{
    public required string PositionId { get; init; }

    /// <summary>
    /// true or false
    /// </summary>
    public required bool AutoSubscribe { get; init; }

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
