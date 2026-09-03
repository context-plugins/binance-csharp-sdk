using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<NewOrderRespType>))]
public sealed record NewOrderRespType : StringEnum<NewOrderRespType>
{
    private NewOrderRespType(string value) : base(value)
    {
    }

    public static readonly NewOrderRespType Ack = new("ACK");

    public static readonly NewOrderRespType Result = new("RESULT");

    public static readonly NewOrderRespType Full = new("FULL");

    public static NewOrderRespType FromValue(string value) => FromValueCore(value);
}
