using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row41
{
    [JsonPropertyName("positionId")]
    public required string PositionId { get; init; }

    [JsonPropertyName("parentPositionId")]
    public required string ParentPositionId { get; init; }

    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("purchaseTime")]
    public required string PurchaseTime { get; init; }

    [JsonPropertyName("duration")]
    public required string Duration { get; init; }

    [JsonPropertyName("accrualDays")]
    public required string AccrualDays { get; init; }

    [JsonPropertyName("rewardAsset")]
    public required string RewardAsset { get; init; }

    [JsonPropertyName("APY")]
    public required string Apy { get; init; }

    /// <summary>
    /// Earned amount
    /// </summary>
    [JsonPropertyName("rewardAmt")]
    public required string RewardAmt { get; init; }

    /// <summary>
    /// Rewards assets of extra staking type
    /// </summary>
    [JsonPropertyName("extraRewardAsset")]
    public required string ExtraRewardAsset { get; init; }

    /// <summary>
    /// APR of extra staking type
    /// </summary>
    [JsonPropertyName("extraRewardAPR")]
    public required string ExtraRewardApr { get; init; }

    /// <summary>
    /// Rewards of extra staking type, distribute when order expires
    /// </summary>
    [JsonPropertyName("estExtraRewardAmt")]
    public required string EstExtraRewardAmt { get; init; }

    /// <summary>
    /// Next estimated rewards payment
    /// </summary>
    [JsonPropertyName("nextPay")]
    public required string NextPay { get; init; }

    /// <summary>
    /// Next rewards payment date
    /// </summary>
    [JsonPropertyName("nextPayDate")]
    public required string NextPayDate { get; init; }

    /// <summary>
    /// Payment cycle
    /// </summary>
    [JsonPropertyName("payPeriod")]
    public required string PayPeriod { get; init; }

    /// <summary>
    /// Early redemption amount
    /// </summary>
    [JsonPropertyName("redeemAmountEarly")]
    public required string RedeemAmountEarly { get; init; }

    /// <summary>
    /// Rewards accrual end date
    /// </summary>
    [JsonPropertyName("rewardsEndDate")]
    public required string RewardsEndDate { get; init; }

    /// <summary>
    /// Redemption arrival time
    /// </summary>
    [JsonPropertyName("deliverDate")]
    public required string DeliverDate { get; init; }

    /// <summary>
    /// Redemption interval
    /// </summary>
    [JsonPropertyName("redeemPeriod")]
    public required string RedeemPeriod { get; init; }

    /// <summary>
    /// Amount under redemption
    /// </summary>
    [JsonPropertyName("redeemingAmt")]
    public required string RedeemingAmt { get; init; }

    /// <summary>
    /// Redeem to Flexible product or Spot wallet
    /// </summary>
    [JsonPropertyName("redeemTo")]
    public required string RedeemTo { get; init; }

    /// <summary>
    /// Arrival time of partial redemption amount of order
    /// </summary>
    [JsonPropertyName("partialAmtDeliverDate")]
    public required string PartialAmtDeliverDate { get; init; }

    /// <summary>
    /// When it is true, early redemption can be operated
    /// </summary>
    [JsonPropertyName("canRedeemEarly")]
    public required bool CanRedeemEarly { get; init; }

    /// <summary>
    /// When it is true, fast redemption can be operated
    /// </summary>
    [JsonPropertyName("canFastRedemption")]
    public required bool CanFastRedemption { get; init; }

    /// <summary>
    /// When it is true, auto staking can be operated
    /// </summary>
    [JsonPropertyName("autoSubscribe")]
    public required bool AutoSubscribe { get; init; }

    /// <summary>
    /// Order type is auto subscribe or normal
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("canReStake")]
    public required bool CanReStake { get; init; }
}
