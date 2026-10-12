namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the AdjustCrossMarginMaxLeverageUserData operation.
/// </summary>
public sealed record AdjustCrossMarginMaxLeverageUserDataRequest
{
    /// <summary>
    /// Can only adjust 3 or 5
    /// </summary>
    public required int MaxLeverage { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
