<!-- Generated file — do not edit; regenerated with the SDK. -->

# Nft — operations

Accessor: `client.Nft` · Source: `Api/Nft.cs` · 4 operations

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
| `GetNftAssetUserDataRequest` | `Requests/Nft/GetNftAssetUserDataRequest.cs` |
| `SapiV1NftUserGetAssetResponse` | `Models/SapiV1NftUserGetAssetResponse.cs` |
| `GetNftAssetUserDataError` | `Errors/GetNftAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetNftDepositHistoryUserDataRequest` | `Requests/Nft/GetNftDepositHistoryUserDataRequest.cs` |
| `SapiV1NftHistoryDepositResponse` | `Models/SapiV1NftHistoryDepositResponse.cs` |
| `GetNftDepositHistoryUserDataError` | `Errors/GetNftDepositHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetNftTransactionHistoryUserDataRequest` | `Requests/Nft/GetNftTransactionHistoryUserDataRequest.cs` |
| `SapiV1NftHistoryTransactionsResponse` | `Models/SapiV1NftHistoryTransactionsResponse.cs` |
| `GetNftTransactionHistoryUserDataError` | `Errors/GetNftTransactionHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetNftWithdrawHistoryUserDataRequest` | `Requests/Nft/GetNftWithdrawHistoryUserDataRequest.cs` |
| `SapiV1NftHistoryWithdrawResponse` | `Models/SapiV1NftHistoryWithdrawResponse.cs` |
| `GetNftWithdrawHistoryUserDataError` | `Errors/GetNftWithdrawHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

