using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryBorrowRepayRecordsInMarginAccountUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryBorrowRepayRecordsInMarginAccountUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryBorrowRepayRecordsInMarginAccountUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryBorrowRepayRecordsInMarginAccountUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryBorrowRepayRecordsInMarginAccountUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryBorrowRepayRecordsInMarginAccountUserDataErrorResponse : IErrorResponse<QueryBorrowRepayRecordsInMarginAccountUserDataError>
{
    public static QueryBorrowRepayRecordsInMarginAccountUserDataErrorResponse Instance { get; } = new();

    private QueryBorrowRepayRecordsInMarginAccountUserDataErrorResponse()
    {
    }

    public Task<QueryBorrowRepayRecordsInMarginAccountUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => QueryBorrowRepayRecordsInMarginAccountUserDataError.Create(response, ct);
}
