using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1PortfolioAssetCollectionResponse
{
    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
