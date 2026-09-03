<!-- Generated file — do not edit; regenerated with the SDK. -->

# FuturesAlgo — operations

Accessor: `client.FuturesAlgo` · Source: `Api/FuturesAlgo.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelAlgoOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelAlgoOrderTrade(long algoId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `algoId` ← `algoId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoFuturesOrderResponse`
- **Error**: `SdkException<CancelAlgoOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AlgoFuturesOrderResponse` | `Models/SapiV1AlgoFuturesOrderResponse.cs` |
| `CancelAlgoOrderTradeError` | `Errors/CancelAlgoOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

### QueryCurrentAlgoOpenOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCurrentAlgoOpenOrdersUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoFuturesOpenOrdersResponse`
- **Error**: `SdkException<QueryCurrentAlgoOpenOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AlgoFuturesOpenOrdersResponse` | `Models/SapiV1AlgoFuturesOpenOrdersResponse.cs` |
| `QueryCurrentAlgoOpenOrdersUserDataError` | `Errors/QueryCurrentAlgoOpenOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryHistoricalAlgoOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryHistoricalAlgoOrdersUserData(long timestamp, string signature, string? symbol, Side? side, long? startTime, long? endTime, int? page, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`symbol` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `symbol` ← `symbol`, `side` ← `side`, `startTime` ← `startTime`, `endTime` ← `endTime`, `page` ← `page`, `pageSize` ← `pageSize`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoFuturesHistoricalOrdersResponse`
- **Error**: `SdkException<QueryHistoricalAlgoOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Side` | `Models/Enums/Side.cs` |
| `SapiV1AlgoFuturesHistoricalOrdersResponse` | `Models/SapiV1AlgoFuturesHistoricalOrdersResponse.cs` |
| `QueryHistoricalAlgoOrdersUserDataError` | `Errors/QueryHistoricalAlgoOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubOrdersUserData(long algoId, long timestamp, string signature, int? page, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `pageSize` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `algoId` ← `algoId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `page` ← `page`, `pageSize` ← `pageSize`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoFuturesSubOrdersResponse`
- **Error**: `SdkException<QuerySubOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AlgoFuturesSubOrdersResponse` | `Models/SapiV1AlgoFuturesSubOrdersResponse.cs` |
| `QuerySubOrdersUserDataError` | `Errors/QuerySubOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### TimeWeightedAveragePriceTwapNewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TimeWeightedAveragePriceTwapNewOrderTrade(string symbol, Side side, double quantity, long duration, long timestamp, string signature, PositionSide? positionSide, string? clientAlgoId, bool? reduceOnly, double? limitPrice, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`positionSide` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `quantity` ← `quantity`, `duration` ← `duration`, `timestamp` ← `timestamp`, `signature` ← `signature`, `positionSide` ← `positionSide`, `clientAlgoId` ← `clientAlgoId`, `reduceOnly` ← `reduceOnly`, `limitPrice` ← `limitPrice`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoFuturesNewOrderTwapResponse`
- **Error**: `SdkException<TimeWeightedAveragePriceTwapNewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Side` | `Models/Enums/Side.cs` |
| `PositionSide` | `Models/Enums/PositionSide.cs` |
| `SapiV1AlgoFuturesNewOrderTwapResponse` | `Models/SapiV1AlgoFuturesNewOrderTwapResponse.cs` |
| `TimeWeightedAveragePriceTwapNewOrderTradeError` | `Errors/TimeWeightedAveragePriceTwapNewOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

### VolumeParticipationVpNewOrderTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `VolumeParticipationVpNewOrderTrade(string symbol, Side side, double quantity, Urgency urgency, long timestamp, string signature, PositionSide? positionSide, string? clientAlgoId, bool? reduceOnly, double? limitPrice, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`positionSide` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `quantity` ← `quantity`, `urgency` ← `urgency`, `timestamp` ← `timestamp`, `signature` ← `signature`, `positionSide` ← `positionSide`, `clientAlgoId` ← `clientAlgoId`, `reduceOnly` ← `reduceOnly`, `limitPrice` ← `limitPrice`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoFuturesNewOrderVpResponse`
- **Error**: `SdkException<VolumeParticipationVpNewOrderTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Side` | `Models/Enums/Side.cs` |
| `Urgency` | `Models/Enums/Urgency.cs` |
| `PositionSide` | `Models/Enums/PositionSide.cs` |
| `SapiV1AlgoFuturesNewOrderVpResponse` | `Models/SapiV1AlgoFuturesNewOrderVpResponse.cs` |
| `VolumeParticipationVpNewOrderTradeError` | `Errors/VolumeParticipationVpNewOrderTradeError.cs` |
| `Error` | `Models/Error.cs` |

