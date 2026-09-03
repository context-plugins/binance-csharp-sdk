using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingAboveTimeInForce>))]
public sealed record PendingAboveTimeInForce : StringEnum<PendingAboveTimeInForce>
{
    private PendingAboveTimeInForce(string value) : base(value)
    {
    }

    public static readonly PendingAboveTimeInForce Gtc = new("GTC");

    public static readonly PendingAboveTimeInForce Ioc = new("IOC");

    public static readonly PendingAboveTimeInForce Fok = new("FOK");

    public static PendingAboveTimeInForce FromValue(string value) => FromValueCore(value);
}
