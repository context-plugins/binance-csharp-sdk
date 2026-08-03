using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data8
{
    [JsonPropertyName("orderNo")]
    public required string OrderNo { get; init; }

    /// <summary>
    /// Fiat trade amount
    /// </summary>
    [JsonPropertyName("sourceAmount")]
    public required string SourceAmount { get; init; }

    /// <summary>
    /// Fiat token
    /// </summary>
    [JsonPropertyName("fiatCurrency")]
    public required string FiatCurrency { get; init; }

    /// <summary>
    /// Crypto trade amount
    /// </summary>
    [JsonPropertyName("obtainAmount")]
    public required string ObtainAmount { get; init; }

    /// <summary>
    /// Crypto token
    /// </summary>
    [JsonPropertyName("cryptoCurrency")]
    public required string CryptoCurrency { get; init; }

    /// <summary>
    /// Trade fee
    /// </summary>
    [JsonPropertyName("totalFee")]
    public required string TotalFee { get; init; }

    [JsonPropertyName("price")]
    public required string Price { get; init; }

    /// <summary>
    /// Processing, Completed, Failed, Refunded
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }
}
