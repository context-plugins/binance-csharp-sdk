<!-- Generated file — do not edit; regenerated with the SDK. -->

# VipLoans — operations

Accessor: `client.VipLoans` · Source: `Api/VipLoans.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckLockedValueOfVipCollateralAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CheckLockedValueOfVipCollateralAccountUserData(CheckLockedValueOfVipCollateralAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `collateralAccountId` ← `CollateralAccountId`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanVipCollateralAccountResponse`
- **Error**: `ApiException<CheckLockedValueOfVipCollateralAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckLockedValueOfVipCollateralAccountUserDataRequest` | `Requests/VipLoans/CheckLockedValueOfVipCollateralAccountUserDataRequest.cs` |
| `SapiV1LoanVipCollateralAccountResponse` | `Models/SapiV1LoanVipCollateralAccountResponse.cs` |
| `CheckLockedValueOfVipCollateralAccountUserDataError` | `Errors/CheckLockedValueOfVipCollateralAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetBorrowInterestRateUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetBorrowInterestRateUserData(GetBorrowInterestRateUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1LoanVipRequestInterestRateResponse>`
- **Error**: `ApiException<GetBorrowInterestRateUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBorrowInterestRateUserDataRequest` | `Requests/VipLoans/GetBorrowInterestRateUserDataRequest.cs` |
| `SapiV1LoanVipRequestInterestRateResponse` | `Models/SapiV1LoanVipRequestInterestRateResponse.cs` |
| `GetBorrowInterestRateUserDataError` | `Errors/GetBorrowInterestRateUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCollateralAssetDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCollateralAssetDataUserData(GetCollateralAssetDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `collateralCoin` ← `CollateralCoin`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanVipCollateralDataResponse`
- **Error**: `ApiException<GetCollateralAssetDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCollateralAssetDataUserDataRequest` | `Requests/VipLoans/GetCollateralAssetDataUserDataRequest.cs` |
| `SapiV1LoanVipCollateralDataResponse` | `Models/SapiV1LoanVipCollateralDataResponse.cs` |
| `GetCollateralAssetDataUserDataError` | `Errors/GetCollateralAssetDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanableAssetsData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLoanableAssetsData(GetLoanableAssetsDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `vipLevel` ← `VipLevel`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanVipLoanableDataResponse`
- **Error**: `ApiException<GetLoanableAssetsDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLoanableAssetsDataRequest` | `Requests/VipLoans/GetLoanableAssetsDataRequest.cs` |
| `SapiV1LoanVipLoanableDataResponse` | `Models/SapiV1LoanVipLoanableDataResponse.cs` |
| `GetLoanableAssetsDataError` | `Errors/GetLoanableAssetsDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetVipLoanOngoingOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetVipLoanOngoingOrdersUserData(GetVipLoanOngoingOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `collateralAccountId` ← `CollateralAccountId`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanVipOngoingOrdersResponse`
- **Error**: `ApiException<GetVipLoanOngoingOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetVipLoanOngoingOrdersUserDataRequest` | `Requests/VipLoans/GetVipLoanOngoingOrdersUserDataRequest.cs` |
| `SapiV1LoanVipOngoingOrdersResponse` | `Models/SapiV1LoanVipOngoingOrdersResponse.cs` |
| `GetVipLoanOngoingOrdersUserDataError` | `Errors/GetVipLoanOngoingOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetVipLoanRepaymentHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetVipLoanRepaymentHistoryUserData(GetVipLoanRepaymentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `loanCoin` ← `LoanCoin`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanVipRepayHistoryResponse`
- **Error**: `ApiException<GetVipLoanRepaymentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetVipLoanRepaymentHistoryUserDataRequest` | `Requests/VipLoans/GetVipLoanRepaymentHistoryUserDataRequest.cs` |
| `SapiV1LoanVipRepayHistoryResponse` | `Models/SapiV1LoanVipRepayHistoryResponse.cs` |
| `GetVipLoanRepaymentHistoryUserDataError` | `Errors/GetVipLoanRepaymentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryApplicationStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryApplicationStatusUserData(QueryApplicationStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanVipRequestDataResponse`
- **Error**: `ApiException<QueryApplicationStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryApplicationStatusUserDataRequest` | `Requests/VipLoans/QueryApplicationStatusUserDataRequest.cs` |
| `SapiV1LoanVipRequestDataResponse` | `Models/SapiV1LoanVipRequestDataResponse.cs` |
| `QueryApplicationStatusUserDataError` | `Errors/QueryApplicationStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### VipLoanBorrow

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `VipLoanBorrow(VipLoanBorrowRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LoanAccountId`, `LoanAmount`, `CollateralAccountId`, `CollateralCoin`, `IsFlexibleRate`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `loanAccountId` ← `LoanAccountId`, `loanAmount` ← `LoanAmount`, `collateralAccountId` ← `CollateralAccountId`, `collateralCoin` ← `CollateralCoin`, `isFlexibleRate` ← `IsFlexibleRate`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `loanTerm` ← `LoanTerm`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanVipBorrowResponse`
- **Error**: `ApiException<VipLoanBorrowError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VipLoanBorrowRequest` | `Requests/VipLoans/VipLoanBorrowRequest.cs` |
| `IsFlexibleRate` | `Models/Enums/IsFlexibleRate.cs` |
| `SapiV1LoanVipBorrowResponse` | `Models/SapiV1LoanVipBorrowResponse.cs` |
| `VipLoanBorrowError` | `Errors/VipLoanBorrowError.cs` |
| `Error` | `Models/Error.cs` |

### VipLoanRenew

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `VipLoanRenew(VipLoanRenewRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `loanTerm` ← `LoanTerm`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanVipRenewResponse`
- **Error**: `ApiException<VipLoanRenewError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VipLoanRenewRequest` | `Requests/VipLoans/VipLoanRenewRequest.cs` |
| `SapiV1LoanVipRenewResponse` | `Models/SapiV1LoanVipRenewResponse.cs` |
| `VipLoanRenewError` | `Errors/VipLoanRenewError.cs` |
| `Error` | `Models/Error.cs` |

### VipLoanRepayTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `VipLoanRepayTrade(VipLoanRepayTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanVipRepayResponse`
- **Error**: `ApiException<VipLoanRepayTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VipLoanRepayTradeRequest` | `Requests/VipLoans/VipLoanRepayTradeRequest.cs` |
| `SapiV1LoanVipRepayResponse` | `Models/SapiV1LoanVipRepayResponse.cs` |
| `VipLoanRepayTradeError` | `Errors/VipLoanRepayTradeError.cs` |
| `Error` | `Models/Error.cs` |

