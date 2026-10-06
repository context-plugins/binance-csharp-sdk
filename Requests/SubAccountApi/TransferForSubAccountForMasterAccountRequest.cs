using Binance.Core.Validation.Attributes;

namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the TransferForSubAccountForMasterAccount operation.
/// </summary>
public sealed record TransferForSubAccountForMasterAccountRequest
{
    /// <summary>
    /// Sub-account email
    /// </summary>
    public required string Email { get; init; }

    public required string Asset { get; init; }

    public required double Amount { get; init; }

    /// <summary>
    /// <list type="bullet">
    ///   <item><description><c>1</c> - transfer from subaccount's spot account to its USDT-margined futures account</description></item>
    ///   <item><description><c>2</c> - transfer from subaccount's USDT-margined futures account to its spot account</description></item>
    ///   <item><description><c>3</c> - transfer from subaccount's spot account to its COIN-margined futures account</description></item>
    ///   <item><description><c>4</c> - transfer from subaccount's COIN-margined futures account to its spot account</description></item>
    /// </list>
    /// </summary>
    [Minimum(1)]
    [Maximum(4)]
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
