using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CancelRestrictions>))]
public sealed record CancelRestrictions : OpenStringEnum<CancelRestrictions>
{
    private CancelRestrictions(string value) : base(value)
    {
    }

    public static readonly CancelRestrictions OnlyNew = new("ONLY_NEW");

    public static readonly CancelRestrictions OnlyPartiallyFilled = new("ONLY_PARTIALLY_FILLED");

    public TResult Match<TResult>(Func<TResult> onOnlyNew,
        Func<TResult> onOnlyPartiallyFilled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OnlyNew => onOnlyNew(),
            _ when this == OnlyPartiallyFilled => onOnlyPartiallyFilled(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnlyNew, Action onOnlyPartiallyFilled, Action<string> otherwise)
    {
        if (this == OnlyNew) onOnlyNew();
        else if (this == OnlyPartiallyFilled) onOnlyPartiallyFilled();
        else otherwise(Value);
    }
}
