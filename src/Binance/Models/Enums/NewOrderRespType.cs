using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<NewOrderRespType>))]
public sealed record NewOrderRespType : OpenStringEnum<NewOrderRespType>
{
    private NewOrderRespType(string value) : base(value)
    {
    }

    public static readonly NewOrderRespType Ack = new("ACK");

    public static readonly NewOrderRespType Result = new("RESULT");

    public static readonly NewOrderRespType Full = new("FULL");

    public TResult Match<TResult>(Func<TResult> onAck,
        Func<TResult> onResult,
        Func<TResult> onFull,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ack => onAck(),
            _ when this == Result => onResult(),
            _ when this == Full => onFull(),
            _ => otherwise(Value)
        };

    public void Match(Action onAck, Action onResult, Action onFull, Action<string> otherwise)
    {
        if (this == Ack) onAck();
        else if (this == Result) onResult();
        else if (this == Full) onFull();
        else otherwise(Value);
    }
}
