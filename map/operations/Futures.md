<!-- Generated file — do not edit; regenerated with the SDK. -->

# Futures — operations

Accessor: `client.Futures` · Source: `src/Binance/Api/Futures.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFutureAccountTransactionHistoryListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFutureAccountTransactionHistoryListUserData(GetFutureAccountTransactionHistoryListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `StartTime`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `startTime` ← `StartTime`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1FuturesTransferResponse1`
- **Error**: `ApiException<GetFutureAccountTransactionHistoryListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFutureAccountTransactionHistoryListUserDataRequest` | `src/Binance/Requests/Futures/GetFutureAccountTransactionHistoryListUserDataRequest.cs` |
| `SapiV1FuturesTransferResponse1` | `src/Binance/Models/SapiV1FuturesTransferResponse1.cs` |
| `GetFutureAccountTransactionHistoryListUserDataError` | `src/Binance/Errors/GetFutureAccountTransactionHistoryListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData(GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `DataType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `dataType` ← `DataType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1FuturesHistDataLinkResponse`
- **Error**: `ApiException<GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest` | `src/Binance/Requests/Futures/GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest.cs` |
| `DataTypeEnum` | `src/Binance/Models/Enums/DataTypeEnum.cs` |
| `SapiV1FuturesHistDataLinkResponse` | `src/Binance/Models/SapiV1FuturesHistDataLinkResponse.cs` |
| `GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError` | `src/Binance/Errors/GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### NewFutureAccountTransferUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NewFutureAccountTransferUserData(NewFutureAccountTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Amount`, `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `amount` ← `Amount`, `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1FuturesTransferResponse`
- **Error**: `ApiException<NewFutureAccountTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NewFutureAccountTransferUserDataRequest` | `src/Binance/Requests/Futures/NewFutureAccountTransferUserDataRequest.cs` |
| `SapiV1FuturesTransferResponse` | `src/Binance/Models/SapiV1FuturesTransferResponse.cs` |
| `NewFutureAccountTransferUserDataError` | `src/Binance/Errors/NewFutureAccountTransferUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

