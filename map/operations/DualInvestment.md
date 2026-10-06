<!-- Generated file — do not edit; regenerated with the SDK. -->

# DualInvestment — operations

Accessor: `client.DualInvestment` · Source: `Api/DualInvestment.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChangeAutoCompoundStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ChangeAutoCompoundStatusUserData(ChangeAutoCompoundStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PositionId`, `AutoCompoundPlan`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `positionId` ← `PositionId`, `autoCompoundPlan` ← `AutoCompoundPlan`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1DciProductAutoCompoundEditStatusResponse`
- **Error**: `ApiException<ChangeAutoCompoundStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChangeAutoCompoundStatusUserDataRequest` | `Requests/DualInvestment/ChangeAutoCompoundStatusUserDataRequest.cs` |
| `AutoCompoundPlan` | `Models/Enums/AutoCompoundPlan.cs` |
| `SapiV1DciProductAutoCompoundEditStatusResponse` | `Models/SapiV1DciProductAutoCompoundEditStatusResponse.cs` |
| `ChangeAutoCompoundStatusUserDataError` | `Errors/ChangeAutoCompoundStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### CheckDualInvestmentAccountsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CheckDualInvestmentAccountsUserData(CheckDualInvestmentAccountsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1DciProductAccountsResponse`
- **Error**: `ApiException<CheckDualInvestmentAccountsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckDualInvestmentAccountsUserDataRequest` | `Requests/DualInvestment/CheckDualInvestmentAccountsUserDataRequest.cs` |
| `SapiV1DciProductAccountsResponse` | `Models/SapiV1DciProductAccountsResponse.cs` |
| `CheckDualInvestmentAccountsUserDataError` | `Errors/CheckDualInvestmentAccountsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetDualInvestmentPositionsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetDualInvestmentPositionsUserData(GetDualInvestmentPositionsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `status` ← `Status`, `pageSize` ← `PageSize`, `pageIndex` ← `PageIndex`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1DciProductPositionsResponse`
- **Error**: `ApiException<GetDualInvestmentPositionsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDualInvestmentPositionsUserDataRequest` | `Requests/DualInvestment/GetDualInvestmentPositionsUserDataRequest.cs` |
| `Status2` | `Models/Enums/Status2.cs` |
| `SapiV1DciProductPositionsResponse` | `Models/SapiV1DciProductPositionsResponse.cs` |
| `GetDualInvestmentPositionsUserDataError` | `Errors/GetDualInvestmentPositionsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetDualInvestmentProductListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetDualInvestmentProductListUserData(GetDualInvestmentProductListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OptionType`, `ExercisedCoin`, `InvestCoin`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `optionType` ← `OptionType`, `exercisedCoin` ← `ExercisedCoin`, `investCoin` ← `InvestCoin`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `pageSize` ← `PageSize`, `pageIndex` ← `PageIndex`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1DciProductListResponse`
- **Error**: `ApiException<GetDualInvestmentProductListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDualInvestmentProductListUserDataRequest` | `Requests/DualInvestment/GetDualInvestmentProductListUserDataRequest.cs` |
| `OptionType` | `Models/Enums/OptionType.cs` |
| `SapiV1DciProductListResponse` | `Models/SapiV1DciProductListResponse.cs` |
| `GetDualInvestmentProductListUserDataError` | `Errors/GetDualInvestmentProductListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeDualInvestmentProductsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubscribeDualInvestmentProductsUserData(SubscribeDualInvestmentProductsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `OrderId`, `DepositAmount`, `AutoCompoundPlan`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `id` ← `Id`, `orderId` ← `OrderId`, `depositAmount` ← `DepositAmount`, `autoCompoundPlan` ← `AutoCompoundPlan`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1DciProductSubscribeResponse`
- **Error**: `ApiException<SubscribeDualInvestmentProductsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubscribeDualInvestmentProductsUserDataRequest` | `Requests/DualInvestment/SubscribeDualInvestmentProductsUserDataRequest.cs` |
| `AutoCompoundPlan` | `Models/Enums/AutoCompoundPlan.cs` |
| `SapiV1DciProductSubscribeResponse` | `Models/SapiV1DciProductSubscribeResponse.cs` |
| `SubscribeDualInvestmentProductsUserDataError` | `Errors/SubscribeDualInvestmentProductsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

