using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PendingBelowType>))]
public sealed record PendingBelowType : StringEnum<PendingBelowType>
{
    private PendingBelowType(string value) : base(value)
    {
    }

    public static readonly PendingBelowType LimitMaker = new("LIMIT_MAKER");

    public static readonly PendingBelowType StopLoss = new("STOP_LOSS");

    public static readonly PendingBelowType StopLossLimit = new("STOP_LOSS_LIMIT");

    public static PendingBelowType FromValue(string value) => FromValueCore(value);
}
