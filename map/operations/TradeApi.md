<!-- Generated file — do not edit; regenerated with the SDK. -->

# TradeApi — operations

Accessor: `client.TradeApi` · Source: `Api/TradeApi.cs` · 23 operations

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
| `AccountInformationUserDataRequest` | `Requests/TradeApi/AccountInformationUserDataRequest.cs` |
| `Account` | `Models/Account.cs` |
| `AccountInformationUserDataError` | `Errors/AccountInformationUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `AccountTradeListUserDataRequest` | `Requests/TradeApi/AccountTradeListUserDataRequest.cs` |
| `MyTrade` | `Models/MyTrade.cs` |
| `AccountTradeListUserDataError` | `Errors/AccountTradeListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `AllOrdersUserDataRequest` | `Requests/TradeApi/AllOrdersUserDataRequest.cs` |
| `OrderDetails` | `Models/OrderDetails.cs` |
| `AllOrdersUserDataError` | `Errors/AllOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `CancelAllOpenOrdersOnASymbolTradeRequest` | `Requests/TradeApi/CancelAllOpenOrdersOnASymbolTradeRequest.cs` |
| `ApiV3OpenOrdersResponse` | `Models/AnyOf/ApiV3OpenOrdersResponse.cs` |
| `CancelAllOpenOrdersOnASymbolTradeError` | `Errors/CancelAllOpenOrdersOnASymbolTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `CancelAnExistingOrderAndSendANewOrderTradeRequest` | `Requests/TradeApi/CancelAnExistingOrderAndSendANewOrderTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `Type1` | `Models/Enums/Type1.cs` |
| `CancelRestrictions` | `Models/Enums/CancelRestrictions.cs` |
| `TimeInForce` | `Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `ApiV3OrderCancelReplaceResponse` | `Models/ApiV3OrderCancelReplaceResponse.cs` |
| `CancelAnExistingOrderAndSendANewOrderTradeError` | `Errors/CancelAnExistingOrderAndSendANewOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `CancelOcoTradeRequest` | `Requests/TradeApi/CancelOcoTradeRequest.cs` |
| `OcoOrder` | `Models/OcoOrder.cs` |
| `CancelOcoTradeError` | `Errors/CancelOcoTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `CancelOrderTradeRequest` | `Requests/TradeApi/CancelOrderTradeRequest.cs` |
| `CancelRestrictions` | `Models/Enums/CancelRestrictions.cs` |
| `Order` | `Models/Order.cs` |
| `CancelOrderTradeError` | `Errors/CancelOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `CurrentOpenOrdersUserDataRequest` | `Requests/TradeApi/CurrentOpenOrdersUserDataRequest.cs` |
| `OrderDetails` | `Models/OrderDetails.cs` |
| `CurrentOpenOrdersUserDataError` | `Errors/CurrentOpenOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `NewOrderListOcoTradeRequest` | `Requests/TradeApi/NewOrderListOcoTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `AboveTimeInForce` | `Models/Enums/AboveTimeInForce.cs` |
| `BelowTimeInForce` | `Models/Enums/BelowTimeInForce.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `ApiV3OrderListOcoResponse` | `Models/ApiV3OrderListOcoResponse.cs` |
| `NewOrderListOcoTradeError` | `Errors/NewOrderListOcoTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `NewOrderListOtoTradeRequest` | `Requests/TradeApi/NewOrderListOtoTradeRequest.cs` |
| `WorkingType` | `Models/Enums/WorkingType.cs` |
| `WorkingSide` | `Models/Enums/WorkingSide.cs` |
| `PendingType` | `Models/Enums/PendingType.cs` |
| `PendingSide` | `Models/Enums/PendingSide.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `WorkingTimeInForce` | `Models/Enums/WorkingTimeInForce.cs` |
| `PendingTimeInForce` | `Models/Enums/PendingTimeInForce.cs` |
| `ApiV3OrderListOtoResponse` | `Models/ApiV3OrderListOtoResponse.cs` |
| `NewOrderListOtoTradeError` | `Errors/NewOrderListOtoTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `NewOrderListOtocoTradeRequest` | `Requests/TradeApi/NewOrderListOtocoTradeRequest.cs` |
| `WorkingType` | `Models/Enums/WorkingType.cs` |
| `WorkingSide` | `Models/Enums/WorkingSide.cs` |
| `PendingSide` | `Models/Enums/PendingSide.cs` |
| `PendingAboveType` | `Models/Enums/PendingAboveType.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `WorkingTimeInForce` | `Models/Enums/WorkingTimeInForce.cs` |
| `PendingAboveTimeInForce` | `Models/Enums/PendingAboveTimeInForce.cs` |
| `PendingBelowType` | `Models/Enums/PendingBelowType.cs` |
| `PendingBelowTimeInForce` | `Models/Enums/PendingBelowTimeInForce.cs` |
| `ApiV3OrderListOtocoResponse` | `Models/ApiV3OrderListOtocoResponse.cs` |
| `NewOrderListOtocoTradeError` | `Errors/NewOrderListOtocoTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `NewOrderTradeRequest` | `Requests/TradeApi/NewOrderTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `Type1` | `Models/Enums/Type1.cs` |
| `TimeInForce` | `Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `ApiV3OrderResponse` | `Models/AnyOf/ApiV3OrderResponse.cs` |
| `NewOrderTradeError` | `Errors/NewOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `NewOrderUsingSorTradeRequest` | `Requests/TradeApi/NewOrderUsingSorTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `Type1` | `Models/Enums/Type1.cs` |
| `TimeInForce` | `Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `ApiV3SorOrderResponse` | `Models/ApiV3SorOrderResponse.cs` |
| `NewOrderUsingSorTradeError` | `Errors/NewOrderUsingSorTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryAllOcoUserDataRequest` | `Requests/TradeApi/QueryAllOcoUserDataRequest.cs` |
| `ApiV3AllOrderListResponse` | `Models/ApiV3AllOrderListResponse.cs` |
| `QueryAllOcoUserDataError` | `Errors/QueryAllOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryAllocationsUserDataRequest` | `Requests/TradeApi/QueryAllocationsUserDataRequest.cs` |
| `ApiV3MyAllocationsResponse` | `Models/ApiV3MyAllocationsResponse.cs` |
| `QueryAllocationsUserDataError` | `Errors/QueryAllocationsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryCommissionRatesUserDataRequest` | `Requests/TradeApi/QueryCommissionRatesUserDataRequest.cs` |
| `ApiV3AccountCommissionResponse` | `Models/ApiV3AccountCommissionResponse.cs` |
| `QueryCommissionRatesUserDataError` | `Errors/QueryCommissionRatesUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryCurrentOrderCountUsageTradeRequest` | `Requests/TradeApi/QueryCurrentOrderCountUsageTradeRequest.cs` |
| `ApiV3RateLimitOrderResponse` | `Models/ApiV3RateLimitOrderResponse.cs` |
| `QueryCurrentOrderCountUsageTradeError` | `Errors/QueryCurrentOrderCountUsageTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryOcoUserDataRequest` | `Requests/TradeApi/QueryOcoUserDataRequest.cs` |
| `ApiV3OrderListResponse` | `Models/ApiV3OrderListResponse.cs` |
| `QueryOcoUserDataError` | `Errors/QueryOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryOpenOcoUserDataRequest` | `Requests/TradeApi/QueryOpenOcoUserDataRequest.cs` |
| `ApiV3OpenOrderListResponse` | `Models/ApiV3OpenOrderListResponse.cs` |
| `QueryOpenOcoUserDataError` | `Errors/QueryOpenOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryOrderUserDataRequest` | `Requests/TradeApi/QueryOrderUserDataRequest.cs` |
| `OrderDetails` | `Models/OrderDetails.cs` |
| `QueryOrderUserDataError` | `Errors/QueryOrderUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryPreventedMatchesRequest` | `Requests/TradeApi/QueryPreventedMatchesRequest.cs` |
| `ApiV3MyPreventedMatchesResponse` | `Models/ApiV3MyPreventedMatchesResponse.cs` |
| `QueryPreventedMatchesError` | `Errors/QueryPreventedMatchesError.cs` |
| `Error` | `Models/Error.cs` |

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
| `TestNewOrderTradeRequest` | `Requests/TradeApi/TestNewOrderTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `Type1` | `Models/Enums/Type1.cs` |
| `TimeInForce` | `Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `TestNewOrderTradeError` | `Errors/TestNewOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `TestNewOrderUsingSorTradeRequest` | `Requests/TradeApi/TestNewOrderUsingSorTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `Type1` | `Models/Enums/Type1.cs` |
| `TimeInForce` | `Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `TestNewOrderUsingSorTradeError` | `Errors/TestNewOrderUsingSorTradeError.cs` |
| `Error` | `Models/Error.cs` |

