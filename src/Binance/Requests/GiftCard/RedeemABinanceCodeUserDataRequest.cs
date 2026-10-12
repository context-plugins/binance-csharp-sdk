namespace Binance.Requests.GiftCard;

/// <summary>
/// The inputs of the RedeemABinanceCodeUserData operation.
/// </summary>
public sealed record RedeemABinanceCodeUserDataRequest
{
    /// <summary>
    /// Binance Code
    /// </summary>
    public required string Code { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Each external unique ID represents a unique user on the partner platform. The function helps you to identify the redemption behavior of different users, such as redemption frequency and amount. It also helps risk and limit control of a single account, such as daily limit on redemption volume, frequency, and incorrect number of entries. This will also prevent a single user account reach the partner's daily redemption limits. We strongly recommend you to use this feature and transfer us the User ID of your users if you have different users redeeming Binance codes on your platform. To protect user data privacy, you may choose to transfer the user id in any desired format (max. 400 characters).
    /// </summary>
    public string? ExternalUid { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
