using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(SapiV2SubAccountFuturesPositionRiskResponseConverter))]
public record SapiV2SubAccountFuturesPositionRiskResponse
{
    private readonly Optional<SubAccountUsdtfuturesPositionRisk> _subAccountUsdtfuturesPositionRiskValue;

    private readonly Optional<SubAccountCoinfuturesPositionRisk> _subAccountCoinfuturesPositionRiskValue;

    private SapiV2SubAccountFuturesPositionRiskResponse(Optional<SubAccountUsdtfuturesPositionRisk> subAccountUsdtfuturesPositionRiskValue,
        Optional<SubAccountCoinfuturesPositionRisk> subAccountCoinfuturesPositionRiskValue)
    {
        _subAccountUsdtfuturesPositionRiskValue = subAccountUsdtfuturesPositionRiskValue;
        _subAccountCoinfuturesPositionRiskValue = subAccountCoinfuturesPositionRiskValue;
    }

    public static SapiV2SubAccountFuturesPositionRiskResponse SubAccountUsdtfuturesPositionRisk(SubAccountUsdtfuturesPositionRisk value) =>
        new(Optional<SubAccountUsdtfuturesPositionRisk>.Some(value), default);

    public static SapiV2SubAccountFuturesPositionRiskResponse SubAccountCoinfuturesPositionRisk(SubAccountCoinfuturesPositionRisk value) =>
        new(default, Optional<SubAccountCoinfuturesPositionRisk>.Some(value));

    public bool TryGetSubAccountUsdtfuturesPositionRisk(out SubAccountUsdtfuturesPositionRisk value) =>
        _subAccountUsdtfuturesPositionRiskValue.TryGetValue(out value);

    public bool TryGetSubAccountCoinfuturesPositionRisk(out SubAccountCoinfuturesPositionRisk value) =>
        _subAccountCoinfuturesPositionRiskValue.TryGetValue(out value);

    public static implicit operator SapiV2SubAccountFuturesPositionRiskResponse(SubAccountUsdtfuturesPositionRisk value) =>
        SubAccountUsdtfuturesPositionRisk(value);

    public static implicit operator SapiV2SubAccountFuturesPositionRiskResponse(SubAccountCoinfuturesPositionRisk value) =>
        SubAccountCoinfuturesPositionRisk(value);
}

file sealed class SapiV2SubAccountFuturesPositionRiskResponseConverter : JsonConverter<SapiV2SubAccountFuturesPositionRiskResponse>
{
    public override SapiV2SubAccountFuturesPositionRiskResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SubAccountUsdtfuturesPositionRisk>(root,
            options,
            out var subAccountUsdtfuturesPositionRiskValue))
        {
            return SapiV2SubAccountFuturesPositionRiskResponse.SubAccountUsdtfuturesPositionRisk(subAccountUsdtfuturesPositionRiskValue);
        }
        if (JsonSerializer.TryDeserialize<SubAccountCoinfuturesPositionRisk>(root,
            options,
            out var subAccountCoinfuturesPositionRiskValue))
        {
            return SapiV2SubAccountFuturesPositionRiskResponse.SubAccountCoinfuturesPositionRisk(subAccountCoinfuturesPositionRiskValue);
        }
        throw new JsonException($"JSON does not match SubAccountUsdtfuturesPositionRisk or SubAccountCoinfuturesPositionRisk schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SapiV2SubAccountFuturesPositionRiskResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetSubAccountUsdtfuturesPositionRisk(out var subAccountUsdtfuturesPositionRiskValue))
        {
            JsonSerializer.Serialize(writer, subAccountUsdtfuturesPositionRiskValue, options);
        }
        else if (value.TryGetSubAccountCoinfuturesPositionRisk(out var subAccountCoinfuturesPositionRiskValue))
        {
            JsonSerializer.Serialize(writer, subAccountCoinfuturesPositionRiskValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SapiV2SubAccountFuturesPositionRiskResponse)} contains no valid value to serialize.");
        }
    }
}
