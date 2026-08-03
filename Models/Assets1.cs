using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Assets1
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("initialMargin")]
    public required string InitialMargin { get; init; }

    [JsonPropertyName("maintenanceMargin")]
    public required string MaintenanceMargin { get; init; }

    [JsonPropertyName("marginBalance")]
    public required string MarginBalance { get; init; }

    [JsonPropertyName("maxWithdrawAmount")]
    public required string MaxWithdrawAmount { get; init; }

    [JsonPropertyName("openOrderInitialMargin")]
    public required string OpenOrderInitialMargin { get; init; }

    [JsonPropertyName("positionInitialMargin")]
    public required string PositionInitialMargin { get; init; }

    [JsonPropertyName("unrealizedProfit")]
    public required string UnrealizedProfit { get; init; }

    [JsonPropertyName("walletBalance")]
    public required string WalletBalance { get; init; }
}
