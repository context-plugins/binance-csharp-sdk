using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PositionSide>))]
public sealed record PositionSide : StringEnum<PositionSide>
{
    private PositionSide(string value) : base(value)
    {
    }

    public static readonly PositionSide Both = new("BOTH");

    public static readonly PositionSide Long = new("LONG");

    public static readonly PositionSide Short = new("SHORT");

    public static PositionSide FromValue(string value) => FromValueCore(value);
}
