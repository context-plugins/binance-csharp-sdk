using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SpotBnbburn>))]
public sealed record SpotBnbburn : StringEnum<SpotBnbburn>
{
    private SpotBnbburn(string value) : base(value)
    {
    }

    public static readonly SpotBnbburn True = new("true");

    public static readonly SpotBnbburn False = new("false");

    public static SpotBnbburn FromValue(string value) => FromValueCore(value);
}
