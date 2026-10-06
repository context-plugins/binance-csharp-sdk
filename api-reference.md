# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [BinanceClient](BinanceClient.cs)

## AutoInvest

> Source: [AutoInvest](Api/AutoInvest.cs)

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanEditStatusResponse&gt; ChangePlanStatus(ChangePlanStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.ChangePlanStatus(new ChangePlanStatusRequest
    {
        PlanId = 1,
        Status = Status1.Ongoing,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanEditStatusResponse
}
catch (ApiException<ChangePlanStatusError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangePlanStatusRequest](Requests/AutoInvest/ChangePlanStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanEditStatusResponse](Models/SapiV1LendingAutoInvestPlanEditStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ChangePlanStatusError](Errors/ChangePlanStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanListResponse&gt; GetListOfPlans(GetListOfPlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.GetListOfPlans(new GetListOfPlansRequest
    {
        PlanType = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanListResponse
}
catch (ApiException<GetListOfPlansError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetListOfPlansRequest](Requests/AutoInvest/GetListOfPlansRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanListResponse](Models/SapiV1LendingAutoInvestPlanListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetListOfPlansError](Errors/GetListOfPlansError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingAutoInvestTargetAssetRoiListResponse&gt;&gt; GetTargetAssetRoiDataUserData(GetTargetAssetRoiDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.GetTargetAssetRoiDataUserData(new GetTargetAssetRoiDataUserDataRequest
    {
        TargetAsset = "BTC",
        HisRoiType = "FIVE_YEAR",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingAutoInvestTargetAssetRoiListResponse>
}
catch (ApiException<GetTargetAssetRoiDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTargetAssetRoiDataUserDataRequest](Requests/AutoInvest/GetTargetAssetRoiDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestTargetAssetRoiListResponse](Models/SapiV1LendingAutoInvestTargetAssetRoiListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTargetAssetRoiDataUserDataError](Errors/GetTargetAssetRoiDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestTargetAssetListResponse&gt; GetTargetAssetListUserData(GetTargetAssetListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.GetTargetAssetListUserData(new GetTargetAssetListUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Size = 100,
        Current = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestTargetAssetListResponse
}
catch (ApiException<GetTargetAssetListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTargetAssetListUserDataRequest](Requests/AutoInvest/GetTargetAssetListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestTargetAssetListResponse](Models/SapiV1LendingAutoInvestTargetAssetListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTargetAssetListUserDataError](Errors/GetTargetAssetListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingAutoInvestRebalanceHistoryResponse&gt;&gt; IndexLinkedPlanRebalanceDetailsUserData(IndexLinkedPlanRebalanceDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.IndexLinkedPlanRebalanceDetailsUserData(
        new IndexLinkedPlanRebalanceDetailsUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingAutoInvestRebalanceHistoryResponse>
}
catch (ApiException<IndexLinkedPlanRebalanceDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IndexLinkedPlanRebalanceDetailsUserDataRequest](Requests/AutoInvest/IndexLinkedPlanRebalanceDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestRebalanceHistoryResponse](Models/SapiV1LendingAutoInvestRebalanceHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[IndexLinkedPlanRebalanceDetailsUserDataError](Errors/IndexLinkedPlanRebalanceDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestRedeemResponse&gt; IndexLinkedPlanRedemptionTrade(IndexLinkedPlanRedemptionTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.IndexLinkedPlanRedemptionTrade(new IndexLinkedPlanRedemptionTradeRequest
    {
        IndexId = 123456L,
        RedemptionPercentage = 10,
        Timestamp = 1L,
        Signature = "some example string",
        RequestId = "TR12354859",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestRedeemResponse
}
catch (ApiException<IndexLinkedPlanRedemptionTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IndexLinkedPlanRedemptionTradeRequest](Requests/AutoInvest/IndexLinkedPlanRedemptionTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestRedeemResponse](Models/SapiV1LendingAutoInvestRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[IndexLinkedPlanRedemptionTradeError](Errors/IndexLinkedPlanRedemptionTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingAutoInvestRedeemHistoryResponse&gt;&gt; IndexLinkedPlanRedemptionHistoryUserData(IndexLinkedPlanRedemptionHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.IndexLinkedPlanRedemptionHistoryUserData(
        new IndexLinkedPlanRedemptionHistoryUserDataRequest
        {
            RequestId = 12345L,
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Asset = "BTC",
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingAutoInvestRedeemHistoryResponse>
}
catch (ApiException<IndexLinkedPlanRedemptionHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IndexLinkedPlanRedemptionHistoryUserDataRequest](Requests/AutoInvest/IndexLinkedPlanRedemptionHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestRedeemHistoryResponse](Models/SapiV1LendingAutoInvestRedeemHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[IndexLinkedPlanRedemptionHistoryUserDataError](Errors/IndexLinkedPlanRedemptionHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanEditResponse&gt; InvestmentPlanAdjustment(InvestmentPlanAdjustmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.InvestmentPlanAdjustment(new InvestmentPlanAdjustmentRequest
    {
        PlanId = 1,
        SubscriptionAmount = 1.5d,
        SubscriptionCycle = SubscriptionCycle.H1,
        SubscriptionStartTime = 1,
        SourceAsset = "USDT",
        Timestamp = 1L,
        Signature = "some example string",
        FlexibleAllowedToUse = true,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanEditResponse
}
catch (ApiException<InvestmentPlanAdjustmentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InvestmentPlanAdjustmentRequest](Requests/AutoInvest/InvestmentPlanAdjustmentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanEditResponse](Models/SapiV1LendingAutoInvestPlanEditResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[InvestmentPlanAdjustmentError](Errors/InvestmentPlanAdjustmentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanAddResponse&gt; InvestmentPlanCreationUserData(InvestmentPlanCreationUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.InvestmentPlanCreationUserData(new InvestmentPlanCreationUserDataRequest
    {
        SourceType = SourceType.MainSite,
        PlanType = PlanType.Single,
        SubscriptionAmount = 1.5d,
        SubscriptionCycle = SubscriptionCycle.H1,
        SubscriptionStartTime = 1,
        SourceAsset = "USDT",
        Details = [new Detail1()],
        Timestamp = 1L,
        Signature = "some example string",
        FlexibleAllowedToUse = true,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanAddResponse
}
catch (ApiException<InvestmentPlanCreationUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InvestmentPlanCreationUserDataRequest](Requests/AutoInvest/InvestmentPlanCreationUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanAddResponse](Models/SapiV1LendingAutoInvestPlanAddResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[InvestmentPlanCreationUserDataError](Errors/InvestmentPlanCreationUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestOneOffResponse&gt; OneTimeTransactionTrade(OneTimeTransactionTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.OneTimeTransactionTrade(new OneTimeTransactionTradeRequest
    {
        SourceType = "MAIN_SITE",
        SubscriptionAmount = 10.1d,
        SourceAsset = "USDT",
        Timestamp = 1L,
        Signature = "some example string",
        RequestId = "TR12354859",
        FlexibleAllowedToUse = true,
        PlanId = 12345L,
        IndexId = 1L,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestOneOffResponse
}
catch (ApiException<OneTimeTransactionTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OneTimeTransactionTradeRequest](Requests/AutoInvest/OneTimeTransactionTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestOneOffResponse](Models/SapiV1LendingAutoInvestOneOffResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[OneTimeTransactionTradeError](Errors/OneTimeTransactionTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestIndexInfoResponse&gt; QueryIndexDetailsUserData(QueryIndexDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.QueryIndexDetailsUserData(new QueryIndexDetailsUserDataRequest
    {
        IndexId = 1L,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestIndexInfoResponse
}
catch (ApiException<QueryIndexDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryIndexDetailsUserDataRequest](Requests/AutoInvest/QueryIndexDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestIndexInfoResponse](Models/SapiV1LendingAutoInvestIndexInfoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryIndexDetailsUserDataError](Errors/QueryIndexDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestIndexUserSummaryResponse&gt; QueryIndexLinkedPlanPositionDetailsUserData(QueryIndexLinkedPlanPositionDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.QueryIndexLinkedPlanPositionDetailsUserData(
        new QueryIndexLinkedPlanPositionDetailsUserDataRequest
        {
            IndexId = 1L,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestIndexUserSummaryResponse
}
catch (ApiException<QueryIndexLinkedPlanPositionDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryIndexLinkedPlanPositionDetailsUserDataRequest](Requests/AutoInvest/QueryIndexLinkedPlanPositionDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestIndexUserSummaryResponse](Models/SapiV1LendingAutoInvestIndexUserSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryIndexLinkedPlanPositionDetailsUserDataError](Errors/QueryIndexLinkedPlanPositionDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestOneOffStatusResponse&gt; QueryOneTimeTransactionStatusUserData(QueryOneTimeTransactionStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.QueryOneTimeTransactionStatusUserData(
        new QueryOneTimeTransactionStatusUserDataRequest
        {
            TransactionId = 12345L,
            Timestamp = 1L,
            Signature = "some example string",
            RequestId = "TR12354859",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestOneOffStatusResponse
}
catch (ApiException<QueryOneTimeTransactionStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryOneTimeTransactionStatusUserDataRequest](Requests/AutoInvest/QueryOneTimeTransactionStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestOneOffStatusResponse](Models/SapiV1LendingAutoInvestOneOffStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryOneTimeTransactionStatusUserDataError](Errors/QueryOneTimeTransactionStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestAllAssetResponse&gt; QueryAllSourceAssetAndTargetAssetUserData(QueryAllSourceAssetAndTargetAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.QueryAllSourceAssetAndTargetAssetUserData(
        new QueryAllSourceAssetAndTargetAssetUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestAllAssetResponse
}
catch (ApiException<QueryAllSourceAssetAndTargetAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryAllSourceAssetAndTargetAssetUserDataRequest](Requests/AutoInvest/QueryAllSourceAssetAndTargetAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestAllAssetResponse](Models/SapiV1LendingAutoInvestAllAssetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryAllSourceAssetAndTargetAssetUserDataError](Errors/QueryAllSourceAssetAndTargetAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestPlanIdResponse&gt; QueryHoldingDetailsOfThePlan(QueryHoldingDetailsOfThePlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.QueryHoldingDetailsOfThePlan(new QueryHoldingDetailsOfThePlanRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestPlanIdResponse
}
catch (ApiException<QueryHoldingDetailsOfThePlanError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryHoldingDetailsOfThePlanRequest](Requests/AutoInvest/QueryHoldingDetailsOfThePlanRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanIdResponse](Models/SapiV1LendingAutoInvestPlanIdResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryHoldingDetailsOfThePlanError](Errors/QueryHoldingDetailsOfThePlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingAutoInvestSourceAssetListResponse&gt; QuerySourceAssetListUserData(QuerySourceAssetListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.QuerySourceAssetListUserData(new QuerySourceAssetListUserDataRequest
    {
        UsageType = "RECURRING",
        Timestamp = 1L,
        Signature = "some example string",
        TargetAsset = "BTC",
        IndexId = 1L,
        FlexibleAllowedToUse = true,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LendingAutoInvestSourceAssetListResponse
}
catch (ApiException<QuerySourceAssetListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QuerySourceAssetListUserDataRequest](Requests/AutoInvest/QuerySourceAssetListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestSourceAssetListResponse](Models/SapiV1LendingAutoInvestSourceAssetListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QuerySourceAssetListUserDataError](Errors/QuerySourceAssetListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingAutoInvestHistoryListResponse&gt;&gt; QuerySubscriptionTransactionHistory(QuerySubscriptionTransactionHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AutoInvest.QuerySubscriptionTransactionHistory(
        new QuerySubscriptionTransactionHistoryRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Size = 100,
            Current = 1,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingAutoInvestHistoryListResponse>
}
catch (ApiException<QuerySubscriptionTransactionHistoryError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QuerySubscriptionTransactionHistoryRequest](Requests/AutoInvest/QuerySubscriptionTransactionHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestHistoryListResponse](Models/SapiV1LendingAutoInvestHistoryListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QuerySubscriptionTransactionHistoryError](Errors/QuerySubscriptionTransactionHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Blvt

> Source: [Blvt](Api/Blvt.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1BlvtTokenInfoResponse&gt;&gt; BlvtInfoMarketData(BlvtInfoMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Blvt.BlvtInfoMarketData(new BlvtInfoMarketDataRequest());
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1BlvtTokenInfoResponse>
}
catch (ApiException<BlvtInfoMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BlvtInfoMarketDataRequest](Requests/Blvt/BlvtInfoMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1BlvtTokenInfoResponse](Models/SapiV1BlvtTokenInfoResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[BlvtInfoMarketDataError](Errors/BlvtInfoMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1BlvtUserLimitResponse&gt;&gt; BlvtUserLimitInfoUserData(BlvtUserLimitInfoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Blvt.BlvtUserLimitInfoUserData(new BlvtUserLimitInfoUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1BlvtUserLimitResponse>
}
catch (ApiException<BlvtUserLimitInfoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BlvtUserLimitInfoUserDataRequest](Requests/Blvt/BlvtUserLimitInfoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1BlvtUserLimitResponse](Models/SapiV1BlvtUserLimitResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[BlvtUserLimitInfoUserDataError](Errors/BlvtUserLimitInfoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1BlvtSubscribeRecordResponse&gt; QuerySubscriptionRecordUserData(QuerySubscriptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Blvt.QuerySubscriptionRecordUserData(new QuerySubscriptionRecordUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 5,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1BlvtSubscribeRecordResponse
}
catch (ApiException<QuerySubscriptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QuerySubscriptionRecordUserDataRequest](Requests/Blvt/QuerySubscriptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1BlvtSubscribeRecordResponse](Models/SapiV1BlvtSubscribeRecordResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QuerySubscriptionRecordUserDataError](Errors/QuerySubscriptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1BlvtRedeemResponse&gt; RedeemBlvtUserData(RedeemBlvtUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Blvt.RedeemBlvtUserData(new RedeemBlvtUserDataRequest
    {
        TokenName = "some example string",
        Amount = 1.01d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1BlvtRedeemResponse
}
catch (ApiException<RedeemBlvtUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RedeemBlvtUserDataRequest](Requests/Blvt/RedeemBlvtUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1BlvtRedeemResponse](Models/SapiV1BlvtRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RedeemBlvtUserDataError](Errors/RedeemBlvtUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1BlvtRedeemRecordResponse&gt;&gt; RedemptionRecordUserData(RedemptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Blvt.RedemptionRecordUserData(new RedemptionRecordUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1BlvtRedeemRecordResponse>
}
catch (ApiException<RedemptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RedemptionRecordUserDataRequest](Requests/Blvt/RedemptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1BlvtRedeemRecordResponse](Models/SapiV1BlvtRedeemRecordResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RedemptionRecordUserDataError](Errors/RedemptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1BlvtSubscribeResponse&gt; SubscribeBlvtUserData(SubscribeBlvtUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Blvt.SubscribeBlvtUserData(new SubscribeBlvtUserDataRequest
    {
        TokenName = "some example string",
        Cost = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1BlvtSubscribeResponse
}
catch (ApiException<SubscribeBlvtUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubscribeBlvtUserDataRequest](Requests/Blvt/SubscribeBlvtUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1BlvtSubscribeResponse](Models/SapiV1BlvtSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubscribeBlvtUserDataError](Errors/SubscribeBlvtUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## C2C

> Source: [C2C](Api/C2C.cs)

<details>
<summary><code>Task&lt;SapiV1C2COrderMatchListUserOrderHistoryResponse&gt; GetC2CTradeHistoryUserData(GetC2CTradeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.C2C.GetC2CTradeHistoryUserData(new GetC2CTradeHistoryUserDataRequest
    {
        TradeType = TradeType.Buy,
        Timestamp = 1L,
        Signature = "some example string",
        Page = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1C2COrderMatchListUserOrderHistoryResponse
}
catch (ApiException<GetC2CTradeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetC2CTradeHistoryUserDataRequest](Requests/C2C/GetC2CTradeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1C2COrderMatchListUserOrderHistoryResponse](Models/SapiV1C2COrderMatchListUserOrderHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetC2CTradeHistoryUserDataError](Errors/GetC2CTradeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConvertApi

> Source: [ConvertApi](Api/ConvertApi.cs)

<details>
<summary><code>Task&lt;SapiV1ConvertAcceptQuoteResponse&gt; AcceptQuoteTrade(AcceptQuoteTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ConvertApi.AcceptQuoteTrade(new AcceptQuoteTradeRequest
    {
        QuoteId = "1000",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1ConvertAcceptQuoteResponse
}
catch (ApiException<AcceptQuoteTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AcceptQuoteTradeRequest](Requests/ConvertApi/AcceptQuoteTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertAcceptQuoteResponse](Models/SapiV1ConvertAcceptQuoteResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AcceptQuoteTradeError](Errors/AcceptQuoteTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertLimitCancelOrderResponse&gt; CancelLimitOrderUserData(CancelLimitOrderUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ConvertApi.CancelLimitOrderUserData(new CancelLimitOrderUserDataRequest
    {
        OrderId = 1603680255057330400L,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1ConvertLimitCancelOrderResponse
}
catch (ApiException<CancelLimitOrderUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelLimitOrderUserDataRequest](Requests/ConvertApi/CancelLimitOrderUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertLimitCancelOrderResponse](Models/SapiV1ConvertLimitCancelOrderResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelLimitOrderUserDataError](Errors/CancelLimitOrderUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertTradeFlowResponse&gt; GetConvertTradeHistoryUserData(GetConvertTradeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ConvertApi.GetConvertTradeHistoryUserData(new GetConvertTradeHistoryUserDataRequest
    {
        StartTime = 1624248872184L,
        EndTime = 1624248872185L,
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1ConvertTradeFlowResponse
}
catch (ApiException<GetConvertTradeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetConvertTradeHistoryUserDataRequest](Requests/ConvertApi/GetConvertTradeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertTradeFlowResponse](Models/SapiV1ConvertTradeFlowResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetConvertTradeHistoryUserDataError](Errors/GetConvertTradeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1ConvertExchangeInfoResponse&gt;&gt; ListAllConvertPairs(ListAllConvertPairsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ConvertApi.ListAllConvertPairs(new ListAllConvertPairsRequest
    {
        FromAsset = "BTC",
        ToAsset = "USDT",
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1ConvertExchangeInfoResponse>
}
catch (ApiException<ListAllConvertPairsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAllConvertPairsRequest](Requests/ConvertApi/ListAllConvertPairsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1ConvertExchangeInfoResponse](Models/SapiV1ConvertExchangeInfoResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListAllConvertPairsError](Errors/ListAllConvertPairsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertOrderStatusResponse&gt; OrderStatusUserData(OrderStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ConvertApi.OrderStatusUserData(new OrderStatusUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        OrderId = "1000",
        QuoteId = "1000",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1ConvertOrderStatusResponse
}
catch (ApiException<OrderStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OrderStatusUserDataRequest](Requests/ConvertApi/OrderStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertOrderStatusResponse](Models/SapiV1ConvertOrderStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[OrderStatusUserDataError](Errors/OrderStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertLimitPlaceOrderResponse&gt; PlaceLimitOrderUserData(PlaceLimitOrderUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ConvertApi.PlaceLimitOrderUserData(new PlaceLimitOrderUserDataRequest
    {
        BaseAsset = "BUSD",
        QuoteAsset = "USDT",
        LimitPrice = 1.5d,
        Side = Side.Sell,
        Timestamp = 1L,
        Signature = "some example string",
        WalletType = WalletType.Spot,
        ExpiredType = ExpiredType._1D,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1ConvertLimitPlaceOrderResponse
}
catch (ApiException<PlaceLimitOrderUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PlaceLimitOrderUserDataRequest](Requests/ConvertApi/PlaceLimitOrderUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertLimitPlaceOrderResponse](Models/SapiV1ConvertLimitPlaceOrderResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PlaceLimitOrderUserDataError](Errors/PlaceLimitOrderUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertLimitQueryOpenOrdersResponse&gt; QueryLimitOpenOrdersUserData(QueryLimitOpenOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ConvertApi.QueryLimitOpenOrdersUserData(new QueryLimitOpenOrdersUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1ConvertLimitQueryOpenOrdersResponse
}
catch (ApiException<QueryLimitOpenOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryLimitOpenOrdersUserDataRequest](Requests/ConvertApi/QueryLimitOpenOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertLimitQueryOpenOrdersResponse](Models/SapiV1ConvertLimitQueryOpenOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryLimitOpenOrdersUserDataError](Errors/QueryLimitOpenOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1ConvertAssetInfoResponse&gt;&gt; QueryOrderQuantityPrecisionPerAssetUserData(QueryOrderQuantityPrecisionPerAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ConvertApi.QueryOrderQuantityPrecisionPerAssetUserData(
        new QueryOrderQuantityPrecisionPerAssetUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1ConvertAssetInfoResponse>
}
catch (ApiException<QueryOrderQuantityPrecisionPerAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryOrderQuantityPrecisionPerAssetUserDataRequest](Requests/ConvertApi/QueryOrderQuantityPrecisionPerAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1ConvertAssetInfoResponse](Models/SapiV1ConvertAssetInfoResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryOrderQuantityPrecisionPerAssetUserDataError](Errors/QueryOrderQuantityPrecisionPerAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ConvertGetQuoteResponse&gt; SendQuoteRequestUserData(SendQuoteRequestUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ConvertApi.SendQuoteRequestUserData(new SendQuoteRequestUserDataRequest
    {
        FromAsset = "BTC",
        ToAsset = "USDT",
        Timestamp = 1L,
        Signature = "some example string",
        FromAmount = 1d,
        ToAmount = 1d,
        ValidTime = "10s",
        WalletType = "SPOT",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1ConvertGetQuoteResponse
}
catch (ApiException<SendQuoteRequestUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SendQuoteRequestUserDataRequest](Requests/ConvertApi/SendQuoteRequestUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertGetQuoteResponse](Models/SapiV1ConvertGetQuoteResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SendQuoteRequestUserDataError](Errors/SendQuoteRequestUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CopyTrading

> Source: [CopyTrading](Api/CopyTrading.cs)

<details>
<summary><code>Task&lt;SapiV1CopyTradingFuturesUserStatusResponse&gt; GetFuturesLeadTraderStatusTrade(GetFuturesLeadTraderStatusTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CopyTrading.GetFuturesLeadTraderStatusTrade(new GetFuturesLeadTraderStatusTradeRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1CopyTradingFuturesUserStatusResponse
}
catch (ApiException<GetFuturesLeadTraderStatusTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFuturesLeadTraderStatusTradeRequest](Requests/CopyTrading/GetFuturesLeadTraderStatusTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CopyTradingFuturesUserStatusResponse](Models/SapiV1CopyTradingFuturesUserStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFuturesLeadTraderStatusTradeError](Errors/GetFuturesLeadTraderStatusTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CopyTradingFuturesLeadSymbolResponse&gt; GetFuturesLeadTradingSymbolWhitelistUserData(GetFuturesLeadTradingSymbolWhitelistUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CopyTrading.GetFuturesLeadTradingSymbolWhitelistUserData(
        new GetFuturesLeadTradingSymbolWhitelistUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1CopyTradingFuturesLeadSymbolResponse
}
catch (ApiException<GetFuturesLeadTradingSymbolWhitelistUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFuturesLeadTradingSymbolWhitelistUserDataRequest](Requests/CopyTrading/GetFuturesLeadTradingSymbolWhitelistUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CopyTradingFuturesLeadSymbolResponse](Models/SapiV1CopyTradingFuturesLeadSymbolResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFuturesLeadTradingSymbolWhitelistUserDataError](Errors/GetFuturesLeadTradingSymbolWhitelistUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CryptoLoans

> Source: [CryptoLoans](Api/CryptoLoans.cs)

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleAdjustLtvResponse&gt; AdjustLtvFlexibleLoanAdjustLtvTrade(AdjustLtvFlexibleLoanAdjustLtvTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.AdjustLtvFlexibleLoanAdjustLtvTrade(
        new AdjustLtvFlexibleLoanAdjustLtvTradeRequest
        {
            AdjustmentAmount = 1.5d,
            Direction = Direction.Additional,
            Timestamp = 1L,
            Signature = "some example string",
            LoanCoin = "BUSD",
            CollateralCoin = "BNB",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2LoanFlexibleAdjustLtvResponse
}
catch (ApiException<AdjustLtvFlexibleLoanAdjustLtvTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdjustLtvFlexibleLoanAdjustLtvTradeRequest](Requests/CryptoLoans/AdjustLtvFlexibleLoanAdjustLtvTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleAdjustLtvResponse](Models/SapiV2LoanFlexibleAdjustLtvResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AdjustLtvFlexibleLoanAdjustLtvTradeError](Errors/AdjustLtvFlexibleLoanAdjustLtvTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleLtvAdjustmentHistoryResponse&gt; AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData(AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData(
        new AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            LoanCoin = "BUSD",
            CollateralCoin = "BNB",
            Current = 1,
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2LoanFlexibleLtvAdjustmentHistoryResponse
}
catch (ApiException<AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest](Requests/CryptoLoans/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleLtvAdjustmentHistoryResponse](Models/SapiV2LoanFlexibleLtvAdjustmentHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError](Errors/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleBorrowResponse&gt; BorrowFlexibleLoanBorrowTrade(BorrowFlexibleLoanBorrowTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.BorrowFlexibleLoanBorrowTrade(new BorrowFlexibleLoanBorrowTradeRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        LoanCoin = "BUSD",
        LoanAmount = 100.1d,
        CollateralCoin = "BNB",
        CollateralAmount = 50.5d,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV2LoanFlexibleBorrowResponse
}
catch (ApiException<BorrowFlexibleLoanBorrowTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BorrowFlexibleLoanBorrowTradeRequest](Requests/CryptoLoans/BorrowFlexibleLoanBorrowTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleBorrowResponse](Models/SapiV2LoanFlexibleBorrowResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[BorrowFlexibleLoanBorrowTradeError](Errors/BorrowFlexibleLoanBorrowTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleBorrowHistoryResponse&gt; BorrowGetFlexibleLoanBorrowHistoryUserData(BorrowGetFlexibleLoanBorrowHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.BorrowGetFlexibleLoanBorrowHistoryUserData(
        new BorrowGetFlexibleLoanBorrowHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            LoanCoin = "BUSD",
            CollateralCoin = "BNB",
            Current = 1,
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2LoanFlexibleBorrowHistoryResponse
}
catch (ApiException<BorrowGetFlexibleLoanBorrowHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BorrowGetFlexibleLoanBorrowHistoryUserDataRequest](Requests/CryptoLoans/BorrowGetFlexibleLoanBorrowHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleBorrowHistoryResponse](Models/SapiV2LoanFlexibleBorrowHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[BorrowGetFlexibleLoanBorrowHistoryUserDataError](Errors/BorrowGetFlexibleLoanBorrowHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleOngoingOrdersResponse&gt; BorrowGetFlexibleLoanOngoingOrdersUserData(BorrowGetFlexibleLoanOngoingOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.BorrowGetFlexibleLoanOngoingOrdersUserData(
        new BorrowGetFlexibleLoanOngoingOrdersUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            LoanCoin = "BUSD",
            CollateralCoin = "BNB",
            Current = 1,
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2LoanFlexibleOngoingOrdersResponse
}
catch (ApiException<BorrowGetFlexibleLoanOngoingOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BorrowGetFlexibleLoanOngoingOrdersUserDataRequest](Requests/CryptoLoans/BorrowGetFlexibleLoanOngoingOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleOngoingOrdersResponse](Models/SapiV2LoanFlexibleOngoingOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[BorrowGetFlexibleLoanOngoingOrdersUserDataError](Errors/BorrowGetFlexibleLoanOngoingOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanRepayCollateralRateResponse&gt; CheckCollateralRepayRateUserData(CheckCollateralRepayRateUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.CheckCollateralRepayRateUserData(new CheckCollateralRepayRateUserDataRequest
    {
        LoanCoin = "BUSD",
        CollateralCoin = "BNB",
        RepayAmount = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanRepayCollateralRateResponse
}
catch (ApiException<CheckCollateralRepayRateUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CheckCollateralRepayRateUserDataRequest](Requests/CryptoLoans/CheckCollateralRepayRateUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanRepayCollateralRateResponse](Models/SapiV1LoanRepayCollateralRateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CheckCollateralRepayRateUserDataError](Errors/CheckCollateralRepayRateUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanAdjustLtvResponse&gt; CryptoLoanAdjustLtvTrade(CryptoLoanAdjustLtvTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.CryptoLoanAdjustLtvTrade(new CryptoLoanAdjustLtvTradeRequest
    {
        OrderId = 123456789L,
        Amount = 100.5d,
        Direction = Direction.Additional,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanAdjustLtvResponse
}
catch (ApiException<CryptoLoanAdjustLtvTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CryptoLoanAdjustLtvTradeRequest](Requests/CryptoLoans/CryptoLoanAdjustLtvTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanAdjustLtvResponse](Models/SapiV1LoanAdjustLtvResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CryptoLoanAdjustLtvTradeError](Errors/CryptoLoanAdjustLtvTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanBorrowResponse&gt; CryptoLoanBorrowTrade(CryptoLoanBorrowTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.CryptoLoanBorrowTrade(new CryptoLoanBorrowTradeRequest
    {
        LoanCoin = "BUSD",
        CollateralCoin = "BNB",
        LoanTerm = 30,
        Timestamp = 1L,
        Signature = "some example string",
        LoanAmount = 100.1d,
        CollateralAmount = 50.5d,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanBorrowResponse
}
catch (ApiException<CryptoLoanBorrowTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CryptoLoanBorrowTradeRequest](Requests/CryptoLoans/CryptoLoanBorrowTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanBorrowResponse](Models/SapiV1LoanBorrowResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CryptoLoanBorrowTradeError](Errors/CryptoLoanBorrowTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanCustomizeMarginCallResponse&gt; CryptoLoanCustomizeMarginCallTrade(CryptoLoanCustomizeMarginCallTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.CryptoLoanCustomizeMarginCallTrade(
        new CryptoLoanCustomizeMarginCallTradeRequest
        {
            MarginCall = 1.5d,
            Timestamp = 1L,
            Signature = "some example string",
            CollateralCoin = "BNB",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LoanCustomizeMarginCallResponse
}
catch (ApiException<CryptoLoanCustomizeMarginCallTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CryptoLoanCustomizeMarginCallTradeRequest](Requests/CryptoLoans/CryptoLoanCustomizeMarginCallTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanCustomizeMarginCallResponse](Models/SapiV1LoanCustomizeMarginCallResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CryptoLoanCustomizeMarginCallTradeError](Errors/CryptoLoanCustomizeMarginCallTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanRepayResponse&gt; CryptoLoanRepayTrade(CryptoLoanRepayTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.CryptoLoanRepayTrade(new CryptoLoanRepayTradeRequest
    {
        OrderId = 123456789L,
        Amount = 100.5d,
        Timestamp = 1L,
        Signature = "some example string",
        Type = 1,
        CollateralReturn = true,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanRepayResponse
}
catch (ApiException<CryptoLoanRepayTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CryptoLoanRepayTradeRequest](Requests/CryptoLoans/CryptoLoanRepayTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanRepayResponse](Models/AnyOf/SapiV1LoanRepayResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CryptoLoanRepayTradeError](Errors/CryptoLoanRepayTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanCollateralDataResponse&gt; GetCollateralAssetsDataUserData(GetCollateralAssetsDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.GetCollateralAssetsDataUserData(new GetCollateralAssetsDataUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        CollateralCoin = "BNB",
        VipLevel = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanCollateralDataResponse
}
catch (ApiException<GetCollateralAssetsDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCollateralAssetsDataUserDataRequest](Requests/CryptoLoans/GetCollateralAssetsDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanCollateralDataResponse](Models/SapiV1LoanCollateralDataResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCollateralAssetsDataUserDataError](Errors/GetCollateralAssetsDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanBorrowHistoryResponse&gt; GetCryptoLoansBorrowHistoryUserData(GetCryptoLoansBorrowHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.GetCryptoLoansBorrowHistoryUserData(
        new GetCryptoLoansBorrowHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            OrderId = 10L,
            LoanCoin = "BUSD",
            CollateralCoin = "BNB",
            Current = 1,
            Limit = 10L,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LoanBorrowHistoryResponse
}
catch (ApiException<GetCryptoLoansBorrowHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCryptoLoansBorrowHistoryUserDataRequest](Requests/CryptoLoans/GetCryptoLoansBorrowHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanBorrowHistoryResponse](Models/SapiV1LoanBorrowHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCryptoLoansBorrowHistoryUserDataError](Errors/GetCryptoLoansBorrowHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LoanIncomeResponse&gt;&gt; GetCryptoLoansIncomeHistoryUserData(GetCryptoLoansIncomeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.GetCryptoLoansIncomeHistoryUserData(
        new GetCryptoLoansIncomeHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Asset = "BNB",
            Limit = 20,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LoanIncomeResponse>
}
catch (ApiException<GetCryptoLoansIncomeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCryptoLoansIncomeHistoryUserDataRequest](Requests/CryptoLoans/GetCryptoLoansIncomeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LoanIncomeResponse](Models/SapiV1LoanIncomeResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCryptoLoansIncomeHistoryUserDataError](Errors/GetCryptoLoansIncomeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleLoanableDataResponse&gt; GetFlexibleLoanAssetsDataUserData(GetFlexibleLoanAssetsDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.GetFlexibleLoanAssetsDataUserData(
        new GetFlexibleLoanAssetsDataUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            LoanCoin = "BUSD",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2LoanFlexibleLoanableDataResponse
}
catch (ApiException<GetFlexibleLoanAssetsDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFlexibleLoanAssetsDataUserDataRequest](Requests/CryptoLoans/GetFlexibleLoanAssetsDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleLoanableDataResponse](Models/SapiV2LoanFlexibleLoanableDataResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFlexibleLoanAssetsDataUserDataError](Errors/GetFlexibleLoanAssetsDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleCollateralDataResponse&gt; GetFlexibleLoanCollateralAssetsDataUserData(GetFlexibleLoanCollateralAssetsDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.GetFlexibleLoanCollateralAssetsDataUserData(
        new GetFlexibleLoanCollateralAssetsDataUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            CollateralCoin = "BNB",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2LoanFlexibleCollateralDataResponse
}
catch (ApiException<GetFlexibleLoanCollateralAssetsDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFlexibleLoanCollateralAssetsDataUserDataRequest](Requests/CryptoLoans/GetFlexibleLoanCollateralAssetsDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleCollateralDataResponse](Models/SapiV2LoanFlexibleCollateralDataResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFlexibleLoanCollateralAssetsDataUserDataError](Errors/GetFlexibleLoanCollateralAssetsDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanLtvAdjustmentHistoryResponse&gt; GetLoanLtvAdjustmentHistoryUserData(GetLoanLtvAdjustmentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.GetLoanLtvAdjustmentHistoryUserData(
        new GetLoanLtvAdjustmentHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            OrderId = 10L,
            LoanCoin = "BUSD",
            CollateralCoin = "BNB",
            Current = 1,
            Limit = 10L,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LoanLtvAdjustmentHistoryResponse
}
catch (ApiException<GetLoanLtvAdjustmentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLoanLtvAdjustmentHistoryUserDataRequest](Requests/CryptoLoans/GetLoanLtvAdjustmentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanLtvAdjustmentHistoryResponse](Models/SapiV1LoanLtvAdjustmentHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLoanLtvAdjustmentHistoryUserDataError](Errors/GetLoanLtvAdjustmentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanOngoingOrdersResponse&gt; GetLoanOngoingOrdersUserData(GetLoanOngoingOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.GetLoanOngoingOrdersUserData(new GetLoanOngoingOrdersUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        OrderId = 10L,
        LoanCoin = "BUSD",
        CollateralCoin = "BNB",
        Current = 1,
        Limit = 10L,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanOngoingOrdersResponse
}
catch (ApiException<GetLoanOngoingOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLoanOngoingOrdersUserDataRequest](Requests/CryptoLoans/GetLoanOngoingOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanOngoingOrdersResponse](Models/SapiV1LoanOngoingOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLoanOngoingOrdersUserDataError](Errors/GetLoanOngoingOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanRepayHistoryResponse&gt; GetLoanRepaymentHistoryUserData(GetLoanRepaymentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.GetLoanRepaymentHistoryUserData(new GetLoanRepaymentHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        OrderId = 10L,
        LoanCoin = "BUSD",
        CollateralCoin = "BNB",
        Current = 1,
        Limit = 10L,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanRepayHistoryResponse
}
catch (ApiException<GetLoanRepaymentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLoanRepaymentHistoryUserDataRequest](Requests/CryptoLoans/GetLoanRepaymentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanRepayHistoryResponse](Models/SapiV1LoanRepayHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLoanRepaymentHistoryUserDataError](Errors/GetLoanRepaymentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanLoanableDataResponse&gt; GetLoanableAssetsDataUserData(GetLoanableAssetsDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.GetLoanableAssetsDataUserData(new GetLoanableAssetsDataUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        LoanCoin = "BUSD",
        VipLevel = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanLoanableDataResponse
}
catch (ApiException<GetLoanableAssetsDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLoanableAssetsDataUserDataRequest](Requests/CryptoLoans/GetLoanableAssetsDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanLoanableDataResponse](Models/SapiV1LoanLoanableDataResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLoanableAssetsDataUserDataError](Errors/GetLoanableAssetsDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleRepayResponse&gt; RepayFlexibleLoanRepayTrade(RepayFlexibleLoanRepayTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.RepayFlexibleLoanRepayTrade(new RepayFlexibleLoanRepayTradeRequest
    {
        RepayAmount = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        LoanCoin = "BUSD",
        CollateralCoin = "BNB",
        CollateralReturn = true,
        FullRepayment = true,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV2LoanFlexibleRepayResponse
}
catch (ApiException<RepayFlexibleLoanRepayTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RepayFlexibleLoanRepayTradeRequest](Requests/CryptoLoans/RepayFlexibleLoanRepayTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleRepayResponse](Models/SapiV2LoanFlexibleRepayResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RepayFlexibleLoanRepayTradeError](Errors/RepayFlexibleLoanRepayTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2LoanFlexibleRepayHistoryResponse&gt; RepayGetFlexibleLoanRepaymentHistoryUserData(RepayGetFlexibleLoanRepaymentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CryptoLoans.RepayGetFlexibleLoanRepaymentHistoryUserData(
        new RepayGetFlexibleLoanRepaymentHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            LoanCoin = "BUSD",
            CollateralCoin = "BNB",
            Current = 1,
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2LoanFlexibleRepayHistoryResponse
}
catch (ApiException<RepayGetFlexibleLoanRepaymentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RepayGetFlexibleLoanRepaymentHistoryUserDataRequest](Requests/CryptoLoans/RepayGetFlexibleLoanRepaymentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleRepayHistoryResponse](Models/SapiV2LoanFlexibleRepayHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RepayGetFlexibleLoanRepaymentHistoryUserDataError](Errors/RepayGetFlexibleLoanRepaymentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DualInvestment

> Source: [DualInvestment](Api/DualInvestment.cs)

<details>
<summary><code>Task&lt;SapiV1DciProductAutoCompoundEditStatusResponse&gt; ChangeAutoCompoundStatusUserData(ChangeAutoCompoundStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.DualInvestment.ChangeAutoCompoundStatusUserData(
        new ChangeAutoCompoundStatusUserDataRequest
        {
            PositionId = 1L,
            AutoCompoundPlan = AutoCompoundPlan.None,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1DciProductAutoCompoundEditStatusResponse
}
catch (ApiException<ChangeAutoCompoundStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangeAutoCompoundStatusUserDataRequest](Requests/DualInvestment/ChangeAutoCompoundStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductAutoCompoundEditStatusResponse](Models/SapiV1DciProductAutoCompoundEditStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ChangeAutoCompoundStatusUserDataError](Errors/ChangeAutoCompoundStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1DciProductAccountsResponse&gt; CheckDualInvestmentAccountsUserData(CheckDualInvestmentAccountsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.DualInvestment.CheckDualInvestmentAccountsUserData(
        new CheckDualInvestmentAccountsUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1DciProductAccountsResponse
}
catch (ApiException<CheckDualInvestmentAccountsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CheckDualInvestmentAccountsUserDataRequest](Requests/DualInvestment/CheckDualInvestmentAccountsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductAccountsResponse](Models/SapiV1DciProductAccountsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CheckDualInvestmentAccountsUserDataError](Errors/CheckDualInvestmentAccountsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1DciProductPositionsResponse&gt; GetDualInvestmentPositionsUserData(GetDualInvestmentPositionsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.DualInvestment.GetDualInvestmentPositionsUserData(
        new GetDualInvestmentPositionsUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1DciProductPositionsResponse
}
catch (ApiException<GetDualInvestmentPositionsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDualInvestmentPositionsUserDataRequest](Requests/DualInvestment/GetDualInvestmentPositionsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductPositionsResponse](Models/SapiV1DciProductPositionsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDualInvestmentPositionsUserDataError](Errors/GetDualInvestmentPositionsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1DciProductListResponse&gt; GetDualInvestmentProductListUserData(GetDualInvestmentProductListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.DualInvestment.GetDualInvestmentProductListUserData(
        new GetDualInvestmentProductListUserDataRequest
        {
            OptionType = OptionType.Call,
            ExercisedCoin = "some example string",
            InvestCoin = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1DciProductListResponse
}
catch (ApiException<GetDualInvestmentProductListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDualInvestmentProductListUserDataRequest](Requests/DualInvestment/GetDualInvestmentProductListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductListResponse](Models/SapiV1DciProductListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDualInvestmentProductListUserDataError](Errors/GetDualInvestmentProductListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1DciProductSubscribeResponse&gt; SubscribeDualInvestmentProductsUserData(SubscribeDualInvestmentProductsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.DualInvestment.SubscribeDualInvestmentProductsUserData(
        new SubscribeDualInvestmentProductsUserDataRequest
        {
            Id = "some example string",
            OrderId = "some example string",
            DepositAmount = 1.5d,
            AutoCompoundPlan = AutoCompoundPlan.None,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1DciProductSubscribeResponse
}
catch (ApiException<SubscribeDualInvestmentProductsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubscribeDualInvestmentProductsUserDataRequest](Requests/DualInvestment/SubscribeDualInvestmentProductsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductSubscribeResponse](Models/SapiV1DciProductSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubscribeDualInvestmentProductsUserDataError](Errors/SubscribeDualInvestmentProductsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Fiat

> Source: [Fiat](Api/Fiat.cs)

<details>
<summary><code>Task&lt;SapiV1FiatOrdersResponse&gt; FiatDepositWithdrawHistoryUserData(FiatDepositWithdrawHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Fiat.FiatDepositWithdrawHistoryUserData(new FiatDepositWithdrawHistoryUserDataRequest
    {
        TransactionType = 1,
        Timestamp = 1L,
        Signature = "some example string",
        BeginTime = 1626144956000L,
        Page = 1,
        Rows = 300,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1FiatOrdersResponse
}
catch (ApiException<FiatDepositWithdrawHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FiatDepositWithdrawHistoryUserDataRequest](Requests/Fiat/FiatDepositWithdrawHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FiatOrdersResponse](Models/SapiV1FiatOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FiatDepositWithdrawHistoryUserDataError](Errors/FiatDepositWithdrawHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1FiatPaymentsResponse&gt; FiatPaymentsHistoryUserData(FiatPaymentsHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Fiat.FiatPaymentsHistoryUserData(new FiatPaymentsHistoryUserDataRequest
    {
        TransactionType = 1,
        Timestamp = 1L,
        Signature = "some example string",
        BeginTime = 1626144956000L,
        Page = 1,
        Rows = 300,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1FiatPaymentsResponse
}
catch (ApiException<FiatPaymentsHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FiatPaymentsHistoryUserDataRequest](Requests/Fiat/FiatPaymentsHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FiatPaymentsResponse](Models/SapiV1FiatPaymentsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FiatPaymentsHistoryUserDataError](Errors/FiatPaymentsHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Futures

> Source: [Futures](Api/Futures.cs)

<details>
<summary><code>Task&lt;SapiV1FuturesTransferResponse1&gt; GetFutureAccountTransactionHistoryListUserData(GetFutureAccountTransactionHistoryListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Futures.GetFutureAccountTransactionHistoryListUserData(
        new GetFutureAccountTransactionHistoryListUserDataRequest
        {
            Asset = "BTC",
            StartTime = 1L,
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1FuturesTransferResponse1
}
catch (ApiException<GetFutureAccountTransactionHistoryListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFutureAccountTransactionHistoryListUserDataRequest](Requests/Futures/GetFutureAccountTransactionHistoryListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FuturesTransferResponse1](Models/SapiV1FuturesTransferResponse1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFutureAccountTransactionHistoryListUserDataError](Errors/GetFutureAccountTransactionHistoryListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1FuturesHistDataLinkResponse&gt; GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData(GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Futures.GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData(
        new GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest
        {
            Symbol = "BTCUSDT",
            DataType = DataTypeEnum.TDepth,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1FuturesHistDataLinkResponse
}
catch (ApiException<GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest](Requests/Futures/GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FuturesHistDataLinkResponse](Models/SapiV1FuturesHistDataLinkResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError](Errors/GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1FuturesTransferResponse&gt; NewFutureAccountTransferUserData(NewFutureAccountTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Futures.NewFutureAccountTransferUserData(new NewFutureAccountTransferUserDataRequest
    {
        Asset = "BTC",
        Amount = 1.01d,
        Type = 1L,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1FuturesTransferResponse
}
catch (ApiException<NewFutureAccountTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NewFutureAccountTransferUserDataRequest](Requests/Futures/NewFutureAccountTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FuturesTransferResponse](Models/SapiV1FuturesTransferResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[NewFutureAccountTransferUserDataError](Errors/NewFutureAccountTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FuturesAlgo

> Source: [FuturesAlgo](Api/FuturesAlgo.cs)

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesOrderResponse&gt; CancelAlgoOrderTrade(CancelAlgoOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FuturesAlgo.CancelAlgoOrderTrade(new CancelAlgoOrderTradeRequest
    {
        AlgoId = 1L,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AlgoFuturesOrderResponse
}
catch (ApiException<CancelAlgoOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelAlgoOrderTradeRequest](Requests/FuturesAlgo/CancelAlgoOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesOrderResponse](Models/SapiV1AlgoFuturesOrderResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelAlgoOrderTradeError](Errors/CancelAlgoOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesOpenOrdersResponse&gt; QueryCurrentAlgoOpenOrdersUserData(QueryCurrentAlgoOpenOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FuturesAlgo.QueryCurrentAlgoOpenOrdersUserData(
        new QueryCurrentAlgoOpenOrdersUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1AlgoFuturesOpenOrdersResponse
}
catch (ApiException<QueryCurrentAlgoOpenOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryCurrentAlgoOpenOrdersUserDataRequest](Requests/FuturesAlgo/QueryCurrentAlgoOpenOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesOpenOrdersResponse](Models/SapiV1AlgoFuturesOpenOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryCurrentAlgoOpenOrdersUserDataError](Errors/QueryCurrentAlgoOpenOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesHistoricalOrdersResponse&gt; QueryHistoricalAlgoOrdersUserData(QueryHistoricalAlgoOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FuturesAlgo.QueryHistoricalAlgoOrdersUserData(
        new QueryHistoricalAlgoOrdersUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Symbol = "BNBUSDT",
            Side = Side.Sell,
            Page = 1,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1AlgoFuturesHistoricalOrdersResponse
}
catch (ApiException<QueryHistoricalAlgoOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryHistoricalAlgoOrdersUserDataRequest](Requests/FuturesAlgo/QueryHistoricalAlgoOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesHistoricalOrdersResponse](Models/SapiV1AlgoFuturesHistoricalOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryHistoricalAlgoOrdersUserDataError](Errors/QueryHistoricalAlgoOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesSubOrdersResponse&gt; QuerySubOrdersUserData(QuerySubOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FuturesAlgo.QuerySubOrdersUserData(new QuerySubOrdersUserDataRequest
    {
        AlgoId = 1L,
        Timestamp = 1L,
        Signature = "some example string",
        Page = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AlgoFuturesSubOrdersResponse
}
catch (ApiException<QuerySubOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QuerySubOrdersUserDataRequest](Requests/FuturesAlgo/QuerySubOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesSubOrdersResponse](Models/SapiV1AlgoFuturesSubOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QuerySubOrdersUserDataError](Errors/QuerySubOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesNewOrderTwapResponse&gt; TimeWeightedAveragePriceTwapNewOrderTrade(TimeWeightedAveragePriceTwapNewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FuturesAlgo.TimeWeightedAveragePriceTwapNewOrderTrade(
        new TimeWeightedAveragePriceTwapNewOrderTradeRequest
        {
            Symbol = "BNBUSDT",
            Side = Side.Sell,
            Quantity = 1.5d,
            Duration = 300L,
            Timestamp = 1L,
            Signature = "some example string",
            PositionSide = PositionSide.Both,
            ClientAlgoId = "00358ce6a268403398bd34eaa36dffe7",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1AlgoFuturesNewOrderTwapResponse
}
catch (ApiException<TimeWeightedAveragePriceTwapNewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TimeWeightedAveragePriceTwapNewOrderTradeRequest](Requests/FuturesAlgo/TimeWeightedAveragePriceTwapNewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesNewOrderTwapResponse](Models/SapiV1AlgoFuturesNewOrderTwapResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TimeWeightedAveragePriceTwapNewOrderTradeError](Errors/TimeWeightedAveragePriceTwapNewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoFuturesNewOrderVpResponse&gt; VolumeParticipationVpNewOrderTrade(VolumeParticipationVpNewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FuturesAlgo.VolumeParticipationVpNewOrderTrade(
        new VolumeParticipationVpNewOrderTradeRequest
        {
            Symbol = "BNBUSDT",
            Side = Side.Sell,
            Quantity = 1.5d,
            Urgency = Urgency.Low,
            Timestamp = 1L,
            Signature = "some example string",
            PositionSide = PositionSide.Both,
            ClientAlgoId = "00358ce6a268403398bd34eaa36dffe7",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1AlgoFuturesNewOrderVpResponse
}
catch (ApiException<VolumeParticipationVpNewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeParticipationVpNewOrderTradeRequest](Requests/FuturesAlgo/VolumeParticipationVpNewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesNewOrderVpResponse](Models/SapiV1AlgoFuturesNewOrderVpResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[VolumeParticipationVpNewOrderTradeError](Errors/VolumeParticipationVpNewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GiftCard

> Source: [GiftCard](Api/GiftCard.cs)

<details>
<summary><code>Task&lt;SapiV1GiftcardBuyCodeResponse&gt; BuyABinanceCodeTrade(BuyABinanceCodeTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.GiftCard.BuyABinanceCodeTrade(new BuyABinanceCodeTradeRequest
    {
        BaseToken = "some example string",
        FaceToken = "some example string",
        BaseTokenAmount = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1GiftcardBuyCodeResponse
}
catch (ApiException<BuyABinanceCodeTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BuyABinanceCodeTradeRequest](Requests/GiftCard/BuyABinanceCodeTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardBuyCodeResponse](Models/SapiV1GiftcardBuyCodeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[BuyABinanceCodeTradeError](Errors/BuyABinanceCodeTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardCreateCodeResponse&gt; CreateABinanceCodeUserData(CreateABinanceCodeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.GiftCard.CreateABinanceCodeUserData(new CreateABinanceCodeUserDataRequest
    {
        Token = "some example string",
        Amount = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1GiftcardCreateCodeResponse
}
catch (ApiException<CreateABinanceCodeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateABinanceCodeUserDataRequest](Requests/GiftCard/CreateABinanceCodeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardCreateCodeResponse](Models/SapiV1GiftcardCreateCodeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateABinanceCodeUserDataError](Errors/CreateABinanceCodeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardCryptographyRsaPublicKeyResponse&gt; FetchRsaPublicKeyUserData(FetchRsaPublicKeyUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.GiftCard.FetchRsaPublicKeyUserData(new FetchRsaPublicKeyUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1GiftcardCryptographyRsaPublicKeyResponse
}
catch (ApiException<FetchRsaPublicKeyUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FetchRsaPublicKeyUserDataRequest](Requests/GiftCard/FetchRsaPublicKeyUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardCryptographyRsaPublicKeyResponse](Models/SapiV1GiftcardCryptographyRsaPublicKeyResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FetchRsaPublicKeyUserDataError](Errors/FetchRsaPublicKeyUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardBuyCodeTokenLimitResponse&gt; FetchTokenLimitUserData(FetchTokenLimitUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.GiftCard.FetchTokenLimitUserData(new FetchTokenLimitUserDataRequest
    {
        BaseToken = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1GiftcardBuyCodeTokenLimitResponse
}
catch (ApiException<FetchTokenLimitUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FetchTokenLimitUserDataRequest](Requests/GiftCard/FetchTokenLimitUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardBuyCodeTokenLimitResponse](Models/SapiV1GiftcardBuyCodeTokenLimitResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FetchTokenLimitUserDataError](Errors/FetchTokenLimitUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardRedeemCodeResponse&gt; RedeemABinanceCodeUserData(RedeemABinanceCodeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.GiftCard.RedeemABinanceCodeUserData(new RedeemABinanceCodeUserDataRequest
    {
        Code = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1GiftcardRedeemCodeResponse
}
catch (ApiException<RedeemABinanceCodeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RedeemABinanceCodeUserDataRequest](Requests/GiftCard/RedeemABinanceCodeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardRedeemCodeResponse](Models/SapiV1GiftcardRedeemCodeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RedeemABinanceCodeUserDataError](Errors/RedeemABinanceCodeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1GiftcardVerifyResponse&gt; VerifyABinanceCodeUserData(VerifyABinanceCodeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.GiftCard.VerifyABinanceCodeUserData(new VerifyABinanceCodeUserDataRequest
    {
        ReferenceNo = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1GiftcardVerifyResponse
}
catch (ApiException<VerifyABinanceCodeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VerifyABinanceCodeUserDataRequest](Requests/GiftCard/VerifyABinanceCodeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardVerifyResponse](Models/SapiV1GiftcardVerifyResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[VerifyABinanceCodeUserDataError](Errors/VerifyABinanceCodeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IsolatedMarginStream

> Source: [IsolatedMarginStream](Api/IsolatedMarginStream.cs)

<details>
<summary><code>Task&lt;object&gt; CloseAListenKeyUserStream3(CloseAListenKeyUserStream3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.IsolatedMarginStream.CloseAListenKeyUserStream3(new CloseAListenKeyUserStream3Request
    {
        ListenKey = "pqia91ma19a5s61cv6a81va65sdf19v8a65a1a5s61cv6a81va65sdf19v8a65a1",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<CloseAListenKeyUserStream3Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CloseAListenKeyUserStream3Request](Requests/IsolatedMarginStream/CloseAListenKeyUserStream3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CloseAListenKeyUserStream3Error](Errors/CloseAListenKeyUserStream3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1UserDataStreamIsolatedResponse&gt; GenerateAListenKeyUserStream(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; PingKeepAliveAListenKeyUserStream(PingKeepAliveAListenKeyUserStreamOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.IsolatedMarginStream.PingKeepAliveAListenKeyUserStream(
        new PingKeepAliveAListenKeyUserStreamOperationRequest
        {
            ListenKey = "pqia91ma19a5s61cv6a81va65sdf19v8a65a1a5s61cv6a81va65sdf19v8a65a1",
        });
    // TODO: Handle 'response' of type object
}
catch (ApiException<PingKeepAliveAListenKeyUserStreamApiError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PingKeepAliveAListenKeyUserStreamOperationRequest](Requests/IsolatedMarginStream/PingKeepAliveAListenKeyUserStreamOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PingKeepAliveAListenKeyUserStreamApiError](Errors/PingKeepAliveAListenKeyUserStreamApiError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Margin

> Source: [Margin](Api/Margin.cs)

<details>
<summary><code>Task&lt;SapiV1MarginMaxLeverageResponse&gt; AdjustCrossMarginMaxLeverageUserData(AdjustCrossMarginMaxLeverageUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.AdjustCrossMarginMaxLeverageUserData(
        new AdjustCrossMarginMaxLeverageUserDataRequest
        {
            MaxLeverage = 3,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1MarginMaxLeverageResponse
}
catch (ApiException<AdjustCrossMarginMaxLeverageUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdjustCrossMarginMaxLeverageUserDataRequest](Requests/Margin/AdjustCrossMarginMaxLeverageUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginMaxLeverageResponse](Models/SapiV1MarginMaxLeverageResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AdjustCrossMarginMaxLeverageUserDataError](Errors/AdjustCrossMarginMaxLeverageUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginCrossMarginCollateralRatioResponse&gt;&gt; CrossMarginCollateralRatioMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<CrossMarginCollateralRatioMarketDataError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CrossMarginCollateralRatioMarketDataError](Errors/CrossMarginCollateralRatioMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginIsolatedAccountResponse&gt; DisableIsolatedMarginAccountTrade(DisableIsolatedMarginAccountTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.DisableIsolatedMarginAccountTrade(new DisableIsolatedMarginAccountTradeRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginIsolatedAccountResponse
}
catch (ApiException<DisableIsolatedMarginAccountTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DisableIsolatedMarginAccountTradeRequest](Requests/Margin/DisableIsolatedMarginAccountTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginIsolatedAccountResponse](Models/SapiV1MarginIsolatedAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DisableIsolatedMarginAccountTradeError](Errors/DisableIsolatedMarginAccountTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginIsolatedAccountResponse&gt; EnableIsolatedMarginAccountTrade(EnableIsolatedMarginAccountTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.EnableIsolatedMarginAccountTrade(new EnableIsolatedMarginAccountTradeRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginIsolatedAccountResponse
}
catch (ApiException<EnableIsolatedMarginAccountTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableIsolatedMarginAccountTradeRequest](Requests/Margin/EnableIsolatedMarginAccountTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginIsolatedAccountResponse](Models/SapiV1MarginIsolatedAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EnableIsolatedMarginAccountTradeError](Errors/EnableIsolatedMarginAccountTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginAllPairsResponse&gt;&gt; GetAllCrossMarginPairsMarketData(GetAllCrossMarginPairsMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetAllCrossMarginPairsMarketData(new GetAllCrossMarginPairsMarketDataRequest
    {
        Symbol = "BNBUSDT",
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginAllPairsResponse>
}
catch (ApiException<GetAllCrossMarginPairsMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAllCrossMarginPairsMarketDataRequest](Requests/Margin/GetAllCrossMarginPairsMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginAllPairsResponse](Models/SapiV1MarginAllPairsResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAllCrossMarginPairsMarketDataError](Errors/GetAllCrossMarginPairsMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginIsolatedAllPairsResponse&gt;&gt; GetAllIsolatedMarginSymbolUserData(GetAllIsolatedMarginSymbolUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetAllIsolatedMarginSymbolUserData(new GetAllIsolatedMarginSymbolUserDataRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginIsolatedAllPairsResponse>
}
catch (ApiException<GetAllIsolatedMarginSymbolUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAllIsolatedMarginSymbolUserDataRequest](Requests/Margin/GetAllIsolatedMarginSymbolUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginIsolatedAllPairsResponse](Models/SapiV1MarginIsolatedAllPairsResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAllIsolatedMarginSymbolUserDataError](Errors/GetAllIsolatedMarginSymbolUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginAllAssetsResponse&gt;&gt; GetAllMarginAssetsMarketData(GetAllMarginAssetsMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetAllMarginAssetsMarketData(new GetAllMarginAssetsMarketDataRequest
    {
        Asset = "BTC",
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginAllAssetsResponse>
}
catch (ApiException<GetAllMarginAssetsMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAllMarginAssetsMarketDataRequest](Requests/Margin/GetAllMarginAssetsMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginAllAssetsResponse](Models/SapiV1MarginAllAssetsResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAllMarginAssetsMarketDataError](Errors/GetAllMarginAssetsMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BnbBurnStatus&gt; GetBnbBurnStatusUserData(GetBnbBurnStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetBnbBurnStatusUserData(new GetBnbBurnStatusUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type BnbBurnStatus
}
catch (ApiException<GetBnbBurnStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBnbBurnStatusUserDataRequest](Requests/Margin/GetBnbBurnStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BnbBurnStatus](Models/BnbBurnStatus.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetBnbBurnStatusUserDataError](Errors/GetBnbBurnStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginTransferResponse&gt; GetCrossMarginTransferHistoryUserData(GetCrossMarginTransferHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetCrossMarginTransferHistoryUserData(
        new GetCrossMarginTransferHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Asset = "BNB",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1MarginTransferResponse
}
catch (ApiException<GetCrossMarginTransferHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCrossMarginTransferHistoryUserDataRequest](Requests/Margin/GetCrossMarginTransferHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginTransferResponse](Models/SapiV1MarginTransferResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCrossMarginTransferHistoryUserDataError](Errors/GetCrossMarginTransferHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginForceLiquidationRecResponse&gt; GetForceLiquidationRecordUserData(GetForceLiquidationRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetForceLiquidationRecordUserData(new GetForceLiquidationRecordUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginForceLiquidationRecResponse
}
catch (ApiException<GetForceLiquidationRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetForceLiquidationRecordUserDataRequest](Requests/Margin/GetForceLiquidationRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginForceLiquidationRecResponse](Models/SapiV1MarginForceLiquidationRecResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetForceLiquidationRecordUserDataError](Errors/GetForceLiquidationRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginInterestHistoryResponse&gt; GetInterestHistoryUserData(GetInterestHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetInterestHistoryUserData(new GetInterestHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Asset = "BNB",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginInterestHistoryResponse
}
catch (ApiException<GetInterestHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInterestHistoryUserDataRequest](Requests/Margin/GetInterestHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginInterestHistoryResponse](Models/SapiV1MarginInterestHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInterestHistoryUserDataError](Errors/GetInterestHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginExchangeSmallLiabilityResponse&gt;&gt; GetSmallLiabilityExchangeCoinListUserData(GetSmallLiabilityExchangeCoinListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetSmallLiabilityExchangeCoinListUserData(
        new GetSmallLiabilityExchangeCoinListUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginExchangeSmallLiabilityResponse>
}
catch (ApiException<GetSmallLiabilityExchangeCoinListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSmallLiabilityExchangeCoinListUserDataRequest](Requests/Margin/GetSmallLiabilityExchangeCoinListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginExchangeSmallLiabilityResponse](Models/SapiV1MarginExchangeSmallLiabilityResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSmallLiabilityExchangeCoinListUserDataError](Errors/GetSmallLiabilityExchangeCoinListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginExchangeSmallLiabilityHistoryResponse&gt; GetSmallLiabilityExchangeHistoryUserData(GetSmallLiabilityExchangeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetSmallLiabilityExchangeHistoryUserData(
        new GetSmallLiabilityExchangeHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1MarginExchangeSmallLiabilityHistoryResponse
}
catch (ApiException<GetSmallLiabilityExchangeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSmallLiabilityExchangeHistoryUserDataRequest](Requests/Margin/GetSmallLiabilityExchangeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginExchangeSmallLiabilityHistoryResponse](Models/SapiV1MarginExchangeSmallLiabilityHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSmallLiabilityExchangeHistoryUserDataError](Errors/GetSmallLiabilityExchangeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginTradeCoeffResponse&gt; GetSummaryOfMarginAccountUserData(GetSummaryOfMarginAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetSummaryOfMarginAccountUserData(new GetSummaryOfMarginAccountUserDataRequest
    {
        Email = "me@email.com",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginTradeCoeffResponse
}
catch (ApiException<GetSummaryOfMarginAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSummaryOfMarginAccountUserDataRequest](Requests/Margin/GetSummaryOfMarginAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginTradeCoeffResponse](Models/SapiV1MarginTradeCoeffResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSummaryOfMarginAccountUserDataError](Errors/GetSummaryOfMarginAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginNextHourlyInterestRateResponse&gt;&gt; GetAFutureHourlyInterestRateUserData(GetAFutureHourlyInterestRateUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetAFutureHourlyInterestRateUserData(
        new GetAFutureHourlyInterestRateUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Assets = "BTC,ETH",
            IsIsolated = IsIsolated.True,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginNextHourlyInterestRateResponse>
}
catch (ApiException<GetAFutureHourlyInterestRateUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAFutureHourlyInterestRateUserDataRequest](Requests/Margin/GetAFutureHourlyInterestRateUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginNextHourlyInterestRateResponse](Models/SapiV1MarginNextHourlyInterestRateResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAFutureHourlyInterestRateUserDataError](Errors/GetAFutureHourlyInterestRateUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginCapitalFlowResponse&gt;&gt; GetCrossOrIsolatedMarginCapitalFlowUserData(GetCrossOrIsolatedMarginCapitalFlowUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetCrossOrIsolatedMarginCapitalFlowUserData(
        new GetCrossOrIsolatedMarginCapitalFlowUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Asset = "BNB",
            Symbol = "BTCUSDT",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginCapitalFlowResponse>
}
catch (ApiException<GetCrossOrIsolatedMarginCapitalFlowUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCrossOrIsolatedMarginCapitalFlowUserDataRequest](Requests/Margin/GetCrossOrIsolatedMarginCapitalFlowUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginCapitalFlowResponse](Models/SapiV1MarginCapitalFlowResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCrossOrIsolatedMarginCapitalFlowUserDataError](Errors/GetCrossOrIsolatedMarginCapitalFlowUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginDelistScheduleResponse&gt;&gt; GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData(GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData(
        new GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginDelistScheduleResponse>
}
catch (ApiException<GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest](Requests/Margin/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginDelistScheduleResponse](Models/SapiV1MarginDelistScheduleResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError](Errors/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MarginOcoOrder&gt; MarginAccountCancelOcoTrade(MarginAccountCancelOcoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginAccountCancelOcoTrade(new MarginAccountCancelOcoTradeRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type MarginOcoOrder
}
catch (ApiException<MarginAccountCancelOcoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginAccountCancelOcoTradeRequest](Requests/Margin/MarginAccountCancelOcoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MarginOcoOrder](Models/MarginOcoOrder.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginAccountCancelOcoTradeError](Errors/MarginAccountCancelOcoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MarginOrder&gt; MarginAccountCancelOrderTrade(MarginAccountCancelOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginAccountCancelOrderTrade(new MarginAccountCancelOrderTradeRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type MarginOrder
}
catch (ApiException<MarginAccountCancelOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginAccountCancelOrderTradeRequest](Requests/Margin/MarginAccountCancelOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MarginOrder](Models/MarginOrder.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginAccountCancelOrderTradeError](Errors/MarginAccountCancelOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginOpenOrdersResponse&gt;&gt; MarginAccountCancelAllOpenOrdersOnASymbolTrade(MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginAccountCancelAllOpenOrdersOnASymbolTrade(
        new MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest
        {
            Symbol = "BNBUSDT",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginOpenOrdersResponse>
}
catch (ApiException<MarginAccountCancelAllOpenOrdersOnASymbolTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest](Requests/Margin/MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginOpenOrdersResponse](Models/AnyOf/SapiV1MarginOpenOrdersResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginAccountCancelAllOpenOrdersOnASymbolTradeError](Errors/MarginAccountCancelAllOpenOrdersOnASymbolTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderOcoResponse&gt; MarginAccountNewOcoTrade(MarginAccountNewOcoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginAccountNewOcoTrade(new MarginAccountNewOcoTradeRequest
    {
        Symbol = "BNBUSDT",
        Side = Side.Sell,
        Quantity = 1d,
        Price = 218d,
        StopPrice = 220d,
        Timestamp = 1L,
        Signature = "some example string",
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginOrderOcoResponse
}
catch (ApiException<MarginAccountNewOcoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginAccountNewOcoTradeRequest](Requests/Margin/MarginAccountNewOcoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderOcoResponse](Models/SapiV1MarginOrderOcoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginAccountNewOcoTradeError](Errors/MarginAccountNewOcoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderOtoResponse&gt; MarginAccountNewOtoTrade(MarginAccountNewOtoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginAccountNewOtoTrade(new MarginAccountNewOtoTradeRequest
    {
        Symbol = "BNBUSDT",
        WorkingType = WorkingType.Limit,
        WorkingSide = WorkingSide.Buy,
        WorkingPrice = 1.5d,
        WorkingQuantity = 1.5d,
        WorkingIcebergQty = 1.5d,
        PendingType = PendingType.Limit,
        PendingSide = PendingSide.Buy,
        PendingQuantity = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
        AutoRepayAtCancel = true,
    });
    // TODO: Handle 'response' of type SapiV1MarginOrderOtoResponse
}
catch (ApiException<MarginAccountNewOtoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginAccountNewOtoTradeRequest](Requests/Margin/MarginAccountNewOtoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderOtoResponse](Models/SapiV1MarginOrderOtoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginAccountNewOtoTradeError](Errors/MarginAccountNewOtoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderOtocoResponse&gt; MarginAccountNewOtocoTrade(MarginAccountNewOtocoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginAccountNewOtocoTrade(new MarginAccountNewOtocoTradeRequest
    {
        Symbol = "BNBUSDT",
        WorkingType = WorkingType.Limit,
        WorkingSide = WorkingSide.Buy,
        WorkingPrice = 1.5d,
        WorkingQuantity = 1.5d,
        WorkingIcebergQty = 1.5d,
        PendingSide = PendingSide.Buy,
        PendingQuantity = 1.5d,
        PendingAboveType = PendingAboveType.LimitMaker,
        Timestamp = 1L,
        Signature = "some example string",
        AutoRepayAtCancel = true,
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
    });
    // TODO: Handle 'response' of type SapiV1MarginOrderOtocoResponse
}
catch (ApiException<MarginAccountNewOtocoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginAccountNewOtocoTradeRequest](Requests/Margin/MarginAccountNewOtocoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderOtocoResponse](Models/SapiV1MarginOrderOtocoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginAccountNewOtocoTradeError](Errors/MarginAccountNewOtocoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderResponse&gt; MarginAccountNewOrderTrade(MarginAccountNewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginAccountNewOrderTrade(new MarginAccountNewOrderTradeRequest
    {
        Symbol = "BNBUSDT",
        Side = Side.Sell,
        Type = Type1.Limit,
        Quantity = 1d,
        AutoRepayAtCancel = true,
        Timestamp = 1L,
        Signature = "some example string",
        Price = 219d,
        StopPrice = 221.01d,
        TimeInForce = TimeInForce.Gtc,
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginOrderResponse
}
catch (ApiException<MarginAccountNewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginAccountNewOrderTradeRequest](Requests/Margin/MarginAccountNewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderResponse](Models/AnyOf/SapiV1MarginOrderResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginAccountNewOrderTradeError](Errors/MarginAccountNewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginInterestRateHistoryResponse&gt;&gt; MarginInterestRateHistoryUserData(MarginInterestRateHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginInterestRateHistoryUserData(new MarginInterestRateHistoryUserDataRequest
    {
        Asset = "BTC",
        Timestamp = 1L,
        Signature = "some example string",
        VipLevel = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginInterestRateHistoryResponse>
}
catch (ApiException<MarginInterestRateHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginInterestRateHistoryUserDataRequest](Requests/Margin/MarginInterestRateHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginInterestRateHistoryResponse](Models/SapiV1MarginInterestRateHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginInterestRateHistoryUserDataError](Errors/MarginInterestRateHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginBorrowRepayResponse&gt; MarginAccountBorrowRepayMargin(MarginAccountBorrowRepayMarginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginAccountBorrowRepayMargin(new MarginAccountBorrowRepayMarginRequest
    {
        Asset = "BTC",
        IsIsolated = "some example string",
        Symbol = "BNBUSDT",
        Amount = 1.01d,
        Type = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginBorrowRepayResponse
}
catch (ApiException<MarginAccountBorrowRepayMarginError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginAccountBorrowRepayMarginRequest](Requests/Margin/MarginAccountBorrowRepayMarginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginBorrowRepayResponse](Models/SapiV1MarginBorrowRepayResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginAccountBorrowRepayMarginError](Errors/MarginAccountBorrowRepayMarginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginManualLiquidationResponse&gt;&gt; MarginManualLiquidationMargin(MarginManualLiquidationMarginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.MarginManualLiquidationMargin(new MarginManualLiquidationMarginRequest
    {
        Type = Type4.Margin,
        Timestamp = 1L,
        Signature = "some example string",
        Symbol = "BTCUSDT",
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginManualLiquidationResponse>
}
catch (ApiException<MarginManualLiquidationMarginError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginManualLiquidationMarginRequest](Requests/Margin/MarginManualLiquidationMarginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginManualLiquidationResponse](Models/SapiV1MarginManualLiquidationResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginManualLiquidationMarginError](Errors/MarginManualLiquidationMarginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginAccountResponse&gt; QueryCrossMarginAccountDetailsUserData(QueryCrossMarginAccountDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryCrossMarginAccountDetailsUserData(
        new QueryCrossMarginAccountDetailsUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1MarginAccountResponse
}
catch (ApiException<QueryCrossMarginAccountDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryCrossMarginAccountDetailsUserDataRequest](Requests/Margin/QueryCrossMarginAccountDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginAccountResponse](Models/SapiV1MarginAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryCrossMarginAccountDetailsUserDataError](Errors/QueryCrossMarginAccountDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginCrossMarginDataResponse&gt;&gt; QueryCrossMarginFeeDataUserData(QueryCrossMarginFeeDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryCrossMarginFeeDataUserData(new QueryCrossMarginFeeDataUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        VipLevel = 1,
        Coin = "BNB",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginCrossMarginDataResponse>
}
catch (ApiException<QueryCrossMarginFeeDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryCrossMarginFeeDataUserDataRequest](Requests/Margin/QueryCrossMarginFeeDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginCrossMarginDataResponse](Models/SapiV1MarginCrossMarginDataResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryCrossMarginFeeDataUserDataError](Errors/QueryCrossMarginFeeDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginRateLimitOrderResponse&gt;&gt; QueryCurrentMarginOrderCountUsageTrade(QueryCurrentMarginOrderCountUsageTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryCurrentMarginOrderCountUsageTrade(
        new QueryCurrentMarginOrderCountUsageTradeRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginRateLimitOrderResponse>
}
catch (ApiException<QueryCurrentMarginOrderCountUsageTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryCurrentMarginOrderCountUsageTradeRequest](Requests/Margin/QueryCurrentMarginOrderCountUsageTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginRateLimitOrderResponse](Models/SapiV1MarginRateLimitOrderResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryCurrentMarginOrderCountUsageTradeError](Errors/QueryCurrentMarginOrderCountUsageTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginIsolatedAccountLimitResponse&gt; QueryEnabledIsolatedMarginAccountLimitUserData(QueryEnabledIsolatedMarginAccountLimitUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryEnabledIsolatedMarginAccountLimitUserData(
        new QueryEnabledIsolatedMarginAccountLimitUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1MarginIsolatedAccountLimitResponse
}
catch (ApiException<QueryEnabledIsolatedMarginAccountLimitUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryEnabledIsolatedMarginAccountLimitUserDataRequest](Requests/Margin/QueryEnabledIsolatedMarginAccountLimitUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginIsolatedAccountLimitResponse](Models/SapiV1MarginIsolatedAccountLimitResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryEnabledIsolatedMarginAccountLimitUserDataError](Errors/QueryEnabledIsolatedMarginAccountLimitUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IsolatedMarginAccountInfo&gt; QueryIsolatedMarginAccountInfoUserData(QueryIsolatedMarginAccountInfoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryIsolatedMarginAccountInfoUserData(
        new QueryIsolatedMarginAccountInfoUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Symbols = "BTCUSDT,BNBUSDT,ADAUSDT",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IsolatedMarginAccountInfo
}
catch (ApiException<QueryIsolatedMarginAccountInfoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryIsolatedMarginAccountInfoUserDataRequest](Requests/Margin/QueryIsolatedMarginAccountInfoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IsolatedMarginAccountInfo](Models/IsolatedMarginAccountInfo.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryIsolatedMarginAccountInfoUserDataError](Errors/QueryIsolatedMarginAccountInfoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginIsolatedMarginDataResponse&gt;&gt; QueryIsolatedMarginFeeDataUserData(QueryIsolatedMarginFeeDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryIsolatedMarginFeeDataUserData(new QueryIsolatedMarginFeeDataUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        VipLevel = 1,
        Symbol = "BNBUSDT",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginIsolatedMarginDataResponse>
}
catch (ApiException<QueryIsolatedMarginFeeDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryIsolatedMarginFeeDataUserDataRequest](Requests/Margin/QueryIsolatedMarginFeeDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginIsolatedMarginDataResponse](Models/SapiV1MarginIsolatedMarginDataResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryIsolatedMarginFeeDataUserDataError](Errors/QueryIsolatedMarginFeeDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginIsolatedMarginTierResponse&gt;&gt; QueryIsolatedMarginTierDataUserData(QueryIsolatedMarginTierDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryIsolatedMarginTierDataUserData(
        new QueryIsolatedMarginTierDataUserDataRequest
        {
            Symbol = "BNBUSDT",
            Timestamp = 1L,
            Signature = "some example string",
            Tier = "1",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginIsolatedMarginTierResponse>
}
catch (ApiException<QueryIsolatedMarginTierDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryIsolatedMarginTierDataUserDataRequest](Requests/Margin/QueryIsolatedMarginTierDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginIsolatedMarginTierResponse](Models/SapiV1MarginIsolatedMarginTierResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryIsolatedMarginTierDataUserDataError](Errors/QueryIsolatedMarginTierDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginLeverageBracketResponse&gt;&gt; QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError](Errors/QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;MarginOrderDetail&gt;&gt; QueryMarginAccountSAllOrdersUserData(QueryMarginAccountSAllOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMarginAccountSAllOrdersUserData(
        new QueryMarginAccountSAllOrdersUserDataRequest
        {
            Symbol = "BNBUSDT",
            Timestamp = 1L,
            Signature = "some example string",
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<MarginOrderDetail>
}
catch (ApiException<QueryMarginAccountSAllOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMarginAccountSAllOrdersUserDataRequest](Requests/Margin/QueryMarginAccountSAllOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MarginOrderDetail](Models/MarginOrderDetail.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSAllOrdersUserDataError](Errors/QueryMarginAccountSAllOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginOrderListResponse&gt; QueryMarginAccountSOcoUserData(QueryMarginAccountSOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMarginAccountSOcoUserData(new QueryMarginAccountSOcoUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginOrderListResponse
}
catch (ApiException<QueryMarginAccountSOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMarginAccountSOcoUserDataRequest](Requests/Margin/QueryMarginAccountSOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderListResponse](Models/SapiV1MarginOrderListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSOcoUserDataError](Errors/QueryMarginAccountSOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginOpenOrderListResponse&gt;&gt; QueryMarginAccountSOpenOcoUserData(QueryMarginAccountSOpenOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMarginAccountSOpenOcoUserData(new QueryMarginAccountSOpenOcoUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginOpenOrderListResponse>
}
catch (ApiException<QueryMarginAccountSOpenOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMarginAccountSOpenOcoUserDataRequest](Requests/Margin/QueryMarginAccountSOpenOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginOpenOrderListResponse](Models/SapiV1MarginOpenOrderListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSOpenOcoUserDataError](Errors/QueryMarginAccountSOpenOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;MarginOrderDetail&gt;&gt; QueryMarginAccountSOpenOrdersUserData(QueryMarginAccountSOpenOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMarginAccountSOpenOrdersUserData(
        new QueryMarginAccountSOpenOrdersUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Symbol = "BNBUSDT",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<MarginOrderDetail>
}
catch (ApiException<QueryMarginAccountSOpenOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMarginAccountSOpenOrdersUserDataRequest](Requests/Margin/QueryMarginAccountSOpenOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MarginOrderDetail](Models/MarginOrderDetail.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSOpenOrdersUserDataError](Errors/QueryMarginAccountSOpenOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MarginOrderDetail&gt; QueryMarginAccountSOrderUserData(QueryMarginAccountSOrderUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMarginAccountSOrderUserData(new QueryMarginAccountSOrderUserDataRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type MarginOrderDetail
}
catch (ApiException<QueryMarginAccountSOrderUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMarginAccountSOrderUserDataRequest](Requests/Margin/QueryMarginAccountSOrderUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MarginOrderDetail](Models/MarginOrderDetail.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSOrderUserDataError](Errors/QueryMarginAccountSOrderUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;MarginTrade&gt;&gt; QueryMarginAccountSTradeListUserData(QueryMarginAccountSTradeListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMarginAccountSTradeListUserData(
        new QueryMarginAccountSTradeListUserDataRequest
        {
            Symbol = "BNBUSDT",
            Timestamp = 1L,
            Signature = "some example string",
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<MarginTrade>
}
catch (ApiException<QueryMarginAccountSTradeListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMarginAccountSTradeListUserDataRequest](Requests/Margin/QueryMarginAccountSTradeListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MarginTrade](Models/MarginTrade.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSTradeListUserDataError](Errors/QueryMarginAccountSTradeListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1MarginAllOrderListResponse&gt;&gt; QueryMarginAccountSAllOcoUserData(QueryMarginAccountSAllOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMarginAccountSAllOcoUserData(new QueryMarginAccountSAllOcoUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1MarginAllOrderListResponse>
}
catch (ApiException<QueryMarginAccountSAllOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMarginAccountSAllOcoUserDataRequest](Requests/Margin/QueryMarginAccountSAllOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginAllOrderListResponse](Models/SapiV1MarginAllOrderListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSAllOcoUserDataError](Errors/QueryMarginAccountSAllOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginAvailableInventoryResponse&gt; QueryMarginAvailableInventoryUserData(QueryMarginAvailableInventoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMarginAvailableInventoryUserData(
        new QueryMarginAvailableInventoryUserDataRequest
        {
            Type = Type4.Margin,
            Timestamp = 1L,
            Signature = "some example string",
        });
    // TODO: Handle 'response' of type SapiV1MarginAvailableInventoryResponse
}
catch (ApiException<QueryMarginAvailableInventoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMarginAvailableInventoryUserDataRequest](Requests/Margin/QueryMarginAvailableInventoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginAvailableInventoryResponse](Models/SapiV1MarginAvailableInventoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMarginAvailableInventoryUserDataError](Errors/QueryMarginAvailableInventoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginPriceIndexResponse&gt; QueryMarginPriceIndexMarketData(QueryMarginPriceIndexMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMarginPriceIndexMarketData(new QueryMarginPriceIndexMarketDataRequest
    {
        Symbol = "BNBUSDT",
    });
    // TODO: Handle 'response' of type SapiV1MarginPriceIndexResponse
}
catch (ApiException<QueryMarginPriceIndexMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMarginPriceIndexMarketDataRequest](Requests/Margin/QueryMarginPriceIndexMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginPriceIndexResponse](Models/SapiV1MarginPriceIndexResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMarginPriceIndexMarketDataError](Errors/QueryMarginPriceIndexMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginMaxBorrowableResponse&gt; QueryMaxBorrowUserData(QueryMaxBorrowUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMaxBorrowUserData(new QueryMaxBorrowUserDataRequest
    {
        Asset = "BTC",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginMaxBorrowableResponse
}
catch (ApiException<QueryMaxBorrowUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMaxBorrowUserDataRequest](Requests/Margin/QueryMaxBorrowUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginMaxBorrowableResponse](Models/SapiV1MarginMaxBorrowableResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMaxBorrowUserDataError](Errors/QueryMaxBorrowUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginMaxTransferableResponse&gt; QueryMaxTransferOutAmountUserData(QueryMaxTransferOutAmountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryMaxTransferOutAmountUserData(new QueryMaxTransferOutAmountUserDataRequest
    {
        Asset = "BTC",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MarginMaxTransferableResponse
}
catch (ApiException<QueryMaxTransferOutAmountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMaxTransferOutAmountUserDataRequest](Requests/Margin/QueryMaxTransferOutAmountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginMaxTransferableResponse](Models/SapiV1MarginMaxTransferableResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryMaxTransferOutAmountUserDataError](Errors/QueryMaxTransferOutAmountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MarginBorrowRepayResponse1&gt; QueryBorrowRepayRecordsInMarginAccountUserData(QueryBorrowRepayRecordsInMarginAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.QueryBorrowRepayRecordsInMarginAccountUserData(
        new QueryBorrowRepayRecordsInMarginAccountUserDataRequest
        {
            Asset = "BTC",
            Type = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1MarginBorrowRepayResponse1
}
catch (ApiException<QueryBorrowRepayRecordsInMarginAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryBorrowRepayRecordsInMarginAccountUserDataRequest](Requests/Margin/QueryBorrowRepayRecordsInMarginAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginBorrowRepayResponse1](Models/SapiV1MarginBorrowRepayResponse1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryBorrowRepayRecordsInMarginAccountUserDataError](Errors/QueryBorrowRepayRecordsInMarginAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BnbBurnStatus&gt; ToggleBnbBurnOnSpotTradeAndMarginInterestUserData(ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Margin.ToggleBnbBurnOnSpotTradeAndMarginInterestUserData(
        new ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            SpotBnbBurn = SpotBnbBurn.True,
            InterestBnbBurn = InterestBnbBurn.False,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type BnbBurnStatus
}
catch (ApiException<ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest](Requests/Margin/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BnbBurnStatus](Models/BnbBurnStatus.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError](Errors/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MarginStream

> Source: [MarginStream](Api/MarginStream.cs)

<details>
<summary><code>Task&lt;object&gt; CloseAListenKeyUserStream2(CloseAListenKeyUserStream2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.MarginStream.CloseAListenKeyUserStream2(new CloseAListenKeyUserStream2Request
    {
        ListenKey = "pqia91ma19a5s61cv6a81va65sdf19v8a65a1a5s61cv6a81va65sdf19v8a65a1",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<CloseAListenKeyUserStream2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CloseAListenKeyUserStream2Request](Requests/MarginStream/CloseAListenKeyUserStream2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CloseAListenKeyUserStream2Error](Errors/CloseAListenKeyUserStream2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1UserDataStreamResponse&gt; CreateAListenKeyUserStream2(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; PingKeepAliveAListenKeyUserStream2(PingKeepAliveAListenKeyUserStream2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.MarginStream.PingKeepAliveAListenKeyUserStream2(
        new PingKeepAliveAListenKeyUserStream2Request
        {
            ListenKey = "pqia91ma19a5s61cv6a81va65sdf19v8a65a1a5s61cv6a81va65sdf19v8a65a1",
        });
    // TODO: Handle 'response' of type object
}
catch (ApiException<PingKeepAliveAListenKeyUserStream2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PingKeepAliveAListenKeyUserStream2Request](Requests/MarginStream/PingKeepAliveAListenKeyUserStream2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PingKeepAliveAListenKeyUserStream2Error](Errors/PingKeepAliveAListenKeyUserStream2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Market

> Source: [Market](Api/Market.cs)

<details>
<summary><code>Task&lt;ApiV3Ticker24HrResponse&gt; HrTickerPriceChangeStatistics24(HrTickerPriceChangeStatistics24Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.HrTickerPriceChangeStatistics24(new HrTickerPriceChangeStatistics24Request
    {
        Symbol = "BNBUSDT",
        Symbols = "[\"BTCUSDT\",\"BNBBTC\"]",
        Type = TypeEnum.Full,
    });
    // TODO: Handle 'response' of type ApiV3Ticker24HrResponse
}
catch (ApiException<HrTickerPriceChangeStatistics24Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[HrTickerPriceChangeStatistics24Request](Requests/Market/HrTickerPriceChangeStatistics24Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3Ticker24HrResponse](Models/AnyOf/ApiV3Ticker24HrResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[HrTickerPriceChangeStatistics24Error](Errors/HrTickerPriceChangeStatistics24Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TimeResponse&gt; CheckServerTime(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AggTrade&gt;&gt; CompressedAggregateTradesList(CompressedAggregateTradesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.CompressedAggregateTradesList(new CompressedAggregateTradesListRequest
    {
        Symbol = "BNBUSDT",
        Limit = 5,
    });
    // TODO: Handle 'response' of type IReadOnlyList<AggTrade>
}
catch (ApiException<CompressedAggregateTradesListError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CompressedAggregateTradesListRequest](Requests/Market/CompressedAggregateTradesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AggTrade](Models/AggTrade.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CompressedAggregateTradesListError](Errors/CompressedAggregateTradesListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3AvgPriceResponse&gt; CurrentAveragePrice(CurrentAveragePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.CurrentAveragePrice(new CurrentAveragePriceRequest { Symbol = "BNBUSDT" });
    // TODO: Handle 'response' of type ApiV3AvgPriceResponse
}
catch (ApiException<CurrentAveragePriceError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CurrentAveragePriceRequest](Requests/Market/CurrentAveragePriceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3AvgPriceResponse](Models/ApiV3AvgPriceResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CurrentAveragePriceError](Errors/CurrentAveragePriceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3ExchangeInfoResponse&gt; ExchangeInformation(ExchangeInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.ExchangeInformation(new ExchangeInformationRequest
    {
        Symbol = "BNBUSDT",
        Symbols = "[\"BTCUSDT\",\"BNBBTC\"]",
        Permissions = "'SPOT' or ['MARGIN','LEVERAGED']",
    });
    // TODO: Handle 'response' of type ApiV3ExchangeInfoResponse
}
catch (ApiException<ExchangeInformationError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ExchangeInformationRequest](Requests/Market/ExchangeInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3ExchangeInfoResponse](Models/ApiV3ExchangeInfoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ExchangeInformationError](Errors/ExchangeInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;ApiV3KlinesResponse&gt;&gt;&gt; KlineCandlestickData(KlineCandlestickDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.KlineCandlestickData(new KlineCandlestickDataRequest
    {
        Symbol = "BNBUSDT",
        Interval = Interval._1S,
        Limit = 5,
    });
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<ApiV3KlinesResponse>>
}
catch (ApiException<KlineCandlestickDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[KlineCandlestickDataRequest](Requests/Market/KlineCandlestickDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[ApiV3KlinesResponse](Models/AnyOf/ApiV3KlinesResponse.cs)&gt;&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[KlineCandlestickDataError](Errors/KlineCandlestickDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Trade&gt;&gt; OldTradeLookup(OldTradeLookupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.OldTradeLookup(new OldTradeLookupRequest { Symbol = "BNBUSDT", Limit = 5 });
    // TODO: Handle 'response' of type IReadOnlyList<Trade>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OldTradeLookupRequest](Requests/Market/OldTradeLookupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Trade](Models/Trade.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3DepthResponse&gt; OrderBook(OrderBookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.OrderBook(new OrderBookRequest { Symbol = "BNBUSDT", Limit = 100 });
    // TODO: Handle 'response' of type ApiV3DepthResponse
}
catch (ApiException<OrderBookError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OrderBookRequest](Requests/Market/OrderBookRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3DepthResponse](Models/ApiV3DepthResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[OrderBookError](Errors/OrderBookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Trade&gt;&gt; RecentTradesList(RecentTradesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.RecentTradesList(new RecentTradesListRequest { Symbol = "BNBUSDT", Limit = 5 });
    // TODO: Handle 'response' of type IReadOnlyList<Trade>
}
catch (ApiException<RecentTradesListError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RecentTradesListRequest](Requests/Market/RecentTradesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Trade](Models/Trade.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RecentTradesListError](Errors/RecentTradesListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TickerResponse&gt; RollingWindowPriceChangeStatistics(RollingWindowPriceChangeStatisticsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.RollingWindowPriceChangeStatistics(new RollingWindowPriceChangeStatisticsRequest
    {
        Symbol = "BNBUSDT",
        Symbols = "[\"BTCUSDT\",\"BNBBTC\"]",
    });
    // TODO: Handle 'response' of type ApiV3TickerResponse
}
catch (ApiException<RollingWindowPriceChangeStatisticsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RollingWindowPriceChangeStatisticsRequest](Requests/Market/RollingWindowPriceChangeStatisticsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerResponse](Models/ApiV3TickerResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RollingWindowPriceChangeStatisticsError](Errors/RollingWindowPriceChangeStatisticsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TickerBookTickerResponse&gt; SymbolOrderBookTicker(SymbolOrderBookTickerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.SymbolOrderBookTicker(new SymbolOrderBookTickerRequest
    {
        Symbol = "BNBUSDT",
        Symbols = "[\"BTCUSDT\",\"BNBBTC\"]",
    });
    // TODO: Handle 'response' of type ApiV3TickerBookTickerResponse
}
catch (ApiException<SymbolOrderBookTickerError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SymbolOrderBookTickerRequest](Requests/Market/SymbolOrderBookTickerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerBookTickerResponse](Models/AnyOf/ApiV3TickerBookTickerResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SymbolOrderBookTickerError](Errors/SymbolOrderBookTickerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TickerPriceResponse&gt; SymbolPriceTicker(SymbolPriceTickerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.SymbolPriceTicker(new SymbolPriceTickerRequest
    {
        Symbol = "BNBUSDT",
        Symbols = "[\"BTCUSDT\",\"BNBBTC\"]",
    });
    // TODO: Handle 'response' of type ApiV3TickerPriceResponse
}
catch (ApiException<SymbolPriceTickerError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SymbolPriceTickerRequest](Requests/Market/SymbolPriceTickerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerPriceResponse](Models/AnyOf/ApiV3TickerPriceResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SymbolPriceTickerError](Errors/SymbolPriceTickerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; TestConnectivity(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3TickerTradingDayResponse&gt; TradingDayTicker(TradingDayTickerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.TradingDayTicker(new TradingDayTickerRequest
    {
        Symbol = "BNBUSDT",
        Symbols = "[\"BTCUSDT\",\"BNBBTC\"]",
        Type = TypeEnum.Full,
    });
    // TODO: Handle 'response' of type ApiV3TickerTradingDayResponse
}
catch (ApiException<TradingDayTickerError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TradingDayTickerRequest](Requests/Market/TradingDayTickerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerTradingDayResponse](Models/AnyOf/ApiV3TickerTradingDayResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TradingDayTickerError](Errors/TradingDayTickerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;ApiV3UiKlinesResponse&gt;&gt;&gt; UiKlines(UiKlinesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Market.UiKlines(new UiKlinesRequest
    {
        Symbol = "BNBUSDT",
        Interval = Interval._1S,
        Limit = 5,
    });
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<ApiV3UiKlinesResponse>>
}
catch (ApiException<UiKlinesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UiKlinesRequest](Requests/Market/UiKlinesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[ApiV3UiKlinesResponse](Models/AnyOf/ApiV3UiKlinesResponse.cs)&gt;&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UiKlinesError](Errors/UiKlinesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Mining

> Source: [Mining](Api/Mining.cs)

<details>
<summary><code>Task&lt;SapiV1MiningStatisticsUserListResponse&gt; AccountListUserData(AccountListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.AccountListUserData(new AccountListUserDataRequest
    {
        Algo = "some example string",
        UserName = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningStatisticsUserListResponse
}
catch (ApiException<AccountListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountListUserDataRequest](Requests/Mining/AccountListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningStatisticsUserListResponse](Models/SapiV1MiningStatisticsUserListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AccountListUserDataError](Errors/AccountListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPubAlgoListResponse&gt; AcquiringAlgorithmMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<AcquiringAlgorithmMarketDataError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AcquiringAlgorithmMarketDataError](Errors/AcquiringAlgorithmMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPubCoinListResponse&gt; AcquiringCoinNameMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<AcquiringCoinNameMarketDataError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AcquiringCoinNameMarketDataError](Errors/AcquiringCoinNameMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningHashTransferConfigCancelResponse&gt; CancelHashrateResaleConfigurationUserData(CancelHashrateResaleConfigurationUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.CancelHashrateResaleConfigurationUserData(
        new CancelHashrateResaleConfigurationUserDataRequest
        {
            ConfigId = "some example string",
            UserName = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1MiningHashTransferConfigCancelResponse
}
catch (ApiException<CancelHashrateResaleConfigurationUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelHashrateResaleConfigurationUserDataRequest](Requests/Mining/CancelHashrateResaleConfigurationUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferConfigCancelResponse](Models/SapiV1MiningHashTransferConfigCancelResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelHashrateResaleConfigurationUserDataError](Errors/CancelHashrateResaleConfigurationUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPaymentListResponse&gt; EarningsListUserData(EarningsListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.EarningsListUserData(new EarningsListUserDataRequest
    {
        Algo = "some example string",
        UserName = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        Coin = "BNB",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningPaymentListResponse
}
catch (ApiException<EarningsListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EarningsListUserDataRequest](Requests/Mining/EarningsListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPaymentListResponse](Models/SapiV1MiningPaymentListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EarningsListUserDataError](Errors/EarningsListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPaymentOtherResponse&gt; ExtraBonusListUserData(ExtraBonusListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.ExtraBonusListUserData(new ExtraBonusListUserDataRequest
    {
        Algo = "some example string",
        UserName = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        Coin = "BNB",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningPaymentOtherResponse
}
catch (ApiException<ExtraBonusListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ExtraBonusListUserDataRequest](Requests/Mining/ExtraBonusListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPaymentOtherResponse](Models/SapiV1MiningPaymentOtherResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ExtraBonusListUserDataError](Errors/ExtraBonusListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningHashTransferProfitDetailsResponse&gt; HashrateResaleDetailsUserData(HashrateResaleDetailsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.HashrateResaleDetailsUserData(new HashrateResaleDetailsUserDataRequest
    {
        ConfigId = "some example string",
        UserName = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningHashTransferProfitDetailsResponse
}
catch (ApiException<HashrateResaleDetailsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[HashrateResaleDetailsUserDataRequest](Requests/Mining/HashrateResaleDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferProfitDetailsResponse](Models/SapiV1MiningHashTransferProfitDetailsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[HashrateResaleDetailsUserDataError](Errors/HashrateResaleDetailsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningHashTransferConfigDetailsListResponse&gt; HashrateResaleListUserData(HashrateResaleListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.HashrateResaleListUserData(new HashrateResaleListUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningHashTransferConfigDetailsListResponse
}
catch (ApiException<HashrateResaleListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[HashrateResaleListUserDataRequest](Requests/Mining/HashrateResaleListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferConfigDetailsListResponse](Models/SapiV1MiningHashTransferConfigDetailsListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[HashrateResaleListUserDataError](Errors/HashrateResaleListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningHashTransferConfigResponse&gt; HashrateResaleRequestUserData(HashrateResaleRequestUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.HashrateResaleRequestUserData(new HashrateResaleRequestUserDataRequest
    {
        UserName = "some example string",
        Algo = "some example string",
        ToPoolUser = "some example string",
        HashRate = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningHashTransferConfigResponse
}
catch (ApiException<HashrateResaleRequestUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[HashrateResaleRequestUserDataRequest](Requests/Mining/HashrateResaleRequestUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferConfigResponse](Models/SapiV1MiningHashTransferConfigResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[HashrateResaleRequestUserDataError](Errors/HashrateResaleRequestUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningPaymentUidResponse&gt; MiningAccountEarningUserData(MiningAccountEarningUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.MiningAccountEarningUserData(new MiningAccountEarningUserDataRequest
    {
        Algo = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningPaymentUidResponse
}
catch (ApiException<MiningAccountEarningUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MiningAccountEarningUserDataRequest](Requests/Mining/MiningAccountEarningUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPaymentUidResponse](Models/SapiV1MiningPaymentUidResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MiningAccountEarningUserDataError](Errors/MiningAccountEarningUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningWorkerDetailResponse&gt; RequestForDetailMinerListUserData(RequestForDetailMinerListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.RequestForDetailMinerListUserData(new RequestForDetailMinerListUserDataRequest
    {
        Algo = "some example string",
        UserName = "some example string",
        WorkerName = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningWorkerDetailResponse
}
catch (ApiException<RequestForDetailMinerListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RequestForDetailMinerListUserDataRequest](Requests/Mining/RequestForDetailMinerListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningWorkerDetailResponse](Models/SapiV1MiningWorkerDetailResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RequestForDetailMinerListUserDataError](Errors/RequestForDetailMinerListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningWorkerListResponse&gt; RequestForMinerListUserData(RequestForMinerListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.RequestForMinerListUserData(new RequestForMinerListUserDataRequest
    {
        Algo = "some example string",
        UserName = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningWorkerListResponse
}
catch (ApiException<RequestForMinerListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RequestForMinerListUserDataRequest](Requests/Mining/RequestForMinerListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningWorkerListResponse](Models/SapiV1MiningWorkerListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RequestForMinerListUserDataError](Errors/RequestForMinerListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1MiningStatisticsUserStatusResponse&gt; StatisticListUserData(StatisticListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Mining.StatisticListUserData(new StatisticListUserDataRequest
    {
        Algo = "some example string",
        UserName = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1MiningStatisticsUserStatusResponse
}
catch (ApiException<StatisticListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StatisticListUserDataRequest](Requests/Mining/StatisticListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningStatisticsUserStatusResponse](Models/SapiV1MiningStatisticsUserStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[StatisticListUserDataError](Errors/StatisticListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Nft

> Source: [Nft](Api/Nft.cs)

<details>
<summary><code>Task&lt;SapiV1NftUserGetAssetResponse&gt; GetNftAssetUserData(GetNftAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Nft.GetNftAssetUserData(new GetNftAssetUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 50,
        Page = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1NftUserGetAssetResponse
}
catch (ApiException<GetNftAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetNftAssetUserDataRequest](Requests/Nft/GetNftAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftUserGetAssetResponse](Models/SapiV1NftUserGetAssetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetNftAssetUserDataError](Errors/GetNftAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1NftHistoryDepositResponse&gt; GetNftDepositHistoryUserData(GetNftDepositHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Nft.GetNftDepositHistoryUserData(new GetNftDepositHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 50,
        Page = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1NftHistoryDepositResponse
}
catch (ApiException<GetNftDepositHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetNftDepositHistoryUserDataRequest](Requests/Nft/GetNftDepositHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftHistoryDepositResponse](Models/SapiV1NftHistoryDepositResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetNftDepositHistoryUserDataError](Errors/GetNftDepositHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1NftHistoryTransactionsResponse&gt; GetNftTransactionHistoryUserData(GetNftTransactionHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Nft.GetNftTransactionHistoryUserData(new GetNftTransactionHistoryUserDataRequest
    {
        OrderType = 1,
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 50,
        Page = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1NftHistoryTransactionsResponse
}
catch (ApiException<GetNftTransactionHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetNftTransactionHistoryUserDataRequest](Requests/Nft/GetNftTransactionHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftHistoryTransactionsResponse](Models/SapiV1NftHistoryTransactionsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetNftTransactionHistoryUserDataError](Errors/GetNftTransactionHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1NftHistoryWithdrawResponse&gt; GetNftWithdrawHistoryUserData(GetNftWithdrawHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Nft.GetNftWithdrawHistoryUserData(new GetNftWithdrawHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 50,
        Page = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1NftHistoryWithdrawResponse
}
catch (ApiException<GetNftWithdrawHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetNftWithdrawHistoryUserDataRequest](Requests/Nft/GetNftWithdrawHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftHistoryWithdrawResponse](Models/SapiV1NftHistoryWithdrawResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetNftWithdrawHistoryUserDataError](Errors/GetNftWithdrawHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Pay

> Source: [Pay](Api/Pay.cs)

<details>
<summary><code>Task&lt;SapiV1PayTransactionsResponse&gt; GetPayTradeHistoryUserData(GetPayTradeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Pay.GetPayTradeHistoryUserData(new GetPayTradeHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1PayTransactionsResponse
}
catch (ApiException<GetPayTradeHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPayTradeHistoryUserDataRequest](Requests/Pay/GetPayTradeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PayTransactionsResponse](Models/SapiV1PayTransactionsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPayTradeHistoryUserDataError](Errors/GetPayTradeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PortfolioMargin

> Source: [PortfolioMargin](Api/PortfolioMargin.cs)

<details>
<summary><code>Task&lt;SapiV1PortfolioBnbTransferResponse&gt; BnbTransferUserData(BnbTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.BnbTransferUserData(new BnbTransferUserDataRequest
    {
        TransferSide = TransferSide.ToUm,
        Amount = 1.01d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1PortfolioBnbTransferResponse
}
catch (ApiException<BnbTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BnbTransferUserDataRequest](Requests/PortfolioMargin/BnbTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioBnbTransferResponse](Models/SapiV1PortfolioBnbTransferResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[BnbTransferUserDataError](Errors/BnbTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioRepayFuturesSwitchResponse&gt; ChangeAutoRepayFuturesStatusUserData(ChangeAutoRepayFuturesStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.ChangeAutoRepayFuturesStatusUserData(
        new ChangeAutoRepayFuturesStatusUserDataRequest
        {
            AutoRepay = true,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1PortfolioRepayFuturesSwitchResponse
}
catch (ApiException<ChangeAutoRepayFuturesStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangeAutoRepayFuturesStatusUserDataRequest](Requests/PortfolioMargin/ChangeAutoRepayFuturesStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayFuturesSwitchResponse](Models/SapiV1PortfolioRepayFuturesSwitchResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ChangeAutoRepayFuturesStatusUserDataError](Errors/ChangeAutoRepayFuturesStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioAutoCollectionResponse&gt; FundAutoCollectionUserData(FundAutoCollectionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.FundAutoCollectionUserData(new FundAutoCollectionUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1PortfolioAutoCollectionResponse
}
catch (ApiException<FundAutoCollectionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FundAutoCollectionUserDataRequest](Requests/PortfolioMargin/FundAutoCollectionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioAutoCollectionResponse](Models/SapiV1PortfolioAutoCollectionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FundAutoCollectionUserDataError](Errors/FundAutoCollectionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioAssetCollectionResponse&gt; FundCollectionByAssetUserData(FundCollectionByAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.FundCollectionByAssetUserData(new FundCollectionByAssetUserDataRequest
    {
        Asset = "BTC",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1PortfolioAssetCollectionResponse
}
catch (ApiException<FundCollectionByAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FundCollectionByAssetUserDataRequest](Requests/PortfolioMargin/FundCollectionByAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioAssetCollectionResponse](Models/SapiV1PortfolioAssetCollectionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FundCollectionByAssetUserDataError](Errors/FundCollectionByAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioRepayFuturesSwitchResponse1&gt; GetAutoRepayFuturesStatusUserData(GetAutoRepayFuturesStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.GetAutoRepayFuturesStatusUserData(
        new GetAutoRepayFuturesStatusUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1PortfolioRepayFuturesSwitchResponse1
}
catch (ApiException<GetAutoRepayFuturesStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAutoRepayFuturesStatusUserDataRequest](Requests/PortfolioMargin/GetAutoRepayFuturesStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayFuturesSwitchResponse1](Models/SapiV1PortfolioRepayFuturesSwitchResponse1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAutoRepayFuturesStatusUserDataError](Errors/GetAutoRepayFuturesStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1PortfolioMarginAssetLeverageResponse&gt;&gt; GetPortfolioMarginAssetLeverageUserData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<GetPortfolioMarginAssetLeverageUserDataError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPortfolioMarginAssetLeverageUserDataError](Errors/GetPortfolioMarginAssetLeverageUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioAccountResponse&gt; PortfolioMarginAccountUserData(PortfolioMarginAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.PortfolioMarginAccountUserData(new PortfolioMarginAccountUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1PortfolioAccountResponse
}
catch (ApiException<PortfolioMarginAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PortfolioMarginAccountUserDataRequest](Requests/PortfolioMargin/PortfolioMarginAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioAccountResponse](Models/SapiV1PortfolioAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginAccountUserDataError](Errors/PortfolioMarginAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioPmLoanResponse&gt; PortfolioMarginBankruptcyLoanAmountUserData(PortfolioMarginBankruptcyLoanAmountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.PortfolioMarginBankruptcyLoanAmountUserData(
        new PortfolioMarginBankruptcyLoanAmountUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1PortfolioPmLoanResponse
}
catch (ApiException<PortfolioMarginBankruptcyLoanAmountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PortfolioMarginBankruptcyLoanAmountUserDataRequest](Requests/PortfolioMargin/PortfolioMarginBankruptcyLoanAmountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioPmLoanResponse](Models/SapiV1PortfolioPmLoanResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginBankruptcyLoanAmountUserDataError](Errors/PortfolioMarginBankruptcyLoanAmountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioRepayResponse&gt; PortfolioMarginBankruptcyLoanRepayUserData(PortfolioMarginBankruptcyLoanRepayUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.PortfolioMarginBankruptcyLoanRepayUserData(
        new PortfolioMarginBankruptcyLoanRepayUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            From = "SPOT",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1PortfolioRepayResponse
}
catch (ApiException<PortfolioMarginBankruptcyLoanRepayUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PortfolioMarginBankruptcyLoanRepayUserDataRequest](Requests/PortfolioMargin/PortfolioMarginBankruptcyLoanRepayUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayResponse](Models/SapiV1PortfolioRepayResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginBankruptcyLoanRepayUserDataError](Errors/PortfolioMarginBankruptcyLoanRepayUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1PortfolioCollateralRateResponse&gt;&gt; PortfolioMarginCollateralRateMarketData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<PortfolioMarginCollateralRateMarketDataError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginCollateralRateMarketDataError](Errors/PortfolioMarginCollateralRateMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV2PortfolioCollateralRateResponse&gt;&gt; PortfolioMarginProTieredCollateralRateUserData(PortfolioMarginProTieredCollateralRateUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.PortfolioMarginProTieredCollateralRateUserData(
        new PortfolioMarginProTieredCollateralRateUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV2PortfolioCollateralRateResponse>
}
catch (ApiException<PortfolioMarginProTieredCollateralRateUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PortfolioMarginProTieredCollateralRateUserDataRequest](Requests/PortfolioMargin/PortfolioMarginProTieredCollateralRateUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV2PortfolioCollateralRateResponse](Models/SapiV2PortfolioCollateralRateResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginProTieredCollateralRateUserDataError](Errors/PortfolioMarginProTieredCollateralRateUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1PortfolioInterestHistoryResponse&gt;&gt; QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData(QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData(
        new QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest
        {
            Asset = "BTC",
            Timestamp = 1L,
            Signature = "some example string",
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1PortfolioInterestHistoryResponse>
}
catch (ApiException<QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest](Requests/PortfolioMargin/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioInterestHistoryResponse](Models/SapiV1PortfolioInterestHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError](Errors/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1PortfolioAssetIndexPriceResponse&gt;&gt; QueryPortfolioMarginAssetIndexPriceMarketData(QueryPortfolioMarginAssetIndexPriceMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.QueryPortfolioMarginAssetIndexPriceMarketData(
        new QueryPortfolioMarginAssetIndexPriceMarketDataRequest { Asset = "BTC" });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1PortfolioAssetIndexPriceResponse>
}
catch (ApiException<QueryPortfolioMarginAssetIndexPriceMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryPortfolioMarginAssetIndexPriceMarketDataRequest](Requests/PortfolioMargin/QueryPortfolioMarginAssetIndexPriceMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioAssetIndexPriceResponse](Models/SapiV1PortfolioAssetIndexPriceResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryPortfolioMarginAssetIndexPriceMarketDataError](Errors/QueryPortfolioMarginAssetIndexPriceMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1PortfolioRepayFuturesNegativeBalanceResponse&gt; RepayFuturesNegativeBalanceUserData(RepayFuturesNegativeBalanceUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.PortfolioMargin.RepayFuturesNegativeBalanceUserData(
        new RepayFuturesNegativeBalanceUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1PortfolioRepayFuturesNegativeBalanceResponse
}
catch (ApiException<RepayFuturesNegativeBalanceUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RepayFuturesNegativeBalanceUserDataRequest](Requests/PortfolioMargin/RepayFuturesNegativeBalanceUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayFuturesNegativeBalanceResponse](Models/SapiV1PortfolioRepayFuturesNegativeBalanceResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RepayFuturesNegativeBalanceUserDataError](Errors/RepayFuturesNegativeBalanceUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Rebate

> Source: [Rebate](Api/Rebate.cs)

<details>
<summary><code>Task&lt;SapiV1RebateTaxQueryResponse&gt; GetSpotRebateHistoryRecordsUserData(GetSpotRebateHistoryRecordsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Rebate.GetSpotRebateHistoryRecordsUserData(
        new GetSpotRebateHistoryRecordsUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1RebateTaxQueryResponse
}
catch (ApiException<GetSpotRebateHistoryRecordsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSpotRebateHistoryRecordsUserDataRequest](Requests/Rebate/GetSpotRebateHistoryRecordsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1RebateTaxQueryResponse](Models/SapiV1RebateTaxQueryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSpotRebateHistoryRecordsUserDataError](Errors/GetSpotRebateHistoryRecordsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Savings

> Source: [Savings](Api/Savings.cs)

<details>
<summary><code>Task&lt;SapiV1LendingPositionChangedResponse&gt; ChangeFixedActivityPositionToDailyPositionUserData(ChangeFixedActivityPositionToDailyPositionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Savings.ChangeFixedActivityPositionToDailyPositionUserData(
        new ChangeFixedActivityPositionToDailyPositionUserDataRequest
        {
            ProjectId = "some example string",
            Lot = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LendingPositionChangedResponse
}
catch (ApiException<ChangeFixedActivityPositionToDailyPositionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangeFixedActivityPositionToDailyPositionUserDataRequest](Requests/Savings/ChangeFixedActivityPositionToDailyPositionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingPositionChangedResponse](Models/SapiV1LendingPositionChangedResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ChangeFixedActivityPositionToDailyPositionUserDataError](Errors/ChangeFixedActivityPositionToDailyPositionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingProjectListResponse&gt;&gt; GetFixedActivityProjectListUserData(GetFixedActivityProjectListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Savings.GetFixedActivityProjectListUserData(
        new GetFixedActivityProjectListUserDataRequest
        {
            Type = Type8.Activity,
            Timestamp = 1L,
            Signature = "some example string",
            Asset = "BNB",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingProjectListResponse>
}
catch (ApiException<GetFixedActivityProjectListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFixedActivityProjectListUserDataRequest](Requests/Savings/GetFixedActivityProjectListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingProjectListResponse](Models/SapiV1LendingProjectListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFixedActivityProjectListUserDataError](Errors/GetFixedActivityProjectListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LendingProjectPositionListResponse&gt;&gt; GetFixedActivityProjectPositionUserData(GetFixedActivityProjectPositionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Savings.GetFixedActivityProjectPositionUserData(
        new GetFixedActivityProjectPositionUserDataRequest
        {
            Asset = "BTC",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LendingProjectPositionListResponse>
}
catch (ApiException<GetFixedActivityProjectPositionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFixedActivityProjectPositionUserDataRequest](Requests/Savings/GetFixedActivityProjectPositionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingProjectPositionListResponse](Models/SapiV1LendingProjectPositionListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFixedActivityProjectPositionUserDataError](Errors/GetFixedActivityProjectPositionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LendingCustomizedFixedPurchaseResponse&gt; PurchaseFixedActivityProjectUserData(PurchaseFixedActivityProjectUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Savings.PurchaseFixedActivityProjectUserData(
        new PurchaseFixedActivityProjectUserDataRequest
        {
            ProjectId = "some example string",
            Lot = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LendingCustomizedFixedPurchaseResponse
}
catch (ApiException<PurchaseFixedActivityProjectUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PurchaseFixedActivityProjectUserDataRequest](Requests/Savings/PurchaseFixedActivityProjectUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingCustomizedFixedPurchaseResponse](Models/SapiV1LendingCustomizedFixedPurchaseResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PurchaseFixedActivityProjectUserDataError](Errors/PurchaseFixedActivityProjectUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SimpleEarn

> Source: [SimpleEarn](Api/SimpleEarn.cs)

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse&gt; GetCollateralRecordUserData(GetCollateralRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetCollateralRecordUserData(new GetCollateralRecordUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse
}
catch (ApiException<GetCollateralRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCollateralRecordUserDataRequest](Requests/SimpleEarn/GetCollateralRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse](Models/SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCollateralRecordUserDataError](Errors/GetCollateralRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse&gt; GetFlexiblePersonalLeftQuotaUserData(GetFlexiblePersonalLeftQuotaUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetFlexiblePersonalLeftQuotaUserData(
        new GetFlexiblePersonalLeftQuotaUserDataRequest
        {
            ProductId = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse
}
catch (ApiException<GetFlexiblePersonalLeftQuotaUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFlexiblePersonalLeftQuotaUserDataRequest](Requests/SimpleEarn/GetFlexiblePersonalLeftQuotaUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse](Models/SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFlexiblePersonalLeftQuotaUserDataError](Errors/GetFlexiblePersonalLeftQuotaUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexiblePositionResponse&gt; GetFlexibleProductPositionUserData(GetFlexibleProductPositionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetFlexibleProductPositionUserData(
        new GetFlexibleProductPositionUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexiblePositionResponse
}
catch (ApiException<GetFlexibleProductPositionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFlexibleProductPositionUserDataRequest](Requests/SimpleEarn/GetFlexibleProductPositionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexiblePositionResponse](Models/SapiV1SimpleEarnFlexiblePositionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFlexibleProductPositionUserDataError](Errors/GetFlexibleProductPositionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse&gt; GetFlexibleRedemptionRecordUserData(GetFlexibleRedemptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetFlexibleRedemptionRecordUserData(
        new GetFlexibleRedemptionRecordUserDataRequest { Current = 1, Size = 100 });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse
}
catch (ApiException<GetFlexibleRedemptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFlexibleRedemptionRecordUserDataRequest](Requests/SimpleEarn/GetFlexibleRedemptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse](Models/SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFlexibleRedemptionRecordUserDataError](Errors/GetFlexibleRedemptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse&gt; GetFlexibleRewardsHistoryUserData(GetFlexibleRewardsHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetFlexibleRewardsHistoryUserData(
        new GetFlexibleRewardsHistoryUserDataRequest { Type = "some example string" });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse
}
catch (ApiException<GetFlexibleRewardsHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFlexibleRewardsHistoryUserDataRequest](Requests/SimpleEarn/GetFlexibleRewardsHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse](Models/SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFlexibleRewardsHistoryUserDataError](Errors/GetFlexibleRewardsHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse&gt; GetFlexibleSubscriptionPreviewUserData(GetFlexibleSubscriptionPreviewUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetFlexibleSubscriptionPreviewUserData(
        new GetFlexibleSubscriptionPreviewUserDataRequest
        {
            ProductId = "some example string",
            Amount = 1.5d,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse
}
catch (ApiException<GetFlexibleSubscriptionPreviewUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFlexibleSubscriptionPreviewUserDataRequest](Requests/SimpleEarn/GetFlexibleSubscriptionPreviewUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse](Models/SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFlexibleSubscriptionPreviewUserDataError](Errors/GetFlexibleSubscriptionPreviewUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse&gt; GetFlexibleSubscriptionRecordUserData(GetFlexibleSubscriptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetFlexibleSubscriptionRecordUserData(
        new GetFlexibleSubscriptionRecordUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse
}
catch (ApiException<GetFlexibleSubscriptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFlexibleSubscriptionRecordUserDataRequest](Requests/SimpleEarn/GetFlexibleSubscriptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse](Models/SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFlexibleSubscriptionRecordUserDataError](Errors/GetFlexibleSubscriptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedPersonalLeftQuotaResponse&gt; GetLockedPersonalLeftQuotaUserData(GetLockedPersonalLeftQuotaUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetLockedPersonalLeftQuotaUserData(
        new GetLockedPersonalLeftQuotaUserDataRequest
        {
            ProjectId = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedPersonalLeftQuotaResponse
}
catch (ApiException<GetLockedPersonalLeftQuotaUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLockedPersonalLeftQuotaUserDataRequest](Requests/SimpleEarn/GetLockedPersonalLeftQuotaUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedPersonalLeftQuotaResponse](Models/SapiV1SimpleEarnLockedPersonalLeftQuotaResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLockedPersonalLeftQuotaUserDataError](Errors/GetLockedPersonalLeftQuotaUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedPositionResponse&gt; GetLockedProductPositionUserData(GetLockedProductPositionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetLockedProductPositionUserData(new GetLockedProductPositionUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedPositionResponse
}
catch (ApiException<GetLockedProductPositionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLockedProductPositionUserDataRequest](Requests/SimpleEarn/GetLockedProductPositionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedPositionResponse](Models/SapiV1SimpleEarnLockedPositionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLockedProductPositionUserDataError](Errors/GetLockedProductPositionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse&gt; GetLockedRedemptionRecordUserData(GetLockedRedemptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetLockedRedemptionRecordUserData(
        new GetLockedRedemptionRecordUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse
}
catch (ApiException<GetLockedRedemptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLockedRedemptionRecordUserDataRequest](Requests/SimpleEarn/GetLockedRedemptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse](Models/SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLockedRedemptionRecordUserDataError](Errors/GetLockedRedemptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedHistoryRewardsRecordResponse&gt; GetLockedRewardsHistoryUserData(GetLockedRewardsHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetLockedRewardsHistoryUserData(new GetLockedRewardsHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedHistoryRewardsRecordResponse
}
catch (ApiException<GetLockedRewardsHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLockedRewardsHistoryUserDataRequest](Requests/SimpleEarn/GetLockedRewardsHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedHistoryRewardsRecordResponse](Models/SapiV1SimpleEarnLockedHistoryRewardsRecordResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLockedRewardsHistoryUserDataError](Errors/GetLockedRewardsHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SimpleEarnLockedSubscriptionPreviewResponse&gt;&gt; GetLockedSubscriptionPreviewUserData(GetLockedSubscriptionPreviewUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetLockedSubscriptionPreviewUserData(
        new GetLockedSubscriptionPreviewUserDataRequest
        {
            ProjectId = "some example string",
            Amount = 1.5d,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SimpleEarnLockedSubscriptionPreviewResponse>
}
catch (ApiException<GetLockedSubscriptionPreviewUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLockedSubscriptionPreviewUserDataRequest](Requests/SimpleEarn/GetLockedSubscriptionPreviewUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SimpleEarnLockedSubscriptionPreviewResponse](Models/SapiV1SimpleEarnLockedSubscriptionPreviewResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLockedSubscriptionPreviewUserDataError](Errors/GetLockedSubscriptionPreviewUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse&gt; GetLockedSubscriptionRecordUserData(GetLockedSubscriptionRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetLockedSubscriptionRecordUserData(
        new GetLockedSubscriptionRecordUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse
}
catch (ApiException<GetLockedSubscriptionRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLockedSubscriptionRecordUserDataRequest](Requests/SimpleEarn/GetLockedSubscriptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse](Models/SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLockedSubscriptionRecordUserDataError](Errors/GetLockedSubscriptionRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse&gt; GetRateHistoryUserData(GetRateHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetRateHistoryUserData(new GetRateHistoryUserDataRequest
    {
        ProductId = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse
}
catch (ApiException<GetRateHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRateHistoryUserDataRequest](Requests/SimpleEarn/GetRateHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse](Models/SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetRateHistoryUserDataError](Errors/GetRateHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleListResponse&gt; GetSimpleEarnFlexibleProductListUserData(GetSimpleEarnFlexibleProductListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetSimpleEarnFlexibleProductListUserData(
        new GetSimpleEarnFlexibleProductListUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Asset = "BTC",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleListResponse
}
catch (ApiException<GetSimpleEarnFlexibleProductListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSimpleEarnFlexibleProductListUserDataRequest](Requests/SimpleEarn/GetSimpleEarnFlexibleProductListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleListResponse](Models/SapiV1SimpleEarnFlexibleListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSimpleEarnFlexibleProductListUserDataError](Errors/GetSimpleEarnFlexibleProductListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedListResponse&gt; GetSimpleEarnLockedProductListUserData(GetSimpleEarnLockedProductListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.GetSimpleEarnLockedProductListUserData(
        new GetSimpleEarnLockedProductListUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Asset = "BNB",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedListResponse
}
catch (ApiException<GetSimpleEarnLockedProductListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSimpleEarnLockedProductListUserDataRequest](Requests/SimpleEarn/GetSimpleEarnLockedProductListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedListResponse](Models/SapiV1SimpleEarnLockedListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSimpleEarnLockedProductListUserDataError](Errors/GetSimpleEarnLockedProductListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleRedeemResponse&gt; RedeemFlexibleProductTrade(RedeemFlexibleProductTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.RedeemFlexibleProductTrade(new RedeemFlexibleProductTradeRequest
    {
        ProductId = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleRedeemResponse
}
catch (ApiException<RedeemFlexibleProductTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RedeemFlexibleProductTradeRequest](Requests/SimpleEarn/RedeemFlexibleProductTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleRedeemResponse](Models/SapiV1SimpleEarnFlexibleRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RedeemFlexibleProductTradeError](Errors/RedeemFlexibleProductTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedRedeemResponse&gt; RedeemLockedProductTrade(RedeemLockedProductTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.RedeemLockedProductTrade(new RedeemLockedProductTradeRequest
    {
        PositionId = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedRedeemResponse
}
catch (ApiException<RedeemLockedProductTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RedeemLockedProductTradeRequest](Requests/SimpleEarn/RedeemLockedProductTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedRedeemResponse](Models/SapiV1SimpleEarnLockedRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RedeemLockedProductTradeError](Errors/RedeemLockedProductTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse&gt; SetFlexibleAutoSubscribeUserData(SetFlexibleAutoSubscribeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.SetFlexibleAutoSubscribeUserData(new SetFlexibleAutoSubscribeUserDataRequest
    {
        ProductId = "some example string",
        AutoSubscribe = true,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse
}
catch (ApiException<SetFlexibleAutoSubscribeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetFlexibleAutoSubscribeUserDataRequest](Requests/SimpleEarn/SetFlexibleAutoSubscribeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse](Models/SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SetFlexibleAutoSubscribeUserDataError](Errors/SetFlexibleAutoSubscribeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedSetAutoSubscribeResponse&gt; SetLockedAutoSubscribeUserData(SetLockedAutoSubscribeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.SetLockedAutoSubscribeUserData(new SetLockedAutoSubscribeUserDataRequest
    {
        PositionId = "some example string",
        AutoSubscribe = true,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedSetAutoSubscribeResponse
}
catch (ApiException<SetLockedAutoSubscribeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetLockedAutoSubscribeUserDataRequest](Requests/SimpleEarn/SetLockedAutoSubscribeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedSetAutoSubscribeResponse](Models/SapiV1SimpleEarnLockedSetAutoSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SetLockedAutoSubscribeUserDataError](Errors/SetLockedAutoSubscribeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedSetRedeemOptionResponse&gt; SetLockedProductRedeemOptionUserData(SetLockedProductRedeemOptionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.SetLockedProductRedeemOptionUserData(
        new SetLockedProductRedeemOptionUserDataRequest
        {
            PositionId = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedSetRedeemOptionResponse
}
catch (ApiException<SetLockedProductRedeemOptionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetLockedProductRedeemOptionUserDataRequest](Requests/SimpleEarn/SetLockedProductRedeemOptionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedSetRedeemOptionResponse](Models/SapiV1SimpleEarnLockedSetRedeemOptionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SetLockedProductRedeemOptionUserDataError](Errors/SetLockedProductRedeemOptionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnAccountResponse&gt; SimpleAccountUserData(SimpleAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.SimpleAccountUserData(new SimpleAccountUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnAccountResponse
}
catch (ApiException<SimpleAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SimpleAccountUserDataRequest](Requests/SimpleEarn/SimpleAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnAccountResponse](Models/SapiV1SimpleEarnAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SimpleAccountUserDataError](Errors/SimpleAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnFlexibleSubscribeResponse&gt; SubscribeFlexibleProductTrade(SubscribeFlexibleProductTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.SubscribeFlexibleProductTrade(new SubscribeFlexibleProductTradeRequest
    {
        ProductId = "some example string",
        Amount = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnFlexibleSubscribeResponse
}
catch (ApiException<SubscribeFlexibleProductTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubscribeFlexibleProductTradeRequest](Requests/SimpleEarn/SubscribeFlexibleProductTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleSubscribeResponse](Models/SapiV1SimpleEarnFlexibleSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubscribeFlexibleProductTradeError](Errors/SubscribeFlexibleProductTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SimpleEarnLockedSubscribeResponse&gt; SubscribeLockedProductTrade(SubscribeLockedProductTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SimpleEarn.SubscribeLockedProductTrade(new SubscribeLockedProductTradeRequest
    {
        ProjectId = "some example string",
        Amount = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SimpleEarnLockedSubscribeResponse
}
catch (ApiException<SubscribeLockedProductTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubscribeLockedProductTradeRequest](Requests/SimpleEarn/SubscribeLockedProductTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedSubscribeResponse](Models/SapiV1SimpleEarnLockedSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubscribeLockedProductTradeError](Errors/SubscribeLockedProductTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SpotAlgo

> Source: [SpotAlgo](Api/SpotAlgo.cs)

<details>
<summary><code>Task&lt;SapiV1AlgoSpotOrderResponse&gt; CancelAlgoOrder(CancelAlgoOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SpotAlgo.CancelAlgoOrder(new CancelAlgoOrderRequest
    {
        AlgoId = 1L,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AlgoSpotOrderResponse
}
catch (ApiException<CancelAlgoOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelAlgoOrderRequest](Requests/SpotAlgo/CancelAlgoOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotOrderResponse](Models/SapiV1AlgoSpotOrderResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelAlgoOrderError](Errors/CancelAlgoOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoSpotOpenOrdersResponse&gt; QueryCurrentAlgoOpenOrders(QueryCurrentAlgoOpenOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SpotAlgo.QueryCurrentAlgoOpenOrders(new QueryCurrentAlgoOpenOrdersRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AlgoSpotOpenOrdersResponse
}
catch (ApiException<QueryCurrentAlgoOpenOrdersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryCurrentAlgoOpenOrdersRequest](Requests/SpotAlgo/QueryCurrentAlgoOpenOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotOpenOrdersResponse](Models/SapiV1AlgoSpotOpenOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryCurrentAlgoOpenOrdersError](Errors/QueryCurrentAlgoOpenOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoSpotHistoricalOrdersResponse&gt; QueryHistoricalAlgoOrders(QueryHistoricalAlgoOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SpotAlgo.QueryHistoricalAlgoOrders(new QueryHistoricalAlgoOrdersRequest
    {
        Symbol = "BNBUSDT",
        Side = Side.Sell,
        Timestamp = 1L,
        Signature = "some example string",
        Page = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AlgoSpotHistoricalOrdersResponse
}
catch (ApiException<QueryHistoricalAlgoOrdersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryHistoricalAlgoOrdersRequest](Requests/SpotAlgo/QueryHistoricalAlgoOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotHistoricalOrdersResponse](Models/SapiV1AlgoSpotHistoricalOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryHistoricalAlgoOrdersError](Errors/QueryHistoricalAlgoOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoSpotSubOrdersResponse&gt; QuerySubOrders(QuerySubOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SpotAlgo.QuerySubOrders(new QuerySubOrdersRequest
    {
        AlgoId = 1L,
        Timestamp = 1L,
        Signature = "some example string",
        Page = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AlgoSpotSubOrdersResponse
}
catch (ApiException<QuerySubOrdersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QuerySubOrdersRequest](Requests/SpotAlgo/QuerySubOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotSubOrdersResponse](Models/SapiV1AlgoSpotSubOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QuerySubOrdersError](Errors/QuerySubOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AlgoSpotNewOrderTwapResponse&gt; TimeWeightedAveragePriceTwapNewOrder(TimeWeightedAveragePriceTwapNewOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SpotAlgo.TimeWeightedAveragePriceTwapNewOrder(
        new TimeWeightedAveragePriceTwapNewOrderRequest
        {
            Symbol = "BNBUSDT",
            Side = Side.Sell,
            Quantity = 1d,
            Duration = 300,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1AlgoSpotNewOrderTwapResponse
}
catch (ApiException<TimeWeightedAveragePriceTwapNewOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TimeWeightedAveragePriceTwapNewOrderRequest](Requests/SpotAlgo/TimeWeightedAveragePriceTwapNewOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotNewOrderTwapResponse](Models/SapiV1AlgoSpotNewOrderTwapResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TimeWeightedAveragePriceTwapNewOrderError](Errors/TimeWeightedAveragePriceTwapNewOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Staking

> Source: [Staking](Api/Staking.cs)

<details>
<summary><code>Task&lt;SapiV2EthStakingAccountResponse&gt; EthStakingAccountV2UserData(EthStakingAccountV2UserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.EthStakingAccountV2UserData(new EthStakingAccountV2UserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV2EthStakingAccountResponse
}
catch (ApiException<EthStakingAccountV2UserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EthStakingAccountV2UserDataRequest](Requests/Staking/EthStakingAccountV2UserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2EthStakingAccountResponse](Models/SapiV2EthStakingAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EthStakingAccountV2UserDataError](Errors/EthStakingAccountV2UserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryRewardsHistoryResponse&gt; GetBethRewardsDistributionHistoryUserData(GetBethRewardsDistributionHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.GetBethRewardsDistributionHistoryUserData(
        new GetBethRewardsDistributionHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryRewardsHistoryResponse
}
catch (ApiException<GetBethRewardsDistributionHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBethRewardsDistributionHistoryUserDataRequest](Requests/Staking/GetBethRewardsDistributionHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryRewardsHistoryResponse](Models/SapiV1EthStakingEthHistoryRewardsHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetBethRewardsDistributionHistoryUserDataError](Errors/GetBethRewardsDistributionHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryRedemptionHistoryResponse&gt; GetEthRedemptionHistoryUserData(GetEthRedemptionHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.GetEthRedemptionHistoryUserData(new GetEthRedemptionHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryRedemptionHistoryResponse
}
catch (ApiException<GetEthRedemptionHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEthRedemptionHistoryUserDataRequest](Requests/Staking/GetEthRedemptionHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryRedemptionHistoryResponse](Models/SapiV1EthStakingEthHistoryRedemptionHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEthRedemptionHistoryUserDataError](Errors/GetEthRedemptionHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryStakingHistoryResponse&gt; GetEthStakingHistoryUserData(GetEthStakingHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.GetEthStakingHistoryUserData(new GetEthStakingHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryStakingHistoryResponse
}
catch (ApiException<GetEthStakingHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEthStakingHistoryUserDataRequest](Requests/Staking/GetEthStakingHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryStakingHistoryResponse](Models/SapiV1EthStakingEthHistoryStakingHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEthStakingHistoryUserDataError](Errors/GetEthStakingHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryRateHistoryResponse&gt; GetWbethRateHistoryUserData(GetWbethRateHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.GetWbethRateHistoryUserData(new GetWbethRateHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryRateHistoryResponse
}
catch (ApiException<GetWbethRateHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetWbethRateHistoryUserDataRequest](Requests/Staking/GetWbethRateHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryRateHistoryResponse](Models/SapiV1EthStakingEthHistoryRateHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetWbethRateHistoryUserDataError](Errors/GetWbethRateHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse&gt; GetWbethRewardsHistoryUserData(GetWbethRewardsHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.GetWbethRewardsHistoryUserData(new GetWbethRewardsHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse
}
catch (ApiException<GetWbethRewardsHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetWbethRewardsHistoryUserDataRequest](Requests/Staking/GetWbethRewardsHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse](Models/SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetWbethRewardsHistoryUserDataError](Errors/GetWbethRewardsHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingWbethHistoryUnwrapHistoryResponse&gt; GetWbethUnwrapHistoryUserData(GetWbethUnwrapHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.GetWbethUnwrapHistoryUserData(new GetWbethUnwrapHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1EthStakingWbethHistoryUnwrapHistoryResponse
}
catch (ApiException<GetWbethUnwrapHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetWbethUnwrapHistoryUserDataRequest](Requests/Staking/GetWbethUnwrapHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingWbethHistoryUnwrapHistoryResponse](Models/SapiV1EthStakingWbethHistoryUnwrapHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetWbethUnwrapHistoryUserDataError](Errors/GetWbethUnwrapHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingWbethHistoryWrapHistoryResponse&gt; GetWbethWrapHistoryUserData(GetWbethWrapHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.GetWbethWrapHistoryUserData(new GetWbethWrapHistoryUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1EthStakingWbethHistoryWrapHistoryResponse
}
catch (ApiException<GetWbethWrapHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetWbethWrapHistoryUserDataRequest](Requests/Staking/GetWbethWrapHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingWbethHistoryWrapHistoryResponse](Models/SapiV1EthStakingWbethHistoryWrapHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetWbethWrapHistoryUserDataError](Errors/GetWbethWrapHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthQuotaResponse&gt; GetCurrentEthStakingQuotaUserData(GetCurrentEthStakingQuotaUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.GetCurrentEthStakingQuotaUserData(new GetCurrentEthStakingQuotaUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1EthStakingEthQuotaResponse
}
catch (ApiException<GetCurrentEthStakingQuotaUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCurrentEthStakingQuotaUserDataRequest](Requests/Staking/GetCurrentEthStakingQuotaUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthQuotaResponse](Models/SapiV1EthStakingEthQuotaResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCurrentEthStakingQuotaUserDataError](Errors/GetCurrentEthStakingQuotaUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingEthRedeemResponse&gt; RedeemEthTrade(RedeemEthTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.RedeemEthTrade(new RedeemEthTradeRequest
    {
        Amount = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1EthStakingEthRedeemResponse
}
catch (ApiException<RedeemEthTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RedeemEthTradeRequest](Requests/Staking/RedeemEthTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthRedeemResponse](Models/SapiV1EthStakingEthRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RedeemEthTradeError](Errors/RedeemEthTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2EthStakingEthStakeResponse&gt; SubscribeEthStakingV2Trade(SubscribeEthStakingV2TradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.SubscribeEthStakingV2Trade(new SubscribeEthStakingV2TradeRequest
    {
        Amount = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV2EthStakingEthStakeResponse
}
catch (ApiException<SubscribeEthStakingV2TradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubscribeEthStakingV2TradeRequest](Requests/Staking/SubscribeEthStakingV2TradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2EthStakingEthStakeResponse](Models/SapiV2EthStakingEthStakeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubscribeEthStakingV2TradeError](Errors/SubscribeEthStakingV2TradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1EthStakingWbethWrapResponse&gt; WrapBethTrade(WrapBethTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Staking.WrapBethTrade(new WrapBethTradeRequest
    {
        Amount = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1EthStakingWbethWrapResponse
}
catch (ApiException<WrapBethTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WrapBethTradeRequest](Requests/Staking/WrapBethTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingWbethWrapResponse](Models/SapiV1EthStakingWbethWrapResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[WrapBethTradeError](Errors/WrapBethTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Stream

> Source: [Stream](Api/Stream.cs)

<details>
<summary><code>Task&lt;object&gt; CloseAListenKeyUserStream(CloseAListenKeyUserStreamRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Stream.CloseAListenKeyUserStream(new CloseAListenKeyUserStreamRequest
    {
        ListenKey = "pqia91ma19a5s61cv6a81va65sdf19v8a65a1a5s61cv6a81va65sdf19v8a65a1",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<CloseAListenKeyUserStreamError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CloseAListenKeyUserStreamRequest](Requests/Stream/CloseAListenKeyUserStreamRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CloseAListenKeyUserStreamError](Errors/CloseAListenKeyUserStreamError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3UserDataStreamResponse&gt; CreateAListenKeyUserStream(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Stream.CreateAListenKeyUserStream();
    // TODO: Handle 'response' of type ApiV3UserDataStreamResponse
}
catch (ApiException<RawError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; PingKeepAliveAListenKeyUserStream(PingKeepAliveAListenKeyUserStreamRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Stream.PingKeepAliveAListenKeyUserStream(new PingKeepAliveAListenKeyUserStreamRequest
    {
        ListenKey = "pqia91ma19a5s61cv6a81va65sdf19v8a65a1a5s61cv6a81va65sdf19v8a65a1",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<PingKeepAliveAListenKeyUserStreamError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PingKeepAliveAListenKeyUserStreamRequest](Requests/Stream/PingKeepAliveAListenKeyUserStreamRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PingKeepAliveAListenKeyUserStreamError](Errors/PingKeepAliveAListenKeyUserStreamError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SubAccountApi

> Source: [SubAccountApi](Api/SubAccountApi.cs)

<details>
<summary><code>Task&lt;SapiV1SubAccountVirtualSubAccountResponse&gt; CreateAVirtualSubAccountForMasterAccount(CreateAVirtualSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.CreateAVirtualSubAccountForMasterAccount(
        new CreateAVirtualSubAccountForMasterAccountRequest
        {
            SubAccountString = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountVirtualSubAccountResponse
}
catch (ApiException<CreateAVirtualSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateAVirtualSubAccountForMasterAccountRequest](Requests/SubAccountApi/CreateAVirtualSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountVirtualSubAccountResponse](Models/SapiV1SubAccountVirtualSubAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateAVirtualSubAccountForMasterAccountError](Errors/CreateAVirtualSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse&gt; DeleteIpListForASubAccountApiKeyForMasterAccount(DeleteIpListForASubAccountApiKeyForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.DeleteIpListForASubAccountApiKeyForMasterAccount(
        new DeleteIpListForASubAccountApiKeyForMasterAccountRequest
        {
            Email = "some example string",
            SubAccountApiKey = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse
}
catch (ApiException<DeleteIpListForASubAccountApiKeyForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteIpListForASubAccountApiKeyForMasterAccountRequest](Requests/SubAccountApi/DeleteIpListForASubAccountApiKeyForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse](Models/SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteIpListForASubAccountApiKeyForMasterAccountError](Errors/DeleteIpListForASubAccountApiKeyForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountDepositResponse&gt; DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount(DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount(
        new DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest
        {
            ToEmail = "some example string",
            Asset = "BTC",
            Amount = 1.01d,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountDepositResponse
}
catch (ApiException<DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest](Requests/SubAccountApi/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountDepositResponse](Models/SapiV1ManagedSubaccountDepositResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError](Errors/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesAccountResponse&gt; DetailOnSubAccountSFuturesAccountForMasterAccount(DetailOnSubAccountSFuturesAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.DetailOnSubAccountSFuturesAccountForMasterAccount(
        new DetailOnSubAccountSFuturesAccountForMasterAccountRequest
        {
            Email = "alice@test.com",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesAccountResponse
}
catch (ApiException<DetailOnSubAccountSFuturesAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DetailOnSubAccountSFuturesAccountForMasterAccountRequest](Requests/SubAccountApi/DetailOnSubAccountSFuturesAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesAccountResponse](Models/SapiV1SubAccountFuturesAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DetailOnSubAccountSFuturesAccountForMasterAccountError](Errors/DetailOnSubAccountSFuturesAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2SubAccountFuturesAccountResponse&gt; DetailOnSubAccountSFuturesAccountV2ForMasterAccount(DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.DetailOnSubAccountSFuturesAccountV2ForMasterAccount(
        new DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest
        {
            Email = "some example string",
            FuturesType = 1,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2SubAccountFuturesAccountResponse
}
catch (ApiException<DetailOnSubAccountSFuturesAccountV2ForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest](Requests/SubAccountApi/DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountFuturesAccountResponse](Models/AnyOf/SapiV2SubAccountFuturesAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DetailOnSubAccountSFuturesAccountV2ForMasterAccountError](Errors/DetailOnSubAccountSFuturesAccountV2ForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountMarginAccountResponse&gt; DetailOnSubAccountSMarginAccountForMasterAccount(DetailOnSubAccountSMarginAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.DetailOnSubAccountSMarginAccountForMasterAccount(
        new DetailOnSubAccountSMarginAccountForMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountMarginAccountResponse
}
catch (ApiException<DetailOnSubAccountSMarginAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DetailOnSubAccountSMarginAccountForMasterAccountRequest](Requests/SubAccountApi/DetailOnSubAccountSMarginAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginAccountResponse](Models/SapiV1SubAccountMarginAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DetailOnSubAccountSMarginAccountForMasterAccountError](Errors/DetailOnSubAccountSMarginAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesEnableResponse&gt; EnableFuturesForSubAccountForMasterAccount(EnableFuturesForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.EnableFuturesForSubAccountForMasterAccount(
        new EnableFuturesForSubAccountForMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesEnableResponse
}
catch (ApiException<EnableFuturesForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableFuturesForSubAccountForMasterAccountRequest](Requests/SubAccountApi/EnableFuturesForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesEnableResponse](Models/SapiV1SubAccountFuturesEnableResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EnableFuturesForSubAccountForMasterAccountError](Errors/EnableFuturesForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountBlvtEnableResponse&gt; EnableLeverageTokenForSubAccountForMasterAccount(EnableLeverageTokenForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.EnableLeverageTokenForSubAccountForMasterAccount(
        new EnableLeverageTokenForSubAccountForMasterAccountRequest
        {
            Email = "some example string",
            EnableBlvt = true,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountBlvtEnableResponse
}
catch (ApiException<EnableLeverageTokenForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableLeverageTokenForSubAccountForMasterAccountRequest](Requests/SubAccountApi/EnableLeverageTokenForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountBlvtEnableResponse](Models/SapiV1SubAccountBlvtEnableResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EnableLeverageTokenForSubAccountForMasterAccountError](Errors/EnableLeverageTokenForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountMarginEnableResponse&gt; EnableMarginForSubAccountForMasterAccount(EnableMarginForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.EnableMarginForSubAccountForMasterAccount(
        new EnableMarginForSubAccountForMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountMarginEnableResponse
}
catch (ApiException<EnableMarginForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableMarginForSubAccountForMasterAccountRequest](Requests/SubAccountApi/EnableMarginForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginEnableResponse](Models/SapiV1SubAccountMarginEnableResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EnableMarginForSubAccountForMasterAccountError](Errors/EnableMarginForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountEoptionsEnableResponse&gt; EnableOptionsForSubAccountForMasterAccountUserData(EnableOptionsForSubAccountForMasterAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.EnableOptionsForSubAccountForMasterAccountUserData(
        new EnableOptionsForSubAccountForMasterAccountUserDataRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountEoptionsEnableResponse
}
catch (ApiException<EnableOptionsForSubAccountForMasterAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableOptionsForSubAccountForMasterAccountUserDataRequest](Requests/SubAccountApi/EnableOptionsForSubAccountForMasterAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountEoptionsEnableResponse](Models/SapiV1SubAccountEoptionsEnableResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EnableOptionsForSubAccountForMasterAccountUserDataError](Errors/EnableOptionsForSubAccountForMasterAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountFuturesPositionRiskResponse&gt;&gt; FuturesPositionRiskOfSubAccountForMasterAccount(FuturesPositionRiskOfSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.FuturesPositionRiskOfSubAccountForMasterAccount(
        new FuturesPositionRiskOfSubAccountForMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountFuturesPositionRiskResponse>
}
catch (ApiException<FuturesPositionRiskOfSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FuturesPositionRiskOfSubAccountForMasterAccountRequest](Requests/SubAccountApi/FuturesPositionRiskOfSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountFuturesPositionRiskResponse](Models/SapiV1SubAccountFuturesPositionRiskResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FuturesPositionRiskOfSubAccountForMasterAccountError](Errors/FuturesPositionRiskOfSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2SubAccountFuturesPositionRiskResponse&gt; FuturesPositionRiskOfSubAccountV2ForMasterAccount(FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.FuturesPositionRiskOfSubAccountV2ForMasterAccount(
        new FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest
        {
            Email = "some example string",
            FuturesType = 1,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2SubAccountFuturesPositionRiskResponse
}
catch (ApiException<FuturesPositionRiskOfSubAccountV2ForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest](Requests/SubAccountApi/FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountFuturesPositionRiskResponse](Models/AnyOf/SapiV2SubAccountFuturesPositionRiskResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FuturesPositionRiskOfSubAccountV2ForMasterAccountError](Errors/FuturesPositionRiskOfSubAccountV2ForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountSubAccountApiIpRestrictionResponse&gt; GetIpRestrictionForASubAccountApiKeyForMasterAccount(GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.GetIpRestrictionForASubAccountApiKeyForMasterAccount(
        new GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest
        {
            Email = "some example string",
            SubAccountApiKey = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountSubAccountApiIpRestrictionResponse
}
catch (ApiException<GetIpRestrictionForASubAccountApiKeyForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest](Requests/SubAccountApi/GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountSubAccountApiIpRestrictionResponse](Models/SapiV1SubAccountSubAccountApiIpRestrictionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetIpRestrictionForASubAccountApiKeyForMasterAccountError](Errors/GetIpRestrictionForASubAccountApiKeyForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountDepositAddressResponse&gt; GetManagedSubAccountDepositAddressForInvestorMasterAccount(GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.GetManagedSubAccountDepositAddressForInvestorMasterAccount(
        new GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest
        {
            Email = "some example string",
            Coin = "BNB",
            Timestamp = 1L,
            Signature = "some example string",
            Network = "BTC",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountDepositAddressResponse
}
catch (ApiException<GetManagedSubAccountDepositAddressForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest](Requests/SubAccountApi/GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountDepositAddressResponse](Models/SapiV1ManagedSubaccountDepositAddressResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetManagedSubAccountDepositAddressForInvestorMasterAccountError](Errors/GetManagedSubAccountDepositAddressForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1ManagedSubaccountAssetResponse&gt;&gt; ManagedSubAccountAssetDetailsForInvestorMasterAccount(ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.ManagedSubAccountAssetDetailsForInvestorMasterAccount(
        new ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1ManagedSubaccountAssetResponse>
}
catch (ApiException<ManagedSubAccountAssetDetailsForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest](Requests/SubAccountApi/ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1ManagedSubaccountAssetResponse](Models/SapiV1ManagedSubaccountAssetResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ManagedSubAccountAssetDetailsForInvestorMasterAccountError](Errors/ManagedSubAccountAssetDetailsForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountAccountSnapshotResponse&gt; ManagedSubAccountSnapshotForInvestorMasterAccount(ManagedSubAccountSnapshotForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.ManagedSubAccountSnapshotForInvestorMasterAccount(
        new ManagedSubAccountSnapshotForInvestorMasterAccountRequest
        {
            Email = "some example string",
            Type = "SPOT",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountAccountSnapshotResponse
}
catch (ApiException<ManagedSubAccountSnapshotForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ManagedSubAccountSnapshotForInvestorMasterAccountRequest](Requests/SubAccountApi/ManagedSubAccountSnapshotForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountAccountSnapshotResponse](Models/SapiV1ManagedSubaccountAccountSnapshotResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ManagedSubAccountSnapshotForInvestorMasterAccountError](Errors/ManagedSubAccountSnapshotForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountMarginTransferResponse&gt; MarginTransferForSubAccountForMasterAccount(MarginTransferForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.MarginTransferForSubAccountForMasterAccount(
        new MarginTransferForSubAccountForMasterAccountRequest
        {
            Email = "some example string",
            Asset = "BTC",
            Amount = 1.01d,
            Type = 1,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountMarginTransferResponse
}
catch (ApiException<MarginTransferForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarginTransferForSubAccountForMasterAccountRequest](Requests/SubAccountApi/MarginTransferForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginTransferResponse](Models/SapiV1SubAccountMarginTransferResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[MarginTransferForSubAccountForMasterAccountError](Errors/MarginTransferForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountQueryTransLogForInvestorResponse&gt; QueryManagedSubAccountTransferLogForInvestorMasterAccount(QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.QueryManagedSubAccountTransferLogForInvestorMasterAccount(
        new QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            Limit = 5,
            Transfers = "FROM",
            TransferFunctionAccountType = "SPOT",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountQueryTransLogForInvestorResponse
}
catch (ApiException<QueryManagedSubAccountTransferLogForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest](Requests/SubAccountApi/QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountQueryTransLogForInvestorResponse](Models/SapiV1ManagedSubaccountQueryTransLogForInvestorResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountTransferLogForInvestorMasterAccountError](Errors/QueryManagedSubAccountTransferLogForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse&gt; QueryManagedSubAccountTransferLogForTradingTeamMasterAccount(QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.QueryManagedSubAccountTransferLogForTradingTeamMasterAccount(
        new QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            Limit = 5,
            Transfers = "FROM",
            TransferFunctionAccountType = "SPOT",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse
}
catch (ApiException<QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest](Requests/SubAccountApi/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse](Models/SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError](Errors/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountQueryTransLogResponse&gt; QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData(QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData(
        new QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest
        {
            Transfers = Transfers.From,
            TransferFunctionAccountType = TransferFunctionAccountType.Spot,
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountQueryTransLogResponse
}
catch (ApiException<QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest](Requests/SubAccountApi/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountQueryTransLogResponse](Models/SapiV1ManagedSubaccountQueryTransLogResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError](Errors/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountFetchFutureAssetResponse&gt; QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount(QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount(
        new QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountFetchFutureAssetResponse
}
catch (ApiException<QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest](Requests/SubAccountApi/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountFetchFutureAssetResponse](Models/SapiV1ManagedSubaccountFetchFutureAssetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError](Errors/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountInfoResponse&gt; QueryManagedSubAccountListForInvestor(QueryManagedSubAccountListForInvestorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.QueryManagedSubAccountListForInvestor(
        new QueryManagedSubAccountListForInvestorRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountInfoResponse
}
catch (ApiException<QueryManagedSubAccountListForInvestorError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryManagedSubAccountListForInvestorRequest](Requests/SubAccountApi/QueryManagedSubAccountListForInvestorRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountInfoResponse](Models/SapiV1ManagedSubaccountInfoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountListForInvestorError](Errors/QueryManagedSubAccountListForInvestorError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountMarginAssetResponse&gt; QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount(QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount(
        new QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountMarginAssetResponse
}
catch (ApiException<QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest](Requests/SubAccountApi/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountMarginAssetResponse](Models/SapiV1ManagedSubaccountMarginAssetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError](Errors/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV4SubAccountAssetsResponse&gt; QuerySubAccountAssetsForMasterAccount(QuerySubAccountAssetsForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.QuerySubAccountAssetsForMasterAccount(
        new QuerySubAccountAssetsForMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV4SubAccountAssetsResponse
}
catch (ApiException<QuerySubAccountAssetsForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QuerySubAccountAssetsForMasterAccountRequest](Requests/SubAccountApi/QuerySubAccountAssetsForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV4SubAccountAssetsResponse](Models/SapiV4SubAccountAssetsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QuerySubAccountAssetsForMasterAccountError](Errors/QuerySubAccountAssetsForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountListResponse&gt; QuerySubAccountListForMasterAccount(QuerySubAccountListForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.QuerySubAccountListForMasterAccount(
        new QuerySubAccountListForMasterAccountRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            Limit = 1,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountListResponse
}
catch (ApiException<QuerySubAccountListForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QuerySubAccountListForMasterAccountRequest](Requests/SubAccountApi/QuerySubAccountListForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountListResponse](Models/SapiV1SubAccountListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QuerySubAccountListForMasterAccountError](Errors/QuerySubAccountListForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountTransactionStatisticsResponse&gt; QuerySubAccountTransactionStatisticsForMasterAccount(QuerySubAccountTransactionStatisticsForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.QuerySubAccountTransactionStatisticsForMasterAccount(
        new QuerySubAccountTransactionStatisticsForMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountTransactionStatisticsResponse
}
catch (ApiException<QuerySubAccountTransactionStatisticsForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QuerySubAccountTransactionStatisticsForMasterAccountRequest](Requests/SubAccountApi/QuerySubAccountTransactionStatisticsForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountTransactionStatisticsResponse](Models/SapiV1SubAccountTransactionStatisticsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QuerySubAccountTransactionStatisticsForMasterAccountError](Errors/QuerySubAccountTransactionStatisticsForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV3SubAccountAssetsResponse&gt; SubAccountAssetsForMasterAccount(SubAccountAssetsForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SubAccountAssetsForMasterAccount(
        new SubAccountAssetsForMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV3SubAccountAssetsResponse
}
catch (ApiException<SubAccountAssetsForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubAccountAssetsForMasterAccountRequest](Requests/SubAccountApi/SubAccountAssetsForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV3SubAccountAssetsResponse](Models/SapiV3SubAccountAssetsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubAccountAssetsForMasterAccountError](Errors/SubAccountAssetsForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalDepositSubHisrecResponse&gt;&gt; SubAccountDepositHistoryForMasterAccount(SubAccountDepositHistoryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SubAccountDepositHistoryForMasterAccount(
        new SubAccountDepositHistoryForMasterAccountRequest
        {
            Email = "some example string",
            Timestamp = 1L,
            Signature = "some example string",
            Coin = "BNB",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalDepositSubHisrecResponse>
}
catch (ApiException<SubAccountDepositHistoryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubAccountDepositHistoryForMasterAccountRequest](Requests/SubAccountApi/SubAccountDepositHistoryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalDepositSubHisrecResponse](Models/SapiV1CapitalDepositSubHisrecResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubAccountDepositHistoryForMasterAccountError](Errors/SubAccountDepositHistoryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesInternalTransferResponse1&gt; SubAccountFuturesAssetTransferForMasterAccount(SubAccountFuturesAssetTransferForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SubAccountFuturesAssetTransferForMasterAccount(
        new SubAccountFuturesAssetTransferForMasterAccountRequest
        {
            FromEmail = "some example string",
            ToEmail = "some example string",
            FuturesType = 2,
            Asset = "BTC",
            Amount = 1.01d,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesInternalTransferResponse1
}
catch (ApiException<SubAccountFuturesAssetTransferForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubAccountFuturesAssetTransferForMasterAccountRequest](Requests/SubAccountApi/SubAccountFuturesAssetTransferForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesInternalTransferResponse1](Models/SapiV1SubAccountFuturesInternalTransferResponse1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubAccountFuturesAssetTransferForMasterAccountError](Errors/SubAccountFuturesAssetTransferForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesInternalTransferResponse&gt; SubAccountFuturesAssetTransferHistoryForMasterAccount(SubAccountFuturesAssetTransferHistoryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SubAccountFuturesAssetTransferHistoryForMasterAccount(
        new SubAccountFuturesAssetTransferHistoryForMasterAccountRequest
        {
            Email = "some example string",
            FuturesType = 2,
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesInternalTransferResponse
}
catch (ApiException<SubAccountFuturesAssetTransferHistoryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubAccountFuturesAssetTransferHistoryForMasterAccountRequest](Requests/SubAccountApi/SubAccountFuturesAssetTransferHistoryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesInternalTransferResponse](Models/SapiV1SubAccountFuturesInternalTransferResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubAccountFuturesAssetTransferHistoryForMasterAccountError](Errors/SubAccountFuturesAssetTransferHistoryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountSubTransferHistoryResponse&gt;&gt; SubAccountSpotAssetTransferHistoryForMasterAccount(SubAccountSpotAssetTransferHistoryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SubAccountSpotAssetTransferHistoryForMasterAccount(
        new SubAccountSpotAssetTransferHistoryForMasterAccountRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            Limit = 1,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountSubTransferHistoryResponse>
}
catch (ApiException<SubAccountSpotAssetTransferHistoryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubAccountSpotAssetTransferHistoryForMasterAccountRequest](Requests/SubAccountApi/SubAccountSpotAssetTransferHistoryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountSubTransferHistoryResponse](Models/SapiV1SubAccountSubTransferHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubAccountSpotAssetTransferHistoryForMasterAccountError](Errors/SubAccountSpotAssetTransferHistoryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountSpotSummaryResponse&gt; SubAccountSpotAssetsSummaryForMasterAccount(SubAccountSpotAssetsSummaryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SubAccountSpotAssetsSummaryForMasterAccount(
        new SubAccountSpotAssetsSummaryForMasterAccountRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountSpotSummaryResponse
}
catch (ApiException<SubAccountSpotAssetsSummaryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubAccountSpotAssetsSummaryForMasterAccountRequest](Requests/SubAccountApi/SubAccountSpotAssetsSummaryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountSpotSummaryResponse](Models/SapiV1SubAccountSpotSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubAccountSpotAssetsSummaryForMasterAccountError](Errors/SubAccountSpotAssetsSummaryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalDepositSubAddressResponse&gt; SubAccountSpotAssetsSummaryForMasterAccount2(SubAccountSpotAssetsSummaryForMasterAccount2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SubAccountSpotAssetsSummaryForMasterAccount2(
        new SubAccountSpotAssetsSummaryForMasterAccount2Request
        {
            Email = "some example string",
            Coin = "BNB",
            Timestamp = 1L,
            Signature = "some example string",
            Network = "BTC",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1CapitalDepositSubAddressResponse
}
catch (ApiException<SubAccountSpotAssetsSummaryForMasterAccount2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubAccountSpotAssetsSummaryForMasterAccount2Request](Requests/SubAccountApi/SubAccountSpotAssetsSummaryForMasterAccount2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalDepositSubAddressResponse](Models/SapiV1CapitalDepositSubAddressResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubAccountSpotAssetsSummaryForMasterAccount2Error](Errors/SubAccountSpotAssetsSummaryForMasterAccount2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountTransferSubUserHistoryResponse&gt;&gt; SubAccountTransferHistoryForSubAccount(SubAccountTransferHistoryForSubAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SubAccountTransferHistoryForSubAccount(
        new SubAccountTransferHistoryForSubAccountRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Asset = "BNB",
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountTransferSubUserHistoryResponse>
}
catch (ApiException<SubAccountTransferHistoryForSubAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubAccountTransferHistoryForSubAccountRequest](Requests/SubAccountApi/SubAccountTransferHistoryForSubAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountTransferSubUserHistoryResponse](Models/SapiV1SubAccountTransferSubUserHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubAccountTransferHistoryForSubAccountError](Errors/SubAccountTransferHistoryForSubAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountStatusResponse&gt;&gt; SubAccountSStatusOnMarginFuturesForMasterAccount(SubAccountSStatusOnMarginFuturesForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SubAccountSStatusOnMarginFuturesForMasterAccount(
        new SubAccountSStatusOnMarginFuturesForMasterAccountRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountStatusResponse>
}
catch (ApiException<SubAccountSStatusOnMarginFuturesForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubAccountSStatusOnMarginFuturesForMasterAccountRequest](Requests/SubAccountApi/SubAccountSStatusOnMarginFuturesForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountStatusResponse](Models/SapiV1SubAccountStatusResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubAccountSStatusOnMarginFuturesForMasterAccountError](Errors/SubAccountSStatusOnMarginFuturesForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesAccountSummaryResponse&gt; SummaryOfSubAccountSFuturesAccountForMasterAccount(SummaryOfSubAccountSFuturesAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SummaryOfSubAccountSFuturesAccountForMasterAccount(
        new SummaryOfSubAccountSFuturesAccountForMasterAccountRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesAccountSummaryResponse
}
catch (ApiException<SummaryOfSubAccountSFuturesAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SummaryOfSubAccountSFuturesAccountForMasterAccountRequest](Requests/SubAccountApi/SummaryOfSubAccountSFuturesAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesAccountSummaryResponse](Models/SapiV1SubAccountFuturesAccountSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SummaryOfSubAccountSFuturesAccountForMasterAccountError](Errors/SummaryOfSubAccountSFuturesAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2SubAccountFuturesAccountSummaryResponse&gt; SummaryOfSubAccountSFuturesAccountV2ForMasterAccount(SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SummaryOfSubAccountSFuturesAccountV2ForMasterAccount(
        new SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest
        {
            FuturesType = 1,
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2SubAccountFuturesAccountSummaryResponse
}
catch (ApiException<SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest](Requests/SubAccountApi/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountFuturesAccountSummaryResponse](Models/AnyOf/SapiV2SubAccountFuturesAccountSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError](Errors/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountMarginAccountSummaryResponse&gt; SummaryOfSubAccountSMarginAccountForMasterAccount(SummaryOfSubAccountSMarginAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.SummaryOfSubAccountSMarginAccountForMasterAccount(
        new SummaryOfSubAccountSMarginAccountForMasterAccountRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountMarginAccountSummaryResponse
}
catch (ApiException<SummaryOfSubAccountSMarginAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SummaryOfSubAccountSMarginAccountForMasterAccountRequest](Requests/SubAccountApi/SummaryOfSubAccountSMarginAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginAccountSummaryResponse](Models/SapiV1SubAccountMarginAccountSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SummaryOfSubAccountSMarginAccountForMasterAccountError](Errors/SummaryOfSubAccountSMarginAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountFuturesTransferResponse&gt; TransferForSubAccountForMasterAccount(TransferForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.TransferForSubAccountForMasterAccount(
        new TransferForSubAccountForMasterAccountRequest
        {
            Email = "some example string",
            Asset = "BTC",
            Amount = 1.01d,
            Type = 1,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountFuturesTransferResponse
}
catch (ApiException<TransferForSubAccountForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferForSubAccountForMasterAccountRequest](Requests/SubAccountApi/TransferForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesTransferResponse](Models/SapiV1SubAccountFuturesTransferResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TransferForSubAccountForMasterAccountError](Errors/TransferForSubAccountForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountTransferSubToMasterResponse&gt; TransferToMasterForSubAccount(TransferToMasterForSubAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.TransferToMasterForSubAccount(new TransferToMasterForSubAccountRequest
    {
        Asset = "BTC",
        Amount = 1.01d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1SubAccountTransferSubToMasterResponse
}
catch (ApiException<TransferToMasterForSubAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferToMasterForSubAccountRequest](Requests/SubAccountApi/TransferToMasterForSubAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountTransferSubToMasterResponse](Models/SapiV1SubAccountTransferSubToMasterResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TransferToMasterForSubAccountError](Errors/TransferToMasterForSubAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountTransferSubToSubResponse&gt; TransferToSubAccountOfSameMasterForSubAccount(TransferToSubAccountOfSameMasterForSubAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.TransferToSubAccountOfSameMasterForSubAccount(
        new TransferToSubAccountOfSameMasterForSubAccountRequest
        {
            ToEmail = "some example string",
            Asset = "BTC",
            Amount = 1.01d,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountTransferSubToSubResponse
}
catch (ApiException<TransferToSubAccountOfSameMasterForSubAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferToSubAccountOfSameMasterForSubAccountRequest](Requests/SubAccountApi/TransferToSubAccountOfSameMasterForSubAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountTransferSubToSubResponse](Models/SapiV1SubAccountTransferSubToSubResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TransferToSubAccountOfSameMasterForSubAccountError](Errors/TransferToSubAccountOfSameMasterForSubAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SubAccountUniversalTransferResponse1&gt; UniversalTransferForMasterAccount(UniversalTransferForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.UniversalTransferForMasterAccount(
        new UniversalTransferForMasterAccountRequest
        {
            FromAccountType = FromAccountType.Spot,
            ToAccountType = ToAccountType.Spot,
            Asset = "BTC",
            Amount = 1.01d,
            Timestamp = 1L,
            Signature = "some example string",
            Symbol = "BNBUSDT",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1SubAccountUniversalTransferResponse1
}
catch (ApiException<UniversalTransferForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UniversalTransferForMasterAccountRequest](Requests/SubAccountApi/UniversalTransferForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountUniversalTransferResponse1](Models/SapiV1SubAccountUniversalTransferResponse1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UniversalTransferForMasterAccountError](Errors/UniversalTransferForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SubAccountUniversalTransferResponse&gt;&gt; UniversalTransferHistoryForMasterAccount(UniversalTransferHistoryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.UniversalTransferHistoryForMasterAccount(
        new UniversalTransferHistoryForMasterAccountRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Page = 1,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SubAccountUniversalTransferResponse>
}
catch (ApiException<UniversalTransferHistoryForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UniversalTransferHistoryForMasterAccountRequest](Requests/SubAccountApi/UniversalTransferHistoryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountUniversalTransferResponse](Models/SapiV1SubAccountUniversalTransferResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UniversalTransferHistoryForMasterAccountError](Errors/UniversalTransferHistoryForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV2SubAccountSubAccountApiIpRestrictionResponse&gt; UpdateIpRestrictionForSubAccountApiKeyForMasterAccount(UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.UpdateIpRestrictionForSubAccountApiKeyForMasterAccount(
        new UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest
        {
            Email = "some example string",
            SubAccountApiKey = "some example string",
            Status = "1",
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV2SubAccountSubAccountApiIpRestrictionResponse
}
catch (ApiException<UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest](Requests/SubAccountApi/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountSubAccountApiIpRestrictionResponse](Models/SapiV2SubAccountSubAccountApiIpRestrictionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError](Errors/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1ManagedSubaccountWithdrawResponse&gt; WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount(WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SubAccountApi.WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount(
        new WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest
        {
            FromEmail = "some example string",
            Asset = "BTC",
            Amount = 1.01d,
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1ManagedSubaccountWithdrawResponse
}
catch (ApiException<WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest](Requests/SubAccountApi/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountWithdrawResponse](Models/SapiV1ManagedSubaccountWithdrawResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError](Errors/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TradeApi

> Source: [TradeApi](Api/TradeApi.cs)

<details>
<summary><code>Task&lt;Account&gt; AccountInformationUserData(AccountInformationUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.AccountInformationUserData(new AccountInformationUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type Account
}
catch (ApiException<AccountInformationUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountInformationUserDataRequest](Requests/TradeApi/AccountInformationUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Account](Models/Account.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AccountInformationUserDataError](Errors/AccountInformationUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;MyTrade&gt;&gt; AccountTradeListUserData(AccountTradeListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.AccountTradeListUserData(new AccountTradeListUserDataRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 5,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<MyTrade>
}
catch (ApiException<AccountTradeListUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountTradeListUserDataRequest](Requests/TradeApi/AccountTradeListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MyTrade](Models/MyTrade.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AccountTradeListUserDataError](Errors/AccountTradeListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;OrderDetails&gt;&gt; AllOrdersUserData(AllOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.AllOrdersUserData(new AllOrdersUserDataRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 5,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<OrderDetails>
}
catch (ApiException<AllOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AllOrdersUserDataRequest](Requests/TradeApi/AllOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[OrderDetails](Models/OrderDetails.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AllOrdersUserDataError](Errors/AllOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OcoOrder&gt; CancelOcoTrade(CancelOcoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.CancelOcoTrade(new CancelOcoTradeRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type OcoOrder
}
catch (ApiException<CancelOcoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelOcoTradeRequest](Requests/TradeApi/CancelOcoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OcoOrder](Models/OcoOrder.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelOcoTradeError](Errors/CancelOcoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; CancelOrderTrade(CancelOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.CancelOrderTrade(new CancelOrderTradeRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        CancelRestrictions = CancelRestrictions.OnlyNew,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<CancelOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelOrderTradeRequest](Requests/TradeApi/CancelOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelOrderTradeError](Errors/CancelOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3OpenOrdersResponse&gt;&gt; CancelAllOpenOrdersOnASymbolTrade(CancelAllOpenOrdersOnASymbolTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.CancelAllOpenOrdersOnASymbolTrade(new CancelAllOpenOrdersOnASymbolTradeRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3OpenOrdersResponse>
}
catch (ApiException<CancelAllOpenOrdersOnASymbolTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelAllOpenOrdersOnASymbolTradeRequest](Requests/TradeApi/CancelAllOpenOrdersOnASymbolTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3OpenOrdersResponse](Models/AnyOf/ApiV3OpenOrdersResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelAllOpenOrdersOnASymbolTradeError](Errors/CancelAllOpenOrdersOnASymbolTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderCancelReplaceResponse&gt; CancelAnExistingOrderAndSendANewOrderTrade(CancelAnExistingOrderAndSendANewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.CancelAnExistingOrderAndSendANewOrderTrade(
        new CancelAnExistingOrderAndSendANewOrderTradeRequest
        {
            Symbol = "BNBUSDT",
            Side = Side.Sell,
            Type = Type1.Limit,
            CancelReplaceMode = "STOP_ON_FAILURE",
            Timestamp = 1L,
            Signature = "some example string",
            CancelRestrictions = CancelRestrictions.OnlyNew,
            TimeInForce = TimeInForce.Gtc,
            Quantity = 1d,
            Price = 219d,
            CancelOrderId = 12L,
            StopPrice = 221.01d,
            SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type ApiV3OrderCancelReplaceResponse
}
catch (ApiException<CancelAnExistingOrderAndSendANewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelAnExistingOrderAndSendANewOrderTradeRequest](Requests/TradeApi/CancelAnExistingOrderAndSendANewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderCancelReplaceResponse](Models/ApiV3OrderCancelReplaceResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelAnExistingOrderAndSendANewOrderTradeError](Errors/CancelAnExistingOrderAndSendANewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;OrderDetails&gt;&gt; CurrentOpenOrdersUserData(CurrentOpenOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.CurrentOpenOrdersUserData(new CurrentOpenOrdersUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Symbol = "BNBUSDT",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<OrderDetails>
}
catch (ApiException<CurrentOpenOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CurrentOpenOrdersUserDataRequest](Requests/TradeApi/CurrentOpenOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[OrderDetails](Models/OrderDetails.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CurrentOpenOrdersUserDataError](Errors/CurrentOpenOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderResponse&gt; NewOrderTrade(NewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.NewOrderTrade(new NewOrderTradeRequest
    {
        Symbol = "BNBUSDT",
        Side = Side.Sell,
        Type = Type1.Limit,
        Timestamp = 1L,
        Signature = "some example string",
        TimeInForce = TimeInForce.Gtc,
        Quantity = 1d,
        Price = 219d,
        StopPrice = 221.01d,
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type ApiV3OrderResponse
}
catch (ApiException<NewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NewOrderTradeRequest](Requests/TradeApi/NewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderResponse](Models/AnyOf/ApiV3OrderResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[NewOrderTradeError](Errors/NewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderListOtoResponse&gt; NewOrderListOtoTrade(NewOrderListOtoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.NewOrderListOtoTrade(new NewOrderListOtoTradeRequest
    {
        Symbol = "BNBUSDT",
        WorkingType = WorkingType.Limit,
        WorkingSide = WorkingSide.Buy,
        WorkingPrice = 1.5d,
        WorkingQuantity = 1.5d,
        WorkingIcebergQty = 1.5d,
        PendingType = PendingType.Limit,
        PendingSide = PendingSide.Buy,
        PendingQuantity = 1.5d,
        Timestamp = 1L,
        Signature = "some example string",
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
    });
    // TODO: Handle 'response' of type ApiV3OrderListOtoResponse
}
catch (ApiException<NewOrderListOtoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NewOrderListOtoTradeRequest](Requests/TradeApi/NewOrderListOtoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListOtoResponse](Models/ApiV3OrderListOtoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[NewOrderListOtoTradeError](Errors/NewOrderListOtoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderListOtocoResponse&gt; NewOrderListOtocoTrade(NewOrderListOtocoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.NewOrderListOtocoTrade(new NewOrderListOtocoTradeRequest
    {
        Symbol = "BNBUSDT",
        WorkingType = WorkingType.Limit,
        WorkingSide = WorkingSide.Buy,
        WorkingPrice = 1.5d,
        WorkingQuantity = 1.5d,
        WorkingIcebergQty = 1.5d,
        PendingSide = PendingSide.Buy,
        PendingQuantity = 1.5d,
        PendingAboveType = PendingAboveType.LimitMaker,
        Timestamp = 1L,
        Signature = "some example string",
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type ApiV3OrderListOtocoResponse
}
catch (ApiException<NewOrderListOtocoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NewOrderListOtocoTradeRequest](Requests/TradeApi/NewOrderListOtocoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListOtocoResponse](Models/ApiV3OrderListOtocoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[NewOrderListOtocoTradeError](Errors/NewOrderListOtocoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderListOcoResponse&gt; NewOrderListOcoTrade(NewOrderListOcoTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.NewOrderListOcoTrade(new NewOrderListOcoTradeRequest
    {
        Symbol = "BNBUSDT",
        Side = Side.Sell,
        Quantity = 1d,
        AboveType = "some example string",
        BelowType = "some example string",
        Timestamp = 1L,
        Signature = "some example string",
        AboveTimeInForce = AboveTimeInForce.Gtc,
        BelowTimeInForce = BelowTimeInForce.Gtc,
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type ApiV3OrderListOcoResponse
}
catch (ApiException<NewOrderListOcoTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NewOrderListOcoTradeRequest](Requests/TradeApi/NewOrderListOcoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListOcoResponse](Models/ApiV3OrderListOcoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[NewOrderListOcoTradeError](Errors/NewOrderListOcoTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3SorOrderResponse&gt; NewOrderUsingSorTrade(NewOrderUsingSorTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.NewOrderUsingSorTrade(new NewOrderUsingSorTradeRequest
    {
        Symbol = "BNBUSDT",
        Side = Side.Sell,
        Type = Type1.Limit,
        Quantity = 1d,
        Timestamp = 1L,
        Signature = "some example string",
        TimeInForce = TimeInForce.Gtc,
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type ApiV3SorOrderResponse
}
catch (ApiException<NewOrderUsingSorTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NewOrderUsingSorTradeRequest](Requests/TradeApi/NewOrderUsingSorTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3SorOrderResponse](Models/ApiV3SorOrderResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[NewOrderUsingSorTradeError](Errors/NewOrderUsingSorTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3MyAllocationsResponse&gt;&gt; QueryAllocationsUserData(QueryAllocationsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.QueryAllocationsUserData(new QueryAllocationsUserDataRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 5,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3MyAllocationsResponse>
}
catch (ApiException<QueryAllocationsUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryAllocationsUserDataRequest](Requests/TradeApi/QueryAllocationsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3MyAllocationsResponse](Models/ApiV3MyAllocationsResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryAllocationsUserDataError](Errors/QueryAllocationsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3AccountCommissionResponse&gt; QueryCommissionRatesUserData(QueryCommissionRatesUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.QueryCommissionRatesUserData(new QueryCommissionRatesUserDataRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
    });
    // TODO: Handle 'response' of type ApiV3AccountCommissionResponse
}
catch (ApiException<QueryCommissionRatesUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryCommissionRatesUserDataRequest](Requests/TradeApi/QueryCommissionRatesUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3AccountCommissionResponse](Models/ApiV3AccountCommissionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryCommissionRatesUserDataError](Errors/QueryCommissionRatesUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3RateLimitOrderResponse&gt;&gt; QueryCurrentOrderCountUsageTrade(QueryCurrentOrderCountUsageTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.QueryCurrentOrderCountUsageTrade(new QueryCurrentOrderCountUsageTradeRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3RateLimitOrderResponse>
}
catch (ApiException<QueryCurrentOrderCountUsageTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryCurrentOrderCountUsageTradeRequest](Requests/TradeApi/QueryCurrentOrderCountUsageTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3RateLimitOrderResponse](Models/ApiV3RateLimitOrderResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryCurrentOrderCountUsageTradeError](Errors/QueryCurrentOrderCountUsageTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiV3OrderListResponse&gt; QueryOcoUserData(QueryOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.QueryOcoUserData(new QueryOcoUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type ApiV3OrderListResponse
}
catch (ApiException<QueryOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryOcoUserDataRequest](Requests/TradeApi/QueryOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListResponse](Models/ApiV3OrderListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryOcoUserDataError](Errors/QueryOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3OpenOrderListResponse&gt;&gt; QueryOpenOcoUserData(QueryOpenOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.QueryOpenOcoUserData(new QueryOpenOcoUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3OpenOrderListResponse>
}
catch (ApiException<QueryOpenOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryOpenOcoUserDataRequest](Requests/TradeApi/QueryOpenOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3OpenOrderListResponse](Models/ApiV3OpenOrderListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryOpenOcoUserDataError](Errors/QueryOpenOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrderDetails&gt; QueryOrderUserData(QueryOrderUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.QueryOrderUserData(new QueryOrderUserDataRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type OrderDetails
}
catch (ApiException<QueryOrderUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryOrderUserDataRequest](Requests/TradeApi/QueryOrderUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrderDetails](Models/OrderDetails.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryOrderUserDataError](Errors/QueryOrderUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3MyPreventedMatchesResponse&gt;&gt; QueryPreventedMatches(QueryPreventedMatchesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.QueryPreventedMatches(new QueryPreventedMatchesRequest
    {
        Symbol = "BNBUSDT",
        Timestamp = 1L,
        Signature = "some example string",
        PreventedMatchId = 1L,
        FromPreventedMatchId = 1L,
        Limit = 5,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3MyPreventedMatchesResponse>
}
catch (ApiException<QueryPreventedMatchesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryPreventedMatchesRequest](Requests/TradeApi/QueryPreventedMatchesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3MyPreventedMatchesResponse](Models/ApiV3MyPreventedMatchesResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryPreventedMatchesError](Errors/QueryPreventedMatchesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ApiV3AllOrderListResponse&gt;&gt; QueryAllOcoUserData(QueryAllOcoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.QueryAllOcoUserData(new QueryAllOcoUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Limit = 5,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<ApiV3AllOrderListResponse>
}
catch (ApiException<QueryAllOcoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryAllOcoUserDataRequest](Requests/TradeApi/QueryAllOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3AllOrderListResponse](Models/ApiV3AllOrderListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryAllOcoUserDataError](Errors/QueryAllOcoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; TestNewOrderTrade(TestNewOrderTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.TestNewOrderTrade(new TestNewOrderTradeRequest
    {
        Symbol = "BNBUSDT",
        Side = Side.Sell,
        Type = Type1.Limit,
        Timestamp = 1L,
        Signature = "some example string",
        TimeInForce = TimeInForce.Gtc,
        Quantity = 1d,
        Price = 219d,
        StopPrice = 221.01d,
        RecvWindow = 5000L,
        ComputeCommissionRates = false,
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<TestNewOrderTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TestNewOrderTradeRequest](Requests/TradeApi/TestNewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TestNewOrderTradeError](Errors/TestNewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; TestNewOrderUsingSorTrade(TestNewOrderUsingSorTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TradeApi.TestNewOrderUsingSorTrade(new TestNewOrderUsingSorTradeRequest
    {
        Symbol = "BNBUSDT",
        Side = Side.Sell,
        Type = Type1.Limit,
        Quantity = 1d,
        Timestamp = 1L,
        Signature = "some example string",
        TimeInForce = TimeInForce.Gtc,
        SelfTradePreventionMode = SelfTradePreventionMode.ExpireTaker,
        ComputeCommissionRates = false,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<TestNewOrderUsingSorTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TestNewOrderUsingSorTradeRequest](Requests/TradeApi/TestNewOrderUsingSorTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TestNewOrderUsingSorTradeError](Errors/TestNewOrderUsingSorTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VipLoans

> Source: [VipLoans](Api/VipLoans.cs)

<details>
<summary><code>Task&lt;SapiV1LoanVipCollateralAccountResponse&gt; CheckLockedValueOfVipCollateralAccountUserData(CheckLockedValueOfVipCollateralAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.CheckLockedValueOfVipCollateralAccountUserData(
        new CheckLockedValueOfVipCollateralAccountUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LoanVipCollateralAccountResponse
}
catch (ApiException<CheckLockedValueOfVipCollateralAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CheckLockedValueOfVipCollateralAccountUserDataRequest](Requests/VipLoans/CheckLockedValueOfVipCollateralAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipCollateralAccountResponse](Models/SapiV1LoanVipCollateralAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CheckLockedValueOfVipCollateralAccountUserDataError](Errors/CheckLockedValueOfVipCollateralAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1LoanVipRequestInterestRateResponse&gt;&gt; GetBorrowInterestRateUserData(GetBorrowInterestRateUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.GetBorrowInterestRateUserData(new GetBorrowInterestRateUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        LoanCoin = "BUSD",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1LoanVipRequestInterestRateResponse>
}
catch (ApiException<GetBorrowInterestRateUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBorrowInterestRateUserDataRequest](Requests/VipLoans/GetBorrowInterestRateUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LoanVipRequestInterestRateResponse](Models/SapiV1LoanVipRequestInterestRateResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetBorrowInterestRateUserDataError](Errors/GetBorrowInterestRateUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipCollateralDataResponse&gt; GetCollateralAssetDataUserData(GetCollateralAssetDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.GetCollateralAssetDataUserData(new GetCollateralAssetDataUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        CollateralCoin = "BNB",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanVipCollateralDataResponse
}
catch (ApiException<GetCollateralAssetDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCollateralAssetDataUserDataRequest](Requests/VipLoans/GetCollateralAssetDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipCollateralDataResponse](Models/SapiV1LoanVipCollateralDataResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCollateralAssetDataUserDataError](Errors/GetCollateralAssetDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipLoanableDataResponse&gt; GetLoanableAssetsData(GetLoanableAssetsDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.GetLoanableAssetsData(new GetLoanableAssetsDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        LoanCoin = "BUSD",
        VipLevel = 1,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanVipLoanableDataResponse
}
catch (ApiException<GetLoanableAssetsDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLoanableAssetsDataRequest](Requests/VipLoans/GetLoanableAssetsDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipLoanableDataResponse](Models/SapiV1LoanVipLoanableDataResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLoanableAssetsDataError](Errors/GetLoanableAssetsDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipOngoingOrdersResponse&gt; GetVipLoanOngoingOrdersUserData(GetVipLoanOngoingOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.GetVipLoanOngoingOrdersUserData(new GetVipLoanOngoingOrdersUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        LoanCoin = "BUSD",
        CollateralCoin = "BNB",
        Current = 1,
        Limit = 10,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanVipOngoingOrdersResponse
}
catch (ApiException<GetVipLoanOngoingOrdersUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetVipLoanOngoingOrdersUserDataRequest](Requests/VipLoans/GetVipLoanOngoingOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipOngoingOrdersResponse](Models/SapiV1LoanVipOngoingOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetVipLoanOngoingOrdersUserDataError](Errors/GetVipLoanOngoingOrdersUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipRepayHistoryResponse&gt; GetVipLoanRepaymentHistoryUserData(GetVipLoanRepaymentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.GetVipLoanRepaymentHistoryUserData(
        new GetVipLoanRepaymentHistoryUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            LoanCoin = "BUSD",
            Current = 1,
            Limit = 10,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1LoanVipRepayHistoryResponse
}
catch (ApiException<GetVipLoanRepaymentHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetVipLoanRepaymentHistoryUserDataRequest](Requests/VipLoans/GetVipLoanRepaymentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRepayHistoryResponse](Models/SapiV1LoanVipRepayHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetVipLoanRepaymentHistoryUserDataError](Errors/GetVipLoanRepaymentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipRequestDataResponse&gt; QueryApplicationStatusUserData(QueryApplicationStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.QueryApplicationStatusUserData(new QueryApplicationStatusUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Current = 1,
        Limit = 5,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanVipRequestDataResponse
}
catch (ApiException<QueryApplicationStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryApplicationStatusUserDataRequest](Requests/VipLoans/QueryApplicationStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRequestDataResponse](Models/SapiV1LoanVipRequestDataResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryApplicationStatusUserDataError](Errors/QueryApplicationStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipBorrowResponse&gt; VipLoanBorrow(VipLoanBorrowRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.VipLoanBorrow(new VipLoanBorrowRequest
    {
        LoanAccountId = 1L,
        LoanAmount = 1.5d,
        CollateralAccountId = "some example string",
        CollateralCoin = "some example string",
        IsFlexibleRate = IsFlexibleRate.True,
        Timestamp = 1L,
        Signature = "some example string",
        LoanCoin = "BUSD",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanVipBorrowResponse
}
catch (ApiException<VipLoanBorrowError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VipLoanBorrowRequest](Requests/VipLoans/VipLoanBorrowRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipBorrowResponse](Models/SapiV1LoanVipBorrowResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[VipLoanBorrowError](Errors/VipLoanBorrowError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipRenewResponse&gt; VipLoanRenew(VipLoanRenewRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.VipLoanRenew(new VipLoanRenewRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        LoanTerm = 30,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanVipRenewResponse
}
catch (ApiException<VipLoanRenewError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VipLoanRenewRequest](Requests/VipLoans/VipLoanRenewRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRenewResponse](Models/SapiV1LoanVipRenewResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[VipLoanRenewError](Errors/VipLoanRenewError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1LoanVipRepayResponse&gt; VipLoanRepayTrade(VipLoanRepayTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VipLoans.VipLoanRepayTrade(new VipLoanRepayTradeRequest
    {
        Amount = 1.01d,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1LoanVipRepayResponse
}
catch (ApiException<VipLoanRepayTradeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VipLoanRepayTradeRequest](Requests/VipLoans/VipLoanRepayTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRepayResponse](Models/SapiV1LoanVipRepayResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[VipLoanRepayTradeError](Errors/VipLoanRepayTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Wallet

> Source: [Wallet](Api/Wallet.cs)

<details>
<summary><code>Task&lt;SapiV1AccountApiTradingStatusResponse&gt; AccountApiTradingStatusUserData(AccountApiTradingStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.AccountApiTradingStatusUserData(new AccountApiTradingStatusUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AccountApiTradingStatusResponse
}
catch (ApiException<AccountApiTradingStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountApiTradingStatusUserDataRequest](Requests/Wallet/AccountApiTradingStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountApiTradingStatusResponse](Models/SapiV1AccountApiTradingStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AccountApiTradingStatusUserDataError](Errors/AccountApiTradingStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AccountStatusResponse&gt; AccountStatusUserData(AccountStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.AccountStatusUserData(new AccountStatusUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AccountStatusResponse
}
catch (ApiException<AccountStatusUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountStatusUserDataRequest](Requests/Wallet/AccountStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountStatusResponse](Models/SapiV1AccountStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AccountStatusUserDataError](Errors/AccountStatusUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AccountInfoResponse&gt; AccountInfoUserData(AccountInfoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.AccountInfoUserData(new AccountInfoUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AccountInfoResponse
}
catch (ApiException<AccountInfoUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountInfoUserDataRequest](Requests/Wallet/AccountInfoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountInfoResponse](Models/SapiV1AccountInfoResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AccountInfoUserDataError](Errors/AccountInfoUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalConfigGetallResponse&gt;&gt; AllCoinsInformationUserData(AllCoinsInformationUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.AllCoinsInformationUserData(new AllCoinsInformationUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalConfigGetallResponse>
}
catch (ApiException<AllCoinsInformationUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AllCoinsInformationUserDataRequest](Requests/Wallet/AllCoinsInformationUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalConfigGetallResponse](Models/SapiV1CapitalConfigGetallResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AllCoinsInformationUserDataError](Errors/AllCoinsInformationUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetAssetDetailResponse&gt; AssetDetailUserData(AssetDetailUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.AssetDetailUserData(new AssetDetailUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Asset = "BNB",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AssetAssetDetailResponse
}
catch (ApiException<AssetDetailUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetDetailUserDataRequest](Requests/Wallet/AssetDetailUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetAssetDetailResponse](Models/SapiV1AssetAssetDetailResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AssetDetailUserDataError](Errors/AssetDetailUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetAssetDividendResponse&gt; AssetDividendRecordUserData(AssetDividendRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.AssetDividendRecordUserData(new AssetDividendRecordUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Asset = "BNB",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AssetAssetDividendResponse
}
catch (ApiException<AssetDividendRecordUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetDividendRecordUserDataRequest](Requests/Wallet/AssetDividendRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetAssetDividendResponse](Models/SapiV1AssetAssetDividendResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AssetDividendRecordUserDataError](Errors/AssetDividendRecordUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetConvertTransferResponse&gt; ConvertTransferUserData(ConvertTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.ConvertTransferUserData(new ConvertTransferUserDataRequest
    {
        ClientTranId = "some example string",
        Asset = "BTC",
        Amount = 1.01d,
        TargetAsset = "BNB",
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AssetConvertTransferResponse
}
catch (ApiException<ConvertTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConvertTransferUserDataRequest](Requests/Wallet/ConvertTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetConvertTransferResponse](Models/SapiV1AssetConvertTransferResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ConvertTransferUserDataError](Errors/ConvertTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AccountSnapshotResponse&gt; DailyAccountSnapshotUserData(DailyAccountSnapshotUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.DailyAccountSnapshotUserData(new DailyAccountSnapshotUserDataRequest
    {
        Type = Type6.Spot,
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AccountSnapshotResponse
}
catch (ApiException<DailyAccountSnapshotUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DailyAccountSnapshotUserDataRequest](Requests/Wallet/DailyAccountSnapshotUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountSnapshotResponse](Models/AnyOf/SapiV1AccountSnapshotResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DailyAccountSnapshotUserDataError](Errors/DailyAccountSnapshotUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalDepositAddressResponse&gt; DepositAddressSupportingNetworkUserData(DepositAddressSupportingNetworkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.DepositAddressSupportingNetworkUserData(
        new DepositAddressSupportingNetworkUserDataRequest
        {
            Coin = "BNB",
            Timestamp = 1L,
            Signature = "some example string",
            Network = "BTC",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1CapitalDepositAddressResponse
}
catch (ApiException<DepositAddressSupportingNetworkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DepositAddressSupportingNetworkUserDataRequest](Requests/Wallet/DepositAddressSupportingNetworkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalDepositAddressResponse](Models/SapiV1CapitalDepositAddressResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DepositAddressSupportingNetworkUserDataError](Errors/DepositAddressSupportingNetworkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalDepositHisrecResponse&gt;&gt; DepositHistorySupportingNetworkUserData(DepositHistorySupportingNetworkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.DepositHistorySupportingNetworkUserData(
        new DepositHistorySupportingNetworkUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Coin = "BNB",
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalDepositHisrecResponse>
}
catch (ApiException<DepositHistorySupportingNetworkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DepositHistorySupportingNetworkUserDataRequest](Requests/Wallet/DepositHistorySupportingNetworkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalDepositHisrecResponse](Models/SapiV1CapitalDepositHisrecResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DepositHistorySupportingNetworkUserDataError](Errors/DepositHistorySupportingNetworkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; DisableFastWithdrawSwitchUserData(DisableFastWithdrawSwitchUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.DisableFastWithdrawSwitchUserData(new DisableFastWithdrawSwitchUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<DisableFastWithdrawSwitchUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DisableFastWithdrawSwitchUserDataRequest](Requests/Wallet/DisableFastWithdrawSwitchUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DisableFastWithdrawSwitchUserDataError](Errors/DisableFastWithdrawSwitchUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetDustResponse&gt; DustTransferUserData(DustTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.DustTransferUserData(new DustTransferUserDataRequest
    {
        Asset = ["some example string"],
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AssetDustResponse
}
catch (ApiException<DustTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DustTransferUserDataRequest](Requests/Wallet/DustTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetDustResponse](Models/SapiV1AssetDustResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DustTransferUserDataError](Errors/DustTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetDribbletResponse&gt; DustLogUserData(DustLogUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.DustLogUserData(new DustLogUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AssetDribbletResponse
}
catch (ApiException<DustLogUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DustLogUserDataRequest](Requests/Wallet/DustLogUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetDribbletResponse](Models/SapiV1AssetDribbletResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DustLogUserDataError](Errors/DustLogUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; EnableFastWithdrawSwitchUserData(EnableFastWithdrawSwitchUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.EnableFastWithdrawSwitchUserData(new EnableFastWithdrawSwitchUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<EnableFastWithdrawSwitchUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableFastWithdrawSwitchUserDataRequest](Requests/Wallet/EnableFastWithdrawSwitchUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EnableFastWithdrawSwitchUserDataError](Errors/EnableFastWithdrawSwitchUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalDepositAddressListResponse&gt;&gt; FetchDepositAddressListWithNetworkUserData(FetchDepositAddressListWithNetworkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.FetchDepositAddressListWithNetworkUserData(
        new FetchDepositAddressListWithNetworkUserDataRequest
        {
            Coin = "BTC",
            Timestamp = 1L,
            Signature = "some example string",
            Network = "BTC",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalDepositAddressListResponse>
}
catch (ApiException<FetchDepositAddressListWithNetworkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FetchDepositAddressListWithNetworkUserDataRequest](Requests/Wallet/FetchDepositAddressListWithNetworkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalDepositAddressListResponse](Models/SapiV1CapitalDepositAddressListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FetchDepositAddressListWithNetworkUserDataError](Errors/FetchDepositAddressListWithNetworkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalWithdrawAddressListResponse&gt;&gt; FetchWithdrawAddressListUserData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<FetchWithdrawAddressListUserDataError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FetchWithdrawAddressListUserDataError](Errors/FetchWithdrawAddressListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1AssetGetFundingAssetResponse&gt;&gt; FundingWalletUserData(FundingWalletUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.FundingWalletUserData(new FundingWalletUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Asset = "BNB",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1AssetGetFundingAssetResponse>
}
catch (ApiException<FundingWalletUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FundingWalletUserDataRequest](Requests/Wallet/FundingWalletUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1AssetGetFundingAssetResponse](Models/SapiV1AssetGetFundingAssetResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[FundingWalletUserDataError](Errors/FundingWalletUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AccountApiRestrictionsResponse&gt; GetApiKeyPermissionUserData(GetApiKeyPermissionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.GetApiKeyPermissionUserData(new GetApiKeyPermissionUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AccountApiRestrictionsResponse
}
catch (ApiException<GetApiKeyPermissionUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetApiKeyPermissionUserDataRequest](Requests/Wallet/GetApiKeyPermissionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountApiRestrictionsResponse](Models/SapiV1AccountApiRestrictionsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetApiKeyPermissionUserDataError](Errors/GetApiKeyPermissionUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetDustBtcResponse&gt; GetAssetsThatCanBeConvertedIntoBnbUserData(GetAssetsThatCanBeConvertedIntoBnbUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.GetAssetsThatCanBeConvertedIntoBnbUserData(
        new GetAssetsThatCanBeConvertedIntoBnbUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1AssetDustBtcResponse
}
catch (ApiException<GetAssetsThatCanBeConvertedIntoBnbUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAssetsThatCanBeConvertedIntoBnbUserDataRequest](Requests/Wallet/GetAssetsThatCanBeConvertedIntoBnbUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetDustBtcResponse](Models/SapiV1AssetDustBtcResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAssetsThatCanBeConvertedIntoBnbUserDataError](Errors/GetAssetsThatCanBeConvertedIntoBnbUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse&gt; GetCloudMiningPaymentAndRefundHistoryUserData(GetCloudMiningPaymentAndRefundHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.GetCloudMiningPaymentAndRefundHistoryUserData(
        new GetCloudMiningPaymentAndRefundHistoryUserDataRequest
        {
            StartTime = 1L,
            EndTime = 1L,
            Timestamp = 1L,
            Signature = "some example string",
            TranId = 118263615991L,
            Asset = "BTC",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse
}
catch (ApiException<GetCloudMiningPaymentAndRefundHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCloudMiningPaymentAndRefundHistoryUserDataRequest](Requests/Wallet/GetCloudMiningPaymentAndRefundHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse](Models/SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCloudMiningPaymentAndRefundHistoryUserDataError](Errors/GetCloudMiningPaymentAndRefundHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1SpotDelistScheduleResponse&gt;&gt; GetSymbolsDelistScheduleForSpotMarketData(GetSymbolsDelistScheduleForSpotMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.GetSymbolsDelistScheduleForSpotMarketData(
        new GetSymbolsDelistScheduleForSpotMarketDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1SpotDelistScheduleResponse>
}
catch (ApiException<GetSymbolsDelistScheduleForSpotMarketDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSymbolsDelistScheduleForSpotMarketDataRequest](Requests/Wallet/GetSymbolsDelistScheduleForSpotMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SpotDelistScheduleResponse](Models/SapiV1SpotDelistScheduleResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSymbolsDelistScheduleForSpotMarketDataError](Errors/GetSymbolsDelistScheduleForSpotMarketDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalDepositCreditApplyResponse&gt; OneClickArrivalDepositApplyUserData(OneClickArrivalDepositApplyUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.OneClickArrivalDepositApplyUserData(
        new OneClickArrivalDepositApplyUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1CapitalDepositCreditApplyResponse
}
catch (ApiException<OneClickArrivalDepositApplyUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OneClickArrivalDepositApplyUserDataRequest](Requests/Wallet/OneClickArrivalDepositApplyUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalDepositCreditApplyResponse](Models/SapiV1CapitalDepositCreditApplyResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[OneClickArrivalDepositApplyUserDataError](Errors/OneClickArrivalDepositApplyUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetConvertTransferQueryByPageResponse&gt; QueryConvertTransferUserData(QueryConvertTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.QueryConvertTransferUserData(new QueryConvertTransferUserDataRequest
    {
        StartTime = 1L,
        EndTime = 1L,
        Timestamp = 1L,
        Signature = "some example string",
        TranId = 118263615991L,
        Asset = "BTC",
        Current = 1,
        Size = 100,
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AssetConvertTransferQueryByPageResponse
}
catch (ApiException<QueryConvertTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryConvertTransferUserDataRequest](Requests/Wallet/QueryConvertTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetConvertTransferQueryByPageResponse](Models/SapiV1AssetConvertTransferQueryByPageResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryConvertTransferUserDataError](Errors/QueryConvertTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetCustodyTransferHistoryResponse&gt; QueryUserDelegationHistoryForMasterAccountUserData(QueryUserDelegationHistoryForMasterAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.QueryUserDelegationHistoryForMasterAccountUserData(
        new QueryUserDelegationHistoryForMasterAccountUserDataRequest
        {
            Email = "alice@test.com",
            StartTime = 1695205406000L,
            EndTime = 1695205396000L,
            Asset = "BTC",
            Timestamp = 1L,
            Signature = "some example string",
            Type = "Delegate",
            Current = 1,
            Size = 100,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1AssetCustodyTransferHistoryResponse
}
catch (ApiException<QueryUserDelegationHistoryForMasterAccountUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryUserDelegationHistoryForMasterAccountUserDataRequest](Requests/Wallet/QueryUserDelegationHistoryForMasterAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetCustodyTransferHistoryResponse](Models/SapiV1AssetCustodyTransferHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryUserDelegationHistoryForMasterAccountUserDataError](Errors/QueryUserDelegationHistoryForMasterAccountUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetTransferResponse&gt; QueryUserUniversalTransferHistoryUserData(QueryUserUniversalTransferHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.QueryUserUniversalTransferHistoryUserData(
        new QueryUserUniversalTransferHistoryUserDataRequest
        {
            Type = Type7.MainC2C,
            Timestamp = 1L,
            Signature = "some example string",
            Current = 1,
            Size = 100,
            FromSymbol = "BNBUSDT",
            ToSymbol = "BNBUSDT",
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type SapiV1AssetTransferResponse
}
catch (ApiException<QueryUserUniversalTransferHistoryUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryUserUniversalTransferHistoryUserDataRequest](Requests/Wallet/QueryUserUniversalTransferHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetTransferResponse](Models/SapiV1AssetTransferResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryUserUniversalTransferHistoryUserDataError](Errors/QueryUserUniversalTransferHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1AssetWalletBalanceResponse&gt;&gt; QueryUserWalletBalanceUserData(QueryUserWalletBalanceUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.QueryUserWalletBalanceUserData(new QueryUserWalletBalanceUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1AssetWalletBalanceResponse>
}
catch (ApiException<QueryUserWalletBalanceUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryUserWalletBalanceUserDataRequest](Requests/Wallet/QueryUserWalletBalanceUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1AssetWalletBalanceResponse](Models/SapiV1AssetWalletBalanceResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryUserWalletBalanceUserDataError](Errors/QueryUserWalletBalanceUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalContractConvertibleCoinsResponse&gt; QueryAutoConvertingStableCoinsUserData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<QueryAutoConvertingStableCoinsUserDataError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[QueryAutoConvertingStableCoinsUserDataError](Errors/QueryAutoConvertingStableCoinsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; SwitchOnOffBusdAndStableCoinsConversionUserDataUserData(SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.SwitchOnOffBusdAndStableCoinsConversionUserDataUserData(
        new SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest
        {
            Coin = "some example string",
            Enable = true,
        });
    // TODO: Handle 'response' of type object
}
catch (ApiException<SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest](Requests/Wallet/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError](Errors/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1SystemStatusResponse&gt; SystemStatusSystem(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<RawError> ex)
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

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1AssetTradeFeeResponse&gt;&gt; TradeFeeUserData(TradeFeeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.TradeFeeUserData(new TradeFeeUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Symbol = "BNBUSDT",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1AssetTradeFeeResponse>
}
catch (ApiException<TradeFeeUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TradeFeeUserDataRequest](Requests/Wallet/TradeFeeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1AssetTradeFeeResponse](Models/SapiV1AssetTradeFeeResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TradeFeeUserDataError](Errors/TradeFeeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV3AssetGetUserAssetResponse&gt;&gt; UserAssetUserData(UserAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.UserAssetUserData(new UserAssetUserDataRequest
    {
        Timestamp = 1L,
        Signature = "some example string",
        Asset = "BNB",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV3AssetGetUserAssetResponse>
}
catch (ApiException<UserAssetUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserAssetUserDataRequest](Requests/Wallet/UserAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV3AssetGetUserAssetResponse](Models/SapiV3AssetGetUserAssetResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UserAssetUserDataError](Errors/UserAssetUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1AssetTransferResponse1&gt; UserUniversalTransferUserData(UserUniversalTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.UserUniversalTransferUserData(new UserUniversalTransferUserDataRequest
    {
        Type = Type7.MainC2C,
        Asset = "BTC",
        Amount = 1.01d,
        Timestamp = 1L,
        Signature = "some example string",
        FromSymbol = "BNBUSDT",
        ToSymbol = "BNBUSDT",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1AssetTransferResponse1
}
catch (ApiException<UserUniversalTransferUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserUniversalTransferUserDataRequest](Requests/Wallet/UserUniversalTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetTransferResponse1](Models/SapiV1AssetTransferResponse1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UserUniversalTransferUserDataError](Errors/UserUniversalTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SapiV1CapitalWithdrawApplyResponse&gt; WithdrawUserData(WithdrawUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.WithdrawUserData(new WithdrawUserDataRequest
    {
        Coin = "BNB",
        Address = "some example string",
        Amount = 1.01d,
        Timestamp = 1L,
        Signature = "some example string",
        Network = "BTC",
        RecvWindow = 5000L,
    });
    // TODO: Handle 'response' of type SapiV1CapitalWithdrawApplyResponse
}
catch (ApiException<WithdrawUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WithdrawUserDataRequest](Requests/Wallet/WithdrawUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalWithdrawApplyResponse](Models/SapiV1CapitalWithdrawApplyResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[WithdrawUserDataError](Errors/WithdrawUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SapiV1CapitalWithdrawHistoryResponse&gt;&gt; WithdrawHistorySupportingNetworkUserData(WithdrawHistorySupportingNetworkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Wallet.WithdrawHistorySupportingNetworkUserData(
        new WithdrawHistorySupportingNetworkUserDataRequest
        {
            Timestamp = 1L,
            Signature = "some example string",
            Coin = "BNB",
            Limit = 5,
            RecvWindow = 5000L,
        });
    // TODO: Handle 'response' of type IReadOnlyList<SapiV1CapitalWithdrawHistoryResponse>
}
catch (ApiException<WithdrawHistorySupportingNetworkUserDataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WithdrawHistorySupportingNetworkUserDataRequest](Requests/Wallet/WithdrawHistorySupportingNetworkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalWithdrawHistoryResponse](Models/SapiV1CapitalWithdrawHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[WithdrawHistorySupportingNetworkUserDataError](Errors/WithdrawHistorySupportingNetworkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

