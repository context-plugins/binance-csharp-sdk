using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type7>))]
public sealed record Type7 : StringEnum<Type7>
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

    public static Type7 FromValue(string value) => FromValueCore(value);
}
