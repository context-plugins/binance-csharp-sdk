using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record ManagerSubTransferHistoryVo2
{
    [JsonPropertyName("fromEmail")]
    public required string FromEmail { get; init; }

    [JsonPropertyName("fromAccountType")]
    public required string FromAccountType { get; init; }

    [JsonPropertyName("toEmail")]
    public required string ToEmail { get; init; }

    [JsonPropertyName("toAccountType")]
    public required string ToAccountType { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("scheduledData")]
    public required long ScheduledData { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
