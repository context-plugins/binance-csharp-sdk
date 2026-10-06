<!-- Generated file — do not edit; regenerated with the SDK. -->

# Pay — operations

Accessor: `client.Pay` · Source: `Api/Pay.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPayTradeHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetPayTradeHistoryUserData(GetPayTradeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PayTransactionsResponse`
- **Error**: `ApiException<GetPayTradeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPayTradeHistoryUserDataRequest` | `Requests/Pay/GetPayTradeHistoryUserDataRequest.cs` |
| `SapiV1PayTransactionsResponse` | `Models/SapiV1PayTransactionsResponse.cs` |
| `GetPayTradeHistoryUserDataError` | `Errors/GetPayTradeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

