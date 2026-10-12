using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SortBy>))]
public sealed record SortBy : OpenStringEnum<SortBy>
{
    private SortBy(string value) : base(value)
    {
    }

    public static readonly SortBy StartTime = new("START_TIME");

    public static readonly SortBy LotSize = new("LOT_SIZE");

    public static readonly SortBy InterestRate = new("INTEREST_RATE");

    public static readonly SortBy Duration = new("DURATION");

    public TResult Match<TResult>(Func<TResult> onStartTime,
        Func<TResult> onLotSize,
        Func<TResult> onInterestRate,
        Func<TResult> onDuration,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == StartTime => onStartTime(),
            _ when this == LotSize => onLotSize(),
            _ when this == InterestRate => onInterestRate(),
            _ when this == Duration => onDuration(),
            _ => otherwise(Value)
        };

    public void Match(Action onStartTime,
        Action onLotSize,
        Action onInterestRate,
        Action onDuration,
        Action<string> otherwise)
    {
        if (this == StartTime) onStartTime();
        else if (this == LotSize) onLotSize();
        else if (this == InterestRate) onInterestRate();
        else if (this == Duration) onDuration();
        else otherwise(Value);
    }
}
