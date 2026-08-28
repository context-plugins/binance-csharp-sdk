using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AboveTimeInForce>))]
public sealed record AboveTimeInForce : StringEnum<AboveTimeInForce>
{
    private AboveTimeInForce(string value) : base(value)
    {
    }

    public static readonly AboveTimeInForce Gtc = new("GTC");

    public static readonly AboveTimeInForce Ioc = new("IOC");

    public static readonly AboveTimeInForce Fok = new("FOK");

    public static AboveTimeInForce FromValue(string value) => FromValueCore(value);
}
