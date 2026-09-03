<!-- Generated file — do not edit; regenerated with the SDK. -->

# ConvertApi — operations

Accessor: `client.ConvertApi` · Source: `Api/ConvertApi.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AcceptQuoteTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AcceptQuoteTrade(string quoteId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `quoteId` ← `quoteId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ConvertAcceptQuoteResponse`
- **Error**: `SdkException<AcceptQuoteTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ConvertAcceptQuoteResponse` | `Models/SapiV1ConvertAcceptQuoteResponse.cs` |
| `AcceptQuoteTradeError` | `Errors/AcceptQuoteTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CancelLimitOrderUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelLimitOrderUserData(long orderId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `orderId` ← `orderId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ConvertLimitCancelOrderResponse`
- **Error**: `SdkException<CancelLimitOrderUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ConvertLimitCancelOrderResponse` | `Models/SapiV1ConvertLimitCancelOrderResponse.cs` |
| `CancelLimitOrderUserDataError` | `Errors/CancelLimitOrderUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetConvertTradeHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetConvertTradeHistoryUserData(long startTime, long endTime, long timestamp, string signature, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`, `timestamp` ← `timestamp`, `signature` ← `signature`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ConvertTradeFlowResponse`
- **Error**: `SdkException<GetConvertTradeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ConvertTradeFlowResponse` | `Models/SapiV1ConvertTradeFlowResponse.cs` |
| `GetConvertTradeHistoryUserDataError` | `Errors/GetConvertTradeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### ListAllConvertPairs

- **Signature**: `ListAllConvertPairs(string? fromAsset, string? toAsset, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `fromAsset` — nullable, no default → **must pass explicitly**
  - `toAsset` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `fromAsset` ← `fromAsset`, `toAsset` ← `toAsset`
- **Returns**: `IReadOnlyList<SapiV1ConvertExchangeInfoResponse>`
- **Error**: `SdkException<ListAllConvertPairsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ConvertExchangeInfoResponse` | `Models/SapiV1ConvertExchangeInfoResponse.cs` |
| `ListAllConvertPairsError` | `Errors/ListAllConvertPairsError.cs` |
| `Error` | `Models/Error.cs` |

### OrderStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `OrderStatusUserData(long timestamp, string signature, string? orderId, string? quoteId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `orderId` — nullable, no default → **must pass explicitly**
  - `quoteId` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `quoteId` ← `quoteId`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ConvertOrderStatusResponse`
- **Error**: `SdkException<OrderStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ConvertOrderStatusResponse` | `Models/SapiV1ConvertOrderStatusResponse.cs` |
| `OrderStatusUserDataError` | `Errors/OrderStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PlaceLimitOrderUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PlaceLimitOrderUserData(string baseAsset, string quoteAsset, double limitPrice, Side side, long timestamp, string signature, double? baseAmount, double? quoteAmount, WalletType? walletType, ExpiredType? expiredType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`baseAmount` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `baseAsset` ← `baseAsset`, `quoteAsset` ← `quoteAsset`, `limitPrice` ← `limitPrice`, `side` ← `side`, `timestamp` ← `timestamp`, `signature` ← `signature`, `baseAmount` ← `baseAmount`, `quoteAmount` ← `quoteAmount`, `walletType` ← `walletType`, `expiredType` ← `expiredType`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ConvertLimitPlaceOrderResponse`
- **Error**: `SdkException<PlaceLimitOrderUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Side` | `Models/Enums/Side.cs` |
| `WalletType` | `Models/Enums/WalletType.cs` |
| `ExpiredType` | `Models/Enums/ExpiredType.cs` |
| `SapiV1ConvertLimitPlaceOrderResponse` | `Models/SapiV1ConvertLimitPlaceOrderResponse.cs` |
| `PlaceLimitOrderUserDataError` | `Errors/PlaceLimitOrderUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryLimitOpenOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryLimitOpenOrdersUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ConvertLimitQueryOpenOrdersResponse`
- **Error**: `SdkException<QueryLimitOpenOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ConvertLimitQueryOpenOrdersResponse` | `Models/SapiV1ConvertLimitQueryOpenOrdersResponse.cs` |
| `QueryLimitOpenOrdersUserDataError` | `Errors/QueryLimitOpenOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryOrderQuantityPrecisionPerAssetUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOrderQuantityPrecisionPerAssetUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1ConvertAssetInfoResponse>`
- **Error**: `SdkException<QueryOrderQuantityPrecisionPerAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ConvertAssetInfoResponse` | `Models/SapiV1ConvertAssetInfoResponse.cs` |
| `QueryOrderQuantityPrecisionPerAssetUserDataError` | `Errors/QueryOrderQuantityPrecisionPerAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SendQuoteRequestUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SendQuoteRequestUserData(string fromAsset, string toAsset, long timestamp, string signature, double? fromAmount, double? toAmount, string? validTime, string? walletType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`fromAmount` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `fromAsset` ← `fromAsset`, `toAsset` ← `toAsset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `fromAmount` ← `fromAmount`, `toAmount` ← `toAmount`, `validTime` ← `validTime`, `walletType` ← `walletType`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ConvertGetQuoteResponse`
- **Error**: `SdkException<SendQuoteRequestUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ConvertGetQuoteResponse` | `Models/SapiV1ConvertGetQuoteResponse.cs` |
| `SendQuoteRequestUserDataError` | `Errors/SendQuoteRequestUserDataError.cs` |
| `Error` | `Models/Error.cs` |

