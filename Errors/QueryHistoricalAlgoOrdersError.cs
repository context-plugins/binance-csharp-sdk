using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryHistoricalAlgoOrdersError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryHistoricalAlgoOrdersError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryHistoricalAlgoOrdersError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryHistoricalAlgoOrdersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryHistoricalAlgoOrdersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryHistoricalAlgoOrdersErrorResponse : IErrorResponse<QueryHistoricalAlgoOrdersError>
{
    public static QueryHistoricalAlgoOrdersErrorResponse Instance { get; } = new();

    private QueryHistoricalAlgoOrdersErrorResponse()
    {
    }

    public Task<QueryHistoricalAlgoOrdersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryHistoricalAlgoOrdersError.Create(response, ct);
}
