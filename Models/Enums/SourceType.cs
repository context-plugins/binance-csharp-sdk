using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SourceType>))]
public sealed record SourceType : StringEnum<SourceType>
{
    private SourceType(string value) : base(value)
    {
    }

    public static readonly SourceType MainSite = new("MAIN_SITE");

    public static readonly SourceType Tr = new("TR");

    public static SourceType FromValue(string value) => FromValueCore(value);
}
