using Binance.Core.Validation.Attributes;

namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the WithdrawHistorySupportingNetworkUserData operation.
/// </summary>
public sealed record WithdrawHistorySupportingNetworkUserDataRequest
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
    /// Coin name
    /// </summary>
    public string? Coin { get; init; }

    public string? WithdrawOrderId { get; init; }

    /// <summary>
    /// <list type="bullet">
    ///   <item><description><c>0</c> - Email Sent</description></item>
    ///   <item><description><c>1</c> - Cancelled</description></item>
    ///   <item><description><c>2</c> - Awaiting Approval</description></item>
    ///   <item><description><c>3</c> - Rejected</description></item>
    ///   <item><description><c>4</c> - Processing</description></item>
    ///   <item><description><c>5</c> - Failure</description></item>
    ///   <item><description><c>6</c> - Completed</description></item>
    /// </list>
    /// </summary>
    [Minimum(0)]
    [Maximum(6)]
    public int? Status { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    public int? Offset { get; init; }

    /// <summary>
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
