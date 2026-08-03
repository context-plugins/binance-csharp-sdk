using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Detail
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("assetFullName")]
    public required string AssetFullName { get; init; }

    /// <summary>
    /// Convertible amount
    /// </summary>
    [JsonPropertyName("amountFree")]
    public required string AmountFree { get; init; }

    /// <summary>
    /// BTC amount
    /// </summary>
    [JsonPropertyName("toBTC")]
    public required string ToBtc { get; init; }

    /// <summary>
    /// BNB amount(Not deducted commission fee
    /// </summary>
    [JsonPropertyName("toBNB")]
    public required string ToBnb { get; init; }

    /// <summary>
    /// BNB amount(Deducted commission fee
    /// </summary>
    [JsonPropertyName("toBNBOffExchange")]
    public required string ToBnboffExchange { get; init; }

    /// <summary>
    /// Commission fee
    /// </summary>
    [JsonPropertyName("exchange")]
    public required string Exchange { get; init; }
}
