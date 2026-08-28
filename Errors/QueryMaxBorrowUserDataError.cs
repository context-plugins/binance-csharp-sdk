using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryMaxBorrowUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryMaxBorrowUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryMaxBorrowUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryMaxBorrowUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryMaxBorrowUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryMaxBorrowUserDataErrorResponse : IErrorResponse<QueryMaxBorrowUserDataError>
{
    public static QueryMaxBorrowUserDataErrorResponse Instance { get; } = new();

    private QueryMaxBorrowUserDataErrorResponse()
    {
    }

    public Task<QueryMaxBorrowUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryMaxBorrowUserDataError.Create(response, ct);
}
