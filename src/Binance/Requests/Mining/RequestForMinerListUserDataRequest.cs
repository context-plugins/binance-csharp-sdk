namespace Binance.Requests.Mining;

/// <summary>
/// The inputs of the RequestForMinerListUserData operation.
/// </summary>
public sealed record RequestForMinerListUserDataRequest
{
    /// <summary>
    /// Algorithm(sha256)
    /// </summary>
    public required string Algo { get; init; }

    /// <summary>
    /// Mining Account
    /// </summary>
    public required string UserName { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Page number, default is first page, start form 1
    /// </summary>
    public int? PageIndex { get; init; }

    /// <summary>
    /// sort sequence(default=0)0 positive sequence, 1 negative sequence
    /// </summary>
    public int? Sort { get; init; }

    /// <summary>
    /// Sort by( default 1): 1: miner name, 2: real-time computing power, 3: daily average computing power, 4: real-time rejection rate, 5: last submission time
    /// </summary>
    public int? SortColumn { get; init; }

    /// <summary>
    /// miners status(default=0)0 all, 1 valid, 2 invalid, 3 failure
    /// </summary>
    public int? WorkerStatus { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
