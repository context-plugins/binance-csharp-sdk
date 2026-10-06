using System.Collections.Generic;
using Binance.Models;
using Binance.Models.Enums;

namespace Binance.Requests.AutoInvest;

/// <summary>
/// The inputs of the InvestmentPlanAdjustment operation.
/// </summary>
public sealed record InvestmentPlanAdjustmentRequest
{
    public required int PlanId { get; init; }

    public required double SubscriptionAmount { get; init; }

    public required SubscriptionCycle SubscriptionCycle { get; init; }

    public required int SubscriptionStartTime { get; init; }

    public required string SourceAsset { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public int? SubscriptionStartDay { get; init; }

    public SubscriptionStartWeekday? SubscriptionStartWeekday { get; init; }

    public bool? FlexibleAllowedToUse { get; init; }

    public IReadOnlyList<Detail1>? Details { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
