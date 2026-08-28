using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SpotBnbBurn>))]
public sealed record SpotBnbBurn : StringEnum<SpotBnbBurn>
{
    private SpotBnbBurn(string value) : base(value)
    {
    }

    public static readonly SpotBnbBurn True = new("true");

    public static readonly SpotBnbBurn False = new("false");

    public static SpotBnbBurn FromValue(string value) => FromValueCore(value);
}
