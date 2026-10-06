using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : OpenStringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Full = new("FULL");

    public static readonly TypeEnum Mini = new("MINI");

    public TResult Match<TResult>(Func<TResult> onFull, Func<TResult> onMini, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Full => onFull(),
            _ when this == Mini => onMini(),
            _ => otherwise(Value)
        };

    public void Match(Action onFull, Action onMini, Action<string> otherwise)
    {
        if (this == Full) onFull();
        else if (this == Mini) onMini();
        else otherwise(Value);
    }
}
