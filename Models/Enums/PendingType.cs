using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingType>))]
public sealed record PendingType : StringEnum<PendingType>
{
    private PendingType(string value) : base(value)
    {
    }

    public static readonly PendingType Limit = new("LIMIT");

    public static readonly PendingType Market = new("MARKET");

    public static readonly PendingType StopLoss = new("STOP_LOSS");

    public static readonly PendingType StopLossLimit = new("STOP_LOSS_LIMIT");

    public static readonly PendingType TakeProfit = new("TAKE_PROFIT");

    public static readonly PendingType TakeProfitLimit = new("TAKE_PROFIT_LIMIT");

    public static readonly PendingType LimitMaker = new("LIMIT_MAKER");

    public static PendingType FromValue(string value) => FromValueCore(value);
}
