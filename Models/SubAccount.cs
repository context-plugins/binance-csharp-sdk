using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SubAccount
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("isFreeze")]
    public required bool IsFreeze { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    [JsonPropertyName("isManagedSubAccount")]
    public required bool IsManagedSubAccount { get; init; }

    [JsonPropertyName("isAssetManagementSubAccount")]
    public required bool IsAssetManagementSubAccount { get; init; }
}
