namespace Binance.Requests.MarginStream;

/// <summary>
/// The inputs of the CloseAListenKeyUserStream2 operation.
/// </summary>
public sealed record CloseAListenKeyUserStream2Request
{
    /// <summary>
    /// User websocket listen key
    /// </summary>
    public string? ListenKey { get; init; }
}
