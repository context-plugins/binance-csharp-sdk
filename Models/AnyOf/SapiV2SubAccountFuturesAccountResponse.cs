using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Binance.Core.Extensions;
using Binance.Core.Models;

namespace Binance.Models.AnyOf;

[JsonConverter(typeof(SapiV2SubAccountFuturesAccountResponseConverter))]
public record SapiV2SubAccountFuturesAccountResponse
{
    private readonly Optional<SubAccountUsdtFuturesDetails> _subAccountUsdtFuturesDetailsValue;

    private readonly Optional<SubAccountCoinFuturesDetails> _subAccountCoinFuturesDetailsValue;

    private SapiV2SubAccountFuturesAccountResponse(Optional<SubAccountUsdtFuturesDetails> subAccountUsdtFuturesDetailsValue,
        Optional<SubAccountCoinFuturesDetails> subAccountCoinFuturesDetailsValue)
    {
        _subAccountUsdtFuturesDetailsValue = subAccountUsdtFuturesDetailsValue;
        _subAccountCoinFuturesDetailsValue = subAccountCoinFuturesDetailsValue;
    }

    public static SapiV2SubAccountFuturesAccountResponse SubAccountUsdtFuturesDetails(SubAccountUsdtFuturesDetails value) =>
        new(Optional<SubAccountUsdtFuturesDetails>.Some(value), default);

    public static SapiV2SubAccountFuturesAccountResponse SubAccountCoinFuturesDetails(SubAccountCoinFuturesDetails value) =>
        new(default, Optional<SubAccountCoinFuturesDetails>.Some(value));

    public bool TryGetSubAccountUsdtFuturesDetails(out SubAccountUsdtFuturesDetails value) =>
        _subAccountUsdtFuturesDetailsValue.TryGetValue(out value);

    public bool TryGetSubAccountCoinFuturesDetails(out SubAccountCoinFuturesDetails value) =>
        _subAccountCoinFuturesDetailsValue.TryGetValue(out value);

    public static implicit operator SapiV2SubAccountFuturesAccountResponse(SubAccountUsdtFuturesDetails value) =>
        SubAccountUsdtFuturesDetails(value);

    public static implicit operator SapiV2SubAccountFuturesAccountResponse(SubAccountCoinFuturesDetails value) =>
        SubAccountCoinFuturesDetails(value);
}

file sealed class SapiV2SubAccountFuturesAccountResponseConverter : JsonConverter<SapiV2SubAccountFuturesAccountResponse>
{
    public override SapiV2SubAccountFuturesAccountResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SubAccountUsdtFuturesDetails>(
            root,
            options,
            out var subAccountUsdtFuturesDetailsValue))
        {
            return SapiV2SubAccountFuturesAccountResponse.SubAccountUsdtFuturesDetails(
                subAccountUsdtFuturesDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<SubAccountCoinFuturesDetails>(
            root,
            options,
            out var subAccountCoinFuturesDetailsValue))
        {
            return SapiV2SubAccountFuturesAccountResponse.SubAccountCoinFuturesDetails(
                subAccountCoinFuturesDetailsValue);
        }
        throw new JsonException(
            $"JSON does not match SubAccountUsdtFuturesDetails or SubAccountCoinFuturesDetails schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SapiV2SubAccountFuturesAccountResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetSubAccountUsdtFuturesDetails(out var subAccountUsdtFuturesDetailsValue))
        {
            JsonSerializer.Serialize(writer, subAccountUsdtFuturesDetailsValue, options);
        }
        else if (value.TryGetSubAccountCoinFuturesDetails(out var subAccountCoinFuturesDetailsValue))
        {
            JsonSerializer.Serialize(writer, subAccountCoinFuturesDetailsValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(SapiV2SubAccountFuturesAccountResponse)} contains no valid value to serialize.");
        }
    }
}
