<!-- Generated file — do not edit; regenerated with the SDK. -->

# SpotAlgo — operations

Accessor: `client.SpotAlgo` · Source: `Api/SpotAlgo.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelAlgoOrder

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelAlgoOrder(long algoId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `algoId` ← `algoId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoSpotOrderResponse`
- **Error**: `SdkException<CancelAlgoOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AlgoSpotOrderResponse` | `Models/SapiV1AlgoSpotOrderResponse.cs` |
| `CancelAlgoOrderError` | `Errors/CancelAlgoOrderError.cs` |
| `Error` | `Models/Error.cs` |

### QueryCurrentAlgoOpenOrders

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCurrentAlgoOpenOrders(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoSpotOpenOrdersResponse`
- **Error**: `SdkException<QueryCurrentAlgoOpenOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AlgoSpotOpenOrdersResponse` | `Models/SapiV1AlgoSpotOpenOrdersResponse.cs` |
| `QueryCurrentAlgoOpenOrdersError` | `Errors/QueryCurrentAlgoOpenOrdersError.cs` |
| `Error` | `Models/Error.cs` |

### QueryHistoricalAlgoOrders

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryHistoricalAlgoOrders(string symbol, Side side, long timestamp, string signature, long? startTime, long? endTime, int? page, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `page` ← `page`, `pageSize` ← `pageSize`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoSpotHistoricalOrdersResponse`
- **Error**: `SdkException<QueryHistoricalAlgoOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Side` | `Models/Enums/Side.cs` |
| `SapiV1AlgoSpotHistoricalOrdersResponse` | `Models/SapiV1AlgoSpotHistoricalOrdersResponse.cs` |
| `QueryHistoricalAlgoOrdersError` | `Errors/QueryHistoricalAlgoOrdersError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubOrders

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubOrders(long algoId, long timestamp, string signature, int? page, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `pageSize` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `algoId` ← `algoId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `page` ← `page`, `pageSize` ← `pageSize`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoSpotSubOrdersResponse`
- **Error**: `SdkException<QuerySubOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AlgoSpotSubOrdersResponse` | `Models/SapiV1AlgoSpotSubOrdersResponse.cs` |
| `QuerySubOrdersError` | `Errors/QuerySubOrdersError.cs` |
| `Error` | `Models/Error.cs` |

### TimeWeightedAveragePriceTwapNewOrder

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TimeWeightedAveragePriceTwapNewOrder(string symbol, Side side, double quantity, int duration, long timestamp, string signature, string? clientAlgoId, double? limitPrice, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `clientAlgoId` — nullable, no default → **must pass explicitly**
  - `limitPrice` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `side` ← `side`, `quantity` ← `quantity`, `duration` ← `duration`, `timestamp` ← `timestamp`, `signature` ← `signature`, `clientAlgoId` ← `clientAlgoId`, `limitPrice` ← `limitPrice`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AlgoSpotNewOrderTwapResponse`
- **Error**: `SdkException<TimeWeightedAveragePriceTwapNewOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Side` | `Models/Enums/Side.cs` |
| `SapiV1AlgoSpotNewOrderTwapResponse` | `Models/SapiV1AlgoSpotNewOrderTwapResponse.cs` |
| `TimeWeightedAveragePriceTwapNewOrderError` | `Errors/TimeWeightedAveragePriceTwapNewOrderError.cs` |
| `Error` | `Models/Error.cs` |

