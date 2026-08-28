using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class BorrowFlexibleLoanBorrowTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private BorrowFlexibleLoanBorrowTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static BorrowFlexibleLoanBorrowTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static BorrowFlexibleLoanBorrowTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<BorrowFlexibleLoanBorrowTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BorrowFlexibleLoanBorrowTradeErrorResponse : IErrorResponse<BorrowFlexibleLoanBorrowTradeError>
{
    public static BorrowFlexibleLoanBorrowTradeErrorResponse Instance { get; } = new();

    private BorrowFlexibleLoanBorrowTradeErrorResponse()
    {
    }

    public Task<BorrowFlexibleLoanBorrowTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BorrowFlexibleLoanBorrowTradeError.Create(response, ct);
}
