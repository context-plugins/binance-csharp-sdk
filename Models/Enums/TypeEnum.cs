using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Full = new("FULL");

    public static readonly TypeEnum Mini = new("MINI");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
