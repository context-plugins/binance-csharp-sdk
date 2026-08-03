using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(SapiV1MarginOrderResponseConverter))]
public record SapiV1MarginOrderResponse
{
    private readonly Optional<MarginOrderResponseAck> _marginOrderResponseAckValue;

    private readonly Optional<MarginOrderResponseResult> _marginOrderResponseResultValue;

    private readonly Optional<MarginOrderResponseFull> _marginOrderResponseFullValue;

    private SapiV1MarginOrderResponse(Optional<MarginOrderResponseAck> marginOrderResponseAckValue,
        Optional<MarginOrderResponseResult> marginOrderResponseResultValue,
        Optional<MarginOrderResponseFull> marginOrderResponseFullValue)
    {
        _marginOrderResponseAckValue = marginOrderResponseAckValue;
        _marginOrderResponseResultValue = marginOrderResponseResultValue;
        _marginOrderResponseFullValue = marginOrderResponseFullValue;
    }

    public static SapiV1MarginOrderResponse MarginOrderResponseAck(MarginOrderResponseAck value) =>
        new(Optional<MarginOrderResponseAck>.Some(value), default, default);

    public static SapiV1MarginOrderResponse MarginOrderResponseResult(MarginOrderResponseResult value) =>
        new(default, Optional<MarginOrderResponseResult>.Some(value), default);

    public static SapiV1MarginOrderResponse MarginOrderResponseFull(MarginOrderResponseFull value) =>
        new(default, default, Optional<MarginOrderResponseFull>.Some(value));

    public bool TryGetMarginOrderResponseAck(out MarginOrderResponseAck value) =>
        _marginOrderResponseAckValue.TryGetValue(out value);

    public bool TryGetMarginOrderResponseResult(out MarginOrderResponseResult value) =>
        _marginOrderResponseResultValue.TryGetValue(out value);

    public bool TryGetMarginOrderResponseFull(out MarginOrderResponseFull value) =>
        _marginOrderResponseFullValue.TryGetValue(out value);

    public static implicit operator SapiV1MarginOrderResponse(MarginOrderResponseAck value) =>
        MarginOrderResponseAck(value);

    public static implicit operator SapiV1MarginOrderResponse(MarginOrderResponseResult value) =>
        MarginOrderResponseResult(value);

    public static implicit operator SapiV1MarginOrderResponse(MarginOrderResponseFull value) =>
        MarginOrderResponseFull(value);
}

file sealed class SapiV1MarginOrderResponseConverter : JsonConverter<SapiV1MarginOrderResponse>
{
    public override SapiV1MarginOrderResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<MarginOrderResponseAck>(root,
            options,
            out var marginOrderResponseAckValue))
        {
            return SapiV1MarginOrderResponse.MarginOrderResponseAck(marginOrderResponseAckValue);
        }
        if (JsonSerializer.TryDeserialize<MarginOrderResponseResult>(root,
            options,
            out var marginOrderResponseResultValue))
        {
            return SapiV1MarginOrderResponse.MarginOrderResponseResult(marginOrderResponseResultValue);
        }
        if (JsonSerializer.TryDeserialize<MarginOrderResponseFull>(root,
            options,
            out var marginOrderResponseFullValue))
        {
            return SapiV1MarginOrderResponse.MarginOrderResponseFull(marginOrderResponseFullValue);
        }
        throw new JsonException($"JSON does not match MarginOrderResponseAck or MarginOrderResponseResult or MarginOrderResponseFull schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SapiV1MarginOrderResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetMarginOrderResponseAck(out var marginOrderResponseAckValue))
        {
            JsonSerializer.Serialize(writer, marginOrderResponseAckValue, options);
        }
        else if (value.TryGetMarginOrderResponseResult(out var marginOrderResponseResultValue))
        {
            JsonSerializer.Serialize(writer, marginOrderResponseResultValue, options);
        }
        else if (value.TryGetMarginOrderResponseFull(out var marginOrderResponseFullValue))
        {
            JsonSerializer.Serialize(writer, marginOrderResponseFullValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SapiV1MarginOrderResponse)} contains no valid value to serialize.");
        }
    }
}
