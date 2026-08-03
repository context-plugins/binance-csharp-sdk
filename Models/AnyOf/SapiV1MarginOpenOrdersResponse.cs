using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(SapiV1MarginOpenOrdersResponseConverter))]
public record SapiV1MarginOpenOrdersResponse
{
    private readonly Optional<CanceledMarginOrderDetail> _canceledMarginOrderDetailValue;

    private readonly Optional<MarginOcoOrder> _marginOcoOrderValue;

    private SapiV1MarginOpenOrdersResponse(Optional<CanceledMarginOrderDetail> canceledMarginOrderDetailValue,
        Optional<MarginOcoOrder> marginOcoOrderValue)
    {
        _canceledMarginOrderDetailValue = canceledMarginOrderDetailValue;
        _marginOcoOrderValue = marginOcoOrderValue;
    }

    public static SapiV1MarginOpenOrdersResponse CanceledMarginOrderDetail(CanceledMarginOrderDetail value) =>
        new(Optional<CanceledMarginOrderDetail>.Some(value), default);

    public static SapiV1MarginOpenOrdersResponse MarginOcoOrder(MarginOcoOrder value) =>
        new(default, Optional<MarginOcoOrder>.Some(value));

    public bool TryGetCanceledMarginOrderDetail(out CanceledMarginOrderDetail value) =>
        _canceledMarginOrderDetailValue.TryGetValue(out value);

    public bool TryGetMarginOcoOrder(out MarginOcoOrder value) => _marginOcoOrderValue.TryGetValue(out value);

    public static implicit operator SapiV1MarginOpenOrdersResponse(CanceledMarginOrderDetail value) =>
        CanceledMarginOrderDetail(value);

    public static implicit operator SapiV1MarginOpenOrdersResponse(MarginOcoOrder value) =>
        MarginOcoOrder(value);
}

file sealed class SapiV1MarginOpenOrdersResponseConverter : JsonConverter<SapiV1MarginOpenOrdersResponse>
{
    public override SapiV1MarginOpenOrdersResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<CanceledMarginOrderDetail>(root,
            options,
            out var canceledMarginOrderDetailValue))
        {
            return SapiV1MarginOpenOrdersResponse.CanceledMarginOrderDetail(canceledMarginOrderDetailValue);
        }
        if (JsonSerializer.TryDeserialize<MarginOcoOrder>(root, options, out var marginOcoOrderValue))
        {
            return SapiV1MarginOpenOrdersResponse.MarginOcoOrder(marginOcoOrderValue);
        }
        throw new JsonException($"JSON does not match CanceledMarginOrderDetail or MarginOcoOrder schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SapiV1MarginOpenOrdersResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetCanceledMarginOrderDetail(out var canceledMarginOrderDetailValue))
        {
            JsonSerializer.Serialize(writer, canceledMarginOrderDetailValue, options);
        }
        else if (value.TryGetMarginOcoOrder(out var marginOcoOrderValue))
        {
            JsonSerializer.Serialize(writer, marginOcoOrderValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SapiV1MarginOpenOrdersResponse)} contains no valid value to serialize.");
        }
    }
}
