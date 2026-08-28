using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AutoCompoundPlan>))]
public sealed record AutoCompoundPlan : StringEnum<AutoCompoundPlan>
{
    private AutoCompoundPlan(string value) : base(value)
    {
    }

    public static readonly AutoCompoundPlan None = new("NONE");

    public static readonly AutoCompoundPlan Standard = new("STANDARD");

    public static readonly AutoCompoundPlan Advance = new("ADVANCE");

    public static AutoCompoundPlan FromValue(string value) => FromValueCore(value);
}
