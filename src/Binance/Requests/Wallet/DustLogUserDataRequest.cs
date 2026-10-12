using Binance.Models.Enums;

namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the DustLogUserData operation.
/// </summary>
public sealed record DustLogUserDataRequest
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
    /// SPOT or MARGIN, default SPOT
    /// </summary>
    public AccountType? AccountType { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
