using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WorkingSide>))]
public sealed record WorkingSide : OpenStringEnum<WorkingSide>
{
    private WorkingSide(string value) : base(value)
    {
    }

    public static readonly WorkingSide Buy = new("BUY");

    public static readonly WorkingSide Sell = new("SELL");

    public TResult Match<TResult>(Func<TResult> onBuy, Func<TResult> onSell, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Buy => onBuy(),
            _ when this == Sell => onSell(),
            _ => otherwise(Value)
        };

    public void Match(Action onBuy, Action onSell, Action<string> otherwise)
    {
        if (this == Buy) onBuy();
        else if (this == Sell) onSell();
        else otherwise(Value);
    }
}
