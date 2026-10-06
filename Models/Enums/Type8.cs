using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type8>))]
public sealed record Type8 : OpenStringEnum<Type8>
{
    private Type8(string value) : base(value)
    {
    }

    public static readonly Type8 Activity = new("ACTIVITY");

    public static readonly Type8 CustomizedFixed = new("CUSTOMIZED_FIXED");

    public TResult Match<TResult>(Func<TResult> onActivity,
        Func<TResult> onCustomizedFixed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Activity => onActivity(),
            _ when this == CustomizedFixed => onCustomizedFixed(),
            _ => otherwise(Value)
        };

    public void Match(Action onActivity, Action onCustomizedFixed, Action<string> otherwise)
    {
        if (this == Activity) onActivity();
        else if (this == CustomizedFixed) onCustomizedFixed();
        else otherwise(Value);
    }
}
