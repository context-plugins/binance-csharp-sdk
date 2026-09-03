using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class HrTickerPriceChangeStatistics24Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private HrTickerPriceChangeStatistics24Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static HrTickerPriceChangeStatistics24Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static HrTickerPriceChangeStatistics24Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<HrTickerPriceChangeStatistics24Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class HrTickerPriceChangeStatistics24ErrorResponse : IErrorResponse<HrTickerPriceChangeStatistics24Error>
{
    public static HrTickerPriceChangeStatistics24ErrorResponse Instance { get; } = new();

    private HrTickerPriceChangeStatistics24ErrorResponse()
    {
    }

    public Task<HrTickerPriceChangeStatistics24Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        HrTickerPriceChangeStatistics24Error.Create(response, ct);
}
