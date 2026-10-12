using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1ManagedSubaccountInfoResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("managerSubUserInfoVoList")]
    public required IReadOnlyList<ManagerSubUserInfoVoList> ManagerSubUserInfoVoList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
