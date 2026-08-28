using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WalletType>))]
public sealed record WalletType : StringEnum<WalletType>
{
    private WalletType(string value) : base(value)
    {
    }

    public static readonly WalletType Spot = new("SPOT");

    public static readonly WalletType Funding = new("FUNDING");

    public static readonly WalletType SpotFunding = new("SPOT_FUNDING");

    public static WalletType FromValue(string value) => FromValueCore(value);
}
