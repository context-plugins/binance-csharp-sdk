using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SubscriptionStartWeekday>))]
public sealed record SubscriptionStartWeekday : StringEnum<SubscriptionStartWeekday>
{
    private SubscriptionStartWeekday(string value) : base(value)
    {
    }

    public static readonly SubscriptionStartWeekday Mon = new("MON");

    public static readonly SubscriptionStartWeekday Tue = new("TUE");

    public static readonly SubscriptionStartWeekday Wed = new("WED");

    public static readonly SubscriptionStartWeekday Thu = new("THU");

    public static readonly SubscriptionStartWeekday Fri = new("FRI");

    public static readonly SubscriptionStartWeekday Sat = new("SAT");

    public static readonly SubscriptionStartWeekday Sun = new("SUN");

    public static SubscriptionStartWeekday FromValue(string value) => FromValueCore(value);
}
