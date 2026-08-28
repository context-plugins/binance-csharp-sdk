using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1ManagedSubaccountWithdrawResponse
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
