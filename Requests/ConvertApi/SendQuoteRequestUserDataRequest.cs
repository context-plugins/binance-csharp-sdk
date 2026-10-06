namespace Binance.Requests.ConvertApi;

/// <summary>
/// The inputs of the SendQuoteRequestUserData operation.
/// </summary>
public sealed record SendQuoteRequestUserDataRequest
{
    public required string FromAsset { get; init; }

    public required string ToAsset { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// When specified, it is the amount you will be debited after the conversion
    /// </summary>
    public double? FromAmount { get; init; }

    /// <summary>
    /// When specified, it is the amount you will be debited after the conversion
    /// </summary>
    public double? ToAmount { get; init; }

    /// <summary>
    /// 10s, 30s, 1m, 2m, default 10s
    /// </summary>
    public string? ValidTime { get; init; }

    /// <summary>
    /// SPOT or FUNDING. Default is SPOT
    /// </summary>
    public string? WalletType { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
