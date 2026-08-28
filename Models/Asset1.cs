using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Asset1
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("marginBalance")]
    public required string MarginBalance { get; init; }

    [JsonPropertyName("walletBalance")]
    public required string WalletBalance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
