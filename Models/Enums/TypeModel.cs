using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeModel>))]
public sealed record TypeModel : StringEnum<TypeModel>
{
    private TypeModel(string value) : base(value)
    {
    }

    public static readonly TypeModel Full = new("FULL");

    public static readonly TypeModel Mini = new("MINI");

    public static TypeModel FromValue(string value) => FromValueCore(value);
}
