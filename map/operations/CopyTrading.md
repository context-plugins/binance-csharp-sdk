<!-- Generated file — do not edit; regenerated with the SDK. -->

# CopyTrading — operations

Accessor: `client.CopyTrading` · Source: `Api/CopyTrading.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFuturesLeadTraderStatusTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFuturesLeadTraderStatusTrade(GetFuturesLeadTraderStatusTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1CopyTradingFuturesUserStatusResponse`
- **Error**: `ApiException<GetFuturesLeadTraderStatusTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFuturesLeadTraderStatusTradeRequest` | `Requests/CopyTrading/GetFuturesLeadTraderStatusTradeRequest.cs` |
| `SapiV1CopyTradingFuturesUserStatusResponse` | `Models/SapiV1CopyTradingFuturesUserStatusResponse.cs` |
| `GetFuturesLeadTraderStatusTradeError` | `Errors/GetFuturesLeadTraderStatusTradeError.cs` |
| `Error` | `Models/Error.cs` |

### GetFuturesLeadTradingSymbolWhitelistUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFuturesLeadTradingSymbolWhitelistUserData(GetFuturesLeadTradingSymbolWhitelistUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1CopyTradingFuturesLeadSymbolResponse`
- **Error**: `ApiException<GetFuturesLeadTradingSymbolWhitelistUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFuturesLeadTradingSymbolWhitelistUserDataRequest` | `Requests/CopyTrading/GetFuturesLeadTradingSymbolWhitelistUserDataRequest.cs` |
| `SapiV1CopyTradingFuturesLeadSymbolResponse` | `Models/SapiV1CopyTradingFuturesLeadSymbolResponse.cs` |
| `GetFuturesLeadTradingSymbolWhitelistUserDataError` | `Errors/GetFuturesLeadTradingSymbolWhitelistUserDataError.cs` |
| `Error` | `Models/Error.cs` |

