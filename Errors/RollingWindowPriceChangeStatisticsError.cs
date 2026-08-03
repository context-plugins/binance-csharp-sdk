using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class RollingWindowPriceChangeStatisticsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RollingWindowPriceChangeStatisticsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RollingWindowPriceChangeStatisticsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RollingWindowPriceChangeStatisticsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RollingWindowPriceChangeStatisticsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RollingWindowPriceChangeStatisticsErrorResponse : IErrorResponse<RollingWindowPriceChangeStatisticsError>
{
    public static RollingWindowPriceChangeStatisticsErrorResponse Instance { get; } = new();

    private RollingWindowPriceChangeStatisticsErrorResponse()
    {
    }

    public Task<RollingWindowPriceChangeStatisticsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RollingWindowPriceChangeStatisticsError.Create(response, ct);
}
