using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryManagedSubAccountTransferLogForTradingTeamMasterAccountErrorResponse : IErrorResponse<QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError>
{
    public static QueryManagedSubAccountTransferLogForTradingTeamMasterAccountErrorResponse Instance { get; } = new();

    private QueryManagedSubAccountTransferLogForTradingTeamMasterAccountErrorResponse()
    {
    }

    public Task<QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError.Create(response, ct);
}
