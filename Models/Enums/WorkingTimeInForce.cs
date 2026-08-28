using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WorkingTimeInForce>))]
public sealed record WorkingTimeInForce : StringEnum<WorkingTimeInForce>
{
    private WorkingTimeInForce(string value) : base(value)
    {
    }

    public static readonly WorkingTimeInForce Gtc = new("GTC");

    public static readonly WorkingTimeInForce Ioc = new("IOC");

    public static readonly WorkingTimeInForce Fok = new("FOK");

    public static WorkingTimeInForce FromValue(string value) => FromValueCore(value);
}
