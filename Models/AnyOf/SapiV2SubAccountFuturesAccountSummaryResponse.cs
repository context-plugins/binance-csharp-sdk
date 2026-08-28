using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Binance.Core.Extensions;
using Binance.Core.Models;

namespace Binance.Models.AnyOf;

[JsonConverter(typeof(SapiV2SubAccountFuturesAccountSummaryResponseConverter))]
public record SapiV2SubAccountFuturesAccountSummaryResponse
{
    private readonly Optional<SubAccountUsdtFuturesSummary> _subAccountUsdtFuturesSummaryValue;

    private readonly Optional<SubAccountCoinFuturesSummary> _subAccountCoinFuturesSummaryValue;

    private SapiV2SubAccountFuturesAccountSummaryResponse(Optional<SubAccountUsdtFuturesSummary> subAccountUsdtFuturesSummaryValue,
        Optional<SubAccountCoinFuturesSummary> subAccountCoinFuturesSummaryValue)
    {
        _subAccountUsdtFuturesSummaryValue = subAccountUsdtFuturesSummaryValue;
        _subAccountCoinFuturesSummaryValue = subAccountCoinFuturesSummaryValue;
    }

    public static SapiV2SubAccountFuturesAccountSummaryResponse SubAccountUsdtFuturesSummary(SubAccountUsdtFuturesSummary value) =>
        new(Optional<SubAccountUsdtFuturesSummary>.Some(value), default);

    public static SapiV2SubAccountFuturesAccountSummaryResponse SubAccountCoinFuturesSummary(SubAccountCoinFuturesSummary value) =>
        new(default, Optional<SubAccountCoinFuturesSummary>.Some(value));

    public bool TryGetSubAccountUsdtFuturesSummary(out SubAccountUsdtFuturesSummary value) =>
        _subAccountUsdtFuturesSummaryValue.TryGetValue(out value);

    public bool TryGetSubAccountCoinFuturesSummary(out SubAccountCoinFuturesSummary value) =>
        _subAccountCoinFuturesSummaryValue.TryGetValue(out value);

    public static implicit operator SapiV2SubAccountFuturesAccountSummaryResponse(SubAccountUsdtFuturesSummary value) =>
        SubAccountUsdtFuturesSummary(value);

    public static implicit operator SapiV2SubAccountFuturesAccountSummaryResponse(SubAccountCoinFuturesSummary value) =>
        SubAccountCoinFuturesSummary(value);
}

file sealed class SapiV2SubAccountFuturesAccountSummaryResponseConverter : JsonConverter<SapiV2SubAccountFuturesAccountSummaryResponse>
{
    public override SapiV2SubAccountFuturesAccountSummaryResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SubAccountUsdtFuturesSummary>(root,
            options,
            out var subAccountUsdtFuturesSummaryValue))
        {
            return SapiV2SubAccountFuturesAccountSummaryResponse.SubAccountUsdtFuturesSummary(subAccountUsdtFuturesSummaryValue);
        }
        if (JsonSerializer.TryDeserialize<SubAccountCoinFuturesSummary>(root,
            options,
            out var subAccountCoinFuturesSummaryValue))
        {
            return SapiV2SubAccountFuturesAccountSummaryResponse.SubAccountCoinFuturesSummary(subAccountCoinFuturesSummaryValue);
        }
        throw new JsonException($"JSON does not match SubAccountUsdtFuturesSummary or SubAccountCoinFuturesSummary schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SapiV2SubAccountFuturesAccountSummaryResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetSubAccountUsdtFuturesSummary(out var subAccountUsdtFuturesSummaryValue))
        {
            JsonSerializer.Serialize(writer, subAccountUsdtFuturesSummaryValue, options);
        }
        else if (value.TryGetSubAccountCoinFuturesSummary(out var subAccountCoinFuturesSummaryValue))
        {
            JsonSerializer.Serialize(writer, subAccountCoinFuturesSummaryValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SapiV2SubAccountFuturesAccountSummaryResponse)} contains no valid value to serialize.");
        }
    }
}
