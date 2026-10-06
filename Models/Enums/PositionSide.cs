using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PositionSide>))]
public sealed record PositionSide : OpenStringEnum<PositionSide>
{
    private PositionSide(string value) : base(value)
    {
    }

    public static readonly PositionSide Both = new("BOTH");

    public static readonly PositionSide Long = new("LONG");

    public static readonly PositionSide Short = new("SHORT");

    public TResult Match<TResult>(Func<TResult> onBoth,
        Func<TResult> onLong,
        Func<TResult> onShort,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Both => onBoth(),
            _ when this == Long => onLong(),
            _ when this == Short => onShort(),
            _ => otherwise(Value)
        };

    public void Match(Action onBoth, Action onLong, Action onShort, Action<string> otherwise)
    {
        if (this == Both) onBoth();
        else if (this == Long) onLong();
        else if (this == Short) onShort();
        else otherwise(Value);
    }
}
