using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DataTypeEnum>))]
public sealed record DataTypeEnum : OpenStringEnum<DataTypeEnum>
{
    private DataTypeEnum(string value) : base(value)
    {
    }

    public static readonly DataTypeEnum TDepth = new("T_DEPTH");

    public static readonly DataTypeEnum SDepth = new("S_DEPTH");

    public TResult Match<TResult>(Func<TResult> onTDepth, Func<TResult> onSDepth, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TDepth => onTDepth(),
            _ when this == SDepth => onSDepth(),
            _ => otherwise(Value)
        };

    public void Match(Action onTDepth, Action onSDepth, Action<string> otherwise)
    {
        if (this == TDepth) onTDepth();
        else if (this == SDepth) onSDepth();
        else otherwise(Value);
    }
}
