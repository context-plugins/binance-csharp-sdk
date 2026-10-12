using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type9>))]
public sealed record Type9 : OpenStringEnum<Type9>
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

    public TResult Match<TResult>(Func<TResult> onBorrowIn,
        Func<TResult> onCollateralSpent,
        Func<TResult> onRepayAmount,
        Func<TResult> onCollateralReturn,
        Func<TResult> onAddCollateral,
        Func<TResult> onRemoveCollateral,
        Func<TResult> onCollateralReturnAfterLiquidation,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BorrowIn => onBorrowIn(),
            _ when this == CollateralSpent => onCollateralSpent(),
            _ when this == RepayAmount => onRepayAmount(),
            _ when this == CollateralReturn => onCollateralReturn(),
            _ when this == AddCollateral => onAddCollateral(),
            _ when this == RemoveCollateral => onRemoveCollateral(),
            _ when this == CollateralReturnAfterLiquidation => onCollateralReturnAfterLiquidation(),
            _ => otherwise(Value)
        };

    public void Match(Action onBorrowIn,
        Action onCollateralSpent,
        Action onRepayAmount,
        Action onCollateralReturn,
        Action onAddCollateral,
        Action onRemoveCollateral,
        Action onCollateralReturnAfterLiquidation,
        Action<string> otherwise)
    {
        if (this == BorrowIn) onBorrowIn();
        else if (this == CollateralSpent) onCollateralSpent();
        else if (this == RepayAmount) onRepayAmount();
        else if (this == CollateralReturn) onCollateralReturn();
        else if (this == AddCollateral) onAddCollateral();
        else if (this == RemoveCollateral) onRemoveCollateral();
        else if (this == CollateralReturnAfterLiquidation) onCollateralReturnAfterLiquidation();
        else otherwise(Value);
    }
}
