<!-- Generated file — do not edit; regenerated with the SDK. -->

# AutoInvest — operations

Accessor: `client.AutoInvest` · Source: `Api/AutoInvest.cs` · 17 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChangePlanStatus

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ChangePlanStatus(int planId, Status1 status, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `planId` ← `planId`, `status` ← `status`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanEditStatusResponse`
- **Error**: `SdkException<ChangePlanStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Status1` | `Models/Enums/Status1.cs` |
| `SapiV1LendingAutoInvestPlanEditStatusResponse` | `Models/SapiV1LendingAutoInvestPlanEditStatusResponse.cs` |
| `ChangePlanStatusError` | `Errors/ChangePlanStatusError.cs` |
| `Error` | `Models/Error.cs` |

### GetListOfPlans

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetListOfPlans(string planType, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `planType` ← `planType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanListResponse`
- **Error**: `SdkException<GetListOfPlansError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestPlanListResponse` | `Models/SapiV1LendingAutoInvestPlanListResponse.cs` |
| `GetListOfPlansError` | `Errors/GetListOfPlansError.cs` |
| `Error` | `Models/Error.cs` |

### GetTargetAssetListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetTargetAssetListUserData(long timestamp, string signature, string? targetAsset, int? size, int? current, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`targetAsset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `targetAsset` ← `targetAsset`, `size` ← `size`, `current` ← `current`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestTargetAssetListResponse`
- **Error**: `SdkException<GetTargetAssetListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestTargetAssetListResponse` | `Models/SapiV1LendingAutoInvestTargetAssetListResponse.cs` |
| `GetTargetAssetListUserDataError` | `Errors/GetTargetAssetListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetTargetAssetRoiDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetTargetAssetRoiDataUserData(string targetAsset, string hisRoiType, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `targetAsset` ← `targetAsset`, `hisRoiType` ← `hisRoiType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingAutoInvestTargetAssetRoiListResponse>`
- **Error**: `SdkException<GetTargetAssetRoiDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestTargetAssetRoiListResponse` | `Models/SapiV1LendingAutoInvestTargetAssetRoiListResponse.cs` |
| `GetTargetAssetRoiDataUserDataError` | `Errors/GetTargetAssetRoiDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### IndexLinkedPlanRebalanceDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `IndexLinkedPlanRebalanceDetailsUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingAutoInvestRebalanceHistoryResponse>`
- **Error**: `SdkException<IndexLinkedPlanRebalanceDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestRebalanceHistoryResponse` | `Models/SapiV1LendingAutoInvestRebalanceHistoryResponse.cs` |
| `IndexLinkedPlanRebalanceDetailsUserDataError` | `Errors/IndexLinkedPlanRebalanceDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### IndexLinkedPlanRedemptionHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `IndexLinkedPlanRedemptionHistoryUserData(long requestId, long timestamp, string signature, long? startTime, long? endTime, int? current, string? asset, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `requestId` ← `requestId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `asset` ← `asset`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingAutoInvestRedeemHistoryResponse>`
- **Error**: `SdkException<IndexLinkedPlanRedemptionHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestRedeemHistoryResponse` | `Models/SapiV1LendingAutoInvestRedeemHistoryResponse.cs` |
| `IndexLinkedPlanRedemptionHistoryUserDataError` | `Errors/IndexLinkedPlanRedemptionHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### IndexLinkedPlanRedemptionTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `IndexLinkedPlanRedemptionTrade(long indexId, int redemptionPercentage, long timestamp, string signature, string? requestId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `requestId` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `indexId` ← `indexId`, `redemptionPercentage` ← `redemptionPercentage`, `timestamp` ← `timestamp`, `signature` ← `signature`, `requestId` ← `requestId`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestRedeemResponse`
- **Error**: `SdkException<IndexLinkedPlanRedemptionTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestRedeemResponse` | `Models/SapiV1LendingAutoInvestRedeemResponse.cs` |
| `IndexLinkedPlanRedemptionTradeError` | `Errors/IndexLinkedPlanRedemptionTradeError.cs` |
| `Error` | `Models/Error.cs` |

### InvestmentPlanAdjustment

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `InvestmentPlanAdjustment(int planId, double subscriptionAmount, SubscriptionCycle subscriptionCycle, int subscriptionStartTime, string sourceAsset, long timestamp, string signature, int? subscriptionStartDay, SubscriptionStartWeekday? subscriptionStartWeekday, bool? flexibleAllowedToUse, IReadOnlyList<Detail1>? details, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`subscriptionStartDay` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `planId` ← `planId`, `subscriptionAmount` ← `subscriptionAmount`, `subscriptionCycle` ← `subscriptionCycle`, `subscriptionStartTime` ← `subscriptionStartTime`, `sourceAsset` ← `sourceAsset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `subscriptionStartDay` ← `subscriptionStartDay`, `subscriptionStartWeekday` ← `subscriptionStartWeekday`, `flexibleAllowedToUse` ← `flexibleAllowedToUse`, `details` ← `details`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanEditResponse`
- **Error**: `SdkException<InvestmentPlanAdjustmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubscriptionCycle` | `Models/Enums/SubscriptionCycle.cs` |
| `SubscriptionStartWeekday` | `Models/Enums/SubscriptionStartWeekday.cs` |
| `Detail1` | `Models/Detail1.cs` |
| `SapiV1LendingAutoInvestPlanEditResponse` | `Models/SapiV1LendingAutoInvestPlanEditResponse.cs` |
| `InvestmentPlanAdjustmentError` | `Errors/InvestmentPlanAdjustmentError.cs` |
| `Error` | `Models/Error.cs` |

### InvestmentPlanCreationUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `InvestmentPlanCreationUserData(SourceType sourceType, PlanType planType, double subscriptionAmount, SubscriptionCycle subscriptionCycle, int subscriptionStartTime, string sourceAsset, IReadOnlyList<Detail1> details, long timestamp, string signature, string? requestId, long? indexId, int? subscriptionStartDay, SubscriptionStartWeekday? subscriptionStartWeekday, bool? flexibleAllowedToUse, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`requestId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `sourceType` ← `sourceType`, `planType` ← `planType`, `subscriptionAmount` ← `subscriptionAmount`, `subscriptionCycle` ← `subscriptionCycle`, `subscriptionStartTime` ← `subscriptionStartTime`, `sourceAsset` ← `sourceAsset`, `details` ← `details`, `timestamp` ← `timestamp`, `signature` ← `signature`, `requestId` ← `requestId`, `IndexId` ← `indexId`, `subscriptionStartDay` ← `subscriptionStartDay`, `subscriptionStartWeekday` ← `subscriptionStartWeekday`, `flexibleAllowedToUse` ← `flexibleAllowedToUse`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanAddResponse`
- **Error**: `SdkException<InvestmentPlanCreationUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SourceType` | `Models/Enums/SourceType.cs` |
| `PlanType` | `Models/Enums/PlanType.cs` |
| `SubscriptionCycle` | `Models/Enums/SubscriptionCycle.cs` |
| `Detail1` | `Models/Detail1.cs` |
| `SubscriptionStartWeekday` | `Models/Enums/SubscriptionStartWeekday.cs` |
| `SapiV1LendingAutoInvestPlanAddResponse` | `Models/SapiV1LendingAutoInvestPlanAddResponse.cs` |
| `InvestmentPlanCreationUserDataError` | `Errors/InvestmentPlanCreationUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### OneTimeTransactionTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `OneTimeTransactionTrade(string sourceType, double subscriptionAmount, string sourceAsset, long timestamp, string signature, string? requestId, bool? flexibleAllowedToUse, long? planId, long? indexId, IReadOnlyList<Detail5>? details, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`requestId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `sourceType` ← `sourceType`, `subscriptionAmount` ← `subscriptionAmount`, `sourceAsset` ← `sourceAsset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `requestId` ← `requestId`, `flexibleAllowedToUse` ← `flexibleAllowedToUse`, `planId` ← `planId`, `indexId` ← `indexId`, `details` ← `details`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestOneOffResponse`
- **Error**: `SdkException<OneTimeTransactionTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Detail5` | `Models/Detail5.cs` |
| `SapiV1LendingAutoInvestOneOffResponse` | `Models/SapiV1LendingAutoInvestOneOffResponse.cs` |
| `OneTimeTransactionTradeError` | `Errors/OneTimeTransactionTradeError.cs` |
| `Error` | `Models/Error.cs` |

### QueryAllSourceAssetAndTargetAssetUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryAllSourceAssetAndTargetAssetUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestAllAssetResponse`
- **Error**: `SdkException<QueryAllSourceAssetAndTargetAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestAllAssetResponse` | `Models/SapiV1LendingAutoInvestAllAssetResponse.cs` |
| `QueryAllSourceAssetAndTargetAssetUserDataError` | `Errors/QueryAllSourceAssetAndTargetAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryHoldingDetailsOfThePlan

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryHoldingDetailsOfThePlan(long timestamp, string signature, long? planId, string? requestId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `planId` — nullable, no default → **must pass explicitly**
  - `requestId` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `planId` ← `planId`, `requestId` ← `requestId`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanIdResponse`
- **Error**: `SdkException<QueryHoldingDetailsOfThePlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestPlanIdResponse` | `Models/SapiV1LendingAutoInvestPlanIdResponse.cs` |
| `QueryHoldingDetailsOfThePlanError` | `Errors/QueryHoldingDetailsOfThePlanError.cs` |
| `Error` | `Models/Error.cs` |

### QueryIndexDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIndexDetailsUserData(long indexId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `indexId` ← `indexId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestIndexInfoResponse`
- **Error**: `SdkException<QueryIndexDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestIndexInfoResponse` | `Models/SapiV1LendingAutoInvestIndexInfoResponse.cs` |
| `QueryIndexDetailsUserDataError` | `Errors/QueryIndexDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryIndexLinkedPlanPositionDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIndexLinkedPlanPositionDetailsUserData(long indexId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `indexId` ← `indexId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestIndexUserSummaryResponse`
- **Error**: `SdkException<QueryIndexLinkedPlanPositionDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestIndexUserSummaryResponse` | `Models/SapiV1LendingAutoInvestIndexUserSummaryResponse.cs` |
| `QueryIndexLinkedPlanPositionDetailsUserDataError` | `Errors/QueryIndexLinkedPlanPositionDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryOneTimeTransactionStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOneTimeTransactionStatusUserData(long transactionId, long timestamp, string signature, string? requestId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `requestId` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `transactionId` ← `transactionId`, `timestamp` ← `timestamp`, `signature` ← `signature`, `requestId` ← `requestId`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestOneOffStatusResponse`
- **Error**: `SdkException<QueryOneTimeTransactionStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestOneOffStatusResponse` | `Models/SapiV1LendingAutoInvestOneOffStatusResponse.cs` |
| `QueryOneTimeTransactionStatusUserDataError` | `Errors/QueryOneTimeTransactionStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySourceAssetListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySourceAssetListUserData(string usageType, long timestamp, string signature, string? targetAsset, long? indexId, bool? flexibleAllowedToUse, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`targetAsset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `usageType` ← `usageType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `targetAsset` ← `targetAsset`, `indexId` ← `indexId`, `flexibleAllowedToUse` ← `flexibleAllowedToUse`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LendingAutoInvestSourceAssetListResponse`
- **Error**: `SdkException<QuerySourceAssetListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LendingAutoInvestSourceAssetListResponse` | `Models/SapiV1LendingAutoInvestSourceAssetListResponse.cs` |
| `QuerySourceAssetListUserDataError` | `Errors/QuerySourceAssetListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubscriptionTransactionHistory

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubscriptionTransactionHistory(long timestamp, string signature, long? planId, long? startTime, long? endTime, long? targetAsset, PlanType1? planType, int? size, int? current, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`planId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `planId` ← `planId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `targetAsset` ← `targetAsset`, `planType` ← `planType`, `size` ← `size`, `current` ← `current`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingAutoInvestHistoryListResponse>`
- **Error**: `SdkException<QuerySubscriptionTransactionHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PlanType1` | `Models/Enums/PlanType1.cs` |
| `SapiV1LendingAutoInvestHistoryListResponse` | `Models/SapiV1LendingAutoInvestHistoryListResponse.cs` |
| `QuerySubscriptionTransactionHistoryError` | `Errors/QuerySubscriptionTransactionHistoryError.cs` |
| `Error` | `Models/Error.cs` |

