using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryIsolatedMarginTierDataUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryIsolatedMarginTierDataUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryIsolatedMarginTierDataUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryIsolatedMarginTierDataUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryIsolatedMarginTierDataUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryIsolatedMarginTierDataUserDataErrorResponse : IErrorResponse<QueryIsolatedMarginTierDataUserDataError>
{
    public static QueryIsolatedMarginTierDataUserDataErrorResponse Instance { get; } = new();

    private QueryIsolatedMarginTierDataUserDataErrorResponse()
    {
    }

    public Task<QueryIsolatedMarginTierDataUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryIsolatedMarginTierDataUserDataError.Create(response, ct);
}
