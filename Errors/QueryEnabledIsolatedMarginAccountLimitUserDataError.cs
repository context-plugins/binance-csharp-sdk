using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryEnabledIsolatedMarginAccountLimitUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryEnabledIsolatedMarginAccountLimitUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryEnabledIsolatedMarginAccountLimitUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryEnabledIsolatedMarginAccountLimitUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryEnabledIsolatedMarginAccountLimitUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryEnabledIsolatedMarginAccountLimitUserDataErrorResponse : IErrorResponse<QueryEnabledIsolatedMarginAccountLimitUserDataError>
{
    public static QueryEnabledIsolatedMarginAccountLimitUserDataErrorResponse Instance { get; } = new();

    private QueryEnabledIsolatedMarginAccountLimitUserDataErrorResponse()
    {
    }

    public Task<QueryEnabledIsolatedMarginAccountLimitUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => QueryEnabledIsolatedMarginAccountLimitUserDataError.Create(response, ct);
}
