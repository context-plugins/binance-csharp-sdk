<!-- Generated file — do not edit; regenerated with the SDK. -->

# PortfolioMargin — operations

Accessor: `client.PortfolioMargin` · Source: `Api/PortfolioMargin.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BnbTransferUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BnbTransferUserData(BnbTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransferSide`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `transferSide` ← `TransferSide`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PortfolioBnbTransferResponse`
- **Error**: `ApiException<BnbTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BnbTransferUserDataRequest` | `Requests/PortfolioMargin/BnbTransferUserDataRequest.cs` |
| `TransferSide` | `Models/Enums/TransferSide.cs` |
| `SapiV1PortfolioBnbTransferResponse` | `Models/SapiV1PortfolioBnbTransferResponse.cs` |
| `BnbTransferUserDataError` | `Errors/BnbTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### ChangeAutoRepayFuturesStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ChangeAutoRepayFuturesStatusUserData(ChangeAutoRepayFuturesStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AutoRepay`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `autoRepay` ← `AutoRepay`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PortfolioRepayFuturesSwitchResponse`
- **Error**: `ApiException<ChangeAutoRepayFuturesStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChangeAutoRepayFuturesStatusUserDataRequest` | `Requests/PortfolioMargin/ChangeAutoRepayFuturesStatusUserDataRequest.cs` |
| `SapiV1PortfolioRepayFuturesSwitchResponse` | `Models/SapiV1PortfolioRepayFuturesSwitchResponse.cs` |
| `ChangeAutoRepayFuturesStatusUserDataError` | `Errors/ChangeAutoRepayFuturesStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FundAutoCollectionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FundAutoCollectionUserData(FundAutoCollectionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PortfolioAutoCollectionResponse`
- **Error**: `ApiException<FundAutoCollectionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FundAutoCollectionUserDataRequest` | `Requests/PortfolioMargin/FundAutoCollectionUserDataRequest.cs` |
| `SapiV1PortfolioAutoCollectionResponse` | `Models/SapiV1PortfolioAutoCollectionResponse.cs` |
| `FundAutoCollectionUserDataError` | `Errors/FundAutoCollectionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FundCollectionByAssetUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FundCollectionByAssetUserData(FundCollectionByAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PortfolioAssetCollectionResponse`
- **Error**: `ApiException<FundCollectionByAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FundCollectionByAssetUserDataRequest` | `Requests/PortfolioMargin/FundCollectionByAssetUserDataRequest.cs` |
| `SapiV1PortfolioAssetCollectionResponse` | `Models/SapiV1PortfolioAssetCollectionResponse.cs` |
| `FundCollectionByAssetUserDataError` | `Errors/FundCollectionByAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetAutoRepayFuturesStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAutoRepayFuturesStatusUserData(GetAutoRepayFuturesStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PortfolioRepayFuturesSwitchResponse1`
- **Error**: `ApiException<GetAutoRepayFuturesStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAutoRepayFuturesStatusUserDataRequest` | `Requests/PortfolioMargin/GetAutoRepayFuturesStatusUserDataRequest.cs` |
| `SapiV1PortfolioRepayFuturesSwitchResponse1` | `Models/SapiV1PortfolioRepayFuturesSwitchResponse1.cs` |
| `GetAutoRepayFuturesStatusUserDataError` | `Errors/GetAutoRepayFuturesStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetPortfolioMarginAssetLeverageUserData

- **Signature**: `GetPortfolioMarginAssetLeverageUserData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1PortfolioMarginAssetLeverageResponse>`
- **Error**: `ApiException<GetPortfolioMarginAssetLeverageUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioMarginAssetLeverageResponse` | `Models/SapiV1PortfolioMarginAssetLeverageResponse.cs` |
| `GetPortfolioMarginAssetLeverageUserDataError` | `Errors/GetPortfolioMarginAssetLeverageUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PortfolioMarginAccountUserData(PortfolioMarginAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PortfolioAccountResponse`
- **Error**: `ApiException<PortfolioMarginAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PortfolioMarginAccountUserDataRequest` | `Requests/PortfolioMargin/PortfolioMarginAccountUserDataRequest.cs` |
| `SapiV1PortfolioAccountResponse` | `Models/SapiV1PortfolioAccountResponse.cs` |
| `PortfolioMarginAccountUserDataError` | `Errors/PortfolioMarginAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginBankruptcyLoanAmountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PortfolioMarginBankruptcyLoanAmountUserData(PortfolioMarginBankruptcyLoanAmountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PortfolioPmLoanResponse`
- **Error**: `ApiException<PortfolioMarginBankruptcyLoanAmountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PortfolioMarginBankruptcyLoanAmountUserDataRequest` | `Requests/PortfolioMargin/PortfolioMarginBankruptcyLoanAmountUserDataRequest.cs` |
| `SapiV1PortfolioPmLoanResponse` | `Models/SapiV1PortfolioPmLoanResponse.cs` |
| `PortfolioMarginBankruptcyLoanAmountUserDataError` | `Errors/PortfolioMarginBankruptcyLoanAmountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginBankruptcyLoanRepayUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PortfolioMarginBankruptcyLoanRepayUserData(PortfolioMarginBankruptcyLoanRepayUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `from` ← `From`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PortfolioRepayResponse`
- **Error**: `ApiException<PortfolioMarginBankruptcyLoanRepayUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PortfolioMarginBankruptcyLoanRepayUserDataRequest` | `Requests/PortfolioMargin/PortfolioMarginBankruptcyLoanRepayUserDataRequest.cs` |
| `SapiV1PortfolioRepayResponse` | `Models/SapiV1PortfolioRepayResponse.cs` |
| `PortfolioMarginBankruptcyLoanRepayUserDataError` | `Errors/PortfolioMarginBankruptcyLoanRepayUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginCollateralRateMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PortfolioMarginCollateralRateMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1PortfolioCollateralRateResponse>`
- **Error**: `ApiException<PortfolioMarginCollateralRateMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioCollateralRateResponse` | `Models/SapiV1PortfolioCollateralRateResponse.cs` |
| `PortfolioMarginCollateralRateMarketDataError` | `Errors/PortfolioMarginCollateralRateMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginProTieredCollateralRateUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PortfolioMarginProTieredCollateralRateUserData(PortfolioMarginProTieredCollateralRateUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV2PortfolioCollateralRateResponse>`
- **Error**: `ApiException<PortfolioMarginProTieredCollateralRateUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PortfolioMarginProTieredCollateralRateUserDataRequest` | `Requests/PortfolioMargin/PortfolioMarginProTieredCollateralRateUserDataRequest.cs` |
| `SapiV2PortfolioCollateralRateResponse` | `Models/SapiV2PortfolioCollateralRateResponse.cs` |
| `PortfolioMarginProTieredCollateralRateUserDataError` | `Errors/PortfolioMarginProTieredCollateralRateUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData(QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1PortfolioInterestHistoryResponse>`
- **Error**: `ApiException<QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest` | `Requests/PortfolioMargin/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest.cs` |
| `SapiV1PortfolioInterestHistoryResponse` | `Models/SapiV1PortfolioInterestHistoryResponse.cs` |
| `QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError` | `Errors/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryPortfolioMarginAssetIndexPriceMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryPortfolioMarginAssetIndexPriceMarketData(QueryPortfolioMarginAssetIndexPriceMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `asset` ← `Asset`
- **Returns**: `IReadOnlyList<SapiV1PortfolioAssetIndexPriceResponse>`
- **Error**: `ApiException<QueryPortfolioMarginAssetIndexPriceMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryPortfolioMarginAssetIndexPriceMarketDataRequest` | `Requests/PortfolioMargin/QueryPortfolioMarginAssetIndexPriceMarketDataRequest.cs` |
| `SapiV1PortfolioAssetIndexPriceResponse` | `Models/SapiV1PortfolioAssetIndexPriceResponse.cs` |
| `QueryPortfolioMarginAssetIndexPriceMarketDataError` | `Errors/QueryPortfolioMarginAssetIndexPriceMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### RepayFuturesNegativeBalanceUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RepayFuturesNegativeBalanceUserData(RepayFuturesNegativeBalanceUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1PortfolioRepayFuturesNegativeBalanceResponse`
- **Error**: `ApiException<RepayFuturesNegativeBalanceUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RepayFuturesNegativeBalanceUserDataRequest` | `Requests/PortfolioMargin/RepayFuturesNegativeBalanceUserDataRequest.cs` |
| `SapiV1PortfolioRepayFuturesNegativeBalanceResponse` | `Models/SapiV1PortfolioRepayFuturesNegativeBalanceResponse.cs` |
| `RepayFuturesNegativeBalanceUserDataError` | `Errors/RepayFuturesNegativeBalanceUserDataError.cs` |
| `Error` | `Models/Error.cs` |

