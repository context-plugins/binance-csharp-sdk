using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingAboveTimeInForce>))]
public sealed record PendingAboveTimeInForce : OpenStringEnum<PendingAboveTimeInForce>
{
    private PendingAboveTimeInForce(string value) : base(value)
    {
    }

    public static readonly PendingAboveTimeInForce Gtc = new("GTC");

    public static readonly PendingAboveTimeInForce Ioc = new("IOC");

    public static readonly PendingAboveTimeInForce Fok = new("FOK");

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
