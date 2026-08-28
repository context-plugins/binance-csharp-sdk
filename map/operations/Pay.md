<!-- Generated file — do not edit; regenerated with the SDK. -->

# Pay — operations

Accessor: `client.Pay` · Source: `Api/Pay.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPayTradeHistoryUserData

- **Signature**: `GetPayTradeHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PayTransactionsResponse`
- **Error**: `SdkException<GetPayTradeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PayTransactionsResponse` | `Models/SapiV1PayTransactionsResponse.cs` |
| `GetPayTradeHistoryUserDataError` | `Errors/GetPayTradeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

