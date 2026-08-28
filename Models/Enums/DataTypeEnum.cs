using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DataTypeEnum>))]
public sealed record DataTypeEnum : StringEnum<DataTypeEnum>
{
    private DataTypeEnum(string value) : base(value)
    {
    }

    public static readonly DataTypeEnum TDepth = new("T_DEPTH");

    public static readonly DataTypeEnum SDepth = new("S_DEPTH");

    public static DataTypeEnum FromValue(string value) => FromValueCore(value);
}
