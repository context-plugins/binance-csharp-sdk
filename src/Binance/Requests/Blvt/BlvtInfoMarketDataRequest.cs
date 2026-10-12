namespace Binance.Requests.Blvt;

/// <summary>
/// The inputs of the BlvtInfoMarketData operation.
/// </summary>
public sealed record BlvtInfoMarketDataRequest
{
    /// <summary>
    /// BTCDOWN, BTCUP
    /// </summary>
    public string? TokenName { get; init; }
}
