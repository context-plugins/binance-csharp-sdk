using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SelfTradePreventionMode>))]
public sealed record SelfTradePreventionMode : OpenStringEnum<SelfTradePreventionMode>
{
    private SelfTradePreventionMode(string value) : base(value)
    {
    }

    public static readonly SelfTradePreventionMode ExpireTaker = new("EXPIRE_TAKER");

    public static readonly SelfTradePreventionMode ExpireMaker = new("EXPIRE_MAKER");

    public static readonly SelfTradePreventionMode ExpireBoth = new("EXPIRE_BOTH");

    public static readonly SelfTradePreventionMode None = new("NONE");

    public TResult Match<TResult>(Func<TResult> onExpireTaker,
        Func<TResult> onExpireMaker,
        Func<TResult> onExpireBoth,
        Func<TResult> onNone,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ExpireTaker => onExpireTaker(),
            _ when this == ExpireMaker => onExpireMaker(),
            _ when this == ExpireBoth => onExpireBoth(),
            _ when this == None => onNone(),
            _ => otherwise(Value)
        };

    public void Match(Action onExpireTaker,
        Action onExpireMaker,
        Action onExpireBoth,
        Action onNone,
        Action<string> otherwise)
    {
        if (this == ExpireTaker) onExpireTaker();
        else if (this == ExpireMaker) onExpireMaker();
        else if (this == ExpireBoth) onExpireBoth();
        else if (this == None) onNone();
        else otherwise(Value);
    }
}
