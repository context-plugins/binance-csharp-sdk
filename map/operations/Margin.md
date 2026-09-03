<!-- Generated file — do not edit; regenerated with the SDK. -->

# Margin — operations

Accessor: `client.Margin` · Source: `Api/Margin.cs` · 48 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdjustCrossMarginMaxLeverageUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AdjustCrossMarginMaxLeverageUserData(int maxLeverage, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `maxLeverage` ← `maxLeverage`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginMaxLeverageResponse`
- **Error**: `SdkException<AdjustCrossMarginMaxLeverageUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginMaxLeverageResponse` | `Models/SapiV1MarginMaxLeverageResponse.cs` |
| `AdjustCrossMarginMaxLeverageUserDataError` | `Errors/AdjustCrossMarginMaxLeverageUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### CrossMarginCollateralRatioMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CrossMarginCollateralRatioMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<SapiV1MarginCrossMarginCollateralRatioResponse>`
- **Error**: `SdkException<CrossMarginCollateralRatioMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginCrossMarginCollateralRatioResponse` | `Models/SapiV1MarginCrossMarginCollateralRatioResponse.cs` |
| `CrossMarginCollateralRatioMarketDataError` | `Errors/CrossMarginCollateralRatioMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### DisableIsolatedMarginAccountTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DisableIsolatedMarginAccountTrade(string symbol, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginIsolatedAccountResponse`
- **Error**: `SdkException<DisableIsolatedMarginAccountTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginIsolatedAccountResponse` | `Models/SapiV1MarginIsolatedAccountResponse.cs` |
| `DisableIsolatedMarginAccountTradeError` | `Errors/DisableIsolatedMarginAccountTradeError.cs` |
| `Error` | `Models/Error.cs` |

### EnableIsolatedMarginAccountTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EnableIsolatedMarginAccountTrade(string symbol, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginIsolatedAccountResponse`
- **Error**: `SdkException<EnableIsolatedMarginAccountTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginIsolatedAccountResponse` | `Models/SapiV1MarginIsolatedAccountResponse.cs` |
| `EnableIsolatedMarginAccountTradeError` | `Errors/EnableIsolatedMarginAccountTradeError.cs` |
| `Error` | `Models/Error.cs` |

### GetAFutureHourlyInterestRateUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAFutureHourlyInterestRateUserData(long timestamp, string signature, string? assets, IsIsolated? isIsolated, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `assets` — nullable, no default → **must pass explicitly**
  - `isIsolated` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `assets` ← `assets`, `isIsolated` ← `isIsolated`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginNextHourlyInterestRateResponse>`
- **Error**: `SdkException<GetAFutureHourlyInterestRateUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginNextHourlyInterestRateResponse` | `Models/SapiV1MarginNextHourlyInterestRateResponse.cs` |
| `GetAFutureHourlyInterestRateUserDataError` | `Errors/GetAFutureHourlyInterestRateUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetAllCrossMarginPairsMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAllCrossMarginPairsMarketData(string symbol, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `symbol` ← `symbol`
- **Returns**: `IReadOnlyList<SapiV1MarginAllPairsResponse>`
- **Error**: `SdkException<GetAllCrossMarginPairsMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginAllPairsResponse` | `Models/SapiV1MarginAllPairsResponse.cs` |
| `GetAllCrossMarginPairsMarketDataError` | `Errors/GetAllCrossMarginPairsMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetAllIsolatedMarginSymbolUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAllIsolatedMarginSymbolUserData(string symbol, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginIsolatedAllPairsResponse>`
- **Error**: `SdkException<GetAllIsolatedMarginSymbolUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginIsolatedAllPairsResponse` | `Models/SapiV1MarginIsolatedAllPairsResponse.cs` |
| `GetAllIsolatedMarginSymbolUserDataError` | `Errors/GetAllIsolatedMarginSymbolUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetAllMarginAssetsMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAllMarginAssetsMarketData(string asset, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `asset` ← `asset`
- **Returns**: `IReadOnlyList<SapiV1MarginAllAssetsResponse>`
- **Error**: `SdkException<GetAllMarginAssetsMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginAllAssetsResponse` | `Models/SapiV1MarginAllAssetsResponse.cs` |
| `GetAllMarginAssetsMarketDataError` | `Errors/GetAllMarginAssetsMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetBnbBurnStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetBnbBurnStatusUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `BnbBurnStatus`
- **Error**: `SdkException<GetBnbBurnStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BnbBurnStatus` | `Models/BnbBurnStatus.cs` |
| `GetBnbBurnStatusUserDataError` | `Errors/GetBnbBurnStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCrossMarginTransferHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCrossMarginTransferHistoryUserData(long timestamp, string signature, string? asset, Type2? type, long? startTime, long? endTime, int? current, int? size, string? isolatedSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `type` ← `type`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `isolatedSymbol` ← `isolatedSymbol`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginTransferResponse`
- **Error**: `SdkException<GetCrossMarginTransferHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type2` | `Models/Enums/Type2.cs` |
| `SapiV1MarginTransferResponse` | `Models/SapiV1MarginTransferResponse.cs` |
| `GetCrossMarginTransferHistoryUserDataError` | `Errors/GetCrossMarginTransferHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCrossOrIsolatedMarginCapitalFlowUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCrossOrIsolatedMarginCapitalFlowUserData(long timestamp, string signature, string? asset, string? symbol, Type3? type, long? startTime, long? endTime, long? fromId, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `symbol` ← `symbol`, `type` ← `type`, `startTime` ← `startTime`, `endTime` ← `endTime`, `fromId` ← `fromId`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginCapitalFlowResponse>`
- **Error**: `SdkException<GetCrossOrIsolatedMarginCapitalFlowUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type3` | `Models/Enums/Type3.cs` |
| `SapiV1MarginCapitalFlowResponse` | `Models/SapiV1MarginCapitalFlowResponse.cs` |
| `GetCrossOrIsolatedMarginCapitalFlowUserDataError` | `Errors/GetCrossOrIsolatedMarginCapitalFlowUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetForceLiquidationRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetForceLiquidationRecordUserData(long timestamp, string signature, long? startTime, long? endTime, string? isolatedSymbol, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `isolatedSymbol` ← `isolatedSymbol`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginForceLiquidationRecResponse`
- **Error**: `SdkException<GetForceLiquidationRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginForceLiquidationRecResponse` | `Models/SapiV1MarginForceLiquidationRecResponse.cs` |
| `GetForceLiquidationRecordUserDataError` | `Errors/GetForceLiquidationRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetInterestHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetInterestHistoryUserData(long timestamp, string signature, string? asset, string? isolatedSymbol, long? startTime, long? endTime, int? current, int? size, string? archived, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `isolatedSymbol` ← `isolatedSymbol`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `archived` ← `archived`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginInterestHistoryResponse`
- **Error**: `SdkException<GetInterestHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginInterestHistoryResponse` | `Models/SapiV1MarginInterestHistoryResponse.cs` |
| `GetInterestHistoryUserDataError` | `Errors/GetInterestHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetSmallLiabilityExchangeCoinListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSmallLiabilityExchangeCoinListUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginExchangeSmallLiabilityResponse>`
- **Error**: `SdkException<GetSmallLiabilityExchangeCoinListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginExchangeSmallLiabilityResponse` | `Models/SapiV1MarginExchangeSmallLiabilityResponse.cs` |
| `GetSmallLiabilityExchangeCoinListUserDataError` | `Errors/GetSmallLiabilityExchangeCoinListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetSmallLiabilityExchangeHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSmallLiabilityExchangeHistoryUserData(long timestamp, string signature, int? current, int? size, long? startTime, long? endTime, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`current` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `current` ← `current`, `size` ← `size`, `startTime` ← `startTime`, `endTime` ← `endTime`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginExchangeSmallLiabilityHistoryResponse`
- **Error**: `SdkException<GetSmallLiabilityExchangeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginExchangeSmallLiabilityHistoryResponse` | `Models/SapiV1MarginExchangeSmallLiabilityHistoryResponse.cs` |
| `GetSmallLiabilityExchangeHistoryUserDataError` | `Errors/GetSmallLiabilityExchangeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetSummaryOfMarginAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSummaryOfMarginAccountUserData(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginTradeCoeffResponse`
- **Error**: `SdkException<GetSummaryOfMarginAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginTradeCoeffResponse` | `Models/SapiV1MarginTradeCoeffResponse.cs` |
| `GetSummaryOfMarginAccountUserDataError` | `Errors/GetSummaryOfMarginAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginDelistScheduleResponse>`
- **Error**: `SdkException<GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginDelistScheduleResponse` | `Models/SapiV1MarginDelistScheduleResponse.cs` |
| `GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError` | `Errors/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### MarginAccountBorrowRepayMargin

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountBorrowRepayMargin(string asset, string isIsolated, string symbol, double amount, string type, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `asset` ← `asset`, `isIsolated` ← `isIsolated`, `symbol` ← `symbol`, `amount` ← `amount`, `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginBorrowRepayResponse`
- **Error**: `SdkException<MarginAccountBorrowRepayMarginError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginBorrowRepayResponse` | `Models/SapiV1MarginBorrowRepayResponse.cs` |
| `MarginAccountBorrowRepayMarginError` | `Errors/MarginAccountBorrowRepayMarginError.cs` |
| `Error` | `Models/Error.cs` |

### MarginAccountCancelAllOpenOrdersOnASymbolTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountCancelAllOpenOrdersOnASymbolTrade(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `isIsolated` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginOpenOrdersResponse>`
- **Error**: `SdkException<MarginAccountCancelAllOpenOrdersOnASymbolTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginOpenOrdersResponse` | `Models/AnyOf/SapiV1MarginOpenOrdersResponse.cs` |
| `MarginAccountCancelAllOpenOrdersOnASymbolTradeError` | `Errors/MarginAccountCancelAllOpenOrdersOnASymbolTradeError.cs` |
| `Error` | `Models/Error.cs` |

### MarginAccountCancelOcoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountCancelOcoTrade(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? orderListId, string? listClientOrderId, string? newClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`isIsolated` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `orderListId` ← `orderListId`, `listClientOrderId` ← `listClientOrderId`, `newClientOrderId` ← `newClientOrderId`, `recvWindow` ← `recvWindow`
- **Returns**: `MarginOcoOrder`
- **Error**: `SdkException<MarginAccountCancelOcoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOcoOrder` | `Models/MarginOcoOrder.cs` |
| `MarginAccountCancelOcoTradeError` | `Errors/MarginAccountCancelOcoTradeError.cs` |
| `Error` | `Models/Error.cs` |

### MarginAccountCancelOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountCancelOrderTrade(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? orderId, string? origClientOrderId, string? newClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`isIsolated` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `orderId` ← `orderId`, `origClientOrderId` ← `origClientOrderId`, `newClientOrderId` ← `newClientOrderId`, `recvWindow` ← `recvWindow`
- **Returns**: `MarginOrder`
- **Error**: `SdkException<MarginAccountCancelOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOrder` | `Models/MarginOrder.cs` |
| `MarginAccountCancelOrderTradeError` | `Errors/MarginAccountCancelOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

### MarginAccountNewOcoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginAccountNewOcoTrade(string symbol, Side side, double quantity, double price, double stopPrice, long timestamp, string signature, IsIsolated? isIsolated, string? listClientOrderId, string? limitClientOrderId, double? limitIcebergQty, string? stopClientOrderId, double? stopLimitPrice, double? stopIcebergQty, StopLimitTimeInForce? stopLimitTimeInForce, NewOrderRespType? newOrderRespType, SideEffectType? sideEffectType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 12 params (`isIsolated` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `quantity` ← `quantity`, `price` ← `price`, `stopPrice` ← `stopPrice`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `listClientOrderId` ← `listClientOrderId`, `limitClientOrderId` ← `limitClientOrderId`, `limitIcebergQty` ← `limitIcebergQty`, `stopClientOrderId` ← `stopClientOrderId`, `stopLimitPrice` ← `stopLimitPrice`, `stopIcebergQty` ← `stopIcebergQty`, `stopLimitTimeInForce` ← `stopLimitTimeInForce`, `newOrderRespType` ← `newOrderRespType`, `sideEffectType` ← `sideEffectType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginOrderOcoResponse`
- **Error**: `SdkException<MarginAccountNewOcoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `MarginAccountNewOrderTrade(string symbol, Side side, Type1 type, double quantity, bool autoRepayAtCancel, long timestamp, string signature, IsIsolated? isIsolated, double? quoteOrderQty, double? price, double? stopPrice, string? newClientOrderId, double? icebergQty, NewOrderRespType? newOrderRespType, SideEffectType? sideEffectType, TimeInForce? timeInForce, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 11 params (`isIsolated` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `type` ← `type`, `quantity` ← `quantity`, `autoRepayAtCancel` ← `autoRepayAtCancel`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `quoteOrderQty` ← `quoteOrderQty`, `price` ← `price`, `stopPrice` ← `stopPrice`, `newClientOrderId` ← `newClientOrderId`, `icebergQty` ← `icebergQty`, `newOrderRespType` ← `newOrderRespType`, `sideEffectType` ← `sideEffectType`, `timeInForce` ← `timeInForce`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginOrderResponse`
- **Error**: `SdkException<MarginAccountNewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `MarginAccountNewOtoTrade(string symbol, WorkingType workingType, WorkingSide workingSide, double workingPrice, double workingQuantity, double workingIcebergQty, PendingType pendingType, PendingSide pendingSide, double pendingQuantity, long timestamp, string signature, IsIsolated? isIsolated, string? listClientOrderId, NewOrderRespType? newOrderRespType, SideEffectType1? sideEffectType, SelfTradePreventionMode? selfTradePreventionMode, bool? autoRepayAtCancel, string? workingClientOrderId, WorkingTimeInForce? workingTimeInForce, string? pendingClientOrderId, double? pendingPrice, double? pendingStopPrice, double? pendingTrailingDelta, double? pendingIcebergQty, PendingTimeInForce? pendingTimeInForce, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 14 params (`isIsolated` … `pendingTimeInForce`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `workingType` ← `workingType`, `workingSide` ← `workingSide`, `workingPrice` ← `workingPrice`, `workingQuantity` ← `workingQuantity`, `workingIcebergQty` ← `workingIcebergQty`, `pendingType` ← `pendingType`, `pendingSide` ← `pendingSide`, `pendingQuantity` ← `pendingQuantity`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `listClientOrderId` ← `listClientOrderId`, `newOrderRespType` ← `newOrderRespType`, `sideEffectType` ← `sideEffectType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `autoRepayAtCancel` ← `autoRepayAtCancel`, `workingClientOrderId` ← `workingClientOrderId`, `workingTimeInForce` ← `workingTimeInForce`, `pendingClientOrderId` ← `pendingClientOrderId`, `pendingPrice` ← `pendingPrice`, `pendingStopPrice` ← `pendingStopPrice`, `pendingTrailingDelta` ← `pendingTrailingDelta`, `pendingIcebergQty` ← `pendingIcebergQty`, `pendingTimeInForce` ← `pendingTimeInForce`
- **Returns**: `SapiV1MarginOrderOtoResponse`
- **Error**: `SdkException<MarginAccountNewOtoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `MarginAccountNewOtocoTrade(string symbol, WorkingType workingType, WorkingSide workingSide, double workingPrice, double workingQuantity, double workingIcebergQty, PendingSide pendingSide, double pendingQuantity, PendingAboveType pendingAboveType, long timestamp, string signature, IsIsolated? isIsolated, SideEffectType1? sideEffectType, bool? autoRepayAtCancel, string? listClientOrderId, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, string? workingClientOrderId, WorkingTimeInForce? workingTimeInForce, string? pendingAboveClientOrderId, double? pendingAbovePrice, double? pendingAboveStopPrice, double? pendingAboveTrailingDelta, double? pendingAboveIcebergQty, PendingAboveTimeInForce? pendingAboveTimeInForce, PendingBelowType? pendingBelowType, string? pendingBelowClientOrderId, double? pendingBelowPrice, double? pendingBelowStopPrice, double? pendingBelowTrailingDelta, double? pendingBelowIcebergQty, PendingBelowTimeInForce? pendingBelowTimeInForce, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 21 params (`isIsolated` … `pendingBelowTimeInForce`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `workingType` ← `workingType`, `workingSide` ← `workingSide`, `workingPrice` ← `workingPrice`, `workingQuantity` ← `workingQuantity`, `workingIcebergQty` ← `workingIcebergQty`, `pendingSide` ← `pendingSide`, `pendingQuantity` ← `pendingQuantity`, `pendingAboveType` ← `pendingAboveType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `sideEffectType` ← `sideEffectType`, `autoRepayAtCancel` ← `autoRepayAtCancel`, `listClientOrderId` ← `listClientOrderId`, `newOrderRespType` ← `newOrderRespType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `workingClientOrderId` ← `workingClientOrderId`, `workingTimeInForce` ← `workingTimeInForce`, `pendingAboveClientOrderId` ← `pendingAboveClientOrderId`, `pendingAbovePrice` ← `pendingAbovePrice`, `pendingAboveStopPrice` ← `pendingAboveStopPrice`, `pendingAboveTrailingDelta` ← `pendingAboveTrailingDelta`, `pendingAboveIcebergQty` ← `pendingAboveIcebergQty`, `pendingAboveTimeInForce` ← `pendingAboveTimeInForce`, `pendingBelowType` ← `pendingBelowType`, `pendingBelowClientOrderId` ← `pendingBelowClientOrderId`, `pendingBelowPrice` ← `pendingBelowPrice`, `pendingBelowStopPrice` ← `pendingBelowStopPrice`, `pendingBelowTrailingDelta` ← `pendingBelowTrailingDelta`, `pendingBelowIcebergQty` ← `pendingBelowIcebergQty`, `pendingBelowTimeInForce` ← `pendingBelowTimeInForce`
- **Returns**: `SapiV1MarginOrderOtocoResponse`
- **Error**: `SdkException<MarginAccountNewOtocoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `MarginInterestRateHistoryUserData(string asset, long timestamp, string signature, int? vipLevel, long? startTime, long? endTime, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`vipLevel` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `asset` ← `asset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `vipLevel` ← `vipLevel`, `startTime` ← `startTime`, `endTime` ← `endTime`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginInterestRateHistoryResponse>`
- **Error**: `SdkException<MarginInterestRateHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginInterestRateHistoryResponse` | `Models/SapiV1MarginInterestRateHistoryResponse.cs` |
| `MarginInterestRateHistoryUserDataError` | `Errors/MarginInterestRateHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### MarginManualLiquidationMargin

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginManualLiquidationMargin(Type4 type, long timestamp, string signature, string? symbol, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `symbol` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `symbol` ← `symbol`
- **Returns**: `IReadOnlyList<SapiV1MarginManualLiquidationResponse>`
- **Error**: `SdkException<MarginManualLiquidationMarginError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type4` | `Models/Enums/Type4.cs` |
| `SapiV1MarginManualLiquidationResponse` | `Models/SapiV1MarginManualLiquidationResponse.cs` |
| `MarginManualLiquidationMarginError` | `Errors/MarginManualLiquidationMarginError.cs` |
| `Error` | `Models/Error.cs` |

### QueryBorrowRepayRecordsInMarginAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryBorrowRepayRecordsInMarginAccountUserData(string asset, string type, long timestamp, string signature, string? isolatedSymbol, long? txId, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`isolatedSymbol` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `asset` ← `asset`, `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isolatedSymbol` ← `isolatedSymbol`, `txId` ← `txId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginBorrowRepayResponse1`
- **Error**: `SdkException<QueryBorrowRepayRecordsInMarginAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginBorrowRepayResponse1` | `Models/SapiV1MarginBorrowRepayResponse1.cs` |
| `QueryBorrowRepayRecordsInMarginAccountUserDataError` | `Errors/QueryBorrowRepayRecordsInMarginAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryCrossMarginAccountDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCrossMarginAccountDetailsUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginAccountResponse`
- **Error**: `SdkException<QueryCrossMarginAccountDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginAccountResponse` | `Models/SapiV1MarginAccountResponse.cs` |
| `QueryCrossMarginAccountDetailsUserDataError` | `Errors/QueryCrossMarginAccountDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryCrossMarginFeeDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCrossMarginFeeDataUserData(long timestamp, string signature, int? vipLevel, string? coin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `vipLevel` — nullable, no default → **must pass explicitly**
  - `coin` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `vipLevel` ← `vipLevel`, `coin` ← `coin`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginCrossMarginDataResponse>`
- **Error**: `SdkException<QueryCrossMarginFeeDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginCrossMarginDataResponse` | `Models/SapiV1MarginCrossMarginDataResponse.cs` |
| `QueryCrossMarginFeeDataUserDataError` | `Errors/QueryCrossMarginFeeDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryCurrentMarginOrderCountUsageTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCurrentMarginOrderCountUsageTrade(long timestamp, string signature, string? isIsolated, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `isIsolated` — nullable, no default → **must pass explicitly**
  - `symbol` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `symbol` ← `symbol`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginRateLimitOrderResponse>`
- **Error**: `SdkException<QueryCurrentMarginOrderCountUsageTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginRateLimitOrderResponse` | `Models/SapiV1MarginRateLimitOrderResponse.cs` |
| `QueryCurrentMarginOrderCountUsageTradeError` | `Errors/QueryCurrentMarginOrderCountUsageTradeError.cs` |
| `Error` | `Models/Error.cs` |

### QueryEnabledIsolatedMarginAccountLimitUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryEnabledIsolatedMarginAccountLimitUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginIsolatedAccountLimitResponse`
- **Error**: `SdkException<QueryEnabledIsolatedMarginAccountLimitUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginIsolatedAccountLimitResponse` | `Models/SapiV1MarginIsolatedAccountLimitResponse.cs` |
| `QueryEnabledIsolatedMarginAccountLimitUserDataError` | `Errors/QueryEnabledIsolatedMarginAccountLimitUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryIsolatedMarginAccountInfoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIsolatedMarginAccountInfoUserData(long timestamp, string signature, string? symbols, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `symbols` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `symbols` ← `symbols`, `recvWindow` ← `recvWindow`
- **Returns**: `IsolatedMarginAccountInfo`
- **Error**: `SdkException<QueryIsolatedMarginAccountInfoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsolatedMarginAccountInfo` | `Models/IsolatedMarginAccountInfo.cs` |
| `QueryIsolatedMarginAccountInfoUserDataError` | `Errors/QueryIsolatedMarginAccountInfoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryIsolatedMarginFeeDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIsolatedMarginFeeDataUserData(long timestamp, string signature, int? vipLevel, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `vipLevel` — nullable, no default → **must pass explicitly**
  - `symbol` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `vipLevel` ← `vipLevel`, `symbol` ← `symbol`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginIsolatedMarginDataResponse>`
- **Error**: `SdkException<QueryIsolatedMarginFeeDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginIsolatedMarginDataResponse` | `Models/SapiV1MarginIsolatedMarginDataResponse.cs` |
| `QueryIsolatedMarginFeeDataUserDataError` | `Errors/QueryIsolatedMarginFeeDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryIsolatedMarginTierDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIsolatedMarginTierDataUserData(string symbol, long timestamp, string signature, string? tier, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `tier` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `tier` ← `tier`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginIsolatedMarginTierResponse>`
- **Error**: `SdkException<QueryIsolatedMarginTierDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginIsolatedMarginTierResponse` | `Models/SapiV1MarginIsolatedMarginTierResponse.cs` |
| `QueryIsolatedMarginTierDataUserDataError` | `Errors/QueryIsolatedMarginTierDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<SapiV1MarginLeverageBracketResponse>`
- **Error**: `SdkException<QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginLeverageBracketResponse` | `Models/SapiV1MarginLeverageBracketResponse.cs` |
| `QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError` | `Errors/QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMarginAccountSAllOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSAllOcoUserData(long timestamp, string signature, IsIsolated? isIsolated, string? symbol, string? fromId, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`isIsolated` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `symbol` ← `symbol`, `fromId` ← `fromId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginAllOrderListResponse>`
- **Error**: `SdkException<QueryMarginAccountSAllOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginAllOrderListResponse` | `Models/SapiV1MarginAllOrderListResponse.cs` |
| `QueryMarginAccountSAllOcoUserDataError` | `Errors/QueryMarginAccountSAllOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMarginAccountSAllOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSAllOrdersUserData(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? orderId, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`isIsolated` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `orderId` ← `orderId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<MarginOrderDetail>`
- **Error**: `SdkException<QueryMarginAccountSAllOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOrderDetail` | `Models/MarginOrderDetail.cs` |
| `QueryMarginAccountSAllOrdersUserDataError` | `Errors/QueryMarginAccountSAllOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMarginAccountSOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSOcoUserData(long timestamp, string signature, IsIsolated? isIsolated, string? symbol, long? orderListId, string? origClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`isIsolated` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `symbol` ← `symbol`, `orderListId` ← `orderListId`, `origClientOrderId` ← `origClientOrderId`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginOrderListResponse`
- **Error**: `SdkException<QueryMarginAccountSOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginOrderListResponse` | `Models/SapiV1MarginOrderListResponse.cs` |
| `QueryMarginAccountSOcoUserDataError` | `Errors/QueryMarginAccountSOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMarginAccountSOpenOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSOpenOcoUserData(long timestamp, string signature, IsIsolated? isIsolated, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `isIsolated` — nullable, no default → **must pass explicitly**
  - `symbol` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `symbol` ← `symbol`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1MarginOpenOrderListResponse>`
- **Error**: `SdkException<QueryMarginAccountSOpenOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `SapiV1MarginOpenOrderListResponse` | `Models/SapiV1MarginOpenOrderListResponse.cs` |
| `QueryMarginAccountSOpenOcoUserDataError` | `Errors/QueryMarginAccountSOpenOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMarginAccountSOpenOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSOpenOrdersUserData(long timestamp, string signature, string? symbol, IsIsolated? isIsolated, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `symbol` — nullable, no default → **must pass explicitly**
  - `isIsolated` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `symbol` ← `symbol`, `isIsolated` ← `isIsolated`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<MarginOrderDetail>`
- **Error**: `SdkException<QueryMarginAccountSOpenOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOrderDetail` | `Models/MarginOrderDetail.cs` |
| `QueryMarginAccountSOpenOrdersUserDataError` | `Errors/QueryMarginAccountSOpenOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMarginAccountSOrderUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSOrderUserData(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? orderId, string? origClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`isIsolated` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `orderId` ← `orderId`, `origClientOrderId` ← `origClientOrderId`, `recvWindow` ← `recvWindow`
- **Returns**: `MarginOrderDetail`
- **Error**: `SdkException<QueryMarginAccountSOrderUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginOrderDetail` | `Models/MarginOrderDetail.cs` |
| `QueryMarginAccountSOrderUserDataError` | `Errors/QueryMarginAccountSOrderUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMarginAccountSTradeListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAccountSTradeListUserData(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? startTime, long? endTime, long? fromId, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`isIsolated` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isIsolated` ← `isIsolated`, `startTime` ← `startTime`, `endTime` ← `endTime`, `fromId` ← `fromId`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<MarginTrade>`
- **Error**: `SdkException<QueryMarginAccountSTradeListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsIsolated` | `Models/Enums/IsIsolated.cs` |
| `MarginTrade` | `Models/MarginTrade.cs` |
| `QueryMarginAccountSTradeListUserDataError` | `Errors/QueryMarginAccountSTradeListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMarginAvailableInventoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginAvailableInventoryUserData(Type4 type, long timestamp, string signature, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`
- **Returns**: `SapiV1MarginAvailableInventoryResponse`
- **Error**: `SdkException<QueryMarginAvailableInventoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type4` | `Models/Enums/Type4.cs` |
| `SapiV1MarginAvailableInventoryResponse` | `Models/SapiV1MarginAvailableInventoryResponse.cs` |
| `QueryMarginAvailableInventoryUserDataError` | `Errors/QueryMarginAvailableInventoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMarginPriceIndexMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMarginPriceIndexMarketData(string symbol, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `symbol` ← `symbol`
- **Returns**: `SapiV1MarginPriceIndexResponse`
- **Error**: `SdkException<QueryMarginPriceIndexMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginPriceIndexResponse` | `Models/SapiV1MarginPriceIndexResponse.cs` |
| `QueryMarginPriceIndexMarketDataError` | `Errors/QueryMarginPriceIndexMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMaxBorrowUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMaxBorrowUserData(string asset, long timestamp, string signature, string? isolatedSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `isolatedSymbol` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `asset` ← `asset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isolatedSymbol` ← `isolatedSymbol`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginMaxBorrowableResponse`
- **Error**: `SdkException<QueryMaxBorrowUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginMaxBorrowableResponse` | `Models/SapiV1MarginMaxBorrowableResponse.cs` |
| `QueryMaxBorrowUserDataError` | `Errors/QueryMaxBorrowUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryMaxTransferOutAmountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryMaxTransferOutAmountUserData(string asset, long timestamp, string signature, string? isolatedSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `isolatedSymbol` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `asset` ← `asset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `isolatedSymbol` ← `isolatedSymbol`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1MarginMaxTransferableResponse`
- **Error**: `SdkException<QueryMaxTransferOutAmountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1MarginMaxTransferableResponse` | `Models/SapiV1MarginMaxTransferableResponse.cs` |
| `QueryMaxTransferOutAmountUserDataError` | `Errors/QueryMaxTransferOutAmountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### ToggleBnbBurnOnSpotTradeAndMarginInterestUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ToggleBnbBurnOnSpotTradeAndMarginInterestUserData(long timestamp, string signature, SpotBnbBurn? spotBnbBurn, InterestBnbBurn? interestBnbBurn, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `spotBnbBurn` — nullable, no default → **must pass explicitly**
  - `interestBnbBurn` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `spotBNBBurn` ← `spotBnbBurn`, `interestBNBBurn` ← `interestBnbBurn`, `recvWindow` ← `recvWindow`
- **Returns**: `BnbBurnStatus`
- **Error**: `SdkException<ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SpotBnbBurn` | `Models/Enums/SpotBnbBurn.cs` |
| `InterestBnbBurn` | `Models/Enums/InterestBnbBurn.cs` |
| `BnbBurnStatus` | `Models/BnbBurnStatus.cs` |
| `ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError` | `Errors/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError.cs` |
| `Error` | `Models/Error.cs` |

