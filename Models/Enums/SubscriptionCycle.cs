using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SubscriptionCycle>))]
public sealed record SubscriptionCycle : StringEnum<SubscriptionCycle>
{
    private SubscriptionCycle(string value) : base(value)
    {
    }

    public static readonly SubscriptionCycle H1 = new("H1");

    public static readonly SubscriptionCycle H4 = new("H4");

    public static readonly SubscriptionCycle H8 = new("H8");

    public static readonly SubscriptionCycle H12 = new("H12");

    public static readonly SubscriptionCycle Weekly = new("WEEKLY");

    public static readonly SubscriptionCycle Daily = new("DAILY");

    public static readonly SubscriptionCycle Monthly = new("MONTHLY");

    public static readonly SubscriptionCycle BiWeekly = new("BI_WEEKLY");

    public static SubscriptionCycle FromValue(string value) => FromValueCore(value);
}
