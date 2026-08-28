using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataErrorResponse : IErrorResponse<AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError>
{
    public static AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataErrorResponse Instance { get; } = new();

    private AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataErrorResponse()
    {
    }

    public Task<AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError.Create(response, ct);
}
