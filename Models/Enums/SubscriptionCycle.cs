using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SubscriptionCycle>))]
public sealed record SubscriptionCycle : OpenStringEnum<SubscriptionCycle>
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

    public TResult Match<TResult>(Func<TResult> onH1,
        Func<TResult> onH4,
        Func<TResult> onH8,
        Func<TResult> onH12,
        Func<TResult> onWeekly,
        Func<TResult> onDaily,
        Func<TResult> onMonthly,
        Func<TResult> onBiWeekly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == H1 => onH1(),
            _ when this == H4 => onH4(),
            _ when this == H8 => onH8(),
            _ when this == H12 => onH12(),
            _ when this == Weekly => onWeekly(),
            _ when this == Daily => onDaily(),
            _ when this == Monthly => onMonthly(),
            _ when this == BiWeekly => onBiWeekly(),
            _ => otherwise(Value)
        };

    public void Match(Action onH1,
        Action onH4,
        Action onH8,
        Action onH12,
        Action onWeekly,
        Action onDaily,
        Action onMonthly,
        Action onBiWeekly,
        Action<string> otherwise)
    {
        if (this == H1) onH1();
        else if (this == H4) onH4();
        else if (this == H8) onH8();
        else if (this == H12) onH12();
        else if (this == Weekly) onWeekly();
        else if (this == Daily) onDaily();
        else if (this == Monthly) onMonthly();
        else if (this == BiWeekly) onBiWeekly();
        else otherwise(Value);
    }
}
