using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class BorrowGetFlexibleLoanBorrowHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private BorrowGetFlexibleLoanBorrowHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static BorrowGetFlexibleLoanBorrowHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static BorrowGetFlexibleLoanBorrowHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<BorrowGetFlexibleLoanBorrowHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BorrowGetFlexibleLoanBorrowHistoryUserDataErrorResponse : IErrorResponse<BorrowGetFlexibleLoanBorrowHistoryUserDataError>
{
    public static BorrowGetFlexibleLoanBorrowHistoryUserDataErrorResponse Instance { get; } = new();

    private BorrowGetFlexibleLoanBorrowHistoryUserDataErrorResponse()
    {
    }

    public Task<BorrowGetFlexibleLoanBorrowHistoryUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => BorrowGetFlexibleLoanBorrowHistoryUserDataError.Create(response, ct);
}
