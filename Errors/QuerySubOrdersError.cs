using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QuerySubOrdersError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QuerySubOrdersError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QuerySubOrdersError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static QuerySubOrdersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QuerySubOrdersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QuerySubOrdersErrorResponse : IErrorResponse<QuerySubOrdersError>
{
    public static QuerySubOrdersErrorResponse Instance { get; } = new();

    private QuerySubOrdersErrorResponse()
    {
    }

    public Task<QuerySubOrdersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QuerySubOrdersError.Create(response, ct);
}
