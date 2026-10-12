using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SubAccountList1
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("totalMarginBalance")]
    public required string TotalMarginBalance { get; init; }

    [JsonPropertyName("totalUnrealizedProfit")]
    public required string TotalUnrealizedProfit { get; init; }

    [JsonPropertyName("totalWalletBalance")]
    public required string TotalWalletBalance { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
