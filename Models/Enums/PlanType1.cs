using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PlanType1>))]
public sealed record PlanType1 : StringEnum<PlanType1>
{
    private PlanType1(string value) : base(value)
    {
    }

    public static readonly PlanType1 Single = new("SINGLE");

    public static readonly PlanType1 Portfolio = new("PORTFOLIO");

    public static readonly PlanType1 Index = new("INDEX");

    public static readonly PlanType1 All = new("ALL");

    public static PlanType1 FromValue(string value) => FromValueCore(value);
}
