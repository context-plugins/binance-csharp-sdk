using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestOneOffResponse
{
    [JsonPropertyName("transactionId")]
    public required long TransactionId { get; init; }

    [JsonPropertyName("waitSecond")]
    public required int WaitSecond { get; init; }
}
