using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PlanType>))]
public sealed record PlanType : StringEnum<PlanType>
{
    private PlanType(string value) : base(value)
    {
    }

    public static readonly PlanType Single = new("SINGLE");

    public static readonly PlanType Portfolio = new("PORTFOLIO");

    public static readonly PlanType Index = new("INDEX");

    public static PlanType FromValue(string value) => FromValueCore(value);
}
