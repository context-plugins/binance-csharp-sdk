using Binance.Models.Enums;

namespace Binance.Requests.SimpleEarn;

/// <summary>
/// The inputs of the SubscribeLockedProductTrade operation.
/// </summary>
public sealed record SubscribeLockedProductTradeRequest
{
    public required string ProjectId { get; init; }

    public required double Amount { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// true or false, default true.
    /// </summary>
    public bool? AutoSubscribe { get; init; }

    /// <summary>
    /// SPOT,FUND,ALL, default SPOT
    /// </summary>
    public string? SourceAccount { get; init; }

    /// <summary>
    /// SPOT,FLEXIBLE, default FLEXIBLE
    /// </summary>
    public RedeemTo? RedeemTo { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
