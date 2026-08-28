<!-- Generated file — do not edit; regenerated with the SDK. -->

# Nft — operations

Accessor: `client.Nft` · Source: `Api/Nft.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetNftAssetUserData

- **Signature**: `GetNftAssetUserData(long timestamp, string signature, int? limit, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `limit` ← `limit`, `page` ← `page`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1NftUserGetAssetResponse`
- **Error**: `SdkException<GetNftAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1NftUserGetAssetResponse` | `Models/SapiV1NftUserGetAssetResponse.cs` |
| `GetNftAssetUserDataError` | `Errors/GetNftAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetNftDepositHistoryUserData

- **Signature**: `GetNftDepositHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? limit, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `page` ← `page`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1NftHistoryDepositResponse`
- **Error**: `SdkException<GetNftDepositHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1NftHistoryDepositResponse` | `Models/SapiV1NftHistoryDepositResponse.cs` |
| `GetNftDepositHistoryUserDataError` | `Errors/GetNftDepositHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetNftTransactionHistoryUserData

- **Signature**: `GetNftTransactionHistoryUserData(int orderType, long timestamp, string signature, long? startTime, long? endTime, int? limit, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `orderType` ← `orderType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `page` ← `page`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1NftHistoryTransactionsResponse`
- **Error**: `SdkException<GetNftTransactionHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1NftHistoryTransactionsResponse` | `Models/SapiV1NftHistoryTransactionsResponse.cs` |
| `GetNftTransactionHistoryUserDataError` | `Errors/GetNftTransactionHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetNftWithdrawHistoryUserData

- **Signature**: `GetNftWithdrawHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? limit, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `page` ← `page`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1NftHistoryWithdrawResponse`
- **Error**: `SdkException<GetNftWithdrawHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1NftHistoryWithdrawResponse` | `Models/SapiV1NftHistoryWithdrawResponse.cs` |
| `GetNftWithdrawHistoryUserDataError` | `Errors/GetNftWithdrawHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

