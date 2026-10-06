using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status2>))]
public sealed record Status2 : OpenStringEnum<Status2>
{
    private Status2(string value) : base(value)
    {
    }

    public static readonly Status2 Pending = new("PENDING");

    public static readonly Status2 PurchaseSuccess = new("PURCHASE_SUCCESS");

    public static readonly Status2 Settled = new("SETTLED");

    public static readonly Status2 PurchaseFail = new("PURCHASE_FAIL");

    public static readonly Status2 Refunding = new("REFUNDING");

    public static readonly Status2 RefundSuccess = new("REFUND_SUCCESS");

    public static readonly Status2 Settling = new("SETTLING");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onPurchaseSuccess,
        Func<TResult> onSettled,
        Func<TResult> onPurchaseFail,
        Func<TResult> onRefunding,
        Func<TResult> onRefundSuccess,
        Func<TResult> onSettling,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == PurchaseSuccess => onPurchaseSuccess(),
            _ when this == Settled => onSettled(),
            _ when this == PurchaseFail => onPurchaseFail(),
            _ when this == Refunding => onRefunding(),
            _ when this == RefundSuccess => onRefundSuccess(),
            _ when this == Settling => onSettling(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onPurchaseSuccess,
        Action onSettled,
        Action onPurchaseFail,
        Action onRefunding,
        Action onRefundSuccess,
        Action onSettling,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == PurchaseSuccess) onPurchaseSuccess();
        else if (this == Settled) onSettled();
        else if (this == PurchaseFail) onPurchaseFail();
        else if (this == Refunding) onRefunding();
        else if (this == RefundSuccess) onRefundSuccess();
        else if (this == Settling) onSettling();
        else otherwise(Value);
    }
}
