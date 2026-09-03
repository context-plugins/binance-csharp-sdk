using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SideEffectType>))]
public sealed record SideEffectType : StringEnum<SideEffectType>
{
    private SideEffectType(string value) : base(value)
    {
    }

    public static readonly SideEffectType NoSideEffect = new("NO_SIDE_EFFECT");

    public static readonly SideEffectType MarginBuy = new("MARGIN_BUY");

    public static readonly SideEffectType AutoRepay = new("AUTO_REPAY");

    public static SideEffectType FromValue(string value) => FromValueCore(value);
}
