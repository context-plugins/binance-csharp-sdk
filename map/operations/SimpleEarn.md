<!-- Generated file — do not edit; regenerated with the SDK. -->

# SimpleEarn — operations

Accessor: `client.SimpleEarn` · Source: `Api/SimpleEarn.cs` · 24 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCollateralRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCollateralRecordUserData(GetCollateralRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `productId` ← `ProductId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse`
- **Error**: `ApiException<GetCollateralRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCollateralRecordUserDataRequest` | `Requests/SimpleEarn/GetCollateralRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse` | `Models/SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse.cs` |
| `GetCollateralRecordUserDataError` | `Errors/GetCollateralRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexiblePersonalLeftQuotaUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexiblePersonalLeftQuotaUserData(GetFlexiblePersonalLeftQuotaUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `productId` ← `ProductId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse`
- **Error**: `ApiException<GetFlexiblePersonalLeftQuotaUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFlexiblePersonalLeftQuotaUserDataRequest` | `Requests/SimpleEarn/GetFlexiblePersonalLeftQuotaUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse` | `Models/SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse.cs` |
| `GetFlexiblePersonalLeftQuotaUserDataError` | `Errors/GetFlexiblePersonalLeftQuotaUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleProductPositionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleProductPositionUserData(GetFlexibleProductPositionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `productId` ← `ProductId`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexiblePositionResponse`
- **Error**: `ApiException<GetFlexibleProductPositionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFlexibleProductPositionUserDataRequest` | `Requests/SimpleEarn/GetFlexibleProductPositionUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexiblePositionResponse` | `Models/SapiV1SimpleEarnFlexiblePositionResponse.cs` |
| `GetFlexibleProductPositionUserDataError` | `Errors/GetFlexibleProductPositionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleRedemptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleRedemptionRecordUserData(GetFlexibleRedemptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `productId` ← `ProductId`, `redeemId` ← `RedeemId`, `asset` ← `Asset`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`
- **Returns**: `SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse`
- **Error**: `ApiException<GetFlexibleRedemptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFlexibleRedemptionRecordUserDataRequest` | `Requests/SimpleEarn/GetFlexibleRedemptionRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse` | `Models/SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse.cs` |
| `GetFlexibleRedemptionRecordUserDataError` | `Errors/GetFlexibleRedemptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleRewardsHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleRewardsHistoryUserData(GetFlexibleRewardsHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Type`
- **Query params (wire ← C#)**: `type` ← `Type`, `productId` ← `ProductId`, `asset` ← `Asset`, `startTime` ← `StartTime`, `endTime` ← `EndTime`
- **Returns**: `SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse`
- **Error**: `ApiException<GetFlexibleRewardsHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFlexibleRewardsHistoryUserDataRequest` | `Requests/SimpleEarn/GetFlexibleRewardsHistoryUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse` | `Models/SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse.cs` |
| `GetFlexibleRewardsHistoryUserDataError` | `Errors/GetFlexibleRewardsHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleSubscriptionPreviewUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleSubscriptionPreviewUserData(GetFlexibleSubscriptionPreviewUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `productId` ← `ProductId`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse`
- **Error**: `ApiException<GetFlexibleSubscriptionPreviewUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFlexibleSubscriptionPreviewUserDataRequest` | `Requests/SimpleEarn/GetFlexibleSubscriptionPreviewUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse` | `Models/SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse.cs` |
| `GetFlexibleSubscriptionPreviewUserDataError` | `Errors/GetFlexibleSubscriptionPreviewUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleSubscriptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleSubscriptionRecordUserData(GetFlexibleSubscriptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `productId` ← `ProductId`, `purchaseId` ← `PurchaseId`, `asset` ← `Asset`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse`
- **Error**: `ApiException<GetFlexibleSubscriptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFlexibleSubscriptionRecordUserDataRequest` | `Requests/SimpleEarn/GetFlexibleSubscriptionRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse` | `Models/SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse.cs` |
| `GetFlexibleSubscriptionRecordUserDataError` | `Errors/GetFlexibleSubscriptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedPersonalLeftQuotaUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedPersonalLeftQuotaUserData(GetLockedPersonalLeftQuotaUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `projectId` ← `ProjectId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedPersonalLeftQuotaResponse`
- **Error**: `ApiException<GetLockedPersonalLeftQuotaUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLockedPersonalLeftQuotaUserDataRequest` | `Requests/SimpleEarn/GetLockedPersonalLeftQuotaUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedPersonalLeftQuotaResponse` | `Models/SapiV1SimpleEarnLockedPersonalLeftQuotaResponse.cs` |
| `GetLockedPersonalLeftQuotaUserDataError` | `Errors/GetLockedPersonalLeftQuotaUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedProductPositionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedProductPositionUserData(GetLockedProductPositionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `positionId` ← `PositionId`, `projectId` ← `ProjectId`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedPositionResponse`
- **Error**: `ApiException<GetLockedProductPositionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLockedProductPositionUserDataRequest` | `Requests/SimpleEarn/GetLockedProductPositionUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedPositionResponse` | `Models/SapiV1SimpleEarnLockedPositionResponse.cs` |
| `GetLockedProductPositionUserDataError` | `Errors/GetLockedProductPositionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedRedemptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedRedemptionRecordUserData(GetLockedRedemptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `positionId` ← `PositionId`, `redeemId` ← `RedeemId`, `asset` ← `Asset`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse`
- **Error**: `ApiException<GetLockedRedemptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLockedRedemptionRecordUserDataRequest` | `Requests/SimpleEarn/GetLockedRedemptionRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse` | `Models/SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse.cs` |
| `GetLockedRedemptionRecordUserDataError` | `Errors/GetLockedRedemptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedRewardsHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedRewardsHistoryUserData(GetLockedRewardsHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `positionId` ← `PositionId`, `asset` ← `Asset`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedHistoryRewardsRecordResponse`
- **Error**: `ApiException<GetLockedRewardsHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLockedRewardsHistoryUserDataRequest` | `Requests/SimpleEarn/GetLockedRewardsHistoryUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedHistoryRewardsRecordResponse` | `Models/SapiV1SimpleEarnLockedHistoryRewardsRecordResponse.cs` |
| `GetLockedRewardsHistoryUserDataError` | `Errors/GetLockedRewardsHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedSubscriptionPreviewUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedSubscriptionPreviewUserData(GetLockedSubscriptionPreviewUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `projectId` ← `ProjectId`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `autoSubscribe` ← `AutoSubscribe`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1SimpleEarnLockedSubscriptionPreviewResponse>`
- **Error**: `ApiException<GetLockedSubscriptionPreviewUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLockedSubscriptionPreviewUserDataRequest` | `Requests/SimpleEarn/GetLockedSubscriptionPreviewUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedSubscriptionPreviewResponse` | `Models/SapiV1SimpleEarnLockedSubscriptionPreviewResponse.cs` |
| `GetLockedSubscriptionPreviewUserDataError` | `Errors/GetLockedSubscriptionPreviewUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLockedSubscriptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLockedSubscriptionRecordUserData(GetLockedSubscriptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `purchaseId` ← `PurchaseId`, `asset` ← `Asset`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse`
- **Error**: `ApiException<GetLockedSubscriptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLockedSubscriptionRecordUserDataRequest` | `Requests/SimpleEarn/GetLockedSubscriptionRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse` | `Models/SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse.cs` |
| `GetLockedSubscriptionRecordUserDataError` | `Errors/GetLockedSubscriptionRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetRateHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetRateHistoryUserData(GetRateHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `productId` ← `ProductId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse`
- **Error**: `ApiException<GetRateHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRateHistoryUserDataRequest` | `Requests/SimpleEarn/GetRateHistoryUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse` | `Models/SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse.cs` |
| `GetRateHistoryUserDataError` | `Errors/GetRateHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetSimpleEarnFlexibleProductListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSimpleEarnFlexibleProductListUserData(GetSimpleEarnFlexibleProductListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleListResponse`
- **Error**: `ApiException<GetSimpleEarnFlexibleProductListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSimpleEarnFlexibleProductListUserDataRequest` | `Requests/SimpleEarn/GetSimpleEarnFlexibleProductListUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleListResponse` | `Models/SapiV1SimpleEarnFlexibleListResponse.cs` |
| `GetSimpleEarnFlexibleProductListUserDataError` | `Errors/GetSimpleEarnFlexibleProductListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetSimpleEarnLockedProductListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSimpleEarnLockedProductListUserData(GetSimpleEarnLockedProductListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedListResponse`
- **Error**: `ApiException<GetSimpleEarnLockedProductListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSimpleEarnLockedProductListUserDataRequest` | `Requests/SimpleEarn/GetSimpleEarnLockedProductListUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedListResponse` | `Models/SapiV1SimpleEarnLockedListResponse.cs` |
| `GetSimpleEarnLockedProductListUserDataError` | `Errors/GetSimpleEarnLockedProductListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RedeemFlexibleProductTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedeemFlexibleProductTrade(RedeemFlexibleProductTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `productId` ← `ProductId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `redeemAll` ← `RedeemAll`, `amount` ← `Amount`, `destAccount` ← `DestAccount`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleRedeemResponse`
- **Error**: `ApiException<RedeemFlexibleProductTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RedeemFlexibleProductTradeRequest` | `Requests/SimpleEarn/RedeemFlexibleProductTradeRequest.cs` |
| `SapiV1SimpleEarnFlexibleRedeemResponse` | `Models/SapiV1SimpleEarnFlexibleRedeemResponse.cs` |
| `RedeemFlexibleProductTradeError` | `Errors/RedeemFlexibleProductTradeError.cs` |
| `Error` | `Models/Error.cs` |

### RedeemLockedProductTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedeemLockedProductTrade(RedeemLockedProductTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PositionId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `positionId` ← `PositionId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedRedeemResponse`
- **Error**: `ApiException<RedeemLockedProductTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RedeemLockedProductTradeRequest` | `Requests/SimpleEarn/RedeemLockedProductTradeRequest.cs` |
| `SapiV1SimpleEarnLockedRedeemResponse` | `Models/SapiV1SimpleEarnLockedRedeemResponse.cs` |
| `RedeemLockedProductTradeError` | `Errors/RedeemLockedProductTradeError.cs` |
| `Error` | `Models/Error.cs` |

### SetFlexibleAutoSubscribeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SetFlexibleAutoSubscribeUserData(SetFlexibleAutoSubscribeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `AutoSubscribe`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `productId` ← `ProductId`, `autoSubscribe` ← `AutoSubscribe`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse`
- **Error**: `ApiException<SetFlexibleAutoSubscribeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SetFlexibleAutoSubscribeUserDataRequest` | `Requests/SimpleEarn/SetFlexibleAutoSubscribeUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse` | `Models/SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse.cs` |
| `SetFlexibleAutoSubscribeUserDataError` | `Errors/SetFlexibleAutoSubscribeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SetLockedAutoSubscribeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SetLockedAutoSubscribeUserData(SetLockedAutoSubscribeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PositionId`, `AutoSubscribe`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `positionId` ← `PositionId`, `autoSubscribe` ← `AutoSubscribe`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedSetAutoSubscribeResponse`
- **Error**: `ApiException<SetLockedAutoSubscribeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SetLockedAutoSubscribeUserDataRequest` | `Requests/SimpleEarn/SetLockedAutoSubscribeUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedSetAutoSubscribeResponse` | `Models/SapiV1SimpleEarnLockedSetAutoSubscribeResponse.cs` |
| `SetLockedAutoSubscribeUserDataError` | `Errors/SetLockedAutoSubscribeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SetLockedProductRedeemOptionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SetLockedProductRedeemOptionUserData(SetLockedProductRedeemOptionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PositionId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `positionId` ← `PositionId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `redeemTo` ← `RedeemTo`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedSetRedeemOptionResponse`
- **Error**: `ApiException<SetLockedProductRedeemOptionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SetLockedProductRedeemOptionUserDataRequest` | `Requests/SimpleEarn/SetLockedProductRedeemOptionUserDataRequest.cs` |
| `RedeemTo` | `Models/Enums/RedeemTo.cs` |
| `SapiV1SimpleEarnLockedSetRedeemOptionResponse` | `Models/SapiV1SimpleEarnLockedSetRedeemOptionResponse.cs` |
| `SetLockedProductRedeemOptionUserDataError` | `Errors/SetLockedProductRedeemOptionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SimpleAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SimpleAccountUserData(SimpleAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnAccountResponse`
- **Error**: `ApiException<SimpleAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SimpleAccountUserDataRequest` | `Requests/SimpleEarn/SimpleAccountUserDataRequest.cs` |
| `SapiV1SimpleEarnAccountResponse` | `Models/SapiV1SimpleEarnAccountResponse.cs` |
| `SimpleAccountUserDataError` | `Errors/SimpleAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeFlexibleProductTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubscribeFlexibleProductTrade(SubscribeFlexibleProductTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `productId` ← `ProductId`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `autoSubscribe` ← `AutoSubscribe`, `sourceAccount` ← `SourceAccount`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnFlexibleSubscribeResponse`
- **Error**: `ApiException<SubscribeFlexibleProductTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubscribeFlexibleProductTradeRequest` | `Requests/SimpleEarn/SubscribeFlexibleProductTradeRequest.cs` |
| `SapiV1SimpleEarnFlexibleSubscribeResponse` | `Models/SapiV1SimpleEarnFlexibleSubscribeResponse.cs` |
| `SubscribeFlexibleProductTradeError` | `Errors/SubscribeFlexibleProductTradeError.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeLockedProductTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubscribeLockedProductTrade(SubscribeLockedProductTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `projectId` ← `ProjectId`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `autoSubscribe` ← `AutoSubscribe`, `sourceAccount` ← `SourceAccount`, `redeemTo` ← `RedeemTo`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SimpleEarnLockedSubscribeResponse`
- **Error**: `ApiException<SubscribeLockedProductTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubscribeLockedProductTradeRequest` | `Requests/SimpleEarn/SubscribeLockedProductTradeRequest.cs` |
| `RedeemTo` | `Models/Enums/RedeemTo.cs` |
| `SapiV1SimpleEarnLockedSubscribeResponse` | `Models/SapiV1SimpleEarnLockedSubscribeResponse.cs` |
| `SubscribeLockedProductTradeError` | `Errors/SubscribeLockedProductTradeError.cs` |
| `Error` | `Models/Error.cs` |

