namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the SwitchOnOffBusdAndStableCoinsConversionUserDataUserData operation.
/// </summary>
public sealed record SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest
{
    /// <summary>
    /// Must be USDC, USDP or TUSD
    /// </summary>
    public required string Coin { get; init; }

    /// <summary>
    /// true: turn on the auto-conversion. false: turn off the auto-conversion
    /// </summary>
    public required bool Enable { get; init; }
}
