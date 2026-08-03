using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestOneOffStatusResponse
{
    [JsonPropertyName("transactionId")]
    public required long TransactionId { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
