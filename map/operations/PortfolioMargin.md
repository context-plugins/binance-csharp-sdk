<!-- Generated file — do not edit; regenerated with the SDK. -->

# PortfolioMargin — operations

Accessor: `client.PortfolioMargin` · Source: `Api/PortfolioMargin.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BnbTransferUserData

- **Signature**: `BnbTransferUserData(TransferSide transferSide, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `transferSide` ← `transferSide`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PortfolioBnbTransferResponse`
- **Error**: `SdkException<BnbTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TransferSide` | `Models/Enums/TransferSide.cs` |
| `SapiV1PortfolioBnbTransferResponse` | `Models/SapiV1PortfolioBnbTransferResponse.cs` |
| `BnbTransferUserDataError` | `Errors/BnbTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### ChangeAutoRepayFuturesStatusUserData

- **Signature**: `ChangeAutoRepayFuturesStatusUserData(bool autoRepay, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `autoRepay` ← `autoRepay`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PortfolioRepayFuturesSwitchResponse`
- **Error**: `SdkException<ChangeAutoRepayFuturesStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioRepayFuturesSwitchResponse` | `Models/SapiV1PortfolioRepayFuturesSwitchResponse.cs` |
| `ChangeAutoRepayFuturesStatusUserDataError` | `Errors/ChangeAutoRepayFuturesStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FundAutoCollectionUserData

- **Signature**: `FundAutoCollectionUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PortfolioAutoCollectionResponse`
- **Error**: `SdkException<FundAutoCollectionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioAutoCollectionResponse` | `Models/SapiV1PortfolioAutoCollectionResponse.cs` |
| `FundAutoCollectionUserDataError` | `Errors/FundAutoCollectionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FundCollectionByAssetUserData

- **Signature**: `FundCollectionByAssetUserData(string asset, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `asset` ← `asset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PortfolioAssetCollectionResponse`
- **Error**: `SdkException<FundCollectionByAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioAssetCollectionResponse` | `Models/SapiV1PortfolioAssetCollectionResponse.cs` |
| `FundCollectionByAssetUserDataError` | `Errors/FundCollectionByAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetAutoRepayFuturesStatusUserData

- **Signature**: `GetAutoRepayFuturesStatusUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PortfolioRepayFuturesSwitchResponse1`
- **Error**: `SdkException<GetAutoRepayFuturesStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioRepayFuturesSwitchResponse1` | `Models/SapiV1PortfolioRepayFuturesSwitchResponse1.cs` |
| `GetAutoRepayFuturesStatusUserDataError` | `Errors/GetAutoRepayFuturesStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetPortfolioMarginAssetLeverageUserData

- **Signature**: `GetPortfolioMarginAssetLeverageUserData(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<SapiV1PortfolioMarginAssetLeverageResponse>`
- **Error**: `SdkException<GetPortfolioMarginAssetLeverageUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioMarginAssetLeverageResponse` | `Models/SapiV1PortfolioMarginAssetLeverageResponse.cs` |
| `GetPortfolioMarginAssetLeverageUserDataError` | `Errors/GetPortfolioMarginAssetLeverageUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginAccountUserData

- **Signature**: `PortfolioMarginAccountUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PortfolioAccountResponse`
- **Error**: `SdkException<PortfolioMarginAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioAccountResponse` | `Models/SapiV1PortfolioAccountResponse.cs` |
| `PortfolioMarginAccountUserDataError` | `Errors/PortfolioMarginAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginBankruptcyLoanAmountUserData

- **Signature**: `PortfolioMarginBankruptcyLoanAmountUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PortfolioPmLoanResponse`
- **Error**: `SdkException<PortfolioMarginBankruptcyLoanAmountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioPmLoanResponse` | `Models/SapiV1PortfolioPmLoanResponse.cs` |
| `PortfolioMarginBankruptcyLoanAmountUserDataError` | `Errors/PortfolioMarginBankruptcyLoanAmountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginBankruptcyLoanRepayUserData

- **Signature**: `PortfolioMarginBankruptcyLoanRepayUserData(long timestamp, string signature, string? from, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `from` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `from` ← `from`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PortfolioRepayResponse`
- **Error**: `SdkException<PortfolioMarginBankruptcyLoanRepayUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioRepayResponse` | `Models/SapiV1PortfolioRepayResponse.cs` |
| `PortfolioMarginBankruptcyLoanRepayUserDataError` | `Errors/PortfolioMarginBankruptcyLoanRepayUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginCollateralRateMarketData

- **Signature**: `PortfolioMarginCollateralRateMarketData(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<SapiV1PortfolioCollateralRateResponse>`
- **Error**: `SdkException<PortfolioMarginCollateralRateMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioCollateralRateResponse` | `Models/SapiV1PortfolioCollateralRateResponse.cs` |
| `PortfolioMarginCollateralRateMarketDataError` | `Errors/PortfolioMarginCollateralRateMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### PortfolioMarginProTieredCollateralRateUserData

- **Signature**: `PortfolioMarginProTieredCollateralRateUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV2PortfolioCollateralRateResponse>`
- **Error**: `SdkException<PortfolioMarginProTieredCollateralRateUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2PortfolioCollateralRateResponse` | `Models/SapiV2PortfolioCollateralRateResponse.cs` |
| `PortfolioMarginProTieredCollateralRateUserDataError` | `Errors/PortfolioMarginProTieredCollateralRateUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData

- **Signature**: `QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData(string asset, long timestamp, string signature, long? startTime, long? endTime, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `asset` ← `asset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1PortfolioInterestHistoryResponse>`
- **Error**: `SdkException<QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioInterestHistoryResponse` | `Models/SapiV1PortfolioInterestHistoryResponse.cs` |
| `QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError` | `Errors/QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryPortfolioMarginAssetIndexPriceMarketData

- **Signature**: `QueryPortfolioMarginAssetIndexPriceMarketData(string? asset, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `asset` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `asset` ← `asset`
- **Returns**: `IReadOnlyList<SapiV1PortfolioAssetIndexPriceResponse>`
- **Error**: `SdkException<QueryPortfolioMarginAssetIndexPriceMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioAssetIndexPriceResponse` | `Models/SapiV1PortfolioAssetIndexPriceResponse.cs` |
| `QueryPortfolioMarginAssetIndexPriceMarketDataError` | `Errors/QueryPortfolioMarginAssetIndexPriceMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### RepayFuturesNegativeBalanceUserData

- **Signature**: `RepayFuturesNegativeBalanceUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1PortfolioRepayFuturesNegativeBalanceResponse`
- **Error**: `SdkException<RepayFuturesNegativeBalanceUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1PortfolioRepayFuturesNegativeBalanceResponse` | `Models/SapiV1PortfolioRepayFuturesNegativeBalanceResponse.cs` |
| `RepayFuturesNegativeBalanceUserDataError` | `Errors/RepayFuturesNegativeBalanceUserDataError.cs` |
| `Error` | `Models/Error.cs` |

