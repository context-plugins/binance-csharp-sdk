<!-- Generated file — do not edit; regenerated with the SDK. -->

# Savings — operations

Accessor: `client.Savings` · Source: `src/Binance/Api/Savings.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChangeFixedActivityPositionToDailyPositionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ChangeFixedActivityPositionToDailyPositionUserData(ChangeFixedActivityPositionToDailyPositionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Lot`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `projectId` ← `ProjectId`, `lot` ← `Lot`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `positionId` ← `PositionId`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingPositionChangedResponse`
- **Error**: `ApiException<ChangeFixedActivityPositionToDailyPositionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChangeFixedActivityPositionToDailyPositionUserDataRequest` | `src/Binance/Requests/Savings/ChangeFixedActivityPositionToDailyPositionUserDataRequest.cs` |
| `SapiV1LendingPositionChangedResponse` | `src/Binance/Models/SapiV1LendingPositionChangedResponse.cs` |
| `ChangeFixedActivityPositionToDailyPositionUserDataError` | `src/Binance/Errors/ChangeFixedActivityPositionToDailyPositionUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetFixedActivityProjectListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFixedActivityProjectListUserData(GetFixedActivityProjectListUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `status` ← `Status`, `isSortAsc` ← `IsSortAsc`, `sortBy` ← `SortBy`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingProjectListResponse>`
- **Error**: `ApiException<GetFixedActivityProjectListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFixedActivityProjectListUserDataRequest` | `src/Binance/Requests/Savings/GetFixedActivityProjectListUserDataRequest.cs` |
| `Type8` | `src/Binance/Models/Enums/Type8.cs` |
| `Status` | `src/Binance/Models/Enums/Status.cs` |
| `SortBy` | `src/Binance/Models/Enums/SortBy.cs` |
| `SapiV1LendingProjectListResponse` | `src/Binance/Models/SapiV1LendingProjectListResponse.cs` |
| `GetFixedActivityProjectListUserDataError` | `src/Binance/Errors/GetFixedActivityProjectListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetFixedActivityProjectPositionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFixedActivityProjectPositionUserData(GetFixedActivityProjectPositionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `projectId` ← `ProjectId`, `status` ← `Status`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1LendingProjectPositionListResponse>`
- **Error**: `ApiException<GetFixedActivityProjectPositionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFixedActivityProjectPositionUserDataRequest` | `src/Binance/Requests/Savings/GetFixedActivityProjectPositionUserDataRequest.cs` |
| `Status` | `src/Binance/Models/Enums/Status.cs` |
| `SapiV1LendingProjectPositionListResponse` | `src/Binance/Models/SapiV1LendingProjectPositionListResponse.cs` |
| `GetFixedActivityProjectPositionUserDataError` | `src/Binance/Errors/GetFixedActivityProjectPositionUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### PurchaseFixedActivityProjectUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PurchaseFixedActivityProjectUserData(PurchaseFixedActivityProjectUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Lot`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `projectId` ← `ProjectId`, `lot` ← `Lot`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LendingCustomizedFixedPurchaseResponse`
- **Error**: `ApiException<PurchaseFixedActivityProjectUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PurchaseFixedActivityProjectUserDataRequest` | `src/Binance/Requests/Savings/PurchaseFixedActivityProjectUserDataRequest.cs` |
| `SapiV1LendingCustomizedFixedPurchaseResponse` | `src/Binance/Models/SapiV1LendingCustomizedFixedPurchaseResponse.cs` |
| `PurchaseFixedActivityProjectUserDataError` | `src/Binance/Errors/PurchaseFixedActivityProjectUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

