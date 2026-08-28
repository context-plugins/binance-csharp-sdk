using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryMarginAvailableInventoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryMarginAvailableInventoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryMarginAvailableInventoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryMarginAvailableInventoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryMarginAvailableInventoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryMarginAvailableInventoryUserDataErrorResponse : IErrorResponse<QueryMarginAvailableInventoryUserDataError>
{
    public static QueryMarginAvailableInventoryUserDataErrorResponse Instance { get; } = new();

    private QueryMarginAvailableInventoryUserDataErrorResponse()
    {
    }

    public Task<QueryMarginAvailableInventoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryMarginAvailableInventoryUserDataError.Create(response, ct);
}
