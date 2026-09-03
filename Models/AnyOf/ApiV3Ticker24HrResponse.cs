using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(ApiV3Ticker24HrResponseConverter))]
public record ApiV3Ticker24HrResponse
{
    private readonly Optional<Ticker> _tickerValue;

    private readonly Optional<IReadOnlyList<Ticker>> _listOfTickerValue;

    private ApiV3Ticker24HrResponse(Optional<Ticker> tickerValue, Optional<IReadOnlyList<Ticker>> listOfTickerValue)
    {
        _tickerValue = tickerValue;
        _listOfTickerValue = listOfTickerValue;
    }

    public static ApiV3Ticker24HrResponse Ticker(Ticker value) =>
        new(Optional<Ticker>.Some(value), default);

    public static ApiV3Ticker24HrResponse ListOfTicker(IReadOnlyList<Ticker> value) =>
        new(default, Optional<IReadOnlyList<Ticker>>.Some(value));

    public bool TryGetTicker(out Ticker value) => _tickerValue.TryGetValue(out value);

    public bool TryGetListOfTicker(out IReadOnlyList<Ticker> value) =>
        _listOfTickerValue.TryGetValue(out value);

    public static implicit operator ApiV3Ticker24HrResponse(Ticker value) => Ticker(value);
}

file sealed class ApiV3Ticker24HrResponseConverter : JsonConverter<ApiV3Ticker24HrResponse>
{
    public override ApiV3Ticker24HrResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Ticker>(root, options, out var tickerValue))
        {
            return ApiV3Ticker24HrResponse.Ticker(tickerValue);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<Ticker>>(root, options, out var listOfTickerValue))
        {
            return ApiV3Ticker24HrResponse.ListOfTicker(listOfTickerValue);
        }
        throw new JsonException($"JSON does not match Ticker or IReadOnlyList<Ticker> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ApiV3Ticker24HrResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetTicker(out var tickerValue))
        {
            JsonSerializer.Serialize(writer, tickerValue, options);
        }
        else if (value.TryGetListOfTicker(out var listOfTickerValue))
        {
            JsonSerializer.Serialize(writer, listOfTickerValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ApiV3Ticker24HrResponse)} contains no valid value to serialize.");
        }
    }
}
