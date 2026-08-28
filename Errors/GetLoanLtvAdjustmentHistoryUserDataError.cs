using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetLoanLtvAdjustmentHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLoanLtvAdjustmentHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLoanLtvAdjustmentHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLoanLtvAdjustmentHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLoanLtvAdjustmentHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLoanLtvAdjustmentHistoryUserDataErrorResponse : IErrorResponse<GetLoanLtvAdjustmentHistoryUserDataError>
{
    public static GetLoanLtvAdjustmentHistoryUserDataErrorResponse Instance { get; } = new();

    private GetLoanLtvAdjustmentHistoryUserDataErrorResponse()
    {
    }

    public Task<GetLoanLtvAdjustmentHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLoanLtvAdjustmentHistoryUserDataError.Create(response, ct);
}
