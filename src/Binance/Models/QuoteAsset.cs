using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record QuoteAsset
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("borrowEnabled")]
    public required bool BorrowEnabled { get; init; }

    [JsonPropertyName("borrowed")]
    public required string Borrowed { get; init; }

    [JsonPropertyName("free")]
    public required string Free { get; init; }

    [JsonPropertyName("interest")]
    public required string Interest { get; init; }

    [JsonPropertyName("locked")]
    public required string Locked { get; init; }

    [JsonPropertyName("netAsset")]
    public required string NetAsset { get; init; }

    [JsonPropertyName("netAssetOfBtc")]
    public required string NetAssetOfBtc { get; init; }

    [JsonPropertyName("repayEnabled")]
    public required bool RepayEnabled { get; init; }

    [JsonPropertyName("totalAsset")]
    public required string TotalAsset { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
