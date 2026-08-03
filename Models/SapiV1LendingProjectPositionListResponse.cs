using System;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingProjectPositionListResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("canTransfer")]
    public required bool CanTransfer { get; init; }

    [JsonPropertyName("createTimestamp")]
    public required long CreateTimestamp { get; init; }

    [JsonPropertyName("duration")]
    public required long Duration { get; init; }

    [JsonPropertyName("endTime")]
    public required long EndTime { get; init; }

    [JsonPropertyName("interest")]
    public required string Interest { get; init; }

    [JsonPropertyName("interestRate")]
    public required string InterestRate { get; init; }

    [JsonPropertyName("lot")]
    public required long Lot { get; init; }

    [JsonPropertyName("positionId")]
    public required long PositionId { get; init; }

    [JsonPropertyName("principal")]
    public required string Principal { get; init; }

    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    [JsonPropertyName("projectName")]
    public required string ProjectName { get; init; }

    [JsonPropertyName("purchaseTime")]
    public required long PurchaseTime { get; init; }

    [JsonPropertyName("redeemDate")]
    public required DateTimeOffset RedeemDate { get; init; }

    [JsonPropertyName("startTime")]
    public required long StartTime { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
