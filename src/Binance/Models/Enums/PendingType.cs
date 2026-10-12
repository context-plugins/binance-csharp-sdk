using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingType>))]
public sealed record PendingType : OpenStringEnum<PendingType>
{
    private PendingType(string value) : base(value)
    {
    }

    public static readonly PendingType Limit = new("LIMIT");

    public static readonly PendingType Market = new("MARKET");

    public static readonly PendingType StopLoss = new("STOP_LOSS");

    public static readonly PendingType StopLossLimit = new("STOP_LOSS_LIMIT");

    public static readonly PendingType TakeProfit = new("TAKE_PROFIT");

    public static readonly PendingType TakeProfitLimit = new("TAKE_PROFIT_LIMIT");

    public static readonly PendingType LimitMaker = new("LIMIT_MAKER");

    public TResult Match<TResult>(Func<TResult> onLimit,
        Func<TResult> onMarket,
        Func<TResult> onStopLoss,
        Func<TResult> onStopLossLimit,
        Func<TResult> onTakeProfit,
        Func<TResult> onTakeProfitLimit,
        Func<TResult> onLimitMaker,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Limit => onLimit(),
            _ when this == Market => onMarket(),
            _ when this == StopLoss => onStopLoss(),
            _ when this == StopLossLimit => onStopLossLimit(),
            _ when this == TakeProfit => onTakeProfit(),
            _ when this == TakeProfitLimit => onTakeProfitLimit(),
            _ when this == LimitMaker => onLimitMaker(),
            _ => otherwise(Value)
        };

    public void Match(Action onLimit,
        Action onMarket,
        Action onStopLoss,
        Action onStopLossLimit,
        Action onTakeProfit,
        Action onTakeProfitLimit,
        Action onLimitMaker,
        Action<string> otherwise)
    {
        if (this == Limit) onLimit();
        else if (this == Market) onMarket();
        else if (this == StopLoss) onStopLoss();
        else if (this == StopLossLimit) onStopLossLimit();
        else if (this == TakeProfit) onTakeProfit();
        else if (this == TakeProfitLimit) onTakeProfitLimit();
        else if (this == LimitMaker) onLimitMaker();
        else otherwise(Value);
    }
}
