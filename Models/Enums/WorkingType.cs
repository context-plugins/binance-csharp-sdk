using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WorkingType>))]
public sealed record WorkingType : OpenStringEnum<WorkingType>
{
    private WorkingType(string value) : base(value)
    {
    }

    public static readonly WorkingType Limit = new("LIMIT");

    public static readonly WorkingType LimitMaker = new("LIMIT_MAKER");

    public TResult Match<TResult>(Func<TResult> onLimit, Func<TResult> onLimitMaker, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Limit => onLimit(),
            _ when this == LimitMaker => onLimitMaker(),
            _ => otherwise(Value)
        };

    public void Match(Action onLimit, Action onLimitMaker, Action<string> otherwise)
    {
        if (this == Limit) onLimit();
        else if (this == LimitMaker) onLimitMaker();
        else otherwise(Value);
    }
}
