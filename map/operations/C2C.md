<!-- Generated file — do not edit; regenerated with the SDK. -->

# C2C — operations

Accessor: `client.C2C` · Source: `Api/C2C.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetC2CTradeHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetC2CTradeHistoryUserData(GetC2CTradeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TradeType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `tradeType` ← `TradeType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTimestamp` ← `StartTimestamp`, `endTimestamp` ← `EndTimestamp`, `page` ← `Page`, `rows` ← `Rows`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1C2COrderMatchListUserOrderHistoryResponse`
- **Error**: `ApiException<GetC2CTradeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetC2CTradeHistoryUserDataRequest` | `Requests/C2C/GetC2CTradeHistoryUserDataRequest.cs` |
| `TradeType` | `Models/Enums/TradeType.cs` |
| `SapiV1C2COrderMatchListUserOrderHistoryResponse` | `Models/SapiV1C2COrderMatchListUserOrderHistoryResponse.cs` |
| `GetC2CTradeHistoryUserDataError` | `Errors/GetC2CTradeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

