<!-- Generated file — do not edit; regenerated with the SDK. -->

# Blvt — operations

Accessor: `client.Blvt` · Source: `Api/Blvt.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BlvtInfoMarketData

- **Signature**: `BlvtInfoMarketData(string? tokenName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `tokenName` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `tokenName` ← `tokenName`
- **Returns**: `IReadOnlyList<SapiV1BlvtTokenInfoResponse>`
- **Error**: `SdkException<BlvtInfoMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1BlvtTokenInfoResponse` | `Models/SapiV1BlvtTokenInfoResponse.cs` |
| `BlvtInfoMarketDataError` | `Errors/BlvtInfoMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### BlvtUserLimitInfoUserData

- **Signature**: `BlvtUserLimitInfoUserData(long timestamp, string signature, string? tokenName, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `tokenName` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `tokenName` ← `tokenName`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1BlvtUserLimitResponse>`
- **Error**: `SdkException<BlvtUserLimitInfoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1BlvtUserLimitResponse` | `Models/SapiV1BlvtUserLimitResponse.cs` |
| `BlvtUserLimitInfoUserDataError` | `Errors/BlvtUserLimitInfoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubscriptionRecordUserData

- **Signature**: `QuerySubscriptionRecordUserData(long timestamp, string signature, string? tokenName, long? id, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`tokenName` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `tokenName` ← `tokenName`, `id` ← `id`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1BlvtSubscribeRecordResponse`
- **Error**: `SdkException<QuerySubscriptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1BlvtSubscribeRecordResponse` | `Models/SapiV1BlvtSubscribeRecordResponse.cs` |
| `QuerySubscriptionRecordUserDataError` | `Errors/QuerySubscriptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RedeemBlvtUserData

- **Signature**: `RedeemBlvtUserData(string tokenName, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `tokenName` ← `tokenName`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1BlvtRedeemResponse`
- **Error**: `SdkException<RedeemBlvtUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1BlvtRedeemResponse` | `Models/SapiV1BlvtRedeemResponse.cs` |
| `RedeemBlvtUserDataError` | `Errors/RedeemBlvtUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RedemptionRecordUserData

- **Signature**: `RedemptionRecordUserData(long timestamp, string signature, string? tokenName, long? id, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`tokenName` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `tokenName` ← `tokenName`, `id` ← `id`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1BlvtRedeemRecordResponse>`
- **Error**: `SdkException<RedemptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1BlvtRedeemRecordResponse` | `Models/SapiV1BlvtRedeemRecordResponse.cs` |
| `RedemptionRecordUserDataError` | `Errors/RedemptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeBlvtUserData

- **Signature**: `SubscribeBlvtUserData(string tokenName, double cost, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `tokenName` ← `tokenName`, `cost` ← `cost`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1BlvtSubscribeResponse`
- **Error**: `SdkException<SubscribeBlvtUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1BlvtSubscribeResponse` | `Models/SapiV1BlvtSubscribeResponse.cs` |
| `SubscribeBlvtUserDataError` | `Errors/SubscribeBlvtUserDataError.cs` |
| `Error` | `Models/Error.cs` |

