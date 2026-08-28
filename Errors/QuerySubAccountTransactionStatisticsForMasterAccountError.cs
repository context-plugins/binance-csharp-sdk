using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QuerySubAccountTransactionStatisticsForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QuerySubAccountTransactionStatisticsForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QuerySubAccountTransactionStatisticsForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QuerySubAccountTransactionStatisticsForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QuerySubAccountTransactionStatisticsForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QuerySubAccountTransactionStatisticsForMasterAccountErrorResponse : IErrorResponse<QuerySubAccountTransactionStatisticsForMasterAccountError>
{
    public static QuerySubAccountTransactionStatisticsForMasterAccountErrorResponse Instance { get; } = new();

    private QuerySubAccountTransactionStatisticsForMasterAccountErrorResponse()
    {
    }

    public Task<QuerySubAccountTransactionStatisticsForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => QuerySubAccountTransactionStatisticsForMasterAccountError.Create(response, ct);
}
