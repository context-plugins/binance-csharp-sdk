using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FromAccountType>))]
public sealed record FromAccountType : OpenStringEnum<FromAccountType>
{
    private FromAccountType(string value) : base(value)
    {
    }

    public static readonly FromAccountType Spot = new("SPOT");

    public static readonly FromAccountType UsdtFuture = new("USDT_FUTURE");

    public static readonly FromAccountType CoinFuture = new("COIN_FUTURE");

    public static readonly FromAccountType Margin = new("MARGIN");

    public static readonly FromAccountType IsolatedMargin = new("ISOLATED_MARGIN");

    public TResult Match<TResult>(Func<TResult> onSpot,
        Func<TResult> onUsdtFuture,
        Func<TResult> onCoinFuture,
        Func<TResult> onMargin,
        Func<TResult> onIsolatedMargin,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Spot => onSpot(),
            _ when this == UsdtFuture => onUsdtFuture(),
            _ when this == CoinFuture => onCoinFuture(),
            _ when this == Margin => onMargin(),
            _ when this == IsolatedMargin => onIsolatedMargin(),
            _ => otherwise(Value)
        };

    public void Match(Action onSpot,
        Action onUsdtFuture,
        Action onCoinFuture,
        Action onMargin,
        Action onIsolatedMargin,
        Action<string> otherwise)
    {
        if (this == Spot) onSpot();
        else if (this == UsdtFuture) onUsdtFuture();
        else if (this == CoinFuture) onCoinFuture();
        else if (this == Margin) onMargin();
        else if (this == IsolatedMargin) onIsolatedMargin();
        else otherwise(Value);
    }
}
