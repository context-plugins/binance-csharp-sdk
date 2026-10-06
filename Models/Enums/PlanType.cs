using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PlanType>))]
public sealed record PlanType : OpenStringEnum<PlanType>
{
    private PlanType(string value) : base(value)
    {
    }

    public static readonly PlanType Single = new("SINGLE");

    public static readonly PlanType Portfolio = new("PORTFOLIO");

    public static readonly PlanType Index = new("INDEX");

    public TResult Match<TResult>(Func<TResult> onSingle,
        Func<TResult> onPortfolio,
        Func<TResult> onIndex,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Single => onSingle(),
            _ when this == Portfolio => onPortfolio(),
            _ when this == Index => onIndex(),
            _ => otherwise(Value)
        };

    public void Match(Action onSingle, Action onPortfolio, Action onIndex, Action<string> otherwise)
    {
        if (this == Single) onSingle();
        else if (this == Portfolio) onPortfolio();
        else if (this == Index) onIndex();
        else otherwise(Value);
    }
}
