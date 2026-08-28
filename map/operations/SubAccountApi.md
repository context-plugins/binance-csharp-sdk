<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubAccountApi — operations

Accessor: `client.SubAccountApi` · Source: `Api/SubAccountApi.cs` · 45 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAVirtualSubAccountForMasterAccount

- **Signature**: `CreateAVirtualSubAccountForMasterAccount(string subAccountString, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `subAccountString` ← `subAccountString`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountVirtualSubAccountResponse`
- **Error**: `SdkException<CreateAVirtualSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountVirtualSubAccountResponse` | `Models/SapiV1SubAccountVirtualSubAccountResponse.cs` |
| `CreateAVirtualSubAccountForMasterAccountError` | `Errors/CreateAVirtualSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteIpListForASubAccountApiKeyForMasterAccount

- **Signature**: `DeleteIpListForASubAccountApiKeyForMasterAccount(string email, string subAccountApiKey, long timestamp, string signature, string? ipAddress, string? thirdPartyName, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `ipAddress` — nullable, no default → **must pass explicitly**
  - `thirdPartyName` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `subAccountApiKey` ← `subAccountApiKey`, `timestamp` ← `timestamp`, `signature` ← `signature`, `ipAddress` ← `ipAddress`, `thirdPartyName` ← `thirdPartyName`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse`
- **Error**: `SdkException<DeleteIpListForASubAccountApiKeyForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse` | `Models/SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse.cs` |
| `DeleteIpListForASubAccountApiKeyForMasterAccountError` | `Errors/DeleteIpListForASubAccountApiKeyForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount

- **Signature**: `DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount(string toEmail, string asset, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `toEmail` ← `toEmail`, `asset` ← `asset`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountDepositResponse`
- **Error**: `SdkException<DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountDepositResponse` | `Models/SapiV1ManagedSubaccountDepositResponse.cs` |
| `DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError` | `Errors/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### DetailOnSubAccountSFuturesAccountForMasterAccount

- **Signature**: `DetailOnSubAccountSFuturesAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountFuturesAccountResponse`
- **Error**: `SdkException<DetailOnSubAccountSFuturesAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountFuturesAccountResponse` | `Models/SapiV1SubAccountFuturesAccountResponse.cs` |
| `DetailOnSubAccountSFuturesAccountForMasterAccountError` | `Errors/DetailOnSubAccountSFuturesAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### DetailOnSubAccountSFuturesAccountV2ForMasterAccount

- **Signature**: `DetailOnSubAccountSFuturesAccountV2ForMasterAccount(string email, int futuresType, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `futuresType` ← `futuresType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2SubAccountFuturesAccountResponse`
- **Error**: `SdkException<DetailOnSubAccountSFuturesAccountV2ForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2SubAccountFuturesAccountResponse` | `Models/AnyOf/SapiV2SubAccountFuturesAccountResponse.cs` |
| `DetailOnSubAccountSFuturesAccountV2ForMasterAccountError` | `Errors/DetailOnSubAccountSFuturesAccountV2ForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### DetailOnSubAccountSMarginAccountForMasterAccount

- **Signature**: `DetailOnSubAccountSMarginAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountMarginAccountResponse`
- **Error**: `SdkException<DetailOnSubAccountSMarginAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountMarginAccountResponse` | `Models/SapiV1SubAccountMarginAccountResponse.cs` |
| `DetailOnSubAccountSMarginAccountForMasterAccountError` | `Errors/DetailOnSubAccountSMarginAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### EnableFuturesForSubAccountForMasterAccount

- **Signature**: `EnableFuturesForSubAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountFuturesEnableResponse`
- **Error**: `SdkException<EnableFuturesForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountFuturesEnableResponse` | `Models/SapiV1SubAccountFuturesEnableResponse.cs` |
| `EnableFuturesForSubAccountForMasterAccountError` | `Errors/EnableFuturesForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### EnableLeverageTokenForSubAccountForMasterAccount

- **Signature**: `EnableLeverageTokenForSubAccountForMasterAccount(string email, bool enableBlvt, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `enableBlvt` ← `enableBlvt`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountBlvtEnableResponse`
- **Error**: `SdkException<EnableLeverageTokenForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountBlvtEnableResponse` | `Models/SapiV1SubAccountBlvtEnableResponse.cs` |
| `EnableLeverageTokenForSubAccountForMasterAccountError` | `Errors/EnableLeverageTokenForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### EnableMarginForSubAccountForMasterAccount

- **Signature**: `EnableMarginForSubAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountMarginEnableResponse`
- **Error**: `SdkException<EnableMarginForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountMarginEnableResponse` | `Models/SapiV1SubAccountMarginEnableResponse.cs` |
| `EnableMarginForSubAccountForMasterAccountError` | `Errors/EnableMarginForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### EnableOptionsForSubAccountForMasterAccountUserData

- **Signature**: `EnableOptionsForSubAccountForMasterAccountUserData(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountEoptionsEnableResponse`
- **Error**: `SdkException<EnableOptionsForSubAccountForMasterAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountEoptionsEnableResponse` | `Models/SapiV1SubAccountEoptionsEnableResponse.cs` |
| `EnableOptionsForSubAccountForMasterAccountUserDataError` | `Errors/EnableOptionsForSubAccountForMasterAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FuturesPositionRiskOfSubAccountForMasterAccount

- **Signature**: `FuturesPositionRiskOfSubAccountForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountFuturesPositionRiskResponse>`
- **Error**: `SdkException<FuturesPositionRiskOfSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountFuturesPositionRiskResponse` | `Models/SapiV1SubAccountFuturesPositionRiskResponse.cs` |
| `FuturesPositionRiskOfSubAccountForMasterAccountError` | `Errors/FuturesPositionRiskOfSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### FuturesPositionRiskOfSubAccountV2ForMasterAccount

- **Signature**: `FuturesPositionRiskOfSubAccountV2ForMasterAccount(string email, int futuresType, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `futuresType` ← `futuresType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2SubAccountFuturesPositionRiskResponse`
- **Error**: `SdkException<FuturesPositionRiskOfSubAccountV2ForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2SubAccountFuturesPositionRiskResponse` | `Models/AnyOf/SapiV2SubAccountFuturesPositionRiskResponse.cs` |
| `FuturesPositionRiskOfSubAccountV2ForMasterAccountError` | `Errors/FuturesPositionRiskOfSubAccountV2ForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### GetIpRestrictionForASubAccountApiKeyForMasterAccount

- **Signature**: `GetIpRestrictionForASubAccountApiKeyForMasterAccount(string email, string subAccountApiKey, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `subAccountApiKey` ← `subAccountApiKey`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountSubAccountApiIpRestrictionResponse`
- **Error**: `SdkException<GetIpRestrictionForASubAccountApiKeyForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountSubAccountApiIpRestrictionResponse` | `Models/SapiV1SubAccountSubAccountApiIpRestrictionResponse.cs` |
| `GetIpRestrictionForASubAccountApiKeyForMasterAccountError` | `Errors/GetIpRestrictionForASubAccountApiKeyForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### GetManagedSubAccountDepositAddressForInvestorMasterAccount

- **Signature**: `GetManagedSubAccountDepositAddressForInvestorMasterAccount(string email, string coin, long timestamp, string signature, string? network, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `network` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `coin` ← `coin`, `timestamp` ← `timestamp`, `signature` ← `signature`, `network` ← `network`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountDepositAddressResponse`
- **Error**: `SdkException<GetManagedSubAccountDepositAddressForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountDepositAddressResponse` | `Models/SapiV1ManagedSubaccountDepositAddressResponse.cs` |
| `GetManagedSubAccountDepositAddressForInvestorMasterAccountError` | `Errors/GetManagedSubAccountDepositAddressForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### ManagedSubAccountAssetDetailsForInvestorMasterAccount

- **Signature**: `ManagedSubAccountAssetDetailsForInvestorMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1ManagedSubaccountAssetResponse>`
- **Error**: `SdkException<ManagedSubAccountAssetDetailsForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountAssetResponse` | `Models/SapiV1ManagedSubaccountAssetResponse.cs` |
| `ManagedSubAccountAssetDetailsForInvestorMasterAccountError` | `Errors/ManagedSubAccountAssetDetailsForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### ManagedSubAccountSnapshotForInvestorMasterAccount

- **Signature**: `ManagedSubAccountSnapshotForInvestorMasterAccount(string email, string type, long timestamp, string signature, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `email` ← `email`, `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountAccountSnapshotResponse`
- **Error**: `SdkException<ManagedSubAccountSnapshotForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountAccountSnapshotResponse` | `Models/SapiV1ManagedSubaccountAccountSnapshotResponse.cs` |
| `ManagedSubAccountSnapshotForInvestorMasterAccountError` | `Errors/ManagedSubAccountSnapshotForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### MarginTransferForSubAccountForMasterAccount

- **Signature**: `MarginTransferForSubAccountForMasterAccount(string email, string asset, double amount, int type, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `asset` ← `asset`, `amount` ← `amount`, `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountMarginTransferResponse`
- **Error**: `SdkException<MarginTransferForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountMarginTransferResponse` | `Models/SapiV1SubAccountMarginTransferResponse.cs` |
| `MarginTransferForSubAccountForMasterAccountError` | `Errors/MarginTransferForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount

- **Signature**: `QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountFetchFutureAssetResponse`
- **Error**: `SdkException<QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountFetchFutureAssetResponse` | `Models/SapiV1ManagedSubaccountFetchFutureAssetResponse.cs` |
| `QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError` | `Errors/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### QueryManagedSubAccountListForInvestor

- **Signature**: `QueryManagedSubAccountListForInvestor(string email, long timestamp, string signature, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `page` ← `page`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountInfoResponse`
- **Error**: `SdkException<QueryManagedSubAccountListForInvestorError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountInfoResponse` | `Models/SapiV1ManagedSubaccountInfoResponse.cs` |
| `QueryManagedSubAccountListForInvestorError` | `Errors/QueryManagedSubAccountListForInvestorError.cs` |
| `Error` | `Models/Error.cs` |

### QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount

- **Signature**: `QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountMarginAssetResponse`
- **Error**: `SdkException<QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountMarginAssetResponse` | `Models/SapiV1ManagedSubaccountMarginAssetResponse.cs` |
| `QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError` | `Errors/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### QueryManagedSubAccountTransferLogForInvestorMasterAccount

- **Signature**: `QueryManagedSubAccountTransferLogForInvestorMasterAccount(string email, long timestamp, string signature, long? startTime, long? endTime, int? page, int? limit, string? transfers, string? transferFunctionAccountType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `page` ← `page`, `limit` ← `limit`, `transfers` ← `transfers`, `transferFunctionAccountType` ← `transferFunctionAccountType`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountQueryTransLogForInvestorResponse`
- **Error**: `SdkException<QueryManagedSubAccountTransferLogForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountQueryTransLogForInvestorResponse` | `Models/SapiV1ManagedSubaccountQueryTransLogForInvestorResponse.cs` |
| `QueryManagedSubAccountTransferLogForInvestorMasterAccountError` | `Errors/QueryManagedSubAccountTransferLogForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### QueryManagedSubAccountTransferLogForTradingTeamMasterAccount

- **Signature**: `QueryManagedSubAccountTransferLogForTradingTeamMasterAccount(string email, long timestamp, string signature, long? startTime, long? endTime, int? page, int? limit, string? transfers, string? transferFunctionAccountType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `page` ← `page`, `limit` ← `limit`, `transfers` ← `transfers`, `transferFunctionAccountType` ← `transferFunctionAccountType`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse`
- **Error**: `SdkException<QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse` | `Models/SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse.cs` |
| `QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError` | `Errors/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData

- **Signature**: `QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData(Transfers transfers, TransferFunctionAccountType transferFunctionAccountType, long timestamp, string signature, long? startTime, long? endTime, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `transfers` ← `transfers`, `transferFunctionAccountType` ← `transferFunctionAccountType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `page` ← `page`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountQueryTransLogResponse`
- **Error**: `SdkException<QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Transfers` | `Models/Enums/Transfers.cs` |
| `TransferFunctionAccountType` | `Models/Enums/TransferFunctionAccountType.cs` |
| `SapiV1ManagedSubaccountQueryTransLogResponse` | `Models/SapiV1ManagedSubaccountQueryTransLogResponse.cs` |
| `QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError` | `Errors/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubAccountAssetsForMasterAccount

- **Signature**: `QuerySubAccountAssetsForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV4SubAccountAssetsResponse`
- **Error**: `SdkException<QuerySubAccountAssetsForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV4SubAccountAssetsResponse` | `Models/SapiV4SubAccountAssetsResponse.cs` |
| `QuerySubAccountAssetsForMasterAccountError` | `Errors/QuerySubAccountAssetsForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubAccountListForMasterAccount

- **Signature**: `QuerySubAccountListForMasterAccount(long timestamp, string signature, string? email, IsFreeze? isFreeze, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`email` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `email` ← `email`, `isFreeze` ← `isFreeze`, `page` ← `page`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountListResponse`
- **Error**: `SdkException<QuerySubAccountListForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IsFreeze` | `Models/Enums/IsFreeze.cs` |
| `SapiV1SubAccountListResponse` | `Models/SapiV1SubAccountListResponse.cs` |
| `QuerySubAccountListForMasterAccountError` | `Errors/QuerySubAccountListForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### QuerySubAccountTransactionStatisticsForMasterAccount

- **Signature**: `QuerySubAccountTransactionStatisticsForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountTransactionStatisticsResponse`
- **Error**: `SdkException<QuerySubAccountTransactionStatisticsForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountTransactionStatisticsResponse` | `Models/SapiV1SubAccountTransactionStatisticsResponse.cs` |
| `QuerySubAccountTransactionStatisticsForMasterAccountError` | `Errors/QuerySubAccountTransactionStatisticsForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SubAccountAssetsForMasterAccount

- **Signature**: `SubAccountAssetsForMasterAccount(string email, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV3SubAccountAssetsResponse`
- **Error**: `SdkException<SubAccountAssetsForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV3SubAccountAssetsResponse` | `Models/SapiV3SubAccountAssetsResponse.cs` |
| `SubAccountAssetsForMasterAccountError` | `Errors/SubAccountAssetsForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SubAccountDepositHistoryForMasterAccount

- **Signature**: `SubAccountDepositHistoryForMasterAccount(string email, long timestamp, string signature, string? coin, int? status, long? startTime, long? endTime, long? limit, int? offset, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`coin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `email` ← `email`, `timestamp` ← `timestamp`, `signature` ← `signature`, `coin` ← `coin`, `status` ← `status`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `offset` ← `offset`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalDepositSubHisrecResponse>`
- **Error**: `SdkException<SubAccountDepositHistoryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalDepositSubHisrecResponse` | `Models/SapiV1CapitalDepositSubHisrecResponse.cs` |
| `SubAccountDepositHistoryForMasterAccountError` | `Errors/SubAccountDepositHistoryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SubAccountFuturesAssetTransferForMasterAccount

- **Signature**: `SubAccountFuturesAssetTransferForMasterAccount(string fromEmail, string toEmail, int futuresType, string asset, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `fromEmail` ← `fromEmail`, `toEmail` ← `toEmail`, `futuresType` ← `futuresType`, `asset` ← `asset`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountFuturesInternalTransferResponse1`
- **Error**: `SdkException<SubAccountFuturesAssetTransferForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountFuturesInternalTransferResponse1` | `Models/SapiV1SubAccountFuturesInternalTransferResponse1.cs` |
| `SubAccountFuturesAssetTransferForMasterAccountError` | `Errors/SubAccountFuturesAssetTransferForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SubAccountFuturesAssetTransferHistoryForMasterAccount

- **Signature**: `SubAccountFuturesAssetTransferHistoryForMasterAccount(string email, int futuresType, long timestamp, string signature, long? startTime, long? endTime, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `email` ← `email`, `futuresType` ← `futuresType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `page` ← `page`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountFuturesInternalTransferResponse`
- **Error**: `SdkException<SubAccountFuturesAssetTransferHistoryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountFuturesInternalTransferResponse` | `Models/SapiV1SubAccountFuturesInternalTransferResponse.cs` |
| `SubAccountFuturesAssetTransferHistoryForMasterAccountError` | `Errors/SubAccountFuturesAssetTransferHistoryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SubAccountSStatusOnMarginFuturesForMasterAccount

- **Signature**: `SubAccountSStatusOnMarginFuturesForMasterAccount(long timestamp, string signature, string? email, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `email` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `email` ← `email`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountStatusResponse>`
- **Error**: `SdkException<SubAccountSStatusOnMarginFuturesForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountStatusResponse` | `Models/SapiV1SubAccountStatusResponse.cs` |
| `SubAccountSStatusOnMarginFuturesForMasterAccountError` | `Errors/SubAccountSStatusOnMarginFuturesForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SubAccountSpotAssetTransferHistoryForMasterAccount

- **Signature**: `SubAccountSpotAssetTransferHistoryForMasterAccount(long timestamp, string signature, string? fromEmail, string? toEmail, long? startTime, long? endTime, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`fromEmail` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `fromEmail` ← `fromEmail`, `toEmail` ← `toEmail`, `startTime` ← `startTime`, `endTime` ← `endTime`, `page` ← `page`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountSubTransferHistoryResponse>`
- **Error**: `SdkException<SubAccountSpotAssetTransferHistoryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountSubTransferHistoryResponse` | `Models/SapiV1SubAccountSubTransferHistoryResponse.cs` |
| `SubAccountSpotAssetTransferHistoryForMasterAccountError` | `Errors/SubAccountSpotAssetTransferHistoryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SubAccountSpotAssetsSummaryForMasterAccount

- **Signature**: `SubAccountSpotAssetsSummaryForMasterAccount(long timestamp, string signature, string? email, int? page, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`email` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `email` ← `email`, `page` ← `page`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountSpotSummaryResponse`
- **Error**: `SdkException<SubAccountSpotAssetsSummaryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountSpotSummaryResponse` | `Models/SapiV1SubAccountSpotSummaryResponse.cs` |
| `SubAccountSpotAssetsSummaryForMasterAccountError` | `Errors/SubAccountSpotAssetsSummaryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SubAccountSpotAssetsSummaryForMasterAccount2

- **Signature**: `SubAccountSpotAssetsSummaryForMasterAccount2(string email, string coin, long timestamp, string signature, string? network, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `network` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `coin` ← `coin`, `timestamp` ← `timestamp`, `signature` ← `signature`, `network` ← `network`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1CapitalDepositSubAddressResponse`
- **Error**: `SdkException<SubAccountSpotAssetsSummaryForMasterAccount2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalDepositSubAddressResponse` | `Models/SapiV1CapitalDepositSubAddressResponse.cs` |
| `SubAccountSpotAssetsSummaryForMasterAccount2Error` | `Errors/SubAccountSpotAssetsSummaryForMasterAccount2Error.cs` |
| `Error` | `Models/Error.cs` |

### SubAccountTransferHistoryForSubAccount

- **Signature**: `SubAccountTransferHistoryForSubAccount(long timestamp, string signature, string? asset, int? type, long? startTime, long? endTime, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `type` ← `type`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountTransferSubUserHistoryResponse>`
- **Error**: `SdkException<SubAccountTransferHistoryForSubAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountTransferSubUserHistoryResponse` | `Models/SapiV1SubAccountTransferSubUserHistoryResponse.cs` |
| `SubAccountTransferHistoryForSubAccountError` | `Errors/SubAccountTransferHistoryForSubAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SummaryOfSubAccountSFuturesAccountForMasterAccount

- **Signature**: `SummaryOfSubAccountSFuturesAccountForMasterAccount(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountFuturesAccountSummaryResponse`
- **Error**: `SdkException<SummaryOfSubAccountSFuturesAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountFuturesAccountSummaryResponse` | `Models/SapiV1SubAccountFuturesAccountSummaryResponse.cs` |
| `SummaryOfSubAccountSFuturesAccountForMasterAccountError` | `Errors/SummaryOfSubAccountSFuturesAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SummaryOfSubAccountSFuturesAccountV2ForMasterAccount

- **Signature**: `SummaryOfSubAccountSFuturesAccountV2ForMasterAccount(int futuresType, long timestamp, string signature, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `futuresType` ← `futuresType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `page` ← `page`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2SubAccountFuturesAccountSummaryResponse`
- **Error**: `SdkException<SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2SubAccountFuturesAccountSummaryResponse` | `Models/AnyOf/SapiV2SubAccountFuturesAccountSummaryResponse.cs` |
| `SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError` | `Errors/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### SummaryOfSubAccountSMarginAccountForMasterAccount

- **Signature**: `SummaryOfSubAccountSMarginAccountForMasterAccount(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountMarginAccountSummaryResponse`
- **Error**: `SdkException<SummaryOfSubAccountSMarginAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountMarginAccountSummaryResponse` | `Models/SapiV1SubAccountMarginAccountSummaryResponse.cs` |
| `SummaryOfSubAccountSMarginAccountForMasterAccountError` | `Errors/SummaryOfSubAccountSMarginAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### TransferForSubAccountForMasterAccount

- **Signature**: `TransferForSubAccountForMasterAccount(string email, string asset, double amount, int type, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `asset` ← `asset`, `amount` ← `amount`, `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountFuturesTransferResponse`
- **Error**: `SdkException<TransferForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountFuturesTransferResponse` | `Models/SapiV1SubAccountFuturesTransferResponse.cs` |
| `TransferForSubAccountForMasterAccountError` | `Errors/TransferForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### TransferToMasterForSubAccount

- **Signature**: `TransferToMasterForSubAccount(string asset, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `asset` ← `asset`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountTransferSubToMasterResponse`
- **Error**: `SdkException<TransferToMasterForSubAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountTransferSubToMasterResponse` | `Models/SapiV1SubAccountTransferSubToMasterResponse.cs` |
| `TransferToMasterForSubAccountError` | `Errors/TransferToMasterForSubAccountError.cs` |
| `Error` | `Models/Error.cs` |

### TransferToSubAccountOfSameMasterForSubAccount

- **Signature**: `TransferToSubAccountOfSameMasterForSubAccount(string toEmail, string asset, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `toEmail` ← `toEmail`, `asset` ← `asset`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountTransferSubToSubResponse`
- **Error**: `SdkException<TransferToSubAccountOfSameMasterForSubAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountTransferSubToSubResponse` | `Models/SapiV1SubAccountTransferSubToSubResponse.cs` |
| `TransferToSubAccountOfSameMasterForSubAccountError` | `Errors/TransferToSubAccountOfSameMasterForSubAccountError.cs` |
| `Error` | `Models/Error.cs` |

### UniversalTransferForMasterAccount

- **Signature**: `UniversalTransferForMasterAccount(FromAccountType fromAccountType, ToAccountType toAccountType, string asset, double amount, long timestamp, string signature, string? fromEmail, string? toEmail, string? clientTranId, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`fromEmail` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `fromAccountType` ← `fromAccountType`, `toAccountType` ← `toAccountType`, `asset` ← `asset`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `fromEmail` ← `fromEmail`, `toEmail` ← `toEmail`, `clientTranId` ← `clientTranId`, `symbol` ← `symbol`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1SubAccountUniversalTransferResponse1`
- **Error**: `SdkException<UniversalTransferForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FromAccountType` | `Models/Enums/FromAccountType.cs` |
| `ToAccountType` | `Models/Enums/ToAccountType.cs` |
| `SapiV1SubAccountUniversalTransferResponse1` | `Models/SapiV1SubAccountUniversalTransferResponse1.cs` |
| `UniversalTransferForMasterAccountError` | `Errors/UniversalTransferForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### UniversalTransferHistoryForMasterAccount

- **Signature**: `UniversalTransferHistoryForMasterAccount(long timestamp, string signature, string? fromEmail, string? toEmail, string? clientTranId, long? startTime, long? endTime, int? page, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`fromEmail` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `fromEmail` ← `fromEmail`, `toEmail` ← `toEmail`, `clientTranId` ← `clientTranId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `page` ← `page`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountUniversalTransferResponse>`
- **Error**: `SdkException<UniversalTransferHistoryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SubAccountUniversalTransferResponse` | `Models/SapiV1SubAccountUniversalTransferResponse.cs` |
| `UniversalTransferHistoryForMasterAccountError` | `Errors/UniversalTransferHistoryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### UpdateIpRestrictionForSubAccountApiKeyForMasterAccount

- **Signature**: `UpdateIpRestrictionForSubAccountApiKeyForMasterAccount(string email, string subAccountApiKey, string status, long timestamp, string signature, string? thirdPartyName, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `thirdPartyName` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `email` ← `email`, `subAccountApiKey` ← `subAccountApiKey`, `status` ← `status`, `timestamp` ← `timestamp`, `signature` ← `signature`, `thirdPartyName` ← `thirdPartyName`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2SubAccountSubAccountApiIpRestrictionResponse`
- **Error**: `SdkException<UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2SubAccountSubAccountApiIpRestrictionResponse` | `Models/SapiV2SubAccountSubAccountApiIpRestrictionResponse.cs` |
| `UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError` | `Errors/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount

- **Signature**: `WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount(string fromEmail, string asset, double amount, long timestamp, string signature, long? transferDate, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `transferDate` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `fromEmail` ← `fromEmail`, `asset` ← `asset`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `transferDate` ← `transferDate`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1ManagedSubaccountWithdrawResponse`
- **Error**: `SdkException<WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1ManagedSubaccountWithdrawResponse` | `Models/SapiV1ManagedSubaccountWithdrawResponse.cs` |
| `WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError` | `Errors/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

