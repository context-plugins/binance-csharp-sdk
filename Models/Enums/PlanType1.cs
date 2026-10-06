using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PlanType1>))]
public sealed record PlanType1 : OpenStringEnum<PlanType1>
{
    private PlanType1(string value) : base(value)
    {
    }

    public static readonly PlanType1 Single = new("SINGLE");

    public static readonly PlanType1 Portfolio = new("PORTFOLIO");

    public static readonly PlanType1 Index = new("INDEX");

    public static readonly PlanType1 All = new("ALL");

    public TResult Match<TResult>(Func<TResult> onSingle,
        Func<TResult> onPortfolio,
        Func<TResult> onIndex,
        Func<TResult> onAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Single => onSingle(),
            _ when this == Portfolio => onPortfolio(),
            _ when this == Index => onIndex(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onSingle, Action onPortfolio, Action onIndex, Action onAll, Action<string> otherwise)
    {
        if (this == Single) onSingle();
        else if (this == Portfolio) onPortfolio();
        else if (this == Index) onIndex();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
