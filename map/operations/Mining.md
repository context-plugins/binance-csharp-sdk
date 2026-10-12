<!-- Generated file — do not edit; regenerated with the SDK. -->

# Mining — operations

Accessor: `client.Mining` · Source: `src/Binance/Api/Mining.cs` · 13 operations

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
| `AccountListUserDataRequest` | `src/Binance/Requests/Mining/AccountListUserDataRequest.cs` |
| `SapiV1MiningStatisticsUserListResponse` | `src/Binance/Models/SapiV1MiningStatisticsUserListResponse.cs` |
| `AccountListUserDataError` | `src/Binance/Errors/AccountListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### AcquiringAlgorithmMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AcquiringAlgorithmMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1MiningPubAlgoListResponse`
- **Error**: `ApiException<AcquiringAlgorithmMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningPubAlgoListResponse` | `src/Binance/Models/SapiV1MiningPubAlgoListResponse.cs` |
| `AcquiringAlgorithmMarketDataError` | `src/Binance/Errors/AcquiringAlgorithmMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### AcquiringCoinNameMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AcquiringCoinNameMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1MiningPubCoinListResponse`
- **Error**: `ApiException<AcquiringCoinNameMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MiningPubCoinListResponse` | `src/Binance/Models/SapiV1MiningPubCoinListResponse.cs` |
| `AcquiringCoinNameMarketDataError` | `src/Binance/Errors/AcquiringCoinNameMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `CancelHashrateResaleConfigurationUserDataRequest` | `src/Binance/Requests/Mining/CancelHashrateResaleConfigurationUserDataRequest.cs` |
| `SapiV1MiningHashTransferConfigCancelResponse` | `src/Binance/Models/SapiV1MiningHashTransferConfigCancelResponse.cs` |
| `CancelHashrateResaleConfigurationUserDataError` | `src/Binance/Errors/CancelHashrateResaleConfigurationUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `EarningsListUserDataRequest` | `src/Binance/Requests/Mining/EarningsListUserDataRequest.cs` |
| `SapiV1MiningPaymentListResponse` | `src/Binance/Models/SapiV1MiningPaymentListResponse.cs` |
| `EarningsListUserDataError` | `src/Binance/Errors/EarningsListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `ExtraBonusListUserDataRequest` | `src/Binance/Requests/Mining/ExtraBonusListUserDataRequest.cs` |
| `SapiV1MiningPaymentOtherResponse` | `src/Binance/Models/SapiV1MiningPaymentOtherResponse.cs` |
| `ExtraBonusListUserDataError` | `src/Binance/Errors/ExtraBonusListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `HashrateResaleDetailsUserDataRequest` | `src/Binance/Requests/Mining/HashrateResaleDetailsUserDataRequest.cs` |
| `SapiV1MiningHashTransferProfitDetailsResponse` | `src/Binance/Models/SapiV1MiningHashTransferProfitDetailsResponse.cs` |
| `HashrateResaleDetailsUserDataError` | `src/Binance/Errors/HashrateResaleDetailsUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `HashrateResaleListUserDataRequest` | `src/Binance/Requests/Mining/HashrateResaleListUserDataRequest.cs` |
| `SapiV1MiningHashTransferConfigDetailsListResponse` | `src/Binance/Models/SapiV1MiningHashTransferConfigDetailsListResponse.cs` |
| `HashrateResaleListUserDataError` | `src/Binance/Errors/HashrateResaleListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `HashrateResaleRequestUserDataRequest` | `src/Binance/Requests/Mining/HashrateResaleRequestUserDataRequest.cs` |
| `SapiV1MiningHashTransferConfigResponse` | `src/Binance/Models/SapiV1MiningHashTransferConfigResponse.cs` |
| `HashrateResaleRequestUserDataError` | `src/Binance/Errors/HashrateResaleRequestUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `MiningAccountEarningUserDataRequest` | `src/Binance/Requests/Mining/MiningAccountEarningUserDataRequest.cs` |
| `SapiV1MiningPaymentUidResponse` | `src/Binance/Models/SapiV1MiningPaymentUidResponse.cs` |
| `MiningAccountEarningUserDataError` | `src/Binance/Errors/MiningAccountEarningUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `RequestForDetailMinerListUserDataRequest` | `src/Binance/Requests/Mining/RequestForDetailMinerListUserDataRequest.cs` |
| `SapiV1MiningWorkerDetailResponse` | `src/Binance/Models/SapiV1MiningWorkerDetailResponse.cs` |
| `RequestForDetailMinerListUserDataError` | `src/Binance/Errors/RequestForDetailMinerListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `RequestForMinerListUserDataRequest` | `src/Binance/Requests/Mining/RequestForMinerListUserDataRequest.cs` |
| `SapiV1MiningWorkerListResponse` | `src/Binance/Models/SapiV1MiningWorkerListResponse.cs` |
| `RequestForMinerListUserDataError` | `src/Binance/Errors/RequestForMinerListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `StatisticListUserDataRequest` | `src/Binance/Requests/Mining/StatisticListUserDataRequest.cs` |
| `SapiV1MiningStatisticsUserStatusResponse` | `src/Binance/Models/SapiV1MiningStatisticsUserStatusResponse.cs` |
| `StatisticListUserDataError` | `src/Binance/Errors/StatisticListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

