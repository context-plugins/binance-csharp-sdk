using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : StringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status All = new("ALL");

    public static readonly Status Subscribable = new("SUBSCRIBABLE");

    public static readonly Status Unsubscribable = new("UNSUBSCRIBABLE");

    public static Status FromValue(string value) => FromValueCore(value);
}
