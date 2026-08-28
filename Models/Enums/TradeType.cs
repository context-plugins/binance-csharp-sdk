using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TradeType>))]
public sealed record TradeType : StringEnum<TradeType>
{
    private TradeType(string value) : base(value)
    {
    }

    public static readonly TradeType Buy = new("BUY");

    public static readonly TradeType Sell = new("SELL");

    public static TradeType FromValue(string value) => FromValueCore(value);
}
