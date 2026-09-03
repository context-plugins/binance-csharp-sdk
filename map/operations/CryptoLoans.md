<!-- Generated file — do not edit; regenerated with the SDK. -->

# CryptoLoans — operations

Accessor: `client.CryptoLoans` · Source: `Api/CryptoLoans.cs` · 21 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdjustLtvFlexibleLoanAdjustLtvTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AdjustLtvFlexibleLoanAdjustLtvTrade(double adjustmentAmount, Direction direction, long timestamp, string signature, string? loanCoin, string? collateralCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `loanCoin` — nullable, no default → **must pass explicitly**
  - `collateralCoin` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `adjustmentAmount` ← `adjustmentAmount`, `direction` ← `direction`, `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2LoanFlexibleAdjustLtvResponse`
- **Error**: `SdkException<AdjustLtvFlexibleLoanAdjustLtvTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `SapiV2LoanFlexibleAdjustLtvResponse` | `Models/SapiV2LoanFlexibleAdjustLtvResponse.cs` |
| `AdjustLtvFlexibleLoanAdjustLtvTradeError` | `Errors/AdjustLtvFlexibleLoanAdjustLtvTradeError.cs` |
| `Error` | `Models/Error.cs` |

### AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData(long timestamp, string signature, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`loanCoin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2LoanFlexibleLtvAdjustmentHistoryResponse`
- **Error**: `SdkException<AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2LoanFlexibleLtvAdjustmentHistoryResponse` | `Models/SapiV2LoanFlexibleLtvAdjustmentHistoryResponse.cs` |
| `AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError` | `Errors/AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### BorrowFlexibleLoanBorrowTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BorrowFlexibleLoanBorrowTrade(long timestamp, string signature, string? loanCoin, double? loanAmount, string? collateralCoin, double? collateralAmount, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`loanCoin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `loanAmount` ← `loanAmount`, `collateralCoin` ← `collateralCoin`, `collateralAmount` ← `collateralAmount`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2LoanFlexibleBorrowResponse`
- **Error**: `SdkException<BorrowFlexibleLoanBorrowTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2LoanFlexibleBorrowResponse` | `Models/SapiV2LoanFlexibleBorrowResponse.cs` |
| `BorrowFlexibleLoanBorrowTradeError` | `Errors/BorrowFlexibleLoanBorrowTradeError.cs` |
| `Error` | `Models/Error.cs` |

### BorrowGetFlexibleLoanBorrowHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BorrowGetFlexibleLoanBorrowHistoryUserData(long timestamp, string signature, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`loanCoin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2LoanFlexibleBorrowHistoryResponse`
- **Error**: `SdkException<BorrowGetFlexibleLoanBorrowHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2LoanFlexibleBorrowHistoryResponse` | `Models/SapiV2LoanFlexibleBorrowHistoryResponse.cs` |
| `BorrowGetFlexibleLoanBorrowHistoryUserDataError` | `Errors/BorrowGetFlexibleLoanBorrowHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### BorrowGetFlexibleLoanOngoingOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BorrowGetFlexibleLoanOngoingOrdersUserData(long timestamp, string signature, string? loanCoin, string? collateralCoin, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`loanCoin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2LoanFlexibleOngoingOrdersResponse`
- **Error**: `SdkException<BorrowGetFlexibleLoanOngoingOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2LoanFlexibleOngoingOrdersResponse` | `Models/SapiV2LoanFlexibleOngoingOrdersResponse.cs` |
| `BorrowGetFlexibleLoanOngoingOrdersUserDataError` | `Errors/BorrowGetFlexibleLoanOngoingOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### CheckCollateralRepayRateUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CheckCollateralRepayRateUserData(string loanCoin, string collateralCoin, double repayAmount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `repayAmount` ← `repayAmount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanRepayCollateralRateResponse`
- **Error**: `SdkException<CheckCollateralRepayRateUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanRepayCollateralRateResponse` | `Models/SapiV1LoanRepayCollateralRateResponse.cs` |
| `CheckCollateralRepayRateUserDataError` | `Errors/CheckCollateralRepayRateUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### CryptoLoanAdjustLtvTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CryptoLoanAdjustLtvTrade(long orderId, double amount, Direction direction, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `orderId` ← `orderId`, `amount` ← `amount`, `direction` ← `direction`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanAdjustLtvResponse`
- **Error**: `SdkException<CryptoLoanAdjustLtvTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `SapiV1LoanAdjustLtvResponse` | `Models/SapiV1LoanAdjustLtvResponse.cs` |
| `CryptoLoanAdjustLtvTradeError` | `Errors/CryptoLoanAdjustLtvTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CryptoLoanBorrowTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CryptoLoanBorrowTrade(string loanCoin, string collateralCoin, int loanTerm, long timestamp, string signature, double? loanAmount, double? collateralAmount, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `loanAmount` — nullable, no default → **must pass explicitly**
  - `collateralAmount` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `loanTerm` ← `loanTerm`, `timestamp` ← `timestamp`, `signature` ← `signature`, `loanAmount` ← `loanAmount`, `collateralAmount` ← `collateralAmount`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanBorrowResponse`
- **Error**: `SdkException<CryptoLoanBorrowTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanBorrowResponse` | `Models/SapiV1LoanBorrowResponse.cs` |
| `CryptoLoanBorrowTradeError` | `Errors/CryptoLoanBorrowTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CryptoLoanCustomizeMarginCallTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CryptoLoanCustomizeMarginCallTrade(double marginCall, long timestamp, string signature, long? orderId, string? collateralCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `orderId` — nullable, no default → **must pass explicitly**
  - `collateralCoin` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `marginCall` ← `marginCall`, `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `collateralCoin` ← `collateralCoin`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanCustomizeMarginCallResponse`
- **Error**: `SdkException<CryptoLoanCustomizeMarginCallTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanCustomizeMarginCallResponse` | `Models/SapiV1LoanCustomizeMarginCallResponse.cs` |
| `CryptoLoanCustomizeMarginCallTradeError` | `Errors/CryptoLoanCustomizeMarginCallTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CryptoLoanRepayTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CryptoLoanRepayTrade(long orderId, double amount, long timestamp, string signature, int? type, bool? collateralReturn, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `type` — nullable, no default → **must pass explicitly**
  - `collateralReturn` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `orderId` ← `orderId`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `type` ← `type`, `collateralReturn` ← `collateralReturn`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanRepayResponse`
- **Error**: `SdkException<CryptoLoanRepayTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanRepayResponse` | `Models/AnyOf/SapiV1LoanRepayResponse.cs` |
| `CryptoLoanRepayTradeError` | `Errors/CryptoLoanRepayTradeError.cs` |
| `Error` | `Models/Error.cs` |

### GetCollateralAssetsDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCollateralAssetsDataUserData(long timestamp, string signature, string? collateralCoin, int? vipLevel, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `collateralCoin` — nullable, no default → **must pass explicitly**
  - `vipLevel` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `collateralCoin` ← `collateralCoin`, `vipLevel` ← `vipLevel`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanCollateralDataResponse`
- **Error**: `SdkException<GetCollateralAssetsDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanCollateralDataResponse` | `Models/SapiV1LoanCollateralDataResponse.cs` |
| `GetCollateralAssetsDataUserDataError` | `Errors/GetCollateralAssetsDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCryptoLoansBorrowHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCryptoLoansBorrowHistoryUserData(long timestamp, string signature, long? orderId, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`orderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanBorrowHistoryResponse`
- **Error**: `SdkException<GetCryptoLoansBorrowHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanBorrowHistoryResponse` | `Models/SapiV1LoanBorrowHistoryResponse.cs` |
| `GetCryptoLoansBorrowHistoryUserDataError` | `Errors/GetCryptoLoansBorrowHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCryptoLoansIncomeHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCryptoLoansIncomeHistoryUserData(long timestamp, string signature, string? asset, Type9? type, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `type` ← `type`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1LoanIncomeResponse>`
- **Error**: `SdkException<GetCryptoLoansIncomeHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type9` | `Models/Enums/Type9.cs` |
| `SapiV1LoanIncomeResponse` | `Models/SapiV1LoanIncomeResponse.cs` |
| `GetCryptoLoansIncomeHistoryUserDataError` | `Errors/GetCryptoLoansIncomeHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleLoanAssetsDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleLoanAssetsDataUserData(long timestamp, string signature, string? loanCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `loanCoin` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2LoanFlexibleLoanableDataResponse`
- **Error**: `SdkException<GetFlexibleLoanAssetsDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2LoanFlexibleLoanableDataResponse` | `Models/SapiV2LoanFlexibleLoanableDataResponse.cs` |
| `GetFlexibleLoanAssetsDataUserDataError` | `Errors/GetFlexibleLoanAssetsDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetFlexibleLoanCollateralAssetsDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetFlexibleLoanCollateralAssetsDataUserData(long timestamp, string signature, string? collateralCoin, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `collateralCoin` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `collateralCoin` ← `collateralCoin`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2LoanFlexibleCollateralDataResponse`
- **Error**: `SdkException<GetFlexibleLoanCollateralAssetsDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2LoanFlexibleCollateralDataResponse` | `Models/SapiV2LoanFlexibleCollateralDataResponse.cs` |
| `GetFlexibleLoanCollateralAssetsDataUserDataError` | `Errors/GetFlexibleLoanCollateralAssetsDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanLtvAdjustmentHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLoanLtvAdjustmentHistoryUserData(long timestamp, string signature, long? orderId, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`orderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanLtvAdjustmentHistoryResponse`
- **Error**: `SdkException<GetLoanLtvAdjustmentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanLtvAdjustmentHistoryResponse` | `Models/SapiV1LoanLtvAdjustmentHistoryResponse.cs` |
| `GetLoanLtvAdjustmentHistoryUserDataError` | `Errors/GetLoanLtvAdjustmentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanOngoingOrdersUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLoanOngoingOrdersUserData(long timestamp, string signature, long? orderId, string? loanCoin, string? collateralCoin, int? current, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`orderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanOngoingOrdersResponse`
- **Error**: `SdkException<GetLoanOngoingOrdersUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanOngoingOrdersResponse` | `Models/SapiV1LoanOngoingOrdersResponse.cs` |
| `GetLoanOngoingOrdersUserDataError` | `Errors/GetLoanOngoingOrdersUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanRepaymentHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLoanRepaymentHistoryUserData(long timestamp, string signature, long? orderId, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, long? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`orderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `orderId` ← `orderId`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanRepayHistoryResponse`
- **Error**: `SdkException<GetLoanRepaymentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanRepayHistoryResponse` | `Models/SapiV1LoanRepayHistoryResponse.cs` |
| `GetLoanRepaymentHistoryUserDataError` | `Errors/GetLoanRepaymentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetLoanableAssetsDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetLoanableAssetsDataUserData(long timestamp, string signature, string? loanCoin, int? vipLevel, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `loanCoin` — nullable, no default → **must pass explicitly**
  - `vipLevel` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `vipLevel` ← `vipLevel`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1LoanLoanableDataResponse`
- **Error**: `SdkException<GetLoanableAssetsDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1LoanLoanableDataResponse` | `Models/SapiV1LoanLoanableDataResponse.cs` |
| `GetLoanableAssetsDataUserDataError` | `Errors/GetLoanableAssetsDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RepayFlexibleLoanRepayTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RepayFlexibleLoanRepayTrade(double repayAmount, long timestamp, string signature, string? loanCoin, string? collateralCoin, bool? collateralReturn, bool? fullRepayment, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`loanCoin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `repayAmount` ← `repayAmount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `collateralReturn` ← `collateralReturn`, `fullRepayment` ← `fullRepayment`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2LoanFlexibleRepayResponse`
- **Error**: `SdkException<RepayFlexibleLoanRepayTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2LoanFlexibleRepayResponse` | `Models/SapiV2LoanFlexibleRepayResponse.cs` |
| `RepayFlexibleLoanRepayTradeError` | `Errors/RepayFlexibleLoanRepayTradeError.cs` |
| `Error` | `Models/Error.cs` |

### RepayGetFlexibleLoanRepaymentHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RepayGetFlexibleLoanRepaymentHistoryUserData(long timestamp, string signature, string? loanCoin, string? collateralCoin, long? startTime, long? endTime, int? current, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`loanCoin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `loanCoin` ← `loanCoin`, `collateralCoin` ← `collateralCoin`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2LoanFlexibleRepayHistoryResponse`
- **Error**: `SdkException<RepayGetFlexibleLoanRepaymentHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2LoanFlexibleRepayHistoryResponse` | `Models/SapiV2LoanFlexibleRepayHistoryResponse.cs` |
| `RepayGetFlexibleLoanRepaymentHistoryUserDataError` | `Errors/RepayGetFlexibleLoanRepaymentHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

