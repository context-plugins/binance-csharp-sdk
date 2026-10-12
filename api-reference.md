# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [BinanceClient](src/Binance/BinanceClient.cs)

## AutoInvest

> Source: [AutoInvest](src/Binance/Api/AutoInvest.cs)

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

<code>[ChangePlanStatusRequest](src/Binance/Requests/AutoInvest/ChangePlanStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanEditStatusResponse](src/Binance/Models/SapiV1LendingAutoInvestPlanEditStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ChangePlanStatusError](src/Binance/Errors/ChangePlanStatusError.cs)&gt;</code>

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

<code>[GetListOfPlansRequest](src/Binance/Requests/AutoInvest/GetListOfPlansRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanListResponse](src/Binance/Models/SapiV1LendingAutoInvestPlanListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetListOfPlansError](src/Binance/Errors/GetListOfPlansError.cs)&gt;</code>

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

<code>[GetTargetAssetRoiDataUserDataRequest](src/Binance/Requests/AutoInvest/GetTargetAssetRoiDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestTargetAssetRoiListResponse](src/Binance/Models/SapiV1LendingAutoInvestTargetAssetRoiListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetTargetAssetRoiDataUserDataError](src/Binance/Errors/GetTargetAssetRoiDataUserDataError.cs)&gt;</code>

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

<code>[GetTargetAssetListUserDataRequest](src/Binance/Requests/AutoInvest/GetTargetAssetListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestTargetAssetListResponse](src/Binance/Models/SapiV1LendingAutoInvestTargetAssetListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetTargetAssetListUserDataError](src/Binance/Errors/GetTargetAssetListUserDataError.cs)&gt;</code>

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

<code>[IndexLinkedPlanRebalanceDetailsUserDataRequest](src/Binance/Requests/AutoInvest/IndexLinkedPlanRebalanceDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestRebalanceHistoryResponse](src/Binance/Models/SapiV1LendingAutoInvestRebalanceHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[IndexLinkedPlanRebalanceDetailsUserDataError](src/Binance/Errors/IndexLinkedPlanRebalanceDetailsUserDataError.cs)&gt;</code>

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

<code>[IndexLinkedPlanRedemptionTradeRequest](src/Binance/Requests/AutoInvest/IndexLinkedPlanRedemptionTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestRedeemResponse](src/Binance/Models/SapiV1LendingAutoInvestRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[IndexLinkedPlanRedemptionTradeError](src/Binance/Errors/IndexLinkedPlanRedemptionTradeError.cs)&gt;</code>

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

<code>[IndexLinkedPlanRedemptionHistoryUserDataRequest](src/Binance/Requests/AutoInvest/IndexLinkedPlanRedemptionHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestRedeemHistoryResponse](src/Binance/Models/SapiV1LendingAutoInvestRedeemHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[IndexLinkedPlanRedemptionHistoryUserDataError](src/Binance/Errors/IndexLinkedPlanRedemptionHistoryUserDataError.cs)&gt;</code>

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

<code>[InvestmentPlanAdjustmentRequest](src/Binance/Requests/AutoInvest/InvestmentPlanAdjustmentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanEditResponse](src/Binance/Models/SapiV1LendingAutoInvestPlanEditResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[InvestmentPlanAdjustmentError](src/Binance/Errors/InvestmentPlanAdjustmentError.cs)&gt;</code>

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

<code>[InvestmentPlanCreationUserDataRequest](src/Binance/Requests/AutoInvest/InvestmentPlanCreationUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanAddResponse](src/Binance/Models/SapiV1LendingAutoInvestPlanAddResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[InvestmentPlanCreationUserDataError](src/Binance/Errors/InvestmentPlanCreationUserDataError.cs)&gt;</code>

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

<code>[OneTimeTransactionTradeRequest](src/Binance/Requests/AutoInvest/OneTimeTransactionTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestOneOffResponse](src/Binance/Models/SapiV1LendingAutoInvestOneOffResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[OneTimeTransactionTradeError](src/Binance/Errors/OneTimeTransactionTradeError.cs)&gt;</code>

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

<code>[QueryIndexDetailsUserDataRequest](src/Binance/Requests/AutoInvest/QueryIndexDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestIndexInfoResponse](src/Binance/Models/SapiV1LendingAutoInvestIndexInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryIndexDetailsUserDataError](src/Binance/Errors/QueryIndexDetailsUserDataError.cs)&gt;</code>

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

<code>[QueryIndexLinkedPlanPositionDetailsUserDataRequest](src/Binance/Requests/AutoInvest/QueryIndexLinkedPlanPositionDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestIndexUserSummaryResponse](src/Binance/Models/SapiV1LendingAutoInvestIndexUserSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryIndexLinkedPlanPositionDetailsUserDataError](src/Binance/Errors/QueryIndexLinkedPlanPositionDetailsUserDataError.cs)&gt;</code>

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

<code>[QueryOneTimeTransactionStatusUserDataRequest](src/Binance/Requests/AutoInvest/QueryOneTimeTransactionStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestOneOffStatusResponse](src/Binance/Models/SapiV1LendingAutoInvestOneOffStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryOneTimeTransactionStatusUserDataError](src/Binance/Errors/QueryOneTimeTransactionStatusUserDataError.cs)&gt;</code>

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

<code>[QueryAllSourceAssetAndTargetAssetUserDataRequest](src/Binance/Requests/AutoInvest/QueryAllSourceAssetAndTargetAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestAllAssetResponse](src/Binance/Models/SapiV1LendingAutoInvestAllAssetResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryAllSourceAssetAndTargetAssetUserDataError](src/Binance/Errors/QueryAllSourceAssetAndTargetAssetUserDataError.cs)&gt;</code>

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

<code>[QueryHoldingDetailsOfThePlanRequest](src/Binance/Requests/AutoInvest/QueryHoldingDetailsOfThePlanRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestPlanIdResponse](src/Binance/Models/SapiV1LendingAutoInvestPlanIdResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryHoldingDetailsOfThePlanError](src/Binance/Errors/QueryHoldingDetailsOfThePlanError.cs)&gt;</code>

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

<code>[QuerySourceAssetListUserDataRequest](src/Binance/Requests/AutoInvest/QuerySourceAssetListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingAutoInvestSourceAssetListResponse](src/Binance/Models/SapiV1LendingAutoInvestSourceAssetListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QuerySourceAssetListUserDataError](src/Binance/Errors/QuerySourceAssetListUserDataError.cs)&gt;</code>

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

<code>[QuerySubscriptionTransactionHistoryRequest](src/Binance/Requests/AutoInvest/QuerySubscriptionTransactionHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingAutoInvestHistoryListResponse](src/Binance/Models/SapiV1LendingAutoInvestHistoryListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QuerySubscriptionTransactionHistoryError](src/Binance/Errors/QuerySubscriptionTransactionHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Blvt

> Source: [Blvt](src/Binance/Api/Blvt.cs)

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

<code>[BlvtInfoMarketDataRequest](src/Binance/Requests/Blvt/BlvtInfoMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1BlvtTokenInfoResponse](src/Binance/Models/SapiV1BlvtTokenInfoResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[BlvtInfoMarketDataError](src/Binance/Errors/BlvtInfoMarketDataError.cs)&gt;</code>

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

<code>[BlvtUserLimitInfoUserDataRequest](src/Binance/Requests/Blvt/BlvtUserLimitInfoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1BlvtUserLimitResponse](src/Binance/Models/SapiV1BlvtUserLimitResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[BlvtUserLimitInfoUserDataError](src/Binance/Errors/BlvtUserLimitInfoUserDataError.cs)&gt;</code>

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

<code>[QuerySubscriptionRecordUserDataRequest](src/Binance/Requests/Blvt/QuerySubscriptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1BlvtSubscribeRecordResponse](src/Binance/Models/SapiV1BlvtSubscribeRecordResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QuerySubscriptionRecordUserDataError](src/Binance/Errors/QuerySubscriptionRecordUserDataError.cs)&gt;</code>

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

<code>[RedeemBlvtUserDataRequest](src/Binance/Requests/Blvt/RedeemBlvtUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1BlvtRedeemResponse](src/Binance/Models/SapiV1BlvtRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RedeemBlvtUserDataError](src/Binance/Errors/RedeemBlvtUserDataError.cs)&gt;</code>

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

<code>[RedemptionRecordUserDataRequest](src/Binance/Requests/Blvt/RedemptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1BlvtRedeemRecordResponse](src/Binance/Models/SapiV1BlvtRedeemRecordResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RedemptionRecordUserDataError](src/Binance/Errors/RedemptionRecordUserDataError.cs)&gt;</code>

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

<code>[SubscribeBlvtUserDataRequest](src/Binance/Requests/Blvt/SubscribeBlvtUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1BlvtSubscribeResponse](src/Binance/Models/SapiV1BlvtSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubscribeBlvtUserDataError](src/Binance/Errors/SubscribeBlvtUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## C2C

> Source: [C2C](src/Binance/Api/C2C.cs)

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

<code>[GetC2CTradeHistoryUserDataRequest](src/Binance/Requests/C2C/GetC2CTradeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1C2COrderMatchListUserOrderHistoryResponse](src/Binance/Models/SapiV1C2COrderMatchListUserOrderHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetC2CTradeHistoryUserDataError](src/Binance/Errors/GetC2CTradeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConvertApi

> Source: [ConvertApi](src/Binance/Api/ConvertApi.cs)

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

<code>[AcceptQuoteTradeRequest](src/Binance/Requests/ConvertApi/AcceptQuoteTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertAcceptQuoteResponse](src/Binance/Models/SapiV1ConvertAcceptQuoteResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AcceptQuoteTradeError](src/Binance/Errors/AcceptQuoteTradeError.cs)&gt;</code>

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

<code>[CancelLimitOrderUserDataRequest](src/Binance/Requests/ConvertApi/CancelLimitOrderUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertLimitCancelOrderResponse](src/Binance/Models/SapiV1ConvertLimitCancelOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CancelLimitOrderUserDataError](src/Binance/Errors/CancelLimitOrderUserDataError.cs)&gt;</code>

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

<code>[GetConvertTradeHistoryUserDataRequest](src/Binance/Requests/ConvertApi/GetConvertTradeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertTradeFlowResponse](src/Binance/Models/SapiV1ConvertTradeFlowResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetConvertTradeHistoryUserDataError](src/Binance/Errors/GetConvertTradeHistoryUserDataError.cs)&gt;</code>

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

<code>[ListAllConvertPairsRequest](src/Binance/Requests/ConvertApi/ListAllConvertPairsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1ConvertExchangeInfoResponse](src/Binance/Models/SapiV1ConvertExchangeInfoResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ListAllConvertPairsError](src/Binance/Errors/ListAllConvertPairsError.cs)&gt;</code>

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

<code>[OrderStatusUserDataRequest](src/Binance/Requests/ConvertApi/OrderStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertOrderStatusResponse](src/Binance/Models/SapiV1ConvertOrderStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[OrderStatusUserDataError](src/Binance/Errors/OrderStatusUserDataError.cs)&gt;</code>

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

<code>[PlaceLimitOrderUserDataRequest](src/Binance/Requests/ConvertApi/PlaceLimitOrderUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertLimitPlaceOrderResponse](src/Binance/Models/SapiV1ConvertLimitPlaceOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PlaceLimitOrderUserDataError](src/Binance/Errors/PlaceLimitOrderUserDataError.cs)&gt;</code>

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

<code>[QueryLimitOpenOrdersUserDataRequest](src/Binance/Requests/ConvertApi/QueryLimitOpenOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertLimitQueryOpenOrdersResponse](src/Binance/Models/SapiV1ConvertLimitQueryOpenOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryLimitOpenOrdersUserDataError](src/Binance/Errors/QueryLimitOpenOrdersUserDataError.cs)&gt;</code>

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

<code>[QueryOrderQuantityPrecisionPerAssetUserDataRequest](src/Binance/Requests/ConvertApi/QueryOrderQuantityPrecisionPerAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1ConvertAssetInfoResponse](src/Binance/Models/SapiV1ConvertAssetInfoResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryOrderQuantityPrecisionPerAssetUserDataError](src/Binance/Errors/QueryOrderQuantityPrecisionPerAssetUserDataError.cs)&gt;</code>

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

<code>[SendQuoteRequestUserDataRequest](src/Binance/Requests/ConvertApi/SendQuoteRequestUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ConvertGetQuoteResponse](src/Binance/Models/SapiV1ConvertGetQuoteResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SendQuoteRequestUserDataError](src/Binance/Errors/SendQuoteRequestUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CopyTrading

> Source: [CopyTrading](src/Binance/Api/CopyTrading.cs)

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

<code>[GetFuturesLeadTraderStatusTradeRequest](src/Binance/Requests/CopyTrading/GetFuturesLeadTraderStatusTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CopyTradingFuturesUserStatusResponse](src/Binance/Models/SapiV1CopyTradingFuturesUserStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFuturesLeadTraderStatusTradeError](src/Binance/Errors/GetFuturesLeadTraderStatusTradeError.cs)&gt;</code>

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

<code>[GetFuturesLeadTradingSymbolWhitelistUserDataRequest](src/Binance/Requests/CopyTrading/GetFuturesLeadTradingSymbolWhitelistUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CopyTradingFuturesLeadSymbolResponse](src/Binance/Models/SapiV1CopyTradingFuturesLeadSymbolResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFuturesLeadTradingSymbolWhitelistUserDataError](src/Binance/Errors/GetFuturesLeadTradingSymbolWhitelistUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CryptoLoans

> Source: [CryptoLoans](src/Binance/Api/CryptoLoans.cs)

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

<code>[AdjustLtvFlexibleLoanAdjustLtvTradeRequest](src/Binance/Requests/CryptoLoans/AdjustLtvFlexibleLoanAdjustLtvTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleAdjustLtvResponse](src/Binance/Models/SapiV2LoanFlexibleAdjustLtvResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AdjustLtvFlexibleLoanAdjustLtvTradeError](src/Binance/Errors/AdjustLtvFlexibleLoanAdjustLtvTradeError.cs)&gt;</code>

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

<code>[AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest](src/Binance/Requests/CryptoLoans/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleLtvAdjustmentHistoryResponse](src/Binance/Models/SapiV2LoanFlexibleLtvAdjustmentHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError](src/Binance/Errors/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError.cs)&gt;</code>

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

<code>[BorrowFlexibleLoanBorrowTradeRequest](src/Binance/Requests/CryptoLoans/BorrowFlexibleLoanBorrowTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleBorrowResponse](src/Binance/Models/SapiV2LoanFlexibleBorrowResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[BorrowFlexibleLoanBorrowTradeError](src/Binance/Errors/BorrowFlexibleLoanBorrowTradeError.cs)&gt;</code>

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

<code>[BorrowGetFlexibleLoanBorrowHistoryUserDataRequest](src/Binance/Requests/CryptoLoans/BorrowGetFlexibleLoanBorrowHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleBorrowHistoryResponse](src/Binance/Models/SapiV2LoanFlexibleBorrowHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[BorrowGetFlexibleLoanBorrowHistoryUserDataError](src/Binance/Errors/BorrowGetFlexibleLoanBorrowHistoryUserDataError.cs)&gt;</code>

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

<code>[BorrowGetFlexibleLoanOngoingOrdersUserDataRequest](src/Binance/Requests/CryptoLoans/BorrowGetFlexibleLoanOngoingOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleOngoingOrdersResponse](src/Binance/Models/SapiV2LoanFlexibleOngoingOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[BorrowGetFlexibleLoanOngoingOrdersUserDataError](src/Binance/Errors/BorrowGetFlexibleLoanOngoingOrdersUserDataError.cs)&gt;</code>

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

<code>[CheckCollateralRepayRateUserDataRequest](src/Binance/Requests/CryptoLoans/CheckCollateralRepayRateUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanRepayCollateralRateResponse](src/Binance/Models/SapiV1LoanRepayCollateralRateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CheckCollateralRepayRateUserDataError](src/Binance/Errors/CheckCollateralRepayRateUserDataError.cs)&gt;</code>

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

<code>[CryptoLoanAdjustLtvTradeRequest](src/Binance/Requests/CryptoLoans/CryptoLoanAdjustLtvTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanAdjustLtvResponse](src/Binance/Models/SapiV1LoanAdjustLtvResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CryptoLoanAdjustLtvTradeError](src/Binance/Errors/CryptoLoanAdjustLtvTradeError.cs)&gt;</code>

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

<code>[CryptoLoanBorrowTradeRequest](src/Binance/Requests/CryptoLoans/CryptoLoanBorrowTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanBorrowResponse](src/Binance/Models/SapiV1LoanBorrowResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CryptoLoanBorrowTradeError](src/Binance/Errors/CryptoLoanBorrowTradeError.cs)&gt;</code>

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

<code>[CryptoLoanCustomizeMarginCallTradeRequest](src/Binance/Requests/CryptoLoans/CryptoLoanCustomizeMarginCallTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanCustomizeMarginCallResponse](src/Binance/Models/SapiV1LoanCustomizeMarginCallResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CryptoLoanCustomizeMarginCallTradeError](src/Binance/Errors/CryptoLoanCustomizeMarginCallTradeError.cs)&gt;</code>

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

<code>[CryptoLoanRepayTradeRequest](src/Binance/Requests/CryptoLoans/CryptoLoanRepayTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanRepayResponse](src/Binance/Models/AnyOf/SapiV1LoanRepayResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CryptoLoanRepayTradeError](src/Binance/Errors/CryptoLoanRepayTradeError.cs)&gt;</code>

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

<code>[GetCollateralAssetsDataUserDataRequest](src/Binance/Requests/CryptoLoans/GetCollateralAssetsDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanCollateralDataResponse](src/Binance/Models/SapiV1LoanCollateralDataResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetCollateralAssetsDataUserDataError](src/Binance/Errors/GetCollateralAssetsDataUserDataError.cs)&gt;</code>

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

<code>[GetCryptoLoansBorrowHistoryUserDataRequest](src/Binance/Requests/CryptoLoans/GetCryptoLoansBorrowHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanBorrowHistoryResponse](src/Binance/Models/SapiV1LoanBorrowHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetCryptoLoansBorrowHistoryUserDataError](src/Binance/Errors/GetCryptoLoansBorrowHistoryUserDataError.cs)&gt;</code>

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

<code>[GetCryptoLoansIncomeHistoryUserDataRequest](src/Binance/Requests/CryptoLoans/GetCryptoLoansIncomeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LoanIncomeResponse](src/Binance/Models/SapiV1LoanIncomeResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetCryptoLoansIncomeHistoryUserDataError](src/Binance/Errors/GetCryptoLoansIncomeHistoryUserDataError.cs)&gt;</code>

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

<code>[GetFlexibleLoanAssetsDataUserDataRequest](src/Binance/Requests/CryptoLoans/GetFlexibleLoanAssetsDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleLoanableDataResponse](src/Binance/Models/SapiV2LoanFlexibleLoanableDataResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFlexibleLoanAssetsDataUserDataError](src/Binance/Errors/GetFlexibleLoanAssetsDataUserDataError.cs)&gt;</code>

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

<code>[GetFlexibleLoanCollateralAssetsDataUserDataRequest](src/Binance/Requests/CryptoLoans/GetFlexibleLoanCollateralAssetsDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleCollateralDataResponse](src/Binance/Models/SapiV2LoanFlexibleCollateralDataResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFlexibleLoanCollateralAssetsDataUserDataError](src/Binance/Errors/GetFlexibleLoanCollateralAssetsDataUserDataError.cs)&gt;</code>

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

<code>[GetLoanLtvAdjustmentHistoryUserDataRequest](src/Binance/Requests/CryptoLoans/GetLoanLtvAdjustmentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanLtvAdjustmentHistoryResponse](src/Binance/Models/SapiV1LoanLtvAdjustmentHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLoanLtvAdjustmentHistoryUserDataError](src/Binance/Errors/GetLoanLtvAdjustmentHistoryUserDataError.cs)&gt;</code>

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

<code>[GetLoanOngoingOrdersUserDataRequest](src/Binance/Requests/CryptoLoans/GetLoanOngoingOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanOngoingOrdersResponse](src/Binance/Models/SapiV1LoanOngoingOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLoanOngoingOrdersUserDataError](src/Binance/Errors/GetLoanOngoingOrdersUserDataError.cs)&gt;</code>

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

<code>[GetLoanRepaymentHistoryUserDataRequest](src/Binance/Requests/CryptoLoans/GetLoanRepaymentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanRepayHistoryResponse](src/Binance/Models/SapiV1LoanRepayHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLoanRepaymentHistoryUserDataError](src/Binance/Errors/GetLoanRepaymentHistoryUserDataError.cs)&gt;</code>

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

<code>[GetLoanableAssetsDataUserDataRequest](src/Binance/Requests/CryptoLoans/GetLoanableAssetsDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanLoanableDataResponse](src/Binance/Models/SapiV1LoanLoanableDataResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLoanableAssetsDataUserDataError](src/Binance/Errors/GetLoanableAssetsDataUserDataError.cs)&gt;</code>

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

<code>[RepayFlexibleLoanRepayTradeRequest](src/Binance/Requests/CryptoLoans/RepayFlexibleLoanRepayTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleRepayResponse](src/Binance/Models/SapiV2LoanFlexibleRepayResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RepayFlexibleLoanRepayTradeError](src/Binance/Errors/RepayFlexibleLoanRepayTradeError.cs)&gt;</code>

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

<code>[RepayGetFlexibleLoanRepaymentHistoryUserDataRequest](src/Binance/Requests/CryptoLoans/RepayGetFlexibleLoanRepaymentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2LoanFlexibleRepayHistoryResponse](src/Binance/Models/SapiV2LoanFlexibleRepayHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RepayGetFlexibleLoanRepaymentHistoryUserDataError](src/Binance/Errors/RepayGetFlexibleLoanRepaymentHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DualInvestment

> Source: [DualInvestment](src/Binance/Api/DualInvestment.cs)

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

<code>[ChangeAutoCompoundStatusUserDataRequest](src/Binance/Requests/DualInvestment/ChangeAutoCompoundStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductAutoCompoundEditStatusResponse](src/Binance/Models/SapiV1DciProductAutoCompoundEditStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ChangeAutoCompoundStatusUserDataError](src/Binance/Errors/ChangeAutoCompoundStatusUserDataError.cs)&gt;</code>

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

<code>[CheckDualInvestmentAccountsUserDataRequest](src/Binance/Requests/DualInvestment/CheckDualInvestmentAccountsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductAccountsResponse](src/Binance/Models/SapiV1DciProductAccountsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CheckDualInvestmentAccountsUserDataError](src/Binance/Errors/CheckDualInvestmentAccountsUserDataError.cs)&gt;</code>

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

<code>[GetDualInvestmentPositionsUserDataRequest](src/Binance/Requests/DualInvestment/GetDualInvestmentPositionsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductPositionsResponse](src/Binance/Models/SapiV1DciProductPositionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetDualInvestmentPositionsUserDataError](src/Binance/Errors/GetDualInvestmentPositionsUserDataError.cs)&gt;</code>

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

<code>[GetDualInvestmentProductListUserDataRequest](src/Binance/Requests/DualInvestment/GetDualInvestmentProductListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductListResponse](src/Binance/Models/SapiV1DciProductListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetDualInvestmentProductListUserDataError](src/Binance/Errors/GetDualInvestmentProductListUserDataError.cs)&gt;</code>

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

<code>[SubscribeDualInvestmentProductsUserDataRequest](src/Binance/Requests/DualInvestment/SubscribeDualInvestmentProductsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1DciProductSubscribeResponse](src/Binance/Models/SapiV1DciProductSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubscribeDualInvestmentProductsUserDataError](src/Binance/Errors/SubscribeDualInvestmentProductsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Fiat

> Source: [Fiat](src/Binance/Api/Fiat.cs)

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

<code>[FiatDepositWithdrawHistoryUserDataRequest](src/Binance/Requests/Fiat/FiatDepositWithdrawHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FiatOrdersResponse](src/Binance/Models/SapiV1FiatOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FiatDepositWithdrawHistoryUserDataError](src/Binance/Errors/FiatDepositWithdrawHistoryUserDataError.cs)&gt;</code>

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

<code>[FiatPaymentsHistoryUserDataRequest](src/Binance/Requests/Fiat/FiatPaymentsHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FiatPaymentsResponse](src/Binance/Models/SapiV1FiatPaymentsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FiatPaymentsHistoryUserDataError](src/Binance/Errors/FiatPaymentsHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Futures

> Source: [Futures](src/Binance/Api/Futures.cs)

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

<code>[GetFutureAccountTransactionHistoryListUserDataRequest](src/Binance/Requests/Futures/GetFutureAccountTransactionHistoryListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FuturesTransferResponse1](src/Binance/Models/SapiV1FuturesTransferResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFutureAccountTransactionHistoryListUserDataError](src/Binance/Errors/GetFutureAccountTransactionHistoryListUserDataError.cs)&gt;</code>

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

<code>[GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest](src/Binance/Requests/Futures/GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FuturesHistDataLinkResponse](src/Binance/Models/SapiV1FuturesHistDataLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError](src/Binance/Errors/GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError.cs)&gt;</code>

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

<code>[NewFutureAccountTransferUserDataRequest](src/Binance/Requests/Futures/NewFutureAccountTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1FuturesTransferResponse](src/Binance/Models/SapiV1FuturesTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[NewFutureAccountTransferUserDataError](src/Binance/Errors/NewFutureAccountTransferUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FuturesAlgo

> Source: [FuturesAlgo](src/Binance/Api/FuturesAlgo.cs)

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

<code>[CancelAlgoOrderTradeRequest](src/Binance/Requests/FuturesAlgo/CancelAlgoOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesOrderResponse](src/Binance/Models/SapiV1AlgoFuturesOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CancelAlgoOrderTradeError](src/Binance/Errors/CancelAlgoOrderTradeError.cs)&gt;</code>

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

<code>[QueryCurrentAlgoOpenOrdersUserDataRequest](src/Binance/Requests/FuturesAlgo/QueryCurrentAlgoOpenOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesOpenOrdersResponse](src/Binance/Models/SapiV1AlgoFuturesOpenOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryCurrentAlgoOpenOrdersUserDataError](src/Binance/Errors/QueryCurrentAlgoOpenOrdersUserDataError.cs)&gt;</code>

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

<code>[QueryHistoricalAlgoOrdersUserDataRequest](src/Binance/Requests/FuturesAlgo/QueryHistoricalAlgoOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesHistoricalOrdersResponse](src/Binance/Models/SapiV1AlgoFuturesHistoricalOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryHistoricalAlgoOrdersUserDataError](src/Binance/Errors/QueryHistoricalAlgoOrdersUserDataError.cs)&gt;</code>

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

<code>[QuerySubOrdersUserDataRequest](src/Binance/Requests/FuturesAlgo/QuerySubOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesSubOrdersResponse](src/Binance/Models/SapiV1AlgoFuturesSubOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QuerySubOrdersUserDataError](src/Binance/Errors/QuerySubOrdersUserDataError.cs)&gt;</code>

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

<code>[TimeWeightedAveragePriceTwapNewOrderTradeRequest](src/Binance/Requests/FuturesAlgo/TimeWeightedAveragePriceTwapNewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesNewOrderTwapResponse](src/Binance/Models/SapiV1AlgoFuturesNewOrderTwapResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[TimeWeightedAveragePriceTwapNewOrderTradeError](src/Binance/Errors/TimeWeightedAveragePriceTwapNewOrderTradeError.cs)&gt;</code>

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

<code>[VolumeParticipationVpNewOrderTradeRequest](src/Binance/Requests/FuturesAlgo/VolumeParticipationVpNewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoFuturesNewOrderVpResponse](src/Binance/Models/SapiV1AlgoFuturesNewOrderVpResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[VolumeParticipationVpNewOrderTradeError](src/Binance/Errors/VolumeParticipationVpNewOrderTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GiftCard

> Source: [GiftCard](src/Binance/Api/GiftCard.cs)

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

<code>[BuyABinanceCodeTradeRequest](src/Binance/Requests/GiftCard/BuyABinanceCodeTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardBuyCodeResponse](src/Binance/Models/SapiV1GiftcardBuyCodeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[BuyABinanceCodeTradeError](src/Binance/Errors/BuyABinanceCodeTradeError.cs)&gt;</code>

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

<code>[CreateABinanceCodeUserDataRequest](src/Binance/Requests/GiftCard/CreateABinanceCodeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardCreateCodeResponse](src/Binance/Models/SapiV1GiftcardCreateCodeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CreateABinanceCodeUserDataError](src/Binance/Errors/CreateABinanceCodeUserDataError.cs)&gt;</code>

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

<code>[FetchRsaPublicKeyUserDataRequest](src/Binance/Requests/GiftCard/FetchRsaPublicKeyUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardCryptographyRsaPublicKeyResponse](src/Binance/Models/SapiV1GiftcardCryptographyRsaPublicKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FetchRsaPublicKeyUserDataError](src/Binance/Errors/FetchRsaPublicKeyUserDataError.cs)&gt;</code>

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

<code>[FetchTokenLimitUserDataRequest](src/Binance/Requests/GiftCard/FetchTokenLimitUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardBuyCodeTokenLimitResponse](src/Binance/Models/SapiV1GiftcardBuyCodeTokenLimitResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FetchTokenLimitUserDataError](src/Binance/Errors/FetchTokenLimitUserDataError.cs)&gt;</code>

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

<code>[RedeemABinanceCodeUserDataRequest](src/Binance/Requests/GiftCard/RedeemABinanceCodeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardRedeemCodeResponse](src/Binance/Models/SapiV1GiftcardRedeemCodeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RedeemABinanceCodeUserDataError](src/Binance/Errors/RedeemABinanceCodeUserDataError.cs)&gt;</code>

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

<code>[VerifyABinanceCodeUserDataRequest](src/Binance/Requests/GiftCard/VerifyABinanceCodeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1GiftcardVerifyResponse](src/Binance/Models/SapiV1GiftcardVerifyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[VerifyABinanceCodeUserDataError](src/Binance/Errors/VerifyABinanceCodeUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IsolatedMarginStream

> Source: [IsolatedMarginStream](src/Binance/Api/IsolatedMarginStream.cs)

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

<code>[CloseAListenKeyUserStream3Request](src/Binance/Requests/IsolatedMarginStream/CloseAListenKeyUserStream3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CloseAListenKeyUserStream3Error](src/Binance/Errors/CloseAListenKeyUserStream3Error.cs)&gt;</code>

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

**OnSuccess**: <code>[SapiV1UserDataStreamIsolatedResponse](src/Binance/Models/SapiV1UserDataStreamIsolatedResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Binance/Core/ErrorResponse/RawError.cs)&gt;</code>

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

<code>[PingKeepAliveAListenKeyUserStreamOperationRequest](src/Binance/Requests/IsolatedMarginStream/PingKeepAliveAListenKeyUserStreamOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PingKeepAliveAListenKeyUserStreamApiError](src/Binance/Errors/PingKeepAliveAListenKeyUserStreamApiError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Margin

> Source: [Margin](src/Binance/Api/Margin.cs)

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

<code>[AdjustCrossMarginMaxLeverageUserDataRequest](src/Binance/Requests/Margin/AdjustCrossMarginMaxLeverageUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginMaxLeverageResponse](src/Binance/Models/SapiV1MarginMaxLeverageResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AdjustCrossMarginMaxLeverageUserDataError](src/Binance/Errors/AdjustCrossMarginMaxLeverageUserDataError.cs)&gt;</code>

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

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginCrossMarginCollateralRatioResponse](src/Binance/Models/SapiV1MarginCrossMarginCollateralRatioResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CrossMarginCollateralRatioMarketDataError](src/Binance/Errors/CrossMarginCollateralRatioMarketDataError.cs)&gt;</code>

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

<code>[DisableIsolatedMarginAccountTradeRequest](src/Binance/Requests/Margin/DisableIsolatedMarginAccountTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginIsolatedAccountResponse](src/Binance/Models/SapiV1MarginIsolatedAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DisableIsolatedMarginAccountTradeError](src/Binance/Errors/DisableIsolatedMarginAccountTradeError.cs)&gt;</code>

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

<code>[EnableIsolatedMarginAccountTradeRequest](src/Binance/Requests/Margin/EnableIsolatedMarginAccountTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginIsolatedAccountResponse](src/Binance/Models/SapiV1MarginIsolatedAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[EnableIsolatedMarginAccountTradeError](src/Binance/Errors/EnableIsolatedMarginAccountTradeError.cs)&gt;</code>

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

<code>[GetAllCrossMarginPairsMarketDataRequest](src/Binance/Requests/Margin/GetAllCrossMarginPairsMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginAllPairsResponse](src/Binance/Models/SapiV1MarginAllPairsResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetAllCrossMarginPairsMarketDataError](src/Binance/Errors/GetAllCrossMarginPairsMarketDataError.cs)&gt;</code>

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

<code>[GetAllIsolatedMarginSymbolUserDataRequest](src/Binance/Requests/Margin/GetAllIsolatedMarginSymbolUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginIsolatedAllPairsResponse](src/Binance/Models/SapiV1MarginIsolatedAllPairsResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetAllIsolatedMarginSymbolUserDataError](src/Binance/Errors/GetAllIsolatedMarginSymbolUserDataError.cs)&gt;</code>

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

<code>[GetAllMarginAssetsMarketDataRequest](src/Binance/Requests/Margin/GetAllMarginAssetsMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginAllAssetsResponse](src/Binance/Models/SapiV1MarginAllAssetsResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetAllMarginAssetsMarketDataError](src/Binance/Errors/GetAllMarginAssetsMarketDataError.cs)&gt;</code>

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

<code>[GetBnbBurnStatusUserDataRequest](src/Binance/Requests/Margin/GetBnbBurnStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BnbBurnStatus](src/Binance/Models/BnbBurnStatus.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetBnbBurnStatusUserDataError](src/Binance/Errors/GetBnbBurnStatusUserDataError.cs)&gt;</code>

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

<code>[GetCrossMarginTransferHistoryUserDataRequest](src/Binance/Requests/Margin/GetCrossMarginTransferHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginTransferResponse](src/Binance/Models/SapiV1MarginTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetCrossMarginTransferHistoryUserDataError](src/Binance/Errors/GetCrossMarginTransferHistoryUserDataError.cs)&gt;</code>

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

<code>[GetForceLiquidationRecordUserDataRequest](src/Binance/Requests/Margin/GetForceLiquidationRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginForceLiquidationRecResponse](src/Binance/Models/SapiV1MarginForceLiquidationRecResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetForceLiquidationRecordUserDataError](src/Binance/Errors/GetForceLiquidationRecordUserDataError.cs)&gt;</code>

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

<code>[GetInterestHistoryUserDataRequest](src/Binance/Requests/Margin/GetInterestHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginInterestHistoryResponse](src/Binance/Models/SapiV1MarginInterestHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetInterestHistoryUserDataError](src/Binance/Errors/GetInterestHistoryUserDataError.cs)&gt;</code>

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

<code>[GetSmallLiabilityExchangeCoinListUserDataRequest](src/Binance/Requests/Margin/GetSmallLiabilityExchangeCoinListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginExchangeSmallLiabilityResponse](src/Binance/Models/SapiV1MarginExchangeSmallLiabilityResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetSmallLiabilityExchangeCoinListUserDataError](src/Binance/Errors/GetSmallLiabilityExchangeCoinListUserDataError.cs)&gt;</code>

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

<code>[GetSmallLiabilityExchangeHistoryUserDataRequest](src/Binance/Requests/Margin/GetSmallLiabilityExchangeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginExchangeSmallLiabilityHistoryResponse](src/Binance/Models/SapiV1MarginExchangeSmallLiabilityHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetSmallLiabilityExchangeHistoryUserDataError](src/Binance/Errors/GetSmallLiabilityExchangeHistoryUserDataError.cs)&gt;</code>

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

<code>[GetSummaryOfMarginAccountUserDataRequest](src/Binance/Requests/Margin/GetSummaryOfMarginAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginTradeCoeffResponse](src/Binance/Models/SapiV1MarginTradeCoeffResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetSummaryOfMarginAccountUserDataError](src/Binance/Errors/GetSummaryOfMarginAccountUserDataError.cs)&gt;</code>

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

<code>[GetAFutureHourlyInterestRateUserDataRequest](src/Binance/Requests/Margin/GetAFutureHourlyInterestRateUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginNextHourlyInterestRateResponse](src/Binance/Models/SapiV1MarginNextHourlyInterestRateResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetAFutureHourlyInterestRateUserDataError](src/Binance/Errors/GetAFutureHourlyInterestRateUserDataError.cs)&gt;</code>

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

<code>[GetCrossOrIsolatedMarginCapitalFlowUserDataRequest](src/Binance/Requests/Margin/GetCrossOrIsolatedMarginCapitalFlowUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginCapitalFlowResponse](src/Binance/Models/SapiV1MarginCapitalFlowResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetCrossOrIsolatedMarginCapitalFlowUserDataError](src/Binance/Errors/GetCrossOrIsolatedMarginCapitalFlowUserDataError.cs)&gt;</code>

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

<code>[GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest](src/Binance/Requests/Margin/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginDelistScheduleResponse](src/Binance/Models/SapiV1MarginDelistScheduleResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError](src/Binance/Errors/GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError.cs)&gt;</code>

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

<code>[MarginAccountCancelOcoTradeRequest](src/Binance/Requests/Margin/MarginAccountCancelOcoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MarginOcoOrder](src/Binance/Models/MarginOcoOrder.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginAccountCancelOcoTradeError](src/Binance/Errors/MarginAccountCancelOcoTradeError.cs)&gt;</code>

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

<code>[MarginAccountCancelOrderTradeRequest](src/Binance/Requests/Margin/MarginAccountCancelOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MarginOrder](src/Binance/Models/MarginOrder.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginAccountCancelOrderTradeError](src/Binance/Errors/MarginAccountCancelOrderTradeError.cs)&gt;</code>

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

<code>[MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest](src/Binance/Requests/Margin/MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginOpenOrdersResponse](src/Binance/Models/AnyOf/SapiV1MarginOpenOrdersResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginAccountCancelAllOpenOrdersOnASymbolTradeError](src/Binance/Errors/MarginAccountCancelAllOpenOrdersOnASymbolTradeError.cs)&gt;</code>

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

<code>[MarginAccountNewOcoTradeRequest](src/Binance/Requests/Margin/MarginAccountNewOcoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderOcoResponse](src/Binance/Models/SapiV1MarginOrderOcoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginAccountNewOcoTradeError](src/Binance/Errors/MarginAccountNewOcoTradeError.cs)&gt;</code>

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

<code>[MarginAccountNewOtoTradeRequest](src/Binance/Requests/Margin/MarginAccountNewOtoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderOtoResponse](src/Binance/Models/SapiV1MarginOrderOtoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginAccountNewOtoTradeError](src/Binance/Errors/MarginAccountNewOtoTradeError.cs)&gt;</code>

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

<code>[MarginAccountNewOtocoTradeRequest](src/Binance/Requests/Margin/MarginAccountNewOtocoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderOtocoResponse](src/Binance/Models/SapiV1MarginOrderOtocoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginAccountNewOtocoTradeError](src/Binance/Errors/MarginAccountNewOtocoTradeError.cs)&gt;</code>

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

<code>[MarginAccountNewOrderTradeRequest](src/Binance/Requests/Margin/MarginAccountNewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderResponse](src/Binance/Models/AnyOf/SapiV1MarginOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginAccountNewOrderTradeError](src/Binance/Errors/MarginAccountNewOrderTradeError.cs)&gt;</code>

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

<code>[MarginInterestRateHistoryUserDataRequest](src/Binance/Requests/Margin/MarginInterestRateHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginInterestRateHistoryResponse](src/Binance/Models/SapiV1MarginInterestRateHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginInterestRateHistoryUserDataError](src/Binance/Errors/MarginInterestRateHistoryUserDataError.cs)&gt;</code>

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

<code>[MarginAccountBorrowRepayMarginRequest](src/Binance/Requests/Margin/MarginAccountBorrowRepayMarginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginBorrowRepayResponse](src/Binance/Models/SapiV1MarginBorrowRepayResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginAccountBorrowRepayMarginError](src/Binance/Errors/MarginAccountBorrowRepayMarginError.cs)&gt;</code>

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

<code>[MarginManualLiquidationMarginRequest](src/Binance/Requests/Margin/MarginManualLiquidationMarginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginManualLiquidationResponse](src/Binance/Models/SapiV1MarginManualLiquidationResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginManualLiquidationMarginError](src/Binance/Errors/MarginManualLiquidationMarginError.cs)&gt;</code>

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

<code>[QueryCrossMarginAccountDetailsUserDataRequest](src/Binance/Requests/Margin/QueryCrossMarginAccountDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginAccountResponse](src/Binance/Models/SapiV1MarginAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryCrossMarginAccountDetailsUserDataError](src/Binance/Errors/QueryCrossMarginAccountDetailsUserDataError.cs)&gt;</code>

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

<code>[QueryCrossMarginFeeDataUserDataRequest](src/Binance/Requests/Margin/QueryCrossMarginFeeDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginCrossMarginDataResponse](src/Binance/Models/SapiV1MarginCrossMarginDataResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryCrossMarginFeeDataUserDataError](src/Binance/Errors/QueryCrossMarginFeeDataUserDataError.cs)&gt;</code>

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

<code>[QueryCurrentMarginOrderCountUsageTradeRequest](src/Binance/Requests/Margin/QueryCurrentMarginOrderCountUsageTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginRateLimitOrderResponse](src/Binance/Models/SapiV1MarginRateLimitOrderResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryCurrentMarginOrderCountUsageTradeError](src/Binance/Errors/QueryCurrentMarginOrderCountUsageTradeError.cs)&gt;</code>

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

<code>[QueryEnabledIsolatedMarginAccountLimitUserDataRequest](src/Binance/Requests/Margin/QueryEnabledIsolatedMarginAccountLimitUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginIsolatedAccountLimitResponse](src/Binance/Models/SapiV1MarginIsolatedAccountLimitResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryEnabledIsolatedMarginAccountLimitUserDataError](src/Binance/Errors/QueryEnabledIsolatedMarginAccountLimitUserDataError.cs)&gt;</code>

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

<code>[QueryIsolatedMarginAccountInfoUserDataRequest](src/Binance/Requests/Margin/QueryIsolatedMarginAccountInfoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IsolatedMarginAccountInfo](src/Binance/Models/IsolatedMarginAccountInfo.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryIsolatedMarginAccountInfoUserDataError](src/Binance/Errors/QueryIsolatedMarginAccountInfoUserDataError.cs)&gt;</code>

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

<code>[QueryIsolatedMarginFeeDataUserDataRequest](src/Binance/Requests/Margin/QueryIsolatedMarginFeeDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginIsolatedMarginDataResponse](src/Binance/Models/SapiV1MarginIsolatedMarginDataResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryIsolatedMarginFeeDataUserDataError](src/Binance/Errors/QueryIsolatedMarginFeeDataUserDataError.cs)&gt;</code>

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

<code>[QueryIsolatedMarginTierDataUserDataRequest](src/Binance/Requests/Margin/QueryIsolatedMarginTierDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginIsolatedMarginTierResponse](src/Binance/Models/SapiV1MarginIsolatedMarginTierResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryIsolatedMarginTierDataUserDataError](src/Binance/Errors/QueryIsolatedMarginTierDataUserDataError.cs)&gt;</code>

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

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginLeverageBracketResponse](src/Binance/Models/SapiV1MarginLeverageBracketResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError](src/Binance/Errors/QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError.cs)&gt;</code>

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

<code>[QueryMarginAccountSAllOrdersUserDataRequest](src/Binance/Requests/Margin/QueryMarginAccountSAllOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MarginOrderDetail](src/Binance/Models/MarginOrderDetail.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSAllOrdersUserDataError](src/Binance/Errors/QueryMarginAccountSAllOrdersUserDataError.cs)&gt;</code>

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

<code>[QueryMarginAccountSOcoUserDataRequest](src/Binance/Requests/Margin/QueryMarginAccountSOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginOrderListResponse](src/Binance/Models/SapiV1MarginOrderListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSOcoUserDataError](src/Binance/Errors/QueryMarginAccountSOcoUserDataError.cs)&gt;</code>

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

<code>[QueryMarginAccountSOpenOcoUserDataRequest](src/Binance/Requests/Margin/QueryMarginAccountSOpenOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginOpenOrderListResponse](src/Binance/Models/SapiV1MarginOpenOrderListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSOpenOcoUserDataError](src/Binance/Errors/QueryMarginAccountSOpenOcoUserDataError.cs)&gt;</code>

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

<code>[QueryMarginAccountSOpenOrdersUserDataRequest](src/Binance/Requests/Margin/QueryMarginAccountSOpenOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MarginOrderDetail](src/Binance/Models/MarginOrderDetail.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSOpenOrdersUserDataError](src/Binance/Errors/QueryMarginAccountSOpenOrdersUserDataError.cs)&gt;</code>

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

<code>[QueryMarginAccountSOrderUserDataRequest](src/Binance/Requests/Margin/QueryMarginAccountSOrderUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MarginOrderDetail](src/Binance/Models/MarginOrderDetail.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSOrderUserDataError](src/Binance/Errors/QueryMarginAccountSOrderUserDataError.cs)&gt;</code>

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

<code>[QueryMarginAccountSTradeListUserDataRequest](src/Binance/Requests/Margin/QueryMarginAccountSTradeListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MarginTrade](src/Binance/Models/MarginTrade.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSTradeListUserDataError](src/Binance/Errors/QueryMarginAccountSTradeListUserDataError.cs)&gt;</code>

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

<code>[QueryMarginAccountSAllOcoUserDataRequest](src/Binance/Requests/Margin/QueryMarginAccountSAllOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1MarginAllOrderListResponse](src/Binance/Models/SapiV1MarginAllOrderListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMarginAccountSAllOcoUserDataError](src/Binance/Errors/QueryMarginAccountSAllOcoUserDataError.cs)&gt;</code>

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

<code>[QueryMarginAvailableInventoryUserDataRequest](src/Binance/Requests/Margin/QueryMarginAvailableInventoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginAvailableInventoryResponse](src/Binance/Models/SapiV1MarginAvailableInventoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMarginAvailableInventoryUserDataError](src/Binance/Errors/QueryMarginAvailableInventoryUserDataError.cs)&gt;</code>

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

<code>[QueryMarginPriceIndexMarketDataRequest](src/Binance/Requests/Margin/QueryMarginPriceIndexMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginPriceIndexResponse](src/Binance/Models/SapiV1MarginPriceIndexResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMarginPriceIndexMarketDataError](src/Binance/Errors/QueryMarginPriceIndexMarketDataError.cs)&gt;</code>

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

<code>[QueryMaxBorrowUserDataRequest](src/Binance/Requests/Margin/QueryMaxBorrowUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginMaxBorrowableResponse](src/Binance/Models/SapiV1MarginMaxBorrowableResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMaxBorrowUserDataError](src/Binance/Errors/QueryMaxBorrowUserDataError.cs)&gt;</code>

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

<code>[QueryMaxTransferOutAmountUserDataRequest](src/Binance/Requests/Margin/QueryMaxTransferOutAmountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginMaxTransferableResponse](src/Binance/Models/SapiV1MarginMaxTransferableResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryMaxTransferOutAmountUserDataError](src/Binance/Errors/QueryMaxTransferOutAmountUserDataError.cs)&gt;</code>

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

<code>[QueryBorrowRepayRecordsInMarginAccountUserDataRequest](src/Binance/Requests/Margin/QueryBorrowRepayRecordsInMarginAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MarginBorrowRepayResponse1](src/Binance/Models/SapiV1MarginBorrowRepayResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryBorrowRepayRecordsInMarginAccountUserDataError](src/Binance/Errors/QueryBorrowRepayRecordsInMarginAccountUserDataError.cs)&gt;</code>

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

<code>[ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest](src/Binance/Requests/Margin/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BnbBurnStatus](src/Binance/Models/BnbBurnStatus.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError](src/Binance/Errors/ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MarginStream

> Source: [MarginStream](src/Binance/Api/MarginStream.cs)

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

<code>[CloseAListenKeyUserStream2Request](src/Binance/Requests/MarginStream/CloseAListenKeyUserStream2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CloseAListenKeyUserStream2Error](src/Binance/Errors/CloseAListenKeyUserStream2Error.cs)&gt;</code>

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

**OnSuccess**: <code>[SapiV1UserDataStreamResponse](src/Binance/Models/SapiV1UserDataStreamResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Binance/Core/ErrorResponse/RawError.cs)&gt;</code>

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

<code>[PingKeepAliveAListenKeyUserStream2Request](src/Binance/Requests/MarginStream/PingKeepAliveAListenKeyUserStream2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PingKeepAliveAListenKeyUserStream2Error](src/Binance/Errors/PingKeepAliveAListenKeyUserStream2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Market

> Source: [Market](src/Binance/Api/Market.cs)

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

<code>[HrTickerPriceChangeStatistics24Request](src/Binance/Requests/Market/HrTickerPriceChangeStatistics24Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3Ticker24HrResponse](src/Binance/Models/AnyOf/ApiV3Ticker24HrResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[HrTickerPriceChangeStatistics24Error](src/Binance/Errors/HrTickerPriceChangeStatistics24Error.cs)&gt;</code>

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

**OnSuccess**: <code>[ApiV3TimeResponse](src/Binance/Models/ApiV3TimeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Binance/Core/ErrorResponse/RawError.cs)&gt;</code>

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

<code>[CompressedAggregateTradesListRequest](src/Binance/Requests/Market/CompressedAggregateTradesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AggTrade](src/Binance/Models/AggTrade.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CompressedAggregateTradesListError](src/Binance/Errors/CompressedAggregateTradesListError.cs)&gt;</code>

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

<code>[CurrentAveragePriceRequest](src/Binance/Requests/Market/CurrentAveragePriceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3AvgPriceResponse](src/Binance/Models/ApiV3AvgPriceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CurrentAveragePriceError](src/Binance/Errors/CurrentAveragePriceError.cs)&gt;</code>

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

<code>[ExchangeInformationRequest](src/Binance/Requests/Market/ExchangeInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3ExchangeInfoResponse](src/Binance/Models/ApiV3ExchangeInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ExchangeInformationError](src/Binance/Errors/ExchangeInformationError.cs)&gt;</code>

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

<code>[KlineCandlestickDataRequest](src/Binance/Requests/Market/KlineCandlestickDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[ApiV3KlinesResponse](src/Binance/Models/AnyOf/ApiV3KlinesResponse.cs)&gt;&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[KlineCandlestickDataError](src/Binance/Errors/KlineCandlestickDataError.cs)&gt;</code>

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

<code>[OldTradeLookupRequest](src/Binance/Requests/Market/OldTradeLookupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Trade](src/Binance/Models/Trade.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Binance/Core/ErrorResponse/RawError.cs)&gt;</code>

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

<code>[OrderBookRequest](src/Binance/Requests/Market/OrderBookRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3DepthResponse](src/Binance/Models/ApiV3DepthResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[OrderBookError](src/Binance/Errors/OrderBookError.cs)&gt;</code>

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

<code>[RecentTradesListRequest](src/Binance/Requests/Market/RecentTradesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Trade](src/Binance/Models/Trade.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RecentTradesListError](src/Binance/Errors/RecentTradesListError.cs)&gt;</code>

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

<code>[RollingWindowPriceChangeStatisticsRequest](src/Binance/Requests/Market/RollingWindowPriceChangeStatisticsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerResponse](src/Binance/Models/ApiV3TickerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RollingWindowPriceChangeStatisticsError](src/Binance/Errors/RollingWindowPriceChangeStatisticsError.cs)&gt;</code>

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

<code>[SymbolOrderBookTickerRequest](src/Binance/Requests/Market/SymbolOrderBookTickerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerBookTickerResponse](src/Binance/Models/AnyOf/ApiV3TickerBookTickerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SymbolOrderBookTickerError](src/Binance/Errors/SymbolOrderBookTickerError.cs)&gt;</code>

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

<code>[SymbolPriceTickerRequest](src/Binance/Requests/Market/SymbolPriceTickerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerPriceResponse](src/Binance/Models/AnyOf/ApiV3TickerPriceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SymbolPriceTickerError](src/Binance/Errors/SymbolPriceTickerError.cs)&gt;</code>

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

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Binance/Core/ErrorResponse/RawError.cs)&gt;</code>

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

<code>[TradingDayTickerRequest](src/Binance/Requests/Market/TradingDayTickerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3TickerTradingDayResponse](src/Binance/Models/AnyOf/ApiV3TickerTradingDayResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[TradingDayTickerError](src/Binance/Errors/TradingDayTickerError.cs)&gt;</code>

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

<code>[UiKlinesRequest](src/Binance/Requests/Market/UiKlinesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[ApiV3UiKlinesResponse](src/Binance/Models/AnyOf/ApiV3UiKlinesResponse.cs)&gt;&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[UiKlinesError](src/Binance/Errors/UiKlinesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Mining

> Source: [Mining](src/Binance/Api/Mining.cs)

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

<code>[AccountListUserDataRequest](src/Binance/Requests/Mining/AccountListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningStatisticsUserListResponse](src/Binance/Models/SapiV1MiningStatisticsUserListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AccountListUserDataError](src/Binance/Errors/AccountListUserDataError.cs)&gt;</code>

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

**OnSuccess**: <code>[SapiV1MiningPubAlgoListResponse](src/Binance/Models/SapiV1MiningPubAlgoListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AcquiringAlgorithmMarketDataError](src/Binance/Errors/AcquiringAlgorithmMarketDataError.cs)&gt;</code>

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

**OnSuccess**: <code>[SapiV1MiningPubCoinListResponse](src/Binance/Models/SapiV1MiningPubCoinListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AcquiringCoinNameMarketDataError](src/Binance/Errors/AcquiringCoinNameMarketDataError.cs)&gt;</code>

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

<code>[CancelHashrateResaleConfigurationUserDataRequest](src/Binance/Requests/Mining/CancelHashrateResaleConfigurationUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferConfigCancelResponse](src/Binance/Models/SapiV1MiningHashTransferConfigCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CancelHashrateResaleConfigurationUserDataError](src/Binance/Errors/CancelHashrateResaleConfigurationUserDataError.cs)&gt;</code>

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

<code>[EarningsListUserDataRequest](src/Binance/Requests/Mining/EarningsListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPaymentListResponse](src/Binance/Models/SapiV1MiningPaymentListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[EarningsListUserDataError](src/Binance/Errors/EarningsListUserDataError.cs)&gt;</code>

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

<code>[ExtraBonusListUserDataRequest](src/Binance/Requests/Mining/ExtraBonusListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPaymentOtherResponse](src/Binance/Models/SapiV1MiningPaymentOtherResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ExtraBonusListUserDataError](src/Binance/Errors/ExtraBonusListUserDataError.cs)&gt;</code>

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

<code>[HashrateResaleDetailsUserDataRequest](src/Binance/Requests/Mining/HashrateResaleDetailsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferProfitDetailsResponse](src/Binance/Models/SapiV1MiningHashTransferProfitDetailsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[HashrateResaleDetailsUserDataError](src/Binance/Errors/HashrateResaleDetailsUserDataError.cs)&gt;</code>

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

<code>[HashrateResaleListUserDataRequest](src/Binance/Requests/Mining/HashrateResaleListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferConfigDetailsListResponse](src/Binance/Models/SapiV1MiningHashTransferConfigDetailsListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[HashrateResaleListUserDataError](src/Binance/Errors/HashrateResaleListUserDataError.cs)&gt;</code>

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

<code>[HashrateResaleRequestUserDataRequest](src/Binance/Requests/Mining/HashrateResaleRequestUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningHashTransferConfigResponse](src/Binance/Models/SapiV1MiningHashTransferConfigResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[HashrateResaleRequestUserDataError](src/Binance/Errors/HashrateResaleRequestUserDataError.cs)&gt;</code>

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

<code>[MiningAccountEarningUserDataRequest](src/Binance/Requests/Mining/MiningAccountEarningUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningPaymentUidResponse](src/Binance/Models/SapiV1MiningPaymentUidResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MiningAccountEarningUserDataError](src/Binance/Errors/MiningAccountEarningUserDataError.cs)&gt;</code>

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

<code>[RequestForDetailMinerListUserDataRequest](src/Binance/Requests/Mining/RequestForDetailMinerListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningWorkerDetailResponse](src/Binance/Models/SapiV1MiningWorkerDetailResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RequestForDetailMinerListUserDataError](src/Binance/Errors/RequestForDetailMinerListUserDataError.cs)&gt;</code>

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

<code>[RequestForMinerListUserDataRequest](src/Binance/Requests/Mining/RequestForMinerListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningWorkerListResponse](src/Binance/Models/SapiV1MiningWorkerListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RequestForMinerListUserDataError](src/Binance/Errors/RequestForMinerListUserDataError.cs)&gt;</code>

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

<code>[StatisticListUserDataRequest](src/Binance/Requests/Mining/StatisticListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1MiningStatisticsUserStatusResponse](src/Binance/Models/SapiV1MiningStatisticsUserStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[StatisticListUserDataError](src/Binance/Errors/StatisticListUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Nft

> Source: [Nft](src/Binance/Api/Nft.cs)

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

<code>[GetNftAssetUserDataRequest](src/Binance/Requests/Nft/GetNftAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftUserGetAssetResponse](src/Binance/Models/SapiV1NftUserGetAssetResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetNftAssetUserDataError](src/Binance/Errors/GetNftAssetUserDataError.cs)&gt;</code>

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

<code>[GetNftDepositHistoryUserDataRequest](src/Binance/Requests/Nft/GetNftDepositHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftHistoryDepositResponse](src/Binance/Models/SapiV1NftHistoryDepositResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetNftDepositHistoryUserDataError](src/Binance/Errors/GetNftDepositHistoryUserDataError.cs)&gt;</code>

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

<code>[GetNftTransactionHistoryUserDataRequest](src/Binance/Requests/Nft/GetNftTransactionHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftHistoryTransactionsResponse](src/Binance/Models/SapiV1NftHistoryTransactionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetNftTransactionHistoryUserDataError](src/Binance/Errors/GetNftTransactionHistoryUserDataError.cs)&gt;</code>

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

<code>[GetNftWithdrawHistoryUserDataRequest](src/Binance/Requests/Nft/GetNftWithdrawHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1NftHistoryWithdrawResponse](src/Binance/Models/SapiV1NftHistoryWithdrawResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetNftWithdrawHistoryUserDataError](src/Binance/Errors/GetNftWithdrawHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Pay

> Source: [Pay](src/Binance/Api/Pay.cs)

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

<code>[GetPayTradeHistoryUserDataRequest](src/Binance/Requests/Pay/GetPayTradeHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PayTransactionsResponse](src/Binance/Models/SapiV1PayTransactionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetPayTradeHistoryUserDataError](src/Binance/Errors/GetPayTradeHistoryUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PortfolioMargin

> Source: [PortfolioMargin](src/Binance/Api/PortfolioMargin.cs)

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

<code>[BnbTransferUserDataRequest](src/Binance/Requests/PortfolioMargin/BnbTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioBnbTransferResponse](src/Binance/Models/SapiV1PortfolioBnbTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[BnbTransferUserDataError](src/Binance/Errors/BnbTransferUserDataError.cs)&gt;</code>

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

<code>[ChangeAutoRepayFuturesStatusUserDataRequest](src/Binance/Requests/PortfolioMargin/ChangeAutoRepayFuturesStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayFuturesSwitchResponse](src/Binance/Models/SapiV1PortfolioRepayFuturesSwitchResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ChangeAutoRepayFuturesStatusUserDataError](src/Binance/Errors/ChangeAutoRepayFuturesStatusUserDataError.cs)&gt;</code>

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

<code>[FundAutoCollectionUserDataRequest](src/Binance/Requests/PortfolioMargin/FundAutoCollectionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioAutoCollectionResponse](src/Binance/Models/SapiV1PortfolioAutoCollectionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FundAutoCollectionUserDataError](src/Binance/Errors/FundAutoCollectionUserDataError.cs)&gt;</code>

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

<code>[FundCollectionByAssetUserDataRequest](src/Binance/Requests/PortfolioMargin/FundCollectionByAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioAssetCollectionResponse](src/Binance/Models/SapiV1PortfolioAssetCollectionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FundCollectionByAssetUserDataError](src/Binance/Errors/FundCollectionByAssetUserDataError.cs)&gt;</code>

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

<code>[GetAutoRepayFuturesStatusUserDataRequest](src/Binance/Requests/PortfolioMargin/GetAutoRepayFuturesStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayFuturesSwitchResponse1](src/Binance/Models/SapiV1PortfolioRepayFuturesSwitchResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetAutoRepayFuturesStatusUserDataError](src/Binance/Errors/GetAutoRepayFuturesStatusUserDataError.cs)&gt;</code>

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

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioMarginAssetLeverageResponse](src/Binance/Models/SapiV1PortfolioMarginAssetLeverageResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetPortfolioMarginAssetLeverageUserDataError](src/Binance/Errors/GetPortfolioMarginAssetLeverageUserDataError.cs)&gt;</code>

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

<code>[PortfolioMarginAccountUserDataRequest](src/Binance/Requests/PortfolioMargin/PortfolioMarginAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioAccountResponse](src/Binance/Models/SapiV1PortfolioAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginAccountUserDataError](src/Binance/Errors/PortfolioMarginAccountUserDataError.cs)&gt;</code>

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

<code>[PortfolioMarginBankruptcyLoanAmountUserDataRequest](src/Binance/Requests/PortfolioMargin/PortfolioMarginBankruptcyLoanAmountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioPmLoanResponse](src/Binance/Models/SapiV1PortfolioPmLoanResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginBankruptcyLoanAmountUserDataError](src/Binance/Errors/PortfolioMarginBankruptcyLoanAmountUserDataError.cs)&gt;</code>

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

<code>[PortfolioMarginBankruptcyLoanRepayUserDataRequest](src/Binance/Requests/PortfolioMargin/PortfolioMarginBankruptcyLoanRepayUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayResponse](src/Binance/Models/SapiV1PortfolioRepayResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginBankruptcyLoanRepayUserDataError](src/Binance/Errors/PortfolioMarginBankruptcyLoanRepayUserDataError.cs)&gt;</code>

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

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioCollateralRateResponse](src/Binance/Models/SapiV1PortfolioCollateralRateResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginCollateralRateMarketDataError](src/Binance/Errors/PortfolioMarginCollateralRateMarketDataError.cs)&gt;</code>

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

<code>[PortfolioMarginProTieredCollateralRateUserDataRequest](src/Binance/Requests/PortfolioMargin/PortfolioMarginProTieredCollateralRateUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV2PortfolioCollateralRateResponse](src/Binance/Models/SapiV2PortfolioCollateralRateResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PortfolioMarginProTieredCollateralRateUserDataError](src/Binance/Errors/PortfolioMarginProTieredCollateralRateUserDataError.cs)&gt;</code>

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

<code>[QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest](src/Binance/Requests/PortfolioMargin/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioInterestHistoryResponse](src/Binance/Models/SapiV1PortfolioInterestHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError](src/Binance/Errors/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError.cs)&gt;</code>

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

<code>[QueryPortfolioMarginAssetIndexPriceMarketDataRequest](src/Binance/Requests/PortfolioMargin/QueryPortfolioMarginAssetIndexPriceMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1PortfolioAssetIndexPriceResponse](src/Binance/Models/SapiV1PortfolioAssetIndexPriceResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryPortfolioMarginAssetIndexPriceMarketDataError](src/Binance/Errors/QueryPortfolioMarginAssetIndexPriceMarketDataError.cs)&gt;</code>

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

<code>[RepayFuturesNegativeBalanceUserDataRequest](src/Binance/Requests/PortfolioMargin/RepayFuturesNegativeBalanceUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1PortfolioRepayFuturesNegativeBalanceResponse](src/Binance/Models/SapiV1PortfolioRepayFuturesNegativeBalanceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RepayFuturesNegativeBalanceUserDataError](src/Binance/Errors/RepayFuturesNegativeBalanceUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Rebate

> Source: [Rebate](src/Binance/Api/Rebate.cs)

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

<code>[GetSpotRebateHistoryRecordsUserDataRequest](src/Binance/Requests/Rebate/GetSpotRebateHistoryRecordsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1RebateTaxQueryResponse](src/Binance/Models/SapiV1RebateTaxQueryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetSpotRebateHistoryRecordsUserDataError](src/Binance/Errors/GetSpotRebateHistoryRecordsUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Savings

> Source: [Savings](src/Binance/Api/Savings.cs)

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

<code>[ChangeFixedActivityPositionToDailyPositionUserDataRequest](src/Binance/Requests/Savings/ChangeFixedActivityPositionToDailyPositionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingPositionChangedResponse](src/Binance/Models/SapiV1LendingPositionChangedResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ChangeFixedActivityPositionToDailyPositionUserDataError](src/Binance/Errors/ChangeFixedActivityPositionToDailyPositionUserDataError.cs)&gt;</code>

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

<code>[GetFixedActivityProjectListUserDataRequest](src/Binance/Requests/Savings/GetFixedActivityProjectListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingProjectListResponse](src/Binance/Models/SapiV1LendingProjectListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFixedActivityProjectListUserDataError](src/Binance/Errors/GetFixedActivityProjectListUserDataError.cs)&gt;</code>

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

<code>[GetFixedActivityProjectPositionUserDataRequest](src/Binance/Requests/Savings/GetFixedActivityProjectPositionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LendingProjectPositionListResponse](src/Binance/Models/SapiV1LendingProjectPositionListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFixedActivityProjectPositionUserDataError](src/Binance/Errors/GetFixedActivityProjectPositionUserDataError.cs)&gt;</code>

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

<code>[PurchaseFixedActivityProjectUserDataRequest](src/Binance/Requests/Savings/PurchaseFixedActivityProjectUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LendingCustomizedFixedPurchaseResponse](src/Binance/Models/SapiV1LendingCustomizedFixedPurchaseResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PurchaseFixedActivityProjectUserDataError](src/Binance/Errors/PurchaseFixedActivityProjectUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SimpleEarn

> Source: [SimpleEarn](src/Binance/Api/SimpleEarn.cs)

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

<code>[GetCollateralRecordUserDataRequest](src/Binance/Requests/SimpleEarn/GetCollateralRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetCollateralRecordUserDataError](src/Binance/Errors/GetCollateralRecordUserDataError.cs)&gt;</code>

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

<code>[GetFlexiblePersonalLeftQuotaUserDataRequest](src/Binance/Requests/SimpleEarn/GetFlexiblePersonalLeftQuotaUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse](src/Binance/Models/SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFlexiblePersonalLeftQuotaUserDataError](src/Binance/Errors/GetFlexiblePersonalLeftQuotaUserDataError.cs)&gt;</code>

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

<code>[GetFlexibleProductPositionUserDataRequest](src/Binance/Requests/SimpleEarn/GetFlexibleProductPositionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexiblePositionResponse](src/Binance/Models/SapiV1SimpleEarnFlexiblePositionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFlexibleProductPositionUserDataError](src/Binance/Errors/GetFlexibleProductPositionUserDataError.cs)&gt;</code>

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

<code>[GetFlexibleRedemptionRecordUserDataRequest](src/Binance/Requests/SimpleEarn/GetFlexibleRedemptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFlexibleRedemptionRecordUserDataError](src/Binance/Errors/GetFlexibleRedemptionRecordUserDataError.cs)&gt;</code>

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

<code>[GetFlexibleRewardsHistoryUserDataRequest](src/Binance/Requests/SimpleEarn/GetFlexibleRewardsHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFlexibleRewardsHistoryUserDataError](src/Binance/Errors/GetFlexibleRewardsHistoryUserDataError.cs)&gt;</code>

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

<code>[GetFlexibleSubscriptionPreviewUserDataRequest](src/Binance/Requests/SimpleEarn/GetFlexibleSubscriptionPreviewUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFlexibleSubscriptionPreviewUserDataError](src/Binance/Errors/GetFlexibleSubscriptionPreviewUserDataError.cs)&gt;</code>

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

<code>[GetFlexibleSubscriptionRecordUserDataRequest](src/Binance/Requests/SimpleEarn/GetFlexibleSubscriptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetFlexibleSubscriptionRecordUserDataError](src/Binance/Errors/GetFlexibleSubscriptionRecordUserDataError.cs)&gt;</code>

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

<code>[GetLockedPersonalLeftQuotaUserDataRequest](src/Binance/Requests/SimpleEarn/GetLockedPersonalLeftQuotaUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedPersonalLeftQuotaResponse](src/Binance/Models/SapiV1SimpleEarnLockedPersonalLeftQuotaResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLockedPersonalLeftQuotaUserDataError](src/Binance/Errors/GetLockedPersonalLeftQuotaUserDataError.cs)&gt;</code>

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

<code>[GetLockedProductPositionUserDataRequest](src/Binance/Requests/SimpleEarn/GetLockedProductPositionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedPositionResponse](src/Binance/Models/SapiV1SimpleEarnLockedPositionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLockedProductPositionUserDataError](src/Binance/Errors/GetLockedProductPositionUserDataError.cs)&gt;</code>

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

<code>[GetLockedRedemptionRecordUserDataRequest](src/Binance/Requests/SimpleEarn/GetLockedRedemptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse](src/Binance/Models/SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLockedRedemptionRecordUserDataError](src/Binance/Errors/GetLockedRedemptionRecordUserDataError.cs)&gt;</code>

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

<code>[GetLockedRewardsHistoryUserDataRequest](src/Binance/Requests/SimpleEarn/GetLockedRewardsHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedHistoryRewardsRecordResponse](src/Binance/Models/SapiV1SimpleEarnLockedHistoryRewardsRecordResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLockedRewardsHistoryUserDataError](src/Binance/Errors/GetLockedRewardsHistoryUserDataError.cs)&gt;</code>

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

<code>[GetLockedSubscriptionPreviewUserDataRequest](src/Binance/Requests/SimpleEarn/GetLockedSubscriptionPreviewUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SimpleEarnLockedSubscriptionPreviewResponse](src/Binance/Models/SapiV1SimpleEarnLockedSubscriptionPreviewResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLockedSubscriptionPreviewUserDataError](src/Binance/Errors/GetLockedSubscriptionPreviewUserDataError.cs)&gt;</code>

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

<code>[GetLockedSubscriptionRecordUserDataRequest](src/Binance/Requests/SimpleEarn/GetLockedSubscriptionRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse](src/Binance/Models/SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLockedSubscriptionRecordUserDataError](src/Binance/Errors/GetLockedSubscriptionRecordUserDataError.cs)&gt;</code>

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

<code>[GetRateHistoryUserDataRequest](src/Binance/Requests/SimpleEarn/GetRateHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetRateHistoryUserDataError](src/Binance/Errors/GetRateHistoryUserDataError.cs)&gt;</code>

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

<code>[GetSimpleEarnFlexibleProductListUserDataRequest](src/Binance/Requests/SimpleEarn/GetSimpleEarnFlexibleProductListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleListResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetSimpleEarnFlexibleProductListUserDataError](src/Binance/Errors/GetSimpleEarnFlexibleProductListUserDataError.cs)&gt;</code>

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

<code>[GetSimpleEarnLockedProductListUserDataRequest](src/Binance/Requests/SimpleEarn/GetSimpleEarnLockedProductListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedListResponse](src/Binance/Models/SapiV1SimpleEarnLockedListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetSimpleEarnLockedProductListUserDataError](src/Binance/Errors/GetSimpleEarnLockedProductListUserDataError.cs)&gt;</code>

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

<code>[RedeemFlexibleProductTradeRequest](src/Binance/Requests/SimpleEarn/RedeemFlexibleProductTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleRedeemResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RedeemFlexibleProductTradeError](src/Binance/Errors/RedeemFlexibleProductTradeError.cs)&gt;</code>

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

<code>[RedeemLockedProductTradeRequest](src/Binance/Requests/SimpleEarn/RedeemLockedProductTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedRedeemResponse](src/Binance/Models/SapiV1SimpleEarnLockedRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RedeemLockedProductTradeError](src/Binance/Errors/RedeemLockedProductTradeError.cs)&gt;</code>

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

<code>[SetFlexibleAutoSubscribeUserDataRequest](src/Binance/Requests/SimpleEarn/SetFlexibleAutoSubscribeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SetFlexibleAutoSubscribeUserDataError](src/Binance/Errors/SetFlexibleAutoSubscribeUserDataError.cs)&gt;</code>

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

<code>[SetLockedAutoSubscribeUserDataRequest](src/Binance/Requests/SimpleEarn/SetLockedAutoSubscribeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedSetAutoSubscribeResponse](src/Binance/Models/SapiV1SimpleEarnLockedSetAutoSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SetLockedAutoSubscribeUserDataError](src/Binance/Errors/SetLockedAutoSubscribeUserDataError.cs)&gt;</code>

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

<code>[SetLockedProductRedeemOptionUserDataRequest](src/Binance/Requests/SimpleEarn/SetLockedProductRedeemOptionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedSetRedeemOptionResponse](src/Binance/Models/SapiV1SimpleEarnLockedSetRedeemOptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SetLockedProductRedeemOptionUserDataError](src/Binance/Errors/SetLockedProductRedeemOptionUserDataError.cs)&gt;</code>

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

<code>[SimpleAccountUserDataRequest](src/Binance/Requests/SimpleEarn/SimpleAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnAccountResponse](src/Binance/Models/SapiV1SimpleEarnAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SimpleAccountUserDataError](src/Binance/Errors/SimpleAccountUserDataError.cs)&gt;</code>

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

<code>[SubscribeFlexibleProductTradeRequest](src/Binance/Requests/SimpleEarn/SubscribeFlexibleProductTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnFlexibleSubscribeResponse](src/Binance/Models/SapiV1SimpleEarnFlexibleSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubscribeFlexibleProductTradeError](src/Binance/Errors/SubscribeFlexibleProductTradeError.cs)&gt;</code>

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

<code>[SubscribeLockedProductTradeRequest](src/Binance/Requests/SimpleEarn/SubscribeLockedProductTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SimpleEarnLockedSubscribeResponse](src/Binance/Models/SapiV1SimpleEarnLockedSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubscribeLockedProductTradeError](src/Binance/Errors/SubscribeLockedProductTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SpotAlgo

> Source: [SpotAlgo](src/Binance/Api/SpotAlgo.cs)

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

<code>[CancelAlgoOrderRequest](src/Binance/Requests/SpotAlgo/CancelAlgoOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotOrderResponse](src/Binance/Models/SapiV1AlgoSpotOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CancelAlgoOrderError](src/Binance/Errors/CancelAlgoOrderError.cs)&gt;</code>

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

<code>[QueryCurrentAlgoOpenOrdersRequest](src/Binance/Requests/SpotAlgo/QueryCurrentAlgoOpenOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotOpenOrdersResponse](src/Binance/Models/SapiV1AlgoSpotOpenOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryCurrentAlgoOpenOrdersError](src/Binance/Errors/QueryCurrentAlgoOpenOrdersError.cs)&gt;</code>

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

<code>[QueryHistoricalAlgoOrdersRequest](src/Binance/Requests/SpotAlgo/QueryHistoricalAlgoOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotHistoricalOrdersResponse](src/Binance/Models/SapiV1AlgoSpotHistoricalOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryHistoricalAlgoOrdersError](src/Binance/Errors/QueryHistoricalAlgoOrdersError.cs)&gt;</code>

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

<code>[QuerySubOrdersRequest](src/Binance/Requests/SpotAlgo/QuerySubOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotSubOrdersResponse](src/Binance/Models/SapiV1AlgoSpotSubOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QuerySubOrdersError](src/Binance/Errors/QuerySubOrdersError.cs)&gt;</code>

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

<code>[TimeWeightedAveragePriceTwapNewOrderRequest](src/Binance/Requests/SpotAlgo/TimeWeightedAveragePriceTwapNewOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AlgoSpotNewOrderTwapResponse](src/Binance/Models/SapiV1AlgoSpotNewOrderTwapResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[TimeWeightedAveragePriceTwapNewOrderError](src/Binance/Errors/TimeWeightedAveragePriceTwapNewOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Staking

> Source: [Staking](src/Binance/Api/Staking.cs)

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

<code>[EthStakingAccountV2UserDataRequest](src/Binance/Requests/Staking/EthStakingAccountV2UserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2EthStakingAccountResponse](src/Binance/Models/SapiV2EthStakingAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[EthStakingAccountV2UserDataError](src/Binance/Errors/EthStakingAccountV2UserDataError.cs)&gt;</code>

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

<code>[GetBethRewardsDistributionHistoryUserDataRequest](src/Binance/Requests/Staking/GetBethRewardsDistributionHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryRewardsHistoryResponse](src/Binance/Models/SapiV1EthStakingEthHistoryRewardsHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetBethRewardsDistributionHistoryUserDataError](src/Binance/Errors/GetBethRewardsDistributionHistoryUserDataError.cs)&gt;</code>

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

<code>[GetEthRedemptionHistoryUserDataRequest](src/Binance/Requests/Staking/GetEthRedemptionHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryRedemptionHistoryResponse](src/Binance/Models/SapiV1EthStakingEthHistoryRedemptionHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetEthRedemptionHistoryUserDataError](src/Binance/Errors/GetEthRedemptionHistoryUserDataError.cs)&gt;</code>

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

<code>[GetEthStakingHistoryUserDataRequest](src/Binance/Requests/Staking/GetEthStakingHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryStakingHistoryResponse](src/Binance/Models/SapiV1EthStakingEthHistoryStakingHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetEthStakingHistoryUserDataError](src/Binance/Errors/GetEthStakingHistoryUserDataError.cs)&gt;</code>

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

<code>[GetWbethRateHistoryUserDataRequest](src/Binance/Requests/Staking/GetWbethRateHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryRateHistoryResponse](src/Binance/Models/SapiV1EthStakingEthHistoryRateHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetWbethRateHistoryUserDataError](src/Binance/Errors/GetWbethRateHistoryUserDataError.cs)&gt;</code>

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

<code>[GetWbethRewardsHistoryUserDataRequest](src/Binance/Requests/Staking/GetWbethRewardsHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse](src/Binance/Models/SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetWbethRewardsHistoryUserDataError](src/Binance/Errors/GetWbethRewardsHistoryUserDataError.cs)&gt;</code>

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

<code>[GetWbethUnwrapHistoryUserDataRequest](src/Binance/Requests/Staking/GetWbethUnwrapHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingWbethHistoryUnwrapHistoryResponse](src/Binance/Models/SapiV1EthStakingWbethHistoryUnwrapHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetWbethUnwrapHistoryUserDataError](src/Binance/Errors/GetWbethUnwrapHistoryUserDataError.cs)&gt;</code>

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

<code>[GetWbethWrapHistoryUserDataRequest](src/Binance/Requests/Staking/GetWbethWrapHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingWbethHistoryWrapHistoryResponse](src/Binance/Models/SapiV1EthStakingWbethHistoryWrapHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetWbethWrapHistoryUserDataError](src/Binance/Errors/GetWbethWrapHistoryUserDataError.cs)&gt;</code>

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

<code>[GetCurrentEthStakingQuotaUserDataRequest](src/Binance/Requests/Staking/GetCurrentEthStakingQuotaUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthQuotaResponse](src/Binance/Models/SapiV1EthStakingEthQuotaResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetCurrentEthStakingQuotaUserDataError](src/Binance/Errors/GetCurrentEthStakingQuotaUserDataError.cs)&gt;</code>

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

<code>[RedeemEthTradeRequest](src/Binance/Requests/Staking/RedeemEthTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingEthRedeemResponse](src/Binance/Models/SapiV1EthStakingEthRedeemResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RedeemEthTradeError](src/Binance/Errors/RedeemEthTradeError.cs)&gt;</code>

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

<code>[SubscribeEthStakingV2TradeRequest](src/Binance/Requests/Staking/SubscribeEthStakingV2TradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2EthStakingEthStakeResponse](src/Binance/Models/SapiV2EthStakingEthStakeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubscribeEthStakingV2TradeError](src/Binance/Errors/SubscribeEthStakingV2TradeError.cs)&gt;</code>

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

<code>[WrapBethTradeRequest](src/Binance/Requests/Staking/WrapBethTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1EthStakingWbethWrapResponse](src/Binance/Models/SapiV1EthStakingWbethWrapResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[WrapBethTradeError](src/Binance/Errors/WrapBethTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Stream

> Source: [Stream](src/Binance/Api/Stream.cs)

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

<code>[CloseAListenKeyUserStreamRequest](src/Binance/Requests/Stream/CloseAListenKeyUserStreamRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CloseAListenKeyUserStreamError](src/Binance/Errors/CloseAListenKeyUserStreamError.cs)&gt;</code>

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

**OnSuccess**: <code>[ApiV3UserDataStreamResponse](src/Binance/Models/ApiV3UserDataStreamResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Binance/Core/ErrorResponse/RawError.cs)&gt;</code>

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

<code>[PingKeepAliveAListenKeyUserStreamRequest](src/Binance/Requests/Stream/PingKeepAliveAListenKeyUserStreamRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[PingKeepAliveAListenKeyUserStreamError](src/Binance/Errors/PingKeepAliveAListenKeyUserStreamError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SubAccountApi

> Source: [SubAccountApi](src/Binance/Api/SubAccountApi.cs)

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

<code>[CreateAVirtualSubAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/CreateAVirtualSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountVirtualSubAccountResponse](src/Binance/Models/SapiV1SubAccountVirtualSubAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CreateAVirtualSubAccountForMasterAccountError](src/Binance/Errors/CreateAVirtualSubAccountForMasterAccountError.cs)&gt;</code>

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

<code>[DeleteIpListForASubAccountApiKeyForMasterAccountRequest](src/Binance/Requests/SubAccountApi/DeleteIpListForASubAccountApiKeyForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse](src/Binance/Models/SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DeleteIpListForASubAccountApiKeyForMasterAccountError](src/Binance/Errors/DeleteIpListForASubAccountApiKeyForMasterAccountError.cs)&gt;</code>

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

<code>[DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest](src/Binance/Requests/SubAccountApi/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountDepositResponse](src/Binance/Models/SapiV1ManagedSubaccountDepositResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError](src/Binance/Errors/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError.cs)&gt;</code>

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

<code>[DetailOnSubAccountSFuturesAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/DetailOnSubAccountSFuturesAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesAccountResponse](src/Binance/Models/SapiV1SubAccountFuturesAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DetailOnSubAccountSFuturesAccountForMasterAccountError](src/Binance/Errors/DetailOnSubAccountSFuturesAccountForMasterAccountError.cs)&gt;</code>

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

<code>[DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest](src/Binance/Requests/SubAccountApi/DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountFuturesAccountResponse](src/Binance/Models/AnyOf/SapiV2SubAccountFuturesAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DetailOnSubAccountSFuturesAccountV2ForMasterAccountError](src/Binance/Errors/DetailOnSubAccountSFuturesAccountV2ForMasterAccountError.cs)&gt;</code>

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

<code>[DetailOnSubAccountSMarginAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/DetailOnSubAccountSMarginAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginAccountResponse](src/Binance/Models/SapiV1SubAccountMarginAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DetailOnSubAccountSMarginAccountForMasterAccountError](src/Binance/Errors/DetailOnSubAccountSMarginAccountForMasterAccountError.cs)&gt;</code>

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

<code>[EnableFuturesForSubAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/EnableFuturesForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesEnableResponse](src/Binance/Models/SapiV1SubAccountFuturesEnableResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[EnableFuturesForSubAccountForMasterAccountError](src/Binance/Errors/EnableFuturesForSubAccountForMasterAccountError.cs)&gt;</code>

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

<code>[EnableLeverageTokenForSubAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/EnableLeverageTokenForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountBlvtEnableResponse](src/Binance/Models/SapiV1SubAccountBlvtEnableResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[EnableLeverageTokenForSubAccountForMasterAccountError](src/Binance/Errors/EnableLeverageTokenForSubAccountForMasterAccountError.cs)&gt;</code>

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

<code>[EnableMarginForSubAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/EnableMarginForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginEnableResponse](src/Binance/Models/SapiV1SubAccountMarginEnableResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[EnableMarginForSubAccountForMasterAccountError](src/Binance/Errors/EnableMarginForSubAccountForMasterAccountError.cs)&gt;</code>

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

<code>[EnableOptionsForSubAccountForMasterAccountUserDataRequest](src/Binance/Requests/SubAccountApi/EnableOptionsForSubAccountForMasterAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountEoptionsEnableResponse](src/Binance/Models/SapiV1SubAccountEoptionsEnableResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[EnableOptionsForSubAccountForMasterAccountUserDataError](src/Binance/Errors/EnableOptionsForSubAccountForMasterAccountUserDataError.cs)&gt;</code>

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

<code>[FuturesPositionRiskOfSubAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/FuturesPositionRiskOfSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountFuturesPositionRiskResponse](src/Binance/Models/SapiV1SubAccountFuturesPositionRiskResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FuturesPositionRiskOfSubAccountForMasterAccountError](src/Binance/Errors/FuturesPositionRiskOfSubAccountForMasterAccountError.cs)&gt;</code>

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

<code>[FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest](src/Binance/Requests/SubAccountApi/FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountFuturesPositionRiskResponse](src/Binance/Models/AnyOf/SapiV2SubAccountFuturesPositionRiskResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FuturesPositionRiskOfSubAccountV2ForMasterAccountError](src/Binance/Errors/FuturesPositionRiskOfSubAccountV2ForMasterAccountError.cs)&gt;</code>

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

<code>[GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest](src/Binance/Requests/SubAccountApi/GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountSubAccountApiIpRestrictionResponse](src/Binance/Models/SapiV1SubAccountSubAccountApiIpRestrictionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetIpRestrictionForASubAccountApiKeyForMasterAccountError](src/Binance/Errors/GetIpRestrictionForASubAccountApiKeyForMasterAccountError.cs)&gt;</code>

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

<code>[GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest](src/Binance/Requests/SubAccountApi/GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountDepositAddressResponse](src/Binance/Models/SapiV1ManagedSubaccountDepositAddressResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetManagedSubAccountDepositAddressForInvestorMasterAccountError](src/Binance/Errors/GetManagedSubAccountDepositAddressForInvestorMasterAccountError.cs)&gt;</code>

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

<code>[ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest](src/Binance/Requests/SubAccountApi/ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1ManagedSubaccountAssetResponse](src/Binance/Models/SapiV1ManagedSubaccountAssetResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ManagedSubAccountAssetDetailsForInvestorMasterAccountError](src/Binance/Errors/ManagedSubAccountAssetDetailsForInvestorMasterAccountError.cs)&gt;</code>

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

<code>[ManagedSubAccountSnapshotForInvestorMasterAccountRequest](src/Binance/Requests/SubAccountApi/ManagedSubAccountSnapshotForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountAccountSnapshotResponse](src/Binance/Models/SapiV1ManagedSubaccountAccountSnapshotResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ManagedSubAccountSnapshotForInvestorMasterAccountError](src/Binance/Errors/ManagedSubAccountSnapshotForInvestorMasterAccountError.cs)&gt;</code>

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

<code>[MarginTransferForSubAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/MarginTransferForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginTransferResponse](src/Binance/Models/SapiV1SubAccountMarginTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[MarginTransferForSubAccountForMasterAccountError](src/Binance/Errors/MarginTransferForSubAccountForMasterAccountError.cs)&gt;</code>

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

<code>[QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest](src/Binance/Requests/SubAccountApi/QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountQueryTransLogForInvestorResponse](src/Binance/Models/SapiV1ManagedSubaccountQueryTransLogForInvestorResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountTransferLogForInvestorMasterAccountError](src/Binance/Errors/QueryManagedSubAccountTransferLogForInvestorMasterAccountError.cs)&gt;</code>

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

<code>[QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest](src/Binance/Requests/SubAccountApi/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse](src/Binance/Models/SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError](src/Binance/Errors/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError.cs)&gt;</code>

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

<code>[QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest](src/Binance/Requests/SubAccountApi/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountQueryTransLogResponse](src/Binance/Models/SapiV1ManagedSubaccountQueryTransLogResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError](src/Binance/Errors/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError.cs)&gt;</code>

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

<code>[QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest](src/Binance/Requests/SubAccountApi/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountFetchFutureAssetResponse](src/Binance/Models/SapiV1ManagedSubaccountFetchFutureAssetResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError](src/Binance/Errors/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError.cs)&gt;</code>

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

<code>[QueryManagedSubAccountListForInvestorRequest](src/Binance/Requests/SubAccountApi/QueryManagedSubAccountListForInvestorRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountInfoResponse](src/Binance/Models/SapiV1ManagedSubaccountInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountListForInvestorError](src/Binance/Errors/QueryManagedSubAccountListForInvestorError.cs)&gt;</code>

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

<code>[QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest](src/Binance/Requests/SubAccountApi/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountMarginAssetResponse](src/Binance/Models/SapiV1ManagedSubaccountMarginAssetResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError](src/Binance/Errors/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError.cs)&gt;</code>

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

<code>[QuerySubAccountAssetsForMasterAccountRequest](src/Binance/Requests/SubAccountApi/QuerySubAccountAssetsForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV4SubAccountAssetsResponse](src/Binance/Models/SapiV4SubAccountAssetsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QuerySubAccountAssetsForMasterAccountError](src/Binance/Errors/QuerySubAccountAssetsForMasterAccountError.cs)&gt;</code>

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

<code>[QuerySubAccountListForMasterAccountRequest](src/Binance/Requests/SubAccountApi/QuerySubAccountListForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountListResponse](src/Binance/Models/SapiV1SubAccountListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QuerySubAccountListForMasterAccountError](src/Binance/Errors/QuerySubAccountListForMasterAccountError.cs)&gt;</code>

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

<code>[QuerySubAccountTransactionStatisticsForMasterAccountRequest](src/Binance/Requests/SubAccountApi/QuerySubAccountTransactionStatisticsForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountTransactionStatisticsResponse](src/Binance/Models/SapiV1SubAccountTransactionStatisticsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QuerySubAccountTransactionStatisticsForMasterAccountError](src/Binance/Errors/QuerySubAccountTransactionStatisticsForMasterAccountError.cs)&gt;</code>

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

<code>[SubAccountAssetsForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SubAccountAssetsForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV3SubAccountAssetsResponse](src/Binance/Models/SapiV3SubAccountAssetsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubAccountAssetsForMasterAccountError](src/Binance/Errors/SubAccountAssetsForMasterAccountError.cs)&gt;</code>

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

<code>[SubAccountDepositHistoryForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SubAccountDepositHistoryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalDepositSubHisrecResponse](src/Binance/Models/SapiV1CapitalDepositSubHisrecResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubAccountDepositHistoryForMasterAccountError](src/Binance/Errors/SubAccountDepositHistoryForMasterAccountError.cs)&gt;</code>

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

<code>[SubAccountFuturesAssetTransferForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SubAccountFuturesAssetTransferForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesInternalTransferResponse1](src/Binance/Models/SapiV1SubAccountFuturesInternalTransferResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubAccountFuturesAssetTransferForMasterAccountError](src/Binance/Errors/SubAccountFuturesAssetTransferForMasterAccountError.cs)&gt;</code>

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

<code>[SubAccountFuturesAssetTransferHistoryForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SubAccountFuturesAssetTransferHistoryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesInternalTransferResponse](src/Binance/Models/SapiV1SubAccountFuturesInternalTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubAccountFuturesAssetTransferHistoryForMasterAccountError](src/Binance/Errors/SubAccountFuturesAssetTransferHistoryForMasterAccountError.cs)&gt;</code>

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

<code>[SubAccountSpotAssetTransferHistoryForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SubAccountSpotAssetTransferHistoryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountSubTransferHistoryResponse](src/Binance/Models/SapiV1SubAccountSubTransferHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubAccountSpotAssetTransferHistoryForMasterAccountError](src/Binance/Errors/SubAccountSpotAssetTransferHistoryForMasterAccountError.cs)&gt;</code>

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

<code>[SubAccountSpotAssetsSummaryForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SubAccountSpotAssetsSummaryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountSpotSummaryResponse](src/Binance/Models/SapiV1SubAccountSpotSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubAccountSpotAssetsSummaryForMasterAccountError](src/Binance/Errors/SubAccountSpotAssetsSummaryForMasterAccountError.cs)&gt;</code>

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

<code>[SubAccountSpotAssetsSummaryForMasterAccount2Request](src/Binance/Requests/SubAccountApi/SubAccountSpotAssetsSummaryForMasterAccount2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalDepositSubAddressResponse](src/Binance/Models/SapiV1CapitalDepositSubAddressResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubAccountSpotAssetsSummaryForMasterAccount2Error](src/Binance/Errors/SubAccountSpotAssetsSummaryForMasterAccount2Error.cs)&gt;</code>

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

<code>[SubAccountTransferHistoryForSubAccountRequest](src/Binance/Requests/SubAccountApi/SubAccountTransferHistoryForSubAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountTransferSubUserHistoryResponse](src/Binance/Models/SapiV1SubAccountTransferSubUserHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubAccountTransferHistoryForSubAccountError](src/Binance/Errors/SubAccountTransferHistoryForSubAccountError.cs)&gt;</code>

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

<code>[SubAccountSStatusOnMarginFuturesForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SubAccountSStatusOnMarginFuturesForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountStatusResponse](src/Binance/Models/SapiV1SubAccountStatusResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SubAccountSStatusOnMarginFuturesForMasterAccountError](src/Binance/Errors/SubAccountSStatusOnMarginFuturesForMasterAccountError.cs)&gt;</code>

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

<code>[SummaryOfSubAccountSFuturesAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SummaryOfSubAccountSFuturesAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesAccountSummaryResponse](src/Binance/Models/SapiV1SubAccountFuturesAccountSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SummaryOfSubAccountSFuturesAccountForMasterAccountError](src/Binance/Errors/SummaryOfSubAccountSFuturesAccountForMasterAccountError.cs)&gt;</code>

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

<code>[SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountFuturesAccountSummaryResponse](src/Binance/Models/AnyOf/SapiV2SubAccountFuturesAccountSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError](src/Binance/Errors/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError.cs)&gt;</code>

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

<code>[SummaryOfSubAccountSMarginAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/SummaryOfSubAccountSMarginAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountMarginAccountSummaryResponse](src/Binance/Models/SapiV1SubAccountMarginAccountSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SummaryOfSubAccountSMarginAccountForMasterAccountError](src/Binance/Errors/SummaryOfSubAccountSMarginAccountForMasterAccountError.cs)&gt;</code>

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

<code>[TransferForSubAccountForMasterAccountRequest](src/Binance/Requests/SubAccountApi/TransferForSubAccountForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountFuturesTransferResponse](src/Binance/Models/SapiV1SubAccountFuturesTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[TransferForSubAccountForMasterAccountError](src/Binance/Errors/TransferForSubAccountForMasterAccountError.cs)&gt;</code>

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

<code>[TransferToMasterForSubAccountRequest](src/Binance/Requests/SubAccountApi/TransferToMasterForSubAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountTransferSubToMasterResponse](src/Binance/Models/SapiV1SubAccountTransferSubToMasterResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[TransferToMasterForSubAccountError](src/Binance/Errors/TransferToMasterForSubAccountError.cs)&gt;</code>

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

<code>[TransferToSubAccountOfSameMasterForSubAccountRequest](src/Binance/Requests/SubAccountApi/TransferToSubAccountOfSameMasterForSubAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountTransferSubToSubResponse](src/Binance/Models/SapiV1SubAccountTransferSubToSubResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[TransferToSubAccountOfSameMasterForSubAccountError](src/Binance/Errors/TransferToSubAccountOfSameMasterForSubAccountError.cs)&gt;</code>

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

<code>[UniversalTransferForMasterAccountRequest](src/Binance/Requests/SubAccountApi/UniversalTransferForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1SubAccountUniversalTransferResponse1](src/Binance/Models/SapiV1SubAccountUniversalTransferResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[UniversalTransferForMasterAccountError](src/Binance/Errors/UniversalTransferForMasterAccountError.cs)&gt;</code>

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

<code>[UniversalTransferHistoryForMasterAccountRequest](src/Binance/Requests/SubAccountApi/UniversalTransferHistoryForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SubAccountUniversalTransferResponse](src/Binance/Models/SapiV1SubAccountUniversalTransferResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[UniversalTransferHistoryForMasterAccountError](src/Binance/Errors/UniversalTransferHistoryForMasterAccountError.cs)&gt;</code>

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

<code>[UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest](src/Binance/Requests/SubAccountApi/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV2SubAccountSubAccountApiIpRestrictionResponse](src/Binance/Models/SapiV2SubAccountSubAccountApiIpRestrictionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError](src/Binance/Errors/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError.cs)&gt;</code>

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

<code>[WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest](src/Binance/Requests/SubAccountApi/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1ManagedSubaccountWithdrawResponse](src/Binance/Models/SapiV1ManagedSubaccountWithdrawResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError](src/Binance/Errors/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TradeApi

> Source: [TradeApi](src/Binance/Api/TradeApi.cs)

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

<code>[AccountInformationUserDataRequest](src/Binance/Requests/TradeApi/AccountInformationUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Account](src/Binance/Models/Account.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AccountInformationUserDataError](src/Binance/Errors/AccountInformationUserDataError.cs)&gt;</code>

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

<code>[AccountTradeListUserDataRequest](src/Binance/Requests/TradeApi/AccountTradeListUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[MyTrade](src/Binance/Models/MyTrade.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AccountTradeListUserDataError](src/Binance/Errors/AccountTradeListUserDataError.cs)&gt;</code>

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

<code>[AllOrdersUserDataRequest](src/Binance/Requests/TradeApi/AllOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[OrderDetails](src/Binance/Models/OrderDetails.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AllOrdersUserDataError](src/Binance/Errors/AllOrdersUserDataError.cs)&gt;</code>

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

<code>[CancelOcoTradeRequest](src/Binance/Requests/TradeApi/CancelOcoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OcoOrder](src/Binance/Models/OcoOrder.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CancelOcoTradeError](src/Binance/Errors/CancelOcoTradeError.cs)&gt;</code>

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

<code>[CancelOrderTradeRequest](src/Binance/Requests/TradeApi/CancelOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](src/Binance/Models/Order.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CancelOrderTradeError](src/Binance/Errors/CancelOrderTradeError.cs)&gt;</code>

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

<code>[CancelAllOpenOrdersOnASymbolTradeRequest](src/Binance/Requests/TradeApi/CancelAllOpenOrdersOnASymbolTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3OpenOrdersResponse](src/Binance/Models/AnyOf/ApiV3OpenOrdersResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CancelAllOpenOrdersOnASymbolTradeError](src/Binance/Errors/CancelAllOpenOrdersOnASymbolTradeError.cs)&gt;</code>

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

<code>[CancelAnExistingOrderAndSendANewOrderTradeRequest](src/Binance/Requests/TradeApi/CancelAnExistingOrderAndSendANewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderCancelReplaceResponse](src/Binance/Models/ApiV3OrderCancelReplaceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CancelAnExistingOrderAndSendANewOrderTradeError](src/Binance/Errors/CancelAnExistingOrderAndSendANewOrderTradeError.cs)&gt;</code>

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

<code>[CurrentOpenOrdersUserDataRequest](src/Binance/Requests/TradeApi/CurrentOpenOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[OrderDetails](src/Binance/Models/OrderDetails.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CurrentOpenOrdersUserDataError](src/Binance/Errors/CurrentOpenOrdersUserDataError.cs)&gt;</code>

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

<code>[NewOrderTradeRequest](src/Binance/Requests/TradeApi/NewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderResponse](src/Binance/Models/AnyOf/ApiV3OrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[NewOrderTradeError](src/Binance/Errors/NewOrderTradeError.cs)&gt;</code>

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

<code>[NewOrderListOtoTradeRequest](src/Binance/Requests/TradeApi/NewOrderListOtoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListOtoResponse](src/Binance/Models/ApiV3OrderListOtoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[NewOrderListOtoTradeError](src/Binance/Errors/NewOrderListOtoTradeError.cs)&gt;</code>

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

<code>[NewOrderListOtocoTradeRequest](src/Binance/Requests/TradeApi/NewOrderListOtocoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListOtocoResponse](src/Binance/Models/ApiV3OrderListOtocoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[NewOrderListOtocoTradeError](src/Binance/Errors/NewOrderListOtocoTradeError.cs)&gt;</code>

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

<code>[NewOrderListOcoTradeRequest](src/Binance/Requests/TradeApi/NewOrderListOcoTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListOcoResponse](src/Binance/Models/ApiV3OrderListOcoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[NewOrderListOcoTradeError](src/Binance/Errors/NewOrderListOcoTradeError.cs)&gt;</code>

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

<code>[NewOrderUsingSorTradeRequest](src/Binance/Requests/TradeApi/NewOrderUsingSorTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3SorOrderResponse](src/Binance/Models/ApiV3SorOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[NewOrderUsingSorTradeError](src/Binance/Errors/NewOrderUsingSorTradeError.cs)&gt;</code>

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

<code>[QueryAllocationsUserDataRequest](src/Binance/Requests/TradeApi/QueryAllocationsUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3MyAllocationsResponse](src/Binance/Models/ApiV3MyAllocationsResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryAllocationsUserDataError](src/Binance/Errors/QueryAllocationsUserDataError.cs)&gt;</code>

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

<code>[QueryCommissionRatesUserDataRequest](src/Binance/Requests/TradeApi/QueryCommissionRatesUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3AccountCommissionResponse](src/Binance/Models/ApiV3AccountCommissionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryCommissionRatesUserDataError](src/Binance/Errors/QueryCommissionRatesUserDataError.cs)&gt;</code>

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

<code>[QueryCurrentOrderCountUsageTradeRequest](src/Binance/Requests/TradeApi/QueryCurrentOrderCountUsageTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3RateLimitOrderResponse](src/Binance/Models/ApiV3RateLimitOrderResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryCurrentOrderCountUsageTradeError](src/Binance/Errors/QueryCurrentOrderCountUsageTradeError.cs)&gt;</code>

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

<code>[QueryOcoUserDataRequest](src/Binance/Requests/TradeApi/QueryOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiV3OrderListResponse](src/Binance/Models/ApiV3OrderListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryOcoUserDataError](src/Binance/Errors/QueryOcoUserDataError.cs)&gt;</code>

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

<code>[QueryOpenOcoUserDataRequest](src/Binance/Requests/TradeApi/QueryOpenOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3OpenOrderListResponse](src/Binance/Models/ApiV3OpenOrderListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryOpenOcoUserDataError](src/Binance/Errors/QueryOpenOcoUserDataError.cs)&gt;</code>

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

<code>[QueryOrderUserDataRequest](src/Binance/Requests/TradeApi/QueryOrderUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrderDetails](src/Binance/Models/OrderDetails.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryOrderUserDataError](src/Binance/Errors/QueryOrderUserDataError.cs)&gt;</code>

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

<code>[QueryPreventedMatchesRequest](src/Binance/Requests/TradeApi/QueryPreventedMatchesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3MyPreventedMatchesResponse](src/Binance/Models/ApiV3MyPreventedMatchesResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryPreventedMatchesError](src/Binance/Errors/QueryPreventedMatchesError.cs)&gt;</code>

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

<code>[QueryAllOcoUserDataRequest](src/Binance/Requests/TradeApi/QueryAllOcoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ApiV3AllOrderListResponse](src/Binance/Models/ApiV3AllOrderListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryAllOcoUserDataError](src/Binance/Errors/QueryAllOcoUserDataError.cs)&gt;</code>

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

<code>[TestNewOrderTradeRequest](src/Binance/Requests/TradeApi/TestNewOrderTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[TestNewOrderTradeError](src/Binance/Errors/TestNewOrderTradeError.cs)&gt;</code>

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

<code>[TestNewOrderUsingSorTradeRequest](src/Binance/Requests/TradeApi/TestNewOrderUsingSorTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[TestNewOrderUsingSorTradeError](src/Binance/Errors/TestNewOrderUsingSorTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VipLoans

> Source: [VipLoans](src/Binance/Api/VipLoans.cs)

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

<code>[CheckLockedValueOfVipCollateralAccountUserDataRequest](src/Binance/Requests/VipLoans/CheckLockedValueOfVipCollateralAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipCollateralAccountResponse](src/Binance/Models/SapiV1LoanVipCollateralAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[CheckLockedValueOfVipCollateralAccountUserDataError](src/Binance/Errors/CheckLockedValueOfVipCollateralAccountUserDataError.cs)&gt;</code>

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

<code>[GetBorrowInterestRateUserDataRequest](src/Binance/Requests/VipLoans/GetBorrowInterestRateUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1LoanVipRequestInterestRateResponse](src/Binance/Models/SapiV1LoanVipRequestInterestRateResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetBorrowInterestRateUserDataError](src/Binance/Errors/GetBorrowInterestRateUserDataError.cs)&gt;</code>

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

<code>[GetCollateralAssetDataUserDataRequest](src/Binance/Requests/VipLoans/GetCollateralAssetDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipCollateralDataResponse](src/Binance/Models/SapiV1LoanVipCollateralDataResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetCollateralAssetDataUserDataError](src/Binance/Errors/GetCollateralAssetDataUserDataError.cs)&gt;</code>

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

<code>[GetLoanableAssetsDataRequest](src/Binance/Requests/VipLoans/GetLoanableAssetsDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipLoanableDataResponse](src/Binance/Models/SapiV1LoanVipLoanableDataResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetLoanableAssetsDataError](src/Binance/Errors/GetLoanableAssetsDataError.cs)&gt;</code>

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

<code>[GetVipLoanOngoingOrdersUserDataRequest](src/Binance/Requests/VipLoans/GetVipLoanOngoingOrdersUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipOngoingOrdersResponse](src/Binance/Models/SapiV1LoanVipOngoingOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetVipLoanOngoingOrdersUserDataError](src/Binance/Errors/GetVipLoanOngoingOrdersUserDataError.cs)&gt;</code>

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

<code>[GetVipLoanRepaymentHistoryUserDataRequest](src/Binance/Requests/VipLoans/GetVipLoanRepaymentHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRepayHistoryResponse](src/Binance/Models/SapiV1LoanVipRepayHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetVipLoanRepaymentHistoryUserDataError](src/Binance/Errors/GetVipLoanRepaymentHistoryUserDataError.cs)&gt;</code>

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

<code>[QueryApplicationStatusUserDataRequest](src/Binance/Requests/VipLoans/QueryApplicationStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRequestDataResponse](src/Binance/Models/SapiV1LoanVipRequestDataResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryApplicationStatusUserDataError](src/Binance/Errors/QueryApplicationStatusUserDataError.cs)&gt;</code>

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

<code>[VipLoanBorrowRequest](src/Binance/Requests/VipLoans/VipLoanBorrowRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipBorrowResponse](src/Binance/Models/SapiV1LoanVipBorrowResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[VipLoanBorrowError](src/Binance/Errors/VipLoanBorrowError.cs)&gt;</code>

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

<code>[VipLoanRenewRequest](src/Binance/Requests/VipLoans/VipLoanRenewRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRenewResponse](src/Binance/Models/SapiV1LoanVipRenewResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[VipLoanRenewError](src/Binance/Errors/VipLoanRenewError.cs)&gt;</code>

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

<code>[VipLoanRepayTradeRequest](src/Binance/Requests/VipLoans/VipLoanRepayTradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1LoanVipRepayResponse](src/Binance/Models/SapiV1LoanVipRepayResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[VipLoanRepayTradeError](src/Binance/Errors/VipLoanRepayTradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Wallet

> Source: [Wallet](src/Binance/Api/Wallet.cs)

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

<code>[AccountApiTradingStatusUserDataRequest](src/Binance/Requests/Wallet/AccountApiTradingStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountApiTradingStatusResponse](src/Binance/Models/SapiV1AccountApiTradingStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AccountApiTradingStatusUserDataError](src/Binance/Errors/AccountApiTradingStatusUserDataError.cs)&gt;</code>

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

<code>[AccountStatusUserDataRequest](src/Binance/Requests/Wallet/AccountStatusUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountStatusResponse](src/Binance/Models/SapiV1AccountStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AccountStatusUserDataError](src/Binance/Errors/AccountStatusUserDataError.cs)&gt;</code>

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

<code>[AccountInfoUserDataRequest](src/Binance/Requests/Wallet/AccountInfoUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountInfoResponse](src/Binance/Models/SapiV1AccountInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AccountInfoUserDataError](src/Binance/Errors/AccountInfoUserDataError.cs)&gt;</code>

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

<code>[AllCoinsInformationUserDataRequest](src/Binance/Requests/Wallet/AllCoinsInformationUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalConfigGetallResponse](src/Binance/Models/SapiV1CapitalConfigGetallResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AllCoinsInformationUserDataError](src/Binance/Errors/AllCoinsInformationUserDataError.cs)&gt;</code>

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

<code>[AssetDetailUserDataRequest](src/Binance/Requests/Wallet/AssetDetailUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetAssetDetailResponse](src/Binance/Models/SapiV1AssetAssetDetailResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AssetDetailUserDataError](src/Binance/Errors/AssetDetailUserDataError.cs)&gt;</code>

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

<code>[AssetDividendRecordUserDataRequest](src/Binance/Requests/Wallet/AssetDividendRecordUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetAssetDividendResponse](src/Binance/Models/SapiV1AssetAssetDividendResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[AssetDividendRecordUserDataError](src/Binance/Errors/AssetDividendRecordUserDataError.cs)&gt;</code>

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

<code>[ConvertTransferUserDataRequest](src/Binance/Requests/Wallet/ConvertTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetConvertTransferResponse](src/Binance/Models/SapiV1AssetConvertTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[ConvertTransferUserDataError](src/Binance/Errors/ConvertTransferUserDataError.cs)&gt;</code>

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

<code>[DailyAccountSnapshotUserDataRequest](src/Binance/Requests/Wallet/DailyAccountSnapshotUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountSnapshotResponse](src/Binance/Models/AnyOf/SapiV1AccountSnapshotResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DailyAccountSnapshotUserDataError](src/Binance/Errors/DailyAccountSnapshotUserDataError.cs)&gt;</code>

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

<code>[DepositAddressSupportingNetworkUserDataRequest](src/Binance/Requests/Wallet/DepositAddressSupportingNetworkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalDepositAddressResponse](src/Binance/Models/SapiV1CapitalDepositAddressResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DepositAddressSupportingNetworkUserDataError](src/Binance/Errors/DepositAddressSupportingNetworkUserDataError.cs)&gt;</code>

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

<code>[DepositHistorySupportingNetworkUserDataRequest](src/Binance/Requests/Wallet/DepositHistorySupportingNetworkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalDepositHisrecResponse](src/Binance/Models/SapiV1CapitalDepositHisrecResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DepositHistorySupportingNetworkUserDataError](src/Binance/Errors/DepositHistorySupportingNetworkUserDataError.cs)&gt;</code>

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

<code>[DisableFastWithdrawSwitchUserDataRequest](src/Binance/Requests/Wallet/DisableFastWithdrawSwitchUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DisableFastWithdrawSwitchUserDataError](src/Binance/Errors/DisableFastWithdrawSwitchUserDataError.cs)&gt;</code>

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

<code>[DustTransferUserDataRequest](src/Binance/Requests/Wallet/DustTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetDustResponse](src/Binance/Models/SapiV1AssetDustResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DustTransferUserDataError](src/Binance/Errors/DustTransferUserDataError.cs)&gt;</code>

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

<code>[DustLogUserDataRequest](src/Binance/Requests/Wallet/DustLogUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetDribbletResponse](src/Binance/Models/SapiV1AssetDribbletResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[DustLogUserDataError](src/Binance/Errors/DustLogUserDataError.cs)&gt;</code>

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

<code>[EnableFastWithdrawSwitchUserDataRequest](src/Binance/Requests/Wallet/EnableFastWithdrawSwitchUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[EnableFastWithdrawSwitchUserDataError](src/Binance/Errors/EnableFastWithdrawSwitchUserDataError.cs)&gt;</code>

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

<code>[FetchDepositAddressListWithNetworkUserDataRequest](src/Binance/Requests/Wallet/FetchDepositAddressListWithNetworkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalDepositAddressListResponse](src/Binance/Models/SapiV1CapitalDepositAddressListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FetchDepositAddressListWithNetworkUserDataError](src/Binance/Errors/FetchDepositAddressListWithNetworkUserDataError.cs)&gt;</code>

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

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalWithdrawAddressListResponse](src/Binance/Models/SapiV1CapitalWithdrawAddressListResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FetchWithdrawAddressListUserDataError](src/Binance/Errors/FetchWithdrawAddressListUserDataError.cs)&gt;</code>

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

<code>[FundingWalletUserDataRequest](src/Binance/Requests/Wallet/FundingWalletUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1AssetGetFundingAssetResponse](src/Binance/Models/SapiV1AssetGetFundingAssetResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[FundingWalletUserDataError](src/Binance/Errors/FundingWalletUserDataError.cs)&gt;</code>

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

<code>[GetApiKeyPermissionUserDataRequest](src/Binance/Requests/Wallet/GetApiKeyPermissionUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AccountApiRestrictionsResponse](src/Binance/Models/SapiV1AccountApiRestrictionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetApiKeyPermissionUserDataError](src/Binance/Errors/GetApiKeyPermissionUserDataError.cs)&gt;</code>

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

<code>[GetAssetsThatCanBeConvertedIntoBnbUserDataRequest](src/Binance/Requests/Wallet/GetAssetsThatCanBeConvertedIntoBnbUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetDustBtcResponse](src/Binance/Models/SapiV1AssetDustBtcResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetAssetsThatCanBeConvertedIntoBnbUserDataError](src/Binance/Errors/GetAssetsThatCanBeConvertedIntoBnbUserDataError.cs)&gt;</code>

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

<code>[GetCloudMiningPaymentAndRefundHistoryUserDataRequest](src/Binance/Requests/Wallet/GetCloudMiningPaymentAndRefundHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse](src/Binance/Models/SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetCloudMiningPaymentAndRefundHistoryUserDataError](src/Binance/Errors/GetCloudMiningPaymentAndRefundHistoryUserDataError.cs)&gt;</code>

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

<code>[GetSymbolsDelistScheduleForSpotMarketDataRequest](src/Binance/Requests/Wallet/GetSymbolsDelistScheduleForSpotMarketDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1SpotDelistScheduleResponse](src/Binance/Models/SapiV1SpotDelistScheduleResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[GetSymbolsDelistScheduleForSpotMarketDataError](src/Binance/Errors/GetSymbolsDelistScheduleForSpotMarketDataError.cs)&gt;</code>

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

<code>[OneClickArrivalDepositApplyUserDataRequest](src/Binance/Requests/Wallet/OneClickArrivalDepositApplyUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalDepositCreditApplyResponse](src/Binance/Models/SapiV1CapitalDepositCreditApplyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[OneClickArrivalDepositApplyUserDataError](src/Binance/Errors/OneClickArrivalDepositApplyUserDataError.cs)&gt;</code>

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

<code>[QueryConvertTransferUserDataRequest](src/Binance/Requests/Wallet/QueryConvertTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetConvertTransferQueryByPageResponse](src/Binance/Models/SapiV1AssetConvertTransferQueryByPageResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryConvertTransferUserDataError](src/Binance/Errors/QueryConvertTransferUserDataError.cs)&gt;</code>

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

<code>[QueryUserDelegationHistoryForMasterAccountUserDataRequest](src/Binance/Requests/Wallet/QueryUserDelegationHistoryForMasterAccountUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetCustodyTransferHistoryResponse](src/Binance/Models/SapiV1AssetCustodyTransferHistoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryUserDelegationHistoryForMasterAccountUserDataError](src/Binance/Errors/QueryUserDelegationHistoryForMasterAccountUserDataError.cs)&gt;</code>

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

<code>[QueryUserUniversalTransferHistoryUserDataRequest](src/Binance/Requests/Wallet/QueryUserUniversalTransferHistoryUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetTransferResponse](src/Binance/Models/SapiV1AssetTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryUserUniversalTransferHistoryUserDataError](src/Binance/Errors/QueryUserUniversalTransferHistoryUserDataError.cs)&gt;</code>

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

<code>[QueryUserWalletBalanceUserDataRequest](src/Binance/Requests/Wallet/QueryUserWalletBalanceUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1AssetWalletBalanceResponse](src/Binance/Models/SapiV1AssetWalletBalanceResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryUserWalletBalanceUserDataError](src/Binance/Errors/QueryUserWalletBalanceUserDataError.cs)&gt;</code>

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

**OnSuccess**: <code>[SapiV1CapitalContractConvertibleCoinsResponse](src/Binance/Models/SapiV1CapitalContractConvertibleCoinsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[QueryAutoConvertingStableCoinsUserDataError](src/Binance/Errors/QueryAutoConvertingStableCoinsUserDataError.cs)&gt;</code>

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

<code>[SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest](src/Binance/Requests/Wallet/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError](src/Binance/Errors/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError.cs)&gt;</code>

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

**OnSuccess**: <code>[SapiV1SystemStatusResponse](src/Binance/Models/SapiV1SystemStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Binance/Core/ErrorResponse/RawError.cs)&gt;</code>

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

<code>[TradeFeeUserDataRequest](src/Binance/Requests/Wallet/TradeFeeUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1AssetTradeFeeResponse](src/Binance/Models/SapiV1AssetTradeFeeResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[TradeFeeUserDataError](src/Binance/Errors/TradeFeeUserDataError.cs)&gt;</code>

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

<code>[UserAssetUserDataRequest](src/Binance/Requests/Wallet/UserAssetUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV3AssetGetUserAssetResponse](src/Binance/Models/SapiV3AssetGetUserAssetResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[UserAssetUserDataError](src/Binance/Errors/UserAssetUserDataError.cs)&gt;</code>

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

<code>[UserUniversalTransferUserDataRequest](src/Binance/Requests/Wallet/UserUniversalTransferUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1AssetTransferResponse1](src/Binance/Models/SapiV1AssetTransferResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[UserUniversalTransferUserDataError](src/Binance/Errors/UserUniversalTransferUserDataError.cs)&gt;</code>

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

<code>[WithdrawUserDataRequest](src/Binance/Requests/Wallet/WithdrawUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SapiV1CapitalWithdrawApplyResponse](src/Binance/Models/SapiV1CapitalWithdrawApplyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[WithdrawUserDataError](src/Binance/Errors/WithdrawUserDataError.cs)&gt;</code>

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

<code>[WithdrawHistorySupportingNetworkUserDataRequest](src/Binance/Requests/Wallet/WithdrawHistorySupportingNetworkUserDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SapiV1CapitalWithdrawHistoryResponse](src/Binance/Models/SapiV1CapitalWithdrawHistoryResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Binance/Core/Exceptions/ApiException.cs)&lt;[WithdrawHistorySupportingNetworkUserDataError](src/Binance/Errors/WithdrawHistorySupportingNetworkUserDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

