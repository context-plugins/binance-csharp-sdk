using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetNftDepositHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetNftDepositHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetNftDepositHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetNftDepositHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetNftDepositHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetNftDepositHistoryUserDataErrorResponse : IErrorResponse<GetNftDepositHistoryUserDataError>
{
    public static GetNftDepositHistoryUserDataErrorResponse Instance { get; } = new();

    private GetNftDepositHistoryUserDataErrorResponse()
    {
    }

    public Task<GetNftDepositHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetNftDepositHistoryUserDataError.Create(response, ct);
}
