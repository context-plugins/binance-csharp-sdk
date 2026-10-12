using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Transaction
{
    /// <summary>
    /// transaction id
    /// </summary>
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
