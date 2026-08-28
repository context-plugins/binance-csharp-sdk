using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryCrossMarginAccountDetailsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryCrossMarginAccountDetailsUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryCrossMarginAccountDetailsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryCrossMarginAccountDetailsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryCrossMarginAccountDetailsUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryCrossMarginAccountDetailsUserDataErrorResponse : IErrorResponse<QueryCrossMarginAccountDetailsUserDataError>
{
    public static QueryCrossMarginAccountDetailsUserDataErrorResponse Instance { get; } = new();

    private QueryCrossMarginAccountDetailsUserDataErrorResponse()
    {
    }

    public Task<QueryCrossMarginAccountDetailsUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryCrossMarginAccountDetailsUserDataError.Create(response, ct);
}
