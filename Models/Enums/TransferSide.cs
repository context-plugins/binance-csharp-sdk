using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TransferSide>))]
public sealed record TransferSide : StringEnum<TransferSide>
{
    private TransferSide(string value) : base(value)
    {
    }

    public static readonly TransferSide ToUm = new("TO_UM");

    public static readonly TransferSide FromUm = new("FROM_UM");

    public static TransferSide FromValue(string value) => FromValueCore(value);
}
