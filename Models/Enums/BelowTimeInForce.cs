using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BelowTimeInForce>))]
public sealed record BelowTimeInForce : StringEnum<BelowTimeInForce>
{
    private BelowTimeInForce(string value) : base(value)
    {
    }

    public static readonly BelowTimeInForce Gtc = new("GTC");

    public static readonly BelowTimeInForce Ioc = new("IOC");

    public static readonly BelowTimeInForce Fok = new("FOK");

    public static BelowTimeInForce FromValue(string value) => FromValueCore(value);
}
