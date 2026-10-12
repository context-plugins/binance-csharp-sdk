using Binance.Models.Enums;

namespace Binance.Requests.DualInvestment;

/// <summary>
/// The inputs of the GetDualInvestmentProductListUserData operation.
/// </summary>
public sealed record GetDualInvestmentProductListUserDataRequest
{
    /// <summary>
    /// Input CALL or PUT
    /// </summary>
    public required OptionType OptionType { get; init; }

    /// <summary>
    /// Target exercised asset, e.g.:
    /// if you subscribe to a high sell product (call option), you should input:
    ///   - optionType: CALL,
    ///   - exercisedCoin: USDT,
    ///   - investCoin: BNB;
    /// <para>
    /// if you subscribe to a low buy product (put option), you should input:
    ///   - optionType: PUT,
    ///   - exercisedCoin: BNB,
    ///   - investCoin: USDT;
    /// </para>
    /// </summary>
    public required string ExercisedCoin { get; init; }

    /// <summary>
    /// Asset used for subscribing, e.g.:
    /// if you subscribe to a high sell product (call option), you should input:
    ///   - optionType: CALL,
    ///   - exercisedCoin: USDT,
    ///   - investCoin: BNB;
    /// <para>
    /// if you subscribe to a low buy product (put option), you should input:
    ///   - optionType: PUT,
    ///   - exercisedCoin: BNB,
    ///   - investCoin: USDT;
    /// </para>
    /// </summary>
    public required string InvestCoin { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// MIN 1, MAX 100; Default 100
    /// </summary>
    public string? PageSize { get; init; }

    /// <summary>
    /// Page number, default is first page, start form 1
    /// </summary>
    public int? PageIndex { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
