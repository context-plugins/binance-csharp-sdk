<!-- Generated file — do not edit; regenerated with the SDK. -->

# TradeApi — operations

Accessor: `client.TradeApi` · Source: `src/Binance/Api/TradeApi.cs` · 23 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountInformationUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AccountInformationUserData(AccountInformationUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `Account`
- **Error**: `ApiException<AccountInformationUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountInformationUserDataRequest` | `src/Binance/Requests/TradeApi/AccountInformationUserDataRequest.cs` |
| `Account` | `src/Binance/Models/Account.cs` |
| `AccountInformationUserDataError` | `src/Binance/Errors/AccountInformationUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### AccountTradeListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AccountTradeListUserData(AccountTradeListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `fromId` ← `FromId`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<MyTrade>`
- **Error**: `ApiException<AccountTradeListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountTradeListUserDataRequest` | `src/Binance/Requests/TradeApi/AccountTradeListUserDataRequest.cs` |
| `MyTrade` | `src/Binance/Models/MyTrade.cs` |
| `AccountTradeListUserDataError` | `src/Binance/Errors/AccountTradeListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### AllOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AllOrdersUserData(AllOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<OrderDetails>`
- **Error**: `ApiException<AllOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AllOrdersUserDataRequest` | `src/Binance/Requests/TradeApi/AllOrdersUserDataRequest.cs` |
| `OrderDetails` | `src/Binance/Models/OrderDetails.cs` |
| `AllOrdersUserDataError` | `src/Binance/Errors/AllOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### CancelAllOpenOrdersOnASymbolTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelAllOpenOrdersOnASymbolTrade(CancelAllOpenOrdersOnASymbolTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<ApiV3OpenOrdersResponse>`
- **Error**: `ApiException<CancelAllOpenOrdersOnASymbolTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelAllOpenOrdersOnASymbolTradeRequest` | `src/Binance/Requests/TradeApi/CancelAllOpenOrdersOnASymbolTradeRequest.cs` |
| `ApiV3OpenOrdersResponse` | `src/Binance/Models/AnyOf/ApiV3OpenOrdersResponse.cs` |
| `CancelAllOpenOrdersOnASymbolTradeError` | `src/Binance/Errors/CancelAllOpenOrdersOnASymbolTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### CancelAnExistingOrderAndSendANewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelAnExistingOrderAndSendANewOrderTrade(CancelAnExistingOrderAndSendANewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Type`, `CancelReplaceMode`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `type` ← `Type`, `cancelReplaceMode` ← `CancelReplaceMode`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `cancelRestrictions` ← `CancelRestrictions`, `timeInForce` ← `TimeInForce`, `quantity` ← `Quantity`, `quoteOrderQty` ← `QuoteOrderQty`, `price` ← `Price`, `cancelNewClientOrderId` ← `CancelNewClientOrderId`, `cancelOrigClientOrderId` ← `CancelOrigClientOrderId`, `cancelOrderId` ← `CancelOrderId`, `newClientOrderId` ← `NewClientOrderId`, `strategyId` ← `StrategyId`, `strategyType` ← `StrategyType`, `stopPrice` ← `StopPrice`, `trailingDelta` ← `TrailingDelta`, `icebergQty` ← `IcebergQty`, `newOrderRespType` ← `NewOrderRespType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `recvWindow` ← `RecvWindow`
- **Returns**: `ApiV3OrderCancelReplaceResponse`
- **Error**: `ApiException<CancelAnExistingOrderAndSendANewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelAnExistingOrderAndSendANewOrderTradeRequest` | `src/Binance/Requests/TradeApi/CancelAnExistingOrderAndSendANewOrderTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `Type1` | `src/Binance/Models/Enums/Type1.cs` |
| `CancelRestrictions` | `src/Binance/Models/Enums/CancelRestrictions.cs` |
| `TimeInForce` | `src/Binance/Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `ApiV3OrderCancelReplaceResponse` | `src/Binance/Models/ApiV3OrderCancelReplaceResponse.cs` |
| `CancelAnExistingOrderAndSendANewOrderTradeError` | `src/Binance/Errors/CancelAnExistingOrderAndSendANewOrderTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### CancelOcoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelOcoTrade(CancelOcoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderListId` ← `OrderListId`, `listClientOrderId` ← `ListClientOrderId`, `newClientOrderId` ← `NewClientOrderId`, `recvWindow` ← `RecvWindow`
- **Returns**: `OcoOrder`
- **Error**: `ApiException<CancelOcoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelOcoTradeRequest` | `src/Binance/Requests/TradeApi/CancelOcoTradeRequest.cs` |
| `OcoOrder` | `src/Binance/Models/OcoOrder.cs` |
| `CancelOcoTradeError` | `src/Binance/Errors/CancelOcoTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### CancelOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelOrderTrade(CancelOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `origClientOrderId` ← `OrigClientOrderId`, `newClientOrderId` ← `NewClientOrderId`, `cancelRestrictions` ← `CancelRestrictions`, `recvWindow` ← `RecvWindow`
- **Returns**: `Order`
- **Error**: `ApiException<CancelOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelOrderTradeRequest` | `src/Binance/Requests/TradeApi/CancelOrderTradeRequest.cs` |
| `CancelRestrictions` | `src/Binance/Models/Enums/CancelRestrictions.cs` |
| `Order` | `src/Binance/Models/Order.cs` |
| `CancelOrderTradeError` | `src/Binance/Errors/CancelOrderTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### CurrentOpenOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CurrentOpenOrdersUserData(CurrentOpenOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `symbol` ← `Symbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<OrderDetails>`
- **Error**: `ApiException<CurrentOpenOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CurrentOpenOrdersUserDataRequest` | `src/Binance/Requests/TradeApi/CurrentOpenOrdersUserDataRequest.cs` |
| `OrderDetails` | `src/Binance/Models/OrderDetails.cs` |
| `CurrentOpenOrdersUserDataError` | `src/Binance/Errors/CurrentOpenOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### NewOrderListOcoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NewOrderListOcoTrade(NewOrderListOcoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Quantity`, `AboveType`, `BelowType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `quantity` ← `Quantity`, `aboveType` ← `AboveType`, `belowType` ← `BelowType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `listClientOrderId` ← `ListClientOrderId`, `aboveClientOrderId` ← `AboveClientOrderId`, `aboveIcebergQty` ← `AboveIcebergQty`, `abovePrice` ← `AbovePrice`, `aboveStopPrice` ← `AboveStopPrice`, `aboveTrailingDelta` ← `AboveTrailingDelta`, `aboveTimeInForce` ← `AboveTimeInForce`, `aboveStrategyId` ← `AboveStrategyId`, `aboveStrategyType` ← `AboveStrategyType`, `belowClientOrderId` ← `BelowClientOrderId`, `belowIcebergQty` ← `BelowIcebergQty`, `belowPrice` ← `BelowPrice`, `belowStopPrice` ← `BelowStopPrice`, `belowTrailingDelta` ← `BelowTrailingDelta`, `belowTimeInForce` ← `BelowTimeInForce`, `belowStrategyId` ← `BelowStrategyId`, `belowStrategyType` ← `BelowStrategyType`, `newOrderRespType` ← `NewOrderRespType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `recvWindow` ← `RecvWindow`
- **Returns**: `ApiV3OrderListOcoResponse`
- **Error**: `ApiException<NewOrderListOcoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NewOrderListOcoTradeRequest` | `src/Binance/Requests/TradeApi/NewOrderListOcoTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `AboveTimeInForce` | `src/Binance/Models/Enums/AboveTimeInForce.cs` |
| `BelowTimeInForce` | `src/Binance/Models/Enums/BelowTimeInForce.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `ApiV3OrderListOcoResponse` | `src/Binance/Models/ApiV3OrderListOcoResponse.cs` |
| `NewOrderListOcoTradeError` | `src/Binance/Errors/NewOrderListOcoTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### NewOrderListOtoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NewOrderListOtoTrade(NewOrderListOtoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `WorkingType`, `WorkingSide`, `WorkingPrice`, `WorkingQuantity`, `WorkingIcebergQty`, `PendingType`, `PendingSide`, `PendingQuantity`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `workingType` ← `WorkingType`, `workingSide` ← `WorkingSide`, `workingPrice` ← `WorkingPrice`, `workingQuantity` ← `WorkingQuantity`, `workingIcebergQty` ← `WorkingIcebergQty`, `pendingType` ← `PendingType`, `pendingSide` ← `PendingSide`, `pendingQuantity` ← `PendingQuantity`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `listClientOrderId` ← `ListClientOrderId`, `newOrderRespType` ← `NewOrderRespType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `workingClientOrderId` ← `WorkingClientOrderId`, `workingTimeInForce` ← `WorkingTimeInForce`, `workingStrategyId` ← `WorkingStrategyId`, `workingStrategyType` ← `WorkingStrategyType`, `pendingClientOrderId` ← `PendingClientOrderId`, `pendingPrice` ← `PendingPrice`, `pendingStopPrice` ← `PendingStopPrice`, `pendingTrailingDelta` ← `PendingTrailingDelta`, `pendingIcebergQty` ← `PendingIcebergQty`, `pendingTimeInForce` ← `PendingTimeInForce`, `pendingStrategyId` ← `PendingStrategyId`, `pendingStrategyType` ← `PendingStrategyType`
- **Returns**: `ApiV3OrderListOtoResponse`
- **Error**: `ApiException<NewOrderListOtoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NewOrderListOtoTradeRequest` | `src/Binance/Requests/TradeApi/NewOrderListOtoTradeRequest.cs` |
| `WorkingType` | `src/Binance/Models/Enums/WorkingType.cs` |
| `WorkingSide` | `src/Binance/Models/Enums/WorkingSide.cs` |
| `PendingType` | `src/Binance/Models/Enums/PendingType.cs` |
| `PendingSide` | `src/Binance/Models/Enums/PendingSide.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `WorkingTimeInForce` | `src/Binance/Models/Enums/WorkingTimeInForce.cs` |
| `PendingTimeInForce` | `src/Binance/Models/Enums/PendingTimeInForce.cs` |
| `ApiV3OrderListOtoResponse` | `src/Binance/Models/ApiV3OrderListOtoResponse.cs` |
| `NewOrderListOtoTradeError` | `src/Binance/Errors/NewOrderListOtoTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### NewOrderListOtocoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NewOrderListOtocoTrade(NewOrderListOtocoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `WorkingType`, `WorkingSide`, `WorkingPrice`, `WorkingQuantity`, `WorkingIcebergQty`, `PendingSide`, `PendingQuantity`, `PendingAboveType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `workingType` ← `WorkingType`, `workingSide` ← `WorkingSide`, `workingPrice` ← `WorkingPrice`, `workingQuantity` ← `WorkingQuantity`, `workingIcebergQty` ← `WorkingIcebergQty`, `pendingSide` ← `PendingSide`, `pendingQuantity` ← `PendingQuantity`, `pendingAboveType` ← `PendingAboveType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `listClientOrderId` ← `ListClientOrderId`, `newOrderRespType` ← `NewOrderRespType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `workingClientOrderId` ← `WorkingClientOrderId`, `workingTimeInForce` ← `WorkingTimeInForce`, `workingStrategyId` ← `WorkingStrategyId`, `workingStrategyType` ← `WorkingStrategyType`, `pendingAboveClientOrderId` ← `PendingAboveClientOrderId`, `pendingAbovePrice` ← `PendingAbovePrice`, `pendingAboveStopPrice` ← `PendingAboveStopPrice`, `pendingAboveTrailingDelta` ← `PendingAboveTrailingDelta`, `pendingAboveIcebergQty` ← `PendingAboveIcebergQty`, `pendingAboveTimeInForce` ← `PendingAboveTimeInForce`, `pendingAboveStrategyId` ← `PendingAboveStrategyId`, `pendingAboveStrategyType` ← `PendingAboveStrategyType`, `pendingBelowType` ← `PendingBelowType`, `pendingBelowClientOrderId` ← `PendingBelowClientOrderId`, `pendingBelowPrice` ← `PendingBelowPrice`, `pendingBelowStopPrice` ← `PendingBelowStopPrice`, `pendingBelowTrailingDelta` ← `PendingBelowTrailingDelta`, `pendingBelowIcebergQty` ← `PendingBelowIcebergQty`, `pendingBelowTimeInForce` ← `PendingBelowTimeInForce`, `pendingBelowStrategyId` ← `PendingBelowStrategyId`, `pendingBelowStrategyType` ← `PendingBelowStrategyType`, `recvWindow` ← `RecvWindow`
- **Returns**: `ApiV3OrderListOtocoResponse`
- **Error**: `ApiException<NewOrderListOtocoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NewOrderListOtocoTradeRequest` | `src/Binance/Requests/TradeApi/NewOrderListOtocoTradeRequest.cs` |
| `WorkingType` | `src/Binance/Models/Enums/WorkingType.cs` |
| `WorkingSide` | `src/Binance/Models/Enums/WorkingSide.cs` |
| `PendingSide` | `src/Binance/Models/Enums/PendingSide.cs` |
| `PendingAboveType` | `src/Binance/Models/Enums/PendingAboveType.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `WorkingTimeInForce` | `src/Binance/Models/Enums/WorkingTimeInForce.cs` |
| `PendingAboveTimeInForce` | `src/Binance/Models/Enums/PendingAboveTimeInForce.cs` |
| `PendingBelowType` | `src/Binance/Models/Enums/PendingBelowType.cs` |
| `PendingBelowTimeInForce` | `src/Binance/Models/Enums/PendingBelowTimeInForce.cs` |
| `ApiV3OrderListOtocoResponse` | `src/Binance/Models/ApiV3OrderListOtocoResponse.cs` |
| `NewOrderListOtocoTradeError` | `src/Binance/Errors/NewOrderListOtocoTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### NewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NewOrderTrade(NewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `timeInForce` ← `TimeInForce`, `quantity` ← `Quantity`, `quoteOrderQty` ← `QuoteOrderQty`, `price` ← `Price`, `newClientOrderId` ← `NewClientOrderId`, `strategyId` ← `StrategyId`, `strategyType` ← `StrategyType`, `stopPrice` ← `StopPrice`, `trailingDelta` ← `TrailingDelta`, `icebergQty` ← `IcebergQty`, `newOrderRespType` ← `NewOrderRespType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `recvWindow` ← `RecvWindow`
- **Returns**: `ApiV3OrderResponse`
- **Error**: `ApiException<NewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NewOrderTradeRequest` | `src/Binance/Requests/TradeApi/NewOrderTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `Type1` | `src/Binance/Models/Enums/Type1.cs` |
| `TimeInForce` | `src/Binance/Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `ApiV3OrderResponse` | `src/Binance/Models/AnyOf/ApiV3OrderResponse.cs` |
| `NewOrderTradeError` | `src/Binance/Errors/NewOrderTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### NewOrderUsingSorTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NewOrderUsingSorTrade(NewOrderUsingSorTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Type`, `Quantity`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `type` ← `Type`, `quantity` ← `Quantity`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `timeInForce` ← `TimeInForce`, `price` ← `Price`, `newClientOrderId` ← `NewClientOrderId`, `strategyId` ← `StrategyId`, `strategyType` ← `StrategyType`, `icebergQty` ← `IcebergQty`, `newOrderRespType` ← `NewOrderRespType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `recvWindow` ← `RecvWindow`
- **Returns**: `ApiV3SorOrderResponse`
- **Error**: `ApiException<NewOrderUsingSorTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NewOrderUsingSorTradeRequest` | `src/Binance/Requests/TradeApi/NewOrderUsingSorTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `Type1` | `src/Binance/Models/Enums/Type1.cs` |
| `TimeInForce` | `src/Binance/Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `ApiV3SorOrderResponse` | `src/Binance/Models/ApiV3SorOrderResponse.cs` |
| `NewOrderUsingSorTradeError` | `src/Binance/Errors/NewOrderUsingSorTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryAllOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryAllOcoUserData(QueryAllOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `fromId` ← `FromId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<ApiV3AllOrderListResponse>`
- **Error**: `ApiException<QueryAllOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryAllOcoUserDataRequest` | `src/Binance/Requests/TradeApi/QueryAllOcoUserDataRequest.cs` |
| `ApiV3AllOrderListResponse` | `src/Binance/Models/ApiV3AllOrderListResponse.cs` |
| `QueryAllOcoUserDataError` | `src/Binance/Errors/QueryAllOcoUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryAllocationsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryAllocationsUserData(QueryAllocationsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `fromAllocationId` ← `FromAllocationId`, `limit` ← `Limit`, `orderId` ← `OrderId`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<ApiV3MyAllocationsResponse>`
- **Error**: `ApiException<QueryAllocationsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryAllocationsUserDataRequest` | `src/Binance/Requests/TradeApi/QueryAllocationsUserDataRequest.cs` |
| `ApiV3MyAllocationsResponse` | `src/Binance/Models/ApiV3MyAllocationsResponse.cs` |
| `QueryAllocationsUserDataError` | `src/Binance/Errors/QueryAllocationsUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryCommissionRatesUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCommissionRatesUserData(QueryCommissionRatesUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`
- **Returns**: `ApiV3AccountCommissionResponse`
- **Error**: `ApiException<QueryCommissionRatesUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryCommissionRatesUserDataRequest` | `src/Binance/Requests/TradeApi/QueryCommissionRatesUserDataRequest.cs` |
| `ApiV3AccountCommissionResponse` | `src/Binance/Models/ApiV3AccountCommissionResponse.cs` |
| `QueryCommissionRatesUserDataError` | `src/Binance/Errors/QueryCommissionRatesUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryCurrentOrderCountUsageTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCurrentOrderCountUsageTrade(QueryCurrentOrderCountUsageTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<ApiV3RateLimitOrderResponse>`
- **Error**: `ApiException<QueryCurrentOrderCountUsageTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryCurrentOrderCountUsageTradeRequest` | `src/Binance/Requests/TradeApi/QueryCurrentOrderCountUsageTradeRequest.cs` |
| `ApiV3RateLimitOrderResponse` | `src/Binance/Models/ApiV3RateLimitOrderResponse.cs` |
| `QueryCurrentOrderCountUsageTradeError` | `src/Binance/Errors/QueryCurrentOrderCountUsageTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOcoUserData(QueryOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderListId` ← `OrderListId`, `origClientOrderId` ← `OrigClientOrderId`, `recvWindow` ← `RecvWindow`
- **Returns**: `ApiV3OrderListResponse`
- **Error**: `ApiException<QueryOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryOcoUserDataRequest` | `src/Binance/Requests/TradeApi/QueryOcoUserDataRequest.cs` |
| `ApiV3OrderListResponse` | `src/Binance/Models/ApiV3OrderListResponse.cs` |
| `QueryOcoUserDataError` | `src/Binance/Errors/QueryOcoUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryOpenOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOpenOcoUserData(QueryOpenOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<ApiV3OpenOrderListResponse>`
- **Error**: `ApiException<QueryOpenOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryOpenOcoUserDataRequest` | `src/Binance/Requests/TradeApi/QueryOpenOcoUserDataRequest.cs` |
| `ApiV3OpenOrderListResponse` | `src/Binance/Models/ApiV3OpenOrderListResponse.cs` |
| `QueryOpenOcoUserDataError` | `src/Binance/Errors/QueryOpenOcoUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryOrderUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOrderUserData(QueryOrderUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `origClientOrderId` ← `OrigClientOrderId`, `recvWindow` ← `RecvWindow`
- **Returns**: `OrderDetails`
- **Error**: `ApiException<QueryOrderUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryOrderUserDataRequest` | `src/Binance/Requests/TradeApi/QueryOrderUserDataRequest.cs` |
| `OrderDetails` | `src/Binance/Models/OrderDetails.cs` |
| `QueryOrderUserDataError` | `src/Binance/Errors/QueryOrderUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryPreventedMatches

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryPreventedMatches(QueryPreventedMatchesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `preventedMatchId` ← `PreventedMatchId`, `orderId` ← `OrderId`, `fromPreventedMatchId` ← `FromPreventedMatchId`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<ApiV3MyPreventedMatchesResponse>`
- **Error**: `ApiException<QueryPreventedMatchesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryPreventedMatchesRequest` | `src/Binance/Requests/TradeApi/QueryPreventedMatchesRequest.cs` |
| `ApiV3MyPreventedMatchesResponse` | `src/Binance/Models/ApiV3MyPreventedMatchesResponse.cs` |
| `QueryPreventedMatchesError` | `src/Binance/Errors/QueryPreventedMatchesError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### TestNewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TestNewOrderTrade(TestNewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `timeInForce` ← `TimeInForce`, `quantity` ← `Quantity`, `quoteOrderQty` ← `QuoteOrderQty`, `price` ← `Price`, `newClientOrderId` ← `NewClientOrderId`, `strategyId` ← `StrategyId`, `strategyType` ← `StrategyType`, `stopPrice` ← `StopPrice`, `trailingDelta` ← `TrailingDelta`, `icebergQty` ← `IcebergQty`, `newOrderRespType` ← `NewOrderRespType`, `recvWindow` ← `RecvWindow`, `computeCommissionRates` ← `ComputeCommissionRates`
- **Returns**: `object`
- **Error**: `ApiException<TestNewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TestNewOrderTradeRequest` | `src/Binance/Requests/TradeApi/TestNewOrderTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `Type1` | `src/Binance/Models/Enums/Type1.cs` |
| `TimeInForce` | `src/Binance/Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `TestNewOrderTradeError` | `src/Binance/Errors/TestNewOrderTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### TestNewOrderUsingSorTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TestNewOrderUsingSorTrade(TestNewOrderUsingSorTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Type`, `Quantity`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `type` ← `Type`, `quantity` ← `Quantity`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `timeInForce` ← `TimeInForce`, `price` ← `Price`, `newClientOrderId` ← `NewClientOrderId`, `strategyId` ← `StrategyId`, `strategyType` ← `StrategyType`, `icebergQty` ← `IcebergQty`, `newOrderRespType` ← `NewOrderRespType`, `selfTradePreventionMode` ← `SelfTradePreventionMode`, `computeCommissionRates` ← `ComputeCommissionRates`, `recvWindow` ← `RecvWindow`
- **Returns**: `object`
- **Error**: `ApiException<TestNewOrderUsingSorTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TestNewOrderUsingSorTradeRequest` | `src/Binance/Requests/TradeApi/TestNewOrderUsingSorTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `Type1` | `src/Binance/Models/Enums/Type1.cs` |
| `TimeInForce` | `src/Binance/Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `src/Binance/Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `src/Binance/Models/Enums/SelfTradePreventionMode.cs` |
| `TestNewOrderUsingSorTradeError` | `src/Binance/Errors/TestNewOrderUsingSorTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

