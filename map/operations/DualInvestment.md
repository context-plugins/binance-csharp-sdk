<!-- Generated file — do not edit; regenerated with the SDK. -->

# DualInvestment — operations

Accessor: `client.DualInvestment` · Source: `src/Binance/Api/DualInvestment.cs` · 5 operations

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
| `ChangeAutoCompoundStatusUserDataRequest` | `src/Binance/Requests/DualInvestment/ChangeAutoCompoundStatusUserDataRequest.cs` |
| `AutoCompoundPlan` | `src/Binance/Models/Enums/AutoCompoundPlan.cs` |
| `SapiV1DciProductAutoCompoundEditStatusResponse` | `src/Binance/Models/SapiV1DciProductAutoCompoundEditStatusResponse.cs` |
| `ChangeAutoCompoundStatusUserDataError` | `src/Binance/Errors/ChangeAutoCompoundStatusUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `CheckDualInvestmentAccountsUserDataRequest` | `src/Binance/Requests/DualInvestment/CheckDualInvestmentAccountsUserDataRequest.cs` |
| `SapiV1DciProductAccountsResponse` | `src/Binance/Models/SapiV1DciProductAccountsResponse.cs` |
| `CheckDualInvestmentAccountsUserDataError` | `src/Binance/Errors/CheckDualInvestmentAccountsUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetDualInvestmentPositionsUserDataRequest` | `src/Binance/Requests/DualInvestment/GetDualInvestmentPositionsUserDataRequest.cs` |
| `Status2` | `src/Binance/Models/Enums/Status2.cs` |
| `SapiV1DciProductPositionsResponse` | `src/Binance/Models/SapiV1DciProductPositionsResponse.cs` |
| `GetDualInvestmentPositionsUserDataError` | `src/Binance/Errors/GetDualInvestmentPositionsUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetDualInvestmentProductListUserDataRequest` | `src/Binance/Requests/DualInvestment/GetDualInvestmentProductListUserDataRequest.cs` |
| `OptionType` | `src/Binance/Models/Enums/OptionType.cs` |
| `SapiV1DciProductListResponse` | `src/Binance/Models/SapiV1DciProductListResponse.cs` |
| `GetDualInvestmentProductListUserDataError` | `src/Binance/Errors/GetDualInvestmentProductListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `SubscribeDualInvestmentProductsUserDataRequest` | `src/Binance/Requests/DualInvestment/SubscribeDualInvestmentProductsUserDataRequest.cs` |
| `AutoCompoundPlan` | `src/Binance/Models/Enums/AutoCompoundPlan.cs` |
| `SapiV1DciProductSubscribeResponse` | `src/Binance/Models/SapiV1DciProductSubscribeResponse.cs` |
| `SubscribeDualInvestmentProductsUserDataError` | `src/Binance/Errors/SubscribeDualInvestmentProductsUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

