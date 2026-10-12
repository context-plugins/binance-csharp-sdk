<!-- Generated file — do not edit; regenerated with the SDK. -->

# PortfolioMargin — operations

Accessor: `client.PortfolioMargin` · Source: `src/Binance/Api/PortfolioMargin.cs` · 14 operations

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
| `BnbTransferUserDataRequest` | `src/Binance/Requests/PortfolioMargin/BnbTransferUserDataRequest.cs` |
| `TransferSide` | `src/Binance/Models/Enums/TransferSide.cs` |
| `SapiV1PortfolioBnbTransferResponse` | `src/Binance/Models/SapiV1PortfolioBnbTransferResponse.cs` |
| `BnbTransferUserDataError` | `src/Binance/Errors/BnbTransferUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `ChangeAutoRepayFuturesStatusUserDataRequest` | `src/Binance/Requests/PortfolioMargin/ChangeAutoRepayFuturesStatusUserDataRequest.cs` |
| `SapiV1PortfolioRepayFuturesSwitchResponse` | `src/Binance/Models/SapiV1PortfolioRepayFuturesSwitchResponse.cs` |
| `ChangeAutoRepayFuturesStatusUserDataError` | `src/Binance/Errors/ChangeAutoRepayFuturesStatusUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `FundAutoCollectionUserDataRequest` | `src/Binance/Requests/PortfolioMargin/FundAutoCollectionUserDataRequest.cs` |
| `SapiV1PortfolioAutoCollectionResponse` | `src/Binance/Models/SapiV1PortfolioAutoCollectionResponse.cs` |
| `FundAutoCollectionUserDataError` | `src/Binance/Errors/FundAutoCollectionUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `FundCollectionByAssetUserDataRequest` | `src/Binance/Requests/PortfolioMargin/FundCollectionByAssetUserDataRequest.cs` |
| `SapiV1PortfolioAssetCollectionResponse` | `src/Binance/Models/SapiV1PortfolioAssetCollectionResponse.cs` |
| `FundCollectionByAssetUserDataError` | `src/Binance/Errors/FundCollectionByAssetUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetAutoRepayFuturesStatusUserDataRequest` | `src/Binance/Requests/PortfolioMargin/GetAutoRepayFuturesStatusUserDataRequest.cs` |
| `SapiV1PortfolioRepayFuturesSwitchResponse1` | `src/Binance/Models/SapiV1PortfolioRepayFuturesSwitchResponse1.cs` |
| `GetAutoRepayFuturesStatusUserDataError` | `src/Binance/Errors/GetAutoRepayFuturesStatusUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetPortfolioMarginAssetLeverageUserData

- **Signature**: `GetPortfolioMarginAssetLeverageUserData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1PortfolioMarginAssetLeverageResponse>`
- **Error**: `ApiException<GetPortfolioMarginAssetLeverageUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioMarginAssetLeverageResponse` | `src/Binance/Models/SapiV1PortfolioMarginAssetLeverageResponse.cs` |
| `GetPortfolioMarginAssetLeverageUserDataError` | `src/Binance/Errors/GetPortfolioMarginAssetLeverageUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `PortfolioMarginAccountUserDataRequest` | `src/Binance/Requests/PortfolioMargin/PortfolioMarginAccountUserDataRequest.cs` |
| `SapiV1PortfolioAccountResponse` | `src/Binance/Models/SapiV1PortfolioAccountResponse.cs` |
| `PortfolioMarginAccountUserDataError` | `src/Binance/Errors/PortfolioMarginAccountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `PortfolioMarginBankruptcyLoanAmountUserDataRequest` | `src/Binance/Requests/PortfolioMargin/PortfolioMarginBankruptcyLoanAmountUserDataRequest.cs` |
| `SapiV1PortfolioPmLoanResponse` | `src/Binance/Models/SapiV1PortfolioPmLoanResponse.cs` |
| `PortfolioMarginBankruptcyLoanAmountUserDataError` | `src/Binance/Errors/PortfolioMarginBankruptcyLoanAmountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `PortfolioMarginBankruptcyLoanRepayUserDataRequest` | `src/Binance/Requests/PortfolioMargin/PortfolioMarginBankruptcyLoanRepayUserDataRequest.cs` |
| `SapiV1PortfolioRepayResponse` | `src/Binance/Models/SapiV1PortfolioRepayResponse.cs` |
| `PortfolioMarginBankruptcyLoanRepayUserDataError` | `src/Binance/Errors/PortfolioMarginBankruptcyLoanRepayUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### PortfolioMarginCollateralRateMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PortfolioMarginCollateralRateMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1PortfolioCollateralRateResponse>`
- **Error**: `ApiException<PortfolioMarginCollateralRateMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioCollateralRateResponse` | `src/Binance/Models/SapiV1PortfolioCollateralRateResponse.cs` |
| `PortfolioMarginCollateralRateMarketDataError` | `src/Binance/Errors/PortfolioMarginCollateralRateMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `PortfolioMarginProTieredCollateralRateUserDataRequest` | `src/Binance/Requests/PortfolioMargin/PortfolioMarginProTieredCollateralRateUserDataRequest.cs` |
| `SapiV2PortfolioCollateralRateResponse` | `src/Binance/Models/SapiV2PortfolioCollateralRateResponse.cs` |
| `PortfolioMarginProTieredCollateralRateUserDataError` | `src/Binance/Errors/PortfolioMarginProTieredCollateralRateUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest` | `src/Binance/Requests/PortfolioMargin/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest.cs` |
| `SapiV1PortfolioInterestHistoryResponse` | `src/Binance/Models/SapiV1PortfolioInterestHistoryResponse.cs` |
| `QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError` | `src/Binance/Errors/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryPortfolioMarginAssetIndexPriceMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryPortfolioMarginAssetIndexPriceMarketData(QueryPortfolioMarginAssetIndexPriceMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `asset` ← `Asset`
- **Returns**: `IReadOnlyList<SapiV1PortfolioAssetIndexPriceResponse>`
- **Error**: `ApiException<QueryPortfolioMarginAssetIndexPriceMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryPortfolioMarginAssetIndexPriceMarketDataRequest` | `src/Binance/Requests/PortfolioMargin/QueryPortfolioMarginAssetIndexPriceMarketDataRequest.cs` |
| `SapiV1PortfolioAssetIndexPriceResponse` | `src/Binance/Models/SapiV1PortfolioAssetIndexPriceResponse.cs` |
| `QueryPortfolioMarginAssetIndexPriceMarketDataError` | `src/Binance/Errors/QueryPortfolioMarginAssetIndexPriceMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `RepayFuturesNegativeBalanceUserDataRequest` | `src/Binance/Requests/PortfolioMargin/RepayFuturesNegativeBalanceUserDataRequest.cs` |
| `SapiV1PortfolioRepayFuturesNegativeBalanceResponse` | `src/Binance/Models/SapiV1PortfolioRepayFuturesNegativeBalanceResponse.cs` |
| `RepayFuturesNegativeBalanceUserDataError` | `src/Binance/Errors/RepayFuturesNegativeBalanceUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

