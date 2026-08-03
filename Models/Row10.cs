using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row10
{
    [JsonPropertyName("clientTranId")]
    public required string ClientTranId { get; init; }

    [JsonPropertyName("transferType")]
    public required string TransferType { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }
}
