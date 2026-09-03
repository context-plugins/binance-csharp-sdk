using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class FiatDepositWithdrawHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FiatDepositWithdrawHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FiatDepositWithdrawHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FiatDepositWithdrawHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FiatDepositWithdrawHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FiatDepositWithdrawHistoryUserDataErrorResponse : IErrorResponse<FiatDepositWithdrawHistoryUserDataError>
{
    public static FiatDepositWithdrawHistoryUserDataErrorResponse Instance { get; } = new();

    private FiatDepositWithdrawHistoryUserDataErrorResponse()
    {
    }

    public Task<FiatDepositWithdrawHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FiatDepositWithdrawHistoryUserDataError.Create(response, ct);
}
