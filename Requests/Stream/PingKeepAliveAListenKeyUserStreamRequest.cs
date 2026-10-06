namespace Binance.Requests.Stream;

/// <summary>
/// The inputs of the PingKeepAliveAListenKeyUserStream operation.
/// </summary>
public sealed record PingKeepAliveAListenKeyUserStreamRequest
{
    /// <summary>
    /// User websocket listen key
    /// </summary>
    public string? ListenKey { get; init; }
}
