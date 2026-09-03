using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FromAccountType>))]
public sealed record FromAccountType : StringEnum<FromAccountType>
{
    private FromAccountType(string value) : base(value)
    {
    }

    public static readonly FromAccountType Spot = new("SPOT");

    public static readonly FromAccountType UsdtFuture = new("USDT_FUTURE");

    public static readonly FromAccountType CoinFuture = new("COIN_FUTURE");

    public static readonly FromAccountType Margin = new("MARGIN");

    public static readonly FromAccountType IsolatedMargin = new("ISOLATED_MARGIN");

    public static FromAccountType FromValue(string value) => FromValueCore(value);
}
