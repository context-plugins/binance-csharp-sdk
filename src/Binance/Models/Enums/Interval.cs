using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Interval>))]
public sealed record Interval : OpenStringEnum<Interval>
{
    private Interval(string value) : base(value)
    {
    }

    public static readonly Interval _1S = new("1s");

    public static readonly Interval _1M = new("1m");

    public static readonly Interval _3M = new("3m");

    public static readonly Interval _5M = new("5m");

    public static readonly Interval _15M = new("15m");

    public static readonly Interval _30M = new("30m");

    public static readonly Interval _1H = new("1h");

    public static readonly Interval _2H = new("2h");

    public static readonly Interval _4H = new("4h");

    public static readonly Interval _6H = new("6h");

    public static readonly Interval _8H = new("8h");

    public static readonly Interval _12H = new("12h");

    public static readonly Interval _1D = new("1d");

    public static readonly Interval _3D = new("3d");

    public static readonly Interval _1W = new("1w");

    public static readonly Interval _1M2 = new("1M");

    public TResult Match<TResult>(Func<TResult> on_1S,
        Func<TResult> on_1M,
        Func<TResult> on_3M,
        Func<TResult> on_5M,
        Func<TResult> on_15M,
        Func<TResult> on_30M,
        Func<TResult> on_1H,
        Func<TResult> on_2H,
        Func<TResult> on_4H,
        Func<TResult> on_6H,
        Func<TResult> on_8H,
        Func<TResult> on_12H,
        Func<TResult> on_1D,
        Func<TResult> on_3D,
        Func<TResult> on_1W,
        Func<TResult> on_1M2,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _1S => on_1S(),
            _ when this == _1M => on_1M(),
            _ when this == _3M => on_3M(),
            _ when this == _5M => on_5M(),
            _ when this == _15M => on_15M(),
            _ when this == _30M => on_30M(),
            _ when this == _1H => on_1H(),
            _ when this == _2H => on_2H(),
            _ when this == _4H => on_4H(),
            _ when this == _6H => on_6H(),
            _ when this == _8H => on_8H(),
            _ when this == _12H => on_12H(),
            _ when this == _1D => on_1D(),
            _ when this == _3D => on_3D(),
            _ when this == _1W => on_1W(),
            _ when this == _1M2 => on_1M2(),
            _ => otherwise(Value)
        };

    public void Match(Action on_1S,
        Action on_1M,
        Action on_3M,
        Action on_5M,
        Action on_15M,
        Action on_30M,
        Action on_1H,
        Action on_2H,
        Action on_4H,
        Action on_6H,
        Action on_8H,
        Action on_12H,
        Action on_1D,
        Action on_3D,
        Action on_1W,
        Action on_1M2,
        Action<string> otherwise)
    {
        if (this == _1S) on_1S();
        else if (this == _1M) on_1M();
        else if (this == _3M) on_3M();
        else if (this == _5M) on_5M();
        else if (this == _15M) on_15M();
        else if (this == _30M) on_30M();
        else if (this == _1H) on_1H();
        else if (this == _2H) on_2H();
        else if (this == _4H) on_4H();
        else if (this == _6H) on_6H();
        else if (this == _8H) on_8H();
        else if (this == _12H) on_12H();
        else if (this == _1D) on_1D();
        else if (this == _3D) on_3D();
        else if (this == _1W) on_1W();
        else if (this == _1M2) on_1M2();
        else otherwise(Value);
    }
}
