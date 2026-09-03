using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Side>))]
public sealed record Side : StringEnum<Side>
{
    private Side(string value) : base(value)
    {
    }

    public static readonly Side Sell = new("SELL");

    public static readonly Side Buy = new("BUY");

    public static Side FromValue(string value) => FromValueCore(value);
}
