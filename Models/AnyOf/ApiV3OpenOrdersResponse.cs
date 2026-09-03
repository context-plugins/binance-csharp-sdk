using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(ApiV3OpenOrdersResponseConverter))]
public record ApiV3OpenOrdersResponse
{
    private readonly Optional<Order> _orderValue;

    private readonly Optional<OcoOrder> _ocoOrderValue;

    private ApiV3OpenOrdersResponse(Optional<Order> orderValue, Optional<OcoOrder> ocoOrderValue)
    {
        _orderValue = orderValue;
        _ocoOrderValue = ocoOrderValue;
    }

    public static ApiV3OpenOrdersResponse Order(Order value) => new(Optional<Order>.Some(value), default);

    public static ApiV3OpenOrdersResponse OcoOrder(OcoOrder value) =>
        new(default, Optional<OcoOrder>.Some(value));

    public bool TryGetOrder(out Order value) => _orderValue.TryGetValue(out value);

    public bool TryGetOcoOrder(out OcoOrder value) => _ocoOrderValue.TryGetValue(out value);

    public static implicit operator ApiV3OpenOrdersResponse(Order value) => Order(value);

    public static implicit operator ApiV3OpenOrdersResponse(OcoOrder value) => OcoOrder(value);
}

file sealed class ApiV3OpenOrdersResponseConverter : JsonConverter<ApiV3OpenOrdersResponse>
{
    public override ApiV3OpenOrdersResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Order>(root, options, out var orderValue))
        {
            return ApiV3OpenOrdersResponse.Order(orderValue);
        }
        if (JsonSerializer.TryDeserialize<OcoOrder>(root, options, out var ocoOrderValue))
        {
            return ApiV3OpenOrdersResponse.OcoOrder(ocoOrderValue);
        }
        throw new JsonException($"JSON does not match Order or OcoOrder schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ApiV3OpenOrdersResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetOrder(out var orderValue))
        {
            JsonSerializer.Serialize(writer, orderValue, options);
        }
        else if (value.TryGetOcoOrder(out var ocoOrderValue))
        {
            JsonSerializer.Serialize(writer, ocoOrderValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ApiV3OpenOrdersResponse)} contains no valid value to serialize.");
        }
    }
}
