using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryUserWalletBalanceUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryUserWalletBalanceUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryUserWalletBalanceUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryUserWalletBalanceUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryUserWalletBalanceUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryUserWalletBalanceUserDataErrorResponse : IErrorResponse<QueryUserWalletBalanceUserDataError>
{
    public static QueryUserWalletBalanceUserDataErrorResponse Instance { get; } = new();

    private QueryUserWalletBalanceUserDataErrorResponse()
    {
    }

    public Task<QueryUserWalletBalanceUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryUserWalletBalanceUserDataError.Create(response, ct);
}
