using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : StringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 Transfer = new("TRANSFER");

    public static readonly Type3 Borrow = new("BORROW");

    public static readonly Type3 Repay = new("REPAY");

    public static readonly Type3 BuyIncome = new("BUY_INCOME");

    public static readonly Type3 BuyExpense = new("BUY_EXPENSE");

    public static readonly Type3 SellIncome = new("SELL_INCOME");

    public static readonly Type3 SellExpense = new("SELL_EXPENSE");

    public static readonly Type3 TradingCommission = new("TRADING_COMMISSION");

    public static readonly Type3 BuyLiquidation = new("BUY_LIQUIDATION");

    public static readonly Type3 SellLiquidation = new("SELL_LIQUIDATION");

    public static readonly Type3 RepayLiquidation = new("REPAY_LIQUIDATION");

    public static readonly Type3 OtherLiquidation = new("OTHER_LIQUIDATION");

    public static readonly Type3 LiquidationFee = new("LIQUIDATION_FEE");

    public static readonly Type3 SmallBalanceConvert = new("SMALL_BALANCE_CONVERT");

    public static readonly Type3 CommissionReturn = new("COMMISSION_RETURN");

    public static readonly Type3 SmallConvert = new("SMALL_CONVERT");

    public static Type3 FromValue(string value) => FromValueCore(value);
}
