using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type6>))]
public sealed record Type6 : OpenStringEnum<Type6>
{
    private Type6(string value) : base(value)
    {
    }

    public static readonly Type6 Spot = new("SPOT");

    public static readonly Type6 Margin = new("MARGIN");

    public static readonly Type6 Futures = new("FUTURES");

    public TResult Match<TResult>(Func<TResult> onSpot,
        Func<TResult> onMargin,
        Func<TResult> onFutures,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Spot => onSpot(),
            _ when this == Margin => onMargin(),
            _ when this == Futures => onFutures(),
            _ => otherwise(Value)
        };

    public void Match(Action onSpot, Action onMargin, Action onFutures, Action<string> otherwise)
    {
        if (this == Spot) onSpot();
        else if (this == Margin) onMargin();
        else if (this == Futures) onFutures();
        else otherwise(Value);
    }
}
