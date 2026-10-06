using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountType>))]
public sealed record AccountType : OpenStringEnum<AccountType>
{
    private AccountType(string value) : base(value)
    {
    }

    public static readonly AccountType Spot = new("SPOT");

    public static readonly AccountType Margin = new("MARGIN");

    public TResult Match<TResult>(Func<TResult> onSpot, Func<TResult> onMargin, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Spot => onSpot(),
            _ when this == Margin => onMargin(),
            _ => otherwise(Value)
        };

    public void Match(Action onSpot, Action onMargin, Action<string> otherwise)
    {
        if (this == Spot) onSpot();
        else if (this == Margin) onMargin();
        else otherwise(Value);
    }
}
