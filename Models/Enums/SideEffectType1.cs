using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SideEffectType1>))]
public sealed record SideEffectType1 : StringEnum<SideEffectType1>
{
    private SideEffectType1(string value) : base(value)
    {
    }

    public static readonly SideEffectType1 NoSideEffect = new("NO_SIDE_EFFECT");

    public static readonly SideEffectType1 MarginBuy = new("MARGIN_BUY");

    public static SideEffectType1 FromValue(string value) => FromValueCore(value);
}
