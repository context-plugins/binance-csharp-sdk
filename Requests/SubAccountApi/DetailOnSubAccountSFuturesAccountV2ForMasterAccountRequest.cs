namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the DetailOnSubAccountSFuturesAccountV2ForMasterAccount operation.
/// </summary>
public sealed record DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest
{
    /// <summary>
    /// Sub-account email
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// <list type="bullet">
    ///   <item><description><c>1</c> - USDT Margined Futures</description></item>
    ///   <item><description><c>2</c> - COIN Margined Futures</description></item>
    /// </list>
    /// </summary>
    public required int FuturesType { get; init; }

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
