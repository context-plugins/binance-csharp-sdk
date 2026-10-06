using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SpotBnbBurn>))]
public sealed record SpotBnbBurn : OpenStringEnum<SpotBnbBurn>
{
    private SpotBnbBurn(string value) : base(value)
    {
    }

    public static readonly SpotBnbBurn True = new("true");

    public static readonly SpotBnbBurn False = new("false");

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
