using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WorkingType>))]
public sealed record WorkingType : StringEnum<WorkingType>
{
    private WorkingType(string value) : base(value)
    {
    }

    public static readonly WorkingType Limit = new("LIMIT");

    public static readonly WorkingType LimitMaker = new("LIMIT_MAKER");

    public static WorkingType FromValue(string value) => FromValueCore(value);
}
