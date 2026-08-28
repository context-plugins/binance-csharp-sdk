using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

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
