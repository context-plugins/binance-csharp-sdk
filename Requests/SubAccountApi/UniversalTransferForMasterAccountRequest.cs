using Binance.Models.Enums;

namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the UniversalTransferForMasterAccount operation.
/// </summary>
public sealed record UniversalTransferForMasterAccountRequest
{
    public required FromAccountType FromAccountType { get; init; }

    public required ToAccountType ToAccountType { get; init; }

    public required string Asset { get; init; }

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
    /// Sub-account email
    /// </summary>
    public string? FromEmail { get; init; }

    /// <summary>
    /// Sub-account email
    /// </summary>
    public string? ToEmail { get; init; }

    public string? ClientTranId { get; init; }

    /// <summary>
    /// Only supported under ISOLATED_MARGIN type
    /// </summary>
    public string? Symbol { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
