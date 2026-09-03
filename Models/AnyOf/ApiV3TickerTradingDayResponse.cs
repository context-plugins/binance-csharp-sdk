using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(ApiV3TickerTradingDayResponseConverter))]
public record ApiV3TickerTradingDayResponse
{
    private readonly Optional<DayTicker> _dayTickerValue;

    private readonly Optional<IReadOnlyList<DayTicker>> _listOfDayTickerValue;

    private ApiV3TickerTradingDayResponse(Optional<DayTicker> dayTickerValue,
        Optional<IReadOnlyList<DayTicker>> listOfDayTickerValue)
    {
        _dayTickerValue = dayTickerValue;
        _listOfDayTickerValue = listOfDayTickerValue;
    }

    public static ApiV3TickerTradingDayResponse DayTicker(DayTicker value) =>
        new(Optional<DayTicker>.Some(value), default);

    public static ApiV3TickerTradingDayResponse ListOfDayTicker(IReadOnlyList<DayTicker> value) =>
        new(default, Optional<IReadOnlyList<DayTicker>>.Some(value));

    public bool TryGetDayTicker(out DayTicker value) => _dayTickerValue.TryGetValue(out value);

    public bool TryGetListOfDayTicker(out IReadOnlyList<DayTicker> value) =>
        _listOfDayTickerValue.TryGetValue(out value);

    public static implicit operator ApiV3TickerTradingDayResponse(DayTicker value) => DayTicker(value);
}

file sealed class ApiV3TickerTradingDayResponseConverter : JsonConverter<ApiV3TickerTradingDayResponse>
{
    public override ApiV3TickerTradingDayResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DayTicker>(root, options, out var dayTickerValue))
        {
            return ApiV3TickerTradingDayResponse.DayTicker(dayTickerValue);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<DayTicker>>(root, options, out var listOfDayTickerValue))
        {
            return ApiV3TickerTradingDayResponse.ListOfDayTicker(listOfDayTickerValue);
        }
        throw new JsonException($"JSON does not match DayTicker or IReadOnlyList<DayTicker> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ApiV3TickerTradingDayResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetDayTicker(out var dayTickerValue))
        {
            JsonSerializer.Serialize(writer, dayTickerValue, options);
        }
        else if (value.TryGetListOfDayTicker(out var listOfDayTickerValue))
        {
            JsonSerializer.Serialize(writer, listOfDayTickerValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ApiV3TickerTradingDayResponse)} contains no valid value to serialize.");
        }
    }
}
