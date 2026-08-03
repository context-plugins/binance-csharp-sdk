using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InterestBnbburn>))]
public sealed record InterestBnbburn : StringEnum<InterestBnbburn>
{
    private InterestBnbburn(string value) : base(value)
    {
    }

    public static readonly InterestBnbburn True = new("true");

    public static readonly InterestBnbburn False = new("false");

    public static InterestBnbburn FromValue(string value) => FromValueCore(value);
}
