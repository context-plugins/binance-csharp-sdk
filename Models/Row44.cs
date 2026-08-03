using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row44
{
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    [JsonPropertyName("redeemId")]
    public required long RedeemId { get; init; }

    /// <summary>
    /// SPOT, FUNDING
    /// </summary>
    [JsonPropertyName("destAccount")]
    public required string DestAccount { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
