using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IsFreeze>))]
public sealed record IsFreeze : StringEnum<IsFreeze>
{
    private IsFreeze(string value) : base(value)
    {
    }

    public static readonly IsFreeze True = new("true");

    public static readonly IsFreeze False = new("false");

    public static IsFreeze FromValue(string value) => FromValueCore(value);
}
