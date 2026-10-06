namespace Binance.Requests.Futures;

/// <summary>
/// The inputs of the NewFutureAccountTransferUserData operation.
/// </summary>
public sealed record NewFutureAccountTransferUserDataRequest
{
    public required string Asset { get; init; }

    public required double Amount { get; init; }

    /// <summary>
    /// 1: transfer from spot account to USDT-Ⓜ futures account. 2: transfer from USDT-Ⓜ futures account to spot account. 3: transfer from spot account to COIN-Ⓜ futures account. 4: transfer from COIN-Ⓜ futures account to spot account.
    /// </summary>
    public required long Type { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
