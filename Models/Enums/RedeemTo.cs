using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RedeemTo>))]
public sealed record RedeemTo : StringEnum<RedeemTo>
{
    private RedeemTo(string value) : base(value)
    {
    }

    public static readonly RedeemTo Spot = new("SPOT");

    public static readonly RedeemTo Flexible = new("FLEXIBLE");

    public static RedeemTo FromValue(string value) => FromValueCore(value);
}
