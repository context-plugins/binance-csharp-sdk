using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SideEffectType>))]
public sealed record SideEffectType : OpenStringEnum<SideEffectType>
{
    private SideEffectType(string value) : base(value)
    {
    }

    public static readonly SideEffectType NoSideEffect = new("NO_SIDE_EFFECT");

    public static readonly SideEffectType MarginBuy = new("MARGIN_BUY");

    public static readonly SideEffectType AutoRepay = new("AUTO_REPAY");

    public TResult Match<TResult>(Func<TResult> onNoSideEffect,
        Func<TResult> onMarginBuy,
        Func<TResult> onAutoRepay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoSideEffect => onNoSideEffect(),
            _ when this == MarginBuy => onMarginBuy(),
            _ when this == AutoRepay => onAutoRepay(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoSideEffect, Action onMarginBuy, Action onAutoRepay, Action<string> otherwise)
    {
        if (this == NoSideEffect) onNoSideEffect();
        else if (this == MarginBuy) onMarginBuy();
        else if (this == AutoRepay) onAutoRepay();
        else otherwise(Value);
    }
}
