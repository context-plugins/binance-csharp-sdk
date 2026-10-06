<!-- Generated file — do not edit; regenerated with the SDK. -->

# Margin — operations

Accessor: `client.Margin` · Source: `Api/Margin.cs` · 48 operations

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
| `AdjustCrossMarginMaxLeverageUserDataRequest` | `Requests/Margin/AdjustCrossMarginMaxLeverageUserDataRequest.cs` |
| `SapiV1MarginMaxLeverageResponse` | `Models/SapiV1MarginMaxLeverageResponse.cs` |
| `AdjustCrossMarginMaxLeverageUserDataError` | `Errors/AdjustCrossMarginMaxLeverageUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### CrossMarginCollateralRatioMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CrossMarginCollateralRatioMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1MarginCrossMarginCollateralRatioResponse>`
- **Error**: `ApiException<CrossMarginCollateralRatioMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginCrossMarginCollateralRatioResponse` | `Models/SapiV1MarginCrossMarginCollateralRatioResponse.cs` |
| `CrossMarginCollateralRatioMarketDataError` | `Errors/CrossMarginCollateralRatioMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `DisableIsolatedMarginAccountTradeRequest` | `Requests/Margin/DisableIsolatedMarginAccountTradeRequest.cs` |
| `SapiV1MarginIsolatedAccountResponse` | `Models/SapiV1MarginIsolatedAccountResponse.cs` |
| `DisableIsolatedMarginAccountTradeError` | `Errors/DisableIsolatedMarginAccountTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `EnableIsolatedMarginAccountTradeRequest` | `Requests/Margin/EnableIsolatedMarginAccountTradeRequest.cs` |
| `SapiV1MarginIsolatedAccountResponse` | `Models/SapiV1MarginIsolatedAccountResponse.cs` |
| `EnableIsolatedMarginAccountTradeError` | `Errors/EnableIsolatedMarginAccountTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetAFutureHourlyInterestRateUserDataRequest` | `Requests/Margin/GetAFutureHourlyInterestRateUserDataRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginNextHourlyInterestRateResponse` | `Models/SapiV1MarginNextHourlyInterestRateResponse.cs` |
| `GetAFutureHourlyInterestRateUserDataError` | `Errors/GetAFutureHourlyInterestRateUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetAllCrossMarginPairsMarketDataRequest` | `Requests/Margin/GetAllCrossMarginPairsMarketDataRequest.cs` |
| `SapiV1MarginAllPairsResponse` | `Models/SapiV1MarginAllPairsResponse.cs` |
| `GetAllCrossMarginPairsMarketDataError` | `Errors/GetAllCrossMarginPairsMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetAllIsolatedMarginSymbolUserDataRequest` | `Requests/Margin/GetAllIsolatedMarginSymbolUserDataRequest.cs` |
| `SapiV1MarginIsolatedAllPairsResponse` | `Models/SapiV1MarginIsolatedAllPairsResponse.cs` |
| `GetAllIsolatedMarginSymbolUserDataError` | `Errors/GetAllIsolatedMarginSymbolUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetAllMarginAssetsMarketDataRequest` | `Requests/Margin/GetAllMarginAssetsMarketDataRequest.cs` |
| `SapiV1MarginAllAssetsResponse` | `Models/SapiV1MarginAllAssetsResponse.cs` |
| `GetAllMarginAssetsMarketDataError` | `Errors/GetAllMarginAssetsMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetBnbBurnStatusUserDataRequest` | `Requests/Margin/GetBnbBurnStatusUserDataRequest.cs` |
| `BnbBurnStatus` | `Models/BnbBurnStatus.cs` |
| `GetBnbBurnStatusUserDataError` | `Errors/GetBnbBurnStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetCrossMarginTransferHistoryUserDataRequest` | `Requests/Margin/GetCrossMarginTransferHistoryUserDataRequest.cs` |
| `Type2` | `Models/Enums/Type2.cs` |
| `SapiV1MarginTransferResponse` | `Models/SapiV1MarginTransferResponse.cs` |
| `GetCrossMarginTransferHistoryUserDataError` | `Errors/GetCrossMarginTransferHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetCrossOrIsolatedMarginCapitalFlowUserDataRequest` | `Requests/Margin/GetCrossOrIsolatedMarginCapitalFlowUserDataRequest.cs` |
| `Type3` | `Models/Enums/Type3.cs` |
| `SapiV1MarginCapitalFlowResponse` | `Models/SapiV1MarginCapitalFlowResponse.cs` |
| `GetCrossOrIsolatedMarginCapitalFlowUserDataError` | `Errors/GetCrossOrIsolatedMarginCapitalFlowUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetForceLiquidationRecordUserDataRequest` | `Requests/Margin/GetForceLiquidationRecordUserDataRequest.cs` |
| `SapiV1MarginForceLiquidationRecResponse` | `Models/SapiV1MarginForceLiquidationRecResponse.cs` |
| `GetForceLiquidationRecordUserDataError` | `Errors/GetForceLiquidationRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetInterestHistoryUserDataRequest` | `Requests/Margin/GetInterestHistoryUserDataRequest.cs` |
| `SapiV1MarginInterestHistoryResponse` | `Models/SapiV1MarginInterestHistoryResponse.cs` |
| `GetInterestHistoryUserDataError` | `Errors/GetInterestHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetSmallLiabilityExchangeCoinListUserDataRequest` | `Requests/Margin/GetSmallLiabilityExchangeCoinListUserDataRequest.cs` |
| `SapiV1MarginExchangeSmallLiabilityResponse` | `Models/SapiV1MarginExchangeSmallLiabilityResponse.cs` |
| `GetSmallLiabilityExchangeCoinListUserDataError` | `Errors/GetSmallLiabilityExchangeCoinListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetSmallLiabilityExchangeHistoryUserDataRequest` | `Requests/Margin/GetSmallLiabilityExchangeHistoryUserDataRequest.cs` |
| `SapiV1MarginExchangeSmallLiabilityHistoryResponse` | `Models/SapiV1MarginExchangeSmallLiabilityHistoryResponse.cs` |
| `GetSmallLiabilityExchangeHistoryUserDataError` | `Errors/GetSmallLiabilityExchangeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetSummaryOfMarginAccountUserDataRequest` | `Requests/Margin/GetSummaryOfMarginAccountUserDataRequest.cs` |
| `SapiV1MarginTradeCoeffResponse` | `Models/SapiV1MarginTradeCoeffResponse.cs` |
| `GetSummaryOfMarginAccountUserDataError` | `Errors/GetSummaryOfMarginAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest` | `Requests/Margin/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest.cs` |
| `SapiV1MarginDelistScheduleResponse` | `Models/SapiV1MarginDelistScheduleResponse.cs` |
| `GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError` | `Errors/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginAccountBorrowRepayMarginRequest` | `Requests/Margin/MarginAccountBorrowRepayMarginRequest.cs` |
| `SapiV1MarginBorrowRepayResponse` | `Models/SapiV1MarginBorrowRepayResponse.cs` |
| `MarginAccountBorrowRepayMarginError` | `Errors/MarginAccountBorrowRepayMarginError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest` | `Requests/Margin/MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginOpenOrdersResponse` | `Models/AnyOf/SapiV1MarginOpenOrdersResponse.cs` |
| `MarginAccountCancelAllOpenOrdersOnASymbolTradeError` | `Errors/MarginAccountCancelAllOpenOrdersOnASymbolTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginAccountCancelOcoTradeRequest` | `Requests/Margin/MarginAccountCancelOcoTradeRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOcoOrder` | `Models/MarginOcoOrder.cs` |
| `MarginAccountCancelOcoTradeError` | `Errors/MarginAccountCancelOcoTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginAccountCancelOrderTradeRequest` | `Requests/Margin/MarginAccountCancelOrderTradeRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOrder` | `Models/MarginOrder.cs` |
| `MarginAccountCancelOrderTradeError` | `Errors/MarginAccountCancelOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginAccountNewOcoTradeRequest` | `Requests/Margin/MarginAccountNewOcoTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `StopLimitTimeInForce` | `Models/Enums/StopLimitTimeInForce.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SideEffectType` | `Models/Enums/SideEffectType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `SapiV1MarginOrderOcoResponse` | `Models/SapiV1MarginOrderOcoResponse.cs` |
| `MarginAccountNewOcoTradeError` | `Errors/MarginAccountNewOcoTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginAccountNewOrderTradeRequest` | `Requests/Margin/MarginAccountNewOrderTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `Type1` | `Models/Enums/Type1.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SideEffectType` | `Models/Enums/SideEffectType.cs` |
| `TimeInForce` | `Models/Enums/TimeInForce.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `SapiV1MarginOrderResponse` | `Models/AnyOf/SapiV1MarginOrderResponse.cs` |
| `MarginAccountNewOrderTradeError` | `Errors/MarginAccountNewOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginAccountNewOtoTradeRequest` | `Requests/Margin/MarginAccountNewOtoTradeRequest.cs` |
| `WorkingType` | `Models/Enums/WorkingType.cs` |
| `WorkingSide` | `Models/Enums/WorkingSide.cs` |
| `PendingType` | `Models/Enums/PendingType.cs` |
| `PendingSide` | `Models/Enums/PendingSide.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SideEffectType1` | `Models/Enums/SideEffectType1.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `WorkingTimeInForce` | `Models/Enums/WorkingTimeInForce.cs` |
| `PendingTimeInForce` | `Models/Enums/PendingTimeInForce.cs` |
| `SapiV1MarginOrderOtoResponse` | `Models/SapiV1MarginOrderOtoResponse.cs` |
| `MarginAccountNewOtoTradeError` | `Errors/MarginAccountNewOtoTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginAccountNewOtocoTradeRequest` | `Requests/Margin/MarginAccountNewOtocoTradeRequest.cs` |
| `WorkingType` | `Models/Enums/WorkingType.cs` |
| `WorkingSide` | `Models/Enums/WorkingSide.cs` |
| `PendingSide` | `Models/Enums/PendingSide.cs` |
| `PendingAboveType` | `Models/Enums/PendingAboveType.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SideEffectType1` | `Models/Enums/SideEffectType1.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `WorkingTimeInForce` | `Models/Enums/WorkingTimeInForce.cs` |
| `PendingAboveTimeInForce` | `Models/Enums/PendingAboveTimeInForce.cs` |
| `PendingBelowType` | `Models/Enums/PendingBelowType.cs` |
| `PendingBelowTimeInForce` | `Models/Enums/PendingBelowTimeInForce.cs` |
| `SapiV1MarginOrderOtocoResponse` | `Models/SapiV1MarginOrderOtocoResponse.cs` |
| `MarginAccountNewOtocoTradeError` | `Errors/MarginAccountNewOtocoTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginInterestRateHistoryUserDataRequest` | `Requests/Margin/MarginInterestRateHistoryUserDataRequest.cs` |
| `SapiV1MarginInterestRateHistoryResponse` | `Models/SapiV1MarginInterestRateHistoryResponse.cs` |
| `MarginInterestRateHistoryUserDataError` | `Errors/MarginInterestRateHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginManualLiquidationMarginRequest` | `Requests/Margin/MarginManualLiquidationMarginRequest.cs` |
| `Type4` | `Models/Enums/Type4.cs` |
| `SapiV1MarginManualLiquidationResponse` | `Models/SapiV1MarginManualLiquidationResponse.cs` |
| `MarginManualLiquidationMarginError` | `Errors/MarginManualLiquidationMarginError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryBorrowRepayRecordsInMarginAccountUserDataRequest` | `Requests/Margin/QueryBorrowRepayRecordsInMarginAccountUserDataRequest.cs` |
| `SapiV1MarginBorrowRepayResponse1` | `Models/SapiV1MarginBorrowRepayResponse1.cs` |
| `QueryBorrowRepayRecordsInMarginAccountUserDataError` | `Errors/QueryBorrowRepayRecordsInMarginAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryCrossMarginAccountDetailsUserDataRequest` | `Requests/Margin/QueryCrossMarginAccountDetailsUserDataRequest.cs` |
| `SapiV1MarginAccountResponse` | `Models/SapiV1MarginAccountResponse.cs` |
| `QueryCrossMarginAccountDetailsUserDataError` | `Errors/QueryCrossMarginAccountDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryCrossMarginFeeDataUserDataRequest` | `Requests/Margin/QueryCrossMarginFeeDataUserDataRequest.cs` |
| `SapiV1MarginCrossMarginDataResponse` | `Models/SapiV1MarginCrossMarginDataResponse.cs` |
| `QueryCrossMarginFeeDataUserDataError` | `Errors/QueryCrossMarginFeeDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryCurrentMarginOrderCountUsageTradeRequest` | `Requests/Margin/QueryCurrentMarginOrderCountUsageTradeRequest.cs` |
| `SapiV1MarginRateLimitOrderResponse` | `Models/SapiV1MarginRateLimitOrderResponse.cs` |
| `QueryCurrentMarginOrderCountUsageTradeError` | `Errors/QueryCurrentMarginOrderCountUsageTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryEnabledIsolatedMarginAccountLimitUserDataRequest` | `Requests/Margin/QueryEnabledIsolatedMarginAccountLimitUserDataRequest.cs` |
| `SapiV1MarginIsolatedAccountLimitResponse` | `Models/SapiV1MarginIsolatedAccountLimitResponse.cs` |
| `QueryEnabledIsolatedMarginAccountLimitUserDataError` | `Errors/QueryEnabledIsolatedMarginAccountLimitUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryIsolatedMarginAccountInfoUserDataRequest` | `Requests/Margin/QueryIsolatedMarginAccountInfoUserDataRequest.cs` |
| `IsolatedMarginAccountInfo` | `Models/IsolatedMarginAccountInfo.cs` |
| `QueryIsolatedMarginAccountInfoUserDataError` | `Errors/QueryIsolatedMarginAccountInfoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryIsolatedMarginFeeDataUserDataRequest` | `Requests/Margin/QueryIsolatedMarginFeeDataUserDataRequest.cs` |
| `SapiV1MarginIsolatedMarginDataResponse` | `Models/SapiV1MarginIsolatedMarginDataResponse.cs` |
| `QueryIsolatedMarginFeeDataUserDataError` | `Errors/QueryIsolatedMarginFeeDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryIsolatedMarginTierDataUserDataRequest` | `Requests/Margin/QueryIsolatedMarginTierDataUserDataRequest.cs` |
| `SapiV1MarginIsolatedMarginTierResponse` | `Models/SapiV1MarginIsolatedMarginTierResponse.cs` |
| `QueryIsolatedMarginTierDataUserDataError` | `Errors/QueryIsolatedMarginTierDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1MarginLeverageBracketResponse>`
- **Error**: `ApiException<QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginLeverageBracketResponse` | `Models/SapiV1MarginLeverageBracketResponse.cs` |
| `QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError` | `Errors/QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMarginAccountSAllOcoUserDataRequest` | `Requests/Margin/QueryMarginAccountSAllOcoUserDataRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginAllOrderListResponse` | `Models/SapiV1MarginAllOrderListResponse.cs` |
| `QueryMarginAccountSAllOcoUserDataError` | `Errors/QueryMarginAccountSAllOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMarginAccountSAllOrdersUserDataRequest` | `Requests/Margin/QueryMarginAccountSAllOrdersUserDataRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOrderDetail` | `Models/MarginOrderDetail.cs` |
| `QueryMarginAccountSAllOrdersUserDataError` | `Errors/QueryMarginAccountSAllOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMarginAccountSOcoUserDataRequest` | `Requests/Margin/QueryMarginAccountSOcoUserDataRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginOrderListResponse` | `Models/SapiV1MarginOrderListResponse.cs` |
| `QueryMarginAccountSOcoUserDataError` | `Errors/QueryMarginAccountSOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMarginAccountSOpenOcoUserDataRequest` | `Requests/Margin/QueryMarginAccountSOpenOcoUserDataRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginOpenOrderListResponse` | `Models/SapiV1MarginOpenOrderListResponse.cs` |
| `QueryMarginAccountSOpenOcoUserDataError` | `Errors/QueryMarginAccountSOpenOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMarginAccountSOpenOrdersUserDataRequest` | `Requests/Margin/QueryMarginAccountSOpenOrdersUserDataRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOrderDetail` | `Models/MarginOrderDetail.cs` |
| `QueryMarginAccountSOpenOrdersUserDataError` | `Errors/QueryMarginAccountSOpenOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMarginAccountSOrderUserDataRequest` | `Requests/Margin/QueryMarginAccountSOrderUserDataRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOrderDetail` | `Models/MarginOrderDetail.cs` |
| `QueryMarginAccountSOrderUserDataError` | `Errors/QueryMarginAccountSOrderUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMarginAccountSTradeListUserDataRequest` | `Requests/Margin/QueryMarginAccountSTradeListUserDataRequest.cs` |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginTrade` | `Models/MarginTrade.cs` |
| `QueryMarginAccountSTradeListUserDataError` | `Errors/QueryMarginAccountSTradeListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMarginAvailableInventoryUserDataRequest` | `Requests/Margin/QueryMarginAvailableInventoryUserDataRequest.cs` |
| `Type4` | `Models/Enums/Type4.cs` |
| `SapiV1MarginAvailableInventoryResponse` | `Models/SapiV1MarginAvailableInventoryResponse.cs` |
| `QueryMarginAvailableInventoryUserDataError` | `Errors/QueryMarginAvailableInventoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMarginPriceIndexMarketDataRequest` | `Requests/Margin/QueryMarginPriceIndexMarketDataRequest.cs` |
| `SapiV1MarginPriceIndexResponse` | `Models/SapiV1MarginPriceIndexResponse.cs` |
| `QueryMarginPriceIndexMarketDataError` | `Errors/QueryMarginPriceIndexMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMaxBorrowUserDataRequest` | `Requests/Margin/QueryMaxBorrowUserDataRequest.cs` |
| `SapiV1MarginMaxBorrowableResponse` | `Models/SapiV1MarginMaxBorrowableResponse.cs` |
| `QueryMaxBorrowUserDataError` | `Errors/QueryMaxBorrowUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryMaxTransferOutAmountUserDataRequest` | `Requests/Margin/QueryMaxTransferOutAmountUserDataRequest.cs` |
| `SapiV1MarginMaxTransferableResponse` | `Models/SapiV1MarginMaxTransferableResponse.cs` |
| `QueryMaxTransferOutAmountUserDataError` | `Errors/QueryMaxTransferOutAmountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest` | `Requests/Margin/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest.cs` |
| `SpotBnbBurn` | `Models/Enums/SpotBnbBurn.cs` |
| `InterestBnbBurn` | `Models/Enums/InterestBnbBurn.cs` |
| `BnbBurnStatus` | `Models/BnbBurnStatus.cs` |
| `ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError` | `Errors/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError.cs` |
| `Error` | `Models/Error.cs` |

