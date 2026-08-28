using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IsIsolated>))]
public sealed record IsIsolated : StringEnum<IsIsolated>
{
    private IsIsolated(string value) : base(value)
    {
    }

    public static readonly IsIsolated True = new("TRUE");

    public static readonly IsIsolated False = new("FALSE");

    public static IsIsolated FromValue(string value) => FromValueCore(value);
}
