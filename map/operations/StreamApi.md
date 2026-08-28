<!-- Generated file — do not edit; regenerated with the SDK. -->

# StreamApi — operations

Accessor: `client.StreamApi` · Source: `Api/StreamApi.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CloseAListenKeyUserStream

- **Signature**: `CloseAListenKeyUserStream(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `listenKey` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `listenKey` ← `listenKey`
- **Returns**: `object`
- **Error**: `SdkException<CloseAListenKeyUserStreamError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CloseAListenKeyUserStreamError` | `Errors/CloseAListenKeyUserStreamError.cs` |
| `Error` | `Models/Error.cs` |

### CreateAListenKeyUserStream

- **Signature**: `CreateAListenKeyUserStream(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ApiV3UserDataStreamResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApiV3UserDataStreamResponse` | `Models/ApiV3UserDataStreamResponse.cs` |

### PingKeepAliveAListenKeyUserStream

- **Signature**: `PingKeepAliveAListenKeyUserStream(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `listenKey` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `listenKey` ← `listenKey`
- **Returns**: `object`
- **Error**: `SdkException<PingKeepAliveAListenKeyUserStreamError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PingKeepAliveAListenKeyUserStreamError` | `Errors/PingKeepAliveAListenKeyUserStreamError.cs` |
| `Error` | `Models/Error.cs` |

