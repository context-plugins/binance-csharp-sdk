<!-- Generated file — do not edit; regenerated with the SDK. -->

# Mining — operations

Accessor: `client.Mining` · Source: `Api/Mining.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AccountListUserData(string algo, string userName, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `algo` ← `algo`, `userName` ← `userName`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningStatisticsUserListResponse`
- **Error**: `SdkException<AccountListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningStatisticsUserListResponse` | `Models/SapiV1MiningStatisticsUserListResponse.cs` |
| `AccountListUserDataError` | `Errors/AccountListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AcquiringAlgorithmMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AcquiringAlgorithmMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SapiV1MiningPubAlgoListResponse`
- **Error**: `SdkException<AcquiringAlgorithmMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningPubAlgoListResponse` | `Models/SapiV1MiningPubAlgoListResponse.cs` |
| `AcquiringAlgorithmMarketDataError` | `Errors/AcquiringAlgorithmMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### AcquiringCoinNameMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AcquiringCoinNameMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SapiV1MiningPubCoinListResponse`
- **Error**: `SdkException<AcquiringCoinNameMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningPubCoinListResponse` | `Models/SapiV1MiningPubCoinListResponse.cs` |
| `AcquiringCoinNameMarketDataError` | `Errors/AcquiringCoinNameMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### CancelHashrateResaleConfigurationUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelHashrateResaleConfigurationUserData(string configId, string userName, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `configId` ← `configId`, `userName` ← `userName`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningHashTransferConfigCancelResponse`
- **Error**: `SdkException<CancelHashrateResaleConfigurationUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningHashTransferConfigCancelResponse` | `Models/SapiV1MiningHashTransferConfigCancelResponse.cs` |
| `CancelHashrateResaleConfigurationUserDataError` | `Errors/CancelHashrateResaleConfigurationUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### EarningsListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EarningsListUserData(string algo, string userName, long timestamp, string signature, string? coin, string? startDate, string? endDate, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`coin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `algo` ← `algo`, `userName` ← `userName`, `timestamp` ← `timestamp`, `signature` ← `signature`, `coin` ← `coin`, `startDate` ← `startDate`, `endDate` ← `endDate`, `pageIndex` ← `pageIndex`, `pageSize` ← `pageSize`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningPaymentListResponse`
- **Error**: `SdkException<EarningsListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningPaymentListResponse` | `Models/SapiV1MiningPaymentListResponse.cs` |
| `EarningsListUserDataError` | `Errors/EarningsListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### ExtraBonusListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ExtraBonusListUserData(string algo, string userName, long timestamp, string signature, string? coin, string? startDate, string? endDate, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`coin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `algo` ← `algo`, `userName` ← `userName`, `timestamp` ← `timestamp`, `signature` ← `signature`, `coin` ← `coin`, `startDate` ← `startDate`, `endDate` ← `endDate`, `pageIndex` ← `pageIndex`, `pageSize` ← `pageSize`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningPaymentOtherResponse`
- **Error**: `SdkException<ExtraBonusListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningPaymentOtherResponse` | `Models/SapiV1MiningPaymentOtherResponse.cs` |
| `ExtraBonusListUserDataError` | `Errors/ExtraBonusListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### HashrateResaleDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `HashrateResaleDetailsUserData(string configId, string userName, long timestamp, string signature, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `pageIndex` — nullable, no default → **must pass explicitly**
  - `pageSize` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `configId` ← `configId`, `userName` ← `userName`, `timestamp` ← `timestamp`, `signature` ← `signature`, `pageIndex` ← `pageIndex`, `pageSize` ← `pageSize`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningHashTransferProfitDetailsResponse`
- **Error**: `SdkException<HashrateResaleDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningHashTransferProfitDetailsResponse` | `Models/SapiV1MiningHashTransferProfitDetailsResponse.cs` |
| `HashrateResaleDetailsUserDataError` | `Errors/HashrateResaleDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### HashrateResaleListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `HashrateResaleListUserData(long timestamp, string signature, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `pageIndex` — nullable, no default → **must pass explicitly**
  - `pageSize` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `pageIndex` ← `pageIndex`, `pageSize` ← `pageSize`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningHashTransferConfigDetailsListResponse`
- **Error**: `SdkException<HashrateResaleListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningHashTransferConfigDetailsListResponse` | `Models/SapiV1MiningHashTransferConfigDetailsListResponse.cs` |
| `HashrateResaleListUserDataError` | `Errors/HashrateResaleListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### HashrateResaleRequestUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `HashrateResaleRequestUserData(string userName, string algo, string toPoolUser, string hashRate, long timestamp, string signature, string? startDate, string? endDate, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `startDate` — nullable, no default → **must pass explicitly**
  - `endDate` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `userName` ← `userName`, `algo` ← `algo`, `toPoolUser` ← `toPoolUser`, `hashRate` ← `hashRate`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startDate` ← `startDate`, `endDate` ← `endDate`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningHashTransferConfigResponse`
- **Error**: `SdkException<HashrateResaleRequestUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningHashTransferConfigResponse` | `Models/SapiV1MiningHashTransferConfigResponse.cs` |
| `HashrateResaleRequestUserDataError` | `Errors/HashrateResaleRequestUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### MiningAccountEarningUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MiningAccountEarningUserData(string algo, long timestamp, string signature, string? startDate, string? endDate, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startDate` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `algo` ← `algo`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startDate` ← `startDate`, `endDate` ← `endDate`, `pageIndex` ← `pageIndex`, `pageSize` ← `pageSize`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningPaymentUidResponse`
- **Error**: `SdkException<MiningAccountEarningUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningPaymentUidResponse` | `Models/SapiV1MiningPaymentUidResponse.cs` |
| `MiningAccountEarningUserDataError` | `Errors/MiningAccountEarningUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RequestForDetailMinerListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RequestForDetailMinerListUserData(string algo, string userName, string workerName, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `algo` ← `algo`, `userName` ← `userName`, `workerName` ← `workerName`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningWorkerDetailResponse`
- **Error**: `SdkException<RequestForDetailMinerListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningWorkerDetailResponse` | `Models/SapiV1MiningWorkerDetailResponse.cs` |
| `RequestForDetailMinerListUserDataError` | `Errors/RequestForDetailMinerListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RequestForMinerListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RequestForMinerListUserData(string algo, string userName, long timestamp, string signature, int? pageIndex, int? sort, int? sortColumn, int? workerStatus, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`pageIndex` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `algo` ← `algo`, `userName` ← `userName`, `timestamp` ← `timestamp`, `signature` ← `signature`, `pageIndex` ← `pageIndex`, `sort` ← `sort`, `sortColumn` ← `sortColumn`, `workerStatus` ← `workerStatus`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningWorkerListResponse`
- **Error**: `SdkException<RequestForMinerListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningWorkerListResponse` | `Models/SapiV1MiningWorkerListResponse.cs` |
| `RequestForMinerListUserDataError` | `Errors/RequestForMinerListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### StatisticListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `StatisticListUserData(string algo, string userName, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `algo` ← `algo`, `userName` ← `userName`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MiningStatisticsUserStatusResponse`
- **Error**: `SdkException<StatisticListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningStatisticsUserStatusResponse` | `Models/SapiV1MiningStatisticsUserStatusResponse.cs` |
| `StatisticListUserDataError` | `Errors/StatisticListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

