using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryUserUniversalTransferHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryUserUniversalTransferHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryUserUniversalTransferHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryUserUniversalTransferHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryUserUniversalTransferHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryUserUniversalTransferHistoryUserDataErrorResponse : IErrorResponse<QueryUserUniversalTransferHistoryUserDataError>
{
    public static QueryUserUniversalTransferHistoryUserDataErrorResponse Instance { get; } = new();

    private QueryUserUniversalTransferHistoryUserDataErrorResponse()
    {
    }

    public Task<QueryUserUniversalTransferHistoryUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => QueryUserUniversalTransferHistoryUserDataError.Create(response, ct);
}
