<!-- Generated file — do not edit; regenerated with the SDK. -->

# TradeApi — operations

Accessor: `client.TradeApi` · Source: `Api/TradeApi.cs` · 23 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountInformationUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AccountInformationUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `Account`
- **Error**: `SdkException<AccountInformationUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Account` | `Models/Account.cs` |
| `AccountInformationUserDataError` | `Errors/AccountInformationUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AccountTradeListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AccountTradeListUserData(string symbol, long timestamp, string signature, long? orderId, long? startTime, long? endTime, long? fromId, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`orderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `fromId` ← `fromId`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<MyTrade>`
- **Error**: `SdkException<AccountTradeListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MyTrade` | `Models/MyTrade.cs` |
| `AccountTradeListUserDataError` | `Errors/AccountTradeListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AllOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AllOrdersUserData(string symbol, long timestamp, string signature, long? orderId, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`orderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<OrderDetails>`
- **Error**: `SdkException<AllOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrderDetails` | `Models/OrderDetails.cs` |
| `AllOrdersUserDataError` | `Errors/AllOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### CancelAllOpenOrdersOnASymbolTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelAllOpenOrdersOnASymbolTrade(string symbol, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<ApiV3OpenOrdersResponse>`
- **Error**: `SdkException<CancelAllOpenOrdersOnASymbolTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3OpenOrdersResponse` | `Models/AnyOf/ApiV3OpenOrdersResponse.cs` |
| `CancelAllOpenOrdersOnASymbolTradeError` | `Errors/CancelAllOpenOrdersOnASymbolTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CancelAnExistingOrderAndSendANewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelAnExistingOrderAndSendANewOrderTrade(string symbol, Side side, Type1 type, string cancelReplaceMode, long timestamp, string signature, CancelRestrictions? cancelRestrictions, TimeInForce? timeInForce, double? quantity, double? quoteOrderQty, double? price, string? cancelNewClientOrderId, string? cancelOrigClientOrderId, long? cancelOrderId, string? newClientOrderId, long? strategyId, long? strategyType, double? stopPrice, double? trailingDelta, double? icebergQty, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 17 params (`cancelRestrictions` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `type` ← `type`, `cancelReplaceMode` ← `cancelReplaceMode`, `timestamp` ← `timestamp`, `signature` ← `signature`, `cancelRestrictions` ← `cancelRestrictions`, `timeInForce` ← `timeInForce`, `quantity` ← `quantity`, `quoteOrderQty` ← `quoteOrderQty`, `price` ← `price`, `cancelNewClientOrderId` ← `cancelNewClientOrderId`, `cancelOrigClientOrderId` ← `cancelOrigClientOrderId`, `cancelOrderId` ← `cancelOrderId`, `newClientOrderId` ← `newClientOrderId`, `strategyId` ← `strategyId`, `strategyType` ← `strategyType`, `stopPrice` ← `stopPrice`, `trailingDelta` ← `trailingDelta`, `icebergQty` ← `icebergQty`, `newOrderRespType` ← `newOrderRespType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `recvWindow` ← `recvWindow`
- **Returns**: `ApiV3OrderCancelReplaceResponse`
- **Error**: `SdkException<CancelAnExistingOrderAndSendANewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `CancelOcoTrade(string symbol, long timestamp, string signature, long? orderListId, string? listClientOrderId, string? newClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`orderListId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `orderListId` ← `orderListId`, `listClientOrderId` ← `listClientOrderId`, `newClientOrderId` ← `newClientOrderId`, `recvWindow` ← `recvWindow`
- **Returns**: `OcoOrder`
- **Error**: `SdkException<CancelOcoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OcoOrder` | `Models/OcoOrder.cs` |
| `CancelOcoTradeError` | `Errors/CancelOcoTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CancelOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelOrderTrade(string symbol, long timestamp, string signature, long? orderId, string? origClientOrderId, string? newClientOrderId, CancelRestrictions? cancelRestrictions, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`orderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `origClientOrderId` ← `origClientOrderId`, `newClientOrderId` ← `newClientOrderId`, `cancelRestrictions` ← `cancelRestrictions`, `recvWindow` ← `recvWindow`
- **Returns**: `Order`
- **Error**: `SdkException<CancelOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelRestrictions` | `Models/Enums/CancelRestrictions.cs` |
| `Order` | `Models/Order.cs` |
| `CancelOrderTradeError` | `Errors/CancelOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CurrentOpenOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CurrentOpenOrdersUserData(long timestamp, string signature, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `symbol` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `symbol` ← `symbol`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<OrderDetails>`
- **Error**: `SdkException<CurrentOpenOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrderDetails` | `Models/OrderDetails.cs` |
| `CurrentOpenOrdersUserDataError` | `Errors/CurrentOpenOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### NewOrderListOcoTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NewOrderListOcoTrade(string symbol, Side side, double quantity, string aboveType, string belowType, long timestamp, string signature, string? listClientOrderId, string? aboveClientOrderId, double? aboveIcebergQty, double? abovePrice, double? aboveStopPrice, double? aboveTrailingDelta, AboveTimeInForce? aboveTimeInForce, double? aboveStrategyId, long? aboveStrategyType, string? belowClientOrderId, double? belowIcebergQty, double? belowPrice, double? belowStopPrice, double? belowTrailingDelta, BelowTimeInForce? belowTimeInForce, double? belowStrategyId, long? belowStrategyType, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 20 params (`listClientOrderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `quantity` ← `quantity`, `aboveType` ← `aboveType`, `belowType` ← `belowType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `listClientOrderId` ← `listClientOrderId`, `aboveClientOrderId` ← `aboveClientOrderId`, `aboveIcebergQty` ← `aboveIcebergQty`, `abovePrice` ← `abovePrice`, `aboveStopPrice` ← `aboveStopPrice`, `aboveTrailingDelta` ← `aboveTrailingDelta`, `aboveTimeInForce` ← `aboveTimeInForce`, `aboveStrategyId` ← `aboveStrategyId`, `aboveStrategyType` ← `aboveStrategyType`, `belowClientOrderId` ← `belowClientOrderId`, `belowIcebergQty` ← `belowIcebergQty`, `belowPrice` ← `belowPrice`, `belowStopPrice` ← `belowStopPrice`, `belowTrailingDelta` ← `belowTrailingDelta`, `belowTimeInForce` ← `belowTimeInForce`, `belowStrategyId` ← `belowStrategyId`, `belowStrategyType` ← `belowStrategyType`, `newOrderRespType` ← `newOrderRespType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `recvWindow` ← `recvWindow`
- **Returns**: `ApiV3OrderListOcoResponse`
- **Error**: `SdkException<NewOrderListOcoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `NewOrderListOtoTrade(string symbol, WorkingType workingType, WorkingSide workingSide, double workingPrice, double workingQuantity, double workingIcebergQty, PendingType pendingType, PendingSide pendingSide, double pendingQuantity, long timestamp, string signature, string? listClientOrderId, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, string? workingClientOrderId, WorkingTimeInForce? workingTimeInForce, double? workingStrategyId, long? workingStrategyType, string? pendingClientOrderId, double? pendingPrice, double? pendingStopPrice, double? pendingTrailingDelta, double? pendingIcebergQty, PendingTimeInForce? pendingTimeInForce, double? pendingStrategyId, long? pendingStrategyType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 15 params (`listClientOrderId` … `pendingStrategyType`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `workingType` ← `workingType`, `workingSide` ← `workingSide`, `workingPrice` ← `workingPrice`, `workingQuantity` ← `workingQuantity`, `workingIcebergQty` ← `workingIcebergQty`, `pendingType` ← `pendingType`, `pendingSide` ← `pendingSide`, `pendingQuantity` ← `pendingQuantity`, `timestamp` ← `timestamp`, `signature` ← `signature`, `listClientOrderId` ← `listClientOrderId`, `newOrderRespType` ← `newOrderRespType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `workingClientOrderId` ← `workingClientOrderId`, `workingTimeInForce` ← `workingTimeInForce`, `workingStrategyId` ← `workingStrategyId`, `workingStrategyType` ← `workingStrategyType`, `pendingClientOrderId` ← `pendingClientOrderId`, `pendingPrice` ← `pendingPrice`, `pendingStopPrice` ← `pendingStopPrice`, `pendingTrailingDelta` ← `pendingTrailingDelta`, `pendingIcebergQty` ← `pendingIcebergQty`, `pendingTimeInForce` ← `pendingTimeInForce`, `pendingStrategyId` ← `pendingStrategyId`, `pendingStrategyType` ← `pendingStrategyType`
- **Returns**: `ApiV3OrderListOtoResponse`
- **Error**: `SdkException<NewOrderListOtoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `NewOrderListOtocoTrade(string symbol, WorkingType workingType, WorkingSide workingSide, double workingPrice, double workingQuantity, double workingIcebergQty, PendingSide pendingSide, double pendingQuantity, PendingAboveType pendingAboveType, long timestamp, string signature, string? listClientOrderId, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, string? workingClientOrderId, WorkingTimeInForce? workingTimeInForce, double? workingStrategyId, long? workingStrategyType, string? pendingAboveClientOrderId, double? pendingAbovePrice, double? pendingAboveStopPrice, double? pendingAboveTrailingDelta, double? pendingAboveIcebergQty, PendingAboveTimeInForce? pendingAboveTimeInForce, double? pendingAboveStrategyId, long? pendingAboveStrategyType, PendingBelowType? pendingBelowType, string? pendingBelowClientOrderId, double? pendingBelowPrice, double? pendingBelowStopPrice, double? pendingBelowTrailingDelta, double? pendingBelowIcebergQty, PendingBelowTimeInForce? pendingBelowTimeInForce, double? pendingBelowStrategyId, long? pendingBelowStrategyType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 25 params (`listClientOrderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `workingType` ← `workingType`, `workingSide` ← `workingSide`, `workingPrice` ← `workingPrice`, `workingQuantity` ← `workingQuantity`, `workingIcebergQty` ← `workingIcebergQty`, `pendingSide` ← `pendingSide`, `pendingQuantity` ← `pendingQuantity`, `pendingAboveType` ← `pendingAboveType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `listClientOrderId` ← `listClientOrderId`, `newOrderRespType` ← `newOrderRespType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `workingClientOrderId` ← `workingClientOrderId`, `workingTimeInForce` ← `workingTimeInForce`, `workingStrategyId` ← `workingStrategyId`, `workingStrategyType` ← `workingStrategyType`, `pendingAboveClientOrderId` ← `pendingAboveClientOrderId`, `pendingAbovePrice` ← `pendingAbovePrice`, `pendingAboveStopPrice` ← `pendingAboveStopPrice`, `pendingAboveTrailingDelta` ← `pendingAboveTrailingDelta`, `pendingAboveIcebergQty` ← `pendingAboveIcebergQty`, `pendingAboveTimeInForce` ← `pendingAboveTimeInForce`, `pendingAboveStrategyId` ← `pendingAboveStrategyId`, `pendingAboveStrategyType` ← `pendingAboveStrategyType`, `pendingBelowType` ← `pendingBelowType`, `pendingBelowClientOrderId` ← `pendingBelowClientOrderId`, `pendingBelowPrice` ← `pendingBelowPrice`, `pendingBelowStopPrice` ← `pendingBelowStopPrice`, `pendingBelowTrailingDelta` ← `pendingBelowTrailingDelta`, `pendingBelowIcebergQty` ← `pendingBelowIcebergQty`, `pendingBelowTimeInForce` ← `pendingBelowTimeInForce`, `pendingBelowStrategyId` ← `pendingBelowStrategyId`, `pendingBelowStrategyType` ← `pendingBelowStrategyType`, `recvWindow` ← `recvWindow`
- **Returns**: `ApiV3OrderListOtocoResponse`
- **Error**: `SdkException<NewOrderListOtocoTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `NewOrderTrade(string symbol, Side side, Type1 type, long timestamp, string signature, TimeInForce? timeInForce, double? quantity, double? quoteOrderQty, double? price, string? newClientOrderId, long? strategyId, long? strategyType, double? stopPrice, double? trailingDelta, double? icebergQty, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 13 params (`timeInForce` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `timeInForce` ← `timeInForce`, `quantity` ← `quantity`, `quoteOrderQty` ← `quoteOrderQty`, `price` ← `price`, `newClientOrderId` ← `newClientOrderId`, `strategyId` ← `strategyId`, `strategyType` ← `strategyType`, `stopPrice` ← `stopPrice`, `trailingDelta` ← `trailingDelta`, `icebergQty` ← `icebergQty`, `newOrderRespType` ← `newOrderRespType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `recvWindow` ← `recvWindow`
- **Returns**: `ApiV3OrderResponse`
- **Error**: `SdkException<NewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `NewOrderUsingSorTrade(string symbol, Side side, Type1 type, double quantity, long timestamp, string signature, TimeInForce? timeInForce, double? price, string? newClientOrderId, long? strategyId, long? strategyType, double? icebergQty, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`timeInForce` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `type` ← `type`, `quantity` ← `quantity`, `timestamp` ← `timestamp`, `signature` ← `signature`, `timeInForce` ← `timeInForce`, `price` ← `price`, `newClientOrderId` ← `newClientOrderId`, `strategyId` ← `strategyId`, `strategyType` ← `strategyType`, `icebergQty` ← `icebergQty`, `newOrderRespType` ← `newOrderRespType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `recvWindow` ← `recvWindow`
- **Returns**: `ApiV3SorOrderResponse`
- **Error**: `SdkException<NewOrderUsingSorTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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
- **Signature**: `QueryAllOcoUserData(long timestamp, string signature, long? fromId, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`fromId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `fromId` ← `fromId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<ApiV3AllOrderListResponse>`
- **Error**: `SdkException<QueryAllOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3AllOrderListResponse` | `Models/ApiV3AllOrderListResponse.cs` |
| `QueryAllOcoUserDataError` | `Errors/QueryAllOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryAllocationsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryAllocationsUserData(string symbol, long timestamp, string signature, long? startTime, long? endTime, long? fromAllocationId, int? limit, long? orderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `fromAllocationId` ← `fromAllocationId`, `limit` ← `limit`, `orderId` ← `orderId`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<ApiV3MyAllocationsResponse>`
- **Error**: `SdkException<QueryAllocationsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3MyAllocationsResponse` | `Models/ApiV3MyAllocationsResponse.cs` |
| `QueryAllocationsUserDataError` | `Errors/QueryAllocationsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryCommissionRatesUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCommissionRatesUserData(string symbol, long timestamp, string signature, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`
- **Returns**: `ApiV3AccountCommissionResponse`
- **Error**: `SdkException<QueryCommissionRatesUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3AccountCommissionResponse` | `Models/ApiV3AccountCommissionResponse.cs` |
| `QueryCommissionRatesUserDataError` | `Errors/QueryCommissionRatesUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryCurrentOrderCountUsageTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCurrentOrderCountUsageTrade(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<ApiV3RateLimitOrderResponse>`
- **Error**: `SdkException<QueryCurrentOrderCountUsageTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3RateLimitOrderResponse` | `Models/ApiV3RateLimitOrderResponse.cs` |
| `QueryCurrentOrderCountUsageTradeError` | `Errors/QueryCurrentOrderCountUsageTradeError.cs` |
| `Error` | `Models/Error.cs` |

### QueryOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOcoUserData(long timestamp, string signature, long? orderListId, string? origClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `orderListId` — nullable, no default → **must pass explicitly**
  - `origClientOrderId` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderListId` ← `orderListId`, `origClientOrderId` ← `origClientOrderId`, `recvWindow` ← `recvWindow`
- **Returns**: `ApiV3OrderListResponse`
- **Error**: `SdkException<QueryOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3OrderListResponse` | `Models/ApiV3OrderListResponse.cs` |
| `QueryOcoUserDataError` | `Errors/QueryOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryOpenOcoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOpenOcoUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<ApiV3OpenOrderListResponse>`
- **Error**: `SdkException<QueryOpenOcoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3OpenOrderListResponse` | `Models/ApiV3OpenOrderListResponse.cs` |
| `QueryOpenOcoUserDataError` | `Errors/QueryOpenOcoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryOrderUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOrderUserData(string symbol, long timestamp, string signature, long? orderId, string? origClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `orderId` — nullable, no default → **must pass explicitly**
  - `origClientOrderId` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `origClientOrderId` ← `origClientOrderId`, `recvWindow` ← `recvWindow`
- **Returns**: `OrderDetails`
- **Error**: `SdkException<QueryOrderUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrderDetails` | `Models/OrderDetails.cs` |
| `QueryOrderUserDataError` | `Errors/QueryOrderUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryPreventedMatches

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryPreventedMatches(string symbol, long timestamp, string signature, long? preventedMatchId, long? orderId, long? fromPreventedMatchId, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`preventedMatchId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `timestamp` ← `timestamp`, `signature` ← `signature`, `preventedMatchId` ← `preventedMatchId`, `orderId` ← `orderId`, `fromPreventedMatchId` ← `fromPreventedMatchId`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<ApiV3MyPreventedMatchesResponse>`
- **Error**: `SdkException<QueryPreventedMatchesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3MyPreventedMatchesResponse` | `Models/ApiV3MyPreventedMatchesResponse.cs` |
| `QueryPreventedMatchesError` | `Errors/QueryPreventedMatchesError.cs` |
| `Error` | `Models/Error.cs` |

### TestNewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TestNewOrderTrade(string symbol, Side side, Type1 type, long timestamp, string signature, TimeInForce? timeInForce, double? quantity, double? quoteOrderQty, double? price, string? newClientOrderId, long? strategyId, long? strategyType, double? stopPrice, double? trailingDelta, double? icebergQty, NewOrderRespType? newOrderRespType, long? recvWindow, bool? computeCommissionRates, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 13 params (`timeInForce` … `computeCommissionRates`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `timeInForce` ← `timeInForce`, `quantity` ← `quantity`, `quoteOrderQty` ← `quoteOrderQty`, `price` ← `price`, `newClientOrderId` ← `newClientOrderId`, `strategyId` ← `strategyId`, `strategyType` ← `strategyType`, `stopPrice` ← `stopPrice`, `trailingDelta` ← `trailingDelta`, `icebergQty` ← `icebergQty`, `newOrderRespType` ← `newOrderRespType`, `recvWindow` ← `recvWindow`, `computeCommissionRates` ← `computeCommissionRates`
- **Returns**: `object`
- **Error**: `SdkException<TestNewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Side` | `Models/Enums/Side.cs` |
| `Type1` | `Models/Enums/Type1.cs` |
| `TimeInForce` | `Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `TestNewOrderTradeError` | `Errors/TestNewOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

### TestNewOrderUsingSorTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TestNewOrderUsingSorTrade(string symbol, Side side, Type1 type, double quantity, long timestamp, string signature, TimeInForce? timeInForce, double? price, string? newClientOrderId, long? strategyId, long? strategyType, double? icebergQty, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, bool? computeCommissionRates, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`timeInForce` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `type` ← `type`, `quantity` ← `quantity`, `timestamp` ← `timestamp`, `signature` ← `signature`, `timeInForce` ← `timeInForce`, `price` ← `price`, `newClientOrderId` ← `newClientOrderId`, `strategyId` ← `strategyId`, `strategyType` ← `strategyType`, `icebergQty` ← `icebergQty`, `newOrderRespType` ← `newOrderRespType`, `selfTradePreventionMode` ← `selfTradePreventionMode`, `computeCommissionRates` ← `computeCommissionRates`, `recvWindow` ← `recvWindow`
- **Returns**: `object`
- **Error**: `SdkException<TestNewOrderUsingSorTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Side` | `Models/Enums/Side.cs` |
| `Type1` | `Models/Enums/Type1.cs` |
| `TimeInForce` | `Models/Enums/TimeInForce.cs` |
| `NewOrderRespType` | `Models/Enums/NewOrderRespType.cs` |
| `SelfTradePreventionMode` | `Models/Enums/SelfTradePreventionMode.cs` |
| `TestNewOrderUsingSorTradeError` | `Errors/TestNewOrderUsingSorTradeError.cs` |
| `Error` | `Models/Error.cs` |

