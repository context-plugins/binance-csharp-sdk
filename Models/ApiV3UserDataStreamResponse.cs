using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record ApiV3UserDataStreamResponse
{
    [JsonPropertyName("listenKey")]
    public required string ListenKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
