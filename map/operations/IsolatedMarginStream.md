<!-- Generated file — do not edit; regenerated with the SDK. -->

# IsolatedMarginStream — operations

Accessor: `client.IsolatedMarginStream` · Source: `Api/IsolatedMarginStream.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CloseAListenKeyUserStream3

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CloseAListenKeyUserStream3(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `listenKey` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `listenKey` ← `listenKey`
- **Returns**: `object`
- **Error**: `SdkException<CloseAListenKeyUserStream3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CloseAListenKeyUserStream3Error` | `Errors/CloseAListenKeyUserStream3Error.cs` |
| `Error` | `Models/Error.cs` |

### GenerateAListenKeyUserStream

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GenerateAListenKeyUserStream(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SapiV1UserDataStreamIsolatedResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SapiV1UserDataStreamIsolatedResponse` | `Models/SapiV1UserDataStreamIsolatedResponse.cs` |

### PingKeepAliveAListenKeyUserStream

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PingKeepAliveAListenKeyUserStream(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `listenKey` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `listenKey` ← `listenKey`
- **Returns**: `object`
- **Error**: `SdkException<PingKeepAliveAListenKeyUserStreamApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PingKeepAliveAListenKeyUserStreamApiError` | `Errors/PingKeepAliveAListenKeyUserStreamApiError.cs` |
| `Error` | `Models/Error.cs` |

