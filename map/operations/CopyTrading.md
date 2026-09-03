<!-- Generated file — do not edit; regenerated with the SDK. -->

# CopyTrading — operations

Accessor: `client.CopyTrading` · Source: `Api/CopyTrading.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFuturesLeadTraderStatusTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFuturesLeadTraderStatusTrade(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1CopyTradingFuturesUserStatusResponse`
- **Error**: `SdkException<GetFuturesLeadTraderStatusTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CopyTradingFuturesUserStatusResponse` | `Models/SapiV1CopyTradingFuturesUserStatusResponse.cs` |
| `GetFuturesLeadTraderStatusTradeError` | `Errors/GetFuturesLeadTraderStatusTradeError.cs` |
| `Error` | `Models/Error.cs` |

### GetFuturesLeadTradingSymbolWhitelistUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFuturesLeadTradingSymbolWhitelistUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1CopyTradingFuturesLeadSymbolResponse`
- **Error**: `SdkException<GetFuturesLeadTradingSymbolWhitelistUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CopyTradingFuturesLeadSymbolResponse` | `Models/SapiV1CopyTradingFuturesLeadSymbolResponse.cs` |
| `GetFuturesLeadTradingSymbolWhitelistUserDataError` | `Errors/GetFuturesLeadTradingSymbolWhitelistUserDataError.cs` |
| `Error` | `Models/Error.cs` |

