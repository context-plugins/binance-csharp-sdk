namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the GetAllMarginAssetsMarketData operation.
/// </summary>
public sealed record GetAllMarginAssetsMarketDataRequest
{
    public required string Asset { get; init; }
}
