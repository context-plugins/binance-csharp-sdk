using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ManagedSubaccountInfoResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("managerSubUserInfoVoList")]
    public required IReadOnlyList<ManagerSubUserInfoVoList> ManagerSubUserInfoVoList { get; init; }
}
