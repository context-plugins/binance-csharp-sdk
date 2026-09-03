using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(ApiV3TickerPriceResponseConverter))]
public record ApiV3TickerPriceResponse
{
    private readonly Optional<PriceTicker> _priceTickerValue;

    private readonly Optional<IReadOnlyList<PriceTicker>> _listOfPriceTickerValue;

    private ApiV3TickerPriceResponse(Optional<PriceTicker> priceTickerValue,
        Optional<IReadOnlyList<PriceTicker>> listOfPriceTickerValue)
    {
        _priceTickerValue = priceTickerValue;
        _listOfPriceTickerValue = listOfPriceTickerValue;
    }

    public static ApiV3TickerPriceResponse PriceTicker(PriceTicker value) =>
        new(Optional<PriceTicker>.Some(value), default);

    public static ApiV3TickerPriceResponse ListOfPriceTicker(IReadOnlyList<PriceTicker> value) =>
        new(default, Optional<IReadOnlyList<PriceTicker>>.Some(value));

    public bool TryGetPriceTicker(out PriceTicker value) => _priceTickerValue.TryGetValue(out value);

    public bool TryGetListOfPriceTicker(out IReadOnlyList<PriceTicker> value) =>
        _listOfPriceTickerValue.TryGetValue(out value);

    public static implicit operator ApiV3TickerPriceResponse(PriceTicker value) => PriceTicker(value);
}

file sealed class ApiV3TickerPriceResponseConverter : JsonConverter<ApiV3TickerPriceResponse>
{
    public override ApiV3TickerPriceResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PriceTicker>(root, options, out var priceTickerValue))
        {
            return ApiV3TickerPriceResponse.PriceTicker(priceTickerValue);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<PriceTicker>>(root, options, out var listOfPriceTickerValue))
        {
            return ApiV3TickerPriceResponse.ListOfPriceTicker(listOfPriceTickerValue);
        }
        throw new JsonException($"JSON does not match PriceTicker or IReadOnlyList<PriceTicker> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ApiV3TickerPriceResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetPriceTicker(out var priceTickerValue))
        {
            JsonSerializer.Serialize(writer, priceTickerValue, options);
        }
        else if (value.TryGetListOfPriceTicker(out var listOfPriceTickerValue))
        {
            JsonSerializer.Serialize(writer, listOfPriceTickerValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ApiV3TickerPriceResponse)} contains no valid value to serialize.");
        }
    }
}
