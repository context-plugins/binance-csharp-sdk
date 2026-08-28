using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Binance.Core.Extensions;
using Binance.Core.Models;

namespace Binance.Models.AnyOf;

[JsonConverter(typeof(ApiV3OrderResponseConverter))]
public record ApiV3OrderResponse
{
    private readonly Optional<OrderResponseAck> _orderResponseAckValue;

    private readonly Optional<OrderResponseResult> _orderResponseResultValue;

    private readonly Optional<OrderResponseFull> _orderResponseFullValue;

    private ApiV3OrderResponse(Optional<OrderResponseAck> orderResponseAckValue,
        Optional<OrderResponseResult> orderResponseResultValue,
        Optional<OrderResponseFull> orderResponseFullValue)
    {
        _orderResponseAckValue = orderResponseAckValue;
        _orderResponseResultValue = orderResponseResultValue;
        _orderResponseFullValue = orderResponseFullValue;
    }

    public static ApiV3OrderResponse OrderResponseAck(OrderResponseAck value) =>
        new(Optional<OrderResponseAck>.Some(value), default, default);

    public static ApiV3OrderResponse OrderResponseResult(OrderResponseResult value) =>
        new(default, Optional<OrderResponseResult>.Some(value), default);

    public static ApiV3OrderResponse OrderResponseFull(OrderResponseFull value) =>
        new(default, default, Optional<OrderResponseFull>.Some(value));

    public bool TryGetOrderResponseAck(out OrderResponseAck value) =>
        _orderResponseAckValue.TryGetValue(out value);

    public bool TryGetOrderResponseResult(out OrderResponseResult value) =>
        _orderResponseResultValue.TryGetValue(out value);

    public bool TryGetOrderResponseFull(out OrderResponseFull value) =>
        _orderResponseFullValue.TryGetValue(out value);

    public static implicit operator ApiV3OrderResponse(OrderResponseAck value) => OrderResponseAck(value);

    public static implicit operator ApiV3OrderResponse(OrderResponseResult value) => OrderResponseResult(value);

    public static implicit operator ApiV3OrderResponse(OrderResponseFull value) => OrderResponseFull(value);
}

file sealed class ApiV3OrderResponseConverter : JsonConverter<ApiV3OrderResponse>
{
    public override ApiV3OrderResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<OrderResponseAck>(root, options, out var orderResponseAckValue))
        {
            return ApiV3OrderResponse.OrderResponseAck(orderResponseAckValue);
        }
        if (JsonSerializer.TryDeserialize<OrderResponseResult>(root, options, out var orderResponseResultValue))
        {
            return ApiV3OrderResponse.OrderResponseResult(orderResponseResultValue);
        }
        if (JsonSerializer.TryDeserialize<OrderResponseFull>(root, options, out var orderResponseFullValue))
        {
            return ApiV3OrderResponse.OrderResponseFull(orderResponseFullValue);
        }
        throw new JsonException($"JSON does not match OrderResponseAck or OrderResponseResult or OrderResponseFull schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ApiV3OrderResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetOrderResponseAck(out var orderResponseAckValue))
        {
            JsonSerializer.Serialize(writer, orderResponseAckValue, options);
        }
        else if (value.TryGetOrderResponseResult(out var orderResponseResultValue))
        {
            JsonSerializer.Serialize(writer, orderResponseResultValue, options);
        }
        else if (value.TryGetOrderResponseFull(out var orderResponseFullValue))
        {
            JsonSerializer.Serialize(writer, orderResponseFullValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ApiV3OrderResponse)} contains no valid value to serialize.");
        }
    }
}
