<!-- Generated file — do not edit; regenerated with the SDK. -->

# FuturesAlgo — operations

Accessor: `client.FuturesAlgo` · Source: `src/Binance/Api/FuturesAlgo.cs` · 6 operations

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
| `CancelAlgoOrderTradeRequest` | `src/Binance/Requests/FuturesAlgo/CancelAlgoOrderTradeRequest.cs` |
| `SapiV1AlgoFuturesOrderResponse` | `src/Binance/Models/SapiV1AlgoFuturesOrderResponse.cs` |
| `CancelAlgoOrderTradeError` | `src/Binance/Errors/CancelAlgoOrderTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `QueryCurrentAlgoOpenOrdersUserDataRequest` | `src/Binance/Requests/FuturesAlgo/QueryCurrentAlgoOpenOrdersUserDataRequest.cs` |
| `SapiV1AlgoFuturesOpenOrdersResponse` | `src/Binance/Models/SapiV1AlgoFuturesOpenOrdersResponse.cs` |
| `QueryCurrentAlgoOpenOrdersUserDataError` | `src/Binance/Errors/QueryCurrentAlgoOpenOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `QueryHistoricalAlgoOrdersUserDataRequest` | `src/Binance/Requests/FuturesAlgo/QueryHistoricalAlgoOrdersUserDataRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `SapiV1AlgoFuturesHistoricalOrdersResponse` | `src/Binance/Models/SapiV1AlgoFuturesHistoricalOrdersResponse.cs` |
| `QueryHistoricalAlgoOrdersUserDataError` | `src/Binance/Errors/QueryHistoricalAlgoOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `QuerySubOrdersUserDataRequest` | `src/Binance/Requests/FuturesAlgo/QuerySubOrdersUserDataRequest.cs` |
| `SapiV1AlgoFuturesSubOrdersResponse` | `src/Binance/Models/SapiV1AlgoFuturesSubOrdersResponse.cs` |
| `QuerySubOrdersUserDataError` | `src/Binance/Errors/QuerySubOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `TimeWeightedAveragePriceTwapNewOrderTradeRequest` | `src/Binance/Requests/FuturesAlgo/TimeWeightedAveragePriceTwapNewOrderTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `PositionSide` | `src/Binance/Models/Enums/PositionSide.cs` |
| `SapiV1AlgoFuturesNewOrderTwapResponse` | `src/Binance/Models/SapiV1AlgoFuturesNewOrderTwapResponse.cs` |
| `TimeWeightedAveragePriceTwapNewOrderTradeError` | `src/Binance/Errors/TimeWeightedAveragePriceTwapNewOrderTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `VolumeParticipationVpNewOrderTradeRequest` | `src/Binance/Requests/FuturesAlgo/VolumeParticipationVpNewOrderTradeRequest.cs` |
| `Side` | `src/Binance/Models/Enums/Side.cs` |
| `Urgency` | `src/Binance/Models/Enums/Urgency.cs` |
| `PositionSide` | `src/Binance/Models/Enums/PositionSide.cs` |
| `SapiV1AlgoFuturesNewOrderVpResponse` | `src/Binance/Models/SapiV1AlgoFuturesNewOrderVpResponse.cs` |
| `VolumeParticipationVpNewOrderTradeError` | `src/Binance/Errors/VolumeParticipationVpNewOrderTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

