using Binance.Models.Enums;

namespace Binance.Requests.DualInvestment;

/// <summary>
/// The inputs of the GetDualInvestmentPositionsUserData operation.
/// </summary>
public sealed record GetDualInvestmentPositionsUserDataRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// - PENDING: Products are purchasing, will give results later;
    /// - PURCHASE_SUCCESS: purchase successfully;
    /// - SETTLED: Products are finish settling;
    /// - PURCHASE_FAIL: fail to purchase;
    /// - REFUNDING: refund ongoing;
    /// - REFUND_SUCCESS: refund to spot account successfully;
    /// - SETTLING: Products are settling.
    /// If don't fill this field, will response all the position status.
    /// </summary>
    public Status2? Status { get; init; }

    /// <summary>
    /// MIN 1, MAX 100; Default 100
    /// </summary>
    public string? PageSize { get; init; }

    /// <summary>
    /// Page number, default is first page, start form 1
    /// </summary>
    public int? PageIndex { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
