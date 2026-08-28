using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InterestBnbBurn>))]
public sealed record InterestBnbBurn : StringEnum<InterestBnbBurn>
{
    private InterestBnbBurn(string value) : base(value)
    {
    }

    public static readonly InterestBnbBurn True = new("true");

    public static readonly InterestBnbBurn False = new("false");

    public static InterestBnbBurn FromValue(string value) => FromValueCore(value);
}
