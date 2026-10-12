using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type7>))]
public sealed record Type7 : OpenStringEnum<Type7>
{
    private Type7(string value) : base(value)
    {
    }

    public static readonly Type7 MainC2C = new("MAIN_C2C");

    public static readonly Type7 MainUmfuture = new("MAIN_UMFUTURE");

    public static readonly Type7 MainCmfuture = new("MAIN_CMFUTURE");

    public static readonly Type7 MainMargin = new("MAIN_MARGIN");

    public static readonly Type7 MainMining = new("MAIN_MINING");

    public static readonly Type7 C2CMain = new("C2C_MAIN");

    public static readonly Type7 C2CUmfuture = new("C2C_UMFUTURE");

    public static readonly Type7 C2CMining = new("C2C_MINING");

    public static readonly Type7 C2CMargin = new("C2C_MARGIN");

    public static readonly Type7 UmfutureMain = new("UMFUTURE_MAIN");

    public static readonly Type7 UmfutureC2C = new("UMFUTURE_C2C");

    public static readonly Type7 UmfutureMargin = new("UMFUTURE_MARGIN");

    public static readonly Type7 CmfutureMain = new("CMFUTURE_MAIN");

    public static readonly Type7 CmfutureMargin = new("CMFUTURE_MARGIN");

    public static readonly Type7 MarginMain = new("MARGIN_MAIN");

    public static readonly Type7 MarginUmfuture = new("MARGIN_UMFUTURE");

    public static readonly Type7 MarginCmfuture = new("MARGIN_CMFUTURE");

    public static readonly Type7 MarginMining = new("MARGIN_MINING");

    public static readonly Type7 MarginC2C = new("MARGIN_C2C");

    public static readonly Type7 MiningMain = new("MINING_MAIN");

    public static readonly Type7 MiningUmfuture = new("MINING_UMFUTURE");

    public static readonly Type7 MiningC2C = new("MINING_C2C");

    public static readonly Type7 MiningMargin = new("MINING_MARGIN");

    public static readonly Type7 MainPay = new("MAIN_PAY");

    public static readonly Type7 PayMain = new("PAY_MAIN");

    public static readonly Type7 IsolatedmarginMargin = new("ISOLATEDMARGIN_MARGIN");

    public static readonly Type7 MarginIsolatedmargin = new("MARGIN_ISOLATEDMARGIN");

    public static readonly Type7 IsolatedmarginIsolatedmargin = new("ISOLATEDMARGIN_ISOLATEDMARGIN");

    public TResult Match<TResult>(Func<TResult> onMainC2C,
        Func<TResult> onMainUmfuture,
        Func<TResult> onMainCmfuture,
        Func<TResult> onMainMargin,
        Func<TResult> onMainMining,
        Func<TResult> onC2CMain,
        Func<TResult> onC2CUmfuture,
        Func<TResult> onC2CMining,
        Func<TResult> onC2CMargin,
        Func<TResult> onUmfutureMain,
        Func<TResult> onUmfutureC2C,
        Func<TResult> onUmfutureMargin,
        Func<TResult> onCmfutureMain,
        Func<TResult> onCmfutureMargin,
        Func<TResult> onMarginMain,
        Func<TResult> onMarginUmfuture,
        Func<TResult> onMarginCmfuture,
        Func<TResult> onMarginMining,
        Func<TResult> onMarginC2C,
        Func<TResult> onMiningMain,
        Func<TResult> onMiningUmfuture,
        Func<TResult> onMiningC2C,
        Func<TResult> onMiningMargin,
        Func<TResult> onMainPay,
        Func<TResult> onPayMain,
        Func<TResult> onIsolatedmarginMargin,
        Func<TResult> onMarginIsolatedmargin,
        Func<TResult> onIsolatedmarginIsolatedmargin,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MainC2C => onMainC2C(),
            _ when this == MainUmfuture => onMainUmfuture(),
            _ when this == MainCmfuture => onMainCmfuture(),
            _ when this == MainMargin => onMainMargin(),
            _ when this == MainMining => onMainMining(),
            _ when this == C2CMain => onC2CMain(),
            _ when this == C2CUmfuture => onC2CUmfuture(),
            _ when this == C2CMining => onC2CMining(),
            _ when this == C2CMargin => onC2CMargin(),
            _ when this == UmfutureMain => onUmfutureMain(),
            _ when this == UmfutureC2C => onUmfutureC2C(),
            _ when this == UmfutureMargin => onUmfutureMargin(),
            _ when this == CmfutureMain => onCmfutureMain(),
            _ when this == CmfutureMargin => onCmfutureMargin(),
            _ when this == MarginMain => onMarginMain(),
            _ when this == MarginUmfuture => onMarginUmfuture(),
            _ when this == MarginCmfuture => onMarginCmfuture(),
            _ when this == MarginMining => onMarginMining(),
            _ when this == MarginC2C => onMarginC2C(),
            _ when this == MiningMain => onMiningMain(),
            _ when this == MiningUmfuture => onMiningUmfuture(),
            _ when this == MiningC2C => onMiningC2C(),
            _ when this == MiningMargin => onMiningMargin(),
            _ when this == MainPay => onMainPay(),
            _ when this == PayMain => onPayMain(),
            _ when this == IsolatedmarginMargin => onIsolatedmarginMargin(),
            _ when this == MarginIsolatedmargin => onMarginIsolatedmargin(),
            _ when this == IsolatedmarginIsolatedmargin => onIsolatedmarginIsolatedmargin(),
            _ => otherwise(Value)
        };

    public void Match(Action onMainC2C,
        Action onMainUmfuture,
        Action onMainCmfuture,
        Action onMainMargin,
        Action onMainMining,
        Action onC2CMain,
        Action onC2CUmfuture,
        Action onC2CMining,
        Action onC2CMargin,
        Action onUmfutureMain,
        Action onUmfutureC2C,
        Action onUmfutureMargin,
        Action onCmfutureMain,
        Action onCmfutureMargin,
        Action onMarginMain,
        Action onMarginUmfuture,
        Action onMarginCmfuture,
        Action onMarginMining,
        Action onMarginC2C,
        Action onMiningMain,
        Action onMiningUmfuture,
        Action onMiningC2C,
        Action onMiningMargin,
        Action onMainPay,
        Action onPayMain,
        Action onIsolatedmarginMargin,
        Action onMarginIsolatedmargin,
        Action onIsolatedmarginIsolatedmargin,
        Action<string> otherwise)
    {
        if (this == MainC2C) onMainC2C();
        else if (this == MainUmfuture) onMainUmfuture();
        else if (this == MainCmfuture) onMainCmfuture();
        else if (this == MainMargin) onMainMargin();
        else if (this == MainMining) onMainMining();
        else if (this == C2CMain) onC2CMain();
        else if (this == C2CUmfuture) onC2CUmfuture();
        else if (this == C2CMining) onC2CMining();
        else if (this == C2CMargin) onC2CMargin();
        else if (this == UmfutureMain) onUmfutureMain();
        else if (this == UmfutureC2C) onUmfutureC2C();
        else if (this == UmfutureMargin) onUmfutureMargin();
        else if (this == CmfutureMain) onCmfutureMain();
        else if (this == CmfutureMargin) onCmfutureMargin();
        else if (this == MarginMain) onMarginMain();
        else if (this == MarginUmfuture) onMarginUmfuture();
        else if (this == MarginCmfuture) onMarginCmfuture();
        else if (this == MarginMining) onMarginMining();
        else if (this == MarginC2C) onMarginC2C();
        else if (this == MiningMain) onMiningMain();
        else if (this == MiningUmfuture) onMiningUmfuture();
        else if (this == MiningC2C) onMiningC2C();
        else if (this == MiningMargin) onMiningMargin();
        else if (this == MainPay) onMainPay();
        else if (this == PayMain) onPayMain();
        else if (this == IsolatedmarginMargin) onIsolatedmarginMargin();
        else if (this == MarginIsolatedmargin) onMarginIsolatedmargin();
        else if (this == IsolatedmarginIsolatedmargin) onIsolatedmarginIsolatedmargin();
        else otherwise(Value);
    }
}
