using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginOrderOtoResponse
{
    [JsonPropertyName("orderListId")]
    public required long OrderListId { get; init; }

    [JsonPropertyName("contingencyType")]
    public required string ContingencyType { get; init; }

    [JsonPropertyName("listStatusType")]
    public required string ListStatusType { get; init; }

    [JsonPropertyName("listOrderStatus")]
    public required string ListOrderStatus { get; init; }

    [JsonPropertyName("listClientOrderId")]
    public required string ListClientOrderId { get; init; }

    [JsonPropertyName("transactionTime")]
    public required long TransactionTime { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("isIsolated")]
    public required bool IsIsolated { get; init; }

    [JsonPropertyName("orders")]
    public required IReadOnlyList<Order1> Orders { get; init; }

    [JsonPropertyName("orderReports")]
    public required IReadOnlyList<OrderReport6> OrderReports { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
