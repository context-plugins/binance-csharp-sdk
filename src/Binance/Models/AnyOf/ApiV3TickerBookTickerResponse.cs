using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Binance.Core.Extensions;
using Binance.Core.Models;

namespace Binance.Models.AnyOf;

[JsonConverter(typeof(ApiV3TickerBookTickerResponseConverter))]
public record ApiV3TickerBookTickerResponse
{
    private readonly Optional<BookTicker> _bookTickerValue;

    private readonly Optional<IReadOnlyList<BookTicker>> _listOfBookTickerValue;

    private ApiV3TickerBookTickerResponse(Optional<BookTicker> bookTickerValue,
        Optional<IReadOnlyList<BookTicker>> listOfBookTickerValue)
    {
        _bookTickerValue = bookTickerValue;
        _listOfBookTickerValue = listOfBookTickerValue;
    }

    public static ApiV3TickerBookTickerResponse BookTicker(BookTicker value) =>
        new(Optional<BookTicker>.Some(value), default);

    public static ApiV3TickerBookTickerResponse ListOfBookTicker(IReadOnlyList<BookTicker> value) =>
        new(default, Optional<IReadOnlyList<BookTicker>>.Some(value));

    public bool TryGetBookTicker(out BookTicker value) => _bookTickerValue.TryGetValue(out value);

    public bool TryGetListOfBookTicker(out IReadOnlyList<BookTicker> value) =>
        _listOfBookTickerValue.TryGetValue(out value);

    public static implicit operator ApiV3TickerBookTickerResponse(BookTicker value) => BookTicker(value);
}

file sealed class ApiV3TickerBookTickerResponseConverter : JsonConverter<ApiV3TickerBookTickerResponse>
{
    public override ApiV3TickerBookTickerResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<BookTicker>(root, options, out var bookTickerValue))
        {
            return ApiV3TickerBookTickerResponse.BookTicker(bookTickerValue);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<BookTicker>>(root, options, out var listOfBookTickerValue))
        {
            return ApiV3TickerBookTickerResponse.ListOfBookTicker(listOfBookTickerValue);
        }
        throw new JsonException(
            $"JSON does not match BookTicker or IReadOnlyList<BookTicker> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ApiV3TickerBookTickerResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetBookTicker(out var bookTickerValue))
        {
            JsonSerializer.Serialize(writer, bookTickerValue, options);
        }
        else if (value.TryGetListOfBookTicker(out var listOfBookTickerValue))
        {
            JsonSerializer.Serialize(writer, listOfBookTickerValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ApiV3TickerBookTickerResponse)} contains no valid value to serialize.");
        }
    }
}
