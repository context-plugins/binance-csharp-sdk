using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginMaxTransferableResponse
{
    /// <summary>
    /// Account's currently max borrowable amount with sufficient system availability
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// Max borrowable amount limited by the account level
    /// </summary>
    [JsonPropertyName("borrowLimit")]
    public required string BorrowLimit { get; init; }
}
