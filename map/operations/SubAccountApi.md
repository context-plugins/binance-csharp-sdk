<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubAccountApi — operations

Accessor: `client.SubAccountApi` · Source: `Api/SubAccountApi.cs` · 45 operations

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
| `CreateAVirtualSubAccountForMasterAccountRequest` | `Requests/SubAccountApi/CreateAVirtualSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountVirtualSubAccountResponse` | `Models/SapiV1SubAccountVirtualSubAccountResponse.cs` |
| `CreateAVirtualSubAccountForMasterAccountError` | `Errors/CreateAVirtualSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `DeleteIpListForASubAccountApiKeyForMasterAccountRequest` | `Requests/SubAccountApi/DeleteIpListForASubAccountApiKeyForMasterAccountRequest.cs` |
| `SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse` | `Models/SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse.cs` |
| `DeleteIpListForASubAccountApiKeyForMasterAccountError` | `Errors/DeleteIpListForASubAccountApiKeyForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest` | `Requests/SubAccountApi/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountDepositResponse` | `Models/SapiV1ManagedSubaccountDepositResponse.cs` |
| `DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError` | `Errors/DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `DetailOnSubAccountSFuturesAccountForMasterAccountRequest` | `Requests/SubAccountApi/DetailOnSubAccountSFuturesAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesAccountResponse` | `Models/SapiV1SubAccountFuturesAccountResponse.cs` |
| `DetailOnSubAccountSFuturesAccountForMasterAccountError` | `Errors/DetailOnSubAccountSFuturesAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest` | `Requests/SubAccountApi/DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest.cs` |
| `SapiV2SubAccountFuturesAccountResponse` | `Models/AnyOf/SapiV2SubAccountFuturesAccountResponse.cs` |
| `DetailOnSubAccountSFuturesAccountV2ForMasterAccountError` | `Errors/DetailOnSubAccountSFuturesAccountV2ForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `DetailOnSubAccountSMarginAccountForMasterAccountRequest` | `Requests/SubAccountApi/DetailOnSubAccountSMarginAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountMarginAccountResponse` | `Models/SapiV1SubAccountMarginAccountResponse.cs` |
| `DetailOnSubAccountSMarginAccountForMasterAccountError` | `Errors/DetailOnSubAccountSMarginAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `EnableFuturesForSubAccountForMasterAccountRequest` | `Requests/SubAccountApi/EnableFuturesForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesEnableResponse` | `Models/SapiV1SubAccountFuturesEnableResponse.cs` |
| `EnableFuturesForSubAccountForMasterAccountError` | `Errors/EnableFuturesForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `EnableLeverageTokenForSubAccountForMasterAccountRequest` | `Requests/SubAccountApi/EnableLeverageTokenForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountBlvtEnableResponse` | `Models/SapiV1SubAccountBlvtEnableResponse.cs` |
| `EnableLeverageTokenForSubAccountForMasterAccountError` | `Errors/EnableLeverageTokenForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `EnableMarginForSubAccountForMasterAccountRequest` | `Requests/SubAccountApi/EnableMarginForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountMarginEnableResponse` | `Models/SapiV1SubAccountMarginEnableResponse.cs` |
| `EnableMarginForSubAccountForMasterAccountError` | `Errors/EnableMarginForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `EnableOptionsForSubAccountForMasterAccountUserDataRequest` | `Requests/SubAccountApi/EnableOptionsForSubAccountForMasterAccountUserDataRequest.cs` |
| `SapiV1SubAccountEoptionsEnableResponse` | `Models/SapiV1SubAccountEoptionsEnableResponse.cs` |
| `EnableOptionsForSubAccountForMasterAccountUserDataError` | `Errors/EnableOptionsForSubAccountForMasterAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `FuturesPositionRiskOfSubAccountForMasterAccountRequest` | `Requests/SubAccountApi/FuturesPositionRiskOfSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesPositionRiskResponse` | `Models/SapiV1SubAccountFuturesPositionRiskResponse.cs` |
| `FuturesPositionRiskOfSubAccountForMasterAccountError` | `Errors/FuturesPositionRiskOfSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest` | `Requests/SubAccountApi/FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest.cs` |
| `SapiV2SubAccountFuturesPositionRiskResponse` | `Models/AnyOf/SapiV2SubAccountFuturesPositionRiskResponse.cs` |
| `FuturesPositionRiskOfSubAccountV2ForMasterAccountError` | `Errors/FuturesPositionRiskOfSubAccountV2ForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest` | `Requests/SubAccountApi/GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest.cs` |
| `SapiV1SubAccountSubAccountApiIpRestrictionResponse` | `Models/SapiV1SubAccountSubAccountApiIpRestrictionResponse.cs` |
| `GetIpRestrictionForASubAccountApiKeyForMasterAccountError` | `Errors/GetIpRestrictionForASubAccountApiKeyForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest` | `Requests/SubAccountApi/GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountDepositAddressResponse` | `Models/SapiV1ManagedSubaccountDepositAddressResponse.cs` |
| `GetManagedSubAccountDepositAddressForInvestorMasterAccountError` | `Errors/GetManagedSubAccountDepositAddressForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest` | `Requests/SubAccountApi/ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountAssetResponse` | `Models/SapiV1ManagedSubaccountAssetResponse.cs` |
| `ManagedSubAccountAssetDetailsForInvestorMasterAccountError` | `Errors/ManagedSubAccountAssetDetailsForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

### ManagedSubAccountSnapshotForInvestorMasterAccount

- **Signature**: `ManagedSubAccountSnapshotForInvestorMasterAccount(ManagedSubAccountSnapshotForInvestorMasterAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1ManagedSubaccountAccountSnapshotResponse`
- **Error**: `ApiException<ManagedSubAccountSnapshotForInvestorMasterAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ManagedSubAccountSnapshotForInvestorMasterAccountRequest` | `Requests/SubAccountApi/ManagedSubAccountSnapshotForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountAccountSnapshotResponse` | `Models/SapiV1ManagedSubaccountAccountSnapshotResponse.cs` |
| `ManagedSubAccountSnapshotForInvestorMasterAccountError` | `Errors/ManagedSubAccountSnapshotForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `MarginTransferForSubAccountForMasterAccountRequest` | `Requests/SubAccountApi/MarginTransferForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountMarginTransferResponse` | `Models/SapiV1SubAccountMarginTransferResponse.cs` |
| `MarginTransferForSubAccountForMasterAccountError` | `Errors/MarginTransferForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest` | `Requests/SubAccountApi/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountFetchFutureAssetResponse` | `Models/SapiV1ManagedSubaccountFetchFutureAssetResponse.cs` |
| `QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError` | `Errors/QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryManagedSubAccountListForInvestorRequest` | `Requests/SubAccountApi/QueryManagedSubAccountListForInvestorRequest.cs` |
| `SapiV1ManagedSubaccountInfoResponse` | `Models/SapiV1ManagedSubaccountInfoResponse.cs` |
| `QueryManagedSubAccountListForInvestorError` | `Errors/QueryManagedSubAccountListForInvestorError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest` | `Requests/SubAccountApi/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountMarginAssetResponse` | `Models/SapiV1ManagedSubaccountMarginAssetResponse.cs` |
| `QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError` | `Errors/QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest` | `Requests/SubAccountApi/QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountQueryTransLogForInvestorResponse` | `Models/SapiV1ManagedSubaccountQueryTransLogForInvestorResponse.cs` |
| `QueryManagedSubAccountTransferLogForInvestorMasterAccountError` | `Errors/QueryManagedSubAccountTransferLogForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest` | `Requests/SubAccountApi/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse` | `Models/SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse.cs` |
| `QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError` | `Errors/QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest` | `Requests/SubAccountApi/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest.cs` |
| `Transfers` | `Models/Enums/Transfers.cs` |
| `TransferFunctionAccountType` | `Models/Enums/TransferFunctionAccountType.cs` |
| `SapiV1ManagedSubaccountQueryTransLogResponse` | `Models/SapiV1ManagedSubaccountQueryTransLogResponse.cs` |
| `QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError` | `Errors/QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QuerySubAccountAssetsForMasterAccountRequest` | `Requests/SubAccountApi/QuerySubAccountAssetsForMasterAccountRequest.cs` |
| `SapiV4SubAccountAssetsResponse` | `Models/SapiV4SubAccountAssetsResponse.cs` |
| `QuerySubAccountAssetsForMasterAccountError` | `Errors/QuerySubAccountAssetsForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QuerySubAccountListForMasterAccountRequest` | `Requests/SubAccountApi/QuerySubAccountListForMasterAccountRequest.cs` |
| `IsFreeze` | `Models/Enums/IsFreeze.cs` |
| `SapiV1SubAccountListResponse` | `Models/SapiV1SubAccountListResponse.cs` |
| `QuerySubAccountListForMasterAccountError` | `Errors/QuerySubAccountListForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `QuerySubAccountTransactionStatisticsForMasterAccountRequest` | `Requests/SubAccountApi/QuerySubAccountTransactionStatisticsForMasterAccountRequest.cs` |
| `SapiV1SubAccountTransactionStatisticsResponse` | `Models/SapiV1SubAccountTransactionStatisticsResponse.cs` |
| `QuerySubAccountTransactionStatisticsForMasterAccountError` | `Errors/QuerySubAccountTransactionStatisticsForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubAccountAssetsForMasterAccountRequest` | `Requests/SubAccountApi/SubAccountAssetsForMasterAccountRequest.cs` |
| `SapiV3SubAccountAssetsResponse` | `Models/SapiV3SubAccountAssetsResponse.cs` |
| `SubAccountAssetsForMasterAccountError` | `Errors/SubAccountAssetsForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubAccountDepositHistoryForMasterAccountRequest` | `Requests/SubAccountApi/SubAccountDepositHistoryForMasterAccountRequest.cs` |
| `SapiV1CapitalDepositSubHisrecResponse` | `Models/SapiV1CapitalDepositSubHisrecResponse.cs` |
| `SubAccountDepositHistoryForMasterAccountError` | `Errors/SubAccountDepositHistoryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubAccountFuturesAssetTransferForMasterAccountRequest` | `Requests/SubAccountApi/SubAccountFuturesAssetTransferForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesInternalTransferResponse1` | `Models/SapiV1SubAccountFuturesInternalTransferResponse1.cs` |
| `SubAccountFuturesAssetTransferForMasterAccountError` | `Errors/SubAccountFuturesAssetTransferForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubAccountFuturesAssetTransferHistoryForMasterAccountRequest` | `Requests/SubAccountApi/SubAccountFuturesAssetTransferHistoryForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesInternalTransferResponse` | `Models/SapiV1SubAccountFuturesInternalTransferResponse.cs` |
| `SubAccountFuturesAssetTransferHistoryForMasterAccountError` | `Errors/SubAccountFuturesAssetTransferHistoryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubAccountSStatusOnMarginFuturesForMasterAccountRequest` | `Requests/SubAccountApi/SubAccountSStatusOnMarginFuturesForMasterAccountRequest.cs` |
| `SapiV1SubAccountStatusResponse` | `Models/SapiV1SubAccountStatusResponse.cs` |
| `SubAccountSStatusOnMarginFuturesForMasterAccountError` | `Errors/SubAccountSStatusOnMarginFuturesForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubAccountSpotAssetTransferHistoryForMasterAccountRequest` | `Requests/SubAccountApi/SubAccountSpotAssetTransferHistoryForMasterAccountRequest.cs` |
| `SapiV1SubAccountSubTransferHistoryResponse` | `Models/SapiV1SubAccountSubTransferHistoryResponse.cs` |
| `SubAccountSpotAssetTransferHistoryForMasterAccountError` | `Errors/SubAccountSpotAssetTransferHistoryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubAccountSpotAssetsSummaryForMasterAccountRequest` | `Requests/SubAccountApi/SubAccountSpotAssetsSummaryForMasterAccountRequest.cs` |
| `SapiV1SubAccountSpotSummaryResponse` | `Models/SapiV1SubAccountSpotSummaryResponse.cs` |
| `SubAccountSpotAssetsSummaryForMasterAccountError` | `Errors/SubAccountSpotAssetsSummaryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubAccountSpotAssetsSummaryForMasterAccount2Request` | `Requests/SubAccountApi/SubAccountSpotAssetsSummaryForMasterAccount2Request.cs` |
| `SapiV1CapitalDepositSubAddressResponse` | `Models/SapiV1CapitalDepositSubAddressResponse.cs` |
| `SubAccountSpotAssetsSummaryForMasterAccount2Error` | `Errors/SubAccountSpotAssetsSummaryForMasterAccount2Error.cs` |
| `Error` | `Models/Error.cs` |

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
| `SubAccountTransferHistoryForSubAccountRequest` | `Requests/SubAccountApi/SubAccountTransferHistoryForSubAccountRequest.cs` |
| `SapiV1SubAccountTransferSubUserHistoryResponse` | `Models/SapiV1SubAccountTransferSubUserHistoryResponse.cs` |
| `SubAccountTransferHistoryForSubAccountError` | `Errors/SubAccountTransferHistoryForSubAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SummaryOfSubAccountSFuturesAccountForMasterAccountRequest` | `Requests/SubAccountApi/SummaryOfSubAccountSFuturesAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesAccountSummaryResponse` | `Models/SapiV1SubAccountFuturesAccountSummaryResponse.cs` |
| `SummaryOfSubAccountSFuturesAccountForMasterAccountError` | `Errors/SummaryOfSubAccountSFuturesAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest` | `Requests/SubAccountApi/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest.cs` |
| `SapiV2SubAccountFuturesAccountSummaryResponse` | `Models/AnyOf/SapiV2SubAccountFuturesAccountSummaryResponse.cs` |
| `SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError` | `Errors/SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `SummaryOfSubAccountSMarginAccountForMasterAccountRequest` | `Requests/SubAccountApi/SummaryOfSubAccountSMarginAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountMarginAccountSummaryResponse` | `Models/SapiV1SubAccountMarginAccountSummaryResponse.cs` |
| `SummaryOfSubAccountSMarginAccountForMasterAccountError` | `Errors/SummaryOfSubAccountSMarginAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `TransferForSubAccountForMasterAccountRequest` | `Requests/SubAccountApi/TransferForSubAccountForMasterAccountRequest.cs` |
| `SapiV1SubAccountFuturesTransferResponse` | `Models/SapiV1SubAccountFuturesTransferResponse.cs` |
| `TransferForSubAccountForMasterAccountError` | `Errors/TransferForSubAccountForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `TransferToMasterForSubAccountRequest` | `Requests/SubAccountApi/TransferToMasterForSubAccountRequest.cs` |
| `SapiV1SubAccountTransferSubToMasterResponse` | `Models/SapiV1SubAccountTransferSubToMasterResponse.cs` |
| `TransferToMasterForSubAccountError` | `Errors/TransferToMasterForSubAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `TransferToSubAccountOfSameMasterForSubAccountRequest` | `Requests/SubAccountApi/TransferToSubAccountOfSameMasterForSubAccountRequest.cs` |
| `SapiV1SubAccountTransferSubToSubResponse` | `Models/SapiV1SubAccountTransferSubToSubResponse.cs` |
| `TransferToSubAccountOfSameMasterForSubAccountError` | `Errors/TransferToSubAccountOfSameMasterForSubAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `UniversalTransferForMasterAccountRequest` | `Requests/SubAccountApi/UniversalTransferForMasterAccountRequest.cs` |
| `FromAccountType` | `Models/Enums/FromAccountType.cs` |
| `ToAccountType` | `Models/Enums/ToAccountType.cs` |
| `SapiV1SubAccountUniversalTransferResponse1` | `Models/SapiV1SubAccountUniversalTransferResponse1.cs` |
| `UniversalTransferForMasterAccountError` | `Errors/UniversalTransferForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `UniversalTransferHistoryForMasterAccountRequest` | `Requests/SubAccountApi/UniversalTransferHistoryForMasterAccountRequest.cs` |
| `SapiV1SubAccountUniversalTransferResponse` | `Models/SapiV1SubAccountUniversalTransferResponse.cs` |
| `UniversalTransferHistoryForMasterAccountError` | `Errors/UniversalTransferHistoryForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest` | `Requests/SubAccountApi/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest.cs` |
| `SapiV2SubAccountSubAccountApiIpRestrictionResponse` | `Models/SapiV2SubAccountSubAccountApiIpRestrictionResponse.cs` |
| `UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError` | `Errors/UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

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
| `WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest` | `Requests/SubAccountApi/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest.cs` |
| `SapiV1ManagedSubaccountWithdrawResponse` | `Models/SapiV1ManagedSubaccountWithdrawResponse.cs` |
| `WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError` | `Errors/WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError.cs` |
| `Error` | `Models/Error.cs` |

