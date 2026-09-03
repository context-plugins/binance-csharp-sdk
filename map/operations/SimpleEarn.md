<!-- Generated file — do not edit; regenerated with the SDK. -->

# SimpleEarn — operations

Accessor: `client.SimpleEarn` · Source: `Api/SimpleEarn.cs` · 24 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCollateralRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCollateralRecordUserData(long timestamp, string signature, string? productId, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`productId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `productId` ← `productId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse`
- **Error**: `SdkException<GetCollateralRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse` | `Models/SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse.cs` |
| `GetCollateralRecordUserDataError` | `Errors/GetCollateralRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexiblePersonalLeftQuotaUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexiblePersonalLeftQuotaUserData(string productId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `productId` ← `productId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse`
- **Error**: `SdkException<GetFlexiblePersonalLeftQuotaUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse` | `Models/SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse.cs` |
| `GetFlexiblePersonalLeftQuotaUserDataError` | `Errors/GetFlexiblePersonalLeftQuotaUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleProductPositionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleProductPositionUserData(long timestamp, string signature, string? asset, string? productId, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `productId` ← `productId`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexiblePositionResponse`
- **Error**: `SdkException<GetFlexibleProductPositionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexiblePositionResponse` | `Models/SapiV1SimpleEarnFlexiblePositionResponse.cs` |
| `GetFlexibleProductPositionUserDataError` | `Errors/GetFlexibleProductPositionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleRedemptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleRedemptionRecordUserData(string? productId, string? redeemId, string? asset, long? startTime, long? endTime, int? current, int? size, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`productId` … `size`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `productId` ← `productId`, `redeemId` ← `redeemId`, `asset` ← `asset`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`
- **Returns**: `SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse`
- **Error**: `SdkException<GetFlexibleRedemptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse` | `Models/SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse.cs` |
| `GetFlexibleRedemptionRecordUserDataError` | `Errors/GetFlexibleRedemptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleRewardsHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleRewardsHistoryUserData(string type, string? productId, string? asset, long? startTime, long? endTime, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`productId` … `endTime`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `type` ← `type`, `productId` ← `productId`, `asset` ← `asset`, `startTime` ← `startTime`, `endTime` ← `endTime`
- **Returns**: `SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse`
- **Error**: `SdkException<GetFlexibleRewardsHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse` | `Models/SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse.cs` |
| `GetFlexibleRewardsHistoryUserDataError` | `Errors/GetFlexibleRewardsHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleSubscriptionPreviewUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleSubscriptionPreviewUserData(string productId, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `productId` ← `productId`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse`
- **Error**: `SdkException<GetFlexibleSubscriptionPreviewUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse` | `Models/SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse.cs` |
| `GetFlexibleSubscriptionPreviewUserDataError` | `Errors/GetFlexibleSubscriptionPreviewUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleSubscriptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleSubscriptionRecordUserData(long timestamp, string signature, string? productId, string? purchaseId, string? asset, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`productId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `productId` ← `productId`, `purchaseId` ← `purchaseId`, `asset` ← `asset`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse`
- **Error**: `SdkException<GetFlexibleSubscriptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse` | `Models/SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse.cs` |
| `GetFlexibleSubscriptionRecordUserDataError` | `Errors/GetFlexibleSubscriptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedPersonalLeftQuotaUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedPersonalLeftQuotaUserData(string projectId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `projectId` ← `projectId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedPersonalLeftQuotaResponse`
- **Error**: `SdkException<GetLockedPersonalLeftQuotaUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnLockedPersonalLeftQuotaResponse` | `Models/SapiV1SimpleEarnLockedPersonalLeftQuotaResponse.cs` |
| `GetLockedPersonalLeftQuotaUserDataError` | `Errors/GetLockedPersonalLeftQuotaUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedProductPositionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedProductPositionUserData(long timestamp, string signature, string? asset, string? positionId, string? projectId, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `positionId` ← `positionId`, `projectId` ← `projectId`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedPositionResponse`
- **Error**: `SdkException<GetLockedProductPositionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnLockedPositionResponse` | `Models/SapiV1SimpleEarnLockedPositionResponse.cs` |
| `GetLockedProductPositionUserDataError` | `Errors/GetLockedProductPositionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedRedemptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedRedemptionRecordUserData(long timestamp, string signature, string? positionId, string? redeemId, string? asset, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`positionId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `positionId` ← `positionId`, `redeemId` ← `redeemId`, `asset` ← `asset`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse`
- **Error**: `SdkException<GetLockedRedemptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse` | `Models/SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse.cs` |
| `GetLockedRedemptionRecordUserDataError` | `Errors/GetLockedRedemptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedRewardsHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedRewardsHistoryUserData(long timestamp, string signature, string? positionId, string? asset, long? startTime, long? endTime, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`positionId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `positionId` ← `positionId`, `asset` ← `asset`, `startTime` ← `startTime`, `endTime` ← `endTime`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedHistoryRewardsRecordResponse`
- **Error**: `SdkException<GetLockedRewardsHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnLockedHistoryRewardsRecordResponse` | `Models/SapiV1SimpleEarnLockedHistoryRewardsRecordResponse.cs` |
| `GetLockedRewardsHistoryUserDataError` | `Errors/GetLockedRewardsHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedSubscriptionPreviewUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedSubscriptionPreviewUserData(string projectId, double amount, long timestamp, string signature, bool? autoSubscribe, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `autoSubscribe` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `projectId` ← `projectId`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `autoSubscribe` ← `autoSubscribe`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1SimpleEarnLockedSubscriptionPreviewResponse>`
- **Error**: `SdkException<GetLockedSubscriptionPreviewUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnLockedSubscriptionPreviewResponse` | `Models/SapiV1SimpleEarnLockedSubscriptionPreviewResponse.cs` |
| `GetLockedSubscriptionPreviewUserDataError` | `Errors/GetLockedSubscriptionPreviewUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedSubscriptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedSubscriptionRecordUserData(long timestamp, string signature, string? purchaseId, string? asset, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`purchaseId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `purchaseId` ← `purchaseId`, `asset` ← `asset`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse`
- **Error**: `SdkException<GetLockedSubscriptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse` | `Models/SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse.cs` |
| `GetLockedSubscriptionRecordUserDataError` | `Errors/GetLockedSubscriptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetRateHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetRateHistoryUserData(string productId, long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `productId` ← `productId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse`
- **Error**: `SdkException<GetRateHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse` | `Models/SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse.cs` |
| `GetRateHistoryUserDataError` | `Errors/GetRateHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetSimpleEarnFlexibleProductListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSimpleEarnFlexibleProductListUserData(long timestamp, string signature, string? asset, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleListResponse`
- **Error**: `SdkException<GetSimpleEarnFlexibleProductListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleListResponse` | `Models/SapiV1SimpleEarnFlexibleListResponse.cs` |
| `GetSimpleEarnFlexibleProductListUserDataError` | `Errors/GetSimpleEarnFlexibleProductListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetSimpleEarnLockedProductListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSimpleEarnLockedProductListUserData(long timestamp, string signature, string? asset, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedListResponse`
- **Error**: `SdkException<GetSimpleEarnLockedProductListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnLockedListResponse` | `Models/SapiV1SimpleEarnLockedListResponse.cs` |
| `GetSimpleEarnLockedProductListUserDataError` | `Errors/GetSimpleEarnLockedProductListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RedeemFlexibleProductTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedeemFlexibleProductTrade(string productId, long timestamp, string signature, bool? redeemAll, double? amount, string? destAccount, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`redeemAll` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `productId` ← `productId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `redeemAll` ← `redeemAll`, `amount` ← `amount`, `destAccount` ← `destAccount`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleRedeemResponse`
- **Error**: `SdkException<RedeemFlexibleProductTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleRedeemResponse` | `Models/SapiV1SimpleEarnFlexibleRedeemResponse.cs` |
| `RedeemFlexibleProductTradeError` | `Errors/RedeemFlexibleProductTradeError.cs` |
| `Error` | `Models/Error.cs` |

### RedeemLockedProductTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedeemLockedProductTrade(string positionId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `positionId` ← `positionId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedRedeemResponse`
- **Error**: `SdkException<RedeemLockedProductTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnLockedRedeemResponse` | `Models/SapiV1SimpleEarnLockedRedeemResponse.cs` |
| `RedeemLockedProductTradeError` | `Errors/RedeemLockedProductTradeError.cs` |
| `Error` | `Models/Error.cs` |

### SetFlexibleAutoSubscribeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SetFlexibleAutoSubscribeUserData(string productId, bool autoSubscribe, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `productId` ← `productId`, `autoSubscribe` ← `autoSubscribe`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse`
- **Error**: `SdkException<SetFlexibleAutoSubscribeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse` | `Models/SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse.cs` |
| `SetFlexibleAutoSubscribeUserDataError` | `Errors/SetFlexibleAutoSubscribeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SetLockedAutoSubscribeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SetLockedAutoSubscribeUserData(string positionId, bool autoSubscribe, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `positionId` ← `positionId`, `autoSubscribe` ← `autoSubscribe`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedSetAutoSubscribeResponse`
- **Error**: `SdkException<SetLockedAutoSubscribeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnLockedSetAutoSubscribeResponse` | `Models/SapiV1SimpleEarnLockedSetAutoSubscribeResponse.cs` |
| `SetLockedAutoSubscribeUserDataError` | `Errors/SetLockedAutoSubscribeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SetLockedProductRedeemOptionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SetLockedProductRedeemOptionUserData(string positionId, long timestamp, string signature, RedeemTo? redeemTo, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `redeemTo` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `positionId` ← `positionId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `redeemTo` ← `redeemTo`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedSetRedeemOptionResponse`
- **Error**: `SdkException<SetLockedProductRedeemOptionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RedeemTo` | `Models/Enums/RedeemTo.cs` |
| `SapiV1SimpleEarnLockedSetRedeemOptionResponse` | `Models/SapiV1SimpleEarnLockedSetRedeemOptionResponse.cs` |
| `SetLockedProductRedeemOptionUserDataError` | `Errors/SetLockedProductRedeemOptionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SimpleAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SimpleAccountUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnAccountResponse`
- **Error**: `SdkException<SimpleAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnAccountResponse` | `Models/SapiV1SimpleEarnAccountResponse.cs` |
| `SimpleAccountUserDataError` | `Errors/SimpleAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeFlexibleProductTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubscribeFlexibleProductTrade(string productId, double amount, long timestamp, string signature, bool? autoSubscribe, string? sourceAccount, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `autoSubscribe` — nullable, no default → **must pass explicitly**
  - `sourceAccount` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `productId` ← `productId`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `autoSubscribe` ← `autoSubscribe`, `sourceAccount` ← `sourceAccount`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleSubscribeResponse`
- **Error**: `SdkException<SubscribeFlexibleProductTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SimpleEarnFlexibleSubscribeResponse` | `Models/SapiV1SimpleEarnFlexibleSubscribeResponse.cs` |
| `SubscribeFlexibleProductTradeError` | `Errors/SubscribeFlexibleProductTradeError.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeLockedProductTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubscribeLockedProductTrade(string projectId, double amount, long timestamp, string signature, bool? autoSubscribe, string? sourceAccount, RedeemTo? redeemTo, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`autoSubscribe` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `projectId` ← `projectId`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `autoSubscribe` ← `autoSubscribe`, `sourceAccount` ← `sourceAccount`, `redeemTo` ← `redeemTo`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SimpleEarnLockedSubscribeResponse`
- **Error**: `SdkException<SubscribeLockedProductTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RedeemTo` | `Models/Enums/RedeemTo.cs` |
| `SapiV1SimpleEarnLockedSubscribeResponse` | `Models/SapiV1SimpleEarnLockedSubscribeResponse.cs` |
| `SubscribeLockedProductTradeError` | `Errors/SubscribeLockedProductTradeError.cs` |
| `Error` | `Models/Error.cs` |

