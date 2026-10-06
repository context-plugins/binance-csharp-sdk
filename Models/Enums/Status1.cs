using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : OpenStringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Ongoing = new("ONGOING");

    public static readonly Status1 Paused = new("PAUSED");

    public static readonly Status1 Removed = new("REMOVED");

    public TResult Match<TResult>(Func<TResult> onOngoing,
        Func<TResult> onPaused,
        Func<TResult> onRemoved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ongoing => onOngoing(),
            _ when this == Paused => onPaused(),
            _ when this == Removed => onRemoved(),
            _ => otherwise(Value)
        };

    public void Match(Action onOngoing, Action onPaused, Action onRemoved, Action<string> otherwise)
    {
        if (this == Ongoing) onOngoing();
        else if (this == Paused) onPaused();
        else if (this == Removed) onRemoved();
        else otherwise(Value);
    }
}
