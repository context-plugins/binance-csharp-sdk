using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingSide>))]
public sealed record PendingSide : StringEnum<PendingSide>
{
    private PendingSide(string value) : base(value)
    {
    }

    public static readonly PendingSide Buy = new("BUY");

    public static readonly PendingSide Sell = new("SELL");

    public static PendingSide FromValue(string value) => FromValueCore(value);
}
