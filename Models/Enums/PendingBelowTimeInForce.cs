using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingBelowTimeInForce>))]
public sealed record PendingBelowTimeInForce : StringEnum<PendingBelowTimeInForce>
{
    private PendingBelowTimeInForce(string value) : base(value)
    {
    }

    public static readonly PendingBelowTimeInForce Gtc = new("GTC");

    public static readonly PendingBelowTimeInForce Ioc = new("IOC");

    public static readonly PendingBelowTimeInForce Fok = new("FOK");

    public static PendingBelowTimeInForce FromValue(string value) => FromValueCore(value);
}
