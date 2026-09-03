using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IsFlexibleRate>))]
public sealed record IsFlexibleRate : StringEnum<IsFlexibleRate>
{
    private IsFlexibleRate(string value) : base(value)
    {
    }

    public static readonly IsFlexibleRate True = new("TRUE");

    public static readonly IsFlexibleRate False = new("FALSE");

    public static IsFlexibleRate FromValue(string value) => FromValueCore(value);
}
