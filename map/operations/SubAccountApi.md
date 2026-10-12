<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubAccountApi — operations

Accessor: `client.SubAccountApi` · Source: `src/Binance/Api/SubAccountApi.cs` · 45 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAVirtualSubAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CreateAVirtualSubAccountForMasterAccount(CreateAVirtualSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubAccountString`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `subAccountString` ← `SubAccountString`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountVirtualSubAccountResponse`
- **Error**: `ApiException<CreateAVirtualSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateAVirtualSubAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/CreateAVirtualSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountVirtualSubAccountResponse` | `src/Binance/Models/SapiV1SubAccountVirtualSubAccountResponse.cs` |
| `CreateAVirtualSubAccountForMasterAccountError` | `src/Binance/Errors/CreateAVirtualSubAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### DeleteIpListForASubAccountApiKeyForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DeleteIpListForASubAccountApiKeyForMasterAccount(DeleteIpListForASubAccountApiKeyForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `SubAccountApiKey`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `subAccountApiKey` ← `SubAccountApiKey`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `ipAddress` ← `IpAddress`, `thirdPartyName` ← `ThirdPartyName`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse`
- **Error**: `ApiException<DeleteIpListForASubAccountApiKeyForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteIpListForASubAccountApiKeyForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/DeleteIpListForASubAccountApiKeyForMasterAccountRequest.cs` |
| `SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse` | `src/Binance/Models/SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse.cs` |
| `DeleteIpListForASubAccountApiKeyForMasterAccountError` | `src/Binance/Errors/DeleteIpListForASubAccountApiKeyForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount(DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ToEmail`, `Asset`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `toEmail` ← `ToEmail`, `asset` ← `Asset`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountDepositResponse`
- **Error**: `ApiException<DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountDepositResponse` | `src/Binance/Models/SapiV1ManagedSubaccountDepositResponse.cs` |
| `DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError` | `src/Binance/Errors/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### DetailOnSubAccountSFuturesAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DetailOnSubAccountSFuturesAccountForMasterAccount(DetailOnSubAccountSFuturesAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountFuturesAccountResponse`
- **Error**: `ApiException<DetailOnSubAccountSFuturesAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DetailOnSubAccountSFuturesAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/DetailOnSubAccountSFuturesAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesAccountResponse` | `src/Binance/Models/SapiV1SubAccountFuturesAccountResponse.cs` |
| `DetailOnSubAccountSFuturesAccountForMasterAccountError` | `src/Binance/Errors/DetailOnSubAccountSFuturesAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### DetailOnSubAccountSFuturesAccountV2ForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DetailOnSubAccountSFuturesAccountV2ForMasterAccount(DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `FuturesType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `futuresType` ← `FuturesType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2SubAccountFuturesAccountResponse`
- **Error**: `ApiException<DetailOnSubAccountSFuturesAccountV2ForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest.cs` |
| `SapiV2SubAccountFuturesAccountResponse` | `src/Binance/Models/AnyOf/SapiV2SubAccountFuturesAccountResponse.cs` |
| `DetailOnSubAccountSFuturesAccountV2ForMasterAccountError` | `src/Binance/Errors/DetailOnSubAccountSFuturesAccountV2ForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### DetailOnSubAccountSMarginAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DetailOnSubAccountSMarginAccountForMasterAccount(DetailOnSubAccountSMarginAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountMarginAccountResponse`
- **Error**: `ApiException<DetailOnSubAccountSMarginAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DetailOnSubAccountSMarginAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/DetailOnSubAccountSMarginAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountMarginAccountResponse` | `src/Binance/Models/SapiV1SubAccountMarginAccountResponse.cs` |
| `DetailOnSubAccountSMarginAccountForMasterAccountError` | `src/Binance/Errors/DetailOnSubAccountSMarginAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### EnableFuturesForSubAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EnableFuturesForSubAccountForMasterAccount(EnableFuturesForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountFuturesEnableResponse`
- **Error**: `ApiException<EnableFuturesForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableFuturesForSubAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/EnableFuturesForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesEnableResponse` | `src/Binance/Models/SapiV1SubAccountFuturesEnableResponse.cs` |
| `EnableFuturesForSubAccountForMasterAccountError` | `src/Binance/Errors/EnableFuturesForSubAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### EnableLeverageTokenForSubAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EnableLeverageTokenForSubAccountForMasterAccount(EnableLeverageTokenForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `EnableBlvt`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `enableBlvt` ← `EnableBlvt`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountBlvtEnableResponse`
- **Error**: `ApiException<EnableLeverageTokenForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableLeverageTokenForSubAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/EnableLeverageTokenForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountBlvtEnableResponse` | `src/Binance/Models/SapiV1SubAccountBlvtEnableResponse.cs` |
| `EnableLeverageTokenForSubAccountForMasterAccountError` | `src/Binance/Errors/EnableLeverageTokenForSubAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### EnableMarginForSubAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EnableMarginForSubAccountForMasterAccount(EnableMarginForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountMarginEnableResponse`
- **Error**: `ApiException<EnableMarginForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableMarginForSubAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/EnableMarginForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountMarginEnableResponse` | `src/Binance/Models/SapiV1SubAccountMarginEnableResponse.cs` |
| `EnableMarginForSubAccountForMasterAccountError` | `src/Binance/Errors/EnableMarginForSubAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### EnableOptionsForSubAccountForMasterAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EnableOptionsForSubAccountForMasterAccountUserData(EnableOptionsForSubAccountForMasterAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountEoptionsEnableResponse`
- **Error**: `ApiException<EnableOptionsForSubAccountForMasterAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableOptionsForSubAccountForMasterAccountUserDataRequest` | `src/Binance/Requests/SubAccountApi/EnableOptionsForSubAccountForMasterAccountUserDataRequest.cs` |
| `SapiV1SubAccountEoptionsEnableResponse` | `src/Binance/Models/SapiV1SubAccountEoptionsEnableResponse.cs` |
| `EnableOptionsForSubAccountForMasterAccountUserDataError` | `src/Binance/Errors/EnableOptionsForSubAccountForMasterAccountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### FuturesPositionRiskOfSubAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FuturesPositionRiskOfSubAccountForMasterAccount(FuturesPositionRiskOfSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountFuturesPositionRiskResponse>`
- **Error**: `ApiException<FuturesPositionRiskOfSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FuturesPositionRiskOfSubAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/FuturesPositionRiskOfSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesPositionRiskResponse` | `src/Binance/Models/SapiV1SubAccountFuturesPositionRiskResponse.cs` |
| `FuturesPositionRiskOfSubAccountForMasterAccountError` | `src/Binance/Errors/FuturesPositionRiskOfSubAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### FuturesPositionRiskOfSubAccountV2ForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FuturesPositionRiskOfSubAccountV2ForMasterAccount(FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `FuturesType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `futuresType` ← `FuturesType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2SubAccountFuturesPositionRiskResponse`
- **Error**: `ApiException<FuturesPositionRiskOfSubAccountV2ForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest.cs` |
| `SapiV2SubAccountFuturesPositionRiskResponse` | `src/Binance/Models/AnyOf/SapiV2SubAccountFuturesPositionRiskResponse.cs` |
| `FuturesPositionRiskOfSubAccountV2ForMasterAccountError` | `src/Binance/Errors/FuturesPositionRiskOfSubAccountV2ForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetIpRestrictionForASubAccountApiKeyForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetIpRestrictionForASubAccountApiKeyForMasterAccount(GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `SubAccountApiKey`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `subAccountApiKey` ← `SubAccountApiKey`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountSubAccountApiIpRestrictionResponse`
- **Error**: `ApiException<GetIpRestrictionForASubAccountApiKeyForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest.cs` |
| `SapiV1SubAccountSubAccountApiIpRestrictionResponse` | `src/Binance/Models/SapiV1SubAccountSubAccountApiIpRestrictionResponse.cs` |
| `GetIpRestrictionForASubAccountApiKeyForMasterAccountError` | `src/Binance/Errors/GetIpRestrictionForASubAccountApiKeyForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### GetManagedSubAccountDepositAddressForInvestorMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetManagedSubAccountDepositAddressForInvestorMasterAccount(GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Coin`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `coin` ← `Coin`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `network` ← `Network`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountDepositAddressResponse`
- **Error**: `ApiException<GetManagedSubAccountDepositAddressForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountDepositAddressResponse` | `src/Binance/Models/SapiV1ManagedSubaccountDepositAddressResponse.cs` |
| `GetManagedSubAccountDepositAddressForInvestorMasterAccountError` | `src/Binance/Errors/GetManagedSubAccountDepositAddressForInvestorMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### ManagedSubAccountAssetDetailsForInvestorMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ManagedSubAccountAssetDetailsForInvestorMasterAccount(ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1ManagedSubaccountAssetResponse>`
- **Error**: `ApiException<ManagedSubAccountAssetDetailsForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountAssetResponse` | `src/Binance/Models/SapiV1ManagedSubaccountAssetResponse.cs` |
| `ManagedSubAccountAssetDetailsForInvestorMasterAccountError` | `src/Binance/Errors/ManagedSubAccountAssetDetailsForInvestorMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### ManagedSubAccountSnapshotForInvestorMasterAccount

- **Signature**: `ManagedSubAccountSnapshotForInvestorMasterAccount(ManagedSubAccountSnapshotForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountAccountSnapshotResponse`
- **Error**: `ApiException<ManagedSubAccountSnapshotForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ManagedSubAccountSnapshotForInvestorMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/ManagedSubAccountSnapshotForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountAccountSnapshotResponse` | `src/Binance/Models/SapiV1ManagedSubaccountAccountSnapshotResponse.cs` |
| `ManagedSubAccountSnapshotForInvestorMasterAccountError` | `src/Binance/Errors/ManagedSubAccountSnapshotForInvestorMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### MarginTransferForSubAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `MarginTransferForSubAccountForMasterAccount(MarginTransferForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Asset`, `Amount`, `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `asset` ← `Asset`, `amount` ← `Amount`, `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountMarginTransferResponse`
- **Error**: `ApiException<MarginTransferForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MarginTransferForSubAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/MarginTransferForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountMarginTransferResponse` | `src/Binance/Models/SapiV1SubAccountMarginTransferResponse.cs` |
| `MarginTransferForSubAccountForMasterAccountError` | `src/Binance/Errors/MarginTransferForSubAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount(QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountFetchFutureAssetResponse`
- **Error**: `ApiException<QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountFetchFutureAssetResponse` | `src/Binance/Models/SapiV1ManagedSubaccountFetchFutureAssetResponse.cs` |
| `QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError` | `src/Binance/Errors/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryManagedSubAccountListForInvestor

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryManagedSubAccountListForInvestor(QueryManagedSubAccountListForInvestorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `page` ← `Page`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountInfoResponse`
- **Error**: `ApiException<QueryManagedSubAccountListForInvestorError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryManagedSubAccountListForInvestorRequest` | `src/Binance/Requests/SubAccountApi/QueryManagedSubAccountListForInvestorRequest.cs` |
| `SapiV1ManagedSubaccountInfoResponse` | `src/Binance/Models/SapiV1ManagedSubaccountInfoResponse.cs` |
| `QueryManagedSubAccountListForInvestorError` | `src/Binance/Errors/QueryManagedSubAccountListForInvestorError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount(QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountMarginAssetResponse`
- **Error**: `ApiException<QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountMarginAssetResponse` | `src/Binance/Models/SapiV1ManagedSubaccountMarginAssetResponse.cs` |
| `QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError` | `src/Binance/Errors/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryManagedSubAccountTransferLogForInvestorMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryManagedSubAccountTransferLogForInvestorMasterAccount(QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `page` ← `Page`, `limit` ← `Limit`, `transfers` ← `Transfers`, `transferFunctionAccountType` ← `TransferFunctionAccountType`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountQueryTransLogForInvestorResponse`
- **Error**: `ApiException<QueryManagedSubAccountTransferLogForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountQueryTransLogForInvestorResponse` | `src/Binance/Models/SapiV1ManagedSubaccountQueryTransLogForInvestorResponse.cs` |
| `QueryManagedSubAccountTransferLogForInvestorMasterAccountError` | `src/Binance/Errors/QueryManagedSubAccountTransferLogForInvestorMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryManagedSubAccountTransferLogForTradingTeamMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryManagedSubAccountTransferLogForTradingTeamMasterAccount(QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `page` ← `Page`, `limit` ← `Limit`, `transfers` ← `Transfers`, `transferFunctionAccountType` ← `TransferFunctionAccountType`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse`
- **Error**: `ApiException<QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse` | `src/Binance/Models/SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse.cs` |
| `QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError` | `src/Binance/Errors/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData(QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Transfers`, `TransferFunctionAccountType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `transfers` ← `Transfers`, `transferFunctionAccountType` ← `TransferFunctionAccountType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `page` ← `Page`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountQueryTransLogResponse`
- **Error**: `ApiException<QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest` | `src/Binance/Requests/SubAccountApi/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest.cs` |
| `Transfers` | `src/Binance/Models/Enums/Transfers.cs` |
| `TransferFunctionAccountType` | `src/Binance/Models/Enums/TransferFunctionAccountType.cs` |
| `SapiV1ManagedSubaccountQueryTransLogResponse` | `src/Binance/Models/SapiV1ManagedSubaccountQueryTransLogResponse.cs` |
| `QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError` | `src/Binance/Errors/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QuerySubAccountAssetsForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubAccountAssetsForMasterAccount(QuerySubAccountAssetsForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV4SubAccountAssetsResponse`
- **Error**: `ApiException<QuerySubAccountAssetsForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QuerySubAccountAssetsForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/QuerySubAccountAssetsForMasterAccountRequest.cs` |
| `SapiV4SubAccountAssetsResponse` | `src/Binance/Models/SapiV4SubAccountAssetsResponse.cs` |
| `QuerySubAccountAssetsForMasterAccountError` | `src/Binance/Errors/QuerySubAccountAssetsForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QuerySubAccountListForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubAccountListForMasterAccount(QuerySubAccountListForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `email` ← `Email`, `isFreeze` ← `IsFreeze`, `page` ← `Page`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountListResponse`
- **Error**: `ApiException<QuerySubAccountListForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QuerySubAccountListForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/QuerySubAccountListForMasterAccountRequest.cs` |
| `IsFreeze` | `src/Binance/Models/Enums/IsFreeze.cs` |
| `SapiV1SubAccountListResponse` | `src/Binance/Models/SapiV1SubAccountListResponse.cs` |
| `QuerySubAccountListForMasterAccountError` | `src/Binance/Errors/QuerySubAccountListForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QuerySubAccountTransactionStatisticsForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QuerySubAccountTransactionStatisticsForMasterAccount(QuerySubAccountTransactionStatisticsForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountTransactionStatisticsResponse`
- **Error**: `ApiException<QuerySubAccountTransactionStatisticsForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QuerySubAccountTransactionStatisticsForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/QuerySubAccountTransactionStatisticsForMasterAccountRequest.cs` |
| `SapiV1SubAccountTransactionStatisticsResponse` | `src/Binance/Models/SapiV1SubAccountTransactionStatisticsResponse.cs` |
| `QuerySubAccountTransactionStatisticsForMasterAccountError` | `src/Binance/Errors/QuerySubAccountTransactionStatisticsForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubAccountAssetsForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubAccountAssetsForMasterAccount(SubAccountAssetsForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV3SubAccountAssetsResponse`
- **Error**: `ApiException<SubAccountAssetsForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubAccountAssetsForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SubAccountAssetsForMasterAccountRequest.cs` |
| `SapiV3SubAccountAssetsResponse` | `src/Binance/Models/SapiV3SubAccountAssetsResponse.cs` |
| `SubAccountAssetsForMasterAccountError` | `src/Binance/Errors/SubAccountAssetsForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubAccountDepositHistoryForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubAccountDepositHistoryForMasterAccount(SubAccountDepositHistoryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `coin` ← `Coin`, `status` ← `Status`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `offset` ← `Offset`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalDepositSubHisrecResponse>`
- **Error**: `ApiException<SubAccountDepositHistoryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubAccountDepositHistoryForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SubAccountDepositHistoryForMasterAccountRequest.cs` |
| `SapiV1CapitalDepositSubHisrecResponse` | `src/Binance/Models/SapiV1CapitalDepositSubHisrecResponse.cs` |
| `SubAccountDepositHistoryForMasterAccountError` | `src/Binance/Errors/SubAccountDepositHistoryForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubAccountFuturesAssetTransferForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubAccountFuturesAssetTransferForMasterAccount(SubAccountFuturesAssetTransferForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FromEmail`, `ToEmail`, `FuturesType`, `Asset`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `fromEmail` ← `FromEmail`, `toEmail` ← `ToEmail`, `futuresType` ← `FuturesType`, `asset` ← `Asset`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountFuturesInternalTransferResponse1`
- **Error**: `ApiException<SubAccountFuturesAssetTransferForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubAccountFuturesAssetTransferForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SubAccountFuturesAssetTransferForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesInternalTransferResponse1` | `src/Binance/Models/SapiV1SubAccountFuturesInternalTransferResponse1.cs` |
| `SubAccountFuturesAssetTransferForMasterAccountError` | `src/Binance/Errors/SubAccountFuturesAssetTransferForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubAccountFuturesAssetTransferHistoryForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubAccountFuturesAssetTransferHistoryForMasterAccount(SubAccountFuturesAssetTransferHistoryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `FuturesType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `futuresType` ← `FuturesType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `page` ← `Page`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountFuturesInternalTransferResponse`
- **Error**: `ApiException<SubAccountFuturesAssetTransferHistoryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubAccountFuturesAssetTransferHistoryForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SubAccountFuturesAssetTransferHistoryForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesInternalTransferResponse` | `src/Binance/Models/SapiV1SubAccountFuturesInternalTransferResponse.cs` |
| `SubAccountFuturesAssetTransferHistoryForMasterAccountError` | `src/Binance/Errors/SubAccountFuturesAssetTransferHistoryForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubAccountSStatusOnMarginFuturesForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubAccountSStatusOnMarginFuturesForMasterAccount(SubAccountSStatusOnMarginFuturesForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `email` ← `Email`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountStatusResponse>`
- **Error**: `ApiException<SubAccountSStatusOnMarginFuturesForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubAccountSStatusOnMarginFuturesForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SubAccountSStatusOnMarginFuturesForMasterAccountRequest.cs` |
| `SapiV1SubAccountStatusResponse` | `src/Binance/Models/SapiV1SubAccountStatusResponse.cs` |
| `SubAccountSStatusOnMarginFuturesForMasterAccountError` | `src/Binance/Errors/SubAccountSStatusOnMarginFuturesForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubAccountSpotAssetTransferHistoryForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubAccountSpotAssetTransferHistoryForMasterAccount(SubAccountSpotAssetTransferHistoryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `fromEmail` ← `FromEmail`, `toEmail` ← `ToEmail`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `page` ← `Page`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountSubTransferHistoryResponse>`
- **Error**: `ApiException<SubAccountSpotAssetTransferHistoryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubAccountSpotAssetTransferHistoryForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SubAccountSpotAssetTransferHistoryForMasterAccountRequest.cs` |
| `SapiV1SubAccountSubTransferHistoryResponse` | `src/Binance/Models/SapiV1SubAccountSubTransferHistoryResponse.cs` |
| `SubAccountSpotAssetTransferHistoryForMasterAccountError` | `src/Binance/Errors/SubAccountSpotAssetTransferHistoryForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubAccountSpotAssetsSummaryForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubAccountSpotAssetsSummaryForMasterAccount(SubAccountSpotAssetsSummaryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `email` ← `Email`, `page` ← `Page`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountSpotSummaryResponse`
- **Error**: `ApiException<SubAccountSpotAssetsSummaryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubAccountSpotAssetsSummaryForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SubAccountSpotAssetsSummaryForMasterAccountRequest.cs` |
| `SapiV1SubAccountSpotSummaryResponse` | `src/Binance/Models/SapiV1SubAccountSpotSummaryResponse.cs` |
| `SubAccountSpotAssetsSummaryForMasterAccountError` | `src/Binance/Errors/SubAccountSpotAssetsSummaryForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubAccountSpotAssetsSummaryForMasterAccount2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubAccountSpotAssetsSummaryForMasterAccount2(SubAccountSpotAssetsSummaryForMasterAccount2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Coin`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `coin` ← `Coin`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `network` ← `Network`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1CapitalDepositSubAddressResponse`
- **Error**: `ApiException<SubAccountSpotAssetsSummaryForMasterAccount2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubAccountSpotAssetsSummaryForMasterAccount2Request` | `src/Binance/Requests/SubAccountApi/SubAccountSpotAssetsSummaryForMasterAccount2Request.cs` |
| `SapiV1CapitalDepositSubAddressResponse` | `src/Binance/Models/SapiV1CapitalDepositSubAddressResponse.cs` |
| `SubAccountSpotAssetsSummaryForMasterAccount2Error` | `src/Binance/Errors/SubAccountSpotAssetsSummaryForMasterAccount2Error.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SubAccountTransferHistoryForSubAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubAccountTransferHistoryForSubAccount(SubAccountTransferHistoryForSubAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `type` ← `Type`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountTransferSubUserHistoryResponse>`
- **Error**: `ApiException<SubAccountTransferHistoryForSubAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubAccountTransferHistoryForSubAccountRequest` | `src/Binance/Requests/SubAccountApi/SubAccountTransferHistoryForSubAccountRequest.cs` |
| `SapiV1SubAccountTransferSubUserHistoryResponse` | `src/Binance/Models/SapiV1SubAccountTransferSubUserHistoryResponse.cs` |
| `SubAccountTransferHistoryForSubAccountError` | `src/Binance/Errors/SubAccountTransferHistoryForSubAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SummaryOfSubAccountSFuturesAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SummaryOfSubAccountSFuturesAccountForMasterAccount(SummaryOfSubAccountSFuturesAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountFuturesAccountSummaryResponse`
- **Error**: `ApiException<SummaryOfSubAccountSFuturesAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SummaryOfSubAccountSFuturesAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SummaryOfSubAccountSFuturesAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesAccountSummaryResponse` | `src/Binance/Models/SapiV1SubAccountFuturesAccountSummaryResponse.cs` |
| `SummaryOfSubAccountSFuturesAccountForMasterAccountError` | `src/Binance/Errors/SummaryOfSubAccountSFuturesAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SummaryOfSubAccountSFuturesAccountV2ForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SummaryOfSubAccountSFuturesAccountV2ForMasterAccount(SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FuturesType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `futuresType` ← `FuturesType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `page` ← `Page`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2SubAccountFuturesAccountSummaryResponse`
- **Error**: `ApiException<SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest.cs` |
| `SapiV2SubAccountFuturesAccountSummaryResponse` | `src/Binance/Models/AnyOf/SapiV2SubAccountFuturesAccountSummaryResponse.cs` |
| `SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError` | `src/Binance/Errors/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SummaryOfSubAccountSMarginAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SummaryOfSubAccountSMarginAccountForMasterAccount(SummaryOfSubAccountSMarginAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountMarginAccountSummaryResponse`
- **Error**: `ApiException<SummaryOfSubAccountSMarginAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SummaryOfSubAccountSMarginAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/SummaryOfSubAccountSMarginAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountMarginAccountSummaryResponse` | `src/Binance/Models/SapiV1SubAccountMarginAccountSummaryResponse.cs` |
| `SummaryOfSubAccountSMarginAccountForMasterAccountError` | `src/Binance/Errors/SummaryOfSubAccountSMarginAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### TransferForSubAccountForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TransferForSubAccountForMasterAccount(TransferForSubAccountForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Asset`, `Amount`, `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `asset` ← `Asset`, `amount` ← `Amount`, `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountFuturesTransferResponse`
- **Error**: `ApiException<TransferForSubAccountForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TransferForSubAccountForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/TransferForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesTransferResponse` | `src/Binance/Models/SapiV1SubAccountFuturesTransferResponse.cs` |
| `TransferForSubAccountForMasterAccountError` | `src/Binance/Errors/TransferForSubAccountForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### TransferToMasterForSubAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TransferToMasterForSubAccount(TransferToMasterForSubAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountTransferSubToMasterResponse`
- **Error**: `ApiException<TransferToMasterForSubAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TransferToMasterForSubAccountRequest` | `src/Binance/Requests/SubAccountApi/TransferToMasterForSubAccountRequest.cs` |
| `SapiV1SubAccountTransferSubToMasterResponse` | `src/Binance/Models/SapiV1SubAccountTransferSubToMasterResponse.cs` |
| `TransferToMasterForSubAccountError` | `src/Binance/Errors/TransferToMasterForSubAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### TransferToSubAccountOfSameMasterForSubAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TransferToSubAccountOfSameMasterForSubAccount(TransferToSubAccountOfSameMasterForSubAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ToEmail`, `Asset`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `toEmail` ← `ToEmail`, `asset` ← `Asset`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountTransferSubToSubResponse`
- **Error**: `ApiException<TransferToSubAccountOfSameMasterForSubAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TransferToSubAccountOfSameMasterForSubAccountRequest` | `src/Binance/Requests/SubAccountApi/TransferToSubAccountOfSameMasterForSubAccountRequest.cs` |
| `SapiV1SubAccountTransferSubToSubResponse` | `src/Binance/Models/SapiV1SubAccountTransferSubToSubResponse.cs` |
| `TransferToSubAccountOfSameMasterForSubAccountError` | `src/Binance/Errors/TransferToSubAccountOfSameMasterForSubAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### UniversalTransferForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `UniversalTransferForMasterAccount(UniversalTransferForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FromAccountType`, `ToAccountType`, `Asset`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `fromAccountType` ← `FromAccountType`, `toAccountType` ← `ToAccountType`, `asset` ← `Asset`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `fromEmail` ← `FromEmail`, `toEmail` ← `ToEmail`, `clientTranId` ← `ClientTranId`, `symbol` ← `Symbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1SubAccountUniversalTransferResponse1`
- **Error**: `ApiException<UniversalTransferForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UniversalTransferForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/UniversalTransferForMasterAccountRequest.cs` |
| `FromAccountType` | `src/Binance/Models/Enums/FromAccountType.cs` |
| `ToAccountType` | `src/Binance/Models/Enums/ToAccountType.cs` |
| `SapiV1SubAccountUniversalTransferResponse1` | `src/Binance/Models/SapiV1SubAccountUniversalTransferResponse1.cs` |
| `UniversalTransferForMasterAccountError` | `src/Binance/Errors/UniversalTransferForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### UniversalTransferHistoryForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `UniversalTransferHistoryForMasterAccount(UniversalTransferHistoryForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `fromEmail` ← `FromEmail`, `toEmail` ← `ToEmail`, `clientTranId` ← `ClientTranId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `page` ← `Page`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1SubAccountUniversalTransferResponse>`
- **Error**: `ApiException<UniversalTransferHistoryForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UniversalTransferHistoryForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/UniversalTransferHistoryForMasterAccountRequest.cs` |
| `SapiV1SubAccountUniversalTransferResponse` | `src/Binance/Models/SapiV1SubAccountUniversalTransferResponse.cs` |
| `UniversalTransferHistoryForMasterAccountError` | `src/Binance/Errors/UniversalTransferHistoryForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### UpdateIpRestrictionForSubAccountApiKeyForMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `UpdateIpRestrictionForSubAccountApiKeyForMasterAccount(UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `SubAccountApiKey`, `Status`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `subAccountApiKey` ← `SubAccountApiKey`, `status` ← `Status`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `thirdPartyName` ← `ThirdPartyName`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2SubAccountSubAccountApiIpRestrictionResponse`
- **Error**: `ApiException<UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest.cs` |
| `SapiV2SubAccountSubAccountApiIpRestrictionResponse` | `src/Binance/Models/SapiV2SubAccountSubAccountApiIpRestrictionResponse.cs` |
| `UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError` | `src/Binance/Errors/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount(WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FromEmail`, `Asset`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `fromEmail` ← `FromEmail`, `asset` ← `Asset`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `transferDate` ← `TransferDate`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountWithdrawResponse`
- **Error**: `ApiException<WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest` | `src/Binance/Requests/SubAccountApi/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountWithdrawResponse` | `src/Binance/Models/SapiV1ManagedSubaccountWithdrawResponse.cs` |
| `WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError` | `src/Binance/Errors/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

