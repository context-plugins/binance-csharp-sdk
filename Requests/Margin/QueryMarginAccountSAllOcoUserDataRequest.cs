using Binance.Models.Enums;

namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the QueryMarginAccountSAllOcoUserData operation.
/// </summary>
public sealed record QueryMarginAccountSAllOcoUserDataRequest
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
    /// If supplied, neither <c>startTime</c> or <c>endTime</c> can be provided
    /// </summary>
    public string? FromId { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Default Value: 500; Max Value: 1000
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
