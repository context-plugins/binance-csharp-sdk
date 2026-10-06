using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TransferSide>))]
public sealed record TransferSide : OpenStringEnum<TransferSide>
{
    private TransferSide(string value) : base(value)
    {
    }

    public static readonly TransferSide ToUm = new("TO_UM");

    public static readonly TransferSide FromUm = new("FROM_UM");

    public TResult Match<TResult>(Func<TResult> onToUm, Func<TResult> onFromUm, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ToUm => onToUm(),
            _ when this == FromUm => onFromUm(),
            _ => otherwise(Value)
        };

    public void Match(Action onToUm, Action onFromUm, Action<string> otherwise)
    {
        if (this == ToUm) onToUm();
        else if (this == FromUm) onFromUm();
        else otherwise(Value);
    }
}
