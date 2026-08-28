# Reference

> Source: [BinancePublicSpotApiClient](BinancePublicSpotApiClient.cs)

## AutoInvest

> Source: [AutoInvest](Api/AutoInvest.cs)

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanEditStatusResponse&gt; ChangePlanStatus(int planId, Status1 status, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Change Plan Status

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.ChangePlanStatus(planId, status, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanEditStatusResponse
}
catch (SdkException<ChangePlanStatusError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>planId</code> | <code>int</code> | - |
| <code>status</code> | <code>[Status1](Models/Enums/Status1.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanEditStatusResponse](Models/SapiV1LendingAutoInvestPlanEditStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ChangePlanStatusError](Errors/ChangePlanStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanListResponse&gt; GetListOfPlans(string planType, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query plan lists

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.GetListOfPlans(planType, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanListResponse
}
catch (SdkException<GetListOfPlansError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>planType</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanListResponse](Models/SapiV1LendingAutoInvestPlanListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetListOfPlansError](Errors/GetListOfPlansError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingAutoInvestTargetAssetRoiListResponse&gt;&gt; GetTargetAssetRoiDataUserData(string targetAsset, string hisRoiType, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

ROI return list for target asset

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.GetTargetAssetRoiDataUserData(targetAsset,
        hisRoiType,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingAutoInvestTargetAssetRoiListResponse>
}
catch (SdkException<GetTargetAssetRoiDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>targetAsset</code> | <code>string</code> | - |
| <code>hisRoiType</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestTargetAssetRoiListResponse](Models/SapiV1LendingAutoInvestTargetAssetRoiListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTargetAssetRoiDataUserDataError](Errors/GetTargetAssetRoiDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestTargetAssetListResponse&gt; GetTargetAssetListUserData(long timestamp, string signature, string? targetAsset, int? size, int? current, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.GetTargetAssetListUserData(timestamp,
        signature,
        targetAsset,
        size,
        current,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestTargetAssetListResponse
}
catch (SdkException<GetTargetAssetListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>targetAsset</code> | <code>string?</code> | - |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestTargetAssetListResponse](Models/SapiV1LendingAutoInvestTargetAssetListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTargetAssetListUserDataError](Errors/GetTargetAssetListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingAutoInvestRebalanceHistoryResponse&gt;&gt; IndexLinkedPlanRebalanceDetailsUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the history of Index Linked Plan Redemption transactions

Max 30 day difference between startTime and endTime
If no startTime and endTime, default to show past 30 day records

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.IndexLinkedPlanRebalanceDetailsUserData(timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingAutoInvestRebalanceHistoryResponse>
}
catch (SdkException<IndexLinkedPlanRebalanceDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestRebalanceHistoryResponse](Models/SapiV1LendingAutoInvestRebalanceHistoryResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[IndexLinkedPlanRebalanceDetailsUserDataError](Errors/IndexLinkedPlanRebalanceDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestRedeemResponse&gt; IndexLinkedPlanRedemptionTrade(long indexId, int redemptionPercentage, long timestamp, string signature, string? requestId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To redeem index-Linked plan holdings

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.IndexLinkedPlanRedemptionTrade(indexId,
        redemptionPercentage,
        timestamp,
        signature,
        requestId,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestRedeemResponse
}
catch (SdkException<IndexLinkedPlanRedemptionTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>indexId</code> | <code>long</code> | PORTFOLIO plan's Id |
| <code>redemptionPercentage</code> | <code>int</code> | user redeem percentage,10/20/100. |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>requestId</code> | <code>string?</code> | sourceType + unique, transactionId and requestId cannot be empty at the same time |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestRedeemResponse](Models/SapiV1LendingAutoInvestRedeemResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[IndexLinkedPlanRedemptionTradeError](Errors/IndexLinkedPlanRedemptionTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingAutoInvestRedeemHistoryResponse&gt;&gt; IndexLinkedPlanRedemptionHistoryUserData(long requestId, long timestamp, string signature, long? startTime, long? endTime, int? current, string? asset, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the history of Index Linked Plan Redemption transactions

Max 30 day difference between startTime and endTime
If no startTime and endTime, default to show past 30 day records

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.IndexLinkedPlanRedemptionHistoryUserData(requestId,
        timestamp,
        signature,
        startTime,
        endTime,
        current,
        asset,
        size,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingAutoInvestRedeemHistoryResponse>
}
catch (SdkException<IndexLinkedPlanRedemptionHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>requestId</code> | <code>long</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>asset</code> | <code>string?</code> | - |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestRedeemHistoryResponse](Models/SapiV1LendingAutoInvestRedeemHistoryResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[IndexLinkedPlanRedemptionHistoryUserDataError](Errors/IndexLinkedPlanRedemptionHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanEditResponse&gt; InvestmentPlanAdjustment(int planId, double subscriptionAmount, SubscriptionCycle subscriptionCycle, int subscriptionStartTime, string sourceAsset, long timestamp, string signature, int? subscriptionStartDay, SubscriptionStartWeekday? subscriptionStartWeekday, bool? flexibleAllowedToUse, IReadOnlyList&lt;Detail1&gt;? details, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Source Asset to be used for investment

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.InvestmentPlanAdjustment(planId,
        subscriptionAmount,
        subscriptionCycle,
        subscriptionStartTime,
        sourceAsset,
        timestamp,
        signature,
        subscriptionStartDay,
        subscriptionStartWeekday,
        flexibleAllowedToUse,
        details,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanEditResponse
}
catch (SdkException<InvestmentPlanAdjustmentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>planId</code> | <code>int</code> | - |
| <code>subscriptionAmount</code> | <code>double</code> | - |
| <code>subscriptionCycle</code> | <code>[SubscriptionCycle](Models/Enums/SubscriptionCycle.cs)</code> | - |
| <code>subscriptionStartTime</code> | <code>int</code> | - |
| <code>sourceAsset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>subscriptionStartDay</code> | <code>int?</code> | - |
| <code>subscriptionStartWeekday</code> | <code>[SubscriptionStartWeekday?](Models/Enums/SubscriptionStartWeekday.cs)</code> | - |
| <code>flexibleAllowedToUse</code> | <code>bool?</code> | - |
| <code>details</code> | <code>IReadOnlyList&lt;[Detail1](Models/Detail1.cs)&gt;?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanEditResponse](Models/SapiV1LendingAutoInvestPlanEditResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InvestmentPlanAdjustmentError](Errors/InvestmentPlanAdjustmentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanAddResponse&gt; InvestmentPlanCreationUserData(SourceType sourceType, PlanType planType, double subscriptionAmount, SubscriptionCycle subscriptionCycle, int subscriptionStartTime, string sourceAsset, IReadOnlyList&lt;Detail1&gt; details, long timestamp, string signature, string? requestId, long? indexId, int? subscriptionStartDay, SubscriptionStartWeekday? subscriptionStartWeekday, bool? flexibleAllowedToUse, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Post an investment plan creation

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.InvestmentPlanCreationUserData(sourceType,
        planType,
        subscriptionAmount,
        subscriptionCycle,
        subscriptionStartTime,
        sourceAsset,
        details,
        timestamp,
        signature,
        requestId,
        indexId,
        subscriptionStartDay,
        subscriptionStartWeekday,
        flexibleAllowedToUse,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanAddResponse
}
catch (SdkException<InvestmentPlanCreationUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>sourceType</code> | <code>[SourceType](Models/Enums/SourceType.cs)</code> | - |
| <code>planType</code> | <code>[PlanType](Models/Enums/PlanType.cs)</code> | - |
| <code>subscriptionAmount</code> | <code>double</code> | - |
| <code>subscriptionCycle</code> | <code>[SubscriptionCycle](Models/Enums/SubscriptionCycle.cs)</code> | - |
| <code>subscriptionStartTime</code> | <code>int</code> | - |
| <code>sourceAsset</code> | <code>string</code> | - |
| <code>details</code> | <code>IReadOnlyList&lt;[Detail1](Models/Detail1.cs)&gt;</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>requestId</code> | <code>string?</code> | - |
| <code>indexId</code> | <code>long?</code> | - |
| <code>subscriptionStartDay</code> | <code>int?</code> | - |
| <code>subscriptionStartWeekday</code> | <code>[SubscriptionStartWeekday?](Models/Enums/SubscriptionStartWeekday.cs)</code> | - |
| <code>flexibleAllowedToUse</code> | <code>bool?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanAddResponse](Models/SapiV1LendingAutoInvestPlanAddResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InvestmentPlanCreationUserDataError](Errors/InvestmentPlanCreationUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestOneOffResponse&gt; OneTimeTransactionTrade(string sourceType, double subscriptionAmount, string sourceAsset, long timestamp, string signature, string? requestId, bool? flexibleAllowedToUse, long? planId, long? indexId, IReadOnlyList&lt;Detail5&gt;? details, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

One time transaction

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.OneTimeTransactionTrade(sourceType,
        subscriptionAmount,
        sourceAsset,
        timestamp,
        signature,
        requestId,
        flexibleAllowedToUse,
        planId,
        indexId,
        details,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestOneOffResponse
}
catch (SdkException<OneTimeTransactionTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>sourceType</code> | <code>string</code> | - |
| <code>subscriptionAmount</code> | <code>double</code> | - |
| <code>sourceAsset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>requestId</code> | <code>string?</code> | - |
| <code>flexibleAllowedToUse</code> | <code>bool?</code> | - |
| <code>planId</code> | <code>long?</code> | - |
| <code>indexId</code> | <code>long?</code> | - |
| <code>details</code> | <code>IReadOnlyList&lt;[Detail5](Models/Detail5.cs)&gt;?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestOneOffResponse](Models/SapiV1LendingAutoInvestOneOffResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OneTimeTransactionTradeError](Errors/OneTimeTransactionTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestIndexInfoResponse&gt; QueryIndexDetailsUserData(long indexId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query index details

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.QueryIndexDetailsUserData(indexId, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestIndexInfoResponse
}
catch (SdkException<QueryIndexDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>indexId</code> | <code>long</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestIndexInfoResponse](Models/SapiV1LendingAutoInvestIndexInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryIndexDetailsUserDataError](Errors/QueryIndexDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestIndexUserSummaryResponse&gt; QueryIndexLinkedPlanPositionDetailsUserData(long indexId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Details on users Index-Linked plan position details

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.QueryIndexLinkedPlanPositionDetailsUserData(indexId,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestIndexUserSummaryResponse
}
catch (SdkException<QueryIndexLinkedPlanPositionDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>indexId</code> | <code>long</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestIndexUserSummaryResponse](Models/SapiV1LendingAutoInvestIndexUserSummaryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryIndexLinkedPlanPositionDetailsUserDataError](Errors/QueryIndexLinkedPlanPositionDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestOneOffStatusResponse&gt; QueryOneTimeTransactionStatusUserData(long transactionId, long timestamp, string signature, string? requestId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Transaction status for one-time transaction

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.QueryOneTimeTransactionStatusUserData(transactionId,
        timestamp,
        signature,
        requestId,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestOneOffStatusResponse
}
catch (SdkException<QueryOneTimeTransactionStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transactionId</code> | <code>long</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>requestId</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestOneOffStatusResponse](Models/SapiV1LendingAutoInvestOneOffStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryOneTimeTransactionStatusUserDataError](Errors/QueryOneTimeTransactionStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestAllAssetResponse&gt; QueryAllSourceAssetAndTargetAssetUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query all source assets and target assets

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.QueryAllSourceAssetAndTargetAssetUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestAllAssetResponse
}
catch (SdkException<QueryAllSourceAssetAndTargetAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestAllAssetResponse](Models/SapiV1LendingAutoInvestAllAssetResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryAllSourceAssetAndTargetAssetUserDataError](Errors/QueryAllSourceAssetAndTargetAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanIdResponse&gt; QueryHoldingDetailsOfThePlan(long timestamp, string signature, long? planId, string? requestId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query holding details of the plan

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.QueryHoldingDetailsOfThePlan(timestamp,
        signature,
        planId,
        requestId,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanIdResponse
}
catch (SdkException<QueryHoldingDetailsOfThePlanError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>planId</code> | <code>long?</code> | - |
| <code>requestId</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanIdResponse](Models/SapiV1LendingAutoInvestPlanIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryHoldingDetailsOfThePlanError](Errors/QueryHoldingDetailsOfThePlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestSourceAssetListResponse&gt; QuerySourceAssetListUserData(string usageType, long timestamp, string signature, string? targetAsset, long? indexId, bool? flexibleAllowedToUse, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Source Asset to be used for investment

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.QuerySourceAssetListUserData(usageType,
        timestamp,
        signature,
        targetAsset,
        indexId,
        flexibleAllowedToUse,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestSourceAssetListResponse
}
catch (SdkException<QuerySourceAssetListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>usageType</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>targetAsset</code> | <code>string?</code> | - |
| <code>indexId</code> | <code>long?</code> | - |
| <code>flexibleAllowedToUse</code> | <code>bool?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestSourceAssetListResponse](Models/SapiV1LendingAutoInvestSourceAssetListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QuerySourceAssetListUserDataError](Errors/QuerySourceAssetListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingAutoInvestHistoryListResponse&gt;&gt; QuerySubscriptionTransactionHistory(long timestamp, string signature, long? planId, long? startTime, long? endTime, long? targetAsset, PlanType1? planType, int? size, int? current, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query subscription transaction history of a plan

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AutoInvest.QuerySubscriptionTransactionHistory(timestamp,
        signature,
        planId,
        startTime,
        endTime,
        targetAsset,
        planType,
        size,
        current,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingAutoInvestHistoryListResponse>
}
catch (SdkException<QuerySubscriptionTransactionHistoryError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>planId</code> | <code>long?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>targetAsset</code> | <code>long?</code> | - |
| <code>planType</code> | <code>[PlanType1?](Models/Enums/PlanType1.cs)</code> | - |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestHistoryListResponse](Models/SapiV1LendingAutoInvestHistoryListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QuerySubscriptionTransactionHistoryError](Errors/QuerySubscriptionTransactionHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Blvt

> Source: [Blvt](Api/Blvt.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1BlvtTokenInfoResponse&gt;&gt; BlvtInfoMarketData(string? tokenName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Blvt.BlvtInfoMarketData(tokenName);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1BlvtTokenInfoResponse>
}
catch (SdkException<BlvtInfoMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tokenName</code> | <code>string?</code> | BTCDOWN, BTCUP |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1BlvtTokenInfoResponse](Models/SapiV1BlvtTokenInfoResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BlvtInfoMarketDataError](Errors/BlvtInfoMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1BlvtUserLimitResponse&gt;&gt; BlvtUserLimitInfoUserData(long timestamp, string signature, string? tokenName, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Blvt.BlvtUserLimitInfoUserData(timestamp, signature, tokenName, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1BlvtUserLimitResponse>
}
catch (SdkException<BlvtUserLimitInfoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>tokenName</code> | <code>string?</code> | BTCDOWN, BTCUP |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1BlvtUserLimitResponse](Models/SapiV1BlvtUserLimitResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BlvtUserLimitInfoUserDataError](Errors/BlvtUserLimitInfoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1BlvtSubscribeRecordResponse&gt; QuerySubscriptionRecordUserData(long timestamp, string signature, string? tokenName, long? id, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Only the data of the latest 90 days is available

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Blvt.QuerySubscriptionRecordUserData(timestamp,
        signature,
        tokenName,
        id,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1BlvtSubscribeRecordResponse
}
catch (SdkException<QuerySubscriptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>tokenName</code> | <code>string?</code> | BTCDOWN, BTCUP |
| <code>id</code> | <code>long?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1BlvtSubscribeRecordResponse](Models/SapiV1BlvtSubscribeRecordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QuerySubscriptionRecordUserDataError](Errors/QuerySubscriptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1BlvtRedeemResponse&gt; RedeemBlvtUserData(string tokenName, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Blvt.RedeemBlvtUserData(tokenName, amount, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1BlvtRedeemResponse
}
catch (SdkException<RedeemBlvtUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tokenName</code> | <code>string</code> | BTCDOWN, BTCUP |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1BlvtRedeemResponse](Models/SapiV1BlvtRedeemResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RedeemBlvtUserDataError](Errors/RedeemBlvtUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1BlvtRedeemRecordResponse&gt;&gt; RedemptionRecordUserData(long timestamp, string signature, string? tokenName, long? id, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Only the data of the latest 90 days is available

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Blvt.RedemptionRecordUserData(timestamp,
        signature,
        tokenName,
        id,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1BlvtRedeemRecordResponse>
}
catch (SdkException<RedemptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>tokenName</code> | <code>string?</code> | BTCDOWN, BTCUP |
| <code>id</code> | <code>long?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | default 1000, max 1000 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1BlvtRedeemRecordResponse](Models/SapiV1BlvtRedeemRecordResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RedemptionRecordUserDataError](Errors/RedemptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1BlvtSubscribeResponse&gt; SubscribeBlvtUserData(string tokenName, double cost, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Blvt.SubscribeBlvtUserData(tokenName, cost, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1BlvtSubscribeResponse
}
catch (SdkException<SubscribeBlvtUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tokenName</code> | <code>string</code> | BTCDOWN, BTCUP |
| <code>cost</code> | <code>double</code> | Spot balance |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1BlvtSubscribeResponse](Models/SapiV1BlvtSubscribeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubscribeBlvtUserDataError](Errors/SubscribeBlvtUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## C2C

> Source: [C2C](Api/C2C.cs)

<details>
<summary><code>Task&lt;SapiV1C2COrderMatchListUserOrderHistoryResponse&gt; GetC2CTradeHistoryUserData(TradeType tradeType, long timestamp, string signature, long? startTimestamp, long? endTimestamp, int? page, int? rows, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If startTimestamp and endTimestamp are not sent, the recent 30-day data will be returned.
- The max interval between startTimestamp and endTimestamp is 30 days.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.C2C.GetC2CTradeHistoryUserData(tradeType,
        timestamp,
        signature,
        startTimestamp,
        endTimestamp,
        page,
        rows,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1C2COrderMatchListUserOrderHistoryResponse
}
catch (SdkException<GetC2CTradeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tradeType</code> | <code>[TradeType](Models/Enums/TradeType.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTimestamp</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTimestamp</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>rows</code> | <code>int?</code> | default 100, max 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1C2COrderMatchListUserOrderHistoryResponse](Models/SapiV1C2COrderMatchListUserOrderHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetC2CTradeHistoryUserDataError](Errors/GetC2CTradeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConvertApi

> Source: [ConvertApi](Api/ConvertApi.cs)

<details>
<summary><code>Task&lt;SapiV1ConvertAcceptQuoteResponse&gt; AcceptQuoteTrade(string quoteId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Accept the offered quote by quote ID.

Weight(UID): 500

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConvertApi.AcceptQuoteTrade(quoteId, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1ConvertAcceptQuoteResponse
}
catch (SdkException<AcceptQuoteTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>quoteId</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertAcceptQuoteResponse](Models/SapiV1ConvertAcceptQuoteResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AcceptQuoteTradeError](Errors/AcceptQuoteTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertLimitCancelOrderResponse&gt; CancelLimitOrderUserData(long orderId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable users to cancel a limit order

Weight(UID): 200

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConvertApi.CancelLimitOrderUserData(orderId, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1ConvertLimitCancelOrderResponse
}
catch (SdkException<CancelLimitOrderUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderId</code> | <code>long</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertLimitCancelOrderResponse](Models/SapiV1ConvertLimitCancelOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelLimitOrderUserDataError](Errors/CancelLimitOrderUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertTradeFlowResponse&gt; GetConvertTradeHistoryUserData(long startTime, long endTime, long timestamp, string signature, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The max interval between startTime and endTime is 30 days.

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConvertApi.GetConvertTradeHistoryUserData(startTime,
        endTime,
        timestamp,
        signature,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ConvertTradeFlowResponse
}
catch (SdkException<GetConvertTradeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>long</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long</code> | UTC timestamp in ms |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>limit</code> | <code>int?</code> | default 100, max 1000 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertTradeFlowResponse](Models/SapiV1ConvertTradeFlowResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetConvertTradeHistoryUserDataError](Errors/GetConvertTradeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1ConvertExchangeInfoResponse&gt;&gt; ListAllConvertPairs(string? fromAsset, string? toAsset, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query for all convertible token pairs and the tokens’ respective upper/lower limits

Weight(IP): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConvertApi.ListAllConvertPairs(fromAsset, toAsset);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1ConvertExchangeInfoResponse>
}
catch (SdkException<ListAllConvertPairsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>fromAsset</code> | <code>string?</code> | User spends coin |
| <code>toAsset</code> | <code>string?</code> | User receives coin |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1ConvertExchangeInfoResponse](Models/SapiV1ConvertExchangeInfoResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAllConvertPairsError](Errors/ListAllConvertPairsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertOrderStatusResponse&gt; OrderStatusUserData(long timestamp, string signature, string? orderId, string? quoteId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query order status by order ID.

Weight(UID): 100

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConvertApi.OrderStatusUserData(timestamp, signature, orderId, quoteId, recvWindow);
    // TODO: Handle 'response' of type SapiV1ConvertOrderStatusResponse
}
catch (SdkException<OrderStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>string?</code> | - |
| <code>quoteId</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertOrderStatusResponse](Models/SapiV1ConvertOrderStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrderStatusUserDataError](Errors/OrderStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertLimitPlaceOrderResponse&gt; PlaceLimitOrderUserData(string baseAsset, string quoteAsset, double limitPrice, Side side, long timestamp, string signature, double? baseAmount, double? quoteAmount, WalletType? walletType, ExpiredType? expiredType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable users to place a limit order

- baseAsset or quoteAsset can be determined via exchangeInfo endpoint.
- Limit price is defined from baseAsset to quoteAsset.
- Either baseAmount or quoteAmount is used.

Weight(UID): 500

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConvertApi.PlaceLimitOrderUserData(baseAsset,
        quoteAsset,
        limitPrice,
        side,
        timestamp,
        signature,
        baseAmount,
        quoteAmount,
        walletType,
        expiredType,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ConvertLimitPlaceOrderResponse
}
catch (SdkException<PlaceLimitOrderUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>baseAsset</code> | <code>string</code> | - |
| <code>quoteAsset</code> | <code>string</code> | - |
| <code>limitPrice</code> | <code>double</code> | Symbol limit price (from baseAsset to quoteAsset) |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>baseAmount</code> | <code>double?</code> | Base asset amount. (One of baseAmount or quoteAmount is required) |
| <code>quoteAmount</code> | <code>double?</code> | Quote asset amount. (One of baseAmount or quoteAmount is required) |
| <code>walletType</code> | <code>[WalletType?](Models/Enums/WalletType.cs)</code> | SPOT or FUNDING or SPOT_FUNDING. It is to use which type of assets. Default is SPOT. |
| <code>expiredType</code> | <code>[ExpiredType?](Models/Enums/ExpiredType.cs)</code> | 1_D, 3_D, 7_D, 30_D (D means day) |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertLimitPlaceOrderResponse](Models/SapiV1ConvertLimitPlaceOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PlaceLimitOrderUserDataError](Errors/PlaceLimitOrderUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertLimitQueryOpenOrdersResponse&gt; QueryLimitOpenOrdersUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable users to query for all existing limit orders

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConvertApi.QueryLimitOpenOrdersUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1ConvertLimitQueryOpenOrdersResponse
}
catch (SdkException<QueryLimitOpenOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertLimitQueryOpenOrdersResponse](Models/SapiV1ConvertLimitQueryOpenOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryLimitOpenOrdersUserDataError](Errors/QueryLimitOpenOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1ConvertAssetInfoResponse&gt;&gt; QueryOrderQuantityPrecisionPerAssetUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query for supported asset precision information

Weight(IP): 100

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConvertApi.QueryOrderQuantityPrecisionPerAssetUserData(timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1ConvertAssetInfoResponse>
}
catch (SdkException<QueryOrderQuantityPrecisionPerAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1ConvertAssetInfoResponse](Models/SapiV1ConvertAssetInfoResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryOrderQuantityPrecisionPerAssetUserDataError](Errors/QueryOrderQuantityPrecisionPerAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertGetQuoteResponse&gt; SendQuoteRequestUserData(string fromAsset, string toAsset, long timestamp, string signature, double? fromAmount, double? toAmount, string? validTime, string? walletType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Request a quote for the requested token pairs

Weight(UID): 200

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConvertApi.SendQuoteRequestUserData(fromAsset,
        toAsset,
        timestamp,
        signature,
        fromAmount,
        toAmount,
        validTime,
        walletType,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ConvertGetQuoteResponse
}
catch (SdkException<SendQuoteRequestUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>fromAsset</code> | <code>string</code> | - |
| <code>toAsset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>fromAmount</code> | <code>double?</code> | When specified, it is the amount you will be debited after the conversion |
| <code>toAmount</code> | <code>double?</code> | When specified, it is the amount you will be debited after the conversion |
| <code>validTime</code> | <code>string?</code> | 10s, 30s, 1m, 2m, default 10s |
| <code>walletType</code> | <code>string?</code> | SPOT or FUNDING. Default is SPOT |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertGetQuoteResponse](Models/SapiV1ConvertGetQuoteResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SendQuoteRequestUserDataError](Errors/SendQuoteRequestUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CopyTrading

> Source: [CopyTrading](Api/CopyTrading.cs)

<details>
<summary><code>Task&lt;SapiV1CopyTradingFuturesUserStatusResponse&gt; GetFuturesLeadTraderStatusTrade(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Futures Lead Trader Status

Weight(UID): 20

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CopyTrading.GetFuturesLeadTraderStatusTrade(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1CopyTradingFuturesUserStatusResponse
}
catch (SdkException<GetFuturesLeadTraderStatusTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CopyTradingFuturesUserStatusResponse](Models/SapiV1CopyTradingFuturesUserStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFuturesLeadTraderStatusTradeError](Errors/GetFuturesLeadTraderStatusTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CopyTradingFuturesLeadSymbolResponse&gt; GetFuturesLeadTradingSymbolWhitelistUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Futures Lead Trading Symbol Whitelist

Weight(IP): 20

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CopyTrading.GetFuturesLeadTradingSymbolWhitelistUserData(timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1CopyTradingFuturesLeadSymbolResponse
}
catch (SdkException<GetFuturesLeadTradingSymbolWhitelistUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CopyTradingFuturesLeadSymbolResponse](Models/SapiV1CopyTradingFuturesLeadSymbolResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFuturesLeadTradingSymbolWhitelistUserDataError](Errors/GetFuturesLeadTradingSymbolWhitelistUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CryptoLoans

> Source: [CryptoLoans](Api/CryptoLoans.cs)

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleAdjustLtvResponse&gt; AdjustLtvFlexibleLoanAdjustLtvTrade(double adjustmentAmount, Direction direction, long timestamp, string signature, string? loanCoin, string? collateralCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- API Key needs Spot & Margin Trading permission for this endpoint

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.AdjustLtvFlexibleLoanAdjustLtvTrade(adjustmentAmount,
        direction,
        timestamp,
        signature,
        loanCoin,
        collateralCoin,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2LoanFlexibleAdjustLtvResponse
}
catch (SdkException<AdjustLtvFlexibleLoanAdjustLtvTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>adjustmentAmount</code> | <code>double</code> | - |
| <code>direction</code> | <code>[Direction](Models/Enums/Direction.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleAdjustLtvResponse](Models/SapiV2LoanFlexibleAdjustLtvResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AdjustLtvFlexibleLoanAdjustLtvTradeError](Errors/AdjustLtvFlexibleLoanAdjustLtvTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleLtvAdjustmentHistoryResponse&gt; AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData(long timestamp, string signature, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If startTime and endTime are not sent, the recent 90-day data will be returned.
- The max interval between startTime and endTime is 180 days.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData(timestamp,
        signature,
        loanCoin,
        collateralCoin,
        startTime,
        endTime,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2LoanFlexibleLtvAdjustmentHistoryResponse
}
catch (SdkException<AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleLtvAdjustmentHistoryResponse](Models/SapiV2LoanFlexibleLtvAdjustmentHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError](Errors/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleBorrowResponse&gt; BorrowFlexibleLoanBorrowTrade(long timestamp, string signature, string? loanCoin, double? loanAmount, string? collateralCoin, double? collateralAmount, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Only available for master account

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.BorrowFlexibleLoanBorrowTrade(timestamp,
        signature,
        loanCoin,
        loanAmount,
        collateralCoin,
        collateralAmount,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2LoanFlexibleBorrowResponse
}
catch (SdkException<BorrowFlexibleLoanBorrowTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>loanAmount</code> | <code>double?</code> | Loan amount |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>collateralAmount</code> | <code>double?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleBorrowResponse](Models/SapiV2LoanFlexibleBorrowResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BorrowFlexibleLoanBorrowTradeError](Errors/BorrowFlexibleLoanBorrowTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleBorrowHistoryResponse&gt; BorrowGetFlexibleLoanBorrowHistoryUserData(long timestamp, string signature, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If startTime and endTime are not sent, the recent 90-day data will be returned.
- The max interval between startTime and endTime is 180 days.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.BorrowGetFlexibleLoanBorrowHistoryUserData(timestamp,
        signature,
        loanCoin,
        collateralCoin,
        startTime,
        endTime,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2LoanFlexibleBorrowHistoryResponse
}
catch (SdkException<BorrowGetFlexibleLoanBorrowHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleBorrowHistoryResponse](Models/SapiV2LoanFlexibleBorrowHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BorrowGetFlexibleLoanBorrowHistoryUserDataError](Errors/BorrowGetFlexibleLoanBorrowHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleOngoingOrdersResponse&gt; BorrowGetFlexibleLoanOngoingOrdersUserData(long timestamp, string signature, string? loanCoin, string? collateralCoin, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>


Weight(IP): 300

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.BorrowGetFlexibleLoanOngoingOrdersUserData(timestamp,
        signature,
        loanCoin,
        collateralCoin,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2LoanFlexibleOngoingOrdersResponse
}
catch (SdkException<BorrowGetFlexibleLoanOngoingOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleOngoingOrdersResponse](Models/SapiV2LoanFlexibleOngoingOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BorrowGetFlexibleLoanOngoingOrdersUserDataError](Errors/BorrowGetFlexibleLoanOngoingOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanRepayCollateralRateResponse&gt; CheckCollateralRepayRateUserData(string loanCoin, string collateralCoin, double repayAmount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the the rate of collateral coin / loan coin when using collateral repay, the rate will be valid within 8 second.

Weight(IP): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.CheckCollateralRepayRateUserData(loanCoin,
        collateralCoin,
        repayAmount,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanRepayCollateralRateResponse
}
catch (SdkException<CheckCollateralRepayRateUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>loanCoin</code> | <code>string</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string</code> | Coin used as collateral |
| <code>repayAmount</code> | <code>double</code> | repay amount of loanCoin |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanRepayCollateralRateResponse](Models/SapiV1LoanRepayCollateralRateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckCollateralRepayRateUserDataError](Errors/CheckCollateralRepayRateUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanAdjustLtvResponse&gt; CryptoLoanAdjustLtvTrade(long orderId, double amount, Direction direction, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.CryptoLoanAdjustLtvTrade(orderId,
        amount,
        direction,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanAdjustLtvResponse
}
catch (SdkException<CryptoLoanAdjustLtvTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderId</code> | <code>long</code> | Order ID |
| <code>amount</code> | <code>double</code> | Amount |
| <code>direction</code> | <code>[Direction](Models/Enums/Direction.cs)</code> | 'ADDITIONAL', 'REDUCED' |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanAdjustLtvResponse](Models/SapiV1LoanAdjustLtvResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CryptoLoanAdjustLtvTradeError](Errors/CryptoLoanAdjustLtvTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanBorrowResponse&gt; CryptoLoanBorrowTrade(string loanCoin, string collateralCoin, int loanTerm, long timestamp, string signature, double? loanAmount, double? collateralAmount, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.CryptoLoanBorrowTrade(loanCoin,
        collateralCoin,
        loanTerm,
        timestamp,
        signature,
        loanAmount,
        collateralAmount,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanBorrowResponse
}
catch (SdkException<CryptoLoanBorrowTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>loanCoin</code> | <code>string</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string</code> | Coin used as collateral |
| <code>loanTerm</code> | <code>int</code> | 7/14/30/90/180 days |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanAmount</code> | <code>double?</code> | Loan amount |
| <code>collateralAmount</code> | <code>double?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanBorrowResponse](Models/SapiV1LoanBorrowResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CryptoLoanBorrowTradeError](Errors/CryptoLoanBorrowTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanCustomizeMarginCallResponse&gt; CryptoLoanCustomizeMarginCallTrade(double marginCall, long timestamp, string signature, long? orderId, string? collateralCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Customize margin call for ongoing orders only.

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.CryptoLoanCustomizeMarginCallTrade(marginCall,
        timestamp,
        signature,
        orderId,
        collateralCoin,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanCustomizeMarginCallResponse
}
catch (SdkException<CryptoLoanCustomizeMarginCallTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>marginCall</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Mandatory when collateralCoin is empty. Send either orderId or collateralCoin, if both parameters are sent, take orderId only. |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanCustomizeMarginCallResponse](Models/SapiV1LoanCustomizeMarginCallResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CryptoLoanCustomizeMarginCallTradeError](Errors/CryptoLoanCustomizeMarginCallTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanRepayResponse&gt; CryptoLoanRepayTrade(long orderId, double amount, long timestamp, string signature, int? type, bool? collateralReturn, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.CryptoLoanRepayTrade(orderId,
        amount,
        timestamp,
        signature,
        type,
        collateralReturn,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanRepayResponse
}
catch (SdkException<CryptoLoanRepayTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderId</code> | <code>long</code> | Order ID |
| <code>amount</code> | <code>double</code> | Repayment Amount |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>type</code> | <code>int?</code> | Default: 1. 1 for 'repay with borrowed coin'; 2 for 'repay with collateral'. |
| <code>collateralReturn</code> | <code>bool?</code> | Default: TRUE. TRUE: Return extra collateral to spot account; FALSE: Keep extra collateral in the order. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanRepayResponse](Models/AnyOf/SapiV1LoanRepayResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CryptoLoanRepayTradeError](Errors/CryptoLoanRepayTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanCollateralDataResponse&gt; GetCollateralAssetsDataUserData(long timestamp, string signature, string? collateralCoin, int? vipLevel, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get LTV information and collateral limit of collateral assets. The collateral limit is shown in USD value.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.GetCollateralAssetsDataUserData(timestamp,
        signature,
        collateralCoin,
        vipLevel,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanCollateralDataResponse
}
catch (SdkException<GetCollateralAssetsDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>vipLevel</code> | <code>int?</code> | Defaults to user's vip level |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanCollateralDataResponse](Models/SapiV1LoanCollateralDataResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCollateralAssetsDataUserDataError](Errors/GetCollateralAssetsDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanBorrowHistoryResponse&gt; GetCryptoLoansBorrowHistoryUserData(long timestamp, string signature, long? orderId, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If startTime and endTime are not sent, the recent 90-day data will be returned.
- The max interval between startTime and endTime is 180 days.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.GetCryptoLoansBorrowHistoryUserData(timestamp,
        signature,
        orderId,
        loanCoin,
        collateralCoin,
        startTime,
        endTime,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanBorrowHistoryResponse
}
catch (SdkException<GetCryptoLoansBorrowHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | orderId in POST /sapi/v1/loan/borrow |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>long?</code> | default 10, max 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanBorrowHistoryResponse](Models/SapiV1LoanBorrowHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCryptoLoansBorrowHistoryUserDataError](Errors/GetCryptoLoansBorrowHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LoanIncomeResponse&gt;&gt; GetCryptoLoansIncomeHistoryUserData(long timestamp, string signature, string? asset, Type9? type, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If startTime and endTime are not sent, the recent 7-day data will be returned.
- The max interval between startTime and endTime is 30 days.

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.GetCryptoLoansIncomeHistoryUserData(timestamp,
        signature,
        asset,
        type,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LoanIncomeResponse>
}
catch (SdkException<GetCryptoLoansIncomeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>type</code> | <code>[Type9?](Models/Enums/Type9.cs)</code> | All types will be returned by default.<br>  * `borrowIn`<br>  * `collateralSpent`<br>  * `repayAmount`<br>  * `collateralReturn` - Collateral return after repayment<br>  * `addCollateral`<br>  * `removeCollateral`<br>  * `collateralReturnAfterLiquidation` |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | default 20, max 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LoanIncomeResponse](Models/SapiV1LoanIncomeResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCryptoLoansIncomeHistoryUserDataError](Errors/GetCryptoLoansIncomeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleLoanableDataResponse&gt; GetFlexibleLoanAssetsDataUserData(long timestamp, string signature, string? loanCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get interest rate and borrow limit of flexible loanable assets. The borrow limit is shown in USD value.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.GetFlexibleLoanAssetsDataUserData(timestamp,
        signature,
        loanCoin,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2LoanFlexibleLoanableDataResponse
}
catch (SdkException<GetFlexibleLoanAssetsDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleLoanableDataResponse](Models/SapiV2LoanFlexibleLoanableDataResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFlexibleLoanAssetsDataUserDataError](Errors/GetFlexibleLoanAssetsDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleCollateralDataResponse&gt; GetFlexibleLoanCollateralAssetsDataUserData(long timestamp, string signature, string? collateralCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get LTV information and collateral limit of flexible loan's collateral assets. The collateral limit is shown in USD value.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.GetFlexibleLoanCollateralAssetsDataUserData(timestamp,
        signature,
        collateralCoin,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2LoanFlexibleCollateralDataResponse
}
catch (SdkException<GetFlexibleLoanCollateralAssetsDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleCollateralDataResponse](Models/SapiV2LoanFlexibleCollateralDataResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFlexibleLoanCollateralAssetsDataUserDataError](Errors/GetFlexibleLoanCollateralAssetsDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanLtvAdjustmentHistoryResponse&gt; GetLoanLtvAdjustmentHistoryUserData(long timestamp, string signature, long? orderId, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

If startTime and endTime are not sent, the recent 90-day data will be returned.
The max interval between startTime and endTime is 180 days.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.GetLoanLtvAdjustmentHistoryUserData(timestamp,
        signature,
        orderId,
        loanCoin,
        collateralCoin,
        startTime,
        endTime,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanLtvAdjustmentHistoryResponse
}
catch (SdkException<GetLoanLtvAdjustmentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order ID |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>long?</code> | default 10, max 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanLtvAdjustmentHistoryResponse](Models/SapiV1LoanLtvAdjustmentHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLoanLtvAdjustmentHistoryUserDataError](Errors/GetLoanLtvAdjustmentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanOngoingOrdersResponse&gt; GetLoanOngoingOrdersUserData(long timestamp, string signature, long? orderId, string? loanCoin, string? collateralCoin, int? current, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 300

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.GetLoanOngoingOrdersUserData(timestamp,
        signature,
        orderId,
        loanCoin,
        collateralCoin,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanOngoingOrdersResponse
}
catch (SdkException<GetLoanOngoingOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | orderId in POST /sapi/v1/loan/borrow |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1; default:1, max:1000 |
| <code>limit</code> | <code>long?</code> | default 10, max 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanOngoingOrdersResponse](Models/SapiV1LoanOngoingOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLoanOngoingOrdersUserDataError](Errors/GetLoanOngoingOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanRepayHistoryResponse&gt; GetLoanRepaymentHistoryUserData(long timestamp, string signature, long? orderId, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

If startTime and endTime are not sent, the recent 90-day data will be returned.
The max interval between startTime and endTime is 180 days.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.GetLoanRepaymentHistoryUserData(timestamp,
        signature,
        orderId,
        loanCoin,
        collateralCoin,
        startTime,
        endTime,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanRepayHistoryResponse
}
catch (SdkException<GetLoanRepaymentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order ID |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>long?</code> | default 10, max 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanRepayHistoryResponse](Models/SapiV1LoanRepayHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLoanRepaymentHistoryUserDataError](Errors/GetLoanRepaymentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanLoanableDataResponse&gt; GetLoanableAssetsDataUserData(long timestamp, string signature, string? loanCoin, int? vipLevel, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get interest rate and borrow limit of loanable assets. The borrow limit is shown in USD value.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.GetLoanableAssetsDataUserData(timestamp,
        signature,
        loanCoin,
        vipLevel,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanLoanableDataResponse
}
catch (SdkException<GetLoanableAssetsDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>vipLevel</code> | <code>int?</code> | Defaults to user's vip level |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanLoanableDataResponse](Models/SapiV1LoanLoanableDataResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLoanableAssetsDataUserDataError](Errors/GetLoanableAssetsDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleRepayResponse&gt; RepayFlexibleLoanRepayTrade(double repayAmount, long timestamp, string signature, string? loanCoin, string? collateralCoin, bool? collateralReturn, bool? fullRepayment, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- repayAmount is mandatory even fullRepayment = FALSE

Weight(IP): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.RepayFlexibleLoanRepayTrade(repayAmount,
        timestamp,
        signature,
        loanCoin,
        collateralCoin,
        collateralReturn,
        fullRepayment,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2LoanFlexibleRepayResponse
}
catch (SdkException<RepayFlexibleLoanRepayTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>repayAmount</code> | <code>double</code> | repay amount of loanCoin |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>collateralReturn</code> | <code>bool?</code> | Default: TRUE.<br>TRUE: Return extra collateral to earn account;<br>FALSE: Keep extra collateral in the order, and lower LTV. |
| <code>fullRepayment</code> | <code>bool?</code> | Default: FALSE.<br>TRUE: Full repayment;<br>FALSE: Partial repayment, based on loanAmount |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleRepayResponse](Models/SapiV2LoanFlexibleRepayResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RepayFlexibleLoanRepayTradeError](Errors/RepayFlexibleLoanRepayTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleRepayHistoryResponse&gt; RepayGetFlexibleLoanRepaymentHistoryUserData(long timestamp, string signature, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If startTime and endTime are not sent, the recent 90-day data will be returned.
- The max interval between startTime and endTime is 180 days.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CryptoLoans.RepayGetFlexibleLoanRepaymentHistoryUserData(timestamp,
        signature,
        loanCoin,
        collateralCoin,
        startTime,
        endTime,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2LoanFlexibleRepayHistoryResponse
}
catch (SdkException<RepayGetFlexibleLoanRepaymentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleRepayHistoryResponse](Models/SapiV2LoanFlexibleRepayHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RepayGetFlexibleLoanRepaymentHistoryUserDataError](Errors/RepayGetFlexibleLoanRepaymentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DualInvestment

> Source: [DualInvestment](Api/DualInvestment.cs)

<details>
<summary><code>Task&lt;SapiV1DciProductAutoCompoundEditStatusResponse&gt; ChangeAutoCompoundStatusUserData(long positionId, AutoCompoundPlan autoCompoundPlan, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Change Auto-Compound status

- 15:31 ~ 16:00 UTC+8 This function is disabled

Weight(IP): 1

Rate Limit: Maximum 1 time/s per account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DualInvestment.ChangeAutoCompoundStatusUserData(positionId,
        autoCompoundPlan,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1DciProductAutoCompoundEditStatusResponse
}
catch (SdkException<ChangeAutoCompoundStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>positionId</code> | <code>long</code> | Get positionId from /sapi/v1/dci/product/positions |
| <code>autoCompoundPlan</code> | <code>[AutoCompoundPlan](Models/Enums/AutoCompoundPlan.cs)</code> | NONE: switch off the plan,<br>STANDARD: standard plan,<br>ADVANCED: advanced plan; |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductAutoCompoundEditStatusResponse](Models/SapiV1DciProductAutoCompoundEditStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ChangeAutoCompoundStatusUserDataError](Errors/ChangeAutoCompoundStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1DciProductAccountsResponse&gt; CheckDualInvestmentAccountsUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Check Dual Investment accounts

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DualInvestment.CheckDualInvestmentAccountsUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1DciProductAccountsResponse
}
catch (SdkException<CheckDualInvestmentAccountsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductAccountsResponse](Models/SapiV1DciProductAccountsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckDualInvestmentAccountsUserDataError](Errors/CheckDualInvestmentAccountsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1DciProductPositionsResponse&gt; GetDualInvestmentPositionsUserData(long timestamp, string signature, Status2? status, string? pageSize, int? pageIndex, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Dual Investment positions (batch)

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DualInvestment.GetDualInvestmentPositionsUserData(timestamp,
        signature,
        status,
        pageSize,
        pageIndex,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1DciProductPositionsResponse
}
catch (SdkException<GetDualInvestmentPositionsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>status</code> | <code>[Status2?](Models/Enums/Status2.cs)</code> | - PENDING: Products are purchasing, will give results later;<br>- PURCHASE_SUCCESS: purchase successfully;<br>- SETTLED: Products are finish settling;<br>- PURCHASE_FAIL: fail to purchase;<br>- REFUNDING: refund ongoing;<br>- REFUND_SUCCESS: refund to spot account successfully;<br>- SETTLING: Products are settling.<br>If don't fill this field, will response all the position status. |
| <code>pageSize</code> | <code>string?</code> | MIN 1, MAX 100; Default 100 |
| <code>pageIndex</code> | <code>int?</code> | Page number, default is first page, start form 1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductPositionsResponse](Models/SapiV1DciProductPositionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDualInvestmentPositionsUserDataError](Errors/GetDualInvestmentPositionsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1DciProductListResponse&gt; GetDualInvestmentProductListUserData(OptionType optionType, string exercisedCoin, string investCoin, long timestamp, string signature, string? pageSize, int? pageIndex, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Dual Investment product list

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DualInvestment.GetDualInvestmentProductListUserData(optionType,
        exercisedCoin,
        investCoin,
        timestamp,
        signature,
        pageSize,
        pageIndex,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1DciProductListResponse
}
catch (SdkException<GetDualInvestmentProductListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>optionType</code> | <code>[OptionType](Models/Enums/OptionType.cs)</code> | Input CALL or PUT |
| <code>exercisedCoin</code> | <code>string</code> | Target exercised asset, e.g.:<br>if you subscribe to a high sell product (call option), you should input:<br>  - optionType: CALL,<br>  - exercisedCoin: USDT,<br>  - investCoin: BNB;<br><br>if you subscribe to a low buy product (put option), you should input:<br>  - optionType: PUT,<br>  - exercisedCoin: BNB,<br>  - investCoin: USDT; |
| <code>investCoin</code> | <code>string</code> | Asset used for subscribing, e.g.:<br>if you subscribe to a high sell product (call option), you should input:<br>  - optionType: CALL,<br>  - exercisedCoin: USDT,<br>  - investCoin: BNB;<br><br>if you subscribe to a low buy product (put option), you should input:<br>  - optionType: PUT,<br>  - exercisedCoin: BNB,<br>  - investCoin: USDT; |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>pageSize</code> | <code>string?</code> | MIN 1, MAX 100; Default 100 |
| <code>pageIndex</code> | <code>int?</code> | Page number, default is first page, start form 1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductListResponse](Models/SapiV1DciProductListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDualInvestmentProductListUserDataError](Errors/GetDualInvestmentProductListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1DciProductSubscribeResponse&gt; SubscribeDualInvestmentProductsUserData(string id, string orderId, double depositAmount, AutoCompoundPlan autoCompoundPlan, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Subscribe Dual Investment products

- `Products are not available.` means that the APR changes to lower value, or the orders are not available.
- `Failed` is a system or network errors.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DualInvestment.SubscribeDualInvestmentProductsUserData(id,
        orderId,
        depositAmount,
        autoCompoundPlan,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1DciProductSubscribeResponse
}
catch (SdkException<SubscribeDualInvestmentProductsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | get id from /sapi/v1/dci/product/list |
| <code>orderId</code> | <code>string</code> | get orderId from /sapi/v1/dci/product/list |
| <code>depositAmount</code> | <code>double</code> | - |
| <code>autoCompoundPlan</code> | <code>[AutoCompoundPlan](Models/Enums/AutoCompoundPlan.cs)</code> | NONE: switch off the plan,<br>STANDARD: standard plan,<br>ADVANCED: advanced plan; |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductSubscribeResponse](Models/SapiV1DciProductSubscribeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubscribeDualInvestmentProductsUserDataError](Errors/SubscribeDualInvestmentProductsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Fiat

> Source: [Fiat](Api/Fiat.cs)

<details>
<summary><code>Task&lt;SapiV1FiatOrdersResponse&gt; FiatDepositWithdrawHistoryUserData(int transactionType, long timestamp, string signature, long? beginTime, long? endTime, int? page, int? rows, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If beginTime and endTime are not sent, the recent 30-day data will be returned.

Weight(UID): 90000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Fiat.FiatDepositWithdrawHistoryUserData(transactionType,
        timestamp,
        signature,
        beginTime,
        endTime,
        page,
        rows,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1FiatOrdersResponse
}
catch (SdkException<FiatDepositWithdrawHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transactionType</code> | <code>int</code> | * `0` - deposit<br>* `1` - withdraw |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>beginTime</code> | <code>long?</code> | - |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>rows</code> | <code>int?</code> | Default 100, max 500 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FiatOrdersResponse](Models/SapiV1FiatOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FiatDepositWithdrawHistoryUserDataError](Errors/FiatDepositWithdrawHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1FiatPaymentsResponse&gt; FiatPaymentsHistoryUserData(int transactionType, long timestamp, string signature, long? beginTime, long? endTime, int? page, int? rows, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If beginTime and endTime are not sent, the recent 30-day data will be returned.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Fiat.FiatPaymentsHistoryUserData(transactionType,
        timestamp,
        signature,
        beginTime,
        endTime,
        page,
        rows,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1FiatPaymentsResponse
}
catch (SdkException<FiatPaymentsHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transactionType</code> | <code>int</code> | * `0` - deposit<br>* `1` - withdraw |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>beginTime</code> | <code>long?</code> | - |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>rows</code> | <code>int?</code> | Default 100, max 500 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FiatPaymentsResponse](Models/SapiV1FiatPaymentsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FiatPaymentsHistoryUserDataError](Errors/FiatPaymentsHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Futures

> Source: [Futures](Api/Futures.cs)

<details>
<summary><code>Task&lt;SapiV1FuturesTransferResponse1&gt; GetFutureAccountTransactionHistoryListUserData(string asset, long startTime, long timestamp, string signature, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Futures.GetFutureAccountTransactionHistoryListUserData(asset,
        startTime,
        timestamp,
        signature,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1FuturesTransferResponse1
}
catch (SdkException<GetFutureAccountTransactionHistoryListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>startTime</code> | <code>long</code> | UTC timestamp in ms |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FuturesTransferResponse1](Models/SapiV1FuturesTransferResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFutureAccountTransactionHistoryListUserDataError](Errors/GetFutureAccountTransactionHistoryListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1FuturesHistDataLinkResponse&gt; GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData(string symbol, DataTypeEnum dataType, long timestamp, string signature, long? startTime, long? endTime, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Futures.GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData(symbol,
        dataType,
        timestamp,
        signature,
        startTime,
        endTime,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1FuturesHistDataLinkResponse
}
catch (SdkException<GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | - |
| <code>dataType</code> | <code>[DataTypeEnum](Models/Enums/DataTypeEnum.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FuturesHistDataLinkResponse](Models/SapiV1FuturesHistDataLinkResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError](Errors/GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1FuturesTransferResponse&gt; NewFutureAccountTransferUserData(string asset, double amount, long type, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Execute transfer between spot account and futures account.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Futures.NewFutureAccountTransferUserData(asset,
        amount,
        type,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1FuturesTransferResponse
}
catch (SdkException<NewFutureAccountTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>type</code> | <code>long</code> | 1: transfer from spot account to USDT-Ⓜ futures account. 2: transfer from USDT-Ⓜ futures account to spot account. 3: transfer from spot account to COIN-Ⓜ futures account. 4: transfer from COIN-Ⓜ futures account to spot account. |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FuturesTransferResponse](Models/SapiV1FuturesTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[NewFutureAccountTransferUserDataError](Errors/NewFutureAccountTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FuturesAlgo

> Source: [FuturesAlgo](Api/FuturesAlgo.cs)

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesOrderResponse&gt; CancelAlgoOrderTrade(long algoId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel an active order.
- You need to enable Futures Trading Permission for the api key which requests this endpoint.
- Base URL: https://api.binance.com

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FuturesAlgo.CancelAlgoOrderTrade(algoId, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoFuturesOrderResponse
}
catch (SdkException<CancelAlgoOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algoId</code> | <code>long</code> | Eg. 14511 |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesOrderResponse](Models/SapiV1AlgoFuturesOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelAlgoOrderTradeError](Errors/CancelAlgoOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesOpenOrdersResponse&gt; QueryCurrentAlgoOpenOrdersUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- You need to enable Futures Trading Permission for the api key which requests this endpoint.
- Base URL: https://api.binance.com

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FuturesAlgo.QueryCurrentAlgoOpenOrdersUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoFuturesOpenOrdersResponse
}
catch (SdkException<QueryCurrentAlgoOpenOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesOpenOrdersResponse](Models/SapiV1AlgoFuturesOpenOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryCurrentAlgoOpenOrdersUserDataError](Errors/QueryCurrentAlgoOpenOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesHistoricalOrdersResponse&gt; QueryHistoricalAlgoOrdersUserData(long timestamp, string signature, string? symbol, Side? side, long? startTime, long? endTime, int? page, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- You need to enable Futures Trading Permission for the api key which requests this endpoint.
- Base URL: https://api.binance.com

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FuturesAlgo.QueryHistoricalAlgoOrdersUserData(timestamp,
        signature,
        symbol,
        side,
        startTime,
        endTime,
        page,
        pageSize,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoFuturesHistoricalOrdersResponse
}
catch (SdkException<QueryHistoricalAlgoOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side?](Models/Enums/Side.cs)</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>pageSize</code> | <code>string?</code> | MIN 1, MAX 100; Default 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesHistoricalOrdersResponse](Models/SapiV1AlgoFuturesHistoricalOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryHistoricalAlgoOrdersUserDataError](Errors/QueryHistoricalAlgoOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesSubOrdersResponse&gt; QuerySubOrdersUserData(long algoId, long timestamp, string signature, int? page, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- You need to enable Futures Trading Permission for the api key which requests this endpoint.
- Base URL: https://api.binance.com

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FuturesAlgo.QuerySubOrdersUserData(algoId,
        timestamp,
        signature,
        page,
        pageSize,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoFuturesSubOrdersResponse
}
catch (SdkException<QuerySubOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algoId</code> | <code>long</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>pageSize</code> | <code>string?</code> | MIN 1, MAX 100; Default 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesSubOrdersResponse](Models/SapiV1AlgoFuturesSubOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QuerySubOrdersUserDataError](Errors/QuerySubOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesNewOrderTwapResponse&gt; TimeWeightedAveragePriceTwapNewOrderTrade(string symbol, Side side, double quantity, long duration, long timestamp, string signature, PositionSide? positionSide, string? clientAlgoId, bool? reduceOnly, double? limitPrice, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Send in a Twap new order. Only support on USDⓈ-M Contracts.

You need to enable Futures Trading Permission for the api key which requests this endpoint.
Base URL: https://api.binance.com

- Total Algo open orders max allowed: 10 orders.
- Leverage of symbols and position mode will be the same as your futures account settings. You can set up through the trading page or fapi.
- Receiving "success": true does not mean that your order will be executed. Please use the query order endpoints(GET sapi/v1/algo/futures/openOrders or GET sapi/v1/algo/futures/historicalOrders) to check the order status. For example: Your futures balance is insufficient, or open position with reduce only or position side is inconsistent with your own setting. In these cases you will receive "success": true, but the order status will be expired after we check it.
- quantity * 60 / duration should be larger than minQty
- duration cannot be less than 5 mins or more than 24 hours.
- For delivery contracts, TWAP end time should be one hour earlier than the delivery time of the symbol.

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FuturesAlgo.TimeWeightedAveragePriceTwapNewOrderTrade(symbol,
        side,
        quantity,
        duration,
        timestamp,
        signature,
        positionSide,
        clientAlgoId,
        reduceOnly,
        limitPrice,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoFuturesNewOrderTwapResponse
}
catch (SdkException<TimeWeightedAveragePriceTwapNewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>quantity</code> | <code>double</code> | Quantity of base asset; The notional (quantity * mark price(base asset)) must be more than the equivalent of 10,000 USDT and less than the equivalent of 1,000,000 USDT |
| <code>duration</code> | <code>long</code> | Duration for TWAP orders in seconds. [300, 86400];Less than 5min => defaults to 5 min; Greater than 24h => defaults to 24h |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>positionSide</code> | <code>[PositionSide?](Models/Enums/PositionSide.cs)</code> | Default BOTH for One-way Mode ; LONG or SHORT for Hedge Mode. It must be sent in Hedge Mode. |
| <code>clientAlgoId</code> | <code>string?</code> | A unique id among Algo orders (length should be 32 characters)， If it is not sent, we will give default value |
| <code>reduceOnly</code> | <code>bool?</code> | 'true' or 'false'. Default 'false'; Cannot be sent in Hedge Mode; Cannot be sent when you open a position |
| <code>limitPrice</code> | <code>double?</code> | Limit price of the order; If it is not sent, will place order by market price by default |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesNewOrderTwapResponse](Models/SapiV1AlgoFuturesNewOrderTwapResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TimeWeightedAveragePriceTwapNewOrderTradeError](Errors/TimeWeightedAveragePriceTwapNewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesNewOrderVpResponse&gt; VolumeParticipationVpNewOrderTrade(string symbol, Side side, double quantity, Urgency urgency, long timestamp, string signature, PositionSide? positionSide, string? clientAlgoId, bool? reduceOnly, double? limitPrice, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Send in a VP new order. Only support on USDⓈ-M Contracts.

- You need to enable `Futures Trading Permission` for the api key which requests this endpoint.
- Base URL: https://api.binance.com

- Total Algo open orders max allowed: 10 orders.
- Leverage of symbols and position mode will be the same as your futures account settings. You can set up through the trading page or fapi.
- Receiving "success": true does not mean that your order will be executed. Please use the query order endpoints(GET sapi/v1/algo/futures/openOrders or GET sapi/v1/algo/futures/historicalOrders) to check the order status. For example: Your futures balance is insufficient, or open position with reduce only or position side is inconsistent with your own setting. In these cases you will receive "success": true, but the order status will be expired after we check it.

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FuturesAlgo.VolumeParticipationVpNewOrderTrade(symbol,
        side,
        quantity,
        urgency,
        timestamp,
        signature,
        positionSide,
        clientAlgoId,
        reduceOnly,
        limitPrice,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoFuturesNewOrderVpResponse
}
catch (SdkException<VolumeParticipationVpNewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>quantity</code> | <code>double</code> | Quantity of base asset; The notional (quantity * mark price(base asset)) must be more than the equivalent of 10,000 USDT and less than the equivalent of 1,000,000 USDT |
| <code>urgency</code> | <code>[Urgency](Models/Enums/Urgency.cs)</code> | Represent the relative speed of the current execution; ENUM: LOW, MEDIUM, HIGH |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>positionSide</code> | <code>[PositionSide?](Models/Enums/PositionSide.cs)</code> | Default BOTH for One-way Mode ; LONG or SHORT for Hedge Mode. It must be sent in Hedge Mode. |
| <code>clientAlgoId</code> | <code>string?</code> | A unique id among Algo orders (length should be 32 characters)， If it is not sent, we will give default value |
| <code>reduceOnly</code> | <code>bool?</code> | 'true' or 'false'. Default 'false'; Cannot be sent in Hedge Mode; Cannot be sent when you open a position |
| <code>limitPrice</code> | <code>double?</code> | Limit price of the order; If it is not sent, will place order by market price by default |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesNewOrderVpResponse](Models/SapiV1AlgoFuturesNewOrderVpResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VolumeParticipationVpNewOrderTradeError](Errors/VolumeParticipationVpNewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GiftCard

> Source: [GiftCard](Api/GiftCard.cs)

<details>
<summary><code>Task&lt;SapiV1GiftcardBuyCodeResponse&gt; BuyABinanceCodeTrade(string baseToken, string faceToken, double baseTokenAmount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API is for buying a fixed-value Binance Code, which means your Binance Code will be redeemable to a token that is different to the token that you are paying in. If the token you’re paying and the redeemable token are the same, please use the Create Binance Code endpoint.
You can use supported crypto currency or fiat token as baseToken to buy Binance Code that is redeemable to your chosen faceToken.
Once successfully purchased, the amount of baseToken would be deducted from your funding wallet.

To get started with, please make sure:
- You have a Binance account
- You have passed kyc
- You have a sufficient balance in your Binance funding wallet
- You need Enable Withdrawals for the API Key which requests this endpoint.

Daily creation volume: 2 BTC / 24H Daily creation times: 200 Codes / 24H

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCard.BuyABinanceCodeTrade(baseToken,
        faceToken,
        baseTokenAmount,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1GiftcardBuyCodeResponse
}
catch (SdkException<BuyABinanceCodeTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>baseToken</code> | <code>string</code> | The token you want to pay, example BUSD |
| <code>faceToken</code> | <code>string</code> | The token you want to buy, example BNB. If faceToken = baseToken, it's the same as createCode endpoint. |
| <code>baseTokenAmount</code> | <code>double</code> | The base token asset quantity, example  1.002 |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardBuyCodeResponse](Models/SapiV1GiftcardBuyCodeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BuyABinanceCodeTradeError](Errors/BuyABinanceCodeTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardCreateCodeResponse&gt; CreateABinanceCodeUserData(string token, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API is for creating a Binance Code. To get started with, please make sure:

- You have a Binance account
- You have passed kyc
- You have a sufficient balance in your Binance funding wallet
- You need Enable Withdrawals for the API Key which requests this endpoint.

Daily creation volume: 2 BTC / 24H Daily creation times: 200 Codes / 24H

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCard.CreateABinanceCodeUserData(token, amount, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1GiftcardCreateCodeResponse
}
catch (SdkException<CreateABinanceCodeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | The coin type contained in the Binance Code |
| <code>amount</code> | <code>double</code> | The amount of the coin |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardCreateCodeResponse](Models/SapiV1GiftcardCreateCodeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateABinanceCodeUserDataError](Errors/CreateABinanceCodeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardCryptographyRsaPublicKeyResponse&gt; FetchRsaPublicKeyUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API is for fetching the RSA Public Key.
This RSA Public key will be used to encrypt the card code.
Please note that the RSA Public key fetched is valid only for the current day.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCard.FetchRsaPublicKeyUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1GiftcardCryptographyRsaPublicKeyResponse
}
catch (SdkException<FetchRsaPublicKeyUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardCryptographyRsaPublicKeyResponse](Models/SapiV1GiftcardCryptographyRsaPublicKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FetchRsaPublicKeyUserDataError](Errors/FetchRsaPublicKeyUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardBuyCodeTokenLimitResponse&gt; FetchTokenLimitUserData(string baseToken, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API is to help you verify which tokens are available for you to purchase fixed-value gift cards as mentioned in section 2 and it's limitation.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCard.FetchTokenLimitUserData(baseToken, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1GiftcardBuyCodeTokenLimitResponse
}
catch (SdkException<FetchTokenLimitUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>baseToken</code> | <code>string</code> | The token you want to pay, example BUSD |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardBuyCodeTokenLimitResponse](Models/SapiV1GiftcardBuyCodeTokenLimitResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FetchTokenLimitUserDataError](Errors/FetchTokenLimitUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardRedeemCodeResponse&gt; RedeemABinanceCodeUserData(string code, long timestamp, string signature, string? externalUid, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API is for redeeming the Binance Code. Once redeemed, the coins will be deposited in your funding wallet.

Please note that if you enter the wrong code 5 times within 24 hours, you will no longer be able to redeem any Binance Code that day.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCard.RedeemABinanceCodeUserData(code,
        timestamp,
        signature,
        externalUid,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1GiftcardRedeemCodeResponse
}
catch (SdkException<RedeemABinanceCodeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>code</code> | <code>string</code> | Binance Code |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>externalUid</code> | <code>string?</code> | Each external unique ID represents a unique user on the partner platform. The function helps you to identify the redemption behavior of different users, such as redemption frequency and amount. It also helps risk and limit control of a single account, such as daily limit on redemption volume, frequency, and incorrect number of entries. This will also prevent a single user account reach the partner's daily redemption limits. We strongly recommend you to use this feature and transfer us the User ID of your users if you have different users redeeming Binance codes on your platform. To protect user data privacy, you may choose to transfer the user id in any desired format (max. 400 characters). |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardRedeemCodeResponse](Models/SapiV1GiftcardRedeemCodeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RedeemABinanceCodeUserDataError](Errors/RedeemABinanceCodeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardVerifyResponse&gt; VerifyABinanceCodeUserData(string referenceNo, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API is for verifying whether the Binance Code is valid or not by entering Binance Code or reference number.

Please note that if you enter the wrong binance code 5 times within an hour, you will no longer be able to verify any binance code for that hour.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCard.VerifyABinanceCodeUserData(referenceNo, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1GiftcardVerifyResponse
}
catch (SdkException<VerifyABinanceCodeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>referenceNo</code> | <code>string</code> | reference number |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardVerifyResponse](Models/SapiV1GiftcardVerifyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VerifyABinanceCodeUserDataError](Errors/VerifyABinanceCodeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IsolatedMarginStream

> Source: [IsolatedMarginStream](Api/IsolatedMarginStream.cs)

<details>
<summary><code>Task&lt;object&gt; CloseAListenKeyUserStream3(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Close out a user data stream.

Weight: 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IsolatedMarginStream.CloseAListenKeyUserStream3(listenKey);
    // TODO: Handle 'response' of type object
}
catch (SdkException<CloseAListenKeyUserStream3Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>listenKey</code> | <code>string?</code> | User websocket listen key |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CloseAListenKeyUserStream3Error](Errors/CloseAListenKeyUserStream3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1UserDataStreamIsolatedResponse&gt; GenerateAListenKeyUserStream(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Start a new user data stream.
The stream will close after 60 minutes unless a keepalive is sent. If the account has an active `listenKey`, that `listenKey` will be returned and its validity will be extended for 60 minutes.

Weight: 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IsolatedMarginStream.GenerateAListenKeyUserStream();
    // TODO: Handle 'response' of type SapiV1UserDataStreamIsolatedResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1UserDataStreamIsolatedResponse](Models/SapiV1UserDataStreamIsolatedResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; PingKeepAliveAListenKeyUserStream(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Keepalive a user data stream to prevent a time out. User data streams will close after 60 minutes. It's recommended to send a ping about every 30 minutes.

Weight: 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IsolatedMarginStream.PingKeepAliveAListenKeyUserStream(listenKey);
    // TODO: Handle 'response' of type object
}
catch (SdkException<PingKeepAliveAListenKeyUserStreamApiError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>listenKey</code> | <code>string?</code> | User websocket listen key |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PingKeepAliveAListenKeyUserStreamApiError](Errors/PingKeepAliveAListenKeyUserStreamApiError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Margin

> Source: [Margin](Api/Margin.cs)

<details>
<summary><code>Task&lt;SapiV1MarginMaxLeverageResponse&gt; AdjustCrossMarginMaxLeverageUserData(int maxLeverage, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adjust cross margin max leverage

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.AdjustCrossMarginMaxLeverageUserData(maxLeverage,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginMaxLeverageResponse
}
catch (SdkException<AdjustCrossMarginMaxLeverageUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>maxLeverage</code> | <code>int</code> | Can only adjust 3 or 5 |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginMaxLeverageResponse](Models/SapiV1MarginMaxLeverageResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AdjustCrossMarginMaxLeverageUserDataError](Errors/AdjustCrossMarginMaxLeverageUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginCrossMarginCollateralRatioResponse&gt;&gt; CrossMarginCollateralRatioMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>


Weight(IP): 100

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.CrossMarginCollateralRatioMarketData();
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginCrossMarginCollateralRatioResponse>
}
catch (SdkException<CrossMarginCollateralRatioMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginCrossMarginCollateralRatioResponse](Models/SapiV1MarginCrossMarginCollateralRatioResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CrossMarginCollateralRatioMarketDataError](Errors/CrossMarginCollateralRatioMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginIsolatedAccountResponse&gt; DisableIsolatedMarginAccountTrade(string symbol, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disable isolated margin account for a specific symbol. Each trading pair can only be deactivated once every 24 hours .

Weight(UID): 300

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.DisableIsolatedMarginAccountTrade(symbol, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginIsolatedAccountResponse
}
catch (SdkException<DisableIsolatedMarginAccountTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginIsolatedAccountResponse](Models/SapiV1MarginIsolatedAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DisableIsolatedMarginAccountTradeError](Errors/DisableIsolatedMarginAccountTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginIsolatedAccountResponse&gt; EnableIsolatedMarginAccountTrade(string symbol, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable isolated margin account for a specific symbol.

Weight(UID): 300

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.EnableIsolatedMarginAccountTrade(symbol, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginIsolatedAccountResponse
}
catch (SdkException<EnableIsolatedMarginAccountTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginIsolatedAccountResponse](Models/SapiV1MarginIsolatedAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EnableIsolatedMarginAccountTradeError](Errors/EnableIsolatedMarginAccountTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginAllPairsResponse&gt;&gt; GetAllCrossMarginPairsMarketData(string symbol, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetAllCrossMarginPairsMarketData(symbol);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginAllPairsResponse>
}
catch (SdkException<GetAllCrossMarginPairsMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginAllPairsResponse](Models/SapiV1MarginAllPairsResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAllCrossMarginPairsMarketDataError](Errors/GetAllCrossMarginPairsMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginIsolatedAllPairsResponse&gt;&gt; GetAllIsolatedMarginSymbolUserData(string symbol, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetAllIsolatedMarginSymbolUserData(symbol, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginIsolatedAllPairsResponse>
}
catch (SdkException<GetAllIsolatedMarginSymbolUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginIsolatedAllPairsResponse](Models/SapiV1MarginIsolatedAllPairsResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAllIsolatedMarginSymbolUserDataError](Errors/GetAllIsolatedMarginSymbolUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginAllAssetsResponse&gt;&gt; GetAllMarginAssetsMarketData(string asset, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetAllMarginAssetsMarketData(asset);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginAllAssetsResponse>
}
catch (SdkException<GetAllMarginAssetsMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginAllAssetsResponse](Models/SapiV1MarginAllAssetsResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAllMarginAssetsMarketDataError](Errors/GetAllMarginAssetsMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BnbBurnStatus&gt; GetBnbBurnStatusUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetBnbBurnStatusUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type BnbBurnStatus
}
catch (SdkException<GetBnbBurnStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BnbBurnStatus](Models/BnbBurnStatus.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBnbBurnStatusUserDataError](Errors/GetBnbBurnStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginTransferResponse&gt; GetCrossMarginTransferHistoryUserData(long timestamp, string signature, string? asset, Type2? type, long? startTime, long? endTime, int? current, int? size, string? isolatedSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Response in descending order
- Returns data for last 7 days by default
- Set `archived` to `true` to query data from 6 months ago

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetCrossMarginTransferHistoryUserData(timestamp,
        signature,
        asset,
        type,
        startTime,
        endTime,
        current,
        size,
        isolatedSymbol,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginTransferResponse
}
catch (SdkException<GetCrossMarginTransferHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>type</code> | <code>[Type2?](Models/Enums/Type2.cs)</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>isolatedSymbol</code> | <code>string?</code> | Isolated symbol |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginTransferResponse](Models/SapiV1MarginTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCrossMarginTransferHistoryUserDataError](Errors/GetCrossMarginTransferHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginForceLiquidationRecResponse&gt; GetForceLiquidationRecordUserData(long timestamp, string signature, long? startTime, long? endTime, string? isolatedSymbol, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Response in descending order

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetForceLiquidationRecordUserData(timestamp,
        signature,
        startTime,
        endTime,
        isolatedSymbol,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginForceLiquidationRecResponse
}
catch (SdkException<GetForceLiquidationRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>isolatedSymbol</code> | <code>string?</code> | Isolated symbol |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginForceLiquidationRecResponse](Models/SapiV1MarginForceLiquidationRecResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetForceLiquidationRecordUserDataError](Errors/GetForceLiquidationRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginInterestHistoryResponse&gt; GetInterestHistoryUserData(long timestamp, string signature, string? asset, string? isolatedSymbol, long? startTime, long? endTime, int? current, int? size, string? archived, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Response in descending order
- If `isolatedSymbol` is not sent, crossed margin data will be returned
- Set `archived` to `true` to query data from 6 months ago
- `type` in response has 4 enums:
  - `PERIODIC` interest charged per hour
  - `ON_BORROW` first interest charged on borrow
  - `PERIODIC_CONVERTED` interest charged per hour converted into BNB
  - `ON_BORROW_CONVERTED` first interest charged on borrow converted into BNB

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetInterestHistoryUserData(timestamp,
        signature,
        asset,
        isolatedSymbol,
        startTime,
        endTime,
        current,
        size,
        archived,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginInterestHistoryResponse
}
catch (SdkException<GetInterestHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>isolatedSymbol</code> | <code>string?</code> | Isolated symbol |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>archived</code> | <code>string?</code> | Default: false. Set to true for archived data from 6 months ago |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginInterestHistoryResponse](Models/SapiV1MarginInterestHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetInterestHistoryUserDataError](Errors/GetInterestHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginExchangeSmallLiabilityResponse&gt;&gt; GetSmallLiabilityExchangeCoinListUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query the coins which can be small liability exchange

Weight(UID): 100

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetSmallLiabilityExchangeCoinListUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginExchangeSmallLiabilityResponse>
}
catch (SdkException<GetSmallLiabilityExchangeCoinListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginExchangeSmallLiabilityResponse](Models/SapiV1MarginExchangeSmallLiabilityResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSmallLiabilityExchangeCoinListUserDataError](Errors/GetSmallLiabilityExchangeCoinListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginExchangeSmallLiabilityHistoryResponse&gt; GetSmallLiabilityExchangeHistoryUserData(long timestamp, string signature, int? current, int? size, long? startTime, long? endTime, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Small liability Exchange History

Weight(UID): 100

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetSmallLiabilityExchangeHistoryUserData(timestamp,
        signature,
        current,
        size,
        startTime,
        endTime,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginExchangeSmallLiabilityHistoryResponse
}
catch (SdkException<GetSmallLiabilityExchangeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginExchangeSmallLiabilityHistoryResponse](Models/SapiV1MarginExchangeSmallLiabilityHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSmallLiabilityExchangeHistoryUserDataError](Errors/GetSmallLiabilityExchangeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginTradeCoeffResponse&gt; GetSummaryOfMarginAccountUserData(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get personal margin level information

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetSummaryOfMarginAccountUserData(email, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginTradeCoeffResponse
}
catch (SdkException<GetSummaryOfMarginAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Email Address |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginTradeCoeffResponse](Models/SapiV1MarginTradeCoeffResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSummaryOfMarginAccountUserDataError](Errors/GetSummaryOfMarginAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginNextHourlyInterestRateResponse&gt;&gt; GetAFutureHourlyInterestRateUserData(long timestamp, string signature, string? assets, IsIsolated? isIsolated, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get user the next hourly estimate interest

Weight(UID): 100

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetAFutureHourlyInterestRateUserData(timestamp,
        signature,
        assets,
        isIsolated,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginNextHourlyInterestRateResponse>
}
catch (SdkException<GetAFutureHourlyInterestRateUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>assets</code> | <code>string?</code> | List of assets, separated by commas, up to 20 |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | for isolated margin or not, "TRUE", "FALSE" |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginNextHourlyInterestRateResponse](Models/SapiV1MarginNextHourlyInterestRateResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAFutureHourlyInterestRateUserDataError](Errors/GetAFutureHourlyInterestRateUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginCapitalFlowResponse&gt;&gt; GetCrossOrIsolatedMarginCapitalFlowUserData(long timestamp, string signature, string? asset, string? symbol, Type3? type, long? startTime, long? endTime, long? fromId, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get cross or isolated margin capital flow

Weight(IP): 100

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetCrossOrIsolatedMarginCapitalFlowUserData(timestamp,
        signature,
        asset,
        symbol,
        type,
        startTime,
        endTime,
        fromId,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginCapitalFlowResponse>
}
catch (SdkException<GetCrossOrIsolatedMarginCapitalFlowUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>symbol</code> | <code>string?</code> | Required when querying isolated data |
| <code>type</code> | <code>[Type3?](Models/Enums/Type3.cs)</code> | - |
| <code>startTime</code> | <code>long?</code> | Only supports querying the data of the last 90 days |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>fromId</code> | <code>long?</code> | If fromId is set, the data with id > fromId will be returned. Otherwise the latest data will be returned |
| <code>limit</code> | <code>long?</code> | The number of data items returned each time is limited. Default 500; Max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginCapitalFlowResponse](Models/SapiV1MarginCapitalFlowResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCrossOrIsolatedMarginCapitalFlowUserDataError](Errors/GetCrossOrIsolatedMarginCapitalFlowUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginDelistScheduleResponse&gt;&gt; GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get tokens or symbols delist schedule for cross margin and isolated margin

Weight(IP): 100

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData(timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginDelistScheduleResponse>
}
catch (SdkException<GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginDelistScheduleResponse](Models/SapiV1MarginDelistScheduleResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError](Errors/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MarginOcoOrder&gt; MarginAccountCancelOcoTrade(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? orderListId, string? listClientOrderId, string? newClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel an entire Order List for a margin account

- Canceling an individual leg will cancel the entire OCO
- Either `orderListId` or `listClientOrderId` must be provided

Weight(UID): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginAccountCancelOcoTrade(symbol,
        timestamp,
        signature,
        isIsolated,
        orderListId,
        listClientOrderId,
        newClientOrderId,
        recvWindow);
    // TODO: Handle 'response' of type MarginOcoOrder
}
catch (SdkException<MarginAccountCancelOcoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>orderListId</code> | <code>long?</code> | Order list id |
| <code>listClientOrderId</code> | <code>string?</code> | A unique Id for the entire orderList |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MarginOcoOrder](Models/MarginOcoOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginAccountCancelOcoTradeError](Errors/MarginAccountCancelOcoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MarginOrder&gt; MarginAccountCancelOrderTrade(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? orderId, string? origClientOrderId, string? newClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel an active order for margin account.

Either `orderId` or `origClientOrderId` must be sent.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginAccountCancelOrderTrade(symbol,
        timestamp,
        signature,
        isIsolated,
        orderId,
        origClientOrderId,
        newClientOrderId,
        recvWindow);
    // TODO: Handle 'response' of type MarginOrder
}
catch (SdkException<MarginAccountCancelOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>origClientOrderId</code> | <code>string?</code> | Order id from client |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MarginOrder](Models/MarginOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginAccountCancelOrderTradeError](Errors/MarginAccountCancelOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginOpenOrdersResponse&gt;&gt; MarginAccountCancelAllOpenOrdersOnASymbolTrade(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Cancels all active orders on a symbol for margin account.
- This includes OCO orders.

Weight(IP): 1


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginAccountCancelAllOpenOrdersOnASymbolTrade(symbol,
        timestamp,
        signature,
        isIsolated,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginOpenOrdersResponse>
}
catch (SdkException<MarginAccountCancelAllOpenOrdersOnASymbolTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginOpenOrdersResponse](Models/AnyOf/SapiV1MarginOpenOrdersResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginAccountCancelAllOpenOrdersOnASymbolTradeError](Errors/MarginAccountCancelAllOpenOrdersOnASymbolTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderOcoResponse&gt; MarginAccountNewOcoTrade(string symbol, Side side, double quantity, double price, double stopPrice, long timestamp, string signature, IsIsolated? isIsolated, string? listClientOrderId, string? limitClientOrderId, double? limitIcebergQty, string? stopClientOrderId, double? stopLimitPrice, double? stopIcebergQty, StopLimitTimeInForce? stopLimitTimeInForce, NewOrderRespType? newOrderRespType, SideEffectType? sideEffectType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Send in a new OCO for a margin account

- Price Restrictions:
  - SELL: Limit Price > Last Price > Stop Price
  - BUY: Limit Price < Last Price < Stop Price
- Quantity Restrictions:
  - Both legs must have the same quantity
  - ICEBERG quantities however do not have to be the same.
- Order Rate Limit
  - OCO counts as 2 orders against the order rate limit.

Weight(UID): 6

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginAccountNewOcoTrade(symbol,
        side,
        quantity,
        price,
        stopPrice,
        timestamp,
        signature,
        isIsolated,
        listClientOrderId,
        limitClientOrderId,
        limitIcebergQty,
        stopClientOrderId,
        stopLimitPrice,
        stopIcebergQty,
        stopLimitTimeInForce,
        newOrderRespType,
        sideEffectType,
        selfTradePreventionMode,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginOrderOcoResponse
}
catch (SdkException<MarginAccountNewOcoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>quantity</code> | <code>double</code> | - |
| <code>price</code> | <code>double</code> | Order price |
| <code>stopPrice</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>listClientOrderId</code> | <code>string?</code> | A unique Id for the entire orderList |
| <code>limitClientOrderId</code> | <code>string?</code> | A unique Id for the limit order |
| <code>limitIcebergQty</code> | <code>double?</code> | - |
| <code>stopClientOrderId</code> | <code>string?</code> | A unique Id for the stop loss/stop loss limit leg |
| <code>stopLimitPrice</code> | <code>double?</code> | If provided, stopLimitTimeInForce is required. |
| <code>stopIcebergQty</code> | <code>double?</code> | - |
| <code>stopLimitTimeInForce</code> | <code>[StopLimitTimeInForce?](Models/Enums/StopLimitTimeInForce.cs)</code> | - |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. |
| <code>sideEffectType</code> | <code>[SideEffectType?](Models/Enums/SideEffectType.cs)</code> | Default `NO_SIDE_EFFECT` |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderOcoResponse](Models/SapiV1MarginOrderOcoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginAccountNewOcoTradeError](Errors/MarginAccountNewOcoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderOtoResponse&gt; MarginAccountNewOtoTrade(string symbol, WorkingType workingType, WorkingSide workingSide, double workingPrice, double workingQuantity, double workingIcebergQty, PendingType pendingType, PendingSide pendingSide, double pendingQuantity, long timestamp, string signature, IsIsolated? isIsolated, string? listClientOrderId, NewOrderRespType? newOrderRespType, SideEffectType1? sideEffectType, SelfTradePreventionMode? selfTradePreventionMode, bool? autoRepayAtCancel, string? workingClientOrderId, WorkingTimeInForce? workingTimeInForce, string? pendingClientOrderId, double? pendingPrice, double? pendingStopPrice, double? pendingTrailingDelta, double? pendingIcebergQty, PendingTimeInForce? pendingTimeInForce, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Post a new `OTO` order for margin account:
- An `OTO` (One-Triggers-the-Other) is an order list comprised of 2 orders
- The first order is called the working order and must be `LIMIT` or `LIMIT_MAKER`. Initially, only the working order goes on the order book.
- The second order is called the pending order. It can be any order type except for `MARKET` orders using parameter `quoteOrderQty`. The pending order is only placed on the order book when the working order gets fully filled.
- If either the working order or the pending order is cancelled individually, the other order in the order list will also be canceled or expired.
- When the order list is placed, if the working order gets immediately fully filled, the placement response will show the working order as `FILLED` but the pending order will still appear as `PENDING_NEW`. You need to query the status of the pending order again to see its updated status.
- OTOs add 2 orders to the unfilled order count, `EXCHANGE_MAX_NUM_ORDERS` filter and `MAX_NUM_ORDERS` filter.

Weight(UID): 6

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginAccountNewOtoTrade(symbol,
        workingType,
        workingSide,
        workingPrice,
        workingQuantity,
        workingIcebergQty,
        pendingType,
        pendingSide,
        pendingQuantity,
        timestamp,
        signature,
        isIsolated,
        listClientOrderId,
        newOrderRespType,
        sideEffectType,
        selfTradePreventionMode,
        autoRepayAtCancel,
        workingClientOrderId,
        workingTimeInForce,
        pendingClientOrderId,
        pendingPrice,
        pendingStopPrice,
        pendingTrailingDelta,
        pendingIcebergQty,
        pendingTimeInForce);
    // TODO: Handle 'response' of type SapiV1MarginOrderOtoResponse
}
catch (SdkException<MarginAccountNewOtoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>workingType</code> | <code>[WorkingType](Models/Enums/WorkingType.cs)</code> | Supported values: LIMIT,LIMIT_MAKER |
| <code>workingSide</code> | <code>[WorkingSide](Models/Enums/WorkingSide.cs)</code> | BUY,SELL |
| <code>workingPrice</code> | <code>double</code> | - |
| <code>workingQuantity</code> | <code>double</code> | Sets the quantity for the working order. |
| <code>workingIcebergQty</code> | <code>double</code> | This can only be used if workingTimeInForce is GTC. |
| <code>pendingType</code> | <code>[PendingType](Models/Enums/PendingType.cs)</code> | Supported values: Order Types Note that MARKET orders using quoteOrderQty are not supported. |
| <code>pendingSide</code> | <code>[PendingSide](Models/Enums/PendingSide.cs)</code> | BUY,SELL |
| <code>pendingQuantity</code> | <code>double</code> | Sets the quantity for the pending order. |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>listClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open order lists. Automatically generated if not sent.<br>A new order list with the same `listClientOrderId` is accepted only when the previous one is filled or completely expired.<br>`listClientOrderId` is distinct from the `workingClientOrderId` and the `pendingClientOrderId`. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. |
| <code>sideEffectType</code> | <code>[SideEffectType1?](Models/Enums/SideEffectType1.cs)</code> | Default `NO_SIDE_EFFECT` |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>autoRepayAtCancel</code> | <code>bool?</code> | Only when MARGIN_BUY order takes effect, true means that the debt generated by the order needs to be repay after the order is cancelled. The default is true |
| <code>workingClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the working order. Automatically generated if not sent. |
| <code>workingTimeInForce</code> | <code>[WorkingTimeInForce?](Models/Enums/WorkingTimeInForce.cs)</code> | GTC, IOC, FOK |
| <code>pendingClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the pending order. Automatically generated if not sent. |
| <code>pendingPrice</code> | <code>double?</code> | - |
| <code>pendingStopPrice</code> | <code>double?</code> | - |
| <code>pendingTrailingDelta</code> | <code>double?</code> | - |
| <code>pendingIcebergQty</code> | <code>double?</code> | This can only be used if pendingTimeInForce is GTC. |
| <code>pendingTimeInForce</code> | <code>[PendingTimeInForce?](Models/Enums/PendingTimeInForce.cs)</code> | GTC, IOC, FOK |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderOtoResponse](Models/SapiV1MarginOrderOtoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginAccountNewOtoTradeError](Errors/MarginAccountNewOtoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderOtocoResponse&gt; MarginAccountNewOtocoTrade(string symbol, WorkingType workingType, WorkingSide workingSide, double workingPrice, double workingQuantity, double workingIcebergQty, PendingSide pendingSide, double pendingQuantity, PendingAboveType pendingAboveType, long timestamp, string signature, IsIsolated? isIsolated, SideEffectType1? sideEffectType, bool? autoRepayAtCancel, string? listClientOrderId, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, string? workingClientOrderId, WorkingTimeInForce? workingTimeInForce, string? pendingAboveClientOrderId, double? pendingAbovePrice, double? pendingAboveStopPrice, double? pendingAboveTrailingDelta, double? pendingAboveIcebergQty, PendingAboveTimeInForce? pendingAboveTimeInForce, PendingBelowType? pendingBelowType, string? pendingBelowClientOrderId, double? pendingBelowPrice, double? pendingBelowStopPrice, double? pendingBelowTrailingDelta, double? pendingBelowIcebergQty, PendingBelowTimeInForce? pendingBelowTimeInForce, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Post a new `OTOCO` order for margin account:
- An `OTOCO` (One-Triggers-the-Other-Cancel-the-Other) is an order list comprised of 3 orders
- The first order is called the working order and must be `LIMIT` or `LIMIT_MAKER`. Initially, only the working order goes on the order book.
  - The behavior of the working order is the same as the `OTO`.
- `OTOCO` has 2 pending orders (pending above and pending below), forming an `OCO` pair. The pending orders are only placed on the order book when the working order gets fully filled.
  - The rules of the pending above and pending below follow the same rules as the Order List `OCO`.
- OTOCOs add 3 orders to the unfilled order count, `EXCHANGE_MAX_NUM_ORDERS` filter and `MAX_NUM_ORDERS` filter.

Weight(UID): 6

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginAccountNewOtocoTrade(symbol,
        workingType,
        workingSide,
        workingPrice,
        workingQuantity,
        workingIcebergQty,
        pendingSide,
        pendingQuantity,
        pendingAboveType,
        timestamp,
        signature,
        isIsolated,
        sideEffectType,
        autoRepayAtCancel,
        listClientOrderId,
        newOrderRespType,
        selfTradePreventionMode,
        workingClientOrderId,
        workingTimeInForce,
        pendingAboveClientOrderId,
        pendingAbovePrice,
        pendingAboveStopPrice,
        pendingAboveTrailingDelta,
        pendingAboveIcebergQty,
        pendingAboveTimeInForce,
        pendingBelowType,
        pendingBelowClientOrderId,
        pendingBelowPrice,
        pendingBelowStopPrice,
        pendingBelowTrailingDelta,
        pendingBelowIcebergQty,
        pendingBelowTimeInForce);
    // TODO: Handle 'response' of type SapiV1MarginOrderOtocoResponse
}
catch (SdkException<MarginAccountNewOtocoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>workingType</code> | <code>[WorkingType](Models/Enums/WorkingType.cs)</code> | Supported values: LIMIT,LIMIT_MAKER |
| <code>workingSide</code> | <code>[WorkingSide](Models/Enums/WorkingSide.cs)</code> | BUY,SELL |
| <code>workingPrice</code> | <code>double</code> | - |
| <code>workingQuantity</code> | <code>double</code> | Sets the quantity for the working order. |
| <code>workingIcebergQty</code> | <code>double</code> | This can only be used if workingTimeInForce is GTC. |
| <code>pendingSide</code> | <code>[PendingSide](Models/Enums/PendingSide.cs)</code> | BUY,SELL |
| <code>pendingQuantity</code> | <code>double</code> | Sets the quantity for the pending order. |
| <code>pendingAboveType</code> | <code>[PendingAboveType](Models/Enums/PendingAboveType.cs)</code> | Supported values: LIMIT_MAKER, STOP_LOSS, and STOP_LOSS_LIMIT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>sideEffectType</code> | <code>[SideEffectType1?](Models/Enums/SideEffectType1.cs)</code> | Default `NO_SIDE_EFFECT` |
| <code>autoRepayAtCancel</code> | <code>bool?</code> | Only when MARGIN_BUY order takes effect, true means that the debt generated by the order needs to be repay after the order is cancelled. The default is true |
| <code>listClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open order lists. Automatically generated if not sent.<br>A new order list with the same `listClientOrderId` is accepted only when the previous one is filled or completely expired.<br>`listClientOrderId` is distinct from the `workingClientOrderId` and the `pendingClientOrderId`. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>workingClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the working order. Automatically generated if not sent. |
| <code>workingTimeInForce</code> | <code>[WorkingTimeInForce?](Models/Enums/WorkingTimeInForce.cs)</code> | GTC, IOC, FOK |
| <code>pendingAboveClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the pending above order. Automatically generated if not sent. |
| <code>pendingAbovePrice</code> | <code>double?</code> | - |
| <code>pendingAboveStopPrice</code> | <code>double?</code> | - |
| <code>pendingAboveTrailingDelta</code> | <code>double?</code> | - |
| <code>pendingAboveIcebergQty</code> | <code>double?</code> | This can only be used if pendingAboveTimeInForce is GTC. |
| <code>pendingAboveTimeInForce</code> | <code>[PendingAboveTimeInForce?](Models/Enums/PendingAboveTimeInForce.cs)</code> | - |
| <code>pendingBelowType</code> | <code>[PendingBelowType?](Models/Enums/PendingBelowType.cs)</code> | Supported values: LIMIT_MAKER, STOP_LOSS, and STOP_LOSS_LIMIT |
| <code>pendingBelowClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the pending below order. Automatically generated if not sent. |
| <code>pendingBelowPrice</code> | <code>double?</code> | - |
| <code>pendingBelowStopPrice</code> | <code>double?</code> | - |
| <code>pendingBelowTrailingDelta</code> | <code>double?</code> | - |
| <code>pendingBelowIcebergQty</code> | <code>double?</code> | This can only be used if pendingBelowTimeInForce is GTC. |
| <code>pendingBelowTimeInForce</code> | <code>[PendingBelowTimeInForce?](Models/Enums/PendingBelowTimeInForce.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderOtocoResponse](Models/SapiV1MarginOrderOtocoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginAccountNewOtocoTradeError](Errors/MarginAccountNewOtocoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderResponse&gt; MarginAccountNewOrderTrade(string symbol, Side side, Type1 type, double quantity, bool autoRepayAtCancel, long timestamp, string signature, IsIsolated? isIsolated, double? quoteOrderQty, double? price, double? stopPrice, string? newClientOrderId, double? icebergQty, NewOrderRespType? newOrderRespType, SideEffectType? sideEffectType, TimeInForce? timeInForce, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Post a new order for margin account.

Weight(UID): 6

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginAccountNewOrderTrade(symbol,
        side,
        type,
        quantity,
        autoRepayAtCancel,
        timestamp,
        signature,
        isIsolated,
        quoteOrderQty,
        price,
        stopPrice,
        newClientOrderId,
        icebergQty,
        newOrderRespType,
        sideEffectType,
        timeInForce,
        selfTradePreventionMode,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginOrderResponse
}
catch (SdkException<MarginAccountNewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>type</code> | <code>[Type1](Models/Enums/Type1.cs)</code> | Order type |
| <code>quantity</code> | <code>double</code> | - |
| <code>autoRepayAtCancel</code> | <code>bool</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>quoteOrderQty</code> | <code>double?</code> | Quote quantity |
| <code>price</code> | <code>double?</code> | Order price |
| <code>stopPrice</code> | <code>double?</code> | Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders. |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>icebergQty</code> | <code>double?</code> | Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. |
| <code>sideEffectType</code> | <code>[SideEffectType?](Models/Enums/SideEffectType.cs)</code> | Default `NO_SIDE_EFFECT` |
| <code>timeInForce</code> | <code>[TimeInForce?](Models/Enums/TimeInForce.cs)</code> | Order time in force |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderResponse](Models/AnyOf/SapiV1MarginOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginAccountNewOrderTradeError](Errors/MarginAccountNewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginInterestRateHistoryResponse&gt;&gt; MarginInterestRateHistoryUserData(string asset, long timestamp, string signature, int? vipLevel, long? startTime, long? endTime, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The max interval between startTime and endTime is 30 days.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginInterestRateHistoryUserData(asset,
        timestamp,
        signature,
        vipLevel,
        startTime,
        endTime,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginInterestRateHistoryResponse>
}
catch (SdkException<MarginInterestRateHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>vipLevel</code> | <code>int?</code> | Defaults to user's vip level |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginInterestRateHistoryResponse](Models/SapiV1MarginInterestRateHistoryResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginInterestRateHistoryUserDataError](Errors/MarginInterestRateHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginBorrowRepayResponse&gt; MarginAccountBorrowRepayMargin(string asset, string isIsolated, string symbol, double amount, string type, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Margin account borrow/repay(MARGIN)

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginAccountBorrowRepayMargin(asset,
        isIsolated,
        symbol,
        amount,
        type,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginBorrowRepayResponse
}
catch (SdkException<MarginAccountBorrowRepayMarginError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>isIsolated</code> | <code>string</code> | TRUE for isolated margin, FALSE for crossed margin |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>amount</code> | <code>double</code> | - |
| <code>type</code> | <code>string</code> | BORROW or REPAY |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginBorrowRepayResponse](Models/SapiV1MarginBorrowRepayResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginAccountBorrowRepayMarginError](Errors/MarginAccountBorrowRepayMarginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginManualLiquidationResponse&gt;&gt; MarginManualLiquidationMargin(Type4 type, long timestamp, string signature, string? symbol, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Margin manual liquidation

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.MarginManualLiquidationMargin(type, timestamp, signature, symbol);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginManualLiquidationResponse>
}
catch (SdkException<MarginManualLiquidationMarginError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>[Type4](Models/Enums/Type4.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>symbol</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginManualLiquidationResponse](Models/SapiV1MarginManualLiquidationResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginManualLiquidationMarginError](Errors/MarginManualLiquidationMarginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginAccountResponse&gt; QueryCrossMarginAccountDetailsUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryCrossMarginAccountDetailsUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginAccountResponse
}
catch (SdkException<QueryCrossMarginAccountDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginAccountResponse](Models/SapiV1MarginAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryCrossMarginAccountDetailsUserDataError](Errors/QueryCrossMarginAccountDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginCrossMarginDataResponse&gt;&gt; QueryCrossMarginFeeDataUserData(long timestamp, string signature, int? vipLevel, string? coin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get cross margin fee data collection with any vip level or user's current specific data as https://www.binance.com/en/margin-fee

Weight(IP): 1 when coin is specified; 5 when the coin parameter is omitted

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryCrossMarginFeeDataUserData(timestamp,
        signature,
        vipLevel,
        coin,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginCrossMarginDataResponse>
}
catch (SdkException<QueryCrossMarginFeeDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>vipLevel</code> | <code>int?</code> | Defaults to user's vip level |
| <code>coin</code> | <code>string?</code> | Coin name |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginCrossMarginDataResponse](Models/SapiV1MarginCrossMarginDataResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryCrossMarginFeeDataUserDataError](Errors/QueryCrossMarginFeeDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginRateLimitOrderResponse&gt;&gt; QueryCurrentMarginOrderCountUsageTrade(long timestamp, string signature, string? isIsolated, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Displays the user's current margin order count usage for all intervals.

Weight(IP): 20

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryCurrentMarginOrderCountUsageTrade(timestamp,
        signature,
        isIsolated,
        symbol,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginRateLimitOrderResponse>
}
catch (SdkException<QueryCurrentMarginOrderCountUsageTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>string?</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>symbol</code> | <code>string?</code> | isolated symbol, mandatory for isolated margin |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginRateLimitOrderResponse](Models/SapiV1MarginRateLimitOrderResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryCurrentMarginOrderCountUsageTradeError](Errors/QueryCurrentMarginOrderCountUsageTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginIsolatedAccountLimitResponse&gt; QueryEnabledIsolatedMarginAccountLimitUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query enabled isolated margin account limit.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryEnabledIsolatedMarginAccountLimitUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginIsolatedAccountLimitResponse
}
catch (SdkException<QueryEnabledIsolatedMarginAccountLimitUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginIsolatedAccountLimitResponse](Models/SapiV1MarginIsolatedAccountLimitResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryEnabledIsolatedMarginAccountLimitUserDataError](Errors/QueryEnabledIsolatedMarginAccountLimitUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IsolatedMarginAccountInfo&gt; QueryIsolatedMarginAccountInfoUserData(long timestamp, string signature, string? symbols, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If "symbols" is not sent, all isolated assets will be returned.
- If "symbols" is sent, only the isolated assets of the sent symbols will be returned.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryIsolatedMarginAccountInfoUserData(timestamp,
        signature,
        symbols,
        recvWindow);
    // TODO: Handle 'response' of type IsolatedMarginAccountInfo
}
catch (SdkException<QueryIsolatedMarginAccountInfoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>symbols</code> | <code>string?</code> | Max 5 symbols can be sent; separated by ',' |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IsolatedMarginAccountInfo](Models/IsolatedMarginAccountInfo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryIsolatedMarginAccountInfoUserDataError](Errors/QueryIsolatedMarginAccountInfoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginIsolatedMarginDataResponse&gt;&gt; QueryIsolatedMarginFeeDataUserData(long timestamp, string signature, int? vipLevel, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get isolated margin fee data collection with any vip level or user's current specific data as https://www.binance.com/en/margin-fee

Weight(IP): 1 when a single is specified; 10 when the symbol parameter is omitted

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryIsolatedMarginFeeDataUserData(timestamp,
        signature,
        vipLevel,
        symbol,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginIsolatedMarginDataResponse>
}
catch (SdkException<QueryIsolatedMarginFeeDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>vipLevel</code> | <code>int?</code> | Defaults to user's vip level |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginIsolatedMarginDataResponse](Models/SapiV1MarginIsolatedMarginDataResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryIsolatedMarginFeeDataUserDataError](Errors/QueryIsolatedMarginFeeDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginIsolatedMarginTierResponse&gt;&gt; QueryIsolatedMarginTierDataUserData(string symbol, long timestamp, string signature, string? tier, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get isolated margin tier data collection with any tier as https://www.binance.com/en/margin-data

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryIsolatedMarginTierDataUserData(symbol,
        timestamp,
        signature,
        tier,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginIsolatedMarginTierResponse>
}
catch (SdkException<QueryIsolatedMarginTierDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>tier</code> | <code>string?</code> | All margin tier data will be returned if tier is omitted |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginIsolatedMarginTierResponse](Models/SapiV1MarginIsolatedMarginTierResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryIsolatedMarginTierDataUserDataError](Errors/QueryIsolatedMarginTierDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginLeverageBracketResponse&gt;&gt; QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Liability Coin Leverage Bracket in Cross Margin Pro Mode

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData();
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginLeverageBracketResponse>
}
catch (SdkException<QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginLeverageBracketResponse](Models/SapiV1MarginLeverageBracketResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError](Errors/QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;MarginOrderDetail&gt;&gt; QueryMarginAccountSAllOrdersUserData(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? orderId, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If `orderId` is set, it will get orders >= that orderId. Otherwise most recent orders are returned.
- For some historical orders `cummulativeQuoteQty` will be < 0, meaning the data is not available at this time.

Weight(IP): 200

Request Limit: 60 times/min per IP

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMarginAccountSAllOrdersUserData(symbol,
        timestamp,
        signature,
        isIsolated,
        orderId,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<MarginOrderDetail>
}
catch (SdkException<QueryMarginAccountSAllOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MarginOrderDetail](Models/MarginOrderDetail.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMarginAccountSAllOrdersUserDataError](Errors/QueryMarginAccountSAllOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderListResponse&gt; QueryMarginAccountSOcoUserData(long timestamp, string signature, IsIsolated? isIsolated, string? symbol, long? orderListId, string? origClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific OCO based on provided optional parameters

- Either `orderListId` or `origClientOrderId` must be provided

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMarginAccountSOcoUserData(timestamp,
        signature,
        isIsolated,
        symbol,
        orderListId,
        origClientOrderId,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginOrderListResponse
}
catch (SdkException<QueryMarginAccountSOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>symbol</code> | <code>string?</code> | Mandatory for isolated margin, not supported for cross margin |
| <code>orderListId</code> | <code>long?</code> | Order list id |
| <code>origClientOrderId</code> | <code>string?</code> | Order id from client |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderListResponse](Models/SapiV1MarginOrderListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMarginAccountSOcoUserDataError](Errors/QueryMarginAccountSOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginOpenOrderListResponse&gt;&gt; QueryMarginAccountSOpenOcoUserData(long timestamp, string signature, IsIsolated? isIsolated, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMarginAccountSOpenOcoUserData(timestamp,
        signature,
        isIsolated,
        symbol,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginOpenOrderListResponse>
}
catch (SdkException<QueryMarginAccountSOpenOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>symbol</code> | <code>string?</code> | Mandatory for isolated margin, not supported for cross margin |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginOpenOrderListResponse](Models/SapiV1MarginOpenOrderListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMarginAccountSOpenOcoUserDataError](Errors/QueryMarginAccountSOpenOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;MarginOrderDetail&gt;&gt; QueryMarginAccountSOpenOrdersUserData(long timestamp, string signature, string? symbol, IsIsolated? isIsolated, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If the `symbol` is not sent, orders for all symbols will be returned in an array.
- When all symbols are returned, the number of requests counted against the rate limiter is equal to the number of symbols currently trading on the exchange
- If isIsolated ="TRUE", symbol must be sent.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMarginAccountSOpenOrdersUserData(timestamp,
        signature,
        symbol,
        isIsolated,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<MarginOrderDetail>
}
catch (SdkException<QueryMarginAccountSOpenOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MarginOrderDetail](Models/MarginOrderDetail.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMarginAccountSOpenOrdersUserDataError](Errors/QueryMarginAccountSOpenOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MarginOrderDetail&gt; QueryMarginAccountSOrderUserData(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? orderId, string? origClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Either `orderId` or `origClientOrderId` must be sent.
- For some historical orders `cummulativeQuoteQty` will be < 0, meaning the data is not available at this time.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMarginAccountSOrderUserData(symbol,
        timestamp,
        signature,
        isIsolated,
        orderId,
        origClientOrderId,
        recvWindow);
    // TODO: Handle 'response' of type MarginOrderDetail
}
catch (SdkException<QueryMarginAccountSOrderUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>origClientOrderId</code> | <code>string?</code> | Order id from client |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MarginOrderDetail](Models/MarginOrderDetail.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMarginAccountSOrderUserDataError](Errors/QueryMarginAccountSOrderUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;MarginTrade&gt;&gt; QueryMarginAccountSTradeListUserData(string symbol, long timestamp, string signature, IsIsolated? isIsolated, long? startTime, long? endTime, long? fromId, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If `fromId` is set, it will get orders >= that `fromId`. Otherwise most recent trades are returned.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMarginAccountSTradeListUserData(symbol,
        timestamp,
        signature,
        isIsolated,
        startTime,
        endTime,
        fromId,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<MarginTrade>
}
catch (SdkException<QueryMarginAccountSTradeListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>fromId</code> | <code>long?</code> | Trade id to fetch from. Default gets most recent trades. |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MarginTrade](Models/MarginTrade.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMarginAccountSTradeListUserDataError](Errors/QueryMarginAccountSTradeListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginAllOrderListResponse&gt;&gt; QueryMarginAccountSAllOcoUserData(long timestamp, string signature, IsIsolated? isIsolated, string? symbol, string? fromId, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves all OCO for a specific margin account based on provided optional parameters

Weight(IP): 200

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMarginAccountSAllOcoUserData(timestamp,
        signature,
        isIsolated,
        symbol,
        fromId,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginAllOrderListResponse>
}
catch (SdkException<QueryMarginAccountSAllOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isIsolated</code> | <code>[IsIsolated?](Models/Enums/IsIsolated.cs)</code> | * `TRUE` - For isolated margin<br>* `FALSE` - Default, not for isolated margin |
| <code>symbol</code> | <code>string?</code> | Mandatory for isolated margin, not supported for cross margin |
| <code>fromId</code> | <code>string?</code> | If supplied, neither `startTime` or `endTime` can be provided |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default Value: 500; Max Value: 1000 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginAllOrderListResponse](Models/SapiV1MarginAllOrderListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMarginAccountSAllOcoUserDataError](Errors/QueryMarginAccountSAllOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginAvailableInventoryResponse&gt; QueryMarginAvailableInventoryUserData(Type4 type, long timestamp, string signature, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Margin available Inventory query

Weight(UID): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMarginAvailableInventoryUserData(type, timestamp, signature);
    // TODO: Handle 'response' of type SapiV1MarginAvailableInventoryResponse
}
catch (SdkException<QueryMarginAvailableInventoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>[Type4](Models/Enums/Type4.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginAvailableInventoryResponse](Models/SapiV1MarginAvailableInventoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMarginAvailableInventoryUserDataError](Errors/QueryMarginAvailableInventoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginPriceIndexResponse&gt; QueryMarginPriceIndexMarketData(string symbol, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMarginPriceIndexMarketData(symbol);
    // TODO: Handle 'response' of type SapiV1MarginPriceIndexResponse
}
catch (SdkException<QueryMarginPriceIndexMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginPriceIndexResponse](Models/SapiV1MarginPriceIndexResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMarginPriceIndexMarketDataError](Errors/QueryMarginPriceIndexMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginMaxBorrowableResponse&gt; QueryMaxBorrowUserData(string asset, long timestamp, string signature, string? isolatedSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If `isolatedSymbol` is not sent, crossed margin data will be sent.
- `borrowLimit` is also available from https://www.binance.com/en/margin-fee

Weight(IP): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMaxBorrowUserData(asset, timestamp, signature, isolatedSymbol, recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginMaxBorrowableResponse
}
catch (SdkException<QueryMaxBorrowUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isolatedSymbol</code> | <code>string?</code> | Isolated symbol |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginMaxBorrowableResponse](Models/SapiV1MarginMaxBorrowableResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMaxBorrowUserDataError](Errors/QueryMaxBorrowUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginMaxTransferableResponse&gt; QueryMaxTransferOutAmountUserData(string asset, long timestamp, string signature, string? isolatedSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If `isolatedSymbol` is not sent, crossed margin data will be sent.

Weight(IP): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryMaxTransferOutAmountUserData(asset,
        timestamp,
        signature,
        isolatedSymbol,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginMaxTransferableResponse
}
catch (SdkException<QueryMaxTransferOutAmountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isolatedSymbol</code> | <code>string?</code> | Isolated symbol |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginMaxTransferableResponse](Models/SapiV1MarginMaxTransferableResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMaxTransferOutAmountUserDataError](Errors/QueryMaxTransferOutAmountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginBorrowRepayResponse1&gt; QueryBorrowRepayRecordsInMarginAccountUserData(string asset, string type, long timestamp, string signature, string? isolatedSymbol, long? txId, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query borrow/repay records in Margin account

- txId or startTime must be sent. txId takes precedence. Response in descending order
- If an asset is sent, data within 30 days before endTime; If an asset is not sent, data within 7 days before endTime
- If neither startTime nor endTime is sent, the recent 7-day data will be returned.
- startTime set as endTime - 7 days by default, endTime set as current time by default

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.QueryBorrowRepayRecordsInMarginAccountUserData(asset,
        type,
        timestamp,
        signature,
        isolatedSymbol,
        txId,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MarginBorrowRepayResponse1
}
catch (SdkException<QueryBorrowRepayRecordsInMarginAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>type</code> | <code>string</code> | BORROW or REPAY |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>isolatedSymbol</code> | <code>string?</code> | Isolated symbol |
| <code>txId</code> | <code>long?</code> | tranId in POST /sapi/v1/margin/loan |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginBorrowRepayResponse1](Models/SapiV1MarginBorrowRepayResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryBorrowRepayRecordsInMarginAccountUserDataError](Errors/QueryBorrowRepayRecordsInMarginAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BnbBurnStatus&gt; ToggleBnbBurnOnSpotTradeAndMarginInterestUserData(long timestamp, string signature, SpotBnbBurn? spotBnbBurn, InterestBnbBurn? interestBnbBurn, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- "spotBNBBurn" and "interestBNBBurn" should be sent at least one.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Margin.ToggleBnbBurnOnSpotTradeAndMarginInterestUserData(timestamp,
        signature,
        spotBnbBurn,
        interestBnbBurn,
        recvWindow);
    // TODO: Handle 'response' of type BnbBurnStatus
}
catch (SdkException<ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>spotBnbBurn</code> | <code>[SpotBnbBurn?](Models/Enums/SpotBnbBurn.cs)</code> | Determines whether to use BNB to pay for trading fees on SPOT |
| <code>interestBnbBurn</code> | <code>[InterestBnbBurn?](Models/Enums/InterestBnbBurn.cs)</code> | Determines whether to use BNB to pay for margin loan's interest |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BnbBurnStatus](Models/BnbBurnStatus.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError](Errors/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MarginStream

> Source: [MarginStream](Api/MarginStream.cs)

<details>
<summary><code>Task&lt;object&gt; CloseAListenKeyUserStream2(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Close out a user data stream.

Weight: 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MarginStream.CloseAListenKeyUserStream2(listenKey);
    // TODO: Handle 'response' of type object
}
catch (SdkException<CloseAListenKeyUserStream2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>listenKey</code> | <code>string?</code> | User websocket listen key |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CloseAListenKeyUserStream2Error](Errors/CloseAListenKeyUserStream2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1UserDataStreamResponse&gt; CreateAListenKeyUserStream2(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Start a new user data stream.
The stream will close after 60 minutes unless a keepalive is sent. If the account has an active `listenKey`, that `listenKey` will be returned and its validity will be extended for 60 minutes.

Weight: 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MarginStream.CreateAListenKeyUserStream2();
    // TODO: Handle 'response' of type SapiV1UserDataStreamResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1UserDataStreamResponse](Models/SapiV1UserDataStreamResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; PingKeepAliveAListenKeyUserStream2(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Keepalive a user data stream to prevent a time out. User data streams will close after 60 minutes. It's recommended to send a ping about every 30 minutes.

Weight: 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MarginStream.PingKeepAliveAListenKeyUserStream2(listenKey);
    // TODO: Handle 'response' of type object
}
catch (SdkException<PingKeepAliveAListenKeyUserStream2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>listenKey</code> | <code>string?</code> | User websocket listen key |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PingKeepAliveAListenKeyUserStream2Error](Errors/PingKeepAliveAListenKeyUserStream2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Market

> Source: [Market](Api/Market.cs)

<details>
<summary><code>Task&lt;ApiV3Ticker24HrResponse&gt; HrTickerPriceChangeStatistics24(string? symbol, string? symbols, TypeEnum? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

24 hour rolling window price change statistics. Careful when accessing this with no symbol.

- If the symbol is not sent, tickers for all symbols will be returned in an array.

Weight(IP):
- `2` for a single symbol;
- `80` when the symbol parameter is omitted;

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.HrTickerPriceChangeStatistics24(symbol, symbols, type);
    // TODO: Handle 'response' of type ApiV3Ticker24HrResponse
}
catch (SdkException<HrTickerPriceChangeStatistics24Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>symbols</code> | <code>string?</code> | - |
| <code>type</code> | <code>[TypeEnum?](Models/Enums/TypeEnum.cs)</code> | Supported values: FULL or MINI.<br>If none provided, the default is FULL |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3Ticker24HrResponse](Models/AnyOf/ApiV3Ticker24HrResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[HrTickerPriceChangeStatistics24Error](Errors/HrTickerPriceChangeStatistics24Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TimeResponse&gt; CheckServerTime(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Test connectivity to the Rest API and get the current server time.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.CheckServerTime();
    // TODO: Handle 'response' of type ApiV3TimeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TimeResponse](Models/ApiV3TimeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AggTrade&gt;&gt; CompressedAggregateTradesList(string symbol, long? fromId, long? startTime, long? endTime, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get compressed, aggregate trades. Trades that fill at the time, from the same order, with the same price will have the quantity aggregated.
- If `fromId`, `startTime`, and `endTime` are not sent, the most recent aggregate trades will be returned.
- Note that if a trade has the following values, this was a duplicate aggregate trade and marked as invalid:

  p = '0' // price

  q = '0' // qty

  f = -1 // ﬁrst_trade_id

  l = -1 // last_trade_id

Weight(IP): 2

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.CompressedAggregateTradesList(symbol, fromId, startTime, endTime, limit);
    // TODO: Handle 'response' of type IReadOnlyList<AggTrade>
}
catch (SdkException<CompressedAggregateTradesListError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>fromId</code> | <code>long?</code> | Trade id to fetch from. Default gets most recent trades. |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AggTrade](Models/AggTrade.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CompressedAggregateTradesListError](Errors/CompressedAggregateTradesListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3AvgPriceResponse&gt; CurrentAveragePrice(string symbol, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Current average price for a symbol.

Weight(IP): 2

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.CurrentAveragePrice(symbol);
    // TODO: Handle 'response' of type ApiV3AvgPriceResponse
}
catch (SdkException<CurrentAveragePriceError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3AvgPriceResponse](Models/ApiV3AvgPriceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CurrentAveragePriceError](Errors/CurrentAveragePriceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3ExchangeInfoResponse&gt; ExchangeInformation(string? symbol, string? symbols, string? permissions, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Current exchange trading rules and symbol information

- If any symbol provided in either symbol or symbols do not exist, the endpoint will throw an error.
- All parameters are optional.
- permissions can support single or multiple values (e.g. SPOT, ["MARGIN","LEVERAGED"])
- If permissions parameter not provided, the default values will be ["SPOT","MARGIN","LEVERAGED"].
  - To display all permissions you need to specify them explicitly. (e.g. SPOT, MARGIN,...)

Examples of Symbol Permissions Interpretation from the Response:
- [["A","B"]] means you may place an order if your account has either permission "A" or permission "B".
- [["A"],["B"]] means you can place an order if your account has permission "A" and permission "B".
- [["A"],["B","C"]] means you can place an order if your account has permission "A" and permission "B" or permission "C". (Inclusive or is applied here, not exclusive or, so your account may have both permission "B" and permission "C".)

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.ExchangeInformation(symbol, symbols, permissions);
    // TODO: Handle 'response' of type ApiV3ExchangeInfoResponse
}
catch (SdkException<ExchangeInformationError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>symbols</code> | <code>string?</code> | - |
| <code>permissions</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3ExchangeInfoResponse](Models/ApiV3ExchangeInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ExchangeInformationError](Errors/ExchangeInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;ApiV3KlinesResponse&gt;&gt;&gt; KlineCandlestickData(string symbol, Interval interval, long? startTime, long? endTime, string? timeZone, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Kline/candlestick bars for a symbol.
Klines are uniquely identified by their open time.

- If `startTime` and `endTime` are not sent, the most recent klines are returned.

Weight(IP): 2

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.KlineCandlestickData(symbol, interval, startTime, endTime, timeZone, limit);
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<ApiV3KlinesResponse>>
}
catch (SdkException<KlineCandlestickDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>interval</code> | <code>[Interval](Models/Enums/Interval.cs)</code> | kline intervals |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>timeZone</code> | <code>string?</code> | Default: 0 (UTC) |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[ApiV3KlinesResponse](Models/AnyOf/ApiV3KlinesResponse.cs)&gt;&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[KlineCandlestickDataError](Errors/KlineCandlestickDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Trade&gt;&gt; OldTradeLookup(string symbol, int? limit, long? fromId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get older market trades.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.OldTradeLookup(symbol, limit, fromId);
    // TODO: Handle 'response' of type IReadOnlyList<Trade>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>fromId</code> | <code>long?</code> | Trade id to fetch from. Default gets most recent trades. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Trade](Models/Trade.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3DepthResponse&gt; OrderBook(string symbol, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

| Limit               | Weight(IP)  |
|---------------------|-------------|
| 1-100               | 5           |
| 101-500             | 25          |
| 501-1000            | 50          |
| 1001-5000           | 250         |

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.OrderBook(symbol);
    // TODO: Handle 'response' of type ApiV3DepthResponse
}
catch (SdkException<OrderBookError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>limit</code> | <code>int?</code> | If limit > 5000, then the response will truncate to 5000<br>**Default**: 100 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3DepthResponse](Models/ApiV3DepthResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrderBookError](Errors/OrderBookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Trade&gt;&gt; RecentTradesList(string symbol, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get recent trades.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.RecentTradesList(symbol, limit);
    // TODO: Handle 'response' of type IReadOnlyList<Trade>
}
catch (SdkException<RecentTradesListError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Trade](Models/Trade.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RecentTradesListError](Errors/RecentTradesListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TickerResponse&gt; RollingWindowPriceChangeStatistics(string? symbol, string? symbols, string? windowSize, string? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The window used to compute statistics is typically slightly wider than requested windowSize.

openTime for /api/v3/ticker always starts on a minute, while the closeTime is the current time of the request. As such, the effective window might be up to 1 minute wider than requested.

E.g. If the closeTime is 1641287867099 (January 04, 2022 09:17:47:099 UTC) , and the windowSize is 1d. the openTime will be: 1641201420000 (January 3, 2022, 09:17:00 UTC)

Weight(IP): 4 for each requested symbol regardless of windowSize.

The weight for this request will cap at 200 once the number of symbols in the request is more than 50.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.RollingWindowPriceChangeStatistics(symbol, symbols, windowSize, type);
    // TODO: Handle 'response' of type ApiV3TickerResponse
}
catch (SdkException<RollingWindowPriceChangeStatisticsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>symbols</code> | <code>string?</code> | - |
| <code>windowSize</code> | <code>string?</code> | Defaults to 1d if no parameter provided.<br>Supported windowSize values:<br>1m,2m....59m for minutes<br>1h, 2h....23h - for hours<br>1d...7d - for days.<br><br>Units cannot be combined (e.g. 1d2h is not allowed) |
| <code>type</code> | <code>string?</code> | Supported values: FULL or MINI.<br>If none provided, the default is FULL |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerResponse](Models/ApiV3TickerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RollingWindowPriceChangeStatisticsError](Errors/RollingWindowPriceChangeStatisticsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TickerBookTickerResponse&gt; SymbolOrderBookTicker(string? symbol, string? symbols, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Best price/qty on the order book for a symbol or symbols.

- If the symbol is not sent, bookTickers for all symbols will be returned in an array.

Weight(IP):
- `2` for a single symbol;
- `4` when the symbol parameter is omitted;

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.SymbolOrderBookTicker(symbol, symbols);
    // TODO: Handle 'response' of type ApiV3TickerBookTickerResponse
}
catch (SdkException<SymbolOrderBookTickerError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>symbols</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerBookTickerResponse](Models/AnyOf/ApiV3TickerBookTickerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SymbolOrderBookTickerError](Errors/SymbolOrderBookTickerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TickerPriceResponse&gt; SymbolPriceTicker(string? symbol, string? symbols, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Latest price for a symbol or symbols.

- If the symbol is not sent, prices for all symbols will be returned in an array.

Weight(IP):
- `2` for a single symbol;
- `4` when the symbol parameter is omitted;

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.SymbolPriceTicker(symbol, symbols);
    // TODO: Handle 'response' of type ApiV3TickerPriceResponse
}
catch (SdkException<SymbolPriceTickerError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>symbols</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerPriceResponse](Models/AnyOf/ApiV3TickerPriceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SymbolPriceTickerError](Errors/SymbolPriceTickerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; TestConnectivity(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Test connectivity to the Rest API.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.TestConnectivity();
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TickerTradingDayResponse&gt; TradingDayTicker(string? symbol, string? symbols, string? timeZone, TypeEnum? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Price change statistics for a trading day.

Notes:
- Supported values for timeZone:
  - Hours and minutes (e.g. -1:00, 05:45)
  - Only hours (e.g. 0, 8, 4)

Weight:
- `4` for each requested symbol.
- The weight for this request will cap at `200` once the number of symbols in the request is more than `50`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.TradingDayTicker(symbol, symbols, timeZone, type);
    // TODO: Handle 'response' of type ApiV3TickerTradingDayResponse
}
catch (SdkException<TradingDayTickerError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>symbols</code> | <code>string?</code> | - |
| <code>timeZone</code> | <code>string?</code> | Default: 0 (UTC) |
| <code>type</code> | <code>[TypeEnum?](Models/Enums/TypeEnum.cs)</code> | Supported values: FULL or MINI.<br>If none provided, the default is FULL |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerTradingDayResponse](Models/AnyOf/ApiV3TickerTradingDayResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TradingDayTickerError](Errors/TradingDayTickerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;ApiV3UiKlinesResponse&gt;&gt;&gt; UiKlines(string symbol, Interval interval, long? startTime, long? endTime, string? timeZone, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The request is similar to klines having the same parameters and response.

uiKlines return modified kline data, optimized for presentation of candlestick charts.

Weight(IP): 2

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Market.UiKlines(symbol, interval, startTime, endTime, timeZone, limit);
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<ApiV3UiKlinesResponse>>
}
catch (SdkException<UiKlinesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>interval</code> | <code>[Interval](Models/Enums/Interval.cs)</code> | kline intervals |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>timeZone</code> | <code>string?</code> | Default: 0 (UTC) |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[ApiV3UiKlinesResponse](Models/AnyOf/ApiV3UiKlinesResponse.cs)&gt;&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UiKlinesError](Errors/UiKlinesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Mining

> Source: [Mining](Api/Mining.cs)

<details>
<summary><code>Task&lt;SapiV1MiningStatisticsUserListResponse&gt; AccountListUserData(string algo, string userName, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.AccountListUserData(algo, userName, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningStatisticsUserListResponse
}
catch (SdkException<AccountListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algo</code> | <code>string</code> | Algorithm(sha256) |
| <code>userName</code> | <code>string</code> | Mining Account |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningStatisticsUserListResponse](Models/SapiV1MiningStatisticsUserListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AccountListUserDataError](Errors/AccountListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPubAlgoListResponse&gt; AcquiringAlgorithmMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.AcquiringAlgorithmMarketData();
    // TODO: Handle 'response' of type SapiV1MiningPubAlgoListResponse
}
catch (SdkException<AcquiringAlgorithmMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPubAlgoListResponse](Models/SapiV1MiningPubAlgoListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AcquiringAlgorithmMarketDataError](Errors/AcquiringAlgorithmMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPubCoinListResponse&gt; AcquiringCoinNameMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.AcquiringCoinNameMarketData();
    // TODO: Handle 'response' of type SapiV1MiningPubCoinListResponse
}
catch (SdkException<AcquiringCoinNameMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPubCoinListResponse](Models/SapiV1MiningPubCoinListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AcquiringCoinNameMarketDataError](Errors/AcquiringCoinNameMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningHashTransferConfigCancelResponse&gt; CancelHashrateResaleConfigurationUserData(string configId, string userName, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.CancelHashrateResaleConfigurationUserData(configId,
        userName,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningHashTransferConfigCancelResponse
}
catch (SdkException<CancelHashrateResaleConfigurationUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>configId</code> | <code>string</code> | Mining ID |
| <code>userName</code> | <code>string</code> | Mining Account |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferConfigCancelResponse](Models/SapiV1MiningHashTransferConfigCancelResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelHashrateResaleConfigurationUserDataError](Errors/CancelHashrateResaleConfigurationUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPaymentListResponse&gt; EarningsListUserData(string algo, string userName, long timestamp, string signature, string? coin, string? startDate, string? endDate, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.EarningsListUserData(algo,
        userName,
        timestamp,
        signature,
        coin,
        startDate,
        endDate,
        pageIndex,
        pageSize,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningPaymentListResponse
}
catch (SdkException<EarningsListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algo</code> | <code>string</code> | Algorithm(sha256) |
| <code>userName</code> | <code>string</code> | Mining Account |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>coin</code> | <code>string?</code> | Coin name |
| <code>startDate</code> | <code>string?</code> | Search date, millisecond timestamp, while empty query all |
| <code>endDate</code> | <code>string?</code> | Search date, millisecond timestamp, while empty query all |
| <code>pageIndex</code> | <code>int?</code> | Page number, default is first page, start form 1 |
| <code>pageSize</code> | <code>string?</code> | Number of pages, minimum 10, maximum 200 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPaymentListResponse](Models/SapiV1MiningPaymentListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EarningsListUserDataError](Errors/EarningsListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPaymentOtherResponse&gt; ExtraBonusListUserData(string algo, string userName, long timestamp, string signature, string? coin, string? startDate, string? endDate, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.ExtraBonusListUserData(algo,
        userName,
        timestamp,
        signature,
        coin,
        startDate,
        endDate,
        pageIndex,
        pageSize,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningPaymentOtherResponse
}
catch (SdkException<ExtraBonusListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algo</code> | <code>string</code> | Algorithm(sha256) |
| <code>userName</code> | <code>string</code> | Mining Account |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>coin</code> | <code>string?</code> | Coin name |
| <code>startDate</code> | <code>string?</code> | Search date, millisecond timestamp, while empty query all |
| <code>endDate</code> | <code>string?</code> | Search date, millisecond timestamp, while empty query all |
| <code>pageIndex</code> | <code>int?</code> | Page number, default is first page, start form 1 |
| <code>pageSize</code> | <code>string?</code> | Number of pages, minimum 10, maximum 200 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPaymentOtherResponse](Models/SapiV1MiningPaymentOtherResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ExtraBonusListUserDataError](Errors/ExtraBonusListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningHashTransferProfitDetailsResponse&gt; HashrateResaleDetailsUserData(string configId, string userName, long timestamp, string signature, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.HashrateResaleDetailsUserData(configId,
        userName,
        timestamp,
        signature,
        pageIndex,
        pageSize,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningHashTransferProfitDetailsResponse
}
catch (SdkException<HashrateResaleDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>configId</code> | <code>string</code> | Mining ID |
| <code>userName</code> | <code>string</code> | Mining Account |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>pageIndex</code> | <code>int?</code> | Page number, default is first page, start form 1 |
| <code>pageSize</code> | <code>string?</code> | Number of pages, minimum 10, maximum 200 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferProfitDetailsResponse](Models/SapiV1MiningHashTransferProfitDetailsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[HashrateResaleDetailsUserDataError](Errors/HashrateResaleDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningHashTransferConfigDetailsListResponse&gt; HashrateResaleListUserData(long timestamp, string signature, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.HashrateResaleListUserData(timestamp,
        signature,
        pageIndex,
        pageSize,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningHashTransferConfigDetailsListResponse
}
catch (SdkException<HashrateResaleListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>pageIndex</code> | <code>int?</code> | Page number, default is first page, start form 1 |
| <code>pageSize</code> | <code>string?</code> | Number of pages, minimum 10, maximum 200 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferConfigDetailsListResponse](Models/SapiV1MiningHashTransferConfigDetailsListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[HashrateResaleListUserDataError](Errors/HashrateResaleListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningHashTransferConfigResponse&gt; HashrateResaleRequestUserData(string userName, string algo, string toPoolUser, string hashRate, long timestamp, string signature, string? startDate, string? endDate, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.HashrateResaleRequestUserData(userName,
        algo,
        toPoolUser,
        hashRate,
        timestamp,
        signature,
        startDate,
        endDate,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningHashTransferConfigResponse
}
catch (SdkException<HashrateResaleRequestUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userName</code> | <code>string</code> | Mining Account |
| <code>algo</code> | <code>string</code> | Algorithm(sha256) |
| <code>toPoolUser</code> | <code>string</code> | Mining Account |
| <code>hashRate</code> | <code>string</code> | Resale hashrate h/s must be transferred (BTC is greater than 500000000000 ETH is greater than 500000) |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startDate</code> | <code>string?</code> | Search date, millisecond timestamp, while empty query all |
| <code>endDate</code> | <code>string?</code> | Search date, millisecond timestamp, while empty query all |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferConfigResponse](Models/SapiV1MiningHashTransferConfigResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[HashrateResaleRequestUserDataError](Errors/HashrateResaleRequestUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPaymentUidResponse&gt; MiningAccountEarningUserData(string algo, long timestamp, string signature, string? startDate, string? endDate, int? pageIndex, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.MiningAccountEarningUserData(algo,
        timestamp,
        signature,
        startDate,
        endDate,
        pageIndex,
        pageSize,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningPaymentUidResponse
}
catch (SdkException<MiningAccountEarningUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algo</code> | <code>string</code> | Algorithm(sha256) |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startDate</code> | <code>string?</code> | Search date, millisecond timestamp, while empty query all |
| <code>endDate</code> | <code>string?</code> | Search date, millisecond timestamp, while empty query all |
| <code>pageIndex</code> | <code>int?</code> | Page number, default is first page, start form 1 |
| <code>pageSize</code> | <code>string?</code> | Number of pages, minimum 10, maximum 200 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPaymentUidResponse](Models/SapiV1MiningPaymentUidResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MiningAccountEarningUserDataError](Errors/MiningAccountEarningUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningWorkerDetailResponse&gt; RequestForDetailMinerListUserData(string algo, string userName, string workerName, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.RequestForDetailMinerListUserData(algo,
        userName,
        workerName,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningWorkerDetailResponse
}
catch (SdkException<RequestForDetailMinerListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algo</code> | <code>string</code> | Algorithm(sha256) |
| <code>userName</code> | <code>string</code> | Mining Account |
| <code>workerName</code> | <code>string</code> | Miner’s name |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningWorkerDetailResponse](Models/SapiV1MiningWorkerDetailResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RequestForDetailMinerListUserDataError](Errors/RequestForDetailMinerListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningWorkerListResponse&gt; RequestForMinerListUserData(string algo, string userName, long timestamp, string signature, int? pageIndex, int? sort, int? sortColumn, int? workerStatus, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.RequestForMinerListUserData(algo,
        userName,
        timestamp,
        signature,
        pageIndex,
        sort,
        sortColumn,
        workerStatus,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningWorkerListResponse
}
catch (SdkException<RequestForMinerListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algo</code> | <code>string</code> | Algorithm(sha256) |
| <code>userName</code> | <code>string</code> | Mining Account |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>pageIndex</code> | <code>int?</code> | Page number, default is first page, start form 1 |
| <code>sort</code> | <code>int?</code> | sort sequence(default=0)0 positive sequence, 1 negative sequence |
| <code>sortColumn</code> | <code>int?</code> | Sort by( default 1): 1: miner name, 2: real-time computing power, 3: daily average computing power, 4: real-time rejection rate, 5: last submission time |
| <code>workerStatus</code> | <code>int?</code> | miners status(default=0)0 all, 1 valid, 2 invalid, 3 failure |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningWorkerListResponse](Models/SapiV1MiningWorkerListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RequestForMinerListUserDataError](Errors/RequestForMinerListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningStatisticsUserStatusResponse&gt; StatisticListUserData(string algo, string userName, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mining.StatisticListUserData(algo, userName, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1MiningStatisticsUserStatusResponse
}
catch (SdkException<StatisticListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algo</code> | <code>string</code> | Algorithm(sha256) |
| <code>userName</code> | <code>string</code> | Mining Account |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningStatisticsUserStatusResponse](Models/SapiV1MiningStatisticsUserStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[StatisticListUserDataError](Errors/StatisticListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Nft

> Source: [Nft](Api/Nft.cs)

<details>
<summary><code>Task&lt;SapiV1NftUserGetAssetResponse&gt; GetNftAssetUserData(long timestamp, string signature, int? limit, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Nft.GetNftAssetUserData(timestamp, signature, limit, page, recvWindow);
    // TODO: Handle 'response' of type SapiV1NftUserGetAssetResponse
}
catch (SdkException<GetNftAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>limit</code> | <code>int?</code> | Default 50, Max 50 |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftUserGetAssetResponse](Models/SapiV1NftUserGetAssetResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetNftAssetUserDataError](Errors/GetNftAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1NftHistoryDepositResponse&gt; GetNftDepositHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? limit, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The max interval between startTime and endTime is 90 days.
- If startTime and endTime are not sent, the recent 7 days' data will be returned.

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Nft.GetNftDepositHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        limit,
        page,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1NftHistoryDepositResponse
}
catch (SdkException<GetNftDepositHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default 50, Max 50 |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftHistoryDepositResponse](Models/SapiV1NftHistoryDepositResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetNftDepositHistoryUserDataError](Errors/GetNftDepositHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1NftHistoryTransactionsResponse&gt; GetNftTransactionHistoryUserData(int orderType, long timestamp, string signature, long? startTime, long? endTime, int? limit, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The max interval between startTime and endTime is 90 days.
- If startTime and endTime are not sent, the recent 7 days' data will be returned.

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Nft.GetNftTransactionHistoryUserData(orderType,
        timestamp,
        signature,
        startTime,
        endTime,
        limit,
        page,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1NftHistoryTransactionsResponse
}
catch (SdkException<GetNftTransactionHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderType</code> | <code>int</code> | 0: purchase order, 1: sell order, 2: royalty income, 3: primary market order, 4: mint fee |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default 50, Max 50 |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftHistoryTransactionsResponse](Models/SapiV1NftHistoryTransactionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetNftTransactionHistoryUserDataError](Errors/GetNftTransactionHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1NftHistoryWithdrawResponse&gt; GetNftWithdrawHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? limit, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The max interval between startTime and endTime is 90 days.
- If startTime and endTime are not sent, the recent 7 days' data will be returned.

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Nft.GetNftWithdrawHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        limit,
        page,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1NftHistoryWithdrawResponse
}
catch (SdkException<GetNftWithdrawHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default 50, Max 50 |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftHistoryWithdrawResponse](Models/SapiV1NftHistoryWithdrawResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetNftWithdrawHistoryUserDataError](Errors/GetNftWithdrawHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Pay

> Source: [Pay](Api/Pay.cs)

<details>
<summary><code>Task&lt;SapiV1PayTransactionsResponse&gt; GetPayTradeHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If startTime and endTime are not sent, the recent 90 days' data will be returned.
- The max interval between startTime and endTime is 90 days.
- Support for querying orders within the last 18 months.

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pay.GetPayTradeHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1PayTransactionsResponse
}
catch (SdkException<GetPayTradeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | default 100, max 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PayTransactionsResponse](Models/SapiV1PayTransactionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPayTradeHistoryUserDataError](Errors/GetPayTradeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PortfolioMargin

> Source: [PortfolioMargin](Api/PortfolioMargin.cs)

<details>
<summary><code>Task&lt;SapiV1PortfolioBnbTransferResponse&gt; BnbTransferUserData(TransferSide transferSide, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

BNB transfer can be between Margin Account and USDM Account

Weight(IP): 1500

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.BnbTransferUserData(transferSide,
        amount,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1PortfolioBnbTransferResponse
}
catch (SdkException<BnbTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transferSide</code> | <code>[TransferSide](Models/Enums/TransferSide.cs)</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioBnbTransferResponse](Models/SapiV1PortfolioBnbTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BnbTransferUserDataError](Errors/BnbTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioRepayFuturesSwitchResponse&gt; ChangeAutoRepayFuturesStatusUserData(bool autoRepay, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Change Auto-repay-futures Status

Weight(IP): 1500

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.ChangeAutoRepayFuturesStatusUserData(autoRepay,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1PortfolioRepayFuturesSwitchResponse
}
catch (SdkException<ChangeAutoRepayFuturesStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>autoRepay</code> | <code>bool</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayFuturesSwitchResponse](Models/SapiV1PortfolioRepayFuturesSwitchResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ChangeAutoRepayFuturesStatusUserDataError](Errors/ChangeAutoRepayFuturesStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioAutoCollectionResponse&gt; FundAutoCollectionUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Transfers all assets from Futures Account to Margin account

Weight(IP): 1500

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.FundAutoCollectionUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1PortfolioAutoCollectionResponse
}
catch (SdkException<FundAutoCollectionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioAutoCollectionResponse](Models/SapiV1PortfolioAutoCollectionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FundAutoCollectionUserDataError](Errors/FundAutoCollectionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioAssetCollectionResponse&gt; FundCollectionByAssetUserData(string asset, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Transfers specific asset from Futures Account to Margin account

Weight(IP): 60

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.FundCollectionByAssetUserData(asset, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1PortfolioAssetCollectionResponse
}
catch (SdkException<FundCollectionByAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioAssetCollectionResponse](Models/SapiV1PortfolioAssetCollectionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FundCollectionByAssetUserDataError](Errors/FundCollectionByAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioRepayFuturesSwitchResponse1&gt; GetAutoRepayFuturesStatusUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Auto-repay-futures Status

Weight(IP): 30

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.GetAutoRepayFuturesStatusUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1PortfolioRepayFuturesSwitchResponse1
}
catch (SdkException<GetAutoRepayFuturesStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayFuturesSwitchResponse1](Models/SapiV1PortfolioRepayFuturesSwitchResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAutoRepayFuturesStatusUserDataError](Errors/GetAutoRepayFuturesStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1PortfolioMarginAssetLeverageResponse&gt;&gt; GetPortfolioMarginAssetLeverageUserData(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.GetPortfolioMarginAssetLeverageUserData();
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1PortfolioMarginAssetLeverageResponse>
}
catch (SdkException<GetPortfolioMarginAssetLeverageUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioMarginAssetLeverageResponse](Models/SapiV1PortfolioMarginAssetLeverageResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPortfolioMarginAssetLeverageUserDataError](Errors/GetPortfolioMarginAssetLeverageUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioAccountResponse&gt; PortfolioMarginAccountUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the account info

'Weight(IP): 1'

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.PortfolioMarginAccountUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1PortfolioAccountResponse
}
catch (SdkException<PortfolioMarginAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioAccountResponse](Models/SapiV1PortfolioAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PortfolioMarginAccountUserDataError](Errors/PortfolioMarginAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioPmLoanResponse&gt; PortfolioMarginBankruptcyLoanAmountUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Portfolio Margin Bankruptcy Loan Amount.

Weight(UID): 500

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.PortfolioMarginBankruptcyLoanAmountUserData(timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1PortfolioPmLoanResponse
}
catch (SdkException<PortfolioMarginBankruptcyLoanAmountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioPmLoanResponse](Models/SapiV1PortfolioPmLoanResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PortfolioMarginBankruptcyLoanAmountUserDataError](Errors/PortfolioMarginBankruptcyLoanAmountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioRepayResponse&gt; PortfolioMarginBankruptcyLoanRepayUserData(long timestamp, string signature, string? from, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Repay Portfolio Margin Bankruptcy Loan.

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.PortfolioMarginBankruptcyLoanRepayUserData(timestamp,
        signature,
        from,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1PortfolioRepayResponse
}
catch (SdkException<PortfolioMarginBankruptcyLoanRepayUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>from</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayResponse](Models/SapiV1PortfolioRepayResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PortfolioMarginBankruptcyLoanRepayUserDataError](Errors/PortfolioMarginBankruptcyLoanRepayUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1PortfolioCollateralRateResponse&gt;&gt; PortfolioMarginCollateralRateMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Portfolio Margin Collateral Rate.

Weight(IP): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.PortfolioMarginCollateralRateMarketData();
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1PortfolioCollateralRateResponse>
}
catch (SdkException<PortfolioMarginCollateralRateMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioCollateralRateResponse](Models/SapiV1PortfolioCollateralRateResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PortfolioMarginCollateralRateMarketDataError](Errors/PortfolioMarginCollateralRateMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV2PortfolioCollateralRateResponse&gt;&gt; PortfolioMarginProTieredCollateralRateUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Portfolio Margin PRO Tiered Collateral Rate

Weight(IP): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.PortfolioMarginProTieredCollateralRateUserData(timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV2PortfolioCollateralRateResponse>
}
catch (SdkException<PortfolioMarginProTieredCollateralRateUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV2PortfolioCollateralRateResponse](Models/SapiV2PortfolioCollateralRateResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PortfolioMarginProTieredCollateralRateUserDataError](Errors/PortfolioMarginProTieredCollateralRateUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1PortfolioInterestHistoryResponse&gt;&gt; QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData(string asset, long timestamp, string signature, long? startTime, long? endTime, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query interest history of negative balance for portfolio margin.

Weight(IP): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData(asset,
        timestamp,
        signature,
        startTime,
        endTime,
        size,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1PortfolioInterestHistoryResponse>
}
catch (SdkException<QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioInterestHistoryResponse](Models/SapiV1PortfolioInterestHistoryResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError](Errors/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1PortfolioAssetIndexPriceResponse&gt;&gt; QueryPortfolioMarginAssetIndexPriceMarketData(string? asset, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Portfolio Margin Asset Index Price

Weight(IP):
- 1 if send asset
- 50 if not send asset

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.QueryPortfolioMarginAssetIndexPriceMarketData(asset);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1PortfolioAssetIndexPriceResponse>
}
catch (SdkException<QueryPortfolioMarginAssetIndexPriceMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioAssetIndexPriceResponse](Models/SapiV1PortfolioAssetIndexPriceResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryPortfolioMarginAssetIndexPriceMarketDataError](Errors/QueryPortfolioMarginAssetIndexPriceMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioRepayFuturesNegativeBalanceResponse&gt; RepayFuturesNegativeBalanceUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Repay futures Negative Balance

Weight(IP): 1500

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioMargin.RepayFuturesNegativeBalanceUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1PortfolioRepayFuturesNegativeBalanceResponse
}
catch (SdkException<RepayFuturesNegativeBalanceUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayFuturesNegativeBalanceResponse](Models/SapiV1PortfolioRepayFuturesNegativeBalanceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RepayFuturesNegativeBalanceUserDataError](Errors/RepayFuturesNegativeBalanceUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Rebate

> Source: [Rebate](Api/Rebate.cs)

<details>
<summary><code>Task&lt;SapiV1RebateTaxQueryResponse&gt; GetSpotRebateHistoryRecordsUserData(long timestamp, string signature, long? startTime, long? endTime, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The max interval between startTime and endTime is 90 days.
- If startTime and endTime are not sent, the recent 7 days' data will be returned.
- The earliest startTime is supported on June 10, 2020

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rebate.GetSpotRebateHistoryRecordsUserData(timestamp,
        signature,
        startTime,
        endTime,
        page,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1RebateTaxQueryResponse
}
catch (SdkException<GetSpotRebateHistoryRecordsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | default 1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1RebateTaxQueryResponse](Models/SapiV1RebateTaxQueryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSpotRebateHistoryRecordsUserDataError](Errors/GetSpotRebateHistoryRecordsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Savings

> Source: [Savings](Api/Savings.cs)

<details>
<summary><code>Task&lt;SapiV1LendingPositionChangedResponse&gt; ChangeFixedActivityPositionToDailyPositionUserData(string projectId, string lot, long timestamp, string signature, string? positionId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- PositionId is mandatory parameter for fixed position.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Savings.ChangeFixedActivityPositionToDailyPositionUserData(projectId,
        lot,
        timestamp,
        signature,
        positionId,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingPositionChangedResponse
}
catch (SdkException<ChangeFixedActivityPositionToDailyPositionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | - |
| <code>lot</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>positionId</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingPositionChangedResponse](Models/SapiV1LendingPositionChangedResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ChangeFixedActivityPositionToDailyPositionUserDataError](Errors/ChangeFixedActivityPositionToDailyPositionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingProjectListResponse&gt;&gt; GetFixedActivityProjectListUserData(Type8 type, long timestamp, string signature, string? asset, Status? status, bool? isSortAsc, SortBy? sortBy, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Savings.GetFixedActivityProjectListUserData(type,
        timestamp,
        signature,
        asset,
        status,
        isSortAsc,
        sortBy,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingProjectListResponse>
}
catch (SdkException<GetFixedActivityProjectListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>[Type8](Models/Enums/Type8.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>status</code> | <code>[Status?](Models/Enums/Status.cs)</code> | Default `ALL` |
| <code>isSortAsc</code> | <code>bool?</code> | default "true" |
| <code>sortBy</code> | <code>[SortBy?](Models/Enums/SortBy.cs)</code> | Default `START_TIME` |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingProjectListResponse](Models/SapiV1LendingProjectListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFixedActivityProjectListUserDataError](Errors/GetFixedActivityProjectListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingProjectPositionListResponse&gt;&gt; GetFixedActivityProjectPositionUserData(string asset, long timestamp, string signature, string? projectId, Status? status, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Savings.GetFixedActivityProjectPositionUserData(asset,
        timestamp,
        signature,
        projectId,
        status,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingProjectPositionListResponse>
}
catch (SdkException<GetFixedActivityProjectPositionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>projectId</code> | <code>string?</code> | - |
| <code>status</code> | <code>[Status?](Models/Enums/Status.cs)</code> | Default `ALL` |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingProjectPositionListResponse](Models/SapiV1LendingProjectPositionListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFixedActivityProjectPositionUserDataError](Errors/GetFixedActivityProjectPositionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingCustomizedFixedPurchaseResponse&gt; PurchaseFixedActivityProjectUserData(string projectId, string lot, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Savings.PurchaseFixedActivityProjectUserData(projectId,
        lot,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LendingCustomizedFixedPurchaseResponse
}
catch (SdkException<PurchaseFixedActivityProjectUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | - |
| <code>lot</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingCustomizedFixedPurchaseResponse](Models/SapiV1LendingCustomizedFixedPurchaseResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PurchaseFixedActivityProjectUserDataError](Errors/PurchaseFixedActivityProjectUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SimpleEarn

> Source: [SimpleEarn](Api/SimpleEarn.cs)

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse&gt; GetCollateralRecordUserData(long timestamp, string signature, string? productId, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetCollateralRecordUserData(timestamp,
        signature,
        productId,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse
}
catch (SdkException<GetCollateralRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>productId</code> | <code>string?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse](Models/SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCollateralRecordUserDataError](Errors/GetCollateralRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse&gt; GetFlexiblePersonalLeftQuotaUserData(string productId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetFlexiblePersonalLeftQuotaUserData(productId,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse
}
catch (SdkException<GetFlexiblePersonalLeftQuotaUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>productId</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse](Models/SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFlexiblePersonalLeftQuotaUserDataError](Errors/GetFlexiblePersonalLeftQuotaUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexiblePositionResponse&gt; GetFlexibleProductPositionUserData(long timestamp, string signature, string? asset, string? productId, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetFlexibleProductPositionUserData(timestamp,
        signature,
        asset,
        productId,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexiblePositionResponse
}
catch (SdkException<GetFlexibleProductPositionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>productId</code> | <code>string?</code> | - |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexiblePositionResponse](Models/SapiV1SimpleEarnFlexiblePositionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFlexibleProductPositionUserDataError](Errors/GetFlexibleProductPositionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse&gt; GetFlexibleRedemptionRecordUserData(string? productId, string? redeemId, string? asset, long? startTime, long? endTime, int? current, int? size, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetFlexibleRedemptionRecordUserData(productId,
        redeemId,
        asset,
        startTime,
        endTime,
        current,
        size);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse
}
catch (SdkException<GetFlexibleRedemptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>productId</code> | <code>string?</code> | - |
| <code>redeemId</code> | <code>string?</code> | - |
| <code>asset</code> | <code>string?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse](Models/SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFlexibleRedemptionRecordUserDataError](Errors/GetFlexibleRedemptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse&gt; GetFlexibleRewardsHistoryUserData(string type, string? productId, string? asset, long? startTime, long? endTime, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetFlexibleRewardsHistoryUserData(type,
        productId,
        asset,
        startTime,
        endTime);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse
}
catch (SdkException<GetFlexibleRewardsHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>string</code> | "BONUS", "REALTIME", "REWARDS" |
| <code>productId</code> | <code>string?</code> | - |
| <code>asset</code> | <code>string?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse](Models/SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFlexibleRewardsHistoryUserDataError](Errors/GetFlexibleRewardsHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse&gt; GetFlexibleSubscriptionPreviewUserData(string productId, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetFlexibleSubscriptionPreviewUserData(productId,
        amount,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse
}
catch (SdkException<GetFlexibleSubscriptionPreviewUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>productId</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse](Models/SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFlexibleSubscriptionPreviewUserDataError](Errors/GetFlexibleSubscriptionPreviewUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse&gt; GetFlexibleSubscriptionRecordUserData(long timestamp, string signature, string? productId, string? purchaseId, string? asset, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetFlexibleSubscriptionRecordUserData(timestamp,
        signature,
        productId,
        purchaseId,
        asset,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse
}
catch (SdkException<GetFlexibleSubscriptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>productId</code> | <code>string?</code> | - |
| <code>purchaseId</code> | <code>string?</code> | - |
| <code>asset</code> | <code>string?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse](Models/SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFlexibleSubscriptionRecordUserDataError](Errors/GetFlexibleSubscriptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedPersonalLeftQuotaResponse&gt; GetLockedPersonalLeftQuotaUserData(string projectId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetLockedPersonalLeftQuotaUserData(projectId,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedPersonalLeftQuotaResponse
}
catch (SdkException<GetLockedPersonalLeftQuotaUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedPersonalLeftQuotaResponse](Models/SapiV1SimpleEarnLockedPersonalLeftQuotaResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLockedPersonalLeftQuotaUserDataError](Errors/GetLockedPersonalLeftQuotaUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedPositionResponse&gt; GetLockedProductPositionUserData(long timestamp, string signature, string? asset, string? positionId, string? projectId, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetLockedProductPositionUserData(timestamp,
        signature,
        asset,
        positionId,
        projectId,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedPositionResponse
}
catch (SdkException<GetLockedProductPositionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>positionId</code> | <code>string?</code> | - |
| <code>projectId</code> | <code>string?</code> | - |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedPositionResponse](Models/SapiV1SimpleEarnLockedPositionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLockedProductPositionUserDataError](Errors/GetLockedProductPositionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse&gt; GetLockedRedemptionRecordUserData(long timestamp, string signature, string? positionId, string? redeemId, string? asset, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetLockedRedemptionRecordUserData(timestamp,
        signature,
        positionId,
        redeemId,
        asset,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse
}
catch (SdkException<GetLockedRedemptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>positionId</code> | <code>string?</code> | - |
| <code>redeemId</code> | <code>string?</code> | - |
| <code>asset</code> | <code>string?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse](Models/SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLockedRedemptionRecordUserDataError](Errors/GetLockedRedemptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedHistoryRewardsRecordResponse&gt; GetLockedRewardsHistoryUserData(long timestamp, string signature, string? positionId, string? asset, long? startTime, long? endTime, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetLockedRewardsHistoryUserData(timestamp,
        signature,
        positionId,
        asset,
        startTime,
        endTime,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedHistoryRewardsRecordResponse
}
catch (SdkException<GetLockedRewardsHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>positionId</code> | <code>string?</code> | - |
| <code>asset</code> | <code>string?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedHistoryRewardsRecordResponse](Models/SapiV1SimpleEarnLockedHistoryRewardsRecordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLockedRewardsHistoryUserDataError](Errors/GetLockedRewardsHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SimpleEarnLockedSubscriptionPreviewResponse&gt;&gt; GetLockedSubscriptionPreviewUserData(string projectId, double amount, long timestamp, string signature, bool? autoSubscribe, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetLockedSubscriptionPreviewUserData(projectId,
        amount,
        timestamp,
        signature,
        autoSubscribe,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SimpleEarnLockedSubscriptionPreviewResponse>
}
catch (SdkException<GetLockedSubscriptionPreviewUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>autoSubscribe</code> | <code>bool?</code> | true or false, default true. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SimpleEarnLockedSubscriptionPreviewResponse](Models/SapiV1SimpleEarnLockedSubscriptionPreviewResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLockedSubscriptionPreviewUserDataError](Errors/GetLockedSubscriptionPreviewUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse&gt; GetLockedSubscriptionRecordUserData(long timestamp, string signature, string? purchaseId, string? asset, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetLockedSubscriptionRecordUserData(timestamp,
        signature,
        purchaseId,
        asset,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse
}
catch (SdkException<GetLockedSubscriptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>purchaseId</code> | <code>string?</code> | - |
| <code>asset</code> | <code>string?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse](Models/SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLockedSubscriptionRecordUserDataError](Errors/GetLockedSubscriptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse&gt; GetRateHistoryUserData(string productId, long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetRateHistoryUserData(productId,
        timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse
}
catch (SdkException<GetRateHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>productId</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse](Models/SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetRateHistoryUserDataError](Errors/GetRateHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleListResponse&gt; GetSimpleEarnFlexibleProductListUserData(long timestamp, string signature, string? asset, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get available Simple Earn flexible product list

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetSimpleEarnFlexibleProductListUserData(timestamp,
        signature,
        asset,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleListResponse
}
catch (SdkException<GetSimpleEarnFlexibleProductListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleListResponse](Models/SapiV1SimpleEarnFlexibleListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSimpleEarnFlexibleProductListUserDataError](Errors/GetSimpleEarnFlexibleProductListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedListResponse&gt; GetSimpleEarnLockedProductListUserData(long timestamp, string signature, string? asset, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.GetSimpleEarnLockedProductListUserData(timestamp,
        signature,
        asset,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedListResponse
}
catch (SdkException<GetSimpleEarnLockedProductListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedListResponse](Models/SapiV1SimpleEarnLockedListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSimpleEarnLockedProductListUserDataError](Errors/GetSimpleEarnLockedProductListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleRedeemResponse&gt; RedeemFlexibleProductTrade(string productId, long timestamp, string signature, bool? redeemAll, double? amount, string? destAccount, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

Rate Limit: 1/3s per account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.RedeemFlexibleProductTrade(productId,
        timestamp,
        signature,
        redeemAll,
        amount,
        destAccount,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleRedeemResponse
}
catch (SdkException<RedeemFlexibleProductTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>productId</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>redeemAll</code> | <code>bool?</code> | true or false, default to false |
| <code>amount</code> | <code>double?</code> | if redeemAll is false, amount is mandatory |
| <code>destAccount</code> | <code>string?</code> | SPOT,FUND,ALL, default SPOT |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleRedeemResponse](Models/SapiV1SimpleEarnFlexibleRedeemResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RedeemFlexibleProductTradeError](Errors/RedeemFlexibleProductTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedRedeemResponse&gt; RedeemLockedProductTrade(string positionId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

Rate Limit: 1/3s per account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.RedeemLockedProductTrade(positionId, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedRedeemResponse
}
catch (SdkException<RedeemLockedProductTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>positionId</code> | <code>string</code> | 1234 |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedRedeemResponse](Models/SapiV1SimpleEarnLockedRedeemResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RedeemLockedProductTradeError](Errors/RedeemLockedProductTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse&gt; SetFlexibleAutoSubscribeUserData(string productId, bool autoSubscribe, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.SetFlexibleAutoSubscribeUserData(productId,
        autoSubscribe,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse
}
catch (SdkException<SetFlexibleAutoSubscribeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>productId</code> | <code>string</code> | - |
| <code>autoSubscribe</code> | <code>bool</code> | true or false |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse](Models/SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetFlexibleAutoSubscribeUserDataError](Errors/SetFlexibleAutoSubscribeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedSetAutoSubscribeResponse&gt; SetLockedAutoSubscribeUserData(string positionId, bool autoSubscribe, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.SetLockedAutoSubscribeUserData(positionId,
        autoSubscribe,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedSetAutoSubscribeResponse
}
catch (SdkException<SetLockedAutoSubscribeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>positionId</code> | <code>string</code> | - |
| <code>autoSubscribe</code> | <code>bool</code> | true or false |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedSetAutoSubscribeResponse](Models/SapiV1SimpleEarnLockedSetAutoSubscribeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetLockedAutoSubscribeUserDataError](Errors/SetLockedAutoSubscribeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedSetRedeemOptionResponse&gt; SetLockedProductRedeemOptionUserData(string positionId, long timestamp, string signature, RedeemTo? redeemTo, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set redeem option for Locked product

Weight(IP): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.SetLockedProductRedeemOptionUserData(positionId,
        timestamp,
        signature,
        redeemTo,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedSetRedeemOptionResponse
}
catch (SdkException<SetLockedProductRedeemOptionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>positionId</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>redeemTo</code> | <code>[RedeemTo?](Models/Enums/RedeemTo.cs)</code> | SPOT,FLEXIBLE, default FLEXIBLE |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedSetRedeemOptionResponse](Models/SapiV1SimpleEarnLockedSetRedeemOptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetLockedProductRedeemOptionUserDataError](Errors/SetLockedProductRedeemOptionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnAccountResponse&gt; SimpleAccountUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.SimpleAccountUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnAccountResponse
}
catch (SdkException<SimpleAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnAccountResponse](Models/SapiV1SimpleEarnAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SimpleAccountUserDataError](Errors/SimpleAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleSubscribeResponse&gt; SubscribeFlexibleProductTrade(string productId, double amount, long timestamp, string signature, bool? autoSubscribe, string? sourceAccount, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

Rate Limit: 1/3s per account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.SubscribeFlexibleProductTrade(productId,
        amount,
        timestamp,
        signature,
        autoSubscribe,
        sourceAccount,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleSubscribeResponse
}
catch (SdkException<SubscribeFlexibleProductTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>productId</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>autoSubscribe</code> | <code>bool?</code> | true or false, default true. |
| <code>sourceAccount</code> | <code>string?</code> | SPOT,FUND,ALL, default SPOT |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleSubscribeResponse](Models/SapiV1SimpleEarnFlexibleSubscribeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubscribeFlexibleProductTradeError](Errors/SubscribeFlexibleProductTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedSubscribeResponse&gt; SubscribeLockedProductTrade(string projectId, double amount, long timestamp, string signature, bool? autoSubscribe, string? sourceAccount, RedeemTo? redeemTo, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

Rate Limit: 1/3s per account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimpleEarn.SubscribeLockedProductTrade(projectId,
        amount,
        timestamp,
        signature,
        autoSubscribe,
        sourceAccount,
        redeemTo,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedSubscribeResponse
}
catch (SdkException<SubscribeLockedProductTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>autoSubscribe</code> | <code>bool?</code> | true or false, default true. |
| <code>sourceAccount</code> | <code>string?</code> | SPOT,FUND,ALL, default SPOT |
| <code>redeemTo</code> | <code>[RedeemTo?](Models/Enums/RedeemTo.cs)</code> | SPOT,FLEXIBLE, default FLEXIBLE |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedSubscribeResponse](Models/SapiV1SimpleEarnLockedSubscribeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubscribeLockedProductTradeError](Errors/SubscribeLockedProductTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SpotAlgo

> Source: [SpotAlgo](Api/SpotAlgo.cs)

<details>
<summary><code>Task&lt;SapiV1AlgoSpotOrderResponse&gt; CancelAlgoOrder(long algoId, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel an open TWAP order

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SpotAlgo.CancelAlgoOrder(algoId, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoSpotOrderResponse
}
catch (SdkException<CancelAlgoOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algoId</code> | <code>long</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotOrderResponse](Models/SapiV1AlgoSpotOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelAlgoOrderError](Errors/CancelAlgoOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoSpotOpenOrdersResponse&gt; QueryCurrentAlgoOpenOrders(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all open SPOT TWAP orders

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SpotAlgo.QueryCurrentAlgoOpenOrders(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoSpotOpenOrdersResponse
}
catch (SdkException<QueryCurrentAlgoOpenOrdersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotOpenOrdersResponse](Models/SapiV1AlgoSpotOpenOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryCurrentAlgoOpenOrdersError](Errors/QueryCurrentAlgoOpenOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoSpotHistoricalOrdersResponse&gt; QueryHistoricalAlgoOrders(string symbol, Side side, long timestamp, string signature, long? startTime, long? endTime, int? page, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all historical SPOT TWAP orders

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SpotAlgo.QueryHistoricalAlgoOrders(symbol,
        side,
        timestamp,
        signature,
        startTime,
        endTime,
        page,
        pageSize,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoSpotHistoricalOrdersResponse
}
catch (SdkException<QueryHistoricalAlgoOrdersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>pageSize</code> | <code>string?</code> | MIN 1, MAX 100; Default 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotHistoricalOrdersResponse](Models/SapiV1AlgoSpotHistoricalOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryHistoricalAlgoOrdersError](Errors/QueryHistoricalAlgoOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoSpotSubOrdersResponse&gt; QuerySubOrders(long algoId, long timestamp, string signature, int? page, string? pageSize, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get respective sub orders for a specified algoId

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SpotAlgo.QuerySubOrders(algoId, timestamp, signature, page, pageSize, recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoSpotSubOrdersResponse
}
catch (SdkException<QuerySubOrdersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>algoId</code> | <code>long</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>pageSize</code> | <code>string?</code> | MIN 1, MAX 100; Default 100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotSubOrdersResponse](Models/SapiV1AlgoSpotSubOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QuerySubOrdersError](Errors/QuerySubOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoSpotNewOrderTwapResponse&gt; TimeWeightedAveragePriceTwapNewOrder(string symbol, Side side, double quantity, int duration, long timestamp, string signature, string? clientAlgoId, double? limitPrice, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Place a new spot TWAP order with Algo service.

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SpotAlgo.TimeWeightedAveragePriceTwapNewOrder(symbol,
        side,
        quantity,
        duration,
        timestamp,
        signature,
        clientAlgoId,
        limitPrice,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AlgoSpotNewOrderTwapResponse
}
catch (SdkException<TimeWeightedAveragePriceTwapNewOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>quantity</code> | <code>double</code> | - |
| <code>duration</code> | <code>int</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>clientAlgoId</code> | <code>string?</code> | - |
| <code>limitPrice</code> | <code>double?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotNewOrderTwapResponse](Models/SapiV1AlgoSpotNewOrderTwapResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TimeWeightedAveragePriceTwapNewOrderError](Errors/TimeWeightedAveragePriceTwapNewOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Staking

> Source: [Staking](Api/Staking.cs)

<details>
<summary><code>Task&lt;SapiV2EthStakingAccountResponse&gt; EthStakingAccountV2UserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.EthStakingAccountV2UserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV2EthStakingAccountResponse
}
catch (SdkException<EthStakingAccountV2UserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2EthStakingAccountResponse](Models/SapiV2EthStakingAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EthStakingAccountV2UserDataError](Errors/EthStakingAccountV2UserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryRewardsHistoryResponse&gt; GetBethRewardsDistributionHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The time between startTime and endTime cannot be longer than 3 months.
- If startTime and endTime are both not sent, then the last 30 days' data will be returned.
- If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.
- If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.GetBethRewardsDistributionHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryRewardsHistoryResponse
}
catch (SdkException<GetBethRewardsDistributionHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryRewardsHistoryResponse](Models/SapiV1EthStakingEthHistoryRewardsHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBethRewardsDistributionHistoryUserDataError](Errors/GetBethRewardsDistributionHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryRedemptionHistoryResponse&gt; GetEthRedemptionHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The time between startTime and endTime cannot be longer than 3 months.
- If startTime and endTime are both not sent, then the last 30 days' data will be returned.
- If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.
- If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.GetEthRedemptionHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryRedemptionHistoryResponse
}
catch (SdkException<GetEthRedemptionHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryRedemptionHistoryResponse](Models/SapiV1EthStakingEthHistoryRedemptionHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetEthRedemptionHistoryUserDataError](Errors/GetEthRedemptionHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryStakingHistoryResponse&gt; GetEthStakingHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The time between startTime and endTime cannot be longer than 3 months.
- If startTime and endTime are both not sent, then the last 30 days' data will be returned.
- If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.
- If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.GetEthStakingHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryStakingHistoryResponse
}
catch (SdkException<GetEthStakingHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryStakingHistoryResponse](Models/SapiV1EthStakingEthHistoryStakingHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetEthStakingHistoryUserDataError](Errors/GetEthStakingHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryRateHistoryResponse&gt; GetWbethRateHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The time between startTime and endTime cannot be longer than 3 months.
- If startTime and endTime are both not sent, then the last 30 days' data will be returned.
- If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.
- If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.GetWbethRateHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryRateHistoryResponse
}
catch (SdkException<GetWbethRateHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryRateHistoryResponse](Models/SapiV1EthStakingEthHistoryRateHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetWbethRateHistoryUserDataError](Errors/GetWbethRateHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse&gt; GetWbethRewardsHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The time between startTime and endTime cannot be longer than 3 months.
- If startTime and endTime are both not sent, then the last 30 days' data will be returned.
- If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.
- If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.GetWbethRewardsHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse
}
catch (SdkException<GetWbethRewardsHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse](Models/SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetWbethRewardsHistoryUserDataError](Errors/GetWbethRewardsHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingWbethHistoryUnwrapHistoryResponse&gt; GetWbethUnwrapHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The time between startTime and endTime cannot be longer than 3 months.
- If startTime and endTime are both not sent, then the last 30 days' data will be returned.
- If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.
- If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.GetWbethUnwrapHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingWbethHistoryUnwrapHistoryResponse
}
catch (SdkException<GetWbethUnwrapHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingWbethHistoryUnwrapHistoryResponse](Models/SapiV1EthStakingWbethHistoryUnwrapHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetWbethUnwrapHistoryUserDataError](Errors/GetWbethUnwrapHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingWbethHistoryWrapHistoryResponse&gt; GetWbethWrapHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The time between startTime and endTime cannot be longer than 3 months.
- If startTime and endTime are both not sent, then the last 30 days' data will be returned.
- If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.
- If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.GetWbethWrapHistoryUserData(timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingWbethHistoryWrapHistoryResponse
}
catch (SdkException<GetWbethWrapHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingWbethHistoryWrapHistoryResponse](Models/SapiV1EthStakingWbethHistoryWrapHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetWbethWrapHistoryUserDataError](Errors/GetWbethWrapHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthQuotaResponse&gt; GetCurrentEthStakingQuotaUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.GetCurrentEthStakingQuotaUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingEthQuotaResponse
}
catch (SdkException<GetCurrentEthStakingQuotaUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthQuotaResponse](Models/SapiV1EthStakingEthQuotaResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCurrentEthStakingQuotaUserDataError](Errors/GetCurrentEthStakingQuotaUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthRedeemResponse&gt; RedeemEthTrade(double amount, long timestamp, string signature, string? asset, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Redeem WBETH or BETH and get ETH

- You need to open Enable Spot & Margin Trading permission for the API Key which requests this endpoint.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.RedeemEthTrade(amount, timestamp, signature, asset, recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingEthRedeemResponse
}
catch (SdkException<RedeemEthTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>amount</code> | <code>double</code> | Amount in BETH, limit 8 decimals |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | WBETH or BETH, default to BETH |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthRedeemResponse](Models/SapiV1EthStakingEthRedeemResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RedeemEthTradeError](Errors/RedeemEthTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2EthStakingEthStakeResponse&gt; SubscribeEthStakingV2Trade(double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stake ETH to get WBETH

- You need to open Enable Spot & Margin Trading permission for the API Key which requests this endpoint.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.SubscribeEthStakingV2Trade(amount, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV2EthStakingEthStakeResponse
}
catch (SdkException<SubscribeEthStakingV2TradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>amount</code> | <code>double</code> | Amount in ETH, limit 4 decimals |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2EthStakingEthStakeResponse](Models/SapiV2EthStakingEthStakeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubscribeEthStakingV2TradeError](Errors/SubscribeEthStakingV2TradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingWbethWrapResponse&gt; WrapBethTrade(double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- You need to open Enable Spot & Margin Trading permission for the API Key which requests this endpoint.

Weight(IP): 150

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Staking.WrapBethTrade(amount, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1EthStakingWbethWrapResponse
}
catch (SdkException<WrapBethTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>amount</code> | <code>double</code> | Amount in BETH, limit 4 decimals |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingWbethWrapResponse](Models/SapiV1EthStakingWbethWrapResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[WrapBethTradeError](Errors/WrapBethTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## StreamApi

> Source: [StreamApi](Api/StreamApi.cs)

<details>
<summary><code>Task&lt;object&gt; CloseAListenKeyUserStream(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Close out a user data stream.

Weight: 2

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StreamApi.CloseAListenKeyUserStream(listenKey);
    // TODO: Handle 'response' of type object
}
catch (SdkException<CloseAListenKeyUserStreamError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>listenKey</code> | <code>string?</code> | User websocket listen key |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CloseAListenKeyUserStreamError](Errors/CloseAListenKeyUserStreamError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3UserDataStreamResponse&gt; CreateAListenKeyUserStream(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Start a new user data stream.
The stream will close after 60 minutes unless a keepalive is sent. If the account has an active `listenKey`, that `listenKey` will be returned and its validity will be extended for 60 minutes.

Weight: 2

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StreamApi.CreateAListenKeyUserStream();
    // TODO: Handle 'response' of type ApiV3UserDataStreamResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3UserDataStreamResponse](Models/ApiV3UserDataStreamResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; PingKeepAliveAListenKeyUserStream(string? listenKey, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Keepalive a user data stream to prevent a time out. User data streams will close after 60 minutes. It's recommended to send a ping about every 30 minutes.

Weight: 2

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StreamApi.PingKeepAliveAListenKeyUserStream(listenKey);
    // TODO: Handle 'response' of type object
}
catch (SdkException<PingKeepAliveAListenKeyUserStreamError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>listenKey</code> | <code>string?</code> | User websocket listen key |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PingKeepAliveAListenKeyUserStreamError](Errors/PingKeepAliveAListenKeyUserStreamError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SubAccountApi

> Source: [SubAccountApi](Api/SubAccountApi.cs)

<details>
<summary><code>Task&lt;SapiV1SubAccountVirtualSubAccountResponse&gt; CreateAVirtualSubAccountForMasterAccount(string subAccountString, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- This request will generate a virtual sub account under your master account.
- You need to enable "trade" option for the api key which requests this endpoint.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.CreateAVirtualSubAccountForMasterAccount(subAccountString,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountVirtualSubAccountResponse
}
catch (SdkException<CreateAVirtualSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>subAccountString</code> | <code>string</code> | Please input a string. We will create a virtual email using that string for you to register |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountVirtualSubAccountResponse](Models/SapiV1SubAccountVirtualSubAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateAVirtualSubAccountForMasterAccountError](Errors/CreateAVirtualSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse&gt; DeleteIpListForASubAccountApiKeyForMasterAccount(string email, string subAccountApiKey, long timestamp, string signature, string? ipAddress, string? thirdPartyName, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.DeleteIpListForASubAccountApiKeyForMasterAccount(email,
        subAccountApiKey,
        timestamp,
        signature,
        ipAddress,
        thirdPartyName,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse
}
catch (SdkException<DeleteIpListForASubAccountApiKeyForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>subAccountApiKey</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>ipAddress</code> | <code>string?</code> | Can be added in batches, separated by commas |
| <code>thirdPartyName</code> | <code>string?</code> | third party IP list name |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse](Models/SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteIpListForASubAccountApiKeyForMasterAccountError](Errors/DeleteIpListForASubAccountApiKeyForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountDepositResponse&gt; DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount(string toEmail, string asset, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount(toEmail,
        asset,
        amount,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountDepositResponse
}
catch (SdkException<DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>toEmail</code> | <code>string</code> | Recipient email |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountDepositResponse](Models/SapiV1ManagedSubaccountDepositResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError](Errors/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesAccountResponse&gt; DetailOnSubAccountSFuturesAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.DetailOnSubAccountSFuturesAccountForMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesAccountResponse
}
catch (SdkException<DetailOnSubAccountSFuturesAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesAccountResponse](Models/SapiV1SubAccountFuturesAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DetailOnSubAccountSFuturesAccountForMasterAccountError](Errors/DetailOnSubAccountSFuturesAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2SubAccountFuturesAccountResponse&gt; DetailOnSubAccountSFuturesAccountV2ForMasterAccount(string email, int futuresType, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.DetailOnSubAccountSFuturesAccountV2ForMasterAccount(email,
        futuresType,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2SubAccountFuturesAccountResponse
}
catch (SdkException<DetailOnSubAccountSFuturesAccountV2ForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>futuresType</code> | <code>int</code> | * `1` - USDT Margined Futures<br>* `2` - COIN Margined Futures |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountFuturesAccountResponse](Models/AnyOf/SapiV2SubAccountFuturesAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DetailOnSubAccountSFuturesAccountV2ForMasterAccountError](Errors/DetailOnSubAccountSFuturesAccountV2ForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountMarginAccountResponse&gt; DetailOnSubAccountSMarginAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.DetailOnSubAccountSMarginAccountForMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountMarginAccountResponse
}
catch (SdkException<DetailOnSubAccountSMarginAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginAccountResponse](Models/SapiV1SubAccountMarginAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DetailOnSubAccountSMarginAccountForMasterAccountError](Errors/DetailOnSubAccountSMarginAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesEnableResponse&gt; EnableFuturesForSubAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.EnableFuturesForSubAccountForMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesEnableResponse
}
catch (SdkException<EnableFuturesForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesEnableResponse](Models/SapiV1SubAccountFuturesEnableResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EnableFuturesForSubAccountForMasterAccountError](Errors/EnableFuturesForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountBlvtEnableResponse&gt; EnableLeverageTokenForSubAccountForMasterAccount(string email, bool enableBlvt, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.EnableLeverageTokenForSubAccountForMasterAccount(email,
        enableBlvt,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountBlvtEnableResponse
}
catch (SdkException<EnableLeverageTokenForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>enableBlvt</code> | <code>bool</code> | Only true for now |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountBlvtEnableResponse](Models/SapiV1SubAccountBlvtEnableResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EnableLeverageTokenForSubAccountForMasterAccountError](Errors/EnableLeverageTokenForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountMarginEnableResponse&gt; EnableMarginForSubAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.EnableMarginForSubAccountForMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountMarginEnableResponse
}
catch (SdkException<EnableMarginForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginEnableResponse](Models/SapiV1SubAccountMarginEnableResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EnableMarginForSubAccountForMasterAccountError](Errors/EnableMarginForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountEoptionsEnableResponse&gt; EnableOptionsForSubAccountForMasterAccountUserData(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable Options for Sub-account (For Master Account).

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.EnableOptionsForSubAccountForMasterAccountUserData(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountEoptionsEnableResponse
}
catch (SdkException<EnableOptionsForSubAccountForMasterAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountEoptionsEnableResponse](Models/SapiV1SubAccountEoptionsEnableResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EnableOptionsForSubAccountForMasterAccountUserDataError](Errors/EnableOptionsForSubAccountForMasterAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountFuturesPositionRiskResponse&gt;&gt; FuturesPositionRiskOfSubAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.FuturesPositionRiskOfSubAccountForMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountFuturesPositionRiskResponse>
}
catch (SdkException<FuturesPositionRiskOfSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountFuturesPositionRiskResponse](Models/SapiV1SubAccountFuturesPositionRiskResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FuturesPositionRiskOfSubAccountForMasterAccountError](Errors/FuturesPositionRiskOfSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2SubAccountFuturesPositionRiskResponse&gt; FuturesPositionRiskOfSubAccountV2ForMasterAccount(string email, int futuresType, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.FuturesPositionRiskOfSubAccountV2ForMasterAccount(email,
        futuresType,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2SubAccountFuturesPositionRiskResponse
}
catch (SdkException<FuturesPositionRiskOfSubAccountV2ForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>futuresType</code> | <code>int</code> | * `1` - USDT Margined Futures<br>* `2` - COIN Margined Futures |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountFuturesPositionRiskResponse](Models/AnyOf/SapiV2SubAccountFuturesPositionRiskResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FuturesPositionRiskOfSubAccountV2ForMasterAccountError](Errors/FuturesPositionRiskOfSubAccountV2ForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountSubAccountApiIpRestrictionResponse&gt; GetIpRestrictionForASubAccountApiKeyForMasterAccount(string email, string subAccountApiKey, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.GetIpRestrictionForASubAccountApiKeyForMasterAccount(email,
        subAccountApiKey,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountSubAccountApiIpRestrictionResponse
}
catch (SdkException<GetIpRestrictionForASubAccountApiKeyForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>subAccountApiKey</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountSubAccountApiIpRestrictionResponse](Models/SapiV1SubAccountSubAccountApiIpRestrictionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetIpRestrictionForASubAccountApiKeyForMasterAccountError](Errors/GetIpRestrictionForASubAccountApiKeyForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountDepositAddressResponse&gt; GetManagedSubAccountDepositAddressForInvestorMasterAccount(string email, string coin, long timestamp, string signature, string? network, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get investor's managed sub-account deposit address

Weight(UID): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.GetManagedSubAccountDepositAddressForInvestorMasterAccount(email,
        coin,
        timestamp,
        signature,
        network,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountDepositAddressResponse
}
catch (SdkException<GetManagedSubAccountDepositAddressForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>coin</code> | <code>string</code> | Coin name |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>network</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountDepositAddressResponse](Models/SapiV1ManagedSubaccountDepositAddressResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetManagedSubAccountDepositAddressForInvestorMasterAccountError](Errors/GetManagedSubAccountDepositAddressForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1ManagedSubaccountAssetResponse&gt;&gt; ManagedSubAccountAssetDetailsForInvestorMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.ManagedSubAccountAssetDetailsForInvestorMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1ManagedSubaccountAssetResponse>
}
catch (SdkException<ManagedSubAccountAssetDetailsForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1ManagedSubaccountAssetResponse](Models/SapiV1ManagedSubaccountAssetResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ManagedSubAccountAssetDetailsForInvestorMasterAccountError](Errors/ManagedSubAccountAssetDetailsForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountAccountSnapshotResponse&gt; ManagedSubAccountSnapshotForInvestorMasterAccount(string email, string type, long timestamp, string signature, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The query time period must be less then 30 days
- Support query within the last one month only
- If `startTime` and `endTime` not sent, return records of the last 7 days by default

Weight(IP): 2400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.ManagedSubAccountSnapshotForInvestorMasterAccount(email,
        type,
        timestamp,
        signature,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountAccountSnapshotResponse
}
catch (SdkException<ManagedSubAccountSnapshotForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>type</code> | <code>string</code> | "SPOT", "MARGIN"(cross), "FUTURES"(UM) |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | min 7, max 30, default 7 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountAccountSnapshotResponse](Models/SapiV1ManagedSubaccountAccountSnapshotResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ManagedSubAccountSnapshotForInvestorMasterAccountError](Errors/ManagedSubAccountSnapshotForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountMarginTransferResponse&gt; MarginTransferForSubAccountForMasterAccount(string email, string asset, double amount, int type, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.MarginTransferForSubAccountForMasterAccount(email,
        asset,
        amount,
        type,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountMarginTransferResponse
}
catch (SdkException<MarginTransferForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>type</code> | <code>int</code> | * `1` - transfer from subaccount's spot account to margin account<br>* `2` - transfer from subaccount's margin account to its spot account |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginTransferResponse](Models/SapiV1SubAccountMarginTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MarginTransferForSubAccountForMasterAccountError](Errors/MarginTransferForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountQueryTransLogForInvestorResponse&gt; QueryManagedSubAccountTransferLogForInvestorMasterAccount(string email, long timestamp, string signature, long? startTime, long? endTime, int? page, int? limit, string? transfers, string? transferFunctionAccountType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Investor can use this api to query managed sub account transfer log. This endpoint is available for investor of Managed Sub-Account. A Managed Sub-Account is an account type for investors who value flexibility in asset allocation and account application, while delegating trades to a professional trading team.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.QueryManagedSubAccountTransferLogForInvestorMasterAccount(email,
        timestamp,
        signature,
        startTime,
        endTime,
        page,
        limit,
        transfers,
        transferFunctionAccountType,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountQueryTransLogForInvestorResponse
}
catch (SdkException<QueryManagedSubAccountTransferLogForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>transfers</code> | <code>string?</code> | Transfer Direction (FROM/TO) |
| <code>transferFunctionAccountType</code> | <code>string?</code> | Transfer function account type (SPOT/MARGIN/ISOLATED_MARGIN/USDT_FUTURE/COIN_FUTURE) |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountQueryTransLogForInvestorResponse](Models/SapiV1ManagedSubaccountQueryTransLogForInvestorResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryManagedSubAccountTransferLogForInvestorMasterAccountError](Errors/QueryManagedSubAccountTransferLogForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse&gt; QueryManagedSubAccountTransferLogForTradingTeamMasterAccount(string email, long timestamp, string signature, long? startTime, long? endTime, int? page, int? limit, string? transfers, string? transferFunctionAccountType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Trading team can use this api to query managed sub account transfer log. This endpoint is available for trading team of Managed Sub-Account. A Managed Sub-Account is an account type for investors who value flexibility in asset allocation and account application, while delegating trades to a professional trading team

Weight(IP): 60

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.QueryManagedSubAccountTransferLogForTradingTeamMasterAccount(email,
        timestamp,
        signature,
        startTime,
        endTime,
        page,
        limit,
        transfers,
        transferFunctionAccountType,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse
}
catch (SdkException<QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>transfers</code> | <code>string?</code> | Transfer Direction (FROM/TO) |
| <code>transferFunctionAccountType</code> | <code>string?</code> | Transfer function account type (SPOT/MARGIN/ISOLATED_MARGIN/USDT_FUTURE/COIN_FUTURE) |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse](Models/SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError](Errors/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountQueryTransLogResponse&gt; QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData(Transfers transfers, TransferFunctionAccountType transferFunctionAccountType, long timestamp, string signature, long? startTime, long? endTime, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Managed Sub Account Transfer Log (For Trading Team Sub Account)

Weight(UID): 60

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData(transfers,
        transferFunctionAccountType,
        timestamp,
        signature,
        startTime,
        endTime,
        page,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountQueryTransLogResponse
}
catch (SdkException<QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transfers</code> | <code>[Transfers](Models/Enums/Transfers.cs)</code> | Transfer Direction |
| <code>transferFunctionAccountType</code> | <code>[TransferFunctionAccountType](Models/Enums/TransferFunctionAccountType.cs)</code> | Transfer function account type |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountQueryTransLogResponse](Models/SapiV1ManagedSubaccountQueryTransLogResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError](Errors/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountFetchFutureAssetResponse&gt; QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Investor can use this api to query managed sub account futures asset details

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountFetchFutureAssetResponse
}
catch (SdkException<QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountFetchFutureAssetResponse](Models/SapiV1ManagedSubaccountFetchFutureAssetResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError](Errors/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountInfoResponse&gt; QueryManagedSubAccountListForInvestor(string email, long timestamp, string signature, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get investor's managed sub-account list.

Weight(UID): 60

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.QueryManagedSubAccountListForInvestor(email,
        timestamp,
        signature,
        page,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountInfoResponse
}
catch (SdkException<QueryManagedSubAccountListForInvestorError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountInfoResponse](Models/SapiV1ManagedSubaccountInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryManagedSubAccountListForInvestorError](Errors/QueryManagedSubAccountListForInvestorError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountMarginAssetResponse&gt; QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Investor can use this api to query managed sub account margin asset details

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountMarginAssetResponse
}
catch (SdkException<QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountMarginAssetResponse](Models/SapiV1ManagedSubaccountMarginAssetResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError](Errors/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV4SubAccountAssetsResponse&gt; QuerySubAccountAssetsForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch sub-account assets

Weight(UID): 60

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.QuerySubAccountAssetsForMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV4SubAccountAssetsResponse
}
catch (SdkException<QuerySubAccountAssetsForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV4SubAccountAssetsResponse](Models/SapiV4SubAccountAssetsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QuerySubAccountAssetsForMasterAccountError](Errors/QuerySubAccountAssetsForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountListResponse&gt; QuerySubAccountListForMasterAccount(long timestamp, string signature, string? email, IsFreeze? isFreeze, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.QuerySubAccountListForMasterAccount(timestamp,
        signature,
        email,
        isFreeze,
        page,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountListResponse
}
catch (SdkException<QuerySubAccountListForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>email</code> | <code>string?</code> | Sub-account email |
| <code>isFreeze</code> | <code>[IsFreeze?](Models/Enums/IsFreeze.cs)</code> | - |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>limit</code> | <code>int?</code> | Default 1; max 200 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountListResponse](Models/SapiV1SubAccountListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QuerySubAccountListForMasterAccountError](Errors/QuerySubAccountListForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountTransactionStatisticsResponse&gt; QuerySubAccountTransactionStatisticsForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Sub-account Transaction statistics (For Master Account).

Weight(UID): 60

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.QuerySubAccountTransactionStatisticsForMasterAccount(email,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountTransactionStatisticsResponse
}
catch (SdkException<QuerySubAccountTransactionStatisticsForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountTransactionStatisticsResponse](Models/SapiV1SubAccountTransactionStatisticsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QuerySubAccountTransactionStatisticsForMasterAccountError](Errors/QuerySubAccountTransactionStatisticsForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV3SubAccountAssetsResponse&gt; SubAccountAssetsForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch sub-account assets

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SubAccountAssetsForMasterAccount(email, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV3SubAccountAssetsResponse
}
catch (SdkException<SubAccountAssetsForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV3SubAccountAssetsResponse](Models/SapiV3SubAccountAssetsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubAccountAssetsForMasterAccountError](Errors/SubAccountAssetsForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalDepositSubHisrecResponse&gt;&gt; SubAccountDepositHistoryForMasterAccount(string email, long timestamp, string signature, string? coin, int? status, long? startTime, long? endTime, long? limit, int? offset, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch sub-account deposit history

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SubAccountDepositHistoryForMasterAccount(email,
        timestamp,
        signature,
        coin,
        status,
        startTime,
        endTime,
        limit,
        offset,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalDepositSubHisrecResponse>
}
catch (SdkException<SubAccountDepositHistoryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>coin</code> | <code>string?</code> | Coin name |
| <code>status</code> | <code>int?</code> | 0(0:pending,6: credited but cannot withdraw, 1:success) |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>long?</code> | - |
| <code>offset</code> | <code>int?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalDepositSubHisrecResponse](Models/SapiV1CapitalDepositSubHisrecResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubAccountDepositHistoryForMasterAccountError](Errors/SubAccountDepositHistoryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesInternalTransferResponse1&gt; SubAccountFuturesAssetTransferForMasterAccount(string fromEmail, string toEmail, int futuresType, string asset, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Master account can transfer max 2000 times a minute

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SubAccountFuturesAssetTransferForMasterAccount(fromEmail,
        toEmail,
        futuresType,
        asset,
        amount,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesInternalTransferResponse1
}
catch (SdkException<SubAccountFuturesAssetTransferForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>fromEmail</code> | <code>string</code> | Sender email |
| <code>toEmail</code> | <code>string</code> | Recipient email |
| <code>futuresType</code> | <code>int</code> | 1:USDT-margined Futures,2: Coin-margined Futures |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesInternalTransferResponse1](Models/SapiV1SubAccountFuturesInternalTransferResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubAccountFuturesAssetTransferForMasterAccountError](Errors/SubAccountFuturesAssetTransferForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesInternalTransferResponse&gt; SubAccountFuturesAssetTransferHistoryForMasterAccount(string email, int futuresType, long timestamp, string signature, long? startTime, long? endTime, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SubAccountFuturesAssetTransferHistoryForMasterAccount(email,
        futuresType,
        timestamp,
        signature,
        startTime,
        endTime,
        page,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesInternalTransferResponse
}
catch (SdkException<SubAccountFuturesAssetTransferHistoryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>futuresType</code> | <code>int</code> | 1:USDT-margined Futures, 2: Coin-margined Futures |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>limit</code> | <code>int?</code> | Default value: 50, Max value: 500 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesInternalTransferResponse](Models/SapiV1SubAccountFuturesInternalTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubAccountFuturesAssetTransferHistoryForMasterAccountError](Errors/SubAccountFuturesAssetTransferHistoryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountSubTransferHistoryResponse&gt;&gt; SubAccountSpotAssetTransferHistoryForMasterAccount(long timestamp, string signature, string? fromEmail, string? toEmail, long? startTime, long? endTime, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- fromEmail and toEmail cannot be sent at the same time.
- Return fromEmail equal master account email by default.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SubAccountSpotAssetTransferHistoryForMasterAccount(timestamp,
        signature,
        fromEmail,
        toEmail,
        startTime,
        endTime,
        page,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountSubTransferHistoryResponse>
}
catch (SdkException<SubAccountSpotAssetTransferHistoryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>fromEmail</code> | <code>string?</code> | Sub-account email |
| <code>toEmail</code> | <code>string?</code> | Sub-account email |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>limit</code> | <code>int?</code> | Default 1 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountSubTransferHistoryResponse](Models/SapiV1SubAccountSubTransferHistoryResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubAccountSpotAssetTransferHistoryForMasterAccountError](Errors/SubAccountSpotAssetTransferHistoryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountSpotSummaryResponse&gt; SubAccountSpotAssetsSummaryForMasterAccount(long timestamp, string signature, string? email, int? page, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get BTC valued asset summary of subaccounts.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SubAccountSpotAssetsSummaryForMasterAccount(timestamp,
        signature,
        email,
        page,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountSpotSummaryResponse
}
catch (SdkException<SubAccountSpotAssetsSummaryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>email</code> | <code>string?</code> | Sub-account email |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:20 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountSpotSummaryResponse](Models/SapiV1SubAccountSpotSummaryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubAccountSpotAssetsSummaryForMasterAccountError](Errors/SubAccountSpotAssetsSummaryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalDepositSubAddressResponse&gt; SubAccountSpotAssetsSummaryForMasterAccount2(string email, string coin, long timestamp, string signature, string? network, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch sub-account deposit address

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SubAccountSpotAssetsSummaryForMasterAccount2(email,
        coin,
        timestamp,
        signature,
        network,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1CapitalDepositSubAddressResponse
}
catch (SdkException<SubAccountSpotAssetsSummaryForMasterAccount2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>coin</code> | <code>string</code> | Coin name |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>network</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalDepositSubAddressResponse](Models/SapiV1CapitalDepositSubAddressResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubAccountSpotAssetsSummaryForMasterAccount2Error](Errors/SubAccountSpotAssetsSummaryForMasterAccount2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountTransferSubUserHistoryResponse&gt;&gt; SubAccountTransferHistoryForSubAccount(long timestamp, string signature, string? asset, int? type, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If `type` is not sent, the records of type 2: transfer out will be returned by default.
- If `startTime` and `endTime` are not sent, the recent 30-day data will be returned.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SubAccountTransferHistoryForSubAccount(timestamp,
        signature,
        asset,
        type,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountTransferSubUserHistoryResponse>
}
catch (SdkException<SubAccountTransferHistoryForSubAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>type</code> | <code>int?</code> | * `1` - transfer in<br>* `2` - transfer out |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountTransferSubUserHistoryResponse](Models/SapiV1SubAccountTransferSubUserHistoryResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubAccountTransferHistoryForSubAccountError](Errors/SubAccountTransferHistoryForSubAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountStatusResponse&gt;&gt; SubAccountSStatusOnMarginFuturesForMasterAccount(long timestamp, string signature, string? email, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- If no `email` sent, all sub-accounts' information will be returned.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SubAccountSStatusOnMarginFuturesForMasterAccount(timestamp,
        signature,
        email,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountStatusResponse>
}
catch (SdkException<SubAccountSStatusOnMarginFuturesForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>email</code> | <code>string?</code> | Sub-account email |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountStatusResponse](Models/SapiV1SubAccountStatusResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubAccountSStatusOnMarginFuturesForMasterAccountError](Errors/SubAccountSStatusOnMarginFuturesForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesAccountSummaryResponse&gt; SummaryOfSubAccountSFuturesAccountForMasterAccount(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SummaryOfSubAccountSFuturesAccountForMasterAccount(timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesAccountSummaryResponse
}
catch (SdkException<SummaryOfSubAccountSFuturesAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesAccountSummaryResponse](Models/SapiV1SubAccountFuturesAccountSummaryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SummaryOfSubAccountSFuturesAccountForMasterAccountError](Errors/SummaryOfSubAccountSFuturesAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2SubAccountFuturesAccountSummaryResponse&gt; SummaryOfSubAccountSFuturesAccountV2ForMasterAccount(int futuresType, long timestamp, string signature, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SummaryOfSubAccountSFuturesAccountV2ForMasterAccount(futuresType,
        timestamp,
        signature,
        page,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2SubAccountFuturesAccountSummaryResponse
}
catch (SdkException<SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>futuresType</code> | <code>int</code> | * `1` - USDT Margined Futures<br>* `2` - COIN Margined Futures |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>limit</code> | <code>int?</code> | Default 10, Max 20 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountFuturesAccountSummaryResponse](Models/AnyOf/SapiV2SubAccountFuturesAccountSummaryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError](Errors/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountMarginAccountSummaryResponse&gt; SummaryOfSubAccountSMarginAccountForMasterAccount(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.SummaryOfSubAccountSMarginAccountForMasterAccount(timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountMarginAccountSummaryResponse
}
catch (SdkException<SummaryOfSubAccountSMarginAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginAccountSummaryResponse](Models/SapiV1SubAccountMarginAccountSummaryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SummaryOfSubAccountSMarginAccountForMasterAccountError](Errors/SummaryOfSubAccountSMarginAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesTransferResponse&gt; TransferForSubAccountForMasterAccount(string email, string asset, double amount, int type, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.TransferForSubAccountForMasterAccount(email,
        asset,
        amount,
        type,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesTransferResponse
}
catch (SdkException<TransferForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>type</code> | <code>int</code> | * `1` - transfer from subaccount's spot account to its USDT-margined futures account<br>* `2` - transfer from subaccount's USDT-margined futures account to its spot account<br>* `3` - transfer from subaccount's spot account to its COIN-margined futures account<br>* `4` - transfer from subaccount's COIN-margined futures account to its spot account |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesTransferResponse](Models/SapiV1SubAccountFuturesTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TransferForSubAccountForMasterAccountError](Errors/TransferForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountTransferSubToMasterResponse&gt; TransferToMasterForSubAccount(string asset, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.TransferToMasterForSubAccount(asset,
        amount,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountTransferSubToMasterResponse
}
catch (SdkException<TransferToMasterForSubAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountTransferSubToMasterResponse](Models/SapiV1SubAccountTransferSubToMasterResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TransferToMasterForSubAccountError](Errors/TransferToMasterForSubAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountTransferSubToSubResponse&gt; TransferToSubAccountOfSameMasterForSubAccount(string toEmail, string asset, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.TransferToSubAccountOfSameMasterForSubAccount(toEmail,
        asset,
        amount,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountTransferSubToSubResponse
}
catch (SdkException<TransferToSubAccountOfSameMasterForSubAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>toEmail</code> | <code>string</code> | Recipient email |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountTransferSubToSubResponse](Models/SapiV1SubAccountTransferSubToSubResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TransferToSubAccountOfSameMasterForSubAccountError](Errors/TransferToSubAccountOfSameMasterForSubAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountUniversalTransferResponse1&gt; UniversalTransferForMasterAccount(FromAccountType fromAccountType, ToAccountType toAccountType, string asset, double amount, long timestamp, string signature, string? fromEmail, string? toEmail, string? clientTranId, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- You need to enable "internal transfer" option for the api key which requests this endpoint.
- Transfer from master account by default if fromEmail is not sent.
- Transfer to master account by default if toEmail is not sent.
- Supported transfer scenarios:
  - Master account SPOT transfer to sub-account SPOT,USDT_FUTURE,COIN_FUTURE,MARGIN(Cross),ISOLATED_MARGIN
  - Sub-account SPOT,USDT_FUTURE,COIN_FUTURE,MARGIN(Cross),ISOLATED_MARGIN transfer to master account SPOT
  - Transfer between two sub-account SPOT accounts

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.UniversalTransferForMasterAccount(fromAccountType,
        toAccountType,
        asset,
        amount,
        timestamp,
        signature,
        fromEmail,
        toEmail,
        clientTranId,
        symbol,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1SubAccountUniversalTransferResponse1
}
catch (SdkException<UniversalTransferForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>fromAccountType</code> | <code>[FromAccountType](Models/Enums/FromAccountType.cs)</code> | - |
| <code>toAccountType</code> | <code>[ToAccountType](Models/Enums/ToAccountType.cs)</code> | - |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>fromEmail</code> | <code>string?</code> | Sub-account email |
| <code>toEmail</code> | <code>string?</code> | Sub-account email |
| <code>clientTranId</code> | <code>string?</code> | - |
| <code>symbol</code> | <code>string?</code> | Only supported under ISOLATED_MARGIN type |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountUniversalTransferResponse1](Models/SapiV1SubAccountUniversalTransferResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UniversalTransferForMasterAccountError](Errors/UniversalTransferForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountUniversalTransferResponse&gt;&gt; UniversalTransferHistoryForMasterAccount(long timestamp, string signature, string? fromEmail, string? toEmail, string? clientTranId, long? startTime, long? endTime, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- `fromEmail` and `toEmail` cannot be sent at the same time.
- Return `fromEmail` equal master account email by default.
- The query time period must be less then 30 days.
- If startTime and endTime not sent, return records of the last 30 days by default.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.UniversalTransferHistoryForMasterAccount(timestamp,
        signature,
        fromEmail,
        toEmail,
        clientTranId,
        startTime,
        endTime,
        page,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountUniversalTransferResponse>
}
catch (SdkException<UniversalTransferHistoryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>fromEmail</code> | <code>string?</code> | Sub-account email |
| <code>toEmail</code> | <code>string?</code> | Sub-account email |
| <code>clientTranId</code> | <code>string?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>page</code> | <code>int?</code> | Default 1 |
| <code>limit</code> | <code>int?</code> | Default 500, Max 500 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountUniversalTransferResponse](Models/SapiV1SubAccountUniversalTransferResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UniversalTransferHistoryForMasterAccountError](Errors/UniversalTransferHistoryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2SubAccountSubAccountApiIpRestrictionResponse&gt; UpdateIpRestrictionForSubAccountApiKeyForMasterAccount(string email, string subAccountApiKey, string status, long timestamp, string signature, string? thirdPartyName, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update IP Restriction for Sub-Account API key

Weight(UID): 3000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.UpdateIpRestrictionForSubAccountApiKeyForMasterAccount(email,
        subAccountApiKey,
        status,
        timestamp,
        signature,
        thirdPartyName,
        recvWindow);
    // TODO: Handle 'response' of type SapiV2SubAccountSubAccountApiIpRestrictionResponse
}
catch (SdkException<UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | Sub-account email |
| <code>subAccountApiKey</code> | <code>string</code> | - |
| <code>status</code> | <code>string</code> | IP Restriction status. 1 = IP Unrestricted. 2 = Restrict access to trusted IPs only. 3 = Restrict access to users' trusted third party IPs only |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>thirdPartyName</code> | <code>string?</code> | third party IP list name |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountSubAccountApiIpRestrictionResponse](Models/SapiV2SubAccountSubAccountApiIpRestrictionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError](Errors/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountWithdrawResponse&gt; WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount(string fromEmail, string asset, double amount, long timestamp, string signature, long? transferDate, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubAccountApi.WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount(fromEmail,
        asset,
        amount,
        timestamp,
        signature,
        transferDate,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountWithdrawResponse
}
catch (SdkException<WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>fromEmail</code> | <code>string</code> | Sender email |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>transferDate</code> | <code>long?</code> | Withdrawals is automatically occur on the transfer date(UTC0). If a date is not selected, the withdrawal occurs right now |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountWithdrawResponse](Models/SapiV1ManagedSubaccountWithdrawResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError](Errors/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TradeApi

> Source: [TradeApi](Api/TradeApi.cs)

<details>
<summary><code>Task&lt;Account&gt; AccountInformationUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get current account information.

Weight(IP): 20

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.AccountInformationUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type Account
}
catch (SdkException<AccountInformationUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Account](Models/Account.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AccountInformationUserDataError](Errors/AccountInformationUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;MyTrade&gt;&gt; AccountTradeListUserData(string symbol, long timestamp, string signature, long? orderId, long? startTime, long? endTime, long? fromId, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get trades for a specific account and symbol.

If `fromId` is set, it will get id >= that `fromId`. Otherwise most recent orders are returned.

The time between startTime and endTime can't be longer than 24 hours.
These are the supported combinations of all parameters:

  symbol

  symbol + orderId

  symbol + startTime

  symbol + endTime

  symbol + fromId

  symbol + startTime + endTime

  symbol+ orderId + fromId

Weight(IP): 20

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.AccountTradeListUserData(symbol,
        timestamp,
        signature,
        orderId,
        startTime,
        endTime,
        fromId,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<MyTrade>
}
catch (SdkException<AccountTradeListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | This can only be used in combination with symbol. |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>fromId</code> | <code>long?</code> | Trade id to fetch from. Default gets most recent trades. |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MyTrade](Models/MyTrade.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AccountTradeListUserDataError](Errors/AccountTradeListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;OrderDetails&gt;&gt; AllOrdersUserData(string symbol, long timestamp, string signature, long? orderId, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all account orders; active, canceled, or filled..

- If `orderId` is set, it will get orders >= that `orderId`. Otherwise most recent orders are returned.
- For some historical orders `cummulativeQuoteQty` will be < 0, meaning the data is not available at this time.
- If `startTime` and/or `endTime` provided, `orderId` is not required

Weight(IP): 20

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.AllOrdersUserData(symbol,
        timestamp,
        signature,
        orderId,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<OrderDetails>
}
catch (SdkException<AllOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[OrderDetails](Models/OrderDetails.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AllOrdersUserDataError](Errors/AllOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OcoOrder&gt; CancelOcoTrade(string symbol, long timestamp, string signature, long? orderListId, string? listClientOrderId, string? newClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel an entire Order List

Canceling an individual leg will cancel the entire OCO

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.CancelOcoTrade(symbol,
        timestamp,
        signature,
        orderListId,
        listClientOrderId,
        newClientOrderId,
        recvWindow);
    // TODO: Handle 'response' of type OcoOrder
}
catch (SdkException<CancelOcoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderListId</code> | <code>long?</code> | Order list id |
| <code>listClientOrderId</code> | <code>string?</code> | A unique Id for the entire orderList |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OcoOrder](Models/OcoOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelOcoTradeError](Errors/CancelOcoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; CancelOrderTrade(string symbol, long timestamp, string signature, long? orderId, string? origClientOrderId, string? newClientOrderId, CancelRestrictions? cancelRestrictions, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel an active order.

Either `orderId` or `origClientOrderId` must be sent.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.CancelOrderTrade(symbol,
        timestamp,
        signature,
        orderId,
        origClientOrderId,
        newClientOrderId,
        cancelRestrictions,
        recvWindow);
    // TODO: Handle 'response' of type Order
}
catch (SdkException<CancelOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>origClientOrderId</code> | <code>string?</code> | Order id from client |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>cancelRestrictions</code> | <code>[CancelRestrictions?](Models/Enums/CancelRestrictions.cs)</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelOrderTradeError](Errors/CancelOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3OpenOrdersResponse&gt;&gt; CancelAllOpenOrdersOnASymbolTrade(string symbol, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels all active orders on a symbol.
This includes OCO orders.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.CancelAllOpenOrdersOnASymbolTrade(symbol, timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3OpenOrdersResponse>
}
catch (SdkException<CancelAllOpenOrdersOnASymbolTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3OpenOrdersResponse](Models/AnyOf/ApiV3OpenOrdersResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelAllOpenOrdersOnASymbolTradeError](Errors/CancelAllOpenOrdersOnASymbolTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderCancelReplaceResponse&gt; CancelAnExistingOrderAndSendANewOrderTrade(string symbol, Side side, Type1 type, string cancelReplaceMode, long timestamp, string signature, CancelRestrictions? cancelRestrictions, TimeInForce? timeInForce, double? quantity, double? quoteOrderQty, double? price, string? cancelNewClientOrderId, string? cancelOrigClientOrderId, long? cancelOrderId, string? newClientOrderId, long? strategyId, long? strategyType, double? stopPrice, double? trailingDelta, double? icebergQty, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an existing order and places a new order on the same symbol.

Filters and Order Count are evaluated before the processing of the cancellation and order placement occurs.

A new order that was not attempted (i.e. when newOrderResult: NOT_ATTEMPTED), will still increase the order count by 1.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.CancelAnExistingOrderAndSendANewOrderTrade(symbol,
        side,
        type,
        cancelReplaceMode,
        timestamp,
        signature,
        cancelRestrictions,
        timeInForce,
        quantity,
        quoteOrderQty,
        price,
        cancelNewClientOrderId,
        cancelOrigClientOrderId,
        cancelOrderId,
        newClientOrderId,
        strategyId,
        strategyType,
        stopPrice,
        trailingDelta,
        icebergQty,
        newOrderRespType,
        selfTradePreventionMode,
        recvWindow);
    // TODO: Handle 'response' of type ApiV3OrderCancelReplaceResponse
}
catch (SdkException<CancelAnExistingOrderAndSendANewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>type</code> | <code>[Type1](Models/Enums/Type1.cs)</code> | Order type |
| <code>cancelReplaceMode</code> | <code>string</code> | - `STOP_ON_FAILURE` If the cancel request fails, the new order placement will not be attempted.<br>- `ALLOW_FAILURES` If new order placement will be attempted even if cancel request fails. |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>cancelRestrictions</code> | <code>[CancelRestrictions?](Models/Enums/CancelRestrictions.cs)</code> | - |
| <code>timeInForce</code> | <code>[TimeInForce?](Models/Enums/TimeInForce.cs)</code> | Order time in force |
| <code>quantity</code> | <code>double?</code> | Order quantity |
| <code>quoteOrderQty</code> | <code>double?</code> | Quote quantity |
| <code>price</code> | <code>double?</code> | Order price |
| <code>cancelNewClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>cancelOrigClientOrderId</code> | <code>string?</code> | Either the cancelOrigClientOrderId or cancelOrderId must be provided. If both are provided, cancelOrderId takes precedence. |
| <code>cancelOrderId</code> | <code>long?</code> | Either the cancelOrigClientOrderId or cancelOrderId must be provided. If both are provided, cancelOrderId takes precedence. |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>strategyId</code> | <code>long?</code> | - |
| <code>strategyType</code> | <code>long?</code> | The value cannot be less than 1000000. |
| <code>stopPrice</code> | <code>double?</code> | Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders. |
| <code>trailingDelta</code> | <code>double?</code> | Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders. |
| <code>icebergQty</code> | <code>double?</code> | Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK. |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderCancelReplaceResponse](Models/ApiV3OrderCancelReplaceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelAnExistingOrderAndSendANewOrderTradeError](Errors/CancelAnExistingOrderAndSendANewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;OrderDetails&gt;&gt; CurrentOpenOrdersUserData(long timestamp, string signature, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all open orders on a symbol. Careful when accessing this with no symbol.

Weight(IP):
- `6` for a single symbol;
- `80` when the symbol parameter is omitted;

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.CurrentOpenOrdersUserData(timestamp, signature, symbol, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<OrderDetails>
}
catch (SdkException<CurrentOpenOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[OrderDetails](Models/OrderDetails.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CurrentOpenOrdersUserDataError](Errors/CurrentOpenOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderResponse&gt; NewOrderTrade(string symbol, Side side, Type1 type, long timestamp, string signature, TimeInForce? timeInForce, double? quantity, double? quoteOrderQty, double? price, string? newClientOrderId, long? strategyId, long? strategyType, double? stopPrice, double? trailingDelta, double? icebergQty, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Send in a new order.

- `LIMIT_MAKER` are `LIMIT` orders that will be rejected if they would immediately match and trade as a taker.
- `STOP_LOSS` and `TAKE_PROFIT` will execute a `MARKET` order when the `stopPrice` is reached.
- Any `LIMIT` or `LIMIT_MAKER` type order can be made an iceberg order by sending an `icebergQty`.
- Any order with an `icebergQty` MUST have `timeInForce` set to `GTC`.
- `MARKET` orders using `quantity` specifies how much a user wants to buy or sell based on the market price.
- `MARKET` orders using `quoteOrderQty` specifies the amount the user wants to spend (when buying) or receive (when selling) of the quote asset; the correct quantity will be determined based on the market liquidity and `quoteOrderQty`.
- `MARKET` orders using `quoteOrderQty` will not break `LOT_SIZE` filter rules; the order will execute a quantity that will have the notional value as close as possible to `quoteOrderQty`.
- same `newClientOrderId` can be accepted only when the previous one is filled, otherwise the order will be rejected.

Trigger order price rules against market price for both `MARKET` and `LIMIT` versions:

- Price above market price: `STOP_LOSS` `BUY`, `TAKE_PROFIT` `SELL`
- Price below market price: `STOP_LOSS` `SELL`, `TAKE_PROFIT` `BUY`


Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.NewOrderTrade(symbol,
        side,
        type,
        timestamp,
        signature,
        timeInForce,
        quantity,
        quoteOrderQty,
        price,
        newClientOrderId,
        strategyId,
        strategyType,
        stopPrice,
        trailingDelta,
        icebergQty,
        newOrderRespType,
        selfTradePreventionMode,
        recvWindow);
    // TODO: Handle 'response' of type ApiV3OrderResponse
}
catch (SdkException<NewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>type</code> | <code>[Type1](Models/Enums/Type1.cs)</code> | Order type |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>timeInForce</code> | <code>[TimeInForce?](Models/Enums/TimeInForce.cs)</code> | Order time in force |
| <code>quantity</code> | <code>double?</code> | Order quantity |
| <code>quoteOrderQty</code> | <code>double?</code> | Quote quantity |
| <code>price</code> | <code>double?</code> | Order price |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>strategyId</code> | <code>long?</code> | - |
| <code>strategyType</code> | <code>long?</code> | The value cannot be less than 1000000. |
| <code>stopPrice</code> | <code>double?</code> | Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders. |
| <code>trailingDelta</code> | <code>double?</code> | Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders. |
| <code>icebergQty</code> | <code>double?</code> | Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK. |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderResponse](Models/AnyOf/ApiV3OrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[NewOrderTradeError](Errors/NewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderListOtoResponse&gt; NewOrderListOtoTrade(string symbol, WorkingType workingType, WorkingSide workingSide, double workingPrice, double workingQuantity, double workingIcebergQty, PendingType pendingType, PendingSide pendingSide, double pendingQuantity, long timestamp, string signature, string? listClientOrderId, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, string? workingClientOrderId, WorkingTimeInForce? workingTimeInForce, double? workingStrategyId, long? workingStrategyType, string? pendingClientOrderId, double? pendingPrice, double? pendingStopPrice, double? pendingTrailingDelta, double? pendingIcebergQty, PendingTimeInForce? pendingTimeInForce, double? pendingStrategyId, long? pendingStrategyType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Places an `OTO`.
- An `OTO` (One-Triggers-the-Other) is an order list comprised of 2 orders.
- The first order is called the working order and must be `LIMIT` or `LIMIT_MAKER`. Initially, only the working order goes on the order book.
- The second order is called the pending order. It can be any order type except for `MARKET` orders using parameter `quoteOrderQty`. The pending order is only placed on the order book when the working order gets fully filled.
- If either the working order or the pending order is cancelled individually, the other order in the order list will also be canceled or expired.
- When the order list is placed, if the working order gets immediately fully filled, the placement response will show the working order as `FILLED` but the pending order will still appear as `PENDING_NEW`. You need to query the status of the pending order again to see its updated status.
- OTOs add 2 orders to the unfilled order count, `EXCHANGE_MAX_NUM_ORDERS` filter and `MAX_NUM_ORDERS` filter.

Weight: 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.NewOrderListOtoTrade(symbol,
        workingType,
        workingSide,
        workingPrice,
        workingQuantity,
        workingIcebergQty,
        pendingType,
        pendingSide,
        pendingQuantity,
        timestamp,
        signature,
        listClientOrderId,
        newOrderRespType,
        selfTradePreventionMode,
        workingClientOrderId,
        workingTimeInForce,
        workingStrategyId,
        workingStrategyType,
        pendingClientOrderId,
        pendingPrice,
        pendingStopPrice,
        pendingTrailingDelta,
        pendingIcebergQty,
        pendingTimeInForce,
        pendingStrategyId,
        pendingStrategyType);
    // TODO: Handle 'response' of type ApiV3OrderListOtoResponse
}
catch (SdkException<NewOrderListOtoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>workingType</code> | <code>[WorkingType](Models/Enums/WorkingType.cs)</code> | Supported values: LIMIT,LIMIT_MAKER |
| <code>workingSide</code> | <code>[WorkingSide](Models/Enums/WorkingSide.cs)</code> | BUY,SELL |
| <code>workingPrice</code> | <code>double</code> | - |
| <code>workingQuantity</code> | <code>double</code> | Sets the quantity for the working order. |
| <code>workingIcebergQty</code> | <code>double</code> | This can only be used if workingTimeInForce is GTC. |
| <code>pendingType</code> | <code>[PendingType](Models/Enums/PendingType.cs)</code> | Supported values: Order Types Note that MARKET orders using quoteOrderQty are not supported. |
| <code>pendingSide</code> | <code>[PendingSide](Models/Enums/PendingSide.cs)</code> | BUY,SELL |
| <code>pendingQuantity</code> | <code>double</code> | Sets the quantity for the pending order. |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>listClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open order lists. Automatically generated if not sent.<br>A new order list with the same `listClientOrderId` is accepted only when the previous one is filled or completely expired.<br>`listClientOrderId` is distinct from the `workingClientOrderId` and the `pendingClientOrderId`. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>workingClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the working order. Automatically generated if not sent. |
| <code>workingTimeInForce</code> | <code>[WorkingTimeInForce?](Models/Enums/WorkingTimeInForce.cs)</code> | GTC, IOC, FOK |
| <code>workingStrategyId</code> | <code>double?</code> | Arbitrary numeric value identifying the working order within an order strategy. |
| <code>workingStrategyType</code> | <code>long?</code> | Arbitrary numeric value identifying the working order strategy.<br>Values smaller than 1000000 are reserved and cannot be used. |
| <code>pendingClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the pending order. Automatically generated if not sent. |
| <code>pendingPrice</code> | <code>double?</code> | - |
| <code>pendingStopPrice</code> | <code>double?</code> | - |
| <code>pendingTrailingDelta</code> | <code>double?</code> | - |
| <code>pendingIcebergQty</code> | <code>double?</code> | This can only be used if pendingTimeInForce is GTC. |
| <code>pendingTimeInForce</code> | <code>[PendingTimeInForce?](Models/Enums/PendingTimeInForce.cs)</code> | GTC, IOC, FOK |
| <code>pendingStrategyId</code> | <code>double?</code> | Arbitrary numeric value identifying the pending order within an order strategy. |
| <code>pendingStrategyType</code> | <code>long?</code> | Arbitrary numeric value identifying the pending order strategy.<br>Values smaller than 1000000 are reserved and cannot be used. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListOtoResponse](Models/ApiV3OrderListOtoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[NewOrderListOtoTradeError](Errors/NewOrderListOtoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderListOtocoResponse&gt; NewOrderListOtocoTrade(string symbol, WorkingType workingType, WorkingSide workingSide, double workingPrice, double workingQuantity, double workingIcebergQty, PendingSide pendingSide, double pendingQuantity, PendingAboveType pendingAboveType, long timestamp, string signature, string? listClientOrderId, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, string? workingClientOrderId, WorkingTimeInForce? workingTimeInForce, double? workingStrategyId, long? workingStrategyType, string? pendingAboveClientOrderId, double? pendingAbovePrice, double? pendingAboveStopPrice, double? pendingAboveTrailingDelta, double? pendingAboveIcebergQty, PendingAboveTimeInForce? pendingAboveTimeInForce, double? pendingAboveStrategyId, long? pendingAboveStrategyType, PendingBelowType? pendingBelowType, string? pendingBelowClientOrderId, double? pendingBelowPrice, double? pendingBelowStopPrice, double? pendingBelowTrailingDelta, double? pendingBelowIcebergQty, PendingBelowTimeInForce? pendingBelowTimeInForce, double? pendingBelowStrategyId, long? pendingBelowStrategyType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Place an `OTOCO`.
- An `OTOCO` (One-Triggers-One-Cancels-the-Other) is an order list comprised of 3 orders.
- The first order is called the working order and must be `LIMIT` or `LIMIT_MAKER`. Initially, only the working order goes on the order book.
  - The behavior of the working order is the same as the `OTO`.
- `OTOCO` has 2 pending orders (pending above and pending below), forming an `OCO` pair. The pending orders are only placed on the order book when the working order gets fully filled.
  - The rules of the pending above and pending below follow the same rules as the Order List `OCO`.
- OTOCOs add 3 orders against the unfilled order count, `EXCHANGE_MAX_NUM_ORDERS` filter, and `MAX_NUM_ORDERS` filter.

Weight: 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.NewOrderListOtocoTrade(symbol,
        workingType,
        workingSide,
        workingPrice,
        workingQuantity,
        workingIcebergQty,
        pendingSide,
        pendingQuantity,
        pendingAboveType,
        timestamp,
        signature,
        listClientOrderId,
        newOrderRespType,
        selfTradePreventionMode,
        workingClientOrderId,
        workingTimeInForce,
        workingStrategyId,
        workingStrategyType,
        pendingAboveClientOrderId,
        pendingAbovePrice,
        pendingAboveStopPrice,
        pendingAboveTrailingDelta,
        pendingAboveIcebergQty,
        pendingAboveTimeInForce,
        pendingAboveStrategyId,
        pendingAboveStrategyType,
        pendingBelowType,
        pendingBelowClientOrderId,
        pendingBelowPrice,
        pendingBelowStopPrice,
        pendingBelowTrailingDelta,
        pendingBelowIcebergQty,
        pendingBelowTimeInForce,
        pendingBelowStrategyId,
        pendingBelowStrategyType,
        recvWindow);
    // TODO: Handle 'response' of type ApiV3OrderListOtocoResponse
}
catch (SdkException<NewOrderListOtocoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>workingType</code> | <code>[WorkingType](Models/Enums/WorkingType.cs)</code> | Supported values: LIMIT,LIMIT_MAKER |
| <code>workingSide</code> | <code>[WorkingSide](Models/Enums/WorkingSide.cs)</code> | BUY,SELL |
| <code>workingPrice</code> | <code>double</code> | - |
| <code>workingQuantity</code> | <code>double</code> | Sets the quantity for the working order. |
| <code>workingIcebergQty</code> | <code>double</code> | This can only be used if workingTimeInForce is GTC. |
| <code>pendingSide</code> | <code>[PendingSide](Models/Enums/PendingSide.cs)</code> | BUY,SELL |
| <code>pendingQuantity</code> | <code>double</code> | Sets the quantity for the pending order. |
| <code>pendingAboveType</code> | <code>[PendingAboveType](Models/Enums/PendingAboveType.cs)</code> | Supported values: LIMIT_MAKER, STOP_LOSS, and STOP_LOSS_LIMIT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>listClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open order lists. Automatically generated if not sent.<br>A new order list with the same `listClientOrderId` is accepted only when the previous one is filled or completely expired.<br>`listClientOrderId` is distinct from the `workingClientOrderId` and the `pendingClientOrderId`. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>workingClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the working order. Automatically generated if not sent. |
| <code>workingTimeInForce</code> | <code>[WorkingTimeInForce?](Models/Enums/WorkingTimeInForce.cs)</code> | GTC, IOC, FOK |
| <code>workingStrategyId</code> | <code>double?</code> | Arbitrary numeric value identifying the working order within an order strategy. |
| <code>workingStrategyType</code> | <code>long?</code> | Arbitrary numeric value identifying the working order strategy.<br>Values smaller than 1000000 are reserved and cannot be used. |
| <code>pendingAboveClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the pending above order. Automatically generated if not sent. |
| <code>pendingAbovePrice</code> | <code>double?</code> | - |
| <code>pendingAboveStopPrice</code> | <code>double?</code> | - |
| <code>pendingAboveTrailingDelta</code> | <code>double?</code> | - |
| <code>pendingAboveIcebergQty</code> | <code>double?</code> | This can only be used if pendingAboveTimeInForce is GTC. |
| <code>pendingAboveTimeInForce</code> | <code>[PendingAboveTimeInForce?](Models/Enums/PendingAboveTimeInForce.cs)</code> | - |
| <code>pendingAboveStrategyId</code> | <code>double?</code> | Arbitrary numeric value identifying the pending above order within an order strategy. |
| <code>pendingAboveStrategyType</code> | <code>long?</code> | Arbitrary numeric value identifying the pending above order strategy.<br>Values smaller than 1000000 are reserved and cannot be used. |
| <code>pendingBelowType</code> | <code>[PendingBelowType?](Models/Enums/PendingBelowType.cs)</code> | Supported values: LIMIT_MAKER, STOP_LOSS, and STOP_LOSS_LIMIT |
| <code>pendingBelowClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the pending below order. Automatically generated if not sent. |
| <code>pendingBelowPrice</code> | <code>double?</code> | - |
| <code>pendingBelowStopPrice</code> | <code>double?</code> | - |
| <code>pendingBelowTrailingDelta</code> | <code>double?</code> | - |
| <code>pendingBelowIcebergQty</code> | <code>double?</code> | This can only be used if pendingBelowTimeInForce is GTC. |
| <code>pendingBelowTimeInForce</code> | <code>[PendingBelowTimeInForce?](Models/Enums/PendingBelowTimeInForce.cs)</code> | - |
| <code>pendingBelowStrategyId</code> | <code>double?</code> | Arbitrary numeric value identifying the pending below order within an order strategy. |
| <code>pendingBelowStrategyType</code> | <code>long?</code> | Arbitrary numeric value identifying the pending below order strategy.<br>Values smaller than 1000000 are reserved and cannot be used. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListOtocoResponse](Models/ApiV3OrderListOtocoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[NewOrderListOtocoTradeError](Errors/NewOrderListOtocoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderListOcoResponse&gt; NewOrderListOcoTrade(string symbol, Side side, double quantity, string aboveType, string belowType, long timestamp, string signature, string? listClientOrderId, string? aboveClientOrderId, double? aboveIcebergQty, double? abovePrice, double? aboveStopPrice, double? aboveTrailingDelta, AboveTimeInForce? aboveTimeInForce, double? aboveStrategyId, long? aboveStrategyType, string? belowClientOrderId, double? belowIcebergQty, double? belowPrice, double? belowStopPrice, double? belowTrailingDelta, BelowTimeInForce? belowTimeInForce, double? belowStrategyId, long? belowStrategyType, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Send in an one-cancels-the-other (OCO) pair, where activation of one order immediately cancels the other.

- An `OCO` has 2 orders called the above order and below order.
- One of the orders must be a `LIMIT_MAKER` order and the other must be `STOP_LOSS` or`STOP_LOSS_LIMIT` order.
- Price restrictions:
    - If the `OCO` is on the `SELL` side: `LIMIT_MAKER` price > Last Traded Price > stopPrice
    - If the `OCO` is on the `BUY` side: `LIMIT_MAKER` price < Last Traded Price < stopPrice
- OCOs add 2 orders to the unfilled order count, `EXCHANGE_MAX_ORDERS` filter, and the `MAX_NUM_ORDERS` filter.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.NewOrderListOcoTrade(symbol,
        side,
        quantity,
        aboveType,
        belowType,
        timestamp,
        signature,
        listClientOrderId,
        aboveClientOrderId,
        aboveIcebergQty,
        abovePrice,
        aboveStopPrice,
        aboveTrailingDelta,
        aboveTimeInForce,
        aboveStrategyId,
        aboveStrategyType,
        belowClientOrderId,
        belowIcebergQty,
        belowPrice,
        belowStopPrice,
        belowTrailingDelta,
        belowTimeInForce,
        belowStrategyId,
        belowStrategyType,
        newOrderRespType,
        selfTradePreventionMode,
        recvWindow);
    // TODO: Handle 'response' of type ApiV3OrderListOcoResponse
}
catch (SdkException<NewOrderListOcoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>quantity</code> | <code>double</code> | - |
| <code>aboveType</code> | <code>string</code> | Supported values : `STOP_LOSS_LIMIT`, `STOP_LOSS`, `LIMIT_MAKER` |
| <code>belowType</code> | <code>string</code> | Supported values : `STOP_LOSS_LIMIT`, `STOP_LOSS`, `LIMIT_MAKER` |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>listClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open order lists. Automatically generated if not sent.<br>A new order list with the same `listClientOrderId` is accepted only when the previous one is filled or completely expired.<br>`listClientOrderId` is distinct from the `aboveClientOrderId` and the `belowCLientOrderId`. |
| <code>aboveClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the above order. Automatically generated if not sent |
| <code>aboveIcebergQty</code> | <code>double?</code> | Note that this can only be used if `aboveTimeInForce` is `GTC`. |
| <code>abovePrice</code> | <code>double?</code> | - |
| <code>aboveStopPrice</code> | <code>double?</code> | Can be used if `aboveType` is `STOP_LOSS` or `STOP_LOSS_LIMIT`.<br>Either `aboveStopPrice` or `aboveTrailingDelta` or both, must be specified. |
| <code>aboveTrailingDelta</code> | <code>double?</code> | - |
| <code>aboveTimeInForce</code> | <code>[AboveTimeInForce?](Models/Enums/AboveTimeInForce.cs)</code> | Required if the `aboveType` is `STOP_LOSS_LIMIT`. |
| <code>aboveStrategyId</code> | <code>double?</code> | Arbitrary numeric value identifying the above order within an order strategy. |
| <code>aboveStrategyType</code> | <code>long?</code> | Arbitrary numeric value identifying the above order strategy.<br>Values smaller than 1000000 are reserved and cannot be used. |
| <code>belowClientOrderId</code> | <code>string?</code> | Arbitrary unique ID among open orders for the below order. Automatically generated if not sent |
| <code>belowIcebergQty</code> | <code>double?</code> | Note that this can only be used if `belowTimeInForce` is `GTC`. |
| <code>belowPrice</code> | <code>double?</code> | Can be used if `belowType` is `STOP_LOSS_LIMIT` or `LIMIT_MAKER` to specify the limit price. |
| <code>belowStopPrice</code> | <code>double?</code> | Can be used if `belowType` is `STOP_LOSS` or `STOP_LOSS_LIMIT`.<br>Either `belowStopPrice` or `belowTrailingDelta` or both, must be specified. |
| <code>belowTrailingDelta</code> | <code>double?</code> | - |
| <code>belowTimeInForce</code> | <code>[BelowTimeInForce?](Models/Enums/BelowTimeInForce.cs)</code> | Required if the `belowType` is `STOP_LOSS_LIMIT`. |
| <code>belowStrategyId</code> | <code>double?</code> | Arbitrary numeric value identifying the below order within an order strategy. |
| <code>belowStrategyType</code> | <code>long?</code> | Arbitrary numeric value identifying the below order strategy.<br>Values smaller than 1000000 are reserved and cannot be used. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK. |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListOcoResponse](Models/ApiV3OrderListOcoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[NewOrderListOcoTradeError](Errors/NewOrderListOcoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3SorOrderResponse&gt; NewOrderUsingSorTrade(string symbol, Side side, Type1 type, double quantity, long timestamp, string signature, TimeInForce? timeInForce, double? price, string? newClientOrderId, long? strategyId, long? strategyType, double? icebergQty, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 6

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.NewOrderUsingSorTrade(symbol,
        side,
        type,
        quantity,
        timestamp,
        signature,
        timeInForce,
        price,
        newClientOrderId,
        strategyId,
        strategyType,
        icebergQty,
        newOrderRespType,
        selfTradePreventionMode,
        recvWindow);
    // TODO: Handle 'response' of type ApiV3SorOrderResponse
}
catch (SdkException<NewOrderUsingSorTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>type</code> | <code>[Type1](Models/Enums/Type1.cs)</code> | Order type |
| <code>quantity</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>timeInForce</code> | <code>[TimeInForce?](Models/Enums/TimeInForce.cs)</code> | Order time in force |
| <code>price</code> | <code>double?</code> | - |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>strategyId</code> | <code>long?</code> | - |
| <code>strategyType</code> | <code>long?</code> | The value cannot be less than 1000000. |
| <code>icebergQty</code> | <code>double?</code> | Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK. |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3SorOrderResponse](Models/ApiV3SorOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[NewOrderUsingSorTradeError](Errors/NewOrderUsingSorTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3MyAllocationsResponse&gt;&gt; QueryAllocationsUserData(string symbol, long timestamp, string signature, long? startTime, long? endTime, long? fromAllocationId, int? limit, long? orderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves allocations resulting from SOR order placement.

Weight: 20

Supported parameter combinations:
Parameters                               Response
symbol                                   allocations from oldest to newest
symbol + startTime                       oldest allocations since startTime
symbol + endTime                         newest allocations until endTime
symbol + startTime + endTime             allocations within the time range
symbol + fromAllocationId               allocations by allocation ID
symbol + orderId                         allocations related to an order starting with oldest
symbol + orderId + fromAllocationId     allocations related to an order by allocation ID

Note: The time between startTime and endTime can't be longer than 24 hours.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.QueryAllocationsUserData(symbol,
        timestamp,
        signature,
        startTime,
        endTime,
        fromAllocationId,
        limit,
        orderId,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3MyAllocationsResponse>
}
catch (SdkException<QueryAllocationsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>fromAllocationId</code> | <code>long?</code> | - |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3MyAllocationsResponse](Models/ApiV3MyAllocationsResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryAllocationsUserDataError](Errors/QueryAllocationsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3AccountCommissionResponse&gt; QueryCommissionRatesUserData(string symbol, long timestamp, string signature, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get current account commission rates.

Weight: 20

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.QueryCommissionRatesUserData(symbol, timestamp, signature);
    // TODO: Handle 'response' of type ApiV3AccountCommissionResponse
}
catch (SdkException<QueryCommissionRatesUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3AccountCommissionResponse](Models/ApiV3AccountCommissionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryCommissionRatesUserDataError](Errors/QueryCommissionRatesUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3RateLimitOrderResponse&gt;&gt; QueryCurrentOrderCountUsageTrade(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Displays the user's current order count usage for all intervals.

Weight(IP): 40

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.QueryCurrentOrderCountUsageTrade(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3RateLimitOrderResponse>
}
catch (SdkException<QueryCurrentOrderCountUsageTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3RateLimitOrderResponse](Models/ApiV3RateLimitOrderResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryCurrentOrderCountUsageTradeError](Errors/QueryCurrentOrderCountUsageTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderListResponse&gt; QueryOcoUserData(long timestamp, string signature, long? orderListId, string? origClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific OCO based on provided optional parameters

Weight(IP): 4

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.QueryOcoUserData(timestamp,
        signature,
        orderListId,
        origClientOrderId,
        recvWindow);
    // TODO: Handle 'response' of type ApiV3OrderListResponse
}
catch (SdkException<QueryOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderListId</code> | <code>long?</code> | Order list id |
| <code>origClientOrderId</code> | <code>string?</code> | Order id from client |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListResponse](Models/ApiV3OrderListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryOcoUserDataError](Errors/QueryOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3OpenOrderListResponse&gt;&gt; QueryOpenOcoUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 6

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.QueryOpenOcoUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3OpenOrderListResponse>
}
catch (SdkException<QueryOpenOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3OpenOrderListResponse](Models/ApiV3OpenOrderListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryOpenOcoUserDataError](Errors/QueryOpenOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrderDetails&gt; QueryOrderUserData(string symbol, long timestamp, string signature, long? orderId, string? origClientOrderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Check an order's status.

- Either `orderId` or `origClientOrderId` must be sent.
- For some historical orders `cummulativeQuoteQty` will be < 0, meaning the data is not available at this time.

Weight(IP): 4

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.QueryOrderUserData(symbol,
        timestamp,
        signature,
        orderId,
        origClientOrderId,
        recvWindow);
    // TODO: Handle 'response' of type OrderDetails
}
catch (SdkException<QueryOrderUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>origClientOrderId</code> | <code>string?</code> | Order id from client |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrderDetails](Models/OrderDetails.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryOrderUserDataError](Errors/QueryOrderUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3MyPreventedMatchesResponse&gt;&gt; QueryPreventedMatches(string symbol, long timestamp, string signature, long? preventedMatchId, long? orderId, long? fromPreventedMatchId, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Displays the list of orders that were expired because of STP.

For additional information on what a Prevented match is, as well as Self Trade Prevention (STP), please refer to our STP FAQ page.

These are the combinations supported:

* symbol + preventedMatchId
* symbol + orderId
* symbol + orderId + fromPreventedMatchId (limit will default to 500)
* symbol + orderId + fromPreventedMatchId + limit

Weight(IP):

Case                               Weight
If symbol is invalid:             2
Querying by preventedMatchId:     2
Querying by orderId:               20

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.QueryPreventedMatches(symbol,
        timestamp,
        signature,
        preventedMatchId,
        orderId,
        fromPreventedMatchId,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3MyPreventedMatchesResponse>
}
catch (SdkException<QueryPreventedMatchesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>preventedMatchId</code> | <code>long?</code> | - |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>fromPreventedMatchId</code> | <code>long?</code> | - |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3MyPreventedMatchesResponse](Models/ApiV3MyPreventedMatchesResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryPreventedMatchesError](Errors/QueryPreventedMatchesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3AllOrderListResponse&gt;&gt; QueryAllOcoUserData(long timestamp, string signature, long? fromId, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves all OCO based on provided optional parameters

Weight(IP): 20

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.QueryAllOcoUserData(timestamp,
        signature,
        fromId,
        startTime,
        endTime,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3AllOrderListResponse>
}
catch (SdkException<QueryAllOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>fromId</code> | <code>long?</code> | Trade id to fetch from. Default gets most recent trades. |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3AllOrderListResponse](Models/ApiV3AllOrderListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryAllOcoUserDataError](Errors/QueryAllOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; TestNewOrderTrade(string symbol, Side side, Type1 type, long timestamp, string signature, TimeInForce? timeInForce, double? quantity, double? quoteOrderQty, double? price, string? newClientOrderId, long? strategyId, long? strategyType, double? stopPrice, double? trailingDelta, double? icebergQty, NewOrderRespType? newOrderRespType, long? recvWindow, bool? computeCommissionRates, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Test new order creation and signature/recvWindow long.
Creates and validates a new order but does not send it into the matching engine.

Weight(IP):
  - Without computeCommissionRates: `1`
  - With computeCommissionRates: `20`

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.TestNewOrderTrade(symbol,
        side,
        type,
        timestamp,
        signature,
        timeInForce,
        quantity,
        quoteOrderQty,
        price,
        newClientOrderId,
        strategyId,
        strategyType,
        stopPrice,
        trailingDelta,
        icebergQty,
        newOrderRespType,
        recvWindow,
        computeCommissionRates);
    // TODO: Handle 'response' of type object
}
catch (SdkException<TestNewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>type</code> | <code>[Type1](Models/Enums/Type1.cs)</code> | Order type |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>timeInForce</code> | <code>[TimeInForce?](Models/Enums/TimeInForce.cs)</code> | Order time in force |
| <code>quantity</code> | <code>double?</code> | Order quantity |
| <code>quoteOrderQty</code> | <code>double?</code> | Quote quantity |
| <code>price</code> | <code>double?</code> | Order price |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>strategyId</code> | <code>long?</code> | - |
| <code>strategyType</code> | <code>long?</code> | The value cannot be less than 1000000. |
| <code>stopPrice</code> | <code>double?</code> | Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders. |
| <code>trailingDelta</code> | <code>double?</code> | Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders. |
| <code>icebergQty</code> | <code>double?</code> | Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |
| <code>computeCommissionRates</code> | <code>bool?</code> | Default: false |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TestNewOrderTradeError](Errors/TestNewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; TestNewOrderUsingSorTrade(string symbol, Side side, Type1 type, double quantity, long timestamp, string signature, TimeInForce? timeInForce, double? price, string? newClientOrderId, long? strategyId, long? strategyType, double? icebergQty, NewOrderRespType? newOrderRespType, SelfTradePreventionMode? selfTradePreventionMode, bool? computeCommissionRates, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Test new order creation and signature/recvWindow using smart order routing (SOR).
Creates and validates a new order but does not send it into the matching engine.

Weight(IP):
  - Without computeCommissionRates: `1`
  - With computeCommissionRates: `20`

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TradeApi.TestNewOrderUsingSorTrade(symbol,
        side,
        type,
        quantity,
        timestamp,
        signature,
        timeInForce,
        price,
        newClientOrderId,
        strategyId,
        strategyType,
        icebergQty,
        newOrderRespType,
        selfTradePreventionMode,
        computeCommissionRates,
        recvWindow);
    // TODO: Handle 'response' of type object
}
catch (SdkException<TestNewOrderUsingSorTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbol</code> | <code>string</code> | Trading symbol, e.g. BNBUSDT |
| <code>side</code> | <code>[Side](Models/Enums/Side.cs)</code> | - |
| <code>type</code> | <code>[Type1](Models/Enums/Type1.cs)</code> | Order type |
| <code>quantity</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>timeInForce</code> | <code>[TimeInForce?](Models/Enums/TimeInForce.cs)</code> | Order time in force |
| <code>price</code> | <code>double?</code> | - |
| <code>newClientOrderId</code> | <code>string?</code> | Used to uniquely identify this cancel. Automatically generated by default |
| <code>strategyId</code> | <code>long?</code> | - |
| <code>strategyType</code> | <code>long?</code> | The value cannot be less than 1000000. |
| <code>icebergQty</code> | <code>double?</code> | Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order. |
| <code>newOrderRespType</code> | <code>[NewOrderRespType?](Models/Enums/NewOrderRespType.cs)</code> | Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK. |
| <code>selfTradePreventionMode</code> | <code>[SelfTradePreventionMode?](Models/Enums/SelfTradePreventionMode.cs)</code> | The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE. |
| <code>computeCommissionRates</code> | <code>bool?</code> | Default: false |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TestNewOrderUsingSorTradeError](Errors/TestNewOrderUsingSorTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VipLoans

> Source: [VipLoans](Api/VipLoans.cs)

<details>
<summary><code>Task&lt;SapiV1LoanVipCollateralAccountResponse&gt; CheckLockedValueOfVipCollateralAccountUserData(long timestamp, string signature, long? orderId, long? collateralAccountId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

VIP loan is available for VIP users only.

Weight(IP): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.CheckLockedValueOfVipCollateralAccountUserData(timestamp,
        signature,
        orderId,
        collateralAccountId,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanVipCollateralAccountResponse
}
catch (SdkException<CheckLockedValueOfVipCollateralAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>collateralAccountId</code> | <code>long?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipCollateralAccountResponse](Models/SapiV1LoanVipCollateralAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckLockedValueOfVipCollateralAccountUserDataError](Errors/CheckLockedValueOfVipCollateralAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LoanVipRequestInterestRateResponse&gt;&gt; GetBorrowInterestRateUserData(long timestamp, string signature, string? loanCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get borrow interest rate.

Weight(UID): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.GetBorrowInterestRateUserData(timestamp, signature, loanCoin, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LoanVipRequestInterestRateResponse>
}
catch (SdkException<GetBorrowInterestRateUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Max 10 assets, Multiple split by "," |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LoanVipRequestInterestRateResponse](Models/SapiV1LoanVipRequestInterestRateResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBorrowInterestRateUserDataError](Errors/GetBorrowInterestRateUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipCollateralDataResponse&gt; GetCollateralAssetDataUserData(long timestamp, string signature, string? collateralCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get collateral asset data.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.GetCollateralAssetDataUserData(timestamp,
        signature,
        collateralCoin,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanVipCollateralDataResponse
}
catch (SdkException<GetCollateralAssetDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipCollateralDataResponse](Models/SapiV1LoanVipCollateralDataResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCollateralAssetDataUserDataError](Errors/GetCollateralAssetDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipLoanableDataResponse&gt; GetLoanableAssetsData(long timestamp, string signature, string? loanCoin, int? vipLevel, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get interest rate and borrow limit of loanable assets. The borrow limit is shown in USD value.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.GetLoanableAssetsData(timestamp, signature, loanCoin, vipLevel, recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanVipLoanableDataResponse
}
catch (SdkException<GetLoanableAssetsDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>vipLevel</code> | <code>int?</code> | Defaults to user's vip level |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipLoanableDataResponse](Models/SapiV1LoanVipLoanableDataResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLoanableAssetsDataError](Errors/GetLoanableAssetsDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipOngoingOrdersResponse&gt; GetVipLoanOngoingOrdersUserData(long timestamp, string signature, long? orderId, long? collateralAccountId, string? loanCoin, string? collateralCoin, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

VIP loan is available for VIP users only.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.GetVipLoanOngoingOrdersUserData(timestamp,
        signature,
        orderId,
        collateralAccountId,
        loanCoin,
        collateralCoin,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanVipOngoingOrdersResponse
}
catch (SdkException<GetVipLoanOngoingOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>collateralAccountId</code> | <code>long?</code> | - |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>collateralCoin</code> | <code>string?</code> | Coin used as collateral |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>int?</code> | Default 10; max 100. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipOngoingOrdersResponse](Models/SapiV1LoanVipOngoingOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVipLoanOngoingOrdersUserDataError](Errors/GetVipLoanOngoingOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipRepayHistoryResponse&gt; GetVipLoanRepaymentHistoryUserData(long timestamp, string signature, long? orderId, string? loanCoin, long? startTime, long? endTime, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

VIP loan is available for VIP users only.

Weight(IP): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.GetVipLoanRepaymentHistoryUserData(timestamp,
        signature,
        orderId,
        loanCoin,
        startTime,
        endTime,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanVipRepayHistoryResponse
}
catch (SdkException<GetVipLoanRepaymentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>int?</code> | Default 10; max 100. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRepayHistoryResponse](Models/SapiV1LoanVipRepayHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVipLoanRepaymentHistoryUserDataError](Errors/GetVipLoanRepaymentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipRequestDataResponse&gt; QueryApplicationStatusUserData(long timestamp, string signature, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Application Status

Weight(UID): 400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.QueryApplicationStatusUserData(timestamp,
        signature,
        current,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanVipRequestDataResponse
}
catch (SdkException<QueryApplicationStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRequestDataResponse](Models/SapiV1LoanVipRequestDataResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryApplicationStatusUserDataError](Errors/QueryApplicationStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipBorrowResponse&gt; VipLoanBorrow(long loanAccountId, double loanAmount, string collateralAccountId, string collateralCoin, IsFlexibleRate isFlexibleRate, long timestamp, string signature, string? loanCoin, int? loanTerm, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

VIP loan is available for VIP users only.

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.VipLoanBorrow(loanAccountId,
        loanAmount,
        collateralAccountId,
        collateralCoin,
        isFlexibleRate,
        timestamp,
        signature,
        loanCoin,
        loanTerm,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanVipBorrowResponse
}
catch (SdkException<VipLoanBorrowError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>loanAccountId</code> | <code>long</code> | - |
| <code>loanAmount</code> | <code>double</code> | - |
| <code>collateralAccountId</code> | <code>string</code> | - |
| <code>collateralCoin</code> | <code>string</code> | - |
| <code>isFlexibleRate</code> | <code>[IsFlexibleRate](Models/Enums/IsFlexibleRate.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>loanCoin</code> | <code>string?</code> | Coin loaned |
| <code>loanTerm</code> | <code>int?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipBorrowResponse](Models/SapiV1LoanVipBorrowResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VipLoanBorrowError](Errors/VipLoanBorrowError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipRenewResponse&gt; VipLoanRenew(long timestamp, string signature, long? orderId, int? loanTerm, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

VIP loan is available for VIP users only.

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.VipLoanRenew(timestamp, signature, orderId, loanTerm, recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanVipRenewResponse
}
catch (SdkException<VipLoanRenewError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>loanTerm</code> | <code>int?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRenewResponse](Models/SapiV1LoanVipRenewResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VipLoanRenewError](Errors/VipLoanRenewError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipRepayResponse&gt; VipLoanRepayTrade(double amount, long timestamp, string signature, long? orderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

VIP loan is available for VIP users only.

Weight(UID): 6000

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VipLoans.VipLoanRepayTrade(amount, timestamp, signature, orderId, recvWindow);
    // TODO: Handle 'response' of type SapiV1LoanVipRepayResponse
}
catch (SdkException<VipLoanRepayTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>orderId</code> | <code>long?</code> | Order id |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRepayResponse](Models/SapiV1LoanVipRepayResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VipLoanRepayTradeError](Errors/VipLoanRepayTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Wallet

> Source: [Wallet](Api/Wallet.cs)

<details>
<summary><code>Task&lt;SapiV1AccountApiTradingStatusResponse&gt; AccountApiTradingStatusUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch account API trading status with details.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.AccountApiTradingStatusUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1AccountApiTradingStatusResponse
}
catch (SdkException<AccountApiTradingStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountApiTradingStatusResponse](Models/SapiV1AccountApiTradingStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AccountApiTradingStatusUserDataError](Errors/AccountApiTradingStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AccountStatusResponse&gt; AccountStatusUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch account status detail.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.AccountStatusUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1AccountStatusResponse
}
catch (SdkException<AccountStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountStatusResponse](Models/SapiV1AccountStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AccountStatusUserDataError](Errors/AccountStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AccountInfoResponse&gt; AccountInfoUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch account info detail.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.AccountInfoUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1AccountInfoResponse
}
catch (SdkException<AccountInfoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountInfoResponse](Models/SapiV1AccountInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AccountInfoUserDataError](Errors/AccountInfoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalConfigGetallResponse&gt;&gt; AllCoinsInformationUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get information of coins (available for deposit and withdraw) for user.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.AllCoinsInformationUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalConfigGetallResponse>
}
catch (SdkException<AllCoinsInformationUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalConfigGetallResponse](Models/SapiV1CapitalConfigGetallResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AllCoinsInformationUserDataError](Errors/AllCoinsInformationUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetAssetDetailResponse&gt; AssetDetailUserData(long timestamp, string signature, string? asset, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch details of assets supported on Binance.

- Please get network and other deposit or withdraw details from `GET /sapi/v1/capital/config/getall`.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.AssetDetailUserData(timestamp, signature, asset, recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetAssetDetailResponse
}
catch (SdkException<AssetDetailUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetAssetDetailResponse](Models/SapiV1AssetAssetDetailResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AssetDetailUserDataError](Errors/AssetDetailUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetAssetDividendResponse&gt; AssetDividendRecordUserData(long timestamp, string signature, string? asset, long? startTime, long? endTime, long? recvWindow, int? limit = 20, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query asset Dividend Record

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.AssetDividendRecordUserData(timestamp,
        signature,
        asset,
        startTime,
        endTime,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetAssetDividendResponse
}
catch (SdkException<AssetDividendRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |
| <code>limit</code> | <code>int?</code> | **Default**: 20 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetAssetDividendResponse](Models/SapiV1AssetAssetDividendResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AssetDividendRecordUserDataError](Errors/AssetDividendRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetConvertTransferResponse&gt; ConvertTransferUserData(string clientTranId, string asset, double amount, string targetAsset, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Convert transfer, convert between BUSD and stablecoins.
If the clientId has been used before, will not do the convert transfer, the original transfer will be returned.

Weight(UID): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.ConvertTransferUserData(clientTranId,
        asset,
        amount,
        targetAsset,
        timestamp,
        signature,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetConvertTransferResponse
}
catch (SdkException<ConvertTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>clientTranId</code> | <code>string</code> | The unique flag, the min length is 20 |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>targetAsset</code> | <code>string</code> | Target asset you want to convert |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetConvertTransferResponse](Models/SapiV1AssetConvertTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ConvertTransferUserDataError](Errors/ConvertTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AccountSnapshotResponse&gt; DailyAccountSnapshotUserData(Type6 type, long timestamp, string signature, long? startTime, long? endTime, long? recvWindow, int? limit = 7, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- The query time period must be less than 30 days
- Support query within the last one month only
- If startTimeand endTime not sent, return records of the last 7 days by default

Weight(IP): 2400

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.DailyAccountSnapshotUserData(type,
        timestamp,
        signature,
        startTime,
        endTime,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AccountSnapshotResponse
}
catch (SdkException<DailyAccountSnapshotUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>[Type6](Models/Enums/Type6.cs)</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |
| <code>limit</code> | <code>int?</code> | **Default**: 7 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountSnapshotResponse](Models/AnyOf/SapiV1AccountSnapshotResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DailyAccountSnapshotUserDataError](Errors/DailyAccountSnapshotUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalDepositAddressResponse&gt; DepositAddressSupportingNetworkUserData(string coin, long timestamp, string signature, string? network, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch deposit address with network.

- If network is not send, return with default network of the coin.
- You can get network and isDefault in networkList in the response of Get /sapi/v1/capital/config/getall (HMAC SHA256).

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.DepositAddressSupportingNetworkUserData(coin,
        timestamp,
        signature,
        network,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1CapitalDepositAddressResponse
}
catch (SdkException<DepositAddressSupportingNetworkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>coin</code> | <code>string</code> | Coin name |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>network</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalDepositAddressResponse](Models/SapiV1CapitalDepositAddressResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DepositAddressSupportingNetworkUserDataError](Errors/DepositAddressSupportingNetworkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalDepositHisrecResponse&gt;&gt; DepositHistorySupportingNetworkUserData(long timestamp, string signature, string? coin, int? status, long? startTime, long? endTime, int? offset, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch deposit history.

- Please notice the default `startTime` and `endTime` to make sure that time interval is within 0-90 days.
- If both `startTime` and `endTime` are sent, time between `startTime` and `endTime` must be less than 90 days.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.DepositHistorySupportingNetworkUserData(timestamp,
        signature,
        coin,
        status,
        startTime,
        endTime,
        offset,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalDepositHisrecResponse>
}
catch (SdkException<DepositHistorySupportingNetworkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>coin</code> | <code>string?</code> | Coin name |
| <code>status</code> | <code>int?</code> | * `0` - pending<br>* `6` - credited but cannot withdraw<br>* `1` - success |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>offset</code> | <code>int?</code> | - |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalDepositHisrecResponse](Models/SapiV1CapitalDepositHisrecResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DepositHistorySupportingNetworkUserDataError](Errors/DepositHistorySupportingNetworkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; DisableFastWithdrawSwitchUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- This request will disable fastwithdraw switch under your account.
- You need to enable "trade" option for the api key which requests this endpoint.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.DisableFastWithdrawSwitchUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type object
}
catch (SdkException<DisableFastWithdrawSwitchUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DisableFastWithdrawSwitchUserDataError](Errors/DisableFastWithdrawSwitchUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetDustResponse&gt; DustTransferUserData(IReadOnlyList&lt;string&gt; asset, long timestamp, string signature, AccountType? accountType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Convert dust assets to BNB.

Weight(UID): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.DustTransferUserData(asset, timestamp, signature, accountType, recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetDustResponse
}
catch (SdkException<DustTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>asset</code> | <code>IReadOnlyList&lt;string&gt;</code> | The asset being converted. For example, asset=BTC&asset=USDT |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>accountType</code> | <code>[AccountType?](Models/Enums/AccountType.cs)</code> | SPOT or MARGIN, default SPOT |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetDustResponse](Models/SapiV1AssetDustResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DustTransferUserDataError](Errors/DustTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetDribbletResponse&gt; DustLogUserData(long timestamp, string signature, AccountType? accountType, long? startTime, long? endTime, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.DustLogUserData(timestamp,
        signature,
        accountType,
        startTime,
        endTime,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetDribbletResponse
}
catch (SdkException<DustLogUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>accountType</code> | <code>[AccountType?](Models/Enums/AccountType.cs)</code> | SPOT or MARGIN, default SPOT |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetDribbletResponse](Models/SapiV1AssetDribbletResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DustLogUserDataError](Errors/DustLogUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; EnableFastWithdrawSwitchUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- This request will enable fastwithdraw switch under your account. You need to enable "trade" option for the api key which requests this endpoint.
- When Fast Withdraw Switch is on, transferring funds to a Binance account will be done instantly. There is no on-chain transaction, no transaction ID and no withdrawal fee.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.EnableFastWithdrawSwitchUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type object
}
catch (SdkException<EnableFastWithdrawSwitchUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EnableFastWithdrawSwitchUserDataError](Errors/EnableFastWithdrawSwitchUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalDepositAddressListResponse&gt;&gt; FetchDepositAddressListWithNetworkUserData(string coin, long timestamp, string signature, string? network, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch deposit address list with network.

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.FetchDepositAddressListWithNetworkUserData(coin,
        timestamp,
        signature,
        network,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalDepositAddressListResponse>
}
catch (SdkException<FetchDepositAddressListWithNetworkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>coin</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>network</code> | <code>string?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalDepositAddressListResponse](Models/SapiV1CapitalDepositAddressListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FetchDepositAddressListWithNetworkUserDataError](Errors/FetchDepositAddressListWithNetworkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalWithdrawAddressListResponse&gt;&gt; FetchWithdrawAddressListUserData(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch withdraw address list

Weight(IP): 10

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.FetchWithdrawAddressListUserData();
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalWithdrawAddressListResponse>
}
catch (SdkException<FetchWithdrawAddressListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalWithdrawAddressListResponse](Models/SapiV1CapitalWithdrawAddressListResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FetchWithdrawAddressListUserDataError](Errors/FetchWithdrawAddressListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1AssetGetFundingAssetResponse&gt;&gt; FundingWalletUserData(long timestamp, string signature, string? asset, NeedBtcValuation? needBtcValuation, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- Currently supports querying the following business assets：Binance Pay, Binance Card, Binance Gift Card, Stock Token

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.FundingWalletUserData(timestamp, signature, asset, needBtcValuation, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1AssetGetFundingAssetResponse>
}
catch (SdkException<FundingWalletUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>needBtcValuation</code> | <code>[NeedBtcValuation?](Models/Enums/NeedBtcValuation.cs)</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1AssetGetFundingAssetResponse](Models/SapiV1AssetGetFundingAssetResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FundingWalletUserDataError](Errors/FundingWalletUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AccountApiRestrictionsResponse&gt; GetApiKeyPermissionUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.GetApiKeyPermissionUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type SapiV1AccountApiRestrictionsResponse
}
catch (SdkException<GetApiKeyPermissionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountApiRestrictionsResponse](Models/SapiV1AccountApiRestrictionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetApiKeyPermissionUserDataError](Errors/GetApiKeyPermissionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetDustBtcResponse&gt; GetAssetsThatCanBeConvertedIntoBnbUserData(long timestamp, string signature, AccountType? accountType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.GetAssetsThatCanBeConvertedIntoBnbUserData(timestamp,
        signature,
        accountType,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetDustBtcResponse
}
catch (SdkException<GetAssetsThatCanBeConvertedIntoBnbUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>accountType</code> | <code>[AccountType?](Models/Enums/AccountType.cs)</code> | SPOT or MARGIN, default SPOT |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetDustBtcResponse](Models/SapiV1AssetDustBtcResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAssetsThatCanBeConvertedIntoBnbUserDataError](Errors/GetAssetsThatCanBeConvertedIntoBnbUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse&gt; GetCloudMiningPaymentAndRefundHistoryUserData(long startTime, long endTime, long timestamp, string signature, long? tranId, string? clientTranId, string? asset, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The query of Cloud-Mining payment and refund history

Weight(UID): 600

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.GetCloudMiningPaymentAndRefundHistoryUserData(startTime,
        endTime,
        timestamp,
        signature,
        tranId,
        clientTranId,
        asset,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse
}
catch (SdkException<GetCloudMiningPaymentAndRefundHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>long</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long</code> | UTC timestamp in ms |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>tranId</code> | <code>long?</code> | The transaction id |
| <code>clientTranId</code> | <code>string?</code> | The unique flag |
| <code>asset</code> | <code>string?</code> | If it is blank, we will query all assets |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse](Models/SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCloudMiningPaymentAndRefundHistoryUserDataError](Errors/GetCloudMiningPaymentAndRefundHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SpotDelistScheduleResponse&gt;&gt; GetSymbolsDelistScheduleForSpotMarketData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get symbols delist schedule for spot

Weight(IP): 100

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.GetSymbolsDelistScheduleForSpotMarketData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SpotDelistScheduleResponse>
}
catch (SdkException<GetSymbolsDelistScheduleForSpotMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SpotDelistScheduleResponse](Models/SapiV1SpotDelistScheduleResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSymbolsDelistScheduleForSpotMarketDataError](Errors/GetSymbolsDelistScheduleForSpotMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalDepositCreditApplyResponse&gt; OneClickArrivalDepositApplyUserData(long timestamp, string signature, long? depositId, string? txId, long? subAccountId, long? subUserId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Apply deposit credit for expired address (One click arrival)

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.OneClickArrivalDepositApplyUserData(timestamp,
        signature,
        depositId,
        txId,
        subAccountId,
        subUserId,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1CapitalDepositCreditApplyResponse
}
catch (SdkException<OneClickArrivalDepositApplyUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>depositId</code> | <code>long?</code> | Deposit record Id, priority use |
| <code>txId</code> | <code>string?</code> | Deposit txId, used when depositId is not specified |
| <code>subAccountId</code> | <code>long?</code> | - |
| <code>subUserId</code> | <code>long?</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalDepositCreditApplyResponse](Models/SapiV1CapitalDepositCreditApplyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OneClickArrivalDepositApplyUserDataError](Errors/OneClickArrivalDepositApplyUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetConvertTransferQueryByPageResponse&gt; QueryConvertTransferUserData(long startTime, long endTime, long timestamp, string signature, long? tranId, string? asset, AccountType3? accountType, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Weight(UID): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.QueryConvertTransferUserData(startTime,
        endTime,
        timestamp,
        signature,
        tranId,
        asset,
        accountType,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetConvertTransferQueryByPageResponse
}
catch (SdkException<QueryConvertTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>long</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long</code> | UTC timestamp in ms |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>tranId</code> | <code>long?</code> | The transaction id |
| <code>asset</code> | <code>string?</code> | If it is blank, we will match deducted asset and target asset. |
| <code>accountType</code> | <code>[AccountType3?](Models/Enums/AccountType3.cs)</code> | MAIN: main account. CARD: funding account. If it is blank, we will query spot and card wallet, otherwise, we just query the corresponding wallet |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetConvertTransferQueryByPageResponse](Models/SapiV1AssetConvertTransferQueryByPageResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryConvertTransferUserDataError](Errors/QueryConvertTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetCustodyTransferHistoryResponse&gt; QueryUserDelegationHistoryForMasterAccountUserData(string email, long startTime, long endTime, string asset, long timestamp, string signature, string? type, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query User Delegation History

Weight(IP): 60

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.QueryUserDelegationHistoryForMasterAccountUserData(email,
        startTime,
        endTime,
        asset,
        timestamp,
        signature,
        type,
        current,
        size,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetCustodyTransferHistoryResponse
}
catch (SdkException<QueryUserDelegationHistoryForMasterAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>email</code> | <code>string</code> | - |
| <code>startTime</code> | <code>long</code> | - |
| <code>endTime</code> | <code>long</code> | - |
| <code>asset</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>type</code> | <code>string?</code> | - |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetCustodyTransferHistoryResponse](Models/SapiV1AssetCustodyTransferHistoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryUserDelegationHistoryForMasterAccountUserDataError](Errors/QueryUserDelegationHistoryForMasterAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetTransferResponse&gt; QueryUserUniversalTransferHistoryUserData(Type7 type, long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, string? fromSymbol, string? toSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

- `fromSymbol` must be sent when type are ISOLATEDMARGIN_MARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN
- `toSymbol` must be sent when type are MARGIN_ISOLATEDMARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN
- Support query within the last 6 months only
- If `startTime` and `endTime` not sent, return records of the last 7 days by default

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.QueryUserUniversalTransferHistoryUserData(type,
        timestamp,
        signature,
        startTime,
        endTime,
        current,
        size,
        fromSymbol,
        toSymbol,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetTransferResponse
}
catch (SdkException<QueryUserUniversalTransferHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>[Type7](Models/Enums/Type7.cs)</code> | Universal transfer type |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>current</code> | <code>int?</code> | Current querying page. Start from 1. Default:1 |
| <code>size</code> | <code>int?</code> | Default:10 Max:100 |
| <code>fromSymbol</code> | <code>string?</code> | Must be sent when type are ISOLATEDMARGIN_MARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN |
| <code>toSymbol</code> | <code>string?</code> | Must be sent when type are MARGIN_ISOLATEDMARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetTransferResponse](Models/SapiV1AssetTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryUserUniversalTransferHistoryUserDataError](Errors/QueryUserUniversalTransferHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1AssetWalletBalanceResponse&gt;&gt; QueryUserWalletBalanceUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query User Wallet Balance

Weight(IP): 60

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.QueryUserWalletBalanceUserData(timestamp, signature, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1AssetWalletBalanceResponse>
}
catch (SdkException<QueryUserWalletBalanceUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1AssetWalletBalanceResponse](Models/SapiV1AssetWalletBalanceResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryUserWalletBalanceUserDataError](Errors/QueryUserWalletBalanceUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalContractConvertibleCoinsResponse&gt; QueryAutoConvertingStableCoinsUserData(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a user's auto-conversion settings in deposit/withdrawal

Weight(UID): 600'

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.QueryAutoConvertingStableCoinsUserData();
    // TODO: Handle 'response' of type SapiV1CapitalContractConvertibleCoinsResponse
}
catch (SdkException<QueryAutoConvertingStableCoinsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalContractConvertibleCoinsResponse](Models/SapiV1CapitalContractConvertibleCoinsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryAutoConvertingStableCoinsUserDataError](Errors/QueryAutoConvertingStableCoinsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; SwitchOnOffBusdAndStableCoinsConversionUserDataUserData(string coin, bool enable, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

User can use it to turn on or turn off the BUSD auto-conversion from/to a specific stable coin.

Weight(UID): 600'

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.SwitchOnOffBusdAndStableCoinsConversionUserDataUserData(coin, enable);
    // TODO: Handle 'response' of type object
}
catch (SdkException<SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>coin</code> | <code>string</code> | Must be USDC, USDP or TUSD |
| <code>enable</code> | <code>bool</code> | true: turn on the auto-conversion. false: turn off the auto-conversion |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError](Errors/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SystemStatusResponse&gt; SystemStatusSystem(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch system status.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.SystemStatusSystem();
    // TODO: Handle 'response' of type SapiV1SystemStatusResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SystemStatusResponse](Models/SapiV1SystemStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1AssetTradeFeeResponse&gt;&gt; TradeFeeUserData(long timestamp, string signature, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch trade fee

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.TradeFeeUserData(timestamp, signature, symbol, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1AssetTradeFeeResponse>
}
catch (SdkException<TradeFeeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>symbol</code> | <code>string?</code> | Trading symbol, e.g. BNBUSDT |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1AssetTradeFeeResponse](Models/SapiV1AssetTradeFeeResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TradeFeeUserDataError](Errors/TradeFeeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV3AssetGetUserAssetResponse&gt;&gt; UserAssetUserData(long timestamp, string signature, string? asset, NeedBtcValuation? needBtcValuation, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get user assets, just for positive data.

Weight(IP): 5

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.UserAssetUserData(timestamp, signature, asset, needBtcValuation, recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV3AssetGetUserAssetResponse>
}
catch (SdkException<UserAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>asset</code> | <code>string?</code> | - |
| <code>needBtcValuation</code> | <code>[NeedBtcValuation?](Models/Enums/NeedBtcValuation.cs)</code> | - |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV3AssetGetUserAssetResponse](Models/SapiV3AssetGetUserAssetResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UserAssetUserDataError](Errors/UserAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetTransferResponse1&gt; UserUniversalTransferUserData(Type7 type, string asset, double amount, long timestamp, string signature, string? fromSymbol, string? toSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You need to enable `Permits Universal Transfer` option for the api key which requests this endpoint.

- `fromSymbol` must be sent when type are ISOLATEDMARGIN_MARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN
- `toSymbol` must be sent when type are MARGIN_ISOLATEDMARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN

ENUM of transfer types:
  - MAIN_UMFUTURE Spot account transfer to USDⓈ-M Futures account
  - MAIN_CMFUTURE Spot account transfer to COIN-M Futures account
  - MAIN_MARGIN Spot account transfer to Margin(cross)account
  - UMFUTURE_MAIN USDⓈ-M Futures account transfer to Spot account
  - UMFUTURE_MARGIN USDⓈ-M Futures account transfer to Margin(cross)account
  - CMFUTURE_MAIN COIN-M Futures account transfer to Spot account
  - CMFUTURE_MARGIN COIN-M Futures account transfer to Margin(cross) account
  - MARGIN_MAIN Margin(cross)account transfer to Spot account
  - MARGIN_UMFUTURE Margin(cross)account transfer to USDⓈ-M Futures
  - MARGIN_CMFUTURE Margin(cross)account transfer to COIN-M Futures
  - ISOLATEDMARGIN_MARGIN Isolated margin account transfer to Margin(cross) account
  - MARGIN_ISOLATEDMARGIN Margin(cross) account transfer to Isolated margin account
  - ISOLATEDMARGIN_ISOLATEDMARGIN Isolated margin account transfer to Isolated margin account
  - MAIN_FUNDING Spot account transfer to Funding account
  - FUNDING_MAIN Funding account transfer to Spot account
  - FUNDING_UMFUTURE Funding account transfer to UMFUTURE account
  - UMFUTURE_FUNDING UMFUTURE account transfer to Funding account
  - MARGIN_FUNDING MARGIN account transfer to Funding account
  - FUNDING_MARGIN Funding account transfer to Margin account
  - FUNDING_CMFUTURE Funding account transfer to CMFUTURE account
  - CMFUTURE_FUNDING CMFUTURE account transfer to Funding account
  - MAIN_OPTION Spot account transfer to Options account
  - OPTION_MAIN Options account transfer to Spot account
  - UMFUTURE_OPTION USDⓈ-M Futures account transfer to Options account
  - OPTION_UMFUTURE Options account transfer to USDⓈ-M Futures account
  - MARGIN_OPTION Margin(cross)account transfer to Options account
  - OPTION_MARGIN Options account transfer to Margin(cross)account
  - FUNDING_OPTION Funding account transfer to Options account
  - OPTION_FUNDING Options account transfer to Funding account
  - MAIN_PORTFOLIO_MARGIN Spot account transfer to Portfolio Margin account
  - PORTFOLIO_MARGIN_MAIN Portfolio Margin account transfer to Spot account
  - MAIN_ISOLATED_MARGIN Spot account transfer to Isolated margin account
  - ISOLATED_MARGIN_MAIN Isolated margin account transfer to Spot account

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.UserUniversalTransferUserData(type,
        asset,
        amount,
        timestamp,
        signature,
        fromSymbol,
        toSymbol,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1AssetTransferResponse1
}
catch (SdkException<UserUniversalTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>[Type7](Models/Enums/Type7.cs)</code> | Universal transfer type |
| <code>asset</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>fromSymbol</code> | <code>string?</code> | Must be sent when type are ISOLATEDMARGIN_MARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN |
| <code>toSymbol</code> | <code>string?</code> | Must be sent when type are MARGIN_ISOLATEDMARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetTransferResponse1](Models/SapiV1AssetTransferResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UserUniversalTransferUserDataError](Errors/UserUniversalTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalWithdrawApplyResponse&gt; WithdrawUserData(string coin, string address, double amount, long timestamp, string signature, string? withdrawOrderId, string? network, string? addressTag, string? name, int? walletType, long? recvWindow, bool? transactionFeeFlag = false, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submit a withdraw request.

- If `network` not send, return with default network of the coin.
- You can get `network` and `isDefault` in `networkList` of a coin in the response of `Get /sapi/v1/capital/config/getall (HMAC SHA256)`.

Weight(IP): 1

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.WithdrawUserData(coin,
        address,
        amount,
        timestamp,
        signature,
        withdrawOrderId,
        network,
        addressTag,
        name,
        walletType,
        recvWindow);
    // TODO: Handle 'response' of type SapiV1CapitalWithdrawApplyResponse
}
catch (SdkException<WithdrawUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>coin</code> | <code>string</code> | Coin name |
| <code>address</code> | <code>string</code> | - |
| <code>amount</code> | <code>double</code> | - |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>withdrawOrderId</code> | <code>string?</code> | Client id for withdraw |
| <code>network</code> | <code>string?</code> | - |
| <code>addressTag</code> | <code>string?</code> | Secondary address identifier for coins like XRP,XMR etc. |
| <code>name</code> | <code>string?</code> | - |
| <code>walletType</code> | <code>int?</code> | The wallet type for withdraw，0-Spot wallet, 1- Funding wallet. Default is Spot wallet |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |
| <code>transactionFeeFlag</code> | <code>bool?</code> | When making internal transfer<br>- `true` ->  returning the fee to the destination account;<br>- `false` -> returning the fee back to the departure account.<br>**Default**: false |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalWithdrawApplyResponse](Models/SapiV1CapitalWithdrawApplyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[WithdrawUserDataError](Errors/WithdrawUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalWithdrawHistoryResponse&gt;&gt; WithdrawHistorySupportingNetworkUserData(long timestamp, string signature, string? coin, string? withdrawOrderId, int? status, long? startTime, long? endTime, int? offset, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch withdraw history.

This endpoint specifically uses per second UID rate limit, user's total second level IP rate limit is 180000/second. Response from the endpoint contains header key X-SAPI-USED-UID-WEIGHT-1S, which defines weight used by the current IP.

- `network` may not be in the response for old withdraw.
- Please notice the default `startTime` and `endTime` to make sure that time interval is within 0-90 days.
- If both `startTime` and `endTime` are sent, time between `startTime` and `endTime` must be less than 90 days
- If withdrawOrderId is sent, time between startTime and endTime must be less than 7 days.
- If withdrawOrderId is sent, startTime and endTime are not sent, will return last 7 days records by default.

Weight(UID): 18000
Request Limit: 10 requests per second

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Wallet.WithdrawHistorySupportingNetworkUserData(timestamp,
        signature,
        coin,
        withdrawOrderId,
        status,
        startTime,
        endTime,
        offset,
        limit,
        recvWindow);
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalWithdrawHistoryResponse>
}
catch (SdkException<WithdrawHistorySupportingNetworkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timestamp</code> | <code>long</code> | UTC timestamp in ms |
| <code>signature</code> | <code>string</code> | Signature |
| <code>coin</code> | <code>string?</code> | Coin name |
| <code>withdrawOrderId</code> | <code>string?</code> | - |
| <code>status</code> | <code>int?</code> | * `0` - Email Sent<br>* `1` - Cancelled<br>* `2` - Awaiting Approval<br>* `3` - Rejected<br>* `4` - Processing<br>* `5` - Failure<br>* `6` - Completed |
| <code>startTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>endTime</code> | <code>long?</code> | UTC timestamp in ms |
| <code>offset</code> | <code>int?</code> | - |
| <code>limit</code> | <code>int?</code> | Default 500; max 1000. |
| <code>recvWindow</code> | <code>long?</code> | The value cannot be greater than 60000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalWithdrawHistoryResponse](Models/SapiV1CapitalWithdrawHistoryResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[WithdrawHistorySupportingNetworkUserDataError](Errors/WithdrawHistorySupportingNetworkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

