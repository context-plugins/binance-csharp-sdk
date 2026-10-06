using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountType3>))]
public sealed record AccountType3 : OpenStringEnum<AccountType3>
{
    private AccountType3(string value) : base(value)
    {
    }

    public static readonly AccountType3 Main = new("MAIN");

    public static readonly AccountType3 Card = new("CARD");

    public TResult Match<TResult>(Func<TResult> onMain, Func<TResult> onCard, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Main => onMain(),
            _ when this == Card => onCard(),
            _ => otherwise(Value)
        };

    public void Match(Action onMain, Action onCard, Action<string> otherwise)
    {
        if (this == Main) onMain();
        else if (this == Card) onCard();
        else otherwise(Value);
    }
}
