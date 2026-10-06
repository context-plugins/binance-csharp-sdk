using Binance.Models.Enums;

namespace Binance.Requests.PortfolioMargin;

/// <summary>
/// The inputs of the BnbTransferUserData operation.
/// </summary>
public sealed record BnbTransferUserDataRequest
{
    public required TransferSide TransferSide { get; init; }

    public required double Amount { get; init; }

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
