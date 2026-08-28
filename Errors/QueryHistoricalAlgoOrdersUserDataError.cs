using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryHistoricalAlgoOrdersUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryHistoricalAlgoOrdersUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryHistoricalAlgoOrdersUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryHistoricalAlgoOrdersUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryHistoricalAlgoOrdersUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryHistoricalAlgoOrdersUserDataErrorResponse : IErrorResponse<QueryHistoricalAlgoOrdersUserDataError>
{
    public static QueryHistoricalAlgoOrdersUserDataErrorResponse Instance { get; } = new();

    private QueryHistoricalAlgoOrdersUserDataErrorResponse()
    {
    }

    public Task<QueryHistoricalAlgoOrdersUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryHistoricalAlgoOrdersUserDataError.Create(response, ct);
}
