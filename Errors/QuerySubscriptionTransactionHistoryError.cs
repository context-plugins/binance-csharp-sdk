using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QuerySubscriptionTransactionHistoryError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QuerySubscriptionTransactionHistoryError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QuerySubscriptionTransactionHistoryError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QuerySubscriptionTransactionHistoryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QuerySubscriptionTransactionHistoryError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QuerySubscriptionTransactionHistoryErrorResponse : IErrorResponse<QuerySubscriptionTransactionHistoryError>
{
    public static QuerySubscriptionTransactionHistoryErrorResponse Instance { get; } = new();

    private QuerySubscriptionTransactionHistoryErrorResponse()
    {
    }

    public Task<QuerySubscriptionTransactionHistoryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QuerySubscriptionTransactionHistoryError.Create(response, ct);
}
