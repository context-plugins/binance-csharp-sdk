using Binance.Models.Enums;

namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the QueryMarginAccountSOcoUserData operation.
/// </summary>
public sealed record QueryMarginAccountSOcoUserDataRequest
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
    /// <list type="bullet">
    ///   <item><description><c>TRUE</c> - For isolated margin</description></item>
    ///   <item><description><c>FALSE</c> - Default, not for isolated margin</description></item>
    /// </list>
    /// </summary>
    public IsIsolated? IsIsolated { get; init; }

    /// <summary>
    /// Mandatory for isolated margin, not supported for cross margin
    /// </summary>
    public string? Symbol { get; init; }

    /// <summary>
    /// Order list id
    /// </summary>
    public long? OrderListId { get; init; }

    /// <summary>
    /// Order id from client
    /// </summary>
    public string? OrigClientOrderId { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
