using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetVipLoanRepaymentHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetVipLoanRepaymentHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetVipLoanRepaymentHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetVipLoanRepaymentHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetVipLoanRepaymentHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVipLoanRepaymentHistoryUserDataErrorResponse : IErrorResponse<GetVipLoanRepaymentHistoryUserDataError>
{
    public static GetVipLoanRepaymentHistoryUserDataErrorResponse Instance { get; } = new();

    private GetVipLoanRepaymentHistoryUserDataErrorResponse()
    {
    }

    public Task<GetVipLoanRepaymentHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVipLoanRepaymentHistoryUserDataError.Create(response, ct);
}
