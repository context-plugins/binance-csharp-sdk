<!-- Generated file — do not edit; regenerated with the SDK. -->

# Margin — operations

Accessor: `client.Margin` · Source: `src/Binance/Api/Margin.cs` · 48 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdjustCrossMarginMaxLeverageUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AdjustCrossMarginMaxLeverageUserData(AdjustCrossMarginMaxLeverageUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MaxLeverage`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `maxLeverage` ← `MaxLeverage`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginMaxLeverageResponse`
- **Error**: `ApiException<AdjustCrossMarginMaxLeverageUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AdjustCrossMarginMaxLeverageUserDataRequest` | `src/Binance/Requests/Margin/AdjustCrossMarginMaxLeverageUserDataRequest.cs` |
| `SapiV1MarginMaxLeverageResponse` | `src/Binance/Models/SapiV1MarginMaxLeverageResponse.cs` |
| `AdjustCrossMarginMaxLeverageUserDataError` | `src/Binance/Errors/AdjustCrossMarginMaxLeverageUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### CrossMarginCollateralRatioMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CrossMarginCollateralRatioMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1MarginCrossMarginCollateralRatioResponse>`
- **Error**: `ApiException<CrossMarginCollateralRatioMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginCrossMarginCollateralRatioResponse` | `src/Binance/Models/SapiV1MarginCrossMarginCollateralRatioResponse.cs` |
| `CrossMarginCollateralRatioMarketDataError` | `src/Binance/Errors/CrossMarginCollateralRatioMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### DisableIsolatedMarginAccountTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DisableIsolatedMarginAccountTrade(DisableIsolatedMarginAccountTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginIsolatedAccountResponse`
- **Error**: `ApiException<DisableIsolatedMarginAccountTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DisableIsolatedMarginAccountTradeRequest` | `src/Binance/Requests/Margin/DisableIsolatedMarginAccountTradeRequest.cs` |
| `SapiV1MarginIsolatedAccountResponse` | `src/Binance/Models/SapiV1MarginIsolatedAccountResponse.cs` |
| `DisableIsolatedMarginAccountTradeError` | `src/Binance/Errors/DisableIsolatedMarginAccountTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### EnableIsolatedMarginAccountTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EnableIsolatedMarginAccountTrade(EnableIsolatedMarginAccountTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginIsolatedAccountResponse`
- **Error**: `ApiException<EnableIsolatedMarginAccountTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableIsolatedMarginAccountTradeRequest` | `src/Binance/Requests/Margin/EnableIsolatedMarginAccountTradeRequest.cs` |
| `SapiV1MarginIsolatedAccountResponse` | `src/Binance/Models/SapiV1MarginIsolatedAccountResponse.cs` |
| `EnableIsolatedMarginAccountTradeError` | `src/Binance/Errors/EnableIsolatedMarginAccountTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetAFutureHourlyInterestRateUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAFutureHourlyInterestRateUserData(GetAFutureHourlyInterestRateUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `assets` ← `Assets`, `isIsolated` ← `IsIsolated`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginNextHourlyInterestRateResponse>`
- **Error**: `ApiException<GetAFutureHourlyInterestRateUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAFutureHourlyInterestRateUserDataRequest` | `src/Binance/Requests/Margin/GetAFutureHourlyInterestRateUserDataRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `SapiV1MarginNextHourlyInterestRateResponse` | `src/Binance/Models/SapiV1MarginNextHourlyInterestRateResponse.cs` |
| `GetAFutureHourlyInterestRateUserDataError` | `src/Binance/Errors/GetAFutureHourlyInterestRateUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetAllCrossMarginPairsMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAllCrossMarginPairsMarketData(GetAllCrossMarginPairsMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`
- **Returns**: `IReadOnlyList<SapiV1MarginAllPairsResponse>`
- **Error**: `ApiException<GetAllCrossMarginPairsMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAllCrossMarginPairsMarketDataRequest` | `src/Binance/Requests/Margin/GetAllCrossMarginPairsMarketDataRequest.cs` |
| `SapiV1MarginAllPairsResponse` | `src/Binance/Models/SapiV1MarginAllPairsResponse.cs` |
| `GetAllCrossMarginPairsMarketDataError` | `src/Binance/Errors/GetAllCrossMarginPairsMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetAllIsolatedMarginSymbolUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAllIsolatedMarginSymbolUserData(GetAllIsolatedMarginSymbolUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginIsolatedAllPairsResponse>`
- **Error**: `ApiException<GetAllIsolatedMarginSymbolUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAllIsolatedMarginSymbolUserDataRequest` | `src/Binance/Requests/Margin/GetAllIsolatedMarginSymbolUserDataRequest.cs` |
| `SapiV1MarginIsolatedAllPairsResponse` | `src/Binance/Models/SapiV1MarginIsolatedAllPairsResponse.cs` |
| `GetAllIsolatedMarginSymbolUserDataError` | `src/Binance/Errors/GetAllIsolatedMarginSymbolUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetAllMarginAssetsMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAllMarginAssetsMarketData(GetAllMarginAssetsMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`
- **Query params (wire ← C#)**: `asset` ← `Asset`
- **Returns**: `IReadOnlyList<SapiV1MarginAllAssetsResponse>`
- **Error**: `ApiException<GetAllMarginAssetsMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAllMarginAssetsMarketDataRequest` | `src/Binance/Requests/Margin/GetAllMarginAssetsMarketDataRequest.cs` |
| `SapiV1MarginAllAssetsResponse` | `src/Binance/Models/SapiV1MarginAllAssetsResponse.cs` |
| `GetAllMarginAssetsMarketDataError` | `src/Binance/Errors/GetAllMarginAssetsMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetBnbBurnStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetBnbBurnStatusUserData(GetBnbBurnStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `BnbBurnStatus`
- **Error**: `ApiException<GetBnbBurnStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBnbBurnStatusUserDataRequest` | `src/Binance/Requests/Margin/GetBnbBurnStatusUserDataRequest.cs` |
| `BnbBurnStatus` | `src/Binance/Models/BnbBurnStatus.cs` |
| `GetBnbBurnStatusUserDataError` | `src/Binance/Errors/GetBnbBurnStatusUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetCrossMarginTransferHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCrossMarginTransferHistoryUserData(GetCrossMarginTransferHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `type` ← `Type`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `isolatedSymbol` ← `IsolatedSymbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginTransferResponse`
- **Error**: `ApiException<GetCrossMarginTransferHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCrossMarginTransferHistoryUserDataRequest` | `src/Binance/Requests/Margin/GetCrossMarginTransferHistoryUserDataRequest.cs` |
| `Type2` | `src/Binance/Models/Enums/Type2.cs` |
| `SapiV1MarginTransferResponse` | `src/Binance/Models/SapiV1MarginTransferResponse.cs` |
| `GetCrossMarginTransferHistoryUserDataError` | `src/Binance/Errors/GetCrossMarginTransferHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetCrossOrIsolatedMarginCapitalFlowUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCrossOrIsolatedMarginCapitalFlowUserData(GetCrossOrIsolatedMarginCapitalFlowUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `symbol` ← `Symbol`, `type` ← `Type`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `fromId` ← `FromId`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginCapitalFlowResponse>`
- **Error**: `ApiException<GetCrossOrIsolatedMarginCapitalFlowUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCrossOrIsolatedMarginCapitalFlowUserDataRequest` | `src/Binance/Requests/Margin/GetCrossOrIsolatedMarginCapitalFlowUserDataRequest.cs` |
| `Type3` | `src/Binance/Models/Enums/Type3.cs` |
| `SapiV1MarginCapitalFlowResponse` | `src/Binance/Models/SapiV1MarginCapitalFlowResponse.cs` |
| `GetCrossOrIsolatedMarginCapitalFlowUserDataError` | `src/Binance/Errors/GetCrossOrIsolatedMarginCapitalFlowUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetForceLiquidationRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetForceLiquidationRecordUserData(GetForceLiquidationRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `isolatedSymbol` ← `IsolatedSymbol`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginForceLiquidationRecResponse`
- **Error**: `ApiException<GetForceLiquidationRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetForceLiquidationRecordUserDataRequest` | `src/Binance/Requests/Margin/GetForceLiquidationRecordUserDataRequest.cs` |
| `SapiV1MarginForceLiquidationRecResponse` | `src/Binance/Models/SapiV1MarginForceLiquidationRecResponse.cs` |
| `GetForceLiquidationRecordUserDataError` | `src/Binance/Errors/GetForceLiquidationRecordUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetInterestHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetInterestHistoryUserData(GetInterestHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `isolatedSymbol` ← `IsolatedSymbol`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `archived` ← `Archived`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginInterestHistoryResponse`
- **Error**: `ApiException<GetInterestHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInterestHistoryUserDataRequest` | `src/Binance/Requests/Margin/GetInterestHistoryUserDataRequest.cs` |
| `SapiV1MarginInterestHistoryResponse` | `src/Binance/Models/SapiV1MarginInterestHistoryResponse.cs` |
| `GetInterestHistoryUserDataError` | `src/Binance/Errors/GetInterestHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetSmallLiabilityExchangeCoinListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSmallLiabilityExchangeCoinListUserData(GetSmallLiabilityExchangeCoinListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginExchangeSmallLiabilityResponse>`
- **Error**: `ApiException<GetSmallLiabilityExchangeCoinListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSmallLiabilityExchangeCoinListUserDataRequest` | `src/Binance/Requests/Margin/GetSmallLiabilityExchangeCoinListUserDataRequest.cs` |
| `SapiV1MarginExchangeSmallLiabilityResponse` | `src/Binance/Models/SapiV1MarginExchangeSmallLiabilityResponse.cs` |
| `GetSmallLiabilityExchangeCoinListUserDataError` | `src/Binance/Errors/GetSmallLiabilityExchangeCoinListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetSmallLiabilityExchangeHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSmallLiabilityExchangeHistoryUserData(GetSmallLiabilityExchangeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `current` ← `Current`, `size` ← `Size`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginExchangeSmallLiabilityHistoryResponse`
- **Error**: `ApiException<GetSmallLiabilityExchangeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSmallLiabilityExchangeHistoryUserDataRequest` | `src/Binance/Requests/Margin/GetSmallLiabilityExchangeHistoryUserDataRequest.cs` |
| `SapiV1MarginExchangeSmallLiabilityHistoryResponse` | `src/Binance/Models/SapiV1MarginExchangeSmallLiabilityHistoryResponse.cs` |
| `GetSmallLiabilityExchangeHistoryUserDataError` | `src/Binance/Errors/GetSmallLiabilityExchangeHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetSummaryOfMarginAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSummaryOfMarginAccountUserData(GetSummaryOfMarginAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginTradeCoeffResponse`
- **Error**: `ApiException<GetSummaryOfMarginAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSummaryOfMarginAccountUserDataRequest` | `src/Binance/Requests/Margin/GetSummaryOfMarginAccountUserDataRequest.cs` |
| `SapiV1MarginTradeCoeffResponse` | `src/Binance/Models/SapiV1MarginTradeCoeffResponse.cs` |
| `GetSummaryOfMarginAccountUserDataError` | `src/Binance/Errors/GetSummaryOfMarginAccountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData(GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginDelistScheduleResponse>`
- **Error**: `ApiException<GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest` | `src/Binance/Requests/Margin/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest.cs` |
| `SapiV1MarginDelistScheduleResponse` | `src/Binance/Models/SapiV1MarginDelistScheduleResponse.cs` |
| `GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError` | `src/Binance/Errors/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginAccountBorrowRepayMargin

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountBorrowRepayMargin(MarginAccountBorrowRepayMarginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `IsIsolated`, `Symbol`, `Amount`, `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `isIsolated` ← `IsIsolated`, `symbol` ← `Symbol`, `amount` ← `Amount`, `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginBorrowRepayResponse`
- **Error**: `ApiException<MarginAccountBorrowRepayMarginError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginAccountBorrowRepayMarginRequest` | `src/Binance/Requests/Margin/MarginAccountBorrowRepayMarginRequest.cs` |
| `SapiV1MarginBorrowRepayResponse` | `src/Binance/Models/SapiV1MarginBorrowRepayResponse.cs` |
| `MarginAccountBorrowRepayMarginError` | `src/Binance/Errors/MarginAccountBorrowRepayMarginError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginAccountCancelAllOpenOrdersOnASymbolTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountCancelAllOpenOrdersOnASymbolTrade(MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginOpenOrdersResponse>`
- **Error**: `ApiException<MarginAccountCancelAllOpenOrdersOnASymbolTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest` | `src/Binance/Requests/Margin/MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `SapiV1MarginOpenOrdersResponse` | `src/Binance/Models/AnyOf/SapiV1MarginOpenOrdersResponse.cs` |
| `MarginAccountCancelAllOpenOrdersOnASymbolTradeError` | `src/Binance/Errors/MarginAccountCancelAllOpenOrdersOnASymbolTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginAccountCancelOcoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountCancelOcoTrade(MarginAccountCancelOcoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `orderListId` ← `OrderListId`, `listClientOrderId` ← `ListClientOrderId`, `newClientOrderId` ← `NewClientOrderId`, `recvWindow` ← `RecvWindow`
- **Returns**: `MarginOcoOrder`
- **Error**: `ApiException<MarginAccountCancelOcoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginAccountCancelOcoTradeRequest` | `src/Binance/Requests/Margin/MarginAccountCancelOcoTradeRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `MarginOcoOrder` | `src/Binance/Models/MarginOcoOrder.cs` |
| `MarginAccountCancelOcoTradeError` | `src/Binance/Errors/MarginAccountCancelOcoTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginAccountCancelOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountCancelOrderTrade(MarginAccountCancelOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `orderId` ← `OrderId`, `origClientOrderId` ← `OrigClientOrderId`, `newClientOrderId` ← `NewClientOrderId`, `recvWindow` ← `RecvWindow`
- **Returns**: `MarginOrder`
- **Error**: `ApiException<MarginAccountCancelOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginAccountCancelOrderTradeRequest` | `src/Binance/Requests/Margin/MarginAccountCancelOrderTradeRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `MarginOrder` | `src/Binance/Models/MarginOrder.cs` |
| `MarginAccountCancelOrderTradeError` | `src/Binance/Errors/MarginAccountCancelOrderTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginAccountNewOcoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountNewOcoTrade(MarginAccountNewOcoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Quantity`, `Price`, `StopPrice`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `quantity` ← `Quantity`, `price` ← `Price`, `stopPrice` ← `StopPrice`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `listClientOrderId` ← `ListClientOrderId`, `limitClientOrderId` ← `LimitClientOrderId`, `limitIcebergQty` ← `LimitIcebergQty`, `stopClientOrderId` ← `StopClientOrderId`, `stopLimitPrice` ← `StopLimitPrice`, `stopIcebergQty` ← `StopIcebergQty`, `stopLimitTimeInForce` ← `StopLimitTimeInForce`, `newOrderRespType` ← `NewOrderRespType`, `sideEffectType` ← `SideEffectType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginOrderOcoResponse`
- **Error**: `ApiException<MarginAccountNewOcoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginAccountNewOcoTradeRequest` | `src/Binance/Requests/Margin/MarginAccountNewOcoTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `StopLimitTimeInForce` | `src/Binance/Models/Enums/StopLimitTimeInForce.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SideEffectType` | `src/Binance/Models/Enums/SideEffectType.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `SapiV1MarginOrderOcoResponse` | `src/Binance/Models/SapiV1MarginOrderOcoResponse.cs` |
| `MarginAccountNewOcoTradeError` | `src/Binance/Errors/MarginAccountNewOcoTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginAccountNewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountNewOrderTrade(MarginAccountNewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Type`, `Quantity`, `AutoRepayAtCancel`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `type` ← `Type`, `quantity` ← `Quantity`, `autoRepayAtCancel` ← `AutoRepayAtCancel`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `quoteOrderQty` ← `QuoteOrderQty`, `price` ← `Price`, `stopPrice` ← `StopPrice`, `newClientOrderId` ← `NewClientOrderId`, `icebergQty` ← `IcebergQty`, `newOrderRespType` ← `NewOrderRespType`, `sideEffectType` ← `SideEffectType`, `timeInForce` ← `TimeInForce`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginOrderResponse`
- **Error**: `ApiException<MarginAccountNewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginAccountNewOrderTradeRequest` | `src/Binance/Requests/Margin/MarginAccountNewOrderTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `Type1` | `src/Binance/Models/Enums/Type1.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SideEffectType` | `src/Binance/Models/Enums/SideEffectType.cs` |
| `TimeInForce` | `src/Binance/Models/Enums/TimeInForce.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `SapiV1MarginOrderResponse` | `src/Binance/Models/AnyOf/SapiV1MarginOrderResponse.cs` |
| `MarginAccountNewOrderTradeError` | `src/Binance/Errors/MarginAccountNewOrderTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginAccountNewOtoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountNewOtoTrade(MarginAccountNewOtoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `WorkingType`, `WorkingSide`, `WorkingPrice`, `WorkingQuantity`, `WorkingIcebergQty`, `PendingType`, `PendingSide`, `PendingQuantity`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `workingType` ← `WorkingType`, `workingSide` ← `WorkingSide`, `workingPrice` ← `WorkingPrice`, `workingQuantity` ← `WorkingQuantity`, `workingIcebergQty` ← `WorkingIcebergQty`, `pendingType` ← `PendingType`, `pendingSide` ← `PendingSide`, `pendingQuantity` ← `PendingQuantity`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `listClientOrderId` ← `ListClientOrderId`, `newOrderRespType` ← `NewOrderRespType`, `sideEffectType` ← `SideEffectType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `autoRepayAtCancel` ← `AutoRepayAtCancel`, `workingClientOrderId` ← `WorkingClientOrderId`, `workingTimeInForce` ← `WorkingTimeInForce`, `pendingClientOrderId` ← `PendingClientOrderId`, `pendingPrice` ← `PendingPrice`, `pendingStopPrice` ← `PendingStopPrice`, `pendingTrailingDelta` ← `PendingTrailingDelta`, `pendingIcebergQty` ← `PendingIcebergQty`, `pendingTimeInForce` ← `PendingTimeInForce`
- **Returns**: `SapiV1MarginOrderOtoResponse`
- **Error**: `ApiException<MarginAccountNewOtoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginAccountNewOtoTradeRequest` | `src/Binance/Requests/Margin/MarginAccountNewOtoTradeRequest.cs` |
| `WorkingType` | `src/Binance/Models/Enums/WorkingType.cs` |
| `WorkingSide` | `src/Binance/Models/Enums/WorkingSide.cs` |
| `PendingType` | `src/Binance/Models/Enums/PendingType.cs` |
| `PendingSide` | `src/Binance/Models/Enums/PendingSide.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SideEffectType1` | `src/Binance/Models/Enums/SideEffectType1.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `WorkingTimeInForce` | `src/Binance/Models/Enums/WorkingTimeInForce.cs` |
| `PendingTimeInForce` | `src/Binance/Models/Enums/PendingTimeInForce.cs` |
| `SapiV1MarginOrderOtoResponse` | `src/Binance/Models/SapiV1MarginOrderOtoResponse.cs` |
| `MarginAccountNewOtoTradeError` | `src/Binance/Errors/MarginAccountNewOtoTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginAccountNewOtocoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountNewOtocoTrade(MarginAccountNewOtocoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `WorkingType`, `WorkingSide`, `WorkingPrice`, `WorkingQuantity`, `WorkingIcebergQty`, `PendingSide`, `PendingQuantity`, `PendingAboveType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `workingType` ← `WorkingType`, `workingSide` ← `WorkingSide`, `workingPrice` ← `WorkingPrice`, `workingQuantity` ← `WorkingQuantity`, `workingIcebergQty` ← `WorkingIcebergQty`, `pendingSide` ← `PendingSide`, `pendingQuantity` ← `PendingQuantity`, `pendingAboveType` ← `PendingAboveType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `sideEffectType` ← `SideEffectType`, `autoRepayAtCancel` ← `AutoRepayAtCancel`, `listClientOrderId` ← `ListClientOrderId`, `newOrderRespType` ← `NewOrderRespType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `workingClientOrderId` ← `WorkingClientOrderId`, `workingTimeInForce` ← `WorkingTimeInForce`, `pendingAboveClientOrderId` ← `PendingAboveClientOrderId`, `pendingAbovePrice` ← `PendingAbovePrice`, `pendingAboveStopPrice` ← `PendingAboveStopPrice`, `pendingAboveTrailingDelta` ← `PendingAboveTrailingDelta`, `pendingAboveIcebergQty` ← `PendingAboveIcebergQty`, `pendingAboveTimeInForce` ← `PendingAboveTimeInForce`, `pendingBelowType` ← `PendingBelowType`, `pendingBelowClientOrderId` ← `PendingBelowClientOrderId`, `pendingBelowPrice` ← `PendingBelowPrice`, `pendingBelowStopPrice` ← `PendingBelowStopPrice`, `pendingBelowTrailingDelta` ← `PendingBelowTrailingDelta`, `pendingBelowIcebergQty` ← `PendingBelowIcebergQty`, `pendingBelowTimeInForce` ← `PendingBelowTimeInForce`
- **Returns**: `SapiV1MarginOrderOtocoResponse`
- **Error**: `ApiException<MarginAccountNewOtocoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginAccountNewOtocoTradeRequest` | `src/Binance/Requests/Margin/MarginAccountNewOtocoTradeRequest.cs` |
| `WorkingType` | `src/Binance/Models/Enums/WorkingType.cs` |
| `WorkingSide` | `src/Binance/Models/Enums/WorkingSide.cs` |
| `PendingSide` | `src/Binance/Models/Enums/PendingSide.cs` |
| `PendingAboveType` | `src/Binance/Models/Enums/PendingAboveType.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `SideEffectType1` | `src/Binance/Models/Enums/SideEffectType1.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `WorkingTimeInForce` | `src/Binance/Models/Enums/WorkingTimeInForce.cs` |
| `PendingAboveTimeInForce` | `src/Binance/Models/Enums/PendingAboveTimeInForce.cs` |
| `PendingBelowType` | `src/Binance/Models/Enums/PendingBelowType.cs` |
| `PendingBelowTimeInForce` | `src/Binance/Models/Enums/PendingBelowTimeInForce.cs` |
| `SapiV1MarginOrderOtocoResponse` | `src/Binance/Models/SapiV1MarginOrderOtocoResponse.cs` |
| `MarginAccountNewOtocoTradeError` | `src/Binance/Errors/MarginAccountNewOtocoTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginInterestRateHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginInterestRateHistoryUserData(MarginInterestRateHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `vipLevel` ← `VipLevel`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginInterestRateHistoryResponse>`
- **Error**: `ApiException<MarginInterestRateHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginInterestRateHistoryUserDataRequest` | `src/Binance/Requests/Margin/MarginInterestRateHistoryUserDataRequest.cs` |
| `SapiV1MarginInterestRateHistoryResponse` | `src/Binance/Models/SapiV1MarginInterestRateHistoryResponse.cs` |
| `MarginInterestRateHistoryUserDataError` | `src/Binance/Errors/MarginInterestRateHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginManualLiquidationMargin

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginManualLiquidationMargin(MarginManualLiquidationMarginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `symbol` ← `Symbol`
- **Returns**: `IReadOnlyList<SapiV1MarginManualLiquidationResponse>`
- **Error**: `ApiException<MarginManualLiquidationMarginError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginManualLiquidationMarginRequest` | `src/Binance/Requests/Margin/MarginManualLiquidationMarginRequest.cs` |
| `Type4` | `src/Binance/Models/Enums/Type4.cs` |
| `SapiV1MarginManualLiquidationResponse` | `src/Binance/Models/SapiV1MarginManualLiquidationResponse.cs` |
| `MarginManualLiquidationMarginError` | `src/Binance/Errors/MarginManualLiquidationMarginError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryBorrowRepayRecordsInMarginAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryBorrowRepayRecordsInMarginAccountUserData(QueryBorrowRepayRecordsInMarginAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isolatedSymbol` ← `IsolatedSymbol`, `txId` ← `TxId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginBorrowRepayResponse1`
- **Error**: `ApiException<QueryBorrowRepayRecordsInMarginAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryBorrowRepayRecordsInMarginAccountUserDataRequest` | `src/Binance/Requests/Margin/QueryBorrowRepayRecordsInMarginAccountUserDataRequest.cs` |
| `SapiV1MarginBorrowRepayResponse1` | `src/Binance/Models/SapiV1MarginBorrowRepayResponse1.cs` |
| `QueryBorrowRepayRecordsInMarginAccountUserDataError` | `src/Binance/Errors/QueryBorrowRepayRecordsInMarginAccountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryCrossMarginAccountDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCrossMarginAccountDetailsUserData(QueryCrossMarginAccountDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginAccountResponse`
- **Error**: `ApiException<QueryCrossMarginAccountDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryCrossMarginAccountDetailsUserDataRequest` | `src/Binance/Requests/Margin/QueryCrossMarginAccountDetailsUserDataRequest.cs` |
| `SapiV1MarginAccountResponse` | `src/Binance/Models/SapiV1MarginAccountResponse.cs` |
| `QueryCrossMarginAccountDetailsUserDataError` | `src/Binance/Errors/QueryCrossMarginAccountDetailsUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryCrossMarginFeeDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCrossMarginFeeDataUserData(QueryCrossMarginFeeDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `vipLevel` ← `VipLevel`, `coin` ← `Coin`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginCrossMarginDataResponse>`
- **Error**: `ApiException<QueryCrossMarginFeeDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryCrossMarginFeeDataUserDataRequest` | `src/Binance/Requests/Margin/QueryCrossMarginFeeDataUserDataRequest.cs` |
| `SapiV1MarginCrossMarginDataResponse` | `src/Binance/Models/SapiV1MarginCrossMarginDataResponse.cs` |
| `QueryCrossMarginFeeDataUserDataError` | `src/Binance/Errors/QueryCrossMarginFeeDataUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryCurrentMarginOrderCountUsageTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCurrentMarginOrderCountUsageTrade(QueryCurrentMarginOrderCountUsageTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `symbol` ← `Symbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginRateLimitOrderResponse>`
- **Error**: `ApiException<QueryCurrentMarginOrderCountUsageTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryCurrentMarginOrderCountUsageTradeRequest` | `src/Binance/Requests/Margin/QueryCurrentMarginOrderCountUsageTradeRequest.cs` |
| `SapiV1MarginRateLimitOrderResponse` | `src/Binance/Models/SapiV1MarginRateLimitOrderResponse.cs` |
| `QueryCurrentMarginOrderCountUsageTradeError` | `src/Binance/Errors/QueryCurrentMarginOrderCountUsageTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryEnabledIsolatedMarginAccountLimitUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryEnabledIsolatedMarginAccountLimitUserData(QueryEnabledIsolatedMarginAccountLimitUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginIsolatedAccountLimitResponse`
- **Error**: `ApiException<QueryEnabledIsolatedMarginAccountLimitUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryEnabledIsolatedMarginAccountLimitUserDataRequest` | `src/Binance/Requests/Margin/QueryEnabledIsolatedMarginAccountLimitUserDataRequest.cs` |
| `SapiV1MarginIsolatedAccountLimitResponse` | `src/Binance/Models/SapiV1MarginIsolatedAccountLimitResponse.cs` |
| `QueryEnabledIsolatedMarginAccountLimitUserDataError` | `src/Binance/Errors/QueryEnabledIsolatedMarginAccountLimitUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryIsolatedMarginAccountInfoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIsolatedMarginAccountInfoUserData(QueryIsolatedMarginAccountInfoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `symbols` ← `Symbols`, `recvWindow` ← `RecvWindow`
- **Returns**: `IsolatedMarginAccountInfo`
- **Error**: `ApiException<QueryIsolatedMarginAccountInfoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryIsolatedMarginAccountInfoUserDataRequest` | `src/Binance/Requests/Margin/QueryIsolatedMarginAccountInfoUserDataRequest.cs` |
| `IsolatedMarginAccountInfo` | `src/Binance/Models/IsolatedMarginAccountInfo.cs` |
| `QueryIsolatedMarginAccountInfoUserDataError` | `src/Binance/Errors/QueryIsolatedMarginAccountInfoUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryIsolatedMarginFeeDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIsolatedMarginFeeDataUserData(QueryIsolatedMarginFeeDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `vipLevel` ← `VipLevel`, `symbol` ← `Symbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginIsolatedMarginDataResponse>`
- **Error**: `ApiException<QueryIsolatedMarginFeeDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryIsolatedMarginFeeDataUserDataRequest` | `src/Binance/Requests/Margin/QueryIsolatedMarginFeeDataUserDataRequest.cs` |
| `SapiV1MarginIsolatedMarginDataResponse` | `src/Binance/Models/SapiV1MarginIsolatedMarginDataResponse.cs` |
| `QueryIsolatedMarginFeeDataUserDataError` | `src/Binance/Errors/QueryIsolatedMarginFeeDataUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryIsolatedMarginTierDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIsolatedMarginTierDataUserData(QueryIsolatedMarginTierDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `tier` ← `Tier`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginIsolatedMarginTierResponse>`
- **Error**: `ApiException<QueryIsolatedMarginTierDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryIsolatedMarginTierDataUserDataRequest` | `src/Binance/Requests/Margin/QueryIsolatedMarginTierDataUserDataRequest.cs` |
| `SapiV1MarginIsolatedMarginTierResponse` | `src/Binance/Models/SapiV1MarginIsolatedMarginTierResponse.cs` |
| `QueryIsolatedMarginTierDataUserDataError` | `src/Binance/Errors/QueryIsolatedMarginTierDataUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1MarginLeverageBracketResponse>`
- **Error**: `ApiException<QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginLeverageBracketResponse` | `src/Binance/Models/SapiV1MarginLeverageBracketResponse.cs` |
| `QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError` | `src/Binance/Errors/QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMarginAccountSAllOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSAllOcoUserData(QueryMarginAccountSAllOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `symbol` ← `Symbol`, `fromId` ← `FromId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginAllOrderListResponse>`
- **Error**: `ApiException<QueryMarginAccountSAllOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMarginAccountSAllOcoUserDataRequest` | `src/Binance/Requests/Margin/QueryMarginAccountSAllOcoUserDataRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `SapiV1MarginAllOrderListResponse` | `src/Binance/Models/SapiV1MarginAllOrderListResponse.cs` |
| `QueryMarginAccountSAllOcoUserDataError` | `src/Binance/Errors/QueryMarginAccountSAllOcoUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMarginAccountSAllOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSAllOrdersUserData(QueryMarginAccountSAllOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `orderId` ← `OrderId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<MarginOrderDetail>`
- **Error**: `ApiException<QueryMarginAccountSAllOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMarginAccountSAllOrdersUserDataRequest` | `src/Binance/Requests/Margin/QueryMarginAccountSAllOrdersUserDataRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `MarginOrderDetail` | `src/Binance/Models/MarginOrderDetail.cs` |
| `QueryMarginAccountSAllOrdersUserDataError` | `src/Binance/Errors/QueryMarginAccountSAllOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMarginAccountSOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSOcoUserData(QueryMarginAccountSOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `symbol` ← `Symbol`, `orderListId` ← `OrderListId`, `origClientOrderId` ← `OrigClientOrderId`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginOrderListResponse`
- **Error**: `ApiException<QueryMarginAccountSOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMarginAccountSOcoUserDataRequest` | `src/Binance/Requests/Margin/QueryMarginAccountSOcoUserDataRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `SapiV1MarginOrderListResponse` | `src/Binance/Models/SapiV1MarginOrderListResponse.cs` |
| `QueryMarginAccountSOcoUserDataError` | `src/Binance/Errors/QueryMarginAccountSOcoUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMarginAccountSOpenOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSOpenOcoUserData(QueryMarginAccountSOpenOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `symbol` ← `Symbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginOpenOrderListResponse>`
- **Error**: `ApiException<QueryMarginAccountSOpenOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMarginAccountSOpenOcoUserDataRequest` | `src/Binance/Requests/Margin/QueryMarginAccountSOpenOcoUserDataRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `SapiV1MarginOpenOrderListResponse` | `src/Binance/Models/SapiV1MarginOpenOrderListResponse.cs` |
| `QueryMarginAccountSOpenOcoUserDataError` | `src/Binance/Errors/QueryMarginAccountSOpenOcoUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMarginAccountSOpenOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSOpenOrdersUserData(QueryMarginAccountSOpenOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `symbol` ← `Symbol`, `isIsolated` ← `IsIsolated`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<MarginOrderDetail>`
- **Error**: `ApiException<QueryMarginAccountSOpenOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMarginAccountSOpenOrdersUserDataRequest` | `src/Binance/Requests/Margin/QueryMarginAccountSOpenOrdersUserDataRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `MarginOrderDetail` | `src/Binance/Models/MarginOrderDetail.cs` |
| `QueryMarginAccountSOpenOrdersUserDataError` | `src/Binance/Errors/QueryMarginAccountSOpenOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMarginAccountSOrderUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSOrderUserData(QueryMarginAccountSOrderUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `orderId` ← `OrderId`, `origClientOrderId` ← `OrigClientOrderId`, `recvWindow` ← `RecvWindow`
- **Returns**: `MarginOrderDetail`
- **Error**: `ApiException<QueryMarginAccountSOrderUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMarginAccountSOrderUserDataRequest` | `src/Binance/Requests/Margin/QueryMarginAccountSOrderUserDataRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `MarginOrderDetail` | `src/Binance/Models/MarginOrderDetail.cs` |
| `QueryMarginAccountSOrderUserDataError` | `src/Binance/Errors/QueryMarginAccountSOrderUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMarginAccountSTradeListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSTradeListUserData(QueryMarginAccountSTradeListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isIsolated` ← `IsIsolated`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `fromId` ← `FromId`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<MarginTrade>`
- **Error**: `ApiException<QueryMarginAccountSTradeListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMarginAccountSTradeListUserDataRequest` | `src/Binance/Requests/Margin/QueryMarginAccountSTradeListUserDataRequest.cs` |
| `IsIsolated` | `src/Binance/Models/Enums/IsIsolated.cs` |
| `MarginTrade` | `src/Binance/Models/MarginTrade.cs` |
| `QueryMarginAccountSTradeListUserDataError` | `src/Binance/Errors/QueryMarginAccountSTradeListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMarginAvailableInventoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAvailableInventoryUserData(QueryMarginAvailableInventoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`
- **Returns**: `SapiV1MarginAvailableInventoryResponse`
- **Error**: `ApiException<QueryMarginAvailableInventoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMarginAvailableInventoryUserDataRequest` | `src/Binance/Requests/Margin/QueryMarginAvailableInventoryUserDataRequest.cs` |
| `Type4` | `src/Binance/Models/Enums/Type4.cs` |
| `SapiV1MarginAvailableInventoryResponse` | `src/Binance/Models/SapiV1MarginAvailableInventoryResponse.cs` |
| `QueryMarginAvailableInventoryUserDataError` | `src/Binance/Errors/QueryMarginAvailableInventoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMarginPriceIndexMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginPriceIndexMarketData(QueryMarginPriceIndexMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`
- **Returns**: `SapiV1MarginPriceIndexResponse`
- **Error**: `ApiException<QueryMarginPriceIndexMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMarginPriceIndexMarketDataRequest` | `src/Binance/Requests/Margin/QueryMarginPriceIndexMarketDataRequest.cs` |
| `SapiV1MarginPriceIndexResponse` | `src/Binance/Models/SapiV1MarginPriceIndexResponse.cs` |
| `QueryMarginPriceIndexMarketDataError` | `src/Binance/Errors/QueryMarginPriceIndexMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMaxBorrowUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMaxBorrowUserData(QueryMaxBorrowUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isolatedSymbol` ← `IsolatedSymbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginMaxBorrowableResponse`
- **Error**: `ApiException<QueryMaxBorrowUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMaxBorrowUserDataRequest` | `src/Binance/Requests/Margin/QueryMaxBorrowUserDataRequest.cs` |
| `SapiV1MarginMaxBorrowableResponse` | `src/Binance/Models/SapiV1MarginMaxBorrowableResponse.cs` |
| `QueryMaxBorrowUserDataError` | `src/Binance/Errors/QueryMaxBorrowUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryMaxTransferOutAmountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMaxTransferOutAmountUserData(QueryMaxTransferOutAmountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `isolatedSymbol` ← `IsolatedSymbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1MarginMaxTransferableResponse`
- **Error**: `ApiException<QueryMaxTransferOutAmountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMaxTransferOutAmountUserDataRequest` | `src/Binance/Requests/Margin/QueryMaxTransferOutAmountUserDataRequest.cs` |
| `SapiV1MarginMaxTransferableResponse` | `src/Binance/Models/SapiV1MarginMaxTransferableResponse.cs` |
| `QueryMaxTransferOutAmountUserDataError` | `src/Binance/Errors/QueryMaxTransferOutAmountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### ToggleBnbBurnOnSpotTradeAndMarginInterestUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ToggleBnbBurnOnSpotTradeAndMarginInterestUserData(ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `spotBNBBurn` ← `SpotBnbBurn`, `interestBNBBurn` ← `InterestBnbBurn`, `recvWindow` ← `RecvWindow`
- **Returns**: `BnbBurnStatus`
- **Error**: `ApiException<ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest` | `src/Binance/Requests/Margin/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest.cs` |
| `SpotBnbBurn` | `src/Binance/Models/Enums/SpotBnbBurn.cs` |
| `InterestBnbBurn` | `src/Binance/Models/Enums/InterestBnbBurn.cs` |
| `BnbBurnStatus` | `src/Binance/Models/BnbBurnStatus.cs` |
| `ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError` | `src/Binance/Errors/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

