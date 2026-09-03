using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountTransferSubUserHistoryResponse
{
    [JsonPropertyName("counterParty")]
    public required string CounterParty { get; init; }

    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// 1 for transfer in, 2 for transfer out
    /// </summary>
    [JsonPropertyName("type")]
    public required int Type { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("qty")]
    public required string Qty { get; init; }

    [JsonPropertyName("fromAccountType")]
    public required string FromAccountType { get; init; }

    [JsonPropertyName("toAccountType")]
    public required string ToAccountType { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
