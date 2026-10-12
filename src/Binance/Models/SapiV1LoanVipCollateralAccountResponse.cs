using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LoanVipCollateralAccountResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row14> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
