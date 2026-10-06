namespace Binance.Requests.PortfolioMargin;

/// <summary>
/// The inputs of the QueryPortfolioMarginAssetIndexPriceMarketData operation.
/// </summary>
public sealed record QueryPortfolioMarginAssetIndexPriceMarketDataRequest
{
    public string? Asset { get; init; }
}
