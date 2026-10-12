using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InterestBnbBurn>))]
public sealed record InterestBnbBurn : OpenStringEnum<InterestBnbBurn>
{
    private InterestBnbBurn(string value) : base(value)
    {
    }

    public static readonly InterestBnbBurn True = new("true");

    public static readonly InterestBnbBurn False = new("false");

    public TResult Match<TResult>(Func<TResult> onTrue, Func<TResult> onFalse, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == True => onTrue(),
            _ when this == False => onFalse(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrue, Action onFalse, Action<string> otherwise)
    {
        if (this == True) onTrue();
        else if (this == False) onFalse();
        else otherwise(Value);
    }
}
