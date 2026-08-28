using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QuerySubscriptionRecordUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QuerySubscriptionRecordUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QuerySubscriptionRecordUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QuerySubscriptionRecordUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QuerySubscriptionRecordUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QuerySubscriptionRecordUserDataErrorResponse : IErrorResponse<QuerySubscriptionRecordUserDataError>
{
    public static QuerySubscriptionRecordUserDataErrorResponse Instance { get; } = new();

    private QuerySubscriptionRecordUserDataErrorResponse()
    {
    }

    public Task<QuerySubscriptionRecordUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QuerySubscriptionRecordUserDataError.Create(response, ct);
}
