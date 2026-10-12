using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : OpenStringEnum<Type3>
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

    public TResult Match<TResult>(Func<TResult> onTransfer,
        Func<TResult> onBorrow,
        Func<TResult> onRepay,
        Func<TResult> onBuyIncome,
        Func<TResult> onBuyExpense,
        Func<TResult> onSellIncome,
        Func<TResult> onSellExpense,
        Func<TResult> onTradingCommission,
        Func<TResult> onBuyLiquidation,
        Func<TResult> onSellLiquidation,
        Func<TResult> onRepayLiquidation,
        Func<TResult> onOtherLiquidation,
        Func<TResult> onLiquidationFee,
        Func<TResult> onSmallBalanceConvert,
        Func<TResult> onCommissionReturn,
        Func<TResult> onSmallConvert,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Transfer => onTransfer(),
            _ when this == Borrow => onBorrow(),
            _ when this == Repay => onRepay(),
            _ when this == BuyIncome => onBuyIncome(),
            _ when this == BuyExpense => onBuyExpense(),
            _ when this == SellIncome => onSellIncome(),
            _ when this == SellExpense => onSellExpense(),
            _ when this == TradingCommission => onTradingCommission(),
            _ when this == BuyLiquidation => onBuyLiquidation(),
            _ when this == SellLiquidation => onSellLiquidation(),
            _ when this == RepayLiquidation => onRepayLiquidation(),
            _ when this == OtherLiquidation => onOtherLiquidation(),
            _ when this == LiquidationFee => onLiquidationFee(),
            _ when this == SmallBalanceConvert => onSmallBalanceConvert(),
            _ when this == CommissionReturn => onCommissionReturn(),
            _ when this == SmallConvert => onSmallConvert(),
            _ => otherwise(Value)
        };

    public void Match(Action onTransfer,
        Action onBorrow,
        Action onRepay,
        Action onBuyIncome,
        Action onBuyExpense,
        Action onSellIncome,
        Action onSellExpense,
        Action onTradingCommission,
        Action onBuyLiquidation,
        Action onSellLiquidation,
        Action onRepayLiquidation,
        Action onOtherLiquidation,
        Action onLiquidationFee,
        Action onSmallBalanceConvert,
        Action onCommissionReturn,
        Action onSmallConvert,
        Action<string> otherwise)
    {
        if (this == Transfer) onTransfer();
        else if (this == Borrow) onBorrow();
        else if (this == Repay) onRepay();
        else if (this == BuyIncome) onBuyIncome();
        else if (this == BuyExpense) onBuyExpense();
        else if (this == SellIncome) onSellIncome();
        else if (this == SellExpense) onSellExpense();
        else if (this == TradingCommission) onTradingCommission();
        else if (this == BuyLiquidation) onBuyLiquidation();
        else if (this == SellLiquidation) onSellLiquidation();
        else if (this == RepayLiquidation) onRepayLiquidation();
        else if (this == OtherLiquidation) onOtherLiquidation();
        else if (this == LiquidationFee) onLiquidationFee();
        else if (this == SmallBalanceConvert) onSmallBalanceConvert();
        else if (this == CommissionReturn) onCommissionReturn();
        else if (this == SmallConvert) onSmallConvert();
        else otherwise(Value);
    }
}
