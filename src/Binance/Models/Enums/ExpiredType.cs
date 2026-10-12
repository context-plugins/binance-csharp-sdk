using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ExpiredType>))]
public sealed record ExpiredType : OpenStringEnum<ExpiredType>
{
    private ExpiredType(string value) : base(value)
    {
    }

    public static readonly ExpiredType _1D = new("1_D");

    public static readonly ExpiredType _3D = new("3_D");

    public static readonly ExpiredType _7D = new("7_D");

    public static readonly ExpiredType _30D = new("30_D");

    public TResult Match<TResult>(Func<TResult> on_1D,
        Func<TResult> on_3D,
        Func<TResult> on_7D,
        Func<TResult> on_30D,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _1D => on_1D(),
            _ when this == _3D => on_3D(),
            _ when this == _7D => on_7D(),
            _ when this == _30D => on_30D(),
            _ => otherwise(Value)
        };

    public void Match(Action on_1D, Action on_3D, Action on_7D, Action on_30D, Action<string> otherwise)
    {
        if (this == _1D) on_1D();
        else if (this == _3D) on_3D();
        else if (this == _7D) on_7D();
        else if (this == _30D) on_30D();
        else otherwise(Value);
    }
}
