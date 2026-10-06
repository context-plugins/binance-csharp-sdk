namespace Binance.Requests.IsolatedMarginStream;

/// <summary>
/// The inputs of the PingKeepAliveAListenKeyUserStream operation.
/// </summary>
public sealed record PingKeepAliveAListenKeyUserStreamOperationRequest
{
    /// <summary>
    /// User websocket listen key
    /// </summary>
    public string? ListenKey { get; init; }
}
