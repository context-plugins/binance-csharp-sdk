using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountType>))]
public sealed record AccountType : StringEnum<AccountType>
{
    private AccountType(string value) : base(value)
    {
    }

    public static readonly AccountType Spot = new("SPOT");

    public static readonly AccountType Margin = new("MARGIN");

    public static AccountType FromValue(string value) => FromValueCore(value);
}
