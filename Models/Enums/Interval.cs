using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Interval>))]
public sealed record Interval : StringEnum<Interval>
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

    public static Interval FromValue(string value) => FromValueCore(value);
}
