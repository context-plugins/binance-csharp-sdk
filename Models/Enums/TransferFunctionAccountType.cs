using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TransferFunctionAccountType>))]
public sealed record TransferFunctionAccountType : StringEnum<TransferFunctionAccountType>
{
    private TransferFunctionAccountType(string value) : base(value)
    {
    }

    public static readonly TransferFunctionAccountType Spot = new("SPOT");

    public static readonly TransferFunctionAccountType Margin = new("MARGIN");

    public static readonly TransferFunctionAccountType IsolatedMargin = new("ISOLATED_MARGIN");

    public static readonly TransferFunctionAccountType UsdtFuture = new("USDT_FUTURE");

    public static readonly TransferFunctionAccountType CoinFuture = new("COIN_FUTURE");

    public static TransferFunctionAccountType FromValue(string value) => FromValueCore(value);
}
