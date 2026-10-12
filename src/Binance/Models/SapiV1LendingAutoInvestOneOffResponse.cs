using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingAutoInvestOneOffResponse
{
    [JsonPropertyName("transactionId")]
    public required long TransactionId { get; init; }

    [JsonPropertyName("waitSecond")]
    public required int WaitSecond { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
