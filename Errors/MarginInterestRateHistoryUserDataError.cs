using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class MarginInterestRateHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginInterestRateHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginInterestRateHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MarginInterestRateHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MarginInterestRateHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MarginInterestRateHistoryUserDataErrorResponse : IErrorResponse<MarginInterestRateHistoryUserDataError>
{
    public static MarginInterestRateHistoryUserDataErrorResponse Instance { get; } = new();

    private MarginInterestRateHistoryUserDataErrorResponse()
    {
    }

    public Task<MarginInterestRateHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MarginInterestRateHistoryUserDataError.Create(response, ct);
}
