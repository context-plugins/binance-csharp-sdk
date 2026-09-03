using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(SapiV2SubAccountFuturesPositionRiskResponseConverter))]
public record SapiV2SubAccountFuturesPositionRiskResponse
{
    private readonly Optional<SubAccountUsdtFuturesPositionRisk> _subAccountUsdtFuturesPositionRiskValue;

    private readonly Optional<SubAccountCoinFuturesPositionRisk> _subAccountCoinFuturesPositionRiskValue;

    private SapiV2SubAccountFuturesPositionRiskResponse(Optional<SubAccountUsdtFuturesPositionRisk> subAccountUsdtFuturesPositionRiskValue,
        Optional<SubAccountCoinFuturesPositionRisk> subAccountCoinFuturesPositionRiskValue)
    {
        _subAccountUsdtFuturesPositionRiskValue = subAccountUsdtFuturesPositionRiskValue;
        _subAccountCoinFuturesPositionRiskValue = subAccountCoinFuturesPositionRiskValue;
    }

    public static SapiV2SubAccountFuturesPositionRiskResponse SubAccountUsdtFuturesPositionRisk(SubAccountUsdtFuturesPositionRisk value) =>
        new(Optional<SubAccountUsdtFuturesPositionRisk>.Some(value), default);

    public static SapiV2SubAccountFuturesPositionRiskResponse SubAccountCoinFuturesPositionRisk(SubAccountCoinFuturesPositionRisk value) =>
        new(default, Optional<SubAccountCoinFuturesPositionRisk>.Some(value));

    public bool TryGetSubAccountUsdtFuturesPositionRisk(out SubAccountUsdtFuturesPositionRisk value) =>
        _subAccountUsdtFuturesPositionRiskValue.TryGetValue(out value);

    public bool TryGetSubAccountCoinFuturesPositionRisk(out SubAccountCoinFuturesPositionRisk value) =>
        _subAccountCoinFuturesPositionRiskValue.TryGetValue(out value);

    public static implicit operator SapiV2SubAccountFuturesPositionRiskResponse(SubAccountUsdtFuturesPositionRisk value) =>
        SubAccountUsdtFuturesPositionRisk(value);

    public static implicit operator SapiV2SubAccountFuturesPositionRiskResponse(SubAccountCoinFuturesPositionRisk value) =>
        SubAccountCoinFuturesPositionRisk(value);
}

file sealed class SapiV2SubAccountFuturesPositionRiskResponseConverter : JsonConverter<SapiV2SubAccountFuturesPositionRiskResponse>
{
    public override SapiV2SubAccountFuturesPositionRiskResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SubAccountUsdtFuturesPositionRisk>(root,
            options,
            out var subAccountUsdtFuturesPositionRiskValue))
        {
            return SapiV2SubAccountFuturesPositionRiskResponse.SubAccountUsdtFuturesPositionRisk(subAccountUsdtFuturesPositionRiskValue);
        }
        if (JsonSerializer.TryDeserialize<SubAccountCoinFuturesPositionRisk>(root,
            options,
            out var subAccountCoinFuturesPositionRiskValue))
        {
            return SapiV2SubAccountFuturesPositionRiskResponse.SubAccountCoinFuturesPositionRisk(subAccountCoinFuturesPositionRiskValue);
        }
        throw new JsonException($"JSON does not match SubAccountUsdtFuturesPositionRisk or SubAccountCoinFuturesPositionRisk schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SapiV2SubAccountFuturesPositionRiskResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetSubAccountUsdtFuturesPositionRisk(out var subAccountUsdtFuturesPositionRiskValue))
        {
            JsonSerializer.Serialize(writer, subAccountUsdtFuturesPositionRiskValue, options);
        }
        else if (value.TryGetSubAccountCoinFuturesPositionRisk(out var subAccountCoinFuturesPositionRiskValue))
        {
            JsonSerializer.Serialize(writer, subAccountCoinFuturesPositionRiskValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SapiV2SubAccountFuturesPositionRiskResponse)} contains no valid value to serialize.");
        }
    }
}
