using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Direction>))]
public sealed record Direction : OpenStringEnum<Direction>
{
    private Direction(string value) : base(value)
    {
    }

    public static readonly Direction Additional = new("ADDITIONAL");

    public static readonly Direction Reduced = new("REDUCED");

    public TResult Match<TResult>(Func<TResult> onAdditional,
        Func<TResult> onReduced,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Additional => onAdditional(),
            _ when this == Reduced => onReduced(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdditional, Action onReduced, Action<string> otherwise)
    {
        if (this == Additional) onAdditional();
        else if (this == Reduced) onReduced();
        else otherwise(Value);
    }
}
