<!-- Generated file — do not edit; regenerated with the SDK. -->

# SimpleEarn — operations

Accessor: `client.SimpleEarn` · Source: `src/Binance/Api/SimpleEarn.cs` · 24 operations

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
| `GetCollateralRecordUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetCollateralRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse.cs` |
| `GetCollateralRecordUserDataError` | `src/Binance/Errors/GetCollateralRecordUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetFlexiblePersonalLeftQuotaUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetFlexiblePersonalLeftQuotaUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse.cs` |
| `GetFlexiblePersonalLeftQuotaUserDataError` | `src/Binance/Errors/GetFlexiblePersonalLeftQuotaUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetFlexibleProductPositionUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetFlexibleProductPositionUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexiblePositionResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexiblePositionResponse.cs` |
| `GetFlexibleProductPositionUserDataError` | `src/Binance/Errors/GetFlexibleProductPositionUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetFlexibleRedemptionRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleRedemptionRecordUserData(GetFlexibleRedemptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `productId` ← `ProductId`, `redeemId` ← `RedeemId`, `asset` ← `Asset`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`
- **Returns**: `SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse`
- **Error**: `ApiException<GetFlexibleRedemptionRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFlexibleRedemptionRecordUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetFlexibleRedemptionRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse.cs` |
| `GetFlexibleRedemptionRecordUserDataError` | `src/Binance/Errors/GetFlexibleRedemptionRecordUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetFlexibleRewardsHistoryUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetFlexibleRewardsHistoryUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse.cs` |
| `GetFlexibleRewardsHistoryUserDataError` | `src/Binance/Errors/GetFlexibleRewardsHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetFlexibleSubscriptionPreviewUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetFlexibleSubscriptionPreviewUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse.cs` |
| `GetFlexibleSubscriptionPreviewUserDataError` | `src/Binance/Errors/GetFlexibleSubscriptionPreviewUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetFlexibleSubscriptionRecordUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetFlexibleSubscriptionRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse.cs` |
| `GetFlexibleSubscriptionRecordUserDataError` | `src/Binance/Errors/GetFlexibleSubscriptionRecordUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLockedPersonalLeftQuotaUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetLockedPersonalLeftQuotaUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedPersonalLeftQuotaResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedPersonalLeftQuotaResponse.cs` |
| `GetLockedPersonalLeftQuotaUserDataError` | `src/Binance/Errors/GetLockedPersonalLeftQuotaUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLockedProductPositionUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetLockedProductPositionUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedPositionResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedPositionResponse.cs` |
| `GetLockedProductPositionUserDataError` | `src/Binance/Errors/GetLockedProductPositionUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLockedRedemptionRecordUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetLockedRedemptionRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse.cs` |
| `GetLockedRedemptionRecordUserDataError` | `src/Binance/Errors/GetLockedRedemptionRecordUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLockedRewardsHistoryUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetLockedRewardsHistoryUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedHistoryRewardsRecordResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedHistoryRewardsRecordResponse.cs` |
| `GetLockedRewardsHistoryUserDataError` | `src/Binance/Errors/GetLockedRewardsHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLockedSubscriptionPreviewUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetLockedSubscriptionPreviewUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedSubscriptionPreviewResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedSubscriptionPreviewResponse.cs` |
| `GetLockedSubscriptionPreviewUserDataError` | `src/Binance/Errors/GetLockedSubscriptionPreviewUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLockedSubscriptionRecordUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetLockedSubscriptionRecordUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse.cs` |
| `GetLockedSubscriptionRecordUserDataError` | `src/Binance/Errors/GetLockedSubscriptionRecordUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetRateHistoryUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetRateHistoryUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse.cs` |
| `GetRateHistoryUserDataError` | `src/Binance/Errors/GetRateHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetSimpleEarnFlexibleProductListUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetSimpleEarnFlexibleProductListUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleListResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleListResponse.cs` |
| `GetSimpleEarnFlexibleProductListUserDataError` | `src/Binance/Errors/GetSimpleEarnFlexibleProductListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetSimpleEarnLockedProductListUserDataRequest` | `src/Binance/Requests/SimpleEarn/GetSimpleEarnLockedProductListUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedListResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedListResponse.cs` |
| `GetSimpleEarnLockedProductListUserDataError` | `src/Binance/Errors/GetSimpleEarnLockedProductListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `RedeemFlexibleProductTradeRequest` | `src/Binance/Requests/SimpleEarn/RedeemFlexibleProductTradeRequest.cs` |
| `SapiV1SimpleEarnFlexibleRedeemResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleRedeemResponse.cs` |
| `RedeemFlexibleProductTradeError` | `src/Binance/Errors/RedeemFlexibleProductTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `RedeemLockedProductTradeRequest` | `src/Binance/Requests/SimpleEarn/RedeemLockedProductTradeRequest.cs` |
| `SapiV1SimpleEarnLockedRedeemResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedRedeemResponse.cs` |
| `RedeemLockedProductTradeError` | `src/Binance/Errors/RedeemLockedProductTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `SetFlexibleAutoSubscribeUserDataRequest` | `src/Binance/Requests/SimpleEarn/SetFlexibleAutoSubscribeUserDataRequest.cs` |
| `SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse.cs` |
| `SetFlexibleAutoSubscribeUserDataError` | `src/Binance/Errors/SetFlexibleAutoSubscribeUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `SetLockedAutoSubscribeUserDataRequest` | `src/Binance/Requests/SimpleEarn/SetLockedAutoSubscribeUserDataRequest.cs` |
| `SapiV1SimpleEarnLockedSetAutoSubscribeResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedSetAutoSubscribeResponse.cs` |
| `SetLockedAutoSubscribeUserDataError` | `src/Binance/Errors/SetLockedAutoSubscribeUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `SetLockedProductRedeemOptionUserDataRequest` | `src/Binance/Requests/SimpleEarn/SetLockedProductRedeemOptionUserDataRequest.cs` |
| `RedeemTo` | `src/Binance/Models/Enums/RedeemTo.cs` |
| `SapiV1SimpleEarnLockedSetRedeemOptionResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedSetRedeemOptionResponse.cs` |
| `SetLockedProductRedeemOptionUserDataError` | `src/Binance/Errors/SetLockedProductRedeemOptionUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `SimpleAccountUserDataRequest` | `src/Binance/Requests/SimpleEarn/SimpleAccountUserDataRequest.cs` |
| `SapiV1SimpleEarnAccountResponse` | `src/Binance/Models/SapiV1SimpleEarnAccountResponse.cs` |
| `SimpleAccountUserDataError` | `src/Binance/Errors/SimpleAccountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `SubscribeFlexibleProductTradeRequest` | `src/Binance/Requests/SimpleEarn/SubscribeFlexibleProductTradeRequest.cs` |
| `SapiV1SimpleEarnFlexibleSubscribeResponse` | `src/Binance/Models/SapiV1SimpleEarnFlexibleSubscribeResponse.cs` |
| `SubscribeFlexibleProductTradeError` | `src/Binance/Errors/SubscribeFlexibleProductTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `SubscribeLockedProductTradeRequest` | `src/Binance/Requests/SimpleEarn/SubscribeLockedProductTradeRequest.cs` |
| `RedeemTo` | `src/Binance/Models/Enums/RedeemTo.cs` |
| `SapiV1SimpleEarnLockedSubscribeResponse` | `src/Binance/Models/SapiV1SimpleEarnLockedSubscribeResponse.cs` |
| `SubscribeLockedProductTradeError` | `src/Binance/Errors/SubscribeLockedProductTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

