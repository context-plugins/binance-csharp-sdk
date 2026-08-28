using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ToAccountType>))]
public sealed record ToAccountType : StringEnum<ToAccountType>
{
    private ToAccountType(string value) : base(value)
    {
    }

    public static readonly ToAccountType Spot = new("SPOT");

    public static readonly ToAccountType UsdtFuture = new("USDT_FUTURE");

    public static readonly ToAccountType CoinFuture = new("COIN_FUTURE");

    public static readonly ToAccountType Margin = new("MARGIN");

    public static readonly ToAccountType IsolatedMargin = new("ISOLATED_MARGIN");

    public static ToAccountType FromValue(string value) => FromValueCore(value);
}
