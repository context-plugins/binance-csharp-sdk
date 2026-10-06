<!-- Generated file — do not edit; regenerated with the SDK. -->

# IsolatedMarginStream — operations

Accessor: `client.IsolatedMarginStream` · Source: `Api/IsolatedMarginStream.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CloseAListenKeyUserStream3

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CloseAListenKeyUserStream3(CloseAListenKeyUserStream3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `listenKey` ← `ListenKey`
- **Returns**: `object`
- **Error**: `ApiException<CloseAListenKeyUserStream3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CloseAListenKeyUserStream3Request` | `Requests/IsolatedMarginStream/CloseAListenKeyUserStream3Request.cs` |
| `CloseAListenKeyUserStream3Error` | `Errors/CloseAListenKeyUserStream3Error.cs` |
| `Error` | `Models/Error.cs` |

### GenerateAListenKeyUserStream

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GenerateAListenKeyUserStream(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1UserDataStreamIsolatedResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SapiV1UserDataStreamIsolatedResponse` | `Models/SapiV1UserDataStreamIsolatedResponse.cs` |

### PingKeepAliveAListenKeyUserStream

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PingKeepAliveAListenKeyUserStream(PingKeepAliveAListenKeyUserStreamOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `listenKey` ← `ListenKey`
- **Returns**: `object`
- **Error**: `ApiException<PingKeepAliveAListenKeyUserStreamApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PingKeepAliveAListenKeyUserStreamOperationRequest` | `Requests/IsolatedMarginStream/PingKeepAliveAListenKeyUserStreamOperationRequest.cs` |
| `PingKeepAliveAListenKeyUserStreamApiError` | `Errors/PingKeepAliveAListenKeyUserStreamApiError.cs` |
| `Error` | `Models/Error.cs` |

