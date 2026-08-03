using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Transaction
{
    /// <summary>
    /// transaction id
    /// </summary>
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }
}
