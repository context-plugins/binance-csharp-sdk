using Binance.Models.Enums;

namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData operation.
/// </summary>
public sealed record QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest
{
    /// <summary>
    /// Transfer Direction
    /// </summary>
    public required Transfers Transfers { get; init; }

    /// <summary>
    /// Transfer function account type
    /// </summary>
    public required TransferFunctionAccountType TransferFunctionAccountType { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Default 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
