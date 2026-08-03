using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Enum;

namespace BinancePublicSpotApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SortBy>))]
public sealed record SortBy : StringEnum<SortBy>
{
    private SortBy(string value) : base(value)
    {
    }

    public static readonly SortBy StartTime = new("START_TIME");

    public static readonly SortBy LotSize = new("LOT_SIZE");

    public static readonly SortBy InterestRate = new("INTEREST_RATE");

    public static readonly SortBy Duration = new("DURATION");

    public static SortBy FromValue(string value) => FromValueCore(value);
}
