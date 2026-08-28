using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CryptoLoanBorrowTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CryptoLoanBorrowTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CryptoLoanBorrowTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CryptoLoanBorrowTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CryptoLoanBorrowTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CryptoLoanBorrowTradeErrorResponse : IErrorResponse<CryptoLoanBorrowTradeError>
{
    public static CryptoLoanBorrowTradeErrorResponse Instance { get; } = new();

    private CryptoLoanBorrowTradeErrorResponse()
    {
    }

    public Task<CryptoLoanBorrowTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CryptoLoanBorrowTradeError.Create(response, ct);
}
