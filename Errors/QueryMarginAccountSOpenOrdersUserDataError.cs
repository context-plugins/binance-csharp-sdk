using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryMarginAccountSOpenOrdersUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryMarginAccountSOpenOrdersUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryMarginAccountSOpenOrdersUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryMarginAccountSOpenOrdersUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryMarginAccountSOpenOrdersUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryMarginAccountSOpenOrdersUserDataErrorResponse : IErrorResponse<QueryMarginAccountSOpenOrdersUserDataError>
{
    public static QueryMarginAccountSOpenOrdersUserDataErrorResponse Instance { get; } = new();

    private QueryMarginAccountSOpenOrdersUserDataErrorResponse()
    {
    }

    public Task<QueryMarginAccountSOpenOrdersUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryMarginAccountSOpenOrdersUserDataError.Create(response, ct);
}
