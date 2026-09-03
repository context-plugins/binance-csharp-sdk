using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ReceiverInfo
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("binanceId")]
    public required string BinanceId { get; init; }

    [JsonPropertyName("accountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; init; }

    [JsonPropertyName("phoneNumber")]
    public required string PhoneNumber { get; init; }

    [JsonPropertyName("mobileCode")]
    public required string MobileCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extend")]
    public IReadOnlyList<Extend>? Extend { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
