using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : OpenStringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 Margin = new("MARGIN");

    public static readonly Type4 Isolated = new("ISOLATED");

    public TResult Match<TResult>(Func<TResult> onMargin, Func<TResult> onIsolated, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Margin => onMargin(),
            _ when this == Isolated => onIsolated(),
            _ => otherwise(Value)
        };

    public void Match(Action onMargin, Action onIsolated, Action<string> otherwise)
    {
        if (this == Margin) onMargin();
        else if (this == Isolated) onIsolated();
        else otherwise(Value);
    }
}
