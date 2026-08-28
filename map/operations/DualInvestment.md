<!-- Generated file — do not edit; regenerated with the SDK. -->

# DualInvestment — operations

Accessor: `client.DualInvestment` · Source: `Api/DualInvestment.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChangeAutoCompoundStatusUserData

- **Signature**: `ChangeAutoCompoundStatusUserData(long positionId, AutoCompoundPlan autoCompoundPlan, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `positionId` ← `positionId`, `autoCompoundPlan` ← `autoCompoundPlan`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1DciProductAutoCompoundEditStatusResponse`
- **Error**: `SdkException<ChangeAutoCompoundStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AutoCompoundPlan` | `Models/Enums/AutoCompoundPlan.cs` |
| `SapiV1DciProductAutoCompoundEditStatusResponse` | `Models/SapiV1DciProductAutoCompoundEditStatusResponse.cs` |
| `ChangeAutoCompoundStatusUserDataError` | `Errors/ChangeAutoCompoundStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### CheckDualInvestmentAccountsUserData

- **Signature**: `CheckDualInvestmentAccountsUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1DciProductAccountsResponse`
- **Error**: `SdkException<CheckDualInvestmentAccountsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1DciProductAccountsResponse` | `Models/SapiV1DciProductAccountsResponse.cs` |
| `CheckDualInvestmentAccountsUserDataError` | `Errors/CheckDualInvestmentAccountsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetDualInvestmentPositionsUserData

- **Signature**: `GetDualInvestmentPositionsUserData(long timestamp, string signature, Status2? status, string? pageSize, int? pageIndex, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`status` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `status` ← `status`, `pageSize` ← `pageSize`, `pageIndex` ← `pageIndex`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1DciProductPositionsResponse`
- **Error**: `SdkException<GetDualInvestmentPositionsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Status2` | `Models/Enums/Status2.cs` |
| `SapiV1DciProductPositionsResponse` | `Models/SapiV1DciProductPositionsResponse.cs` |
| `GetDualInvestmentPositionsUserDataError` | `Errors/GetDualInvestmentPositionsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetDualInvestmentProductListUserData

- **Signature**: `GetDualInvestmentProductListUserData(OptionType optionType, string exercisedCoin, string investCoin, long timestamp, string signature, string? pageSize, int? pageIndex, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `pageSize` — nullable, no default → **must pass explicitly**
  - `pageIndex` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `optionType` ← `optionType`, `exercisedCoin` ← `exercisedCoin`, `investCoin` ← `investCoin`, `timestamp` ← `timestamp`, `signature` ← `signature`, `pageSize` ← `pageSize`, `pageIndex` ← `pageIndex`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1DciProductListResponse`
- **Error**: `SdkException<GetDualInvestmentProductListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OptionType` | `Models/Enums/OptionType.cs` |
| `SapiV1DciProductListResponse` | `Models/SapiV1DciProductListResponse.cs` |
| `GetDualInvestmentProductListUserDataError` | `Errors/GetDualInvestmentProductListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeDualInvestmentProductsUserData

- **Signature**: `SubscribeDualInvestmentProductsUserData(string id, string orderId, double depositAmount, AutoCompoundPlan autoCompoundPlan, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `id` ← `id`, `orderId` ← `orderId`, `depositAmount` ← `depositAmount`, `autoCompoundPlan` ← `autoCompoundPlan`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1DciProductSubscribeResponse`
- **Error**: `SdkException<SubscribeDualInvestmentProductsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AutoCompoundPlan` | `Models/Enums/AutoCompoundPlan.cs` |
| `SapiV1DciProductSubscribeResponse` | `Models/SapiV1DciProductSubscribeResponse.cs` |
| `SubscribeDualInvestmentProductsUserDataError` | `Errors/SubscribeDualInvestmentProductsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

