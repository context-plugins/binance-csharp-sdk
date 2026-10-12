using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : OpenStringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 RollIn = new("ROLL_IN");

    public static readonly Type2 RollOut = new("ROLL_OUT");

    public TResult Match<TResult>(Func<TResult> onRollIn, Func<TResult> onRollOut, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RollIn => onRollIn(),
            _ when this == RollOut => onRollOut(),
            _ => otherwise(Value)
        };

    public void Match(Action onRollIn, Action onRollOut, Action<string> otherwise)
    {
        if (this == RollIn) onRollIn();
        else if (this == RollOut) onRollOut();
        else otherwise(Value);
    }
}
