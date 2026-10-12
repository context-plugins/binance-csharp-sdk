using System.Collections.Generic;
using Binance.Models;
using Binance.Models.Enums;

namespace Binance.Requests.AutoInvest;

/// <summary>
/// The inputs of the InvestmentPlanCreationUserData operation.
/// </summary>
public sealed record InvestmentPlanCreationUserDataRequest
{
    public required SourceType SourceType { get; init; }

    public required PlanType PlanType { get; init; }

    public required double SubscriptionAmount { get; init; }

    public required SubscriptionCycle SubscriptionCycle { get; init; }

    public required int SubscriptionStartTime { get; init; }

    public required string SourceAsset { get; init; }

    public required IReadOnlyList<Detail1> Details { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? RequestId { get; init; }

    public long? IndexId { get; init; }

    public int? SubscriptionStartDay { get; init; }

    public SubscriptionStartWeekday? SubscriptionStartWeekday { get; init; }

    public bool? FlexibleAllowedToUse { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
