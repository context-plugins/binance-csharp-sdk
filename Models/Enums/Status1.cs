using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : StringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Ongoing = new("ONGOING");

    public static readonly Status1 Paused = new("PAUSED");

    public static readonly Status1 Removed = new("REMOVED");

    public static Status1 FromValue(string value) => FromValueCore(value);
}
