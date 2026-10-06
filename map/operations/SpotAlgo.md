<!-- Generated file — do not edit; regenerated with the SDK. -->

# SpotAlgo — operations

Accessor: `client.SpotAlgo` · Source: `Api/SpotAlgo.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelAlgoOrder

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelAlgoOrder(CancelAlgoOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AlgoId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algoId` ← `AlgoId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoSpotOrderResponse`
- **Error**: `ApiException<CancelAlgoOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelAlgoOrderRequest` | `Requests/SpotAlgo/CancelAlgoOrderRequest.cs` |
| `SapiV1AlgoSpotOrderResponse` | `Models/SapiV1AlgoSpotOrderResponse.cs` |
| `CancelAlgoOrderError` | `Errors/CancelAlgoOrderError.cs` |
| `Error` | `Models/Error.cs` |

### QueryCurrentAlgoOpenOrders

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryCurrentAlgoOpenOrders(QueryCurrentAlgoOpenOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoSpotOpenOrdersResponse`
- **Error**: `ApiException<QueryCurrentAlgoOpenOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryCurrentAlgoOpenOrdersRequest` | `Requests/SpotAlgo/QueryCurrentAlgoOpenOrdersRequest.cs` |
| `SapiV1AlgoSpotOpenOrdersResponse` | `Models/SapiV1AlgoSpotOpenOrdersResponse.cs` |
| `QueryCurrentAlgoOpenOrdersError` | `Errors/QueryCurrentAlgoOpenOrdersError.cs` |
| `Error` | `Models/Error.cs` |

### QueryHistoricalAlgoOrders

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryHistoricalAlgoOrders(QueryHistoricalAlgoOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `page` ← `Page`, `pageSize` ← `PageSize`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoSpotHistoricalOrdersResponse`
- **Error**: `ApiException<QueryHistoricalAlgoOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryHistoricalAlgoOrdersRequest` | `Requests/SpotAlgo/QueryHistoricalAlgoOrdersRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `SapiV1AlgoSpotHistoricalOrdersResponse` | `Models/SapiV1AlgoSpotHistoricalOrdersResponse.cs` |
| `QueryHistoricalAlgoOrdersError` | `Errors/QueryHistoricalAlgoOrdersError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubOrders

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubOrders(QuerySubOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AlgoId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `algoId` ← `AlgoId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `page` ← `Page`, `pageSize` ← `PageSize`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoSpotSubOrdersResponse`
- **Error**: `ApiException<QuerySubOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QuerySubOrdersRequest` | `Requests/SpotAlgo/QuerySubOrdersRequest.cs` |
| `SapiV1AlgoSpotSubOrdersResponse` | `Models/SapiV1AlgoSpotSubOrdersResponse.cs` |
| `QuerySubOrdersError` | `Errors/QuerySubOrdersError.cs` |
| `Error` | `Models/Error.cs` |

### TimeWeightedAveragePriceTwapNewOrder

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TimeWeightedAveragePriceTwapNewOrder(TimeWeightedAveragePriceTwapNewOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Side`, `Quantity`, `Duration`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `side` ← `Side`, `quantity` ← `Quantity`, `duration` ← `Duration`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `clientAlgoId` ← `ClientAlgoId`, `limitPrice` ← `LimitPrice`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AlgoSpotNewOrderTwapResponse`
- **Error**: `ApiException<TimeWeightedAveragePriceTwapNewOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TimeWeightedAveragePriceTwapNewOrderRequest` | `Requests/SpotAlgo/TimeWeightedAveragePriceTwapNewOrderRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `SapiV1AlgoSpotNewOrderTwapResponse` | `Models/SapiV1AlgoSpotNewOrderTwapResponse.cs` |
| `TimeWeightedAveragePriceTwapNewOrderError` | `Errors/TimeWeightedAveragePriceTwapNewOrderError.cs` |
| `Error` | `Models/Error.cs` |

