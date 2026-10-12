using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Side>))]
public sealed record Side : OpenStringEnum<Side>
{
    private Side(string value) : base(value)
    {
    }

    public static readonly Side Sell = new("SELL");

    public static readonly Side Buy = new("BUY");

    public TResult Match<TResult>(Func<TResult> onSell, Func<TResult> onBuy, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sell => onSell(),
            _ when this == Buy => onBuy(),
            _ => otherwise(Value)
        };

    public void Match(Action onSell, Action onBuy, Action<string> otherwise)
    {
        if (this == Sell) onSell();
        else if (this == Buy) onBuy();
        else otherwise(Value);
    }
}
