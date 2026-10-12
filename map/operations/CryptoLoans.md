<!-- Generated file — do not edit; regenerated with the SDK. -->

# CryptoLoans — operations

Accessor: `client.CryptoLoans` · Source: `src/Binance/Api/CryptoLoans.cs` · 21 operations

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
| `AdjustLtvFlexibleLoanAdjustLtvTradeRequest` | `src/Binance/Requests/CryptoLoans/AdjustLtvFlexibleLoanAdjustLtvTradeRequest.cs` |
| `Direction` | `src/Binance/Models/Enums/Direction.cs` |
| `SapiV2LoanFlexibleAdjustLtvResponse` | `src/Binance/Models/SapiV2LoanFlexibleAdjustLtvResponse.cs` |
| `AdjustLtvFlexibleLoanAdjustLtvTradeError` | `src/Binance/Errors/AdjustLtvFlexibleLoanAdjustLtvTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest` | `src/Binance/Requests/CryptoLoans/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest.cs` |
| `SapiV2LoanFlexibleLtvAdjustmentHistoryResponse` | `src/Binance/Models/SapiV2LoanFlexibleLtvAdjustmentHistoryResponse.cs` |
| `AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError` | `src/Binance/Errors/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `BorrowFlexibleLoanBorrowTradeRequest` | `src/Binance/Requests/CryptoLoans/BorrowFlexibleLoanBorrowTradeRequest.cs` |
| `SapiV2LoanFlexibleBorrowResponse` | `src/Binance/Models/SapiV2LoanFlexibleBorrowResponse.cs` |
| `BorrowFlexibleLoanBorrowTradeError` | `src/Binance/Errors/BorrowFlexibleLoanBorrowTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `BorrowGetFlexibleLoanBorrowHistoryUserDataRequest` | `src/Binance/Requests/CryptoLoans/BorrowGetFlexibleLoanBorrowHistoryUserDataRequest.cs` |
| `SapiV2LoanFlexibleBorrowHistoryResponse` | `src/Binance/Models/SapiV2LoanFlexibleBorrowHistoryResponse.cs` |
| `BorrowGetFlexibleLoanBorrowHistoryUserDataError` | `src/Binance/Errors/BorrowGetFlexibleLoanBorrowHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `BorrowGetFlexibleLoanOngoingOrdersUserDataRequest` | `src/Binance/Requests/CryptoLoans/BorrowGetFlexibleLoanOngoingOrdersUserDataRequest.cs` |
| `SapiV2LoanFlexibleOngoingOrdersResponse` | `src/Binance/Models/SapiV2LoanFlexibleOngoingOrdersResponse.cs` |
| `BorrowGetFlexibleLoanOngoingOrdersUserDataError` | `src/Binance/Errors/BorrowGetFlexibleLoanOngoingOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `CheckCollateralRepayRateUserDataRequest` | `src/Binance/Requests/CryptoLoans/CheckCollateralRepayRateUserDataRequest.cs` |
| `SapiV1LoanRepayCollateralRateResponse` | `src/Binance/Models/SapiV1LoanRepayCollateralRateResponse.cs` |
| `CheckCollateralRepayRateUserDataError` | `src/Binance/Errors/CheckCollateralRepayRateUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `CryptoLoanAdjustLtvTradeRequest` | `src/Binance/Requests/CryptoLoans/CryptoLoanAdjustLtvTradeRequest.cs` |
| `Direction` | `src/Binance/Models/Enums/Direction.cs` |
| `SapiV1LoanAdjustLtvResponse` | `src/Binance/Models/SapiV1LoanAdjustLtvResponse.cs` |
| `CryptoLoanAdjustLtvTradeError` | `src/Binance/Errors/CryptoLoanAdjustLtvTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `CryptoLoanBorrowTradeRequest` | `src/Binance/Requests/CryptoLoans/CryptoLoanBorrowTradeRequest.cs` |
| `SapiV1LoanBorrowResponse` | `src/Binance/Models/SapiV1LoanBorrowResponse.cs` |
| `CryptoLoanBorrowTradeError` | `src/Binance/Errors/CryptoLoanBorrowTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `CryptoLoanCustomizeMarginCallTradeRequest` | `src/Binance/Requests/CryptoLoans/CryptoLoanCustomizeMarginCallTradeRequest.cs` |
| `SapiV1LoanCustomizeMarginCallResponse` | `src/Binance/Models/SapiV1LoanCustomizeMarginCallResponse.cs` |
| `CryptoLoanCustomizeMarginCallTradeError` | `src/Binance/Errors/CryptoLoanCustomizeMarginCallTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `CryptoLoanRepayTradeRequest` | `src/Binance/Requests/CryptoLoans/CryptoLoanRepayTradeRequest.cs` |
| `SapiV1LoanRepayResponse` | `src/Binance/Models/AnyOf/SapiV1LoanRepayResponse.cs` |
| `CryptoLoanRepayTradeError` | `src/Binance/Errors/CryptoLoanRepayTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetCollateralAssetsDataUserDataRequest` | `src/Binance/Requests/CryptoLoans/GetCollateralAssetsDataUserDataRequest.cs` |
| `SapiV1LoanCollateralDataResponse` | `src/Binance/Models/SapiV1LoanCollateralDataResponse.cs` |
| `GetCollateralAssetsDataUserDataError` | `src/Binance/Errors/GetCollateralAssetsDataUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetCryptoLoansBorrowHistoryUserDataRequest` | `src/Binance/Requests/CryptoLoans/GetCryptoLoansBorrowHistoryUserDataRequest.cs` |
| `SapiV1LoanBorrowHistoryResponse` | `src/Binance/Models/SapiV1LoanBorrowHistoryResponse.cs` |
| `GetCryptoLoansBorrowHistoryUserDataError` | `src/Binance/Errors/GetCryptoLoansBorrowHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetCryptoLoansIncomeHistoryUserDataRequest` | `src/Binance/Requests/CryptoLoans/GetCryptoLoansIncomeHistoryUserDataRequest.cs` |
| `Type9` | `src/Binance/Models/Enums/Type9.cs` |
| `SapiV1LoanIncomeResponse` | `src/Binance/Models/SapiV1LoanIncomeResponse.cs` |
| `GetCryptoLoansIncomeHistoryUserDataError` | `src/Binance/Errors/GetCryptoLoansIncomeHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetFlexibleLoanAssetsDataUserDataRequest` | `src/Binance/Requests/CryptoLoans/GetFlexibleLoanAssetsDataUserDataRequest.cs` |
| `SapiV2LoanFlexibleLoanableDataResponse` | `src/Binance/Models/SapiV2LoanFlexibleLoanableDataResponse.cs` |
| `GetFlexibleLoanAssetsDataUserDataError` | `src/Binance/Errors/GetFlexibleLoanAssetsDataUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetFlexibleLoanCollateralAssetsDataUserDataRequest` | `src/Binance/Requests/CryptoLoans/GetFlexibleLoanCollateralAssetsDataUserDataRequest.cs` |
| `SapiV2LoanFlexibleCollateralDataResponse` | `src/Binance/Models/SapiV2LoanFlexibleCollateralDataResponse.cs` |
| `GetFlexibleLoanCollateralAssetsDataUserDataError` | `src/Binance/Errors/GetFlexibleLoanCollateralAssetsDataUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLoanLtvAdjustmentHistoryUserDataRequest` | `src/Binance/Requests/CryptoLoans/GetLoanLtvAdjustmentHistoryUserDataRequest.cs` |
| `SapiV1LoanLtvAdjustmentHistoryResponse` | `src/Binance/Models/SapiV1LoanLtvAdjustmentHistoryResponse.cs` |
| `GetLoanLtvAdjustmentHistoryUserDataError` | `src/Binance/Errors/GetLoanLtvAdjustmentHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLoanOngoingOrdersUserDataRequest` | `src/Binance/Requests/CryptoLoans/GetLoanOngoingOrdersUserDataRequest.cs` |
| `SapiV1LoanOngoingOrdersResponse` | `src/Binance/Models/SapiV1LoanOngoingOrdersResponse.cs` |
| `GetLoanOngoingOrdersUserDataError` | `src/Binance/Errors/GetLoanOngoingOrdersUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLoanRepaymentHistoryUserDataRequest` | `src/Binance/Requests/CryptoLoans/GetLoanRepaymentHistoryUserDataRequest.cs` |
| `SapiV1LoanRepayHistoryResponse` | `src/Binance/Models/SapiV1LoanRepayHistoryResponse.cs` |
| `GetLoanRepaymentHistoryUserDataError` | `src/Binance/Errors/GetLoanRepaymentHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetLoanableAssetsDataUserDataRequest` | `src/Binance/Requests/CryptoLoans/GetLoanableAssetsDataUserDataRequest.cs` |
| `SapiV1LoanLoanableDataResponse` | `src/Binance/Models/SapiV1LoanLoanableDataResponse.cs` |
| `GetLoanableAssetsDataUserDataError` | `src/Binance/Errors/GetLoanableAssetsDataUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `RepayFlexibleLoanRepayTradeRequest` | `src/Binance/Requests/CryptoLoans/RepayFlexibleLoanRepayTradeRequest.cs` |
| `SapiV2LoanFlexibleRepayResponse` | `src/Binance/Models/SapiV2LoanFlexibleRepayResponse.cs` |
| `RepayFlexibleLoanRepayTradeError` | `src/Binance/Errors/RepayFlexibleLoanRepayTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `RepayGetFlexibleLoanRepaymentHistoryUserDataRequest` | `src/Binance/Requests/CryptoLoans/RepayGetFlexibleLoanRepaymentHistoryUserDataRequest.cs` |
| `SapiV2LoanFlexibleRepayHistoryResponse` | `src/Binance/Models/SapiV2LoanFlexibleRepayHistoryResponse.cs` |
| `RepayGetFlexibleLoanRepaymentHistoryUserDataError` | `src/Binance/Errors/RepayGetFlexibleLoanRepaymentHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

