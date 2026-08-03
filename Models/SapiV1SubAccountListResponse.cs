using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountListResponse
{
    [JsonPropertyName("subAccounts")]
    public required IReadOnlyList<SubAccount> SubAccounts { get; init; }
}
