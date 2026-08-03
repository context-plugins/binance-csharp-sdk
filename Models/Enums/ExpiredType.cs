using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ExpiredType>))]
public sealed record ExpiredType : StringEnum<ExpiredType>
{
    private ExpiredType(string value) : base(value)
    {
    }

    public static readonly ExpiredType _1D = new("1_D");

    public static readonly ExpiredType _3D = new("3_D");

    public static readonly ExpiredType _7D = new("7_D");

    public static readonly ExpiredType _30D = new("30_D");

    public static ExpiredType FromValue(string value) => FromValueCore(value);
}
