using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Urgency>))]
public sealed record Urgency : StringEnum<Urgency>
{
    private Urgency(string value) : base(value)
    {
    }

    public static readonly Urgency Low = new("LOW");

    public static readonly Urgency Medium = new("MEDIUM");

    public static readonly Urgency High = new("HIGH");

    public static Urgency FromValue(string value) => FromValueCore(value);
}
