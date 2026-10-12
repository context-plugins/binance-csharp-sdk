<!-- Generated file — do not edit; regenerated with the SDK. -->

# VipLoans — operations

Accessor: `client.VipLoans` · Source: `src/Binance/Api/VipLoans.cs` · 10 operations

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
| `CheckLockedValueOfVipCollateralAccountUserDataRequest` | `src/Binance/Requests/VipLoans/CheckLockedValueOfVipCollateralAccountUserDataRequest.cs` |
| `SapiV1LoanVipCollateralAccountResponse` | `src/Binance/Models/SapiV1LoanVipCollateralAccountResponse.cs` |
| `CheckLockedValueOfVipCollateralAccountUserDataError` | `src/Binance/Errors/CheckLockedValueOfVipCollateralAccountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetBorrowInterestRateUserDataRequest` | `src/Binance/Requests/VipLoans/GetBorrowInterestRateUserDataRequest.cs` |
| `SapiV1LoanVipRequestInterestRateResponse` | `src/Binance/Models/SapiV1LoanVipRequestInterestRateResponse.cs` |
| `GetBorrowInterestRateUserDataError` | `src/Binance/Errors/GetBorrowInterestRateUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetCollateralAssetDataUserDataRequest` | `src/Binance/Requests/VipLoans/GetCollateralAssetDataUserDataRequest.cs` |
| `SapiV1LoanVipCollateralDataResponse` | `src/Binance/Models/SapiV1LoanVipCollateralDataResponse.cs` |
| `GetCollateralAssetDataUserDataError` | `src/Binance/Errors/GetCollateralAssetDataUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLoanableAssetsDataRequest` | `src/Binance/Requests/VipLoans/GetLoanableAssetsDataRequest.cs` |
| `SapiV1LoanVipLoanableDataResponse` | `src/Binance/Models/SapiV1LoanVipLoanableDataResponse.cs` |
| `GetLoanableAssetsDataError` | `src/Binance/Errors/GetLoanableAssetsDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetVipLoanOngoingOrdersUserDataRequest` | `src/Binance/Requests/VipLoans/GetVipLoanOngoingOrdersUserDataRequest.cs` |
| `SapiV1LoanVipOngoingOrdersResponse` | `src/Binance/Models/SapiV1LoanVipOngoingOrdersResponse.cs` |
| `GetVipLoanOngoingOrdersUserDataError` | `src/Binance/Errors/GetVipLoanOngoingOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetVipLoanRepaymentHistoryUserDataRequest` | `src/Binance/Requests/VipLoans/GetVipLoanRepaymentHistoryUserDataRequest.cs` |
| `SapiV1LoanVipRepayHistoryResponse` | `src/Binance/Models/SapiV1LoanVipRepayHistoryResponse.cs` |
| `GetVipLoanRepaymentHistoryUserDataError` | `src/Binance/Errors/GetVipLoanRepaymentHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `QueryApplicationStatusUserDataRequest` | `src/Binance/Requests/VipLoans/QueryApplicationStatusUserDataRequest.cs` |
| `SapiV1LoanVipRequestDataResponse` | `src/Binance/Models/SapiV1LoanVipRequestDataResponse.cs` |
| `QueryApplicationStatusUserDataError` | `src/Binance/Errors/QueryApplicationStatusUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `VipLoanBorrowRequest` | `src/Binance/Requests/VipLoans/VipLoanBorrowRequest.cs` |
| `IsFlexibleRate` | `src/Binance/Models/Enums/IsFlexibleRate.cs` |
| `SapiV1LoanVipBorrowResponse` | `src/Binance/Models/SapiV1LoanVipBorrowResponse.cs` |
| `VipLoanBorrowError` | `src/Binance/Errors/VipLoanBorrowError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `VipLoanRenewRequest` | `src/Binance/Requests/VipLoans/VipLoanRenewRequest.cs` |
| `SapiV1LoanVipRenewResponse` | `src/Binance/Models/SapiV1LoanVipRenewResponse.cs` |
| `VipLoanRenewError` | `src/Binance/Errors/VipLoanRenewError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `VipLoanRepayTradeRequest` | `src/Binance/Requests/VipLoans/VipLoanRepayTradeRequest.cs` |
| `SapiV1LoanVipRepayResponse` | `src/Binance/Models/SapiV1LoanVipRepayResponse.cs` |
| `VipLoanRepayTradeError` | `src/Binance/Errors/VipLoanRepayTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

