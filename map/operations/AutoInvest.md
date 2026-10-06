<!-- Generated file — do not edit; regenerated with the SDK. -->

# AutoInvest — operations

Accessor: `client.AutoInvest` · Source: `Api/AutoInvest.cs` · 17 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChangePlanStatus

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ChangePlanStatus(ChangePlanStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PlanId`, `Status`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `planId` ← `PlanId`, `status` ← `Status`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanEditStatusResponse`
- **Error**: `ApiException<ChangePlanStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChangePlanStatusRequest` | `Requests/AutoInvest/ChangePlanStatusRequest.cs` |
| `Status1` | `Models/Enums/Status1.cs` |
| `SapiV1LendingAutoInvestPlanEditStatusResponse` | `Models/SapiV1LendingAutoInvestPlanEditStatusResponse.cs` |
| `ChangePlanStatusError` | `Errors/ChangePlanStatusError.cs` |
| `Error` | `Models/Error.cs` |

### GetListOfPlans

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetListOfPlans(GetListOfPlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PlanType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `planType` ← `PlanType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanListResponse`
- **Error**: `ApiException<GetListOfPlansError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetListOfPlansRequest` | `Requests/AutoInvest/GetListOfPlansRequest.cs` |
| `SapiV1LendingAutoInvestPlanListResponse` | `Models/SapiV1LendingAutoInvestPlanListResponse.cs` |
| `GetListOfPlansError` | `Errors/GetListOfPlansError.cs` |
| `Error` | `Models/Error.cs` |

### GetTargetAssetListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetTargetAssetListUserData(GetTargetAssetListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `targetAsset` ← `TargetAsset`, `size` ← `Size`, `current` ← `Current`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestTargetAssetListResponse`
- **Error**: `ApiException<GetTargetAssetListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTargetAssetListUserDataRequest` | `Requests/AutoInvest/GetTargetAssetListUserDataRequest.cs` |
| `SapiV1LendingAutoInvestTargetAssetListResponse` | `Models/SapiV1LendingAutoInvestTargetAssetListResponse.cs` |
| `GetTargetAssetListUserDataError` | `Errors/GetTargetAssetListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetTargetAssetRoiDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetTargetAssetRoiDataUserData(GetTargetAssetRoiDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TargetAsset`, `HisRoiType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `targetAsset` ← `TargetAsset`, `hisRoiType` ← `HisRoiType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingAutoInvestTargetAssetRoiListResponse>`
- **Error**: `ApiException<GetTargetAssetRoiDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTargetAssetRoiDataUserDataRequest` | `Requests/AutoInvest/GetTargetAssetRoiDataUserDataRequest.cs` |
| `SapiV1LendingAutoInvestTargetAssetRoiListResponse` | `Models/SapiV1LendingAutoInvestTargetAssetRoiListResponse.cs` |
| `GetTargetAssetRoiDataUserDataError` | `Errors/GetTargetAssetRoiDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### IndexLinkedPlanRebalanceDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `IndexLinkedPlanRebalanceDetailsUserData(IndexLinkedPlanRebalanceDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingAutoInvestRebalanceHistoryResponse>`
- **Error**: `ApiException<IndexLinkedPlanRebalanceDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IndexLinkedPlanRebalanceDetailsUserDataRequest` | `Requests/AutoInvest/IndexLinkedPlanRebalanceDetailsUserDataRequest.cs` |
| `SapiV1LendingAutoInvestRebalanceHistoryResponse` | `Models/SapiV1LendingAutoInvestRebalanceHistoryResponse.cs` |
| `IndexLinkedPlanRebalanceDetailsUserDataError` | `Errors/IndexLinkedPlanRebalanceDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### IndexLinkedPlanRedemptionHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `IndexLinkedPlanRedemptionHistoryUserData(IndexLinkedPlanRedemptionHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RequestId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `requestId` ← `RequestId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `asset` ← `Asset`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingAutoInvestRedeemHistoryResponse>`
- **Error**: `ApiException<IndexLinkedPlanRedemptionHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IndexLinkedPlanRedemptionHistoryUserDataRequest` | `Requests/AutoInvest/IndexLinkedPlanRedemptionHistoryUserDataRequest.cs` |
| `SapiV1LendingAutoInvestRedeemHistoryResponse` | `Models/SapiV1LendingAutoInvestRedeemHistoryResponse.cs` |
| `IndexLinkedPlanRedemptionHistoryUserDataError` | `Errors/IndexLinkedPlanRedemptionHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### IndexLinkedPlanRedemptionTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `IndexLinkedPlanRedemptionTrade(IndexLinkedPlanRedemptionTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `IndexId`, `RedemptionPercentage`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `indexId` ← `IndexId`, `redemptionPercentage` ← `RedemptionPercentage`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `requestId` ← `RequestId`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestRedeemResponse`
- **Error**: `ApiException<IndexLinkedPlanRedemptionTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IndexLinkedPlanRedemptionTradeRequest` | `Requests/AutoInvest/IndexLinkedPlanRedemptionTradeRequest.cs` |
| `SapiV1LendingAutoInvestRedeemResponse` | `Models/SapiV1LendingAutoInvestRedeemResponse.cs` |
| `IndexLinkedPlanRedemptionTradeError` | `Errors/IndexLinkedPlanRedemptionTradeError.cs` |
| `Error` | `Models/Error.cs` |

### InvestmentPlanAdjustment

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `InvestmentPlanAdjustment(InvestmentPlanAdjustmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PlanId`, `SubscriptionAmount`, `SubscriptionCycle`, `SubscriptionStartTime`, `SourceAsset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `planId` ← `PlanId`, `subscriptionAmount` ← `SubscriptionAmount`, `subscriptionCycle` ← `SubscriptionCycle`, `subscriptionStartTime` ← `SubscriptionStartTime`, `sourceAsset` ← `SourceAsset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `subscriptionStartDay` ← `SubscriptionStartDay`, `subscriptionStartWeekday` ← `SubscriptionStartWeekday`, `flexibleAllowedToUse` ← `FlexibleAllowedToUse`, `details` ← `Details`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanEditResponse`
- **Error**: `ApiException<InvestmentPlanAdjustmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InvestmentPlanAdjustmentRequest` | `Requests/AutoInvest/InvestmentPlanAdjustmentRequest.cs` |
| `SubscriptionCycle` | `Models/Enums/SubscriptionCycle.cs` |
| `SubscriptionStartWeekday` | `Models/Enums/SubscriptionStartWeekday.cs` |
| `Detail1` | `Models/Detail1.cs` |
| `SapiV1LendingAutoInvestPlanEditResponse` | `Models/SapiV1LendingAutoInvestPlanEditResponse.cs` |
| `InvestmentPlanAdjustmentError` | `Errors/InvestmentPlanAdjustmentError.cs` |
| `Error` | `Models/Error.cs` |

### InvestmentPlanCreationUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `InvestmentPlanCreationUserData(InvestmentPlanCreationUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SourceType`, `PlanType`, `SubscriptionAmount`, `SubscriptionCycle`, `SubscriptionStartTime`, `SourceAsset`, `Details`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `sourceType` ← `SourceType`, `planType` ← `PlanType`, `subscriptionAmount` ← `SubscriptionAmount`, `subscriptionCycle` ← `SubscriptionCycle`, `subscriptionStartTime` ← `SubscriptionStartTime`, `sourceAsset` ← `SourceAsset`, `details` ← `Details`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `requestId` ← `RequestId`, `IndexId` ← `IndexId`, `subscriptionStartDay` ← `SubscriptionStartDay`, `subscriptionStartWeekday` ← `SubscriptionStartWeekday`, `flexibleAllowedToUse` ← `FlexibleAllowedToUse`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanAddResponse`
- **Error**: `ApiException<InvestmentPlanCreationUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InvestmentPlanCreationUserDataRequest` | `Requests/AutoInvest/InvestmentPlanCreationUserDataRequest.cs` |
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
- **Signature**: `OneTimeTransactionTrade(OneTimeTransactionTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SourceType`, `SubscriptionAmount`, `SourceAsset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `sourceType` ← `SourceType`, `subscriptionAmount` ← `SubscriptionAmount`, `sourceAsset` ← `SourceAsset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `requestId` ← `RequestId`, `flexibleAllowedToUse` ← `FlexibleAllowedToUse`, `planId` ← `PlanId`, `indexId` ← `IndexId`, `details` ← `Details`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestOneOffResponse`
- **Error**: `ApiException<OneTimeTransactionTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OneTimeTransactionTradeRequest` | `Requests/AutoInvest/OneTimeTransactionTradeRequest.cs` |
| `Detail5` | `Models/Detail5.cs` |
| `SapiV1LendingAutoInvestOneOffResponse` | `Models/SapiV1LendingAutoInvestOneOffResponse.cs` |
| `OneTimeTransactionTradeError` | `Errors/OneTimeTransactionTradeError.cs` |
| `Error` | `Models/Error.cs` |

### QueryAllSourceAssetAndTargetAssetUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryAllSourceAssetAndTargetAssetUserData(QueryAllSourceAssetAndTargetAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestAllAssetResponse`
- **Error**: `ApiException<QueryAllSourceAssetAndTargetAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryAllSourceAssetAndTargetAssetUserDataRequest` | `Requests/AutoInvest/QueryAllSourceAssetAndTargetAssetUserDataRequest.cs` |
| `SapiV1LendingAutoInvestAllAssetResponse` | `Models/SapiV1LendingAutoInvestAllAssetResponse.cs` |
| `QueryAllSourceAssetAndTargetAssetUserDataError` | `Errors/QueryAllSourceAssetAndTargetAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryHoldingDetailsOfThePlan

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryHoldingDetailsOfThePlan(QueryHoldingDetailsOfThePlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `planId` ← `PlanId`, `requestId` ← `RequestId`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestPlanIdResponse`
- **Error**: `ApiException<QueryHoldingDetailsOfThePlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryHoldingDetailsOfThePlanRequest` | `Requests/AutoInvest/QueryHoldingDetailsOfThePlanRequest.cs` |
| `SapiV1LendingAutoInvestPlanIdResponse` | `Models/SapiV1LendingAutoInvestPlanIdResponse.cs` |
| `QueryHoldingDetailsOfThePlanError` | `Errors/QueryHoldingDetailsOfThePlanError.cs` |
| `Error` | `Models/Error.cs` |

### QueryIndexDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIndexDetailsUserData(QueryIndexDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `IndexId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `indexId` ← `IndexId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestIndexInfoResponse`
- **Error**: `ApiException<QueryIndexDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryIndexDetailsUserDataRequest` | `Requests/AutoInvest/QueryIndexDetailsUserDataRequest.cs` |
| `SapiV1LendingAutoInvestIndexInfoResponse` | `Models/SapiV1LendingAutoInvestIndexInfoResponse.cs` |
| `QueryIndexDetailsUserDataError` | `Errors/QueryIndexDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryIndexLinkedPlanPositionDetailsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryIndexLinkedPlanPositionDetailsUserData(QueryIndexLinkedPlanPositionDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `IndexId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `indexId` ← `IndexId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestIndexUserSummaryResponse`
- **Error**: `ApiException<QueryIndexLinkedPlanPositionDetailsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryIndexLinkedPlanPositionDetailsUserDataRequest` | `Requests/AutoInvest/QueryIndexLinkedPlanPositionDetailsUserDataRequest.cs` |
| `SapiV1LendingAutoInvestIndexUserSummaryResponse` | `Models/SapiV1LendingAutoInvestIndexUserSummaryResponse.cs` |
| `QueryIndexLinkedPlanPositionDetailsUserDataError` | `Errors/QueryIndexLinkedPlanPositionDetailsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryOneTimeTransactionStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryOneTimeTransactionStatusUserData(QueryOneTimeTransactionStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransactionId`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `transactionId` ← `TransactionId`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `requestId` ← `RequestId`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestOneOffStatusResponse`
- **Error**: `ApiException<QueryOneTimeTransactionStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryOneTimeTransactionStatusUserDataRequest` | `Requests/AutoInvest/QueryOneTimeTransactionStatusUserDataRequest.cs` |
| `SapiV1LendingAutoInvestOneOffStatusResponse` | `Models/SapiV1LendingAutoInvestOneOffStatusResponse.cs` |
| `QueryOneTimeTransactionStatusUserDataError` | `Errors/QueryOneTimeTransactionStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySourceAssetListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySourceAssetListUserData(QuerySourceAssetListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `UsageType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `usageType` ← `UsageType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `targetAsset` ← `TargetAsset`, `indexId` ← `IndexId`, `flexibleAllowedToUse` ← `FlexibleAllowedToUse`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingAutoInvestSourceAssetListResponse`
- **Error**: `ApiException<QuerySourceAssetListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QuerySourceAssetListUserDataRequest` | `Requests/AutoInvest/QuerySourceAssetListUserDataRequest.cs` |
| `SapiV1LendingAutoInvestSourceAssetListResponse` | `Models/SapiV1LendingAutoInvestSourceAssetListResponse.cs` |
| `QuerySourceAssetListUserDataError` | `Errors/QuerySourceAssetListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubscriptionTransactionHistory

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubscriptionTransactionHistory(QuerySubscriptionTransactionHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `planId` ← `PlanId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `targetAsset` ← `TargetAsset`, `planType` ← `PlanType`, `size` ← `Size`, `current` ← `Current`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingAutoInvestHistoryListResponse>`
- **Error**: `ApiException<QuerySubscriptionTransactionHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QuerySubscriptionTransactionHistoryRequest` | `Requests/AutoInvest/QuerySubscriptionTransactionHistoryRequest.cs` |
| `PlanType1` | `Models/Enums/PlanType1.cs` |
| `SapiV1LendingAutoInvestHistoryListResponse` | `Models/SapiV1LendingAutoInvestHistoryListResponse.cs` |
| `QuerySubscriptionTransactionHistoryError` | `Errors/QuerySubscriptionTransactionHistoryError.cs` |
| `Error` | `Models/Error.cs` |

