namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the MarginAccountBorrowRepayMargin operation.
/// </summary>
public sealed record MarginAccountBorrowRepayMarginRequest
{
    public required string Asset { get; init; }

    /// <summary>
    /// TRUE for isolated margin, FALSE for crossed margin
    /// </summary>
    public required string IsIsolated { get; init; }

    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    public required double Amount { get; init; }

    /// <summary>
    /// BORROW or REPAY
    /// </summary>
    public required string Type { get; init; }

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
