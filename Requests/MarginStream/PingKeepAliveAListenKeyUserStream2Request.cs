namespace Binance.Requests.MarginStream;

/// <summary>
/// The inputs of the PingKeepAliveAListenKeyUserStream2 operation.
/// </summary>
public sealed record PingKeepAliveAListenKeyUserStream2Request
{
    /// <summary>
    /// User websocket listen key
    /// </summary>
    public string? ListenKey { get; init; }
}
