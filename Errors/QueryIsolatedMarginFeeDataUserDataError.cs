using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryIsolatedMarginFeeDataUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryIsolatedMarginFeeDataUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryIsolatedMarginFeeDataUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryIsolatedMarginFeeDataUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryIsolatedMarginFeeDataUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryIsolatedMarginFeeDataUserDataErrorResponse : IErrorResponse<QueryIsolatedMarginFeeDataUserDataError>
{
    public static QueryIsolatedMarginFeeDataUserDataErrorResponse Instance { get; } = new();

    private QueryIsolatedMarginFeeDataUserDataErrorResponse()
    {
    }

    public Task<QueryIsolatedMarginFeeDataUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryIsolatedMarginFeeDataUserDataError.Create(response, ct);
}
