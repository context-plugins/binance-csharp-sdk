using Binance.Core.Validation.Attributes;

namespace Binance.Requests.Fiat;

/// <summary>
/// The inputs of the FiatDepositWithdrawHistoryUserData operation.
/// </summary>
public sealed record FiatDepositWithdrawHistoryUserDataRequest
{
    /// <summary>
    /// <list type="bullet">
    ///   <item><description><c>0</c> - deposit</description></item>
    ///   <item><description><c>1</c> - withdraw</description></item>
    /// </list>
    /// </summary>
    [Minimum(0)]
    [Maximum(1)]
    public required int TransactionType { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public long? BeginTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Default 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Default 100, max 500
    /// </summary>
    public int? Rows { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
