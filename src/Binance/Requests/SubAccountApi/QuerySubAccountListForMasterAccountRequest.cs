using Binance.Models.Enums;

namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the QuerySubAccountListForMasterAccount operation.
/// </summary>
public sealed record QuerySubAccountListForMasterAccountRequest
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
    /// Sub-account email
    /// </summary>
    public string? Email { get; init; }

    public IsFreeze? IsFreeze { get; init; }

    /// <summary>
    /// Default 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Default 1; max 200
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
