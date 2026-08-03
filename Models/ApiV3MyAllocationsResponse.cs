using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record ApiV3MyAllocationsResponse
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("allocationId")]
    public required long AllocationId { get; init; }

    [JsonPropertyName("allocationType")]
    public required string AllocationType { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("orderListId")]
    public required long OrderListId { get; init; }

    [JsonPropertyName("price")]
    public required string Price { get; init; }

    [JsonPropertyName("qty")]
    public required string Qty { get; init; }

    [JsonPropertyName("quoteQty")]
    public required string QuoteQty { get; init; }

    [JsonPropertyName("commission")]
    public required string Commission { get; init; }

    [JsonPropertyName("commissionAsset")]
    public required string CommissionAsset { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("isBuyer")]
    public required bool IsBuyer { get; init; }

    [JsonPropertyName("isMaker")]
    public required bool IsMaker { get; init; }

    [JsonPropertyName("isAllocator")]
    public required bool IsAllocator { get; init; }
}
