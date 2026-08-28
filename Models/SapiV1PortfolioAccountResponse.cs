using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1PortfolioAccountResponse
{
    /// <summary>
    /// Classic Portfolio margin account maintenance margin rate
    /// </summary>
    [JsonPropertyName("uniMMR")]
    public required string UniMmr { get; init; }

    /// <summary>
    /// Account equity, unit is USD
    /// </summary>
    [JsonPropertyName("accountEquity")]
    public required string AccountEquity { get; init; }

    /// <summary>
    /// Actual equity, unit is USD
    /// </summary>
    [JsonPropertyName("actualEquity")]
    public required string ActualEquity { get; init; }

    /// <summary>
    /// Classic Portfolio margin account maintenance margin, unit is USD
    /// </summary>
    [JsonPropertyName("accountMaintMargin")]
    public required string AccountMaintMargin { get; init; }

    /// <summary>
    /// Classic Portfolio margin account status:"NORMAL", "MARGIN_CALL", "SUPPLY_MARGIN", "REDUCE_ONLY", "ACTIVE_LIQUIDATION", "FORCE_LIQUIDATION", "BANKRUPTED"
    /// </summary>
    [JsonPropertyName("accountStatus")]
    public required string AccountStatus { get; init; }

    /// <summary>
    /// PM_1 for classic PM, PM_2 for PM
    /// </summary>
    [JsonPropertyName("accountType")]
    public required string AccountType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
