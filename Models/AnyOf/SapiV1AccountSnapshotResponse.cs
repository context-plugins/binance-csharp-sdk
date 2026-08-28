using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Binance.Core.Extensions;
using Binance.Core.Models;

namespace Binance.Models.AnyOf;

[JsonConverter(typeof(SapiV1AccountSnapshotResponseConverter))]
public record SapiV1AccountSnapshotResponse
{
    private readonly Optional<SnapshotSpot> _snapshotSpotValue;

    private readonly Optional<SnapshotMargin> _snapshotMarginValue;

    private readonly Optional<SnapshotFutures> _snapshotFuturesValue;

    private SapiV1AccountSnapshotResponse(Optional<SnapshotSpot> snapshotSpotValue,
        Optional<SnapshotMargin> snapshotMarginValue,
        Optional<SnapshotFutures> snapshotFuturesValue)
    {
        _snapshotSpotValue = snapshotSpotValue;
        _snapshotMarginValue = snapshotMarginValue;
        _snapshotFuturesValue = snapshotFuturesValue;
    }

    public static SapiV1AccountSnapshotResponse SnapshotSpot(SnapshotSpot value) =>
        new(Optional<SnapshotSpot>.Some(value), default, default);

    public static SapiV1AccountSnapshotResponse SnapshotMargin(SnapshotMargin value) =>
        new(default, Optional<SnapshotMargin>.Some(value), default);

    public static SapiV1AccountSnapshotResponse SnapshotFutures(SnapshotFutures value) =>
        new(default, default, Optional<SnapshotFutures>.Some(value));

    public bool TryGetSnapshotSpot(out SnapshotSpot value) => _snapshotSpotValue.TryGetValue(out value);

    public bool TryGetSnapshotMargin(out SnapshotMargin value) => _snapshotMarginValue.TryGetValue(out value);

    public bool TryGetSnapshotFutures(out SnapshotFutures value) =>
        _snapshotFuturesValue.TryGetValue(out value);

    public static implicit operator SapiV1AccountSnapshotResponse(SnapshotSpot value) => SnapshotSpot(value);

    public static implicit operator SapiV1AccountSnapshotResponse(SnapshotMargin value) =>
        SnapshotMargin(value);

    public static implicit operator SapiV1AccountSnapshotResponse(SnapshotFutures value) =>
        SnapshotFutures(value);
}

file sealed class SapiV1AccountSnapshotResponseConverter : JsonConverter<SapiV1AccountSnapshotResponse>
{
    public override SapiV1AccountSnapshotResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SnapshotSpot>(root, options, out var snapshotSpotValue))
        {
            return SapiV1AccountSnapshotResponse.SnapshotSpot(snapshotSpotValue);
        }
        if (JsonSerializer.TryDeserialize<SnapshotMargin>(root, options, out var snapshotMarginValue))
        {
            return SapiV1AccountSnapshotResponse.SnapshotMargin(snapshotMarginValue);
        }
        if (JsonSerializer.TryDeserialize<SnapshotFutures>(root, options, out var snapshotFuturesValue))
        {
            return SapiV1AccountSnapshotResponse.SnapshotFutures(snapshotFuturesValue);
        }
        throw new JsonException($"JSON does not match SnapshotSpot or SnapshotMargin or SnapshotFutures schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SapiV1AccountSnapshotResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetSnapshotSpot(out var snapshotSpotValue))
        {
            JsonSerializer.Serialize(writer, snapshotSpotValue, options);
        }
        else if (value.TryGetSnapshotMargin(out var snapshotMarginValue))
        {
            JsonSerializer.Serialize(writer, snapshotMarginValue, options);
        }
        else if (value.TryGetSnapshotFutures(out var snapshotFuturesValue))
        {
            JsonSerializer.Serialize(writer, snapshotFuturesValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SapiV1AccountSnapshotResponse)} contains no valid value to serialize.");
        }
    }
}
