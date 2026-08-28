using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataErrorResponse : IErrorResponse<QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError>
{
    public static QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataErrorResponse Instance { get; } = new();

    private QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataErrorResponse()
    {
    }

    public Task<QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError.Create(response, ct);
}
