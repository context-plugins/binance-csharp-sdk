using Binance.Models.Enums;

namespace Binance.Requests.DualInvestment;

/// <summary>
/// The inputs of the SubscribeDualInvestmentProductsUserData operation.
/// </summary>
public sealed record SubscribeDualInvestmentProductsUserDataRequest
{
    /// <summary>
    /// get id from /sapi/v1/dci/product/list
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// get orderId from /sapi/v1/dci/product/list
    /// </summary>
    public required string OrderId { get; init; }

    public required double DepositAmount { get; init; }

    /// <summary>
    /// NONE: switch off the plan,
    /// STANDARD: standard plan,
    /// ADVANCED: advanced plan;
    /// </summary>
    public required AutoCompoundPlan AutoCompoundPlan { get; init; }

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
