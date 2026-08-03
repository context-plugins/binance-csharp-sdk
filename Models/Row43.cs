using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row43
{
    [JsonPropertyName("positionId")]
    public required string PositionId { get; init; }

    [JsonPropertyName("purchaseId")]
    public required long PurchaseId { get; init; }

    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("lockPeriod")]
    public required string LockPeriod { get; init; }

    /// <summary>
    /// NORMAL for normal subscription, AUTO for auto-subscription order, ACTIVITY for activity order, TRIAL for trial fund order, RESTAKE for restake order
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// SPOT, FUNDING, SPOTANDFUNDING
    /// </summary>
    [JsonPropertyName("sourceAccount")]
    public required string SourceAccount { get; init; }

    /// <summary>
    /// Display if sourceAccount is SPOTANDFUNDING
    /// </summary>
    [JsonPropertyName("amtFromSpot")]
    public required string AmtFromSpot { get; init; }

    /// <summary>
    /// Display if sourceAccount is SPOTANDFUNDING
    /// </summary>
    [JsonPropertyName("amtFromFunding")]
    public required string AmtFromFunding { get; init; }

    /// <summary>
    /// PURCHASING/SUCCESS/FAILED
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
