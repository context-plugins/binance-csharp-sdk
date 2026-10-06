namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the WithdrawUserData operation.
/// </summary>
public sealed record WithdrawUserDataRequest
{
    /// <summary>
    /// Coin name
    /// </summary>
    public required string Coin { get; init; }

    public required string Address { get; init; }

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
    /// Client id for withdraw
    /// </summary>
    public string? WithdrawOrderId { get; init; }

    public string? Network { get; init; }

    /// <summary>
    /// Secondary address identifier for coins like XRP,XMR etc.
    /// </summary>
    public string? AddressTag { get; init; }

    /// <summary>
    /// When making internal transfer
    /// - <c>true</c> -&gt;  returning the fee to the destination account;
    /// - <c>false</c> -&gt; returning the fee back to the departure account.
    /// </summary>
    public bool TransactionFeeFlag { get; init; } = false;

    public string? Name { get; init; }

    /// <summary>
    /// The wallet type for withdraw，0-Spot wallet, 1- Funding wallet. Default is Spot wallet
    /// </summary>
    public int? WalletType { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
