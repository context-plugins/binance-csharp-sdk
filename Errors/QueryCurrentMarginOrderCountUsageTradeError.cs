using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryCurrentMarginOrderCountUsageTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryCurrentMarginOrderCountUsageTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryCurrentMarginOrderCountUsageTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryCurrentMarginOrderCountUsageTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryCurrentMarginOrderCountUsageTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryCurrentMarginOrderCountUsageTradeErrorResponse : IErrorResponse<QueryCurrentMarginOrderCountUsageTradeError>
{
    public static QueryCurrentMarginOrderCountUsageTradeErrorResponse Instance { get; } = new();

    private QueryCurrentMarginOrderCountUsageTradeErrorResponse()
    {
    }

    public Task<QueryCurrentMarginOrderCountUsageTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryCurrentMarginOrderCountUsageTradeError.Create(response, ct);
}
