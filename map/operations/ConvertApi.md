<!-- Generated file — do not edit; regenerated with the SDK. -->

# ConvertApi — operations

Accessor: `client.ConvertApi` · Source: `Api/ConvertApi.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AcceptQuoteTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AcceptQuoteTrade(AcceptQuoteTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `QuoteId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `quoteId` ← `QuoteId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ConvertAcceptQuoteResponse`
- **Error**: `ApiException<AcceptQuoteTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AcceptQuoteTradeRequest` | `Requests/ConvertApi/AcceptQuoteTradeRequest.cs` |
| `SapiV1ConvertAcceptQuoteResponse` | `Models/SapiV1ConvertAcceptQuoteResponse.cs` |
| `AcceptQuoteTradeError` | `Errors/AcceptQuoteTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CancelLimitOrderUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CancelLimitOrderUserData(CancelLimitOrderUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `orderId` ← `OrderId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ConvertLimitCancelOrderResponse`
- **Error**: `ApiException<CancelLimitOrderUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelLimitOrderUserDataRequest` | `Requests/ConvertApi/CancelLimitOrderUserDataRequest.cs` |
| `SapiV1ConvertLimitCancelOrderResponse` | `Models/SapiV1ConvertLimitCancelOrderResponse.cs` |
| `CancelLimitOrderUserDataError` | `Errors/CancelLimitOrderUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetConvertTradeHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetConvertTradeHistoryUserData(GetConvertTradeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StartTime`, `EndTime`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `startTime` ← `StartTime`, `endTime` ← `EndTime`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ConvertTradeFlowResponse`
- **Error**: `ApiException<GetConvertTradeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetConvertTradeHistoryUserDataRequest` | `Requests/ConvertApi/GetConvertTradeHistoryUserDataRequest.cs` |
| `SapiV1ConvertTradeFlowResponse` | `Models/SapiV1ConvertTradeFlowResponse.cs` |
| `GetConvertTradeHistoryUserDataError` | `Errors/GetConvertTradeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### ListAllConvertPairs

- **Signature**: `ListAllConvertPairs(ListAllConvertPairsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `fromAsset` ← `FromAsset`, `toAsset` ← `ToAsset`
- **Returns**: `IReadOnlyList<SapiV1ConvertExchangeInfoResponse>`
- **Error**: `ApiException<ListAllConvertPairsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAllConvertPairsRequest` | `Requests/ConvertApi/ListAllConvertPairsRequest.cs` |
| `SapiV1ConvertExchangeInfoResponse` | `Models/SapiV1ConvertExchangeInfoResponse.cs` |
| `ListAllConvertPairsError` | `Errors/ListAllConvertPairsError.cs` |
| `Error` | `Models/Error.cs` |

### OrderStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `OrderStatusUserData(OrderStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `quoteId` ← `QuoteId`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ConvertOrderStatusResponse`
- **Error**: `ApiException<OrderStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrderStatusUserDataRequest` | `Requests/ConvertApi/OrderStatusUserDataRequest.cs` |
| `SapiV1ConvertOrderStatusResponse` | `Models/SapiV1ConvertOrderStatusResponse.cs` |
| `OrderStatusUserDataError` | `Errors/OrderStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PlaceLimitOrderUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PlaceLimitOrderUserData(PlaceLimitOrderUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BaseAsset`, `QuoteAsset`, `LimitPrice`, `Side`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `baseAsset` ← `BaseAsset`, `quoteAsset` ← `QuoteAsset`, `limitPrice` ← `LimitPrice`, `side` ← `Side`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `baseAmount` ← `BaseAmount`, `quoteAmount` ← `QuoteAmount`, `walletType` ← `WalletType`, `expiredType` ← `ExpiredType`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ConvertLimitPlaceOrderResponse`
- **Error**: `ApiException<PlaceLimitOrderUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PlaceLimitOrderUserDataRequest` | `Requests/ConvertApi/PlaceLimitOrderUserDataRequest.cs` |
| `Side` | `Models/Enums/Side.cs` |
| `WalletType` | `Models/Enums/WalletType.cs` |
| `ExpiredType` | `Models/Enums/ExpiredType.cs` |
| `SapiV1ConvertLimitPlaceOrderResponse` | `Models/SapiV1ConvertLimitPlaceOrderResponse.cs` |
| `PlaceLimitOrderUserDataError` | `Errors/PlaceLimitOrderUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryLimitOpenOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryLimitOpenOrdersUserData(QueryLimitOpenOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ConvertLimitQueryOpenOrdersResponse`
- **Error**: `ApiException<QueryLimitOpenOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryLimitOpenOrdersUserDataRequest` | `Requests/ConvertApi/QueryLimitOpenOrdersUserDataRequest.cs` |
| `SapiV1ConvertLimitQueryOpenOrdersResponse` | `Models/SapiV1ConvertLimitQueryOpenOrdersResponse.cs` |
| `QueryLimitOpenOrdersUserDataError` | `Errors/QueryLimitOpenOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryOrderQuantityPrecisionPerAssetUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOrderQuantityPrecisionPerAssetUserData(QueryOrderQuantityPrecisionPerAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1ConvertAssetInfoResponse>`
- **Error**: `ApiException<QueryOrderQuantityPrecisionPerAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryOrderQuantityPrecisionPerAssetUserDataRequest` | `Requests/ConvertApi/QueryOrderQuantityPrecisionPerAssetUserDataRequest.cs` |
| `SapiV1ConvertAssetInfoResponse` | `Models/SapiV1ConvertAssetInfoResponse.cs` |
| `QueryOrderQuantityPrecisionPerAssetUserDataError` | `Errors/QueryOrderQuantityPrecisionPerAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SendQuoteRequestUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SendQuoteRequestUserData(SendQuoteRequestUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FromAsset`, `ToAsset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `fromAsset` ← `FromAsset`, `toAsset` ← `ToAsset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `fromAmount` ← `FromAmount`, `toAmount` ← `ToAmount`, `validTime` ← `ValidTime`, `walletType` ← `WalletType`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ConvertGetQuoteResponse`
- **Error**: `ApiException<SendQuoteRequestUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SendQuoteRequestUserDataRequest` | `Requests/ConvertApi/SendQuoteRequestUserDataRequest.cs` |
| `SapiV1ConvertGetQuoteResponse` | `Models/SapiV1ConvertGetQuoteResponse.cs` |
| `SendQuoteRequestUserDataError` | `Errors/SendQuoteRequestUserDataError.cs` |
| `Error` | `Models/Error.cs` |

