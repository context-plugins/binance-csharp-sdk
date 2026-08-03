using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : StringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 Margin = new("MARGIN");

    public static readonly Type4 Isolated = new("ISOLATED");

    public static Type4 FromValue(string value) => FromValueCore(value);
}
