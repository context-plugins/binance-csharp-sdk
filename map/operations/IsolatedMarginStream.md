<!-- Generated file — do not edit; regenerated with the SDK. -->

# IsolatedMarginStream — operations

Accessor: `client.IsolatedMarginStream` · Source: `src/Binance/Api/IsolatedMarginStream.cs` · 3 operations

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
| `CloseAListenKeyUserStream3Request` | `src/Binance/Requests/IsolatedMarginStream/CloseAListenKeyUserStream3Request.cs` |
| `CloseAListenKeyUserStream3Error` | `src/Binance/Errors/CloseAListenKeyUserStream3Error.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GenerateAListenKeyUserStream

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GenerateAListenKeyUserStream(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1UserDataStreamIsolatedResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SapiV1UserDataStreamIsolatedResponse` | `src/Binance/Models/SapiV1UserDataStreamIsolatedResponse.cs` |

### PingKeepAliveAListenKeyUserStream

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PingKeepAliveAListenKeyUserStream(PingKeepAliveAListenKeyUserStreamOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `listenKey` ← `ListenKey`
- **Returns**: `object`
- **Error**: `ApiException<PingKeepAliveAListenKeyUserStreamApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PingKeepAliveAListenKeyUserStreamOperationRequest` | `src/Binance/Requests/IsolatedMarginStream/PingKeepAliveAListenKeyUserStreamOperationRequest.cs` |
| `PingKeepAliveAListenKeyUserStreamApiError` | `src/Binance/Errors/PingKeepAliveAListenKeyUserStreamApiError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

