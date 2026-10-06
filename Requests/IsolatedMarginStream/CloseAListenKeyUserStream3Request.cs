namespace Binance.Requests.IsolatedMarginStream;

/// <summary>
/// The inputs of the CloseAListenKeyUserStream3 operation.
/// </summary>
public sealed record CloseAListenKeyUserStream3Request
{
    /// <summary>
    /// User websocket listen key
    /// </summary>
    public string? ListenKey { get; init; }
}
