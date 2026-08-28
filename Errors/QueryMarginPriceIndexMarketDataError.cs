using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryMarginPriceIndexMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryMarginPriceIndexMarketDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryMarginPriceIndexMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryMarginPriceIndexMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryMarginPriceIndexMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryMarginPriceIndexMarketDataErrorResponse : IErrorResponse<QueryMarginPriceIndexMarketDataError>
{
    public static QueryMarginPriceIndexMarketDataErrorResponse Instance { get; } = new();

    private QueryMarginPriceIndexMarketDataErrorResponse()
    {
    }

    public Task<QueryMarginPriceIndexMarketDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryMarginPriceIndexMarketDataError.Create(response, ct);
}
