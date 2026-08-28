using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class RepayGetFlexibleLoanRepaymentHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RepayGetFlexibleLoanRepaymentHistoryUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RepayGetFlexibleLoanRepaymentHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RepayGetFlexibleLoanRepaymentHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RepayGetFlexibleLoanRepaymentHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RepayGetFlexibleLoanRepaymentHistoryUserDataErrorResponse : IErrorResponse<RepayGetFlexibleLoanRepaymentHistoryUserDataError>
{
    public static RepayGetFlexibleLoanRepaymentHistoryUserDataErrorResponse Instance { get; } = new();

    private RepayGetFlexibleLoanRepaymentHistoryUserDataErrorResponse()
    {
    }

    public Task<RepayGetFlexibleLoanRepaymentHistoryUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => RepayGetFlexibleLoanRepaymentHistoryUserDataError.Create(response, ct);
}
