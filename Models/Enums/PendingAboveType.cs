using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingAboveType>))]
public sealed record PendingAboveType : StringEnum<PendingAboveType>
{
    private PendingAboveType(string value) : base(value)
    {
    }

    public static readonly PendingAboveType LimitMaker = new("LIMIT_MAKER");

    public static readonly PendingAboveType StopLoss = new("STOP_LOSS");

    public static readonly PendingAboveType StopLossLimit = new("STOP_LOSS_LIMIT");

    public static PendingAboveType FromValue(string value) => FromValueCore(value);
}
