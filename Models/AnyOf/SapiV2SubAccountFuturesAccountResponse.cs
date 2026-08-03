using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Extensions;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models.AnyOf;

[JsonConverter(typeof(SapiV2SubAccountFuturesAccountResponseConverter))]
public record SapiV2SubAccountFuturesAccountResponse
{
    private readonly Optional<SubAccountUsdtfuturesDetails> _subAccountUsdtfuturesDetailsValue;

    private readonly Optional<SubAccountCoinfuturesDetails> _subAccountCoinfuturesDetailsValue;

    private SapiV2SubAccountFuturesAccountResponse(Optional<SubAccountUsdtfuturesDetails> subAccountUsdtfuturesDetailsValue,
        Optional<SubAccountCoinfuturesDetails> subAccountCoinfuturesDetailsValue)
    {
        _subAccountUsdtfuturesDetailsValue = subAccountUsdtfuturesDetailsValue;
        _subAccountCoinfuturesDetailsValue = subAccountCoinfuturesDetailsValue;
    }

    public static SapiV2SubAccountFuturesAccountResponse SubAccountUsdtfuturesDetails(SubAccountUsdtfuturesDetails value) =>
        new(Optional<SubAccountUsdtfuturesDetails>.Some(value), default);

    public static SapiV2SubAccountFuturesAccountResponse SubAccountCoinfuturesDetails(SubAccountCoinfuturesDetails value) =>
        new(default, Optional<SubAccountCoinfuturesDetails>.Some(value));

    public bool TryGetSubAccountUsdtfuturesDetails(out SubAccountUsdtfuturesDetails value) =>
        _subAccountUsdtfuturesDetailsValue.TryGetValue(out value);

    public bool TryGetSubAccountCoinfuturesDetails(out SubAccountCoinfuturesDetails value) =>
        _subAccountCoinfuturesDetailsValue.TryGetValue(out value);

    public static implicit operator SapiV2SubAccountFuturesAccountResponse(SubAccountUsdtfuturesDetails value) =>
        SubAccountUsdtfuturesDetails(value);

    public static implicit operator SapiV2SubAccountFuturesAccountResponse(SubAccountCoinfuturesDetails value) =>
        SubAccountCoinfuturesDetails(value);
}

file sealed class SapiV2SubAccountFuturesAccountResponseConverter : JsonConverter<SapiV2SubAccountFuturesAccountResponse>
{
    public override SapiV2SubAccountFuturesAccountResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SubAccountUsdtfuturesDetails>(root,
            options,
            out var subAccountUsdtfuturesDetailsValue))
        {
            return SapiV2SubAccountFuturesAccountResponse.SubAccountUsdtfuturesDetails(subAccountUsdtfuturesDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<SubAccountCoinfuturesDetails>(root,
            options,
            out var subAccountCoinfuturesDetailsValue))
        {
            return SapiV2SubAccountFuturesAccountResponse.SubAccountCoinfuturesDetails(subAccountCoinfuturesDetailsValue);
        }
        throw new JsonException($"JSON does not match SubAccountUsdtfuturesDetails or SubAccountCoinfuturesDetails schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SapiV2SubAccountFuturesAccountResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetSubAccountUsdtfuturesDetails(out var subAccountUsdtfuturesDetailsValue))
        {
            JsonSerializer.Serialize(writer, subAccountUsdtfuturesDetailsValue, options);
        }
        else if (value.TryGetSubAccountCoinfuturesDetails(out var subAccountCoinfuturesDetailsValue))
        {
            JsonSerializer.Serialize(writer, subAccountCoinfuturesDetailsValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SapiV2SubAccountFuturesAccountResponse)} contains no valid value to serialize.");
        }
    }
}
