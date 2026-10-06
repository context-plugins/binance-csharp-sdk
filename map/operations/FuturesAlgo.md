<!-- Generated file — do not edit; regenerated with the SDK. -->

# FuturesAlgo — operations

Accessor: `client.FuturesAlgo` · Source: `Api/FuturesAlgo.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelAlgoOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelAlgoOrderTrade(CancelAlgoOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AlgoId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algoId` ← `AlgoId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoFuturesOrderResponse`
- **Error**: `ApiException<CancelAlgoOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelAlgoOrderTradeRequest` | `Requests/FuturesAlgo/CancelAlgoOrderTradeRequest.cs` |
| `SapiV1AlgoFuturesOrderResponse` | `Models/SapiV1AlgoFuturesOrderResponse.cs` |
| `CancelAlgoOrderTradeError` | `Errors/CancelAlgoOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

### QueryCurrentAlgoOpenOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCurrentAlgoOpenOrdersUserData(QueryCurrentAlgoOpenOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoFuturesOpenOrdersResponse`
- **Error**: `ApiException<QueryCurrentAlgoOpenOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryCurrentAlgoOpenOrdersUserDataRequest` | `Requests/FuturesAlgo/QueryCurrentAlgoOpenOrdersUserDataRequest.cs` |
| `SapiV1AlgoFuturesOpenOrdersResponse` | `Models/SapiV1AlgoFuturesOpenOrdersResponse.cs` |
| `QueryCurrentAlgoOpenOrdersUserDataError` | `Errors/QueryCurrentAlgoOpenOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryHistoricalAlgoOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryHistoricalAlgoOrdersUserData(QueryHistoricalAlgoOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `symbol` ← `Symbol`, `side` ← `Side`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `page` ← `Page`, `pageSize` ← `PageSize`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoFuturesHistoricalOrdersResponse`
- **Error**: `ApiException<QueryHistoricalAlgoOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryHistoricalAlgoOrdersUserDataRequest` | `Requests/FuturesAlgo/QueryHistoricalAlgoOrdersUserDataRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `SapiV1AlgoFuturesHistoricalOrdersResponse` | `Models/SapiV1AlgoFuturesHistoricalOrdersResponse.cs` |
| `QueryHistoricalAlgoOrdersUserDataError` | `Errors/QueryHistoricalAlgoOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubOrdersUserData(QuerySubOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AlgoId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algoId` ← `AlgoId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `page` ← `Page`, `pageSize` ← `PageSize`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoFuturesSubOrdersResponse`
- **Error**: `ApiException<QuerySubOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QuerySubOrdersUserDataRequest` | `Requests/FuturesAlgo/QuerySubOrdersUserDataRequest.cs` |
| `SapiV1AlgoFuturesSubOrdersResponse` | `Models/SapiV1AlgoFuturesSubOrdersResponse.cs` |
| `QuerySubOrdersUserDataError` | `Errors/QuerySubOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### TimeWeightedAveragePriceTwapNewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TimeWeightedAveragePriceTwapNewOrderTrade(TimeWeightedAveragePriceTwapNewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Quantity`, `Duration`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `quantity` ← `Quantity`, `duration` ← `Duration`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `positionSide` ← `PositionSide`, `clientAlgoId` ← `ClientAlgoId`, `reduceOnly` ← `ReduceOnly`, `limitPrice` ← `LimitPrice`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoFuturesNewOrderTwapResponse`
- **Error**: `ApiException<TimeWeightedAveragePriceTwapNewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TimeWeightedAveragePriceTwapNewOrderTradeRequest` | `Requests/FuturesAlgo/TimeWeightedAveragePriceTwapNewOrderTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `PositionSide` | `Models/Enums/PositionSide.cs` |
| `SapiV1AlgoFuturesNewOrderTwapResponse` | `Models/SapiV1AlgoFuturesNewOrderTwapResponse.cs` |
| `TimeWeightedAveragePriceTwapNewOrderTradeError` | `Errors/TimeWeightedAveragePriceTwapNewOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

### VolumeParticipationVpNewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `VolumeParticipationVpNewOrderTrade(VolumeParticipationVpNewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Quantity`, `Urgency`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `quantity` ← `Quantity`, `urgency` ← `Urgency`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `positionSide` ← `PositionSide`, `clientAlgoId` ← `ClientAlgoId`, `reduceOnly` ← `ReduceOnly`, `limitPrice` ← `LimitPrice`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoFuturesNewOrderVpResponse`
- **Error**: `ApiException<VolumeParticipationVpNewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VolumeParticipationVpNewOrderTradeRequest` | `Requests/FuturesAlgo/VolumeParticipationVpNewOrderTradeRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `Urgency` | `Models/Enums/Urgency.cs` |
| `PositionSide` | `Models/Enums/PositionSide.cs` |
| `SapiV1AlgoFuturesNewOrderVpResponse` | `Models/SapiV1AlgoFuturesNewOrderVpResponse.cs` |
| `VolumeParticipationVpNewOrderTradeError` | `Errors/VolumeParticipationVpNewOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

