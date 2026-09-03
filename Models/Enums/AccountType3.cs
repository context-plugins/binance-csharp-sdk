using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountType3>))]
public sealed record AccountType3 : StringEnum<AccountType3>
{
    private AccountType3(string value) : base(value)
    {
    }

    public static readonly AccountType3 Main = new("MAIN");

    public static readonly AccountType3 Card = new("CARD");

    public static AccountType3 FromValue(string value) => FromValueCore(value);
}
