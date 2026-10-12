using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record MarginTransferDetails
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
