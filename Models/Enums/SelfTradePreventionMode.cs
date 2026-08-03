using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SelfTradePreventionMode>))]
public sealed record SelfTradePreventionMode : StringEnum<SelfTradePreventionMode>
{
    private SelfTradePreventionMode(string value) : base(value)
    {
    }

    public static readonly SelfTradePreventionMode ExpireTaker = new("EXPIRE_TAKER");

    public static readonly SelfTradePreventionMode ExpireMaker = new("EXPIRE_MAKER");

    public static readonly SelfTradePreventionMode ExpireBoth = new("EXPIRE_BOTH");

    public static readonly SelfTradePreventionMode None = new("NONE");

    public static SelfTradePreventionMode FromValue(string value) => FromValueCore(value);
}
