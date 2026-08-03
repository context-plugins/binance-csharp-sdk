using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SubAccountCoinfuturesDetails
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("assets")]
    public required IReadOnlyList<Asset2> Assets { get; init; }

    [JsonPropertyName("canDeposit")]
    public required bool CanDeposit { get; init; }

    [JsonPropertyName("canTrade")]
    public required bool CanTrade { get; init; }

    [JsonPropertyName("canWithdraw")]
    public required bool CanWithdraw { get; init; }

    [JsonPropertyName("feeTier")]
    public required long FeeTier { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }
}
