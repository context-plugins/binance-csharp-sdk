using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(ApiV3UiKlinesResponseConverter))]
public record ApiV3UiKlinesResponse
{
    private readonly Optional<long> _longValue;

    private readonly Optional<string> _stringValue;

    private ApiV3UiKlinesResponse(Optional<long> longValue, Optional<string> stringValue)
    {
        _longValue = longValue;
        _stringValue = stringValue;
    }

    public static ApiV3UiKlinesResponse Long(long value) => new(Optional<long>.Some(value), default);

    public static ApiV3UiKlinesResponse String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetLong(out long value) => _longValue.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator ApiV3UiKlinesResponse(long value) => Long(value);

    public static implicit operator ApiV3UiKlinesResponse(string value) => String(value);
}

file sealed class ApiV3UiKlinesResponseConverter : JsonConverter<ApiV3UiKlinesResponse>
{
    public override ApiV3UiKlinesResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt64(out var longValue))
            {
                return ApiV3UiKlinesResponse.Long(longValue);
            }
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ApiV3UiKlinesResponse.String(value);
        }
        throw new JsonException($"JSON does not match long or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ApiV3UiKlinesResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetLong(out var longValue))
        {
            JsonSerializer.Serialize(writer, longValue, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ApiV3UiKlinesResponse)} contains no valid value to serialize.");
        }
    }
}
