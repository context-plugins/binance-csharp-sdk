using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status2>))]
public sealed record Status2 : StringEnum<Status2>
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

    public static Status2 FromValue(string value) => FromValueCore(value);
}
