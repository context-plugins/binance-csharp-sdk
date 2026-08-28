using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TimeInForce>))]
public sealed record TimeInForce : StringEnum<TimeInForce>
{
    private TimeInForce(string value) : base(value)
    {
    }

    public static readonly TimeInForce Gtc = new("GTC");

    public static readonly TimeInForce Ioc = new("IOC");

    public static readonly TimeInForce Fok = new("FOK");

    public static TimeInForce FromValue(string value) => FromValueCore(value);
}
