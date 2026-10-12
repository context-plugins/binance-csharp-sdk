using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WalletType>))]
public sealed record WalletType : OpenStringEnum<WalletType>
{
    private WalletType(string value) : base(value)
    {
    }

    public static readonly WalletType Spot = new("SPOT");

    public static readonly WalletType Funding = new("FUNDING");

    public static readonly WalletType SpotFunding = new("SPOT_FUNDING");

    public TResult Match<TResult>(Func<TResult> onSpot,
        Func<TResult> onFunding,
        Func<TResult> onSpotFunding,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Spot => onSpot(),
            _ when this == Funding => onFunding(),
            _ when this == SpotFunding => onSpotFunding(),
            _ => otherwise(Value)
        };

    public void Match(Action onSpot, Action onFunding, Action onSpotFunding, Action<string> otherwise)
    {
        if (this == Spot) onSpot();
        else if (this == Funding) onFunding();
        else if (this == SpotFunding) onSpotFunding();
        else otherwise(Value);
    }
}
