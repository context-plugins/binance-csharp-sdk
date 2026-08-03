using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryIsolatedMarginAccountInfoUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryIsolatedMarginAccountInfoUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryIsolatedMarginAccountInfoUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryIsolatedMarginAccountInfoUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryIsolatedMarginAccountInfoUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryIsolatedMarginAccountInfoUserDataErrorResponse : IErrorResponse<QueryIsolatedMarginAccountInfoUserDataError>
{
    public static QueryIsolatedMarginAccountInfoUserDataErrorResponse Instance { get; } = new();

    private QueryIsolatedMarginAccountInfoUserDataErrorResponse()
    {
    }

    public Task<QueryIsolatedMarginAccountInfoUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryIsolatedMarginAccountInfoUserDataError.Create(response, ct);
}
