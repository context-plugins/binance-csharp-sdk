<!-- Generated file — do not edit; regenerated with the SDK. -->

# MarginStream — operations

Accessor: `client.MarginStream` · Source: `Api/MarginStream.cs` · 3 operations

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
| `CloseAListenKeyUserStream2Request` | `Requests/MarginStream/CloseAListenKeyUserStream2Request.cs` |
| `CloseAListenKeyUserStream2Error` | `Errors/CloseAListenKeyUserStream2Error.cs` |
| `Error` | `Models/Error.cs` |

### CreateAListenKeyUserStream2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CreateAListenKeyUserStream2(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1UserDataStreamResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SapiV1UserDataStreamResponse` | `Models/SapiV1UserDataStreamResponse.cs` |

### PingKeepAliveAListenKeyUserStream2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PingKeepAliveAListenKeyUserStream2(PingKeepAliveAListenKeyUserStream2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `listenKey` ← `ListenKey`
- **Returns**: `object`
- **Error**: `ApiException<PingKeepAliveAListenKeyUserStream2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PingKeepAliveAListenKeyUserStream2Request` | `Requests/MarginStream/PingKeepAliveAListenKeyUserStream2Request.cs` |
| `PingKeepAliveAListenKeyUserStream2Error` | `Errors/PingKeepAliveAListenKeyUserStream2Error.cs` |
| `Error` | `Models/Error.cs` |

