using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type8>))]
public sealed record Type8 : StringEnum<Type8>
{
    private Type8(string value) : base(value)
    {
    }

    public static readonly Type8 Activity = new("ACTIVITY");

    public static readonly Type8 CustomizedFixed = new("CUSTOMIZED_FIXED");

    public static Type8 FromValue(string value) => FromValueCore(value);
}
