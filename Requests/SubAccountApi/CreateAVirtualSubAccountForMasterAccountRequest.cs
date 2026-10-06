namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the CreateAVirtualSubAccountForMasterAccount operation.
/// </summary>
public sealed record CreateAVirtualSubAccountForMasterAccountRequest
{
    /// <summary>
    /// Please input a string. We will create a virtual email using that string for you to register
    /// </summary>
    public required string SubAccountString { get; init; }

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
