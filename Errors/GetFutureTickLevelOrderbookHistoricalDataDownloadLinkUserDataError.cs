using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

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

    internal static Task<GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataErrorResponse : IErrorResponse<GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError>
{
    public static GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataErrorResponse Instance { get; } = new();

    private GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataErrorResponse()
    {
    }

    public Task<GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError.Create(response, ct);
}
