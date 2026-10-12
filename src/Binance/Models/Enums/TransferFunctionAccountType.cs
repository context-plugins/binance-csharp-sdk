using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TransferFunctionAccountType>))]
public sealed record TransferFunctionAccountType : OpenStringEnum<TransferFunctionAccountType>
{
    private TransferFunctionAccountType(string value) : base(value)
    {
    }

    public static readonly TransferFunctionAccountType Spot = new("SPOT");

    public static readonly TransferFunctionAccountType Margin = new("MARGIN");

    public static readonly TransferFunctionAccountType IsolatedMargin = new("ISOLATED_MARGIN");

    public static readonly TransferFunctionAccountType UsdtFuture = new("USDT_FUTURE");

    public static readonly TransferFunctionAccountType CoinFuture = new("COIN_FUTURE");

    public TResult Match<TResult>(Func<TResult> onSpot,
        Func<TResult> onMargin,
        Func<TResult> onIsolatedMargin,
        Func<TResult> onUsdtFuture,
        Func<TResult> onCoinFuture,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Spot => onSpot(),
            _ when this == Margin => onMargin(),
            _ when this == IsolatedMargin => onIsolatedMargin(),
            _ when this == UsdtFuture => onUsdtFuture(),
            _ when this == CoinFuture => onCoinFuture(),
            _ => otherwise(Value)
        };

    public void Match(Action onSpot,
        Action onMargin,
        Action onIsolatedMargin,
        Action onUsdtFuture,
        Action onCoinFuture,
        Action<string> otherwise)
    {
        if (this == Spot) onSpot();
        else if (this == Margin) onMargin();
        else if (this == IsolatedMargin) onIsolatedMargin();
        else if (this == UsdtFuture) onUsdtFuture();
        else if (this == CoinFuture) onCoinFuture();
        else otherwise(Value);
    }
}
