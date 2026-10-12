<!-- Generated file — do not edit; regenerated with the SDK. -->

# Blvt — operations

Accessor: `client.Blvt` · Source: `src/Binance/Api/Blvt.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BlvtInfoMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BlvtInfoMarketData(BlvtInfoMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `tokenName` ← `TokenName`
- **Returns**: `IReadOnlyList<SapiV1BlvtTokenInfoResponse>`
- **Error**: `ApiException<BlvtInfoMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BlvtInfoMarketDataRequest` | `src/Binance/Requests/Blvt/BlvtInfoMarketDataRequest.cs` |
| `SapiV1BlvtTokenInfoResponse` | `src/Binance/Models/SapiV1BlvtTokenInfoResponse.cs` |
| `BlvtInfoMarketDataError` | `src/Binance/Errors/BlvtInfoMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### BlvtUserLimitInfoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BlvtUserLimitInfoUserData(BlvtUserLimitInfoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `tokenName` ← `TokenName`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1BlvtUserLimitResponse>`
- **Error**: `ApiException<BlvtUserLimitInfoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BlvtUserLimitInfoUserDataRequest` | `src/Binance/Requests/Blvt/BlvtUserLimitInfoUserDataRequest.cs` |
| `SapiV1BlvtUserLimitResponse` | `src/Binance/Models/SapiV1BlvtUserLimitResponse.cs` |
| `BlvtUserLimitInfoUserDataError` | `src/Binance/Errors/BlvtUserLimitInfoUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QuerySubscriptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubscriptionRecordUserData(QuerySubscriptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `tokenName` ← `TokenName`, `id` ← `Id`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1BlvtSubscribeRecordResponse`
- **Error**: `ApiException<QuerySubscriptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QuerySubscriptionRecordUserDataRequest` | `src/Binance/Requests/Blvt/QuerySubscriptionRecordUserDataRequest.cs` |
| `SapiV1BlvtSubscribeRecordResponse` | `src/Binance/Models/SapiV1BlvtSubscribeRecordResponse.cs` |
| `QuerySubscriptionRecordUserDataError` | `src/Binance/Errors/QuerySubscriptionRecordUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### RedeemBlvtUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedeemBlvtUserData(RedeemBlvtUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TokenName`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `tokenName` ← `TokenName`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1BlvtRedeemResponse`
- **Error**: `ApiException<RedeemBlvtUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RedeemBlvtUserDataRequest` | `src/Binance/Requests/Blvt/RedeemBlvtUserDataRequest.cs` |
| `SapiV1BlvtRedeemResponse` | `src/Binance/Models/SapiV1BlvtRedeemResponse.cs` |
| `RedeemBlvtUserDataError` | `src/Binance/Errors/RedeemBlvtUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### RedemptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedemptionRecordUserData(RedemptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `tokenName` ← `TokenName`, `id` ← `Id`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1BlvtRedeemRecordResponse>`
- **Error**: `ApiException<RedemptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RedemptionRecordUserDataRequest` | `src/Binance/Requests/Blvt/RedemptionRecordUserDataRequest.cs` |
| `SapiV1BlvtRedeemRecordResponse` | `src/Binance/Models/SapiV1BlvtRedeemRecordResponse.cs` |
| `RedemptionRecordUserDataError` | `src/Binance/Errors/RedemptionRecordUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubscribeBlvtUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubscribeBlvtUserData(SubscribeBlvtUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TokenName`, `Cost`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `tokenName` ← `TokenName`, `cost` ← `Cost`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1BlvtSubscribeResponse`
- **Error**: `ApiException<SubscribeBlvtUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubscribeBlvtUserDataRequest` | `src/Binance/Requests/Blvt/SubscribeBlvtUserDataRequest.cs` |
| `SapiV1BlvtSubscribeResponse` | `src/Binance/Models/SapiV1BlvtSubscribeResponse.cs` |
| `SubscribeBlvtUserDataError` | `src/Binance/Errors/SubscribeBlvtUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

