using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<NeedBtcValuation>))]
public sealed record NeedBtcValuation : StringEnum<NeedBtcValuation>
{
    private NeedBtcValuation(string value) : base(value)
    {
    }

    public static readonly NeedBtcValuation True = new("true");

    public static readonly NeedBtcValuation False = new("false");

    public static NeedBtcValuation FromValue(string value) => FromValueCore(value);
}
