using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryPortfolioMarginAssetIndexPriceMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryPortfolioMarginAssetIndexPriceMarketDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryPortfolioMarginAssetIndexPriceMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryPortfolioMarginAssetIndexPriceMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryPortfolioMarginAssetIndexPriceMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryPortfolioMarginAssetIndexPriceMarketDataErrorResponse : IErrorResponse<QueryPortfolioMarginAssetIndexPriceMarketDataError>
{
    public static QueryPortfolioMarginAssetIndexPriceMarketDataErrorResponse Instance { get; } = new();

    private QueryPortfolioMarginAssetIndexPriceMarketDataErrorResponse()
    {
    }

    public Task<QueryPortfolioMarginAssetIndexPriceMarketDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => QueryPortfolioMarginAssetIndexPriceMarketDataError.Create(response, ct);
}
