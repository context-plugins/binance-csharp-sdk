<!-- Generated file — do not edit; regenerated with the SDK. -->

# Blvt — operations

Accessor: `client.Blvt` · Source: `Api/Blvt.cs` · 6 operations

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
| `BlvtInfoMarketDataRequest` | `Requests/Blvt/BlvtInfoMarketDataRequest.cs` |
| `SapiV1BlvtTokenInfoResponse` | `Models/SapiV1BlvtTokenInfoResponse.cs` |
| `BlvtInfoMarketDataError` | `Errors/BlvtInfoMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `BlvtUserLimitInfoUserDataRequest` | `Requests/Blvt/BlvtUserLimitInfoUserDataRequest.cs` |
| `SapiV1BlvtUserLimitResponse` | `Models/SapiV1BlvtUserLimitResponse.cs` |
| `BlvtUserLimitInfoUserDataError` | `Errors/BlvtUserLimitInfoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QuerySubscriptionRecordUserDataRequest` | `Requests/Blvt/QuerySubscriptionRecordUserDataRequest.cs` |
| `SapiV1BlvtSubscribeRecordResponse` | `Models/SapiV1BlvtSubscribeRecordResponse.cs` |
| `QuerySubscriptionRecordUserDataError` | `Errors/QuerySubscriptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `RedeemBlvtUserDataRequest` | `Requests/Blvt/RedeemBlvtUserDataRequest.cs` |
| `SapiV1BlvtRedeemResponse` | `Models/SapiV1BlvtRedeemResponse.cs` |
| `RedeemBlvtUserDataError` | `Errors/RedeemBlvtUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `RedemptionRecordUserDataRequest` | `Requests/Blvt/RedemptionRecordUserDataRequest.cs` |
| `SapiV1BlvtRedeemRecordResponse` | `Models/SapiV1BlvtRedeemRecordResponse.cs` |
| `RedemptionRecordUserDataError` | `Errors/RedemptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubscribeBlvtUserDataRequest` | `Requests/Blvt/SubscribeBlvtUserDataRequest.cs` |
| `SapiV1BlvtSubscribeResponse` | `Models/SapiV1BlvtSubscribeResponse.cs` |
| `SubscribeBlvtUserDataError` | `Errors/SubscribeBlvtUserDataError.cs` |
| `Error` | `Models/Error.cs` |

