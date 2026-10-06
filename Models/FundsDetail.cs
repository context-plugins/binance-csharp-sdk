using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record FundsDetail
{
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
