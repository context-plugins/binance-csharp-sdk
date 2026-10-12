using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data21
{
    [JsonPropertyName("orderNumber")]
    public required string OrderNumber { get; init; }

    [JsonPropertyName("advNo")]
    public required string AdvNo { get; init; }

    [JsonPropertyName("tradeType")]
    public required string TradeType { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("fiat")]
    public required string Fiat { get; init; }

    [JsonPropertyName("fiatSymbol")]
    public required string FiatSymbol { get; init; }

    /// <summary>
    /// Quantity (in Crypto)
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("totalPrice")]
    public required string TotalPrice { get; init; }

    /// <summary>
    /// Unit Price (in Fiat)
    /// </summary>
    [JsonPropertyName("unitPrice")]
    public required string UnitPrice { get; init; }

    /// <summary>
    /// PENDING, TRADING, BUYER_PAYED, DISTRIBUTING, COMPLETED, IN_APPEAL, CANCELLED, CANCELLED_BY_SYSTEM
    /// </summary>
    [JsonPropertyName("orderStatus")]
    public required string OrderStatus { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    /// <summary>
    /// Transaction Fee (in Crypto)
    /// </summary>
    [JsonPropertyName("commission")]
    public required string Commission { get; init; }

    [JsonPropertyName("counterPartNickName")]
    public required string CounterPartNickName { get; init; }

    [JsonPropertyName("advertisementRole")]
    public required string AdvertisementRole { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
