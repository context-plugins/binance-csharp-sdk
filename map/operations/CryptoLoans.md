<!-- Generated file — do not edit; regenerated with the SDK. -->

# CryptoLoans — operations

Accessor: `client.CryptoLoans` · Source: `Api/CryptoLoans.cs` · 21 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdjustLtvFlexibleLoanAdjustLtvTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AdjustLtvFlexibleLoanAdjustLtvTrade(AdjustLtvFlexibleLoanAdjustLtvTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AdjustmentAmount`, `Direction`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `adjustmentAmount` ← `AdjustmentAmount`, `direction` ← `Direction`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2LoanFlexibleAdjustLtvResponse`
- **Error**: `ApiException<AdjustLtvFlexibleLoanAdjustLtvTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AdjustLtvFlexibleLoanAdjustLtvTradeRequest` | `Requests/CryptoLoans/AdjustLtvFlexibleLoanAdjustLtvTradeRequest.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `SapiV2LoanFlexibleAdjustLtvResponse` | `Models/SapiV2LoanFlexibleAdjustLtvResponse.cs` |
| `AdjustLtvFlexibleLoanAdjustLtvTradeError` | `Errors/AdjustLtvFlexibleLoanAdjustLtvTradeError.cs` |
| `Error` | `Models/Error.cs` |

### AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData(AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2LoanFlexibleLtvAdjustmentHistoryResponse`
- **Error**: `ApiException<AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest` | `Requests/CryptoLoans/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest.cs` |
| `SapiV2LoanFlexibleLtvAdjustmentHistoryResponse` | `Models/SapiV2LoanFlexibleLtvAdjustmentHistoryResponse.cs` |
| `AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError` | `Errors/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### BorrowFlexibleLoanBorrowTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BorrowFlexibleLoanBorrowTrade(BorrowFlexibleLoanBorrowTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `loanAmount` ← `LoanAmount`, `collateralCoin` ← `CollateralCoin`, `collateralAmount` ← `CollateralAmount`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2LoanFlexibleBorrowResponse`
- **Error**: `ApiException<BorrowFlexibleLoanBorrowTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BorrowFlexibleLoanBorrowTradeRequest` | `Requests/CryptoLoans/BorrowFlexibleLoanBorrowTradeRequest.cs` |
| `SapiV2LoanFlexibleBorrowResponse` | `Models/SapiV2LoanFlexibleBorrowResponse.cs` |
| `BorrowFlexibleLoanBorrowTradeError` | `Errors/BorrowFlexibleLoanBorrowTradeError.cs` |
| `Error` | `Models/Error.cs` |

### BorrowGetFlexibleLoanBorrowHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BorrowGetFlexibleLoanBorrowHistoryUserData(BorrowGetFlexibleLoanBorrowHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2LoanFlexibleBorrowHistoryResponse`
- **Error**: `ApiException<BorrowGetFlexibleLoanBorrowHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BorrowGetFlexibleLoanBorrowHistoryUserDataRequest` | `Requests/CryptoLoans/BorrowGetFlexibleLoanBorrowHistoryUserDataRequest.cs` |
| `SapiV2LoanFlexibleBorrowHistoryResponse` | `Models/SapiV2LoanFlexibleBorrowHistoryResponse.cs` |
| `BorrowGetFlexibleLoanBorrowHistoryUserDataError` | `Errors/BorrowGetFlexibleLoanBorrowHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### BorrowGetFlexibleLoanOngoingOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BorrowGetFlexibleLoanOngoingOrdersUserData(BorrowGetFlexibleLoanOngoingOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2LoanFlexibleOngoingOrdersResponse`
- **Error**: `ApiException<BorrowGetFlexibleLoanOngoingOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BorrowGetFlexibleLoanOngoingOrdersUserDataRequest` | `Requests/CryptoLoans/BorrowGetFlexibleLoanOngoingOrdersUserDataRequest.cs` |
| `SapiV2LoanFlexibleOngoingOrdersResponse` | `Models/SapiV2LoanFlexibleOngoingOrdersResponse.cs` |
| `BorrowGetFlexibleLoanOngoingOrdersUserDataError` | `Errors/BorrowGetFlexibleLoanOngoingOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### CheckCollateralRepayRateUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CheckCollateralRepayRateUserData(CheckCollateralRepayRateUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LoanCoin`, `CollateralCoin`, `RepayAmount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `repayAmount` ← `RepayAmount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanRepayCollateralRateResponse`
- **Error**: `ApiException<CheckCollateralRepayRateUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckCollateralRepayRateUserDataRequest` | `Requests/CryptoLoans/CheckCollateralRepayRateUserDataRequest.cs` |
| `SapiV1LoanRepayCollateralRateResponse` | `Models/SapiV1LoanRepayCollateralRateResponse.cs` |
| `CheckCollateralRepayRateUserDataError` | `Errors/CheckCollateralRepayRateUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### CryptoLoanAdjustLtvTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CryptoLoanAdjustLtvTrade(CryptoLoanAdjustLtvTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`, `Amount`, `Direction`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `orderId` ← `OrderId`, `amount` ← `Amount`, `direction` ← `Direction`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanAdjustLtvResponse`
- **Error**: `ApiException<CryptoLoanAdjustLtvTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CryptoLoanAdjustLtvTradeRequest` | `Requests/CryptoLoans/CryptoLoanAdjustLtvTradeRequest.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `SapiV1LoanAdjustLtvResponse` | `Models/SapiV1LoanAdjustLtvResponse.cs` |
| `CryptoLoanAdjustLtvTradeError` | `Errors/CryptoLoanAdjustLtvTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CryptoLoanBorrowTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CryptoLoanBorrowTrade(CryptoLoanBorrowTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LoanCoin`, `CollateralCoin`, `LoanTerm`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `loanTerm` ← `LoanTerm`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanAmount` ← `LoanAmount`, `collateralAmount` ← `CollateralAmount`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanBorrowResponse`
- **Error**: `ApiException<CryptoLoanBorrowTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CryptoLoanBorrowTradeRequest` | `Requests/CryptoLoans/CryptoLoanBorrowTradeRequest.cs` |
| `SapiV1LoanBorrowResponse` | `Models/SapiV1LoanBorrowResponse.cs` |
| `CryptoLoanBorrowTradeError` | `Errors/CryptoLoanBorrowTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CryptoLoanCustomizeMarginCallTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CryptoLoanCustomizeMarginCallTrade(CryptoLoanCustomizeMarginCallTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MarginCall`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `marginCall` ← `MarginCall`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `collateralCoin` ← `CollateralCoin`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanCustomizeMarginCallResponse`
- **Error**: `ApiException<CryptoLoanCustomizeMarginCallTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CryptoLoanCustomizeMarginCallTradeRequest` | `Requests/CryptoLoans/CryptoLoanCustomizeMarginCallTradeRequest.cs` |
| `SapiV1LoanCustomizeMarginCallResponse` | `Models/SapiV1LoanCustomizeMarginCallResponse.cs` |
| `CryptoLoanCustomizeMarginCallTradeError` | `Errors/CryptoLoanCustomizeMarginCallTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CryptoLoanRepayTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CryptoLoanRepayTrade(CryptoLoanRepayTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `orderId` ← `OrderId`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `type` ← `Type`, `collateralReturn` ← `CollateralReturn`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanRepayResponse`
- **Error**: `ApiException<CryptoLoanRepayTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CryptoLoanRepayTradeRequest` | `Requests/CryptoLoans/CryptoLoanRepayTradeRequest.cs` |
| `SapiV1LoanRepayResponse` | `Models/AnyOf/SapiV1LoanRepayResponse.cs` |
| `CryptoLoanRepayTradeError` | `Errors/CryptoLoanRepayTradeError.cs` |
| `Error` | `Models/Error.cs` |

### GetCollateralAssetsDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCollateralAssetsDataUserData(GetCollateralAssetsDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `collateralCoin` ← `CollateralCoin`, `vipLevel` ← `VipLevel`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanCollateralDataResponse`
- **Error**: `ApiException<GetCollateralAssetsDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCollateralAssetsDataUserDataRequest` | `Requests/CryptoLoans/GetCollateralAssetsDataUserDataRequest.cs` |
| `SapiV1LoanCollateralDataResponse` | `Models/SapiV1LoanCollateralDataResponse.cs` |
| `GetCollateralAssetsDataUserDataError` | `Errors/GetCollateralAssetsDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCryptoLoansBorrowHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCryptoLoansBorrowHistoryUserData(GetCryptoLoansBorrowHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanBorrowHistoryResponse`
- **Error**: `ApiException<GetCryptoLoansBorrowHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCryptoLoansBorrowHistoryUserDataRequest` | `Requests/CryptoLoans/GetCryptoLoansBorrowHistoryUserDataRequest.cs` |
| `SapiV1LoanBorrowHistoryResponse` | `Models/SapiV1LoanBorrowHistoryResponse.cs` |
| `GetCryptoLoansBorrowHistoryUserDataError` | `Errors/GetCryptoLoansBorrowHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCryptoLoansIncomeHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCryptoLoansIncomeHistoryUserData(GetCryptoLoansIncomeHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `type` ← `Type`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1LoanIncomeResponse>`
- **Error**: `ApiException<GetCryptoLoansIncomeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCryptoLoansIncomeHistoryUserDataRequest` | `Requests/CryptoLoans/GetCryptoLoansIncomeHistoryUserDataRequest.cs` |
| `Type9` | `Models/Enums/Type9.cs` |
| `SapiV1LoanIncomeResponse` | `Models/SapiV1LoanIncomeResponse.cs` |
| `GetCryptoLoansIncomeHistoryUserDataError` | `Errors/GetCryptoLoansIncomeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleLoanAssetsDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleLoanAssetsDataUserData(GetFlexibleLoanAssetsDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2LoanFlexibleLoanableDataResponse`
- **Error**: `ApiException<GetFlexibleLoanAssetsDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFlexibleLoanAssetsDataUserDataRequest` | `Requests/CryptoLoans/GetFlexibleLoanAssetsDataUserDataRequest.cs` |
| `SapiV2LoanFlexibleLoanableDataResponse` | `Models/SapiV2LoanFlexibleLoanableDataResponse.cs` |
| `GetFlexibleLoanAssetsDataUserDataError` | `Errors/GetFlexibleLoanAssetsDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleLoanCollateralAssetsDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleLoanCollateralAssetsDataUserData(GetFlexibleLoanCollateralAssetsDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `collateralCoin` ← `CollateralCoin`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2LoanFlexibleCollateralDataResponse`
- **Error**: `ApiException<GetFlexibleLoanCollateralAssetsDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFlexibleLoanCollateralAssetsDataUserDataRequest` | `Requests/CryptoLoans/GetFlexibleLoanCollateralAssetsDataUserDataRequest.cs` |
| `SapiV2LoanFlexibleCollateralDataResponse` | `Models/SapiV2LoanFlexibleCollateralDataResponse.cs` |
| `GetFlexibleLoanCollateralAssetsDataUserDataError` | `Errors/GetFlexibleLoanCollateralAssetsDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanLtvAdjustmentHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLoanLtvAdjustmentHistoryUserData(GetLoanLtvAdjustmentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanLtvAdjustmentHistoryResponse`
- **Error**: `ApiException<GetLoanLtvAdjustmentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLoanLtvAdjustmentHistoryUserDataRequest` | `Requests/CryptoLoans/GetLoanLtvAdjustmentHistoryUserDataRequest.cs` |
| `SapiV1LoanLtvAdjustmentHistoryResponse` | `Models/SapiV1LoanLtvAdjustmentHistoryResponse.cs` |
| `GetLoanLtvAdjustmentHistoryUserDataError` | `Errors/GetLoanLtvAdjustmentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanOngoingOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLoanOngoingOrdersUserData(GetLoanOngoingOrdersUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanOngoingOrdersResponse`
- **Error**: `ApiException<GetLoanOngoingOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLoanOngoingOrdersUserDataRequest` | `Requests/CryptoLoans/GetLoanOngoingOrdersUserDataRequest.cs` |
| `SapiV1LoanOngoingOrdersResponse` | `Models/SapiV1LoanOngoingOrdersResponse.cs` |
| `GetLoanOngoingOrdersUserDataError` | `Errors/GetLoanOngoingOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanRepaymentHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLoanRepaymentHistoryUserData(GetLoanRepaymentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `orderId` ← `OrderId`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanRepayHistoryResponse`
- **Error**: `ApiException<GetLoanRepaymentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLoanRepaymentHistoryUserDataRequest` | `Requests/CryptoLoans/GetLoanRepaymentHistoryUserDataRequest.cs` |
| `SapiV1LoanRepayHistoryResponse` | `Models/SapiV1LoanRepayHistoryResponse.cs` |
| `GetLoanRepaymentHistoryUserDataError` | `Errors/GetLoanRepaymentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanableAssetsDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLoanableAssetsDataUserData(GetLoanableAssetsDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `vipLevel` ← `VipLevel`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1LoanLoanableDataResponse`
- **Error**: `ApiException<GetLoanableAssetsDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLoanableAssetsDataUserDataRequest` | `Requests/CryptoLoans/GetLoanableAssetsDataUserDataRequest.cs` |
| `SapiV1LoanLoanableDataResponse` | `Models/SapiV1LoanLoanableDataResponse.cs` |
| `GetLoanableAssetsDataUserDataError` | `Errors/GetLoanableAssetsDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RepayFlexibleLoanRepayTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RepayFlexibleLoanRepayTrade(RepayFlexibleLoanRepayTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RepayAmount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `repayAmount` ← `RepayAmount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `collateralReturn` ← `CollateralReturn`, `fullRepayment` ← `FullRepayment`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2LoanFlexibleRepayResponse`
- **Error**: `ApiException<RepayFlexibleLoanRepayTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RepayFlexibleLoanRepayTradeRequest` | `Requests/CryptoLoans/RepayFlexibleLoanRepayTradeRequest.cs` |
| `SapiV2LoanFlexibleRepayResponse` | `Models/SapiV2LoanFlexibleRepayResponse.cs` |
| `RepayFlexibleLoanRepayTradeError` | `Errors/RepayFlexibleLoanRepayTradeError.cs` |
| `Error` | `Models/Error.cs` |

### RepayGetFlexibleLoanRepaymentHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RepayGetFlexibleLoanRepaymentHistoryUserData(RepayGetFlexibleLoanRepaymentHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `loanCoin` ← `LoanCoin`, `collateralCoin` ← `CollateralCoin`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2LoanFlexibleRepayHistoryResponse`
- **Error**: `ApiException<RepayGetFlexibleLoanRepaymentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RepayGetFlexibleLoanRepaymentHistoryUserDataRequest` | `Requests/CryptoLoans/RepayGetFlexibleLoanRepaymentHistoryUserDataRequest.cs` |
| `SapiV2LoanFlexibleRepayHistoryResponse` | `Models/SapiV2LoanFlexibleRepayHistoryResponse.cs` |
| `RepayGetFlexibleLoanRepaymentHistoryUserDataError` | `Errors/RepayGetFlexibleLoanRepaymentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

