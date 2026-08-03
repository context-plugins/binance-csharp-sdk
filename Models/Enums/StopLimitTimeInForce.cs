using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<StopLimitTimeInForce>))]
public sealed record StopLimitTimeInForce : StringEnum<StopLimitTimeInForce>
{
    private StopLimitTimeInForce(string value) : base(value)
    {
    }

    public static readonly StopLimitTimeInForce Gtc = new("GTC");

    public static readonly StopLimitTimeInForce Fok = new("FOK");

    public static readonly StopLimitTimeInForce Ioc = new("IOC");

    public static StopLimitTimeInForce FromValue(string value) => FromValueCore(value);
}
