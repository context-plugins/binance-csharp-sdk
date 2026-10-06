<!-- Generated file — do not edit; regenerated with the SDK. -->

# Stream — operations

Accessor: `client.Stream` · Source: `Api/Stream.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CloseAListenKeyUserStream

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CloseAListenKeyUserStream(CloseAListenKeyUserStreamRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `listenKey` ← `ListenKey`
- **Returns**: `object`
- **Error**: `ApiException<CloseAListenKeyUserStreamError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CloseAListenKeyUserStreamRequest` | `Requests/Stream/CloseAListenKeyUserStreamRequest.cs` |
| `CloseAListenKeyUserStreamError` | `Errors/CloseAListenKeyUserStreamError.cs` |
| `Error` | `Models/Error.cs` |

### CreateAListenKeyUserStream

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CreateAListenKeyUserStream(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ApiV3UserDataStreamResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApiV3UserDataStreamResponse` | `Models/ApiV3UserDataStreamResponse.cs` |

### PingKeepAliveAListenKeyUserStream

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PingKeepAliveAListenKeyUserStream(PingKeepAliveAListenKeyUserStreamRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `listenKey` ← `ListenKey`
- **Returns**: `object`
- **Error**: `ApiException<PingKeepAliveAListenKeyUserStreamError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PingKeepAliveAListenKeyUserStreamRequest` | `Requests/Stream/PingKeepAliveAListenKeyUserStreamRequest.cs` |
| `PingKeepAliveAListenKeyUserStreamError` | `Errors/PingKeepAliveAListenKeyUserStreamError.cs` |
| `Error` | `Models/Error.cs` |

