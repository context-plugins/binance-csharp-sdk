using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DataType>))]
public sealed record DataType : StringEnum<DataType>
{
    private DataType(string value) : base(value)
    {
    }

    public static readonly DataType TDepth = new("T_DEPTH");

    public static readonly DataType SDepth = new("S_DEPTH");

    public static DataType FromValue(string value) => FromValueCore(value);
}
