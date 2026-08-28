using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WorkingSide>))]
public sealed record WorkingSide : StringEnum<WorkingSide>
{
    private WorkingSide(string value) : base(value)
    {
    }

    public static readonly WorkingSide Buy = new("BUY");

    public static readonly WorkingSide Sell = new("SELL");

    public static WorkingSide FromValue(string value) => FromValueCore(value);
}
