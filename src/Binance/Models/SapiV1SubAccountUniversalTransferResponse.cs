using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SubAccountUniversalTransferResponse
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonPropertyName("fromEmail")]
    public required string FromEmail { get; init; }

    [JsonPropertyName("toEmail")]
    public required string ToEmail { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("fromAccountType")]
    public required string FromAccountType { get; init; }

    [JsonPropertyName("toAccountType")]
    public required string ToAccountType { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("createTimeStamp")]
    public required long CreateTimeStamp { get; init; }

    [JsonPropertyName("clientTranId")]
    public required string ClientTranId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
