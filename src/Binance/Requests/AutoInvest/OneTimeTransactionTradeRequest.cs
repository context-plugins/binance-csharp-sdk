using System.Collections.Generic;
using Binance.Models;

namespace Binance.Requests.AutoInvest;

/// <summary>
/// The inputs of the OneTimeTransactionTrade operation.
/// </summary>
public sealed record OneTimeTransactionTradeRequest
{
    public required string SourceType { get; init; }

    public required double SubscriptionAmount { get; init; }

    public required string SourceAsset { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? RequestId { get; init; }

    public bool? FlexibleAllowedToUse { get; init; }

    public long? PlanId { get; init; }

    public long? IndexId { get; init; }

    public IReadOnlyList<Detail5>? Details { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
