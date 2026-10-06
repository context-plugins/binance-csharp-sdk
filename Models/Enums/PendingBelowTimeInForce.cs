using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingBelowTimeInForce>))]
public sealed record PendingBelowTimeInForce : OpenStringEnum<PendingBelowTimeInForce>
{
    private PendingBelowTimeInForce(string value) : base(value)
    {
    }

    public static readonly PendingBelowTimeInForce Gtc = new("GTC");

    public static readonly PendingBelowTimeInForce Ioc = new("IOC");

    public static readonly PendingBelowTimeInForce Fok = new("FOK");

    public TResult Match<TResult>(Func<TResult> onGtc,
        Func<TResult> onIoc,
        Func<TResult> onFok,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Gtc => onGtc(),
            _ when this == Ioc => onIoc(),
            _ when this == Fok => onFok(),
            _ => otherwise(Value)
        };

    public void Match(Action onGtc, Action onIoc, Action onFok, Action<string> otherwise)
    {
        if (this == Gtc) onGtc();
        else if (this == Ioc) onIoc();
        else if (this == Fok) onFok();
        else otherwise(Value);
    }
}
