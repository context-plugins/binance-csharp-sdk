<!-- Generated file — do not edit; regenerated with the SDK. -->

# Nft — operations

Accessor: `client.Nft` · Source: `src/Binance/Api/Nft.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetNftAssetUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetNftAssetUserData(GetNftAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `limit` ← `Limit`, `page` ← `Page`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1NftUserGetAssetResponse`
- **Error**: `ApiException<GetNftAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNftAssetUserDataRequest` | `src/Binance/Requests/Nft/GetNftAssetUserDataRequest.cs` |
| `SapiV1NftUserGetAssetResponse` | `src/Binance/Models/SapiV1NftUserGetAssetResponse.cs` |
| `GetNftAssetUserDataError` | `src/Binance/Errors/GetNftAssetUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetNftDepositHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetNftDepositHistoryUserData(GetNftDepositHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `page` ← `Page`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1NftHistoryDepositResponse`
- **Error**: `ApiException<GetNftDepositHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNftDepositHistoryUserDataRequest` | `src/Binance/Requests/Nft/GetNftDepositHistoryUserDataRequest.cs` |
| `SapiV1NftHistoryDepositResponse` | `src/Binance/Models/SapiV1NftHistoryDepositResponse.cs` |
| `GetNftDepositHistoryUserDataError` | `src/Binance/Errors/GetNftDepositHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetNftTransactionHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetNftTransactionHistoryUserData(GetNftTransactionHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `orderType` ← `OrderType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `page` ← `Page`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1NftHistoryTransactionsResponse`
- **Error**: `ApiException<GetNftTransactionHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNftTransactionHistoryUserDataRequest` | `src/Binance/Requests/Nft/GetNftTransactionHistoryUserDataRequest.cs` |
| `SapiV1NftHistoryTransactionsResponse` | `src/Binance/Models/SapiV1NftHistoryTransactionsResponse.cs` |
| `GetNftTransactionHistoryUserDataError` | `src/Binance/Errors/GetNftTransactionHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetNftWithdrawHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetNftWithdrawHistoryUserData(GetNftWithdrawHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `page` ← `Page`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1NftHistoryWithdrawResponse`
- **Error**: `ApiException<GetNftWithdrawHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNftWithdrawHistoryUserDataRequest` | `src/Binance/Requests/Nft/GetNftWithdrawHistoryUserDataRequest.cs` |
| `SapiV1NftHistoryWithdrawResponse` | `src/Binance/Models/SapiV1NftHistoryWithdrawResponse.cs` |
| `GetNftWithdrawHistoryUserDataError` | `src/Binance/Errors/GetNftWithdrawHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

