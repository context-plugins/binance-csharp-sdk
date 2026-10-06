using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WorkingTimeInForce>))]
public sealed record WorkingTimeInForce : OpenStringEnum<WorkingTimeInForce>
{
    private WorkingTimeInForce(string value) : base(value)
    {
    }

    public static readonly WorkingTimeInForce Gtc = new("GTC");

    public static readonly WorkingTimeInForce Ioc = new("IOC");

    public static readonly WorkingTimeInForce Fok = new("FOK");

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
