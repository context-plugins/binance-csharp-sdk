using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<StopLimitTimeInForce>))]
public sealed record StopLimitTimeInForce : OpenStringEnum<StopLimitTimeInForce>
{
    private StopLimitTimeInForce(string value) : base(value)
    {
    }

    public static readonly StopLimitTimeInForce Gtc = new("GTC");

    public static readonly StopLimitTimeInForce Fok = new("FOK");

    public static readonly StopLimitTimeInForce Ioc = new("IOC");

    public TResult Match<TResult>(Func<TResult> onGtc,
        Func<TResult> onFok,
        Func<TResult> onIoc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Gtc => onGtc(),
            _ when this == Fok => onFok(),
            _ when this == Ioc => onIoc(),
            _ => otherwise(Value)
        };

    public void Match(Action onGtc, Action onFok, Action onIoc, Action<string> otherwise)
    {
        if (this == Gtc) onGtc();
        else if (this == Fok) onFok();
        else if (this == Ioc) onIoc();
        else otherwise(Value);
    }
}
