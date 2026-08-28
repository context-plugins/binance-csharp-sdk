<!-- Generated file — do not edit; regenerated with the SDK. -->

# C2C — operations

Accessor: `client.C2C` · Source: `Api/C2C.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetC2CTradeHistoryUserData

- **Signature**: `GetC2CTradeHistoryUserData(TradeType tradeType, long timestamp, string signature, long? startTimestamp, long? endTimestamp, int? page, int? rows, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTimestamp` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `tradeType` ← `tradeType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTimestamp` ← `startTimestamp`, `endTimestamp` ← `endTimestamp`, `page` ← `page`, `rows` ← `rows`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1C2COrderMatchListUserOrderHistoryResponse`
- **Error**: `SdkException<GetC2CTradeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TradeType` | `Models/Enums/TradeType.cs` |
| `SapiV1C2COrderMatchListUserOrderHistoryResponse` | `Models/SapiV1C2COrderMatchListUserOrderHistoryResponse.cs` |
| `GetC2CTradeHistoryUserDataError` | `Errors/GetC2CTradeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

