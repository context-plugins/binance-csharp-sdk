using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetLoanRepaymentHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLoanRepaymentHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLoanRepaymentHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLoanRepaymentHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLoanRepaymentHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLoanRepaymentHistoryUserDataErrorResponse : IErrorResponse<GetLoanRepaymentHistoryUserDataError>
{
    public static GetLoanRepaymentHistoryUserDataErrorResponse Instance { get; } = new();

    private GetLoanRepaymentHistoryUserDataErrorResponse()
    {
    }

    public Task<GetLoanRepaymentHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLoanRepaymentHistoryUserDataError.Create(response, ct);
}
