<!-- Generated file — do not edit; regenerated with the SDK. -->

# MarginStream — operations

Accessor: `client.MarginStream` · Source: `src/Binance/Api/MarginStream.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CloseAListenKeyUserStream2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CloseAListenKeyUserStream2(CloseAListenKeyUserStream2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `listenKey` ← `ListenKey`
- **Returns**: `object`
- **Error**: `ApiException<CloseAListenKeyUserStream2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CloseAListenKeyUserStream2Request` | `src/Binance/Requests/MarginStream/CloseAListenKeyUserStream2Request.cs` |
| `CloseAListenKeyUserStream2Error` | `src/Binance/Errors/CloseAListenKeyUserStream2Error.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### CreateAListenKeyUserStream2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CreateAListenKeyUserStream2(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1UserDataStreamResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SapiV1UserDataStreamResponse` | `src/Binance/Models/SapiV1UserDataStreamResponse.cs` |

### PingKeepAliveAListenKeyUserStream2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PingKeepAliveAListenKeyUserStream2(PingKeepAliveAListenKeyUserStream2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `listenKey` ← `ListenKey`
- **Returns**: `object`
- **Error**: `ApiException<PingKeepAliveAListenKeyUserStream2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PingKeepAliveAListenKeyUserStream2Request` | `src/Binance/Requests/MarginStream/PingKeepAliveAListenKeyUserStream2Request.cs` |
| `PingKeepAliveAListenKeyUserStream2Error` | `src/Binance/Errors/PingKeepAliveAListenKeyUserStream2Error.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

