using Binance.Models.Enums;

namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the CryptoLoanAdjustLtvTrade operation.
/// </summary>
public sealed record CryptoLoanAdjustLtvTradeRequest
{
    /// <summary>
    /// Order ID
    /// </summary>
    public required long OrderId { get; init; }

    /// <summary>
    /// Amount
    /// </summary>
    public required double Amount { get; init; }

    /// <summary>
    /// 'ADDITIONAL', 'REDUCED'
    /// </summary>
    public required Direction Direction { get; init; }

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
