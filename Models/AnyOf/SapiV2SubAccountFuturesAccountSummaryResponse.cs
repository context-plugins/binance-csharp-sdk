using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(SapiV2SubAccountFuturesAccountSummaryResponseConverter))]
public record SapiV2SubAccountFuturesAccountSummaryResponse
{
    private readonly Optional<SubAccountUsdtfuturesSummary> _subAccountUsdtfuturesSummaryValue;

    private readonly Optional<SubAccountCoinfuturesSummary> _subAccountCoinfuturesSummaryValue;

    private SapiV2SubAccountFuturesAccountSummaryResponse(Optional<SubAccountUsdtfuturesSummary> subAccountUsdtfuturesSummaryValue,
        Optional<SubAccountCoinfuturesSummary> subAccountCoinfuturesSummaryValue)
    {
        _subAccountUsdtfuturesSummaryValue = subAccountUsdtfuturesSummaryValue;
        _subAccountCoinfuturesSummaryValue = subAccountCoinfuturesSummaryValue;
    }

    public static SapiV2SubAccountFuturesAccountSummaryResponse SubAccountUsdtfuturesSummary(SubAccountUsdtfuturesSummary value) =>
        new(Optional<SubAccountUsdtfuturesSummary>.Some(value), default);

    public static SapiV2SubAccountFuturesAccountSummaryResponse SubAccountCoinfuturesSummary(SubAccountCoinfuturesSummary value) =>
        new(default, Optional<SubAccountCoinfuturesSummary>.Some(value));

    public bool TryGetSubAccountUsdtfuturesSummary(out SubAccountUsdtfuturesSummary value) =>
        _subAccountUsdtfuturesSummaryValue.TryGetValue(out value);

    public bool TryGetSubAccountCoinfuturesSummary(out SubAccountCoinfuturesSummary value) =>
        _subAccountCoinfuturesSummaryValue.TryGetValue(out value);

    public static implicit operator SapiV2SubAccountFuturesAccountSummaryResponse(SubAccountUsdtfuturesSummary value) =>
        SubAccountUsdtfuturesSummary(value);

    public static implicit operator SapiV2SubAccountFuturesAccountSummaryResponse(SubAccountCoinfuturesSummary value) =>
        SubAccountCoinfuturesSummary(value);
}

file sealed class SapiV2SubAccountFuturesAccountSummaryResponseConverter : JsonConverter<SapiV2SubAccountFuturesAccountSummaryResponse>
{
    public override SapiV2SubAccountFuturesAccountSummaryResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SubAccountUsdtfuturesSummary>(root,
            options,
            out var subAccountUsdtfuturesSummaryValue))
        {
            return SapiV2SubAccountFuturesAccountSummaryResponse.SubAccountUsdtfuturesSummary(subAccountUsdtfuturesSummaryValue);
        }
        if (JsonSerializer.TryDeserialize<SubAccountCoinfuturesSummary>(root,
            options,
            out var subAccountCoinfuturesSummaryValue))
        {
            return SapiV2SubAccountFuturesAccountSummaryResponse.SubAccountCoinfuturesSummary(subAccountCoinfuturesSummaryValue);
        }
        throw new JsonException($"JSON does not match SubAccountUsdtfuturesSummary or SubAccountCoinfuturesSummary schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SapiV2SubAccountFuturesAccountSummaryResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetSubAccountUsdtfuturesSummary(out var subAccountUsdtfuturesSummaryValue))
        {
            JsonSerializer.Serialize(writer, subAccountUsdtfuturesSummaryValue, options);
        }
        else if (value.TryGetSubAccountCoinfuturesSummary(out var subAccountCoinfuturesSummaryValue))
        {
            JsonSerializer.Serialize(writer, subAccountCoinfuturesSummaryValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SapiV2SubAccountFuturesAccountSummaryResponse)} contains no valid value to serialize.");
        }
    }
}
