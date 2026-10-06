namespace Binance.Requests.ConvertApi;

/// <summary>
/// The inputs of the ListAllConvertPairs operation.
/// </summary>
public sealed record ListAllConvertPairsRequest
{
    /// <summary>
    /// User spends coin
    /// </summary>
    public string? FromAsset { get; init; }

    /// <summary>
    /// User receives coin
    /// </summary>
    public string? ToAsset { get; init; }
}
