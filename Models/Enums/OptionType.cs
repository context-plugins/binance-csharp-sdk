using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<OptionType>))]
public sealed record OptionType : OpenStringEnum<OptionType>
{
    private OptionType(string value) : base(value)
    {
    }

    public static readonly OptionType Call = new("CALL");

    public static readonly OptionType Put = new("PUT");

    public TResult Match<TResult>(Func<TResult> onCall, Func<TResult> onPut, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Call => onCall(),
            _ when this == Put => onPut(),
            _ => otherwise(Value)
        };

    public void Match(Action onCall, Action onPut, Action<string> otherwise)
    {
        if (this == Call) onCall();
        else if (this == Put) onPut();
        else otherwise(Value);
    }
}
