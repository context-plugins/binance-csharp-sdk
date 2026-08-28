using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : StringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Limit = new("LIMIT");

    public static readonly Type1 Market = new("MARKET");

    public static readonly Type1 StopLoss = new("STOP_LOSS");

    public static readonly Type1 StopLossLimit = new("STOP_LOSS_LIMIT");

    public static readonly Type1 TakeProfit = new("TAKE_PROFIT");

    public static readonly Type1 TakeProfitLimit = new("TAKE_PROFIT_LIMIT");

    public static readonly Type1 LimitMaker = new("LIMIT_MAKER");

    public static Type1 FromValue(string value) => FromValueCore(value);
}
