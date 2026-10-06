using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : OpenStringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status All = new("ALL");

    public static readonly Status Subscribable = new("SUBSCRIBABLE");

    public static readonly Status Unsubscribable = new("UNSUBSCRIBABLE");

    public TResult Match<TResult>(Func<TResult> onAll,
        Func<TResult> onSubscribable,
        Func<TResult> onUnsubscribable,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == All => onAll(),
            _ when this == Subscribable => onSubscribable(),
            _ when this == Unsubscribable => onUnsubscribable(),
            _ => otherwise(Value)
        };

    public void Match(Action onAll, Action onSubscribable, Action onUnsubscribable, Action<string> otherwise)
    {
        if (this == All) onAll();
        else if (this == Subscribable) onSubscribable();
        else if (this == Unsubscribable) onUnsubscribable();
        else otherwise(Value);
    }
}
