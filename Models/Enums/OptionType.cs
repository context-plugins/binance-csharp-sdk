using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<OptionType>))]
public sealed record OptionType : StringEnum<OptionType>
{
    private OptionType(string value) : base(value)
    {
    }

    public static readonly OptionType Call = new("CALL");

    public static readonly OptionType Put = new("PUT");

    public static OptionType FromValue(string value) => FromValueCore(value);
}
