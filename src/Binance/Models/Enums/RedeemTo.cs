using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RedeemTo>))]
public sealed record RedeemTo : OpenStringEnum<RedeemTo>
{
    private RedeemTo(string value) : base(value)
    {
    }

    public static readonly RedeemTo Spot = new("SPOT");

    public static readonly RedeemTo Flexible = new("FLEXIBLE");

    public TResult Match<TResult>(Func<TResult> onSpot, Func<TResult> onFlexible, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Spot => onSpot(),
            _ when this == Flexible => onFlexible(),
            _ => otherwise(Value)
        };

    public void Match(Action onSpot, Action onFlexible, Action<string> otherwise)
    {
        if (this == Spot) onSpot();
        else if (this == Flexible) onFlexible();
        else otherwise(Value);
    }
}
