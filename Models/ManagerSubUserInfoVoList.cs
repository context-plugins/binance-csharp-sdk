using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ManagerSubUserInfoVoList
{
    [JsonPropertyName("rootUserId")]
    public required long RootUserId { get; init; }

    [JsonPropertyName("managersubUserId")]
    public required long ManagersubUserId { get; init; }

    [JsonPropertyName("bindParentUserId")]
    public required long BindParentUserId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("insertTimeStamp")]
    public required long InsertTimeStamp { get; init; }

    [JsonPropertyName("bindParentEmail")]
    public required string BindParentEmail { get; init; }

    [JsonPropertyName("isSubUserEnabled")]
    public required bool IsSubUserEnabled { get; init; }

    [JsonPropertyName("isUserActive")]
    public required bool IsUserActive { get; init; }

    [JsonPropertyName("isMarginEnabled")]
    public required bool IsMarginEnabled { get; init; }

    [JsonPropertyName("isFutureEnabled")]
    public required bool IsFutureEnabled { get; init; }

    [JsonPropertyName("isSignedLVTRiskAgreement")]
    public required bool IsSignedLvtRiskAgreement { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
