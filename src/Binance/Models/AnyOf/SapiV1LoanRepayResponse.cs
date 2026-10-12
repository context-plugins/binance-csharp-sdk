using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Binance.Core.Extensions;
using Binance.Core.Models;

namespace Binance.Models.AnyOf;

[JsonConverter(typeof(SapiV1LoanRepayResponseConverter))]
public record SapiV1LoanRepayResponse
{
    private readonly Optional<RepaymentInfo> _repaymentInfoValue;

    private readonly Optional<RepaymentInfo2> _repaymentInfo2Value;

    private SapiV1LoanRepayResponse(Optional<RepaymentInfo> repaymentInfoValue,
        Optional<RepaymentInfo2> repaymentInfo2Value)
    {
        _repaymentInfoValue = repaymentInfoValue;
        _repaymentInfo2Value = repaymentInfo2Value;
    }

    public static SapiV1LoanRepayResponse RepaymentInfo(RepaymentInfo value) =>
        new(Optional<RepaymentInfo>.Some(value), default);

    public static SapiV1LoanRepayResponse RepaymentInfo2(RepaymentInfo2 value) =>
        new(default, Optional<RepaymentInfo2>.Some(value));

    public bool TryGetRepaymentInfo(out RepaymentInfo value) => _repaymentInfoValue.TryGetValue(out value);

    public bool TryGetRepaymentInfo2(out RepaymentInfo2 value) => _repaymentInfo2Value.TryGetValue(out value);

    public static implicit operator SapiV1LoanRepayResponse(RepaymentInfo value) => RepaymentInfo(value);

    public static implicit operator SapiV1LoanRepayResponse(RepaymentInfo2 value) => RepaymentInfo2(value);
}

file sealed class SapiV1LoanRepayResponseConverter : JsonConverter<SapiV1LoanRepayResponse>
{
    public override SapiV1LoanRepayResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<RepaymentInfo>(root, options, out var repaymentInfoValue))
        {
            return SapiV1LoanRepayResponse.RepaymentInfo(repaymentInfoValue);
        }
        if (JsonSerializer.TryDeserialize<RepaymentInfo2>(root, options, out var repaymentInfo2Value))
        {
            return SapiV1LoanRepayResponse.RepaymentInfo2(repaymentInfo2Value);
        }
        throw new JsonException($"JSON does not match RepaymentInfo or RepaymentInfo2 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SapiV1LoanRepayResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetRepaymentInfo(out var repaymentInfoValue))
        {
            JsonSerializer.Serialize(writer, repaymentInfoValue, options);
        }
        else if (value.TryGetRepaymentInfo2(out var repaymentInfo2Value))
        {
            JsonSerializer.Serialize(writer, repaymentInfo2Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(SapiV1LoanRepayResponse)} contains no valid value to serialize.");
        }
    }
}
