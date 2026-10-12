using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AutoCompoundPlan>))]
public sealed record AutoCompoundPlan : OpenStringEnum<AutoCompoundPlan>
{
    private AutoCompoundPlan(string value) : base(value)
    {
    }

    public static readonly AutoCompoundPlan None = new("NONE");

    public static readonly AutoCompoundPlan Standard = new("STANDARD");

    public static readonly AutoCompoundPlan Advance = new("ADVANCE");

    public TResult Match<TResult>(Func<TResult> onNone,
        Func<TResult> onStandard,
        Func<TResult> onAdvance,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == None => onNone(),
            _ when this == Standard => onStandard(),
            _ when this == Advance => onAdvance(),
            _ => otherwise(Value)
        };

    public void Match(Action onNone, Action onStandard, Action onAdvance, Action<string> otherwise)
    {
        if (this == None) onNone();
        else if (this == Standard) onStandard();
        else if (this == Advance) onAdvance();
        else otherwise(Value);
    }
}
