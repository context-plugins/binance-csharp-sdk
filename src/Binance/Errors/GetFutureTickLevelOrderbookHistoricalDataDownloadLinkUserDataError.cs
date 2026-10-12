using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError> Response { get; } = new(
        Create);
}
