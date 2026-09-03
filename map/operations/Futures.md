<!-- Generated file — do not edit; regenerated with the SDK. -->

# Futures — operations

Accessor: `client.Futures` · Source: `Api/Futures.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFutureAccountTransactionHistoryListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFutureAccountTransactionHistoryListUserData(string asset, long startTime, long timestamp, string signature, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`endTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `asset` ← `asset`, `startTime` ← `startTime`, `timestamp` ← `timestamp`, `signature` ← `signature`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1FuturesTransferResponse1`
- **Error**: `SdkException<GetFutureAccountTransactionHistoryListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1FuturesTransferResponse1` | `Models/SapiV1FuturesTransferResponse1.cs` |
| `GetFutureAccountTransactionHistoryListUserDataError` | `Errors/GetFutureAccountTransactionHistoryListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData(string symbol, DataTypeEnum dataType, long timestamp, string signature, long? startTime, long? endTime, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `startTime` — nullable, no default → **must pass explicitly**
  - `endTime` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `dataType` ← `dataType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1FuturesHistDataLinkResponse`
- **Error**: `SdkException<GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DataTypeEnum` | `Models/Enums/DataTypeEnum.cs` |
| `SapiV1FuturesHistDataLinkResponse` | `Models/SapiV1FuturesHistDataLinkResponse.cs` |
| `GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError` | `Errors/GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### NewFutureAccountTransferUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NewFutureAccountTransferUserData(string asset, double amount, long type, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `asset` ← `asset`, `amount` ← `amount`, `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1FuturesTransferResponse`
- **Error**: `SdkException<NewFutureAccountTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1FuturesTransferResponse` | `Models/SapiV1FuturesTransferResponse.cs` |
| `NewFutureAccountTransferUserDataError` | `Errors/NewFutureAccountTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

