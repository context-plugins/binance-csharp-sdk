using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Direction>))]
public sealed record Direction : StringEnum<Direction>
{
    private Direction(string value) : base(value)
    {
    }

    public static readonly Direction Additional = new("ADDITIONAL");

    public static readonly Direction Reduced = new("REDUCED");

    public static Direction FromValue(string value) => FromValueCore(value);
}
