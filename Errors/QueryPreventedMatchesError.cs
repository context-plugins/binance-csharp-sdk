using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryPreventedMatchesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryPreventedMatchesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryPreventedMatchesError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryPreventedMatchesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryPreventedMatchesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryPreventedMatchesErrorResponse : IErrorResponse<QueryPreventedMatchesError>
{
    public static QueryPreventedMatchesErrorResponse Instance { get; } = new();

    private QueryPreventedMatchesErrorResponse()
    {
    }

    public Task<QueryPreventedMatchesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryPreventedMatchesError.Create(response, ct);
}
