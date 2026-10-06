<!-- Generated file — do not edit; regenerated with the SDK. -->

# Mining — operations

Accessor: `client.Mining` · Source: `Api/Mining.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AccountListUserData(AccountListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Algo`, `UserName`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algo` ← `Algo`, `userName` ← `UserName`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningStatisticsUserListResponse`
- **Error**: `ApiException<AccountListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountListUserDataRequest` | `Requests/Mining/AccountListUserDataRequest.cs` |
| `SapiV1MiningStatisticsUserListResponse` | `Models/SapiV1MiningStatisticsUserListResponse.cs` |
| `AccountListUserDataError` | `Errors/AccountListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AcquiringAlgorithmMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AcquiringAlgorithmMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1MiningPubAlgoListResponse`
- **Error**: `ApiException<AcquiringAlgorithmMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningPubAlgoListResponse` | `Models/SapiV1MiningPubAlgoListResponse.cs` |
| `AcquiringAlgorithmMarketDataError` | `Errors/AcquiringAlgorithmMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### AcquiringCoinNameMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AcquiringCoinNameMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1MiningPubCoinListResponse`
- **Error**: `ApiException<AcquiringCoinNameMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningPubCoinListResponse` | `Models/SapiV1MiningPubCoinListResponse.cs` |
| `AcquiringCoinNameMarketDataError` | `Errors/AcquiringCoinNameMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### CancelHashrateResaleConfigurationUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelHashrateResaleConfigurationUserData(CancelHashrateResaleConfigurationUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ConfigId`, `UserName`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `configId` ← `ConfigId`, `userName` ← `UserName`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningHashTransferConfigCancelResponse`
- **Error**: `ApiException<CancelHashrateResaleConfigurationUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelHashrateResaleConfigurationUserDataRequest` | `Requests/Mining/CancelHashrateResaleConfigurationUserDataRequest.cs` |
| `SapiV1MiningHashTransferConfigCancelResponse` | `Models/SapiV1MiningHashTransferConfigCancelResponse.cs` |
| `CancelHashrateResaleConfigurationUserDataError` | `Errors/CancelHashrateResaleConfigurationUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### EarningsListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EarningsListUserData(EarningsListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Algo`, `UserName`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algo` ← `Algo`, `userName` ← `UserName`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `coin` ← `Coin`, `startDate` ← `StartDate`, `endDate` ← `EndDate`, `pageIndex` ← `PageIndex`, `pageSize` ← `PageSize`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningPaymentListResponse`
- **Error**: `ApiException<EarningsListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EarningsListUserDataRequest` | `Requests/Mining/EarningsListUserDataRequest.cs` |
| `SapiV1MiningPaymentListResponse` | `Models/SapiV1MiningPaymentListResponse.cs` |
| `EarningsListUserDataError` | `Errors/EarningsListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### ExtraBonusListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ExtraBonusListUserData(ExtraBonusListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Algo`, `UserName`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algo` ← `Algo`, `userName` ← `UserName`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `coin` ← `Coin`, `startDate` ← `StartDate`, `endDate` ← `EndDate`, `pageIndex` ← `PageIndex`, `pageSize` ← `PageSize`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningPaymentOtherResponse`
- **Error**: `ApiException<ExtraBonusListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ExtraBonusListUserDataRequest` | `Requests/Mining/ExtraBonusListUserDataRequest.cs` |
| `SapiV1MiningPaymentOtherResponse` | `Models/SapiV1MiningPaymentOtherResponse.cs` |
| `ExtraBonusListUserDataError` | `Errors/ExtraBonusListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### HashrateResaleDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `HashrateResaleDetailsUserData(HashrateResaleDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ConfigId`, `UserName`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `configId` ← `ConfigId`, `userName` ← `UserName`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `pageIndex` ← `PageIndex`, `pageSize` ← `PageSize`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningHashTransferProfitDetailsResponse`
- **Error**: `ApiException<HashrateResaleDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `HashrateResaleDetailsUserDataRequest` | `Requests/Mining/HashrateResaleDetailsUserDataRequest.cs` |
| `SapiV1MiningHashTransferProfitDetailsResponse` | `Models/SapiV1MiningHashTransferProfitDetailsResponse.cs` |
| `HashrateResaleDetailsUserDataError` | `Errors/HashrateResaleDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### HashrateResaleListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `HashrateResaleListUserData(HashrateResaleListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `pageIndex` ← `PageIndex`, `pageSize` ← `PageSize`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningHashTransferConfigDetailsListResponse`
- **Error**: `ApiException<HashrateResaleListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `HashrateResaleListUserDataRequest` | `Requests/Mining/HashrateResaleListUserDataRequest.cs` |
| `SapiV1MiningHashTransferConfigDetailsListResponse` | `Models/SapiV1MiningHashTransferConfigDetailsListResponse.cs` |
| `HashrateResaleListUserDataError` | `Errors/HashrateResaleListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### HashrateResaleRequestUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `HashrateResaleRequestUserData(HashrateResaleRequestUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `UserName`, `Algo`, `ToPoolUser`, `HashRate`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `userName` ← `UserName`, `algo` ← `Algo`, `toPoolUser` ← `ToPoolUser`, `hashRate` ← `HashRate`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startDate` ← `StartDate`, `endDate` ← `EndDate`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningHashTransferConfigResponse`
- **Error**: `ApiException<HashrateResaleRequestUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `HashrateResaleRequestUserDataRequest` | `Requests/Mining/HashrateResaleRequestUserDataRequest.cs` |
| `SapiV1MiningHashTransferConfigResponse` | `Models/SapiV1MiningHashTransferConfigResponse.cs` |
| `HashrateResaleRequestUserDataError` | `Errors/HashrateResaleRequestUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### MiningAccountEarningUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MiningAccountEarningUserData(MiningAccountEarningUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Algo`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algo` ← `Algo`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startDate` ← `StartDate`, `endDate` ← `EndDate`, `pageIndex` ← `PageIndex`, `pageSize` ← `PageSize`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningPaymentUidResponse`
- **Error**: `ApiException<MiningAccountEarningUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MiningAccountEarningUserDataRequest` | `Requests/Mining/MiningAccountEarningUserDataRequest.cs` |
| `SapiV1MiningPaymentUidResponse` | `Models/SapiV1MiningPaymentUidResponse.cs` |
| `MiningAccountEarningUserDataError` | `Errors/MiningAccountEarningUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RequestForDetailMinerListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RequestForDetailMinerListUserData(RequestForDetailMinerListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Algo`, `UserName`, `WorkerName`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algo` ← `Algo`, `userName` ← `UserName`, `workerName` ← `WorkerName`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningWorkerDetailResponse`
- **Error**: `ApiException<RequestForDetailMinerListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RequestForDetailMinerListUserDataRequest` | `Requests/Mining/RequestForDetailMinerListUserDataRequest.cs` |
| `SapiV1MiningWorkerDetailResponse` | `Models/SapiV1MiningWorkerDetailResponse.cs` |
| `RequestForDetailMinerListUserDataError` | `Errors/RequestForDetailMinerListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RequestForMinerListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RequestForMinerListUserData(RequestForMinerListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Algo`, `UserName`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algo` ← `Algo`, `userName` ← `UserName`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `pageIndex` ← `PageIndex`, `sort` ← `Sort`, `sortColumn` ← `SortColumn`, `workerStatus` ← `WorkerStatus`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningWorkerListResponse`
- **Error**: `ApiException<RequestForMinerListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RequestForMinerListUserDataRequest` | `Requests/Mining/RequestForMinerListUserDataRequest.cs` |
| `SapiV1MiningWorkerListResponse` | `Models/SapiV1MiningWorkerListResponse.cs` |
| `RequestForMinerListUserDataError` | `Errors/RequestForMinerListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### StatisticListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `StatisticListUserData(StatisticListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Algo`, `UserName`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algo` ← `Algo`, `userName` ← `UserName`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MiningStatisticsUserStatusResponse`
- **Error**: `ApiException<StatisticListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `StatisticListUserDataRequest` | `Requests/Mining/StatisticListUserDataRequest.cs` |
| `SapiV1MiningStatisticsUserStatusResponse` | `Models/SapiV1MiningStatisticsUserStatusResponse.cs` |
| `StatisticListUserDataError` | `Errors/StatisticListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

