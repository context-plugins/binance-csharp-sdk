using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryAutoConvertingStableCoinsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryAutoConvertingStableCoinsUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryAutoConvertingStableCoinsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryAutoConvertingStableCoinsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryAutoConvertingStableCoinsUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryAutoConvertingStableCoinsUserDataErrorResponse : IErrorResponse<QueryAutoConvertingStableCoinsUserDataError>
{
    public static QueryAutoConvertingStableCoinsUserDataErrorResponse Instance { get; } = new();

    private QueryAutoConvertingStableCoinsUserDataErrorResponse()
    {
    }

    public Task<QueryAutoConvertingStableCoinsUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryAutoConvertingStableCoinsUserDataError.Create(response, ct);
}
