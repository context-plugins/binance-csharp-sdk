namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the ExchangeInformation operation.
/// </summary>
public sealed record ExchangeInformationRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public string? Symbol { get; init; }

    public string? Symbols { get; init; }

    public string? Permissions { get; init; }
}
