using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : StringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 RollIn = new("ROLL_IN");

    public static readonly Type2 RollOut = new("ROLL_OUT");

    public static Type2 FromValue(string value) => FromValueCore(value);
}
