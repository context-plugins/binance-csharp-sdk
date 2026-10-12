using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingAboveType>))]
public sealed record PendingAboveType : OpenStringEnum<PendingAboveType>
{
    private PendingAboveType(string value) : base(value)
    {
    }

    public static readonly PendingAboveType LimitMaker = new("LIMIT_MAKER");

    public static readonly PendingAboveType StopLoss = new("STOP_LOSS");

    public static readonly PendingAboveType StopLossLimit = new("STOP_LOSS_LIMIT");

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
