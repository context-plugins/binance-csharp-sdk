<!-- Generated file — do not edit; regenerated with the SDK. -->

# VipLoans — operations

Accessor: `client.VipLoans` · Source: `Api/VipLoans.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckLockedValueOfVipCollateralAccountUserData

- **Signature**: `CheckLockedValueOfVipCollateralAccountUserData(long timestamp, string signature, long? orderId, long? collateralAccountId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `orderId` — nullable, no default → **must pass explicitly**
  - `collateralAccountId` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `collateralAccountId` ← `collateralAccountId`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanVipCollateralAccountResponse`
- **Error**: `SdkException<CheckLockedValueOfVipCollateralAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanVipCollateralAccountResponse` | `Models/SapiV1LoanVipCollateralAccountResponse.cs` |
| `CheckLockedValueOfVipCollateralAccountUserDataError` | `Errors/CheckLockedValueOfVipCollateralAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetBorrowInterestRateUserData

- **Signature**: `GetBorrowInterestRateUserData(long timestamp, string signature, string? loanCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `loanCoin` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1LoanVipRequestInterestRateResponse>`
- **Error**: `SdkException<GetBorrowInterestRateUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanVipRequestInterestRateResponse` | `Models/SapiV1LoanVipRequestInterestRateResponse.cs` |
| `GetBorrowInterestRateUserDataError` | `Errors/GetBorrowInterestRateUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCollateralAssetDataUserData

- **Signature**: `GetCollateralAssetDataUserData(long timestamp, string signature, string? collateralCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `collateralCoin` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `collateralCoin` ← `collateralCoin`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanVipCollateralDataResponse`
- **Error**: `SdkException<GetCollateralAssetDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanVipCollateralDataResponse` | `Models/SapiV1LoanVipCollateralDataResponse.cs` |
| `GetCollateralAssetDataUserDataError` | `Errors/GetCollateralAssetDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanableAssetsData

- **Signature**: `GetLoanableAssetsData(long timestamp, string signature, string? loanCoin, int? vipLevel, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `loanCoin` — nullable, no default → **must pass explicitly**
  - `vipLevel` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `vipLevel` ← `vipLevel`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanVipLoanableDataResponse`
- **Error**: `SdkException<GetLoanableAssetsDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanVipLoanableDataResponse` | `Models/SapiV1LoanVipLoanableDataResponse.cs` |
| `GetLoanableAssetsDataError` | `Errors/GetLoanableAssetsDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetVipLoanOngoingOrdersUserData

- **Signature**: `GetVipLoanOngoingOrdersUserData(long timestamp, string signature, long? orderId, long? collateralAccountId, string? loanCoin, string? collateralCoin, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`orderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `collateralAccountId` ← `collateralAccountId`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanVipOngoingOrdersResponse`
- **Error**: `SdkException<GetVipLoanOngoingOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanVipOngoingOrdersResponse` | `Models/SapiV1LoanVipOngoingOrdersResponse.cs` |
| `GetVipLoanOngoingOrdersUserDataError` | `Errors/GetVipLoanOngoingOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetVipLoanRepaymentHistoryUserData

- **Signature**: `GetVipLoanRepaymentHistoryUserData(long timestamp, string signature, long? orderId, string? loanCoin, long? startTime, long? endTime, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`orderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `loanCoin` ← `loanCoin`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanVipRepayHistoryResponse`
- **Error**: `SdkException<GetVipLoanRepaymentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanVipRepayHistoryResponse` | `Models/SapiV1LoanVipRepayHistoryResponse.cs` |
| `GetVipLoanRepaymentHistoryUserDataError` | `Errors/GetVipLoanRepaymentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryApplicationStatusUserData

- **Signature**: `QueryApplicationStatusUserData(long timestamp, string signature, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `current` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanVipRequestDataResponse`
- **Error**: `SdkException<QueryApplicationStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanVipRequestDataResponse` | `Models/SapiV1LoanVipRequestDataResponse.cs` |
| `QueryApplicationStatusUserDataError` | `Errors/QueryApplicationStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### VipLoanBorrow

- **Signature**: `VipLoanBorrow(long loanAccountId, double loanAmount, string collateralAccountId, string collateralCoin, IsFlexibleRate isFlexibleRate, long timestamp, string signature, string? loanCoin, int? loanTerm, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `loanCoin` — nullable, no default → **must pass explicitly**
  - `loanTerm` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `loanAccountId` ← `loanAccountId`, `loanAmount` ← `loanAmount`, `collateralAccountId` ← `collateralAccountId`, `collateralCoin` ← `collateralCoin`, `isFlexibleRate` ← `isFlexibleRate`, `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `loanTerm` ← `loanTerm`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanVipBorrowResponse`
- **Error**: `SdkException<VipLoanBorrowError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsFlexibleRate` | `Models/Enums/IsFlexibleRate.cs` |
| `SapiV1LoanVipBorrowResponse` | `Models/SapiV1LoanVipBorrowResponse.cs` |
| `VipLoanBorrowError` | `Errors/VipLoanBorrowError.cs` |
| `Error` | `Models/Error.cs` |

### VipLoanRenew

- **Signature**: `VipLoanRenew(long timestamp, string signature, long? orderId, int? loanTerm, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `orderId` — nullable, no default → **must pass explicitly**
  - `loanTerm` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `loanTerm` ← `loanTerm`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanVipRenewResponse`
- **Error**: `SdkException<VipLoanRenewError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanVipRenewResponse` | `Models/SapiV1LoanVipRenewResponse.cs` |
| `VipLoanRenewError` | `Errors/VipLoanRenewError.cs` |
| `Error` | `Models/Error.cs` |

### VipLoanRepayTrade

- **Signature**: `VipLoanRepayTrade(double amount, long timestamp, string signature, long? orderId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `orderId` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanVipRepayResponse`
- **Error**: `SdkException<VipLoanRepayTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanVipRepayResponse` | `Models/SapiV1LoanVipRepayResponse.cs` |
| `VipLoanRepayTradeError` | `Errors/VipLoanRepayTradeError.cs` |
| `Error` | `Models/Error.cs` |

