using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Transfers>))]
public sealed record Transfers : StringEnum<Transfers>
{
    private Transfers(string value) : base(value)
    {
    }

    public static readonly Transfers From = new("FROM");

    public static readonly Transfers To = new("TO");

    public static Transfers FromValue(string value) => FromValueCore(value);
}
