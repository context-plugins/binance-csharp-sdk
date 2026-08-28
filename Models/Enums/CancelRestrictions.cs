using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CancelRestrictions>))]
public sealed record CancelRestrictions : StringEnum<CancelRestrictions>
{
    private CancelRestrictions(string value) : base(value)
    {
    }

    public static readonly CancelRestrictions OnlyNew = new("ONLY_NEW");

    public static readonly CancelRestrictions OnlyPartiallyFilled = new("ONLY_PARTIALLY_FILLED");

    public static CancelRestrictions FromValue(string value) => FromValueCore(value);
}
