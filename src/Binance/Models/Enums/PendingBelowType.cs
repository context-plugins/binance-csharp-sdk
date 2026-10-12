using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingBelowType>))]
public sealed record PendingBelowType : OpenStringEnum<PendingBelowType>
{
    private PendingBelowType(string value) : base(value)
    {
    }

    public static readonly PendingBelowType LimitMaker = new("LIMIT_MAKER");

    public static readonly PendingBelowType StopLoss = new("STOP_LOSS");

    public static readonly PendingBelowType StopLossLimit = new("STOP_LOSS_LIMIT");

    public TResult Match<TResult>(Func<TResult> onLimitMaker,
        Func<TResult> onStopLoss,
        Func<TResult> onStopLossLimit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LimitMaker => onLimitMaker(),
            _ when this == StopLoss => onStopLoss(),
            _ when this == StopLossLimit => onStopLossLimit(),
            _ => otherwise(Value)
        };

    public void Match(Action onLimitMaker, Action onStopLoss, Action onStopLossLimit, Action<string> otherwise)
    {
        if (this == LimitMaker) onLimitMaker();
        else if (this == StopLoss) onStopLoss();
        else if (this == StopLossLimit) onStopLossLimit();
        else otherwise(Value);
    }
}
