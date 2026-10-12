using Binance.Core.Validation.Attributes;

namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the MarginTransferForSubAccountForMasterAccount operation.
/// </summary>
public sealed record MarginTransferForSubAccountForMasterAccountRequest
{
    /// <summary>
    /// Sub-account email
    /// </summary>
    public required string Email { get; init; }

    public required string Asset { get; init; }

    public required double Amount { get; init; }

    /// <summary>
    /// <list type="bullet">
    ///   <item><description><c>1</c> - transfer from subaccount's spot account to margin account</description></item>
    ///   <item><description><c>2</c> - transfer from subaccount's margin account to its spot account</description></item>
    /// </list>
    /// </summary>
    [Minimum(1)]
    [Maximum(2)]
    public required int Type { get; init; }

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
