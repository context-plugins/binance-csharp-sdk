using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row8
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonPropertyName("type")]
    public required long Type { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("deductedAsset")]
    public required string DeductedAsset { get; init; }

    [JsonPropertyName("deductedAmount")]
    public required string DeductedAmount { get; init; }

    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    [JsonPropertyName("targetAmount")]
    public required string TargetAmount { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("accountType")]
    public required string AccountType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
