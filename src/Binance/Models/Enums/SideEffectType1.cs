using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SideEffectType1>))]
public sealed record SideEffectType1 : OpenStringEnum<SideEffectType1>
{
    private SideEffectType1(string value) : base(value)
    {
    }

    public static readonly SideEffectType1 NoSideEffect = new("NO_SIDE_EFFECT");

    public static readonly SideEffectType1 MarginBuy = new("MARGIN_BUY");

    public TResult Match<TResult>(Func<TResult> onNoSideEffect,
        Func<TResult> onMarginBuy,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoSideEffect => onNoSideEffect(),
            _ when this == MarginBuy => onMarginBuy(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoSideEffect, Action onMarginBuy, Action<string> otherwise)
    {
        if (this == NoSideEffect) onNoSideEffect();
        else if (this == MarginBuy) onMarginBuy();
        else otherwise(Value);
    }
}
