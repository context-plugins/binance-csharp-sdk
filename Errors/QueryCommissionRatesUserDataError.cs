using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryCommissionRatesUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryCommissionRatesUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryCommissionRatesUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryCommissionRatesUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryCommissionRatesUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryCommissionRatesUserDataErrorResponse : IErrorResponse<QueryCommissionRatesUserDataError>
{
    public static QueryCommissionRatesUserDataErrorResponse Instance { get; } = new();

    private QueryCommissionRatesUserDataErrorResponse()
    {
    }

    public Task<QueryCommissionRatesUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryCommissionRatesUserDataError.Create(response, ct);
}
