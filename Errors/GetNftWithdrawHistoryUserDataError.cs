using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetNftWithdrawHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetNftWithdrawHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetNftWithdrawHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetNftWithdrawHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetNftWithdrawHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetNftWithdrawHistoryUserDataErrorResponse : IErrorResponse<GetNftWithdrawHistoryUserDataError>
{
    public static GetNftWithdrawHistoryUserDataErrorResponse Instance { get; } = new();

    private GetNftWithdrawHistoryUserDataErrorResponse()
    {
    }

    public Task<GetNftWithdrawHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetNftWithdrawHistoryUserDataError.Create(response, ct);
}
