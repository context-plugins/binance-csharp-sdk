using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingTimeInForce>))]
public sealed record PendingTimeInForce : StringEnum<PendingTimeInForce>
{
    private PendingTimeInForce(string value) : base(value)
    {
    }

    public static readonly PendingTimeInForce Gtc = new("GTC");

    public static readonly PendingTimeInForce Ioc = new("IOC");

    public static readonly PendingTimeInForce Fok = new("FOK");

    public static PendingTimeInForce FromValue(string value) => FromValueCore(value);
}
