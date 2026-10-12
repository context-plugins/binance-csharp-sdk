using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record ConfigDetail
{
    /// <summary>
    /// Mining ID
    /// </summary>
    [JsonPropertyName("configId")]
    public required long ConfigId { get; init; }

    /// <summary>
    /// Transfer out of subaccount
    /// </summary>
    [JsonPropertyName("poolUsername")]
    public required string PoolUsername { get; init; }

    /// <summary>
    /// Transfer into subaccount
    /// </summary>
    [JsonPropertyName("toPoolUsername")]
    public required string ToPoolUsername { get; init; }

    /// <summary>
    /// Transfer algorithm
    /// </summary>
    [JsonPropertyName("algoName")]
    public required string AlgoName { get; init; }

    /// <summary>
    /// Transferred Hashrate quantity
    /// </summary>
    [JsonPropertyName("hashRate")]
    public required long HashRate { get; init; }

    /// <summary>
    /// Start date
    /// </summary>
    [JsonPropertyName("startDay")]
    public required long StartDay { get; init; }

    /// <summary>
    /// End date
    /// </summary>
    [JsonPropertyName("endDay")]
    public required long EndDay { get; init; }

    /// <summary>
    /// 0 Processing, 1：Cancelled, 2：Terminated
    /// </summary>
    [JsonPropertyName("status")]
    public required int Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
