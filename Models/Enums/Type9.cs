using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type9>))]
public sealed record Type9 : StringEnum<Type9>
{
    private Type9(string value) : base(value)
    {
    }

    public static readonly Type9 BorrowIn = new("borrowIn");

    public static readonly Type9 CollateralSpent = new("collateralSpent");

    public static readonly Type9 RepayAmount = new("repayAmount");

    public static readonly Type9 CollateralReturn = new("collateralReturn");

    public static readonly Type9 AddCollateral = new("addCollateral");

    public static readonly Type9 RemoveCollateral = new("removeCollateral");

    public static readonly Type9 CollateralReturnAfterLiquidation = new("collateralReturnAfterLiquidation");

    public static Type9 FromValue(string value) => FromValueCore(value);
}
