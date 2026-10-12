namespace Binance.Requests.Stream;

/// <summary>
/// The inputs of the CloseAListenKeyUserStream operation.
/// </summary>
public sealed record CloseAListenKeyUserStreamRequest
{
    /// <summary>
    /// User websocket listen key
    /// </summary>
    public string? ListenKey { get; init; }
}
