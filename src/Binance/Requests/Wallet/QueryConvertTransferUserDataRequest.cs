using Binance.Models.Enums;

namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the QueryConvertTransferUserData operation.
/// </summary>
public sealed record QueryConvertTransferUserDataRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long EndTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// The transaction id
    /// </summary>
    public long? TranId { get; init; }

    /// <summary>
    /// If it is blank, we will match deducted asset and target asset.
    /// </summary>
    public string? Asset { get; init; }

    /// <summary>
    /// MAIN: main account. CARD: funding account. If it is blank, we will query spot and card wallet, otherwise, we just query the corresponding wallet
    /// </summary>
    public AccountType3? AccountType { get; init; }

    /// <summary>
    /// Current querying page. Start from 1. Default:1
    /// </summary>
    public int? Current { get; init; }

    /// <summary>
    /// Default:10 Max:100
    /// </summary>
    public int? Size { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
