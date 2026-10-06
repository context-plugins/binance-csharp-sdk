<!-- Generated file — do not edit; regenerated with the SDK. -->

# Wallet — operations

Accessor: `client.Wallet` · Source: `Api/Wallet.cs` · 34 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountApiTradingStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AccountApiTradingStatusUserData(AccountApiTradingStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AccountApiTradingStatusResponse`
- **Error**: `ApiException<AccountApiTradingStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountApiTradingStatusUserDataRequest` | `Requests/Wallet/AccountApiTradingStatusUserDataRequest.cs` |
| `SapiV1AccountApiTradingStatusResponse` | `Models/SapiV1AccountApiTradingStatusResponse.cs` |
| `AccountApiTradingStatusUserDataError` | `Errors/AccountApiTradingStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AccountInfoUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AccountInfoUserData(AccountInfoUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AccountInfoResponse`
- **Error**: `ApiException<AccountInfoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountInfoUserDataRequest` | `Requests/Wallet/AccountInfoUserDataRequest.cs` |
| `SapiV1AccountInfoResponse` | `Models/SapiV1AccountInfoResponse.cs` |
| `AccountInfoUserDataError` | `Errors/AccountInfoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AccountStatusUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AccountStatusUserData(AccountStatusUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AccountStatusResponse`
- **Error**: `ApiException<AccountStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountStatusUserDataRequest` | `Requests/Wallet/AccountStatusUserDataRequest.cs` |
| `SapiV1AccountStatusResponse` | `Models/SapiV1AccountStatusResponse.cs` |
| `AccountStatusUserDataError` | `Errors/AccountStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AllCoinsInformationUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AllCoinsInformationUserData(AllCoinsInformationUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalConfigGetallResponse>`
- **Error**: `ApiException<AllCoinsInformationUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AllCoinsInformationUserDataRequest` | `Requests/Wallet/AllCoinsInformationUserDataRequest.cs` |
| `SapiV1CapitalConfigGetallResponse` | `Models/SapiV1CapitalConfigGetallResponse.cs` |
| `AllCoinsInformationUserDataError` | `Errors/AllCoinsInformationUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AssetDetailUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AssetDetailUserData(AssetDetailUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetAssetDetailResponse`
- **Error**: `ApiException<AssetDetailUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AssetDetailUserDataRequest` | `Requests/Wallet/AssetDetailUserDataRequest.cs` |
| `SapiV1AssetAssetDetailResponse` | `Models/SapiV1AssetAssetDetailResponse.cs` |
| `AssetDetailUserDataError` | `Errors/AssetDetailUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AssetDividendRecordUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `AssetDividendRecordUserData(AssetDividendRecordUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetAssetDividendResponse`
- **Error**: `ApiException<AssetDividendRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AssetDividendRecordUserDataRequest` | `Requests/Wallet/AssetDividendRecordUserDataRequest.cs` |
| `SapiV1AssetAssetDividendResponse` | `Models/SapiV1AssetAssetDividendResponse.cs` |
| `AssetDividendRecordUserDataError` | `Errors/AssetDividendRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### ConvertTransferUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `ConvertTransferUserData(ConvertTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClientTranId`, `Asset`, `Amount`, `TargetAsset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `clientTranId` ← `ClientTranId`, `asset` ← `Asset`, `amount` ← `Amount`, `targetAsset` ← `TargetAsset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetConvertTransferResponse`
- **Error**: `ApiException<ConvertTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ConvertTransferUserDataRequest` | `Requests/Wallet/ConvertTransferUserDataRequest.cs` |
| `SapiV1AssetConvertTransferResponse` | `Models/SapiV1AssetConvertTransferResponse.cs` |
| `ConvertTransferUserDataError` | `Errors/ConvertTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DailyAccountSnapshotUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DailyAccountSnapshotUserData(DailyAccountSnapshotUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AccountSnapshotResponse`
- **Error**: `ApiException<DailyAccountSnapshotUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DailyAccountSnapshotUserDataRequest` | `Requests/Wallet/DailyAccountSnapshotUserDataRequest.cs` |
| `Type6` | `Models/Enums/Type6.cs` |
| `SapiV1AccountSnapshotResponse` | `Models/AnyOf/SapiV1AccountSnapshotResponse.cs` |
| `DailyAccountSnapshotUserDataError` | `Errors/DailyAccountSnapshotUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DepositAddressSupportingNetworkUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DepositAddressSupportingNetworkUserData(DepositAddressSupportingNetworkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Coin`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `coin` ← `Coin`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `network` ← `Network`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1CapitalDepositAddressResponse`
- **Error**: `ApiException<DepositAddressSupportingNetworkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DepositAddressSupportingNetworkUserDataRequest` | `Requests/Wallet/DepositAddressSupportingNetworkUserDataRequest.cs` |
| `SapiV1CapitalDepositAddressResponse` | `Models/SapiV1CapitalDepositAddressResponse.cs` |
| `DepositAddressSupportingNetworkUserDataError` | `Errors/DepositAddressSupportingNetworkUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DepositHistorySupportingNetworkUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DepositHistorySupportingNetworkUserData(DepositHistorySupportingNetworkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `coin` ← `Coin`, `status` ← `Status`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `offset` ← `Offset`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalDepositHisrecResponse>`
- **Error**: `ApiException<DepositHistorySupportingNetworkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DepositHistorySupportingNetworkUserDataRequest` | `Requests/Wallet/DepositHistorySupportingNetworkUserDataRequest.cs` |
| `SapiV1CapitalDepositHisrecResponse` | `Models/SapiV1CapitalDepositHisrecResponse.cs` |
| `DepositHistorySupportingNetworkUserDataError` | `Errors/DepositHistorySupportingNetworkUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DisableFastWithdrawSwitchUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DisableFastWithdrawSwitchUserData(DisableFastWithdrawSwitchUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `object`
- **Error**: `ApiException<DisableFastWithdrawSwitchUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DisableFastWithdrawSwitchUserDataRequest` | `Requests/Wallet/DisableFastWithdrawSwitchUserDataRequest.cs` |
| `DisableFastWithdrawSwitchUserDataError` | `Errors/DisableFastWithdrawSwitchUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DustLogUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DustLogUserData(DustLogUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `accountType` ← `AccountType`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetDribbletResponse`
- **Error**: `ApiException<DustLogUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DustLogUserDataRequest` | `Requests/Wallet/DustLogUserDataRequest.cs` |
| `AccountType` | `Models/Enums/AccountType.cs` |
| `SapiV1AssetDribbletResponse` | `Models/SapiV1AssetDribbletResponse.cs` |
| `DustLogUserDataError` | `Errors/DustLogUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DustTransferUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DustTransferUserData(DustTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Asset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `asset` ← `Asset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `accountType` ← `AccountType`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetDustResponse`
- **Error**: `ApiException<DustTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DustTransferUserDataRequest` | `Requests/Wallet/DustTransferUserDataRequest.cs` |
| `AccountType` | `Models/Enums/AccountType.cs` |
| `SapiV1AssetDustResponse` | `Models/SapiV1AssetDustResponse.cs` |
| `DustTransferUserDataError` | `Errors/DustTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### EnableFastWithdrawSwitchUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EnableFastWithdrawSwitchUserData(EnableFastWithdrawSwitchUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `object`
- **Error**: `ApiException<EnableFastWithdrawSwitchUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableFastWithdrawSwitchUserDataRequest` | `Requests/Wallet/EnableFastWithdrawSwitchUserDataRequest.cs` |
| `EnableFastWithdrawSwitchUserDataError` | `Errors/EnableFastWithdrawSwitchUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FetchDepositAddressListWithNetworkUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FetchDepositAddressListWithNetworkUserData(FetchDepositAddressListWithNetworkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Coin`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `coin` ← `Coin`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `network` ← `Network`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalDepositAddressListResponse>`
- **Error**: `ApiException<FetchDepositAddressListWithNetworkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FetchDepositAddressListWithNetworkUserDataRequest` | `Requests/Wallet/FetchDepositAddressListWithNetworkUserDataRequest.cs` |
| `SapiV1CapitalDepositAddressListResponse` | `Models/SapiV1CapitalDepositAddressListResponse.cs` |
| `FetchDepositAddressListWithNetworkUserDataError` | `Errors/FetchDepositAddressListWithNetworkUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FetchWithdrawAddressListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FetchWithdrawAddressListUserData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1CapitalWithdrawAddressListResponse>`
- **Error**: `ApiException<FetchWithdrawAddressListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalWithdrawAddressListResponse` | `Models/SapiV1CapitalWithdrawAddressListResponse.cs` |
| `FetchWithdrawAddressListUserDataError` | `Errors/FetchWithdrawAddressListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FundingWalletUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FundingWalletUserData(FundingWalletUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `needBtcValuation` ← `NeedBtcValuation`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1AssetGetFundingAssetResponse>`
- **Error**: `ApiException<FundingWalletUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FundingWalletUserDataRequest` | `Requests/Wallet/FundingWalletUserDataRequest.cs` |
| `NeedBtcValuation` | `Models/Enums/NeedBtcValuation.cs` |
| `SapiV1AssetGetFundingAssetResponse` | `Models/SapiV1AssetGetFundingAssetResponse.cs` |
| `FundingWalletUserDataError` | `Errors/FundingWalletUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetApiKeyPermissionUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetApiKeyPermissionUserData(GetApiKeyPermissionUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AccountApiRestrictionsResponse`
- **Error**: `ApiException<GetApiKeyPermissionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetApiKeyPermissionUserDataRequest` | `Requests/Wallet/GetApiKeyPermissionUserDataRequest.cs` |
| `SapiV1AccountApiRestrictionsResponse` | `Models/SapiV1AccountApiRestrictionsResponse.cs` |
| `GetApiKeyPermissionUserDataError` | `Errors/GetApiKeyPermissionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetAssetsThatCanBeConvertedIntoBnbUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetAssetsThatCanBeConvertedIntoBnbUserData(GetAssetsThatCanBeConvertedIntoBnbUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `accountType` ← `AccountType`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetDustBtcResponse`
- **Error**: `ApiException<GetAssetsThatCanBeConvertedIntoBnbUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAssetsThatCanBeConvertedIntoBnbUserDataRequest` | `Requests/Wallet/GetAssetsThatCanBeConvertedIntoBnbUserDataRequest.cs` |
| `AccountType` | `Models/Enums/AccountType.cs` |
| `SapiV1AssetDustBtcResponse` | `Models/SapiV1AssetDustBtcResponse.cs` |
| `GetAssetsThatCanBeConvertedIntoBnbUserDataError` | `Errors/GetAssetsThatCanBeConvertedIntoBnbUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCloudMiningPaymentAndRefundHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCloudMiningPaymentAndRefundHistoryUserData(GetCloudMiningPaymentAndRefundHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StartTime`, `EndTime`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `startTime` ← `StartTime`, `endTime` ← `EndTime`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `tranId` ← `TranId`, `clientTranId` ← `ClientTranId`, `asset` ← `Asset`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse`
- **Error**: `ApiException<GetCloudMiningPaymentAndRefundHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCloudMiningPaymentAndRefundHistoryUserDataRequest` | `Requests/Wallet/GetCloudMiningPaymentAndRefundHistoryUserDataRequest.cs` |
| `SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse` | `Models/SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse.cs` |
| `GetCloudMiningPaymentAndRefundHistoryUserDataError` | `Errors/GetCloudMiningPaymentAndRefundHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetSymbolsDelistScheduleForSpotMarketData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSymbolsDelistScheduleForSpotMarketData(GetSymbolsDelistScheduleForSpotMarketDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1SpotDelistScheduleResponse>`
- **Error**: `ApiException<GetSymbolsDelistScheduleForSpotMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSymbolsDelistScheduleForSpotMarketDataRequest` | `Requests/Wallet/GetSymbolsDelistScheduleForSpotMarketDataRequest.cs` |
| `SapiV1SpotDelistScheduleResponse` | `Models/SapiV1SpotDelistScheduleResponse.cs` |
| `GetSymbolsDelistScheduleForSpotMarketDataError` | `Errors/GetSymbolsDelistScheduleForSpotMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### OneClickArrivalDepositApplyUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `OneClickArrivalDepositApplyUserData(OneClickArrivalDepositApplyUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `depositId` ← `DepositId`, `txId` ← `TxId`, `subAccountId` ← `SubAccountId`, `subUserId` ← `SubUserId`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1CapitalDepositCreditApplyResponse`
- **Error**: `ApiException<OneClickArrivalDepositApplyUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OneClickArrivalDepositApplyUserDataRequest` | `Requests/Wallet/OneClickArrivalDepositApplyUserDataRequest.cs` |
| `SapiV1CapitalDepositCreditApplyResponse` | `Models/SapiV1CapitalDepositCreditApplyResponse.cs` |
| `OneClickArrivalDepositApplyUserDataError` | `Errors/OneClickArrivalDepositApplyUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryAutoConvertingStableCoinsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryAutoConvertingStableCoinsUserData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1CapitalContractConvertibleCoinsResponse`
- **Error**: `ApiException<QueryAutoConvertingStableCoinsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalContractConvertibleCoinsResponse` | `Models/SapiV1CapitalContractConvertibleCoinsResponse.cs` |
| `QueryAutoConvertingStableCoinsUserDataError` | `Errors/QueryAutoConvertingStableCoinsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryConvertTransferUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryConvertTransferUserData(QueryConvertTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StartTime`, `EndTime`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `startTime` ← `StartTime`, `endTime` ← `EndTime`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `tranId` ← `TranId`, `asset` ← `Asset`, `accountType` ← `AccountType`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetConvertTransferQueryByPageResponse`
- **Error**: `ApiException<QueryConvertTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryConvertTransferUserDataRequest` | `Requests/Wallet/QueryConvertTransferUserDataRequest.cs` |
| `AccountType3` | `Models/Enums/AccountType3.cs` |
| `SapiV1AssetConvertTransferQueryByPageResponse` | `Models/SapiV1AssetConvertTransferQueryByPageResponse.cs` |
| `QueryConvertTransferUserDataError` | `Errors/QueryConvertTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryUserDelegationHistoryForMasterAccountUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryUserDelegationHistoryForMasterAccountUserData(QueryUserDelegationHistoryForMasterAccountUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Email`, `StartTime`, `EndTime`, `Asset`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `email` ← `Email`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `asset` ← `Asset`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `type` ← `Type`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetCustodyTransferHistoryResponse`
- **Error**: `ApiException<QueryUserDelegationHistoryForMasterAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryUserDelegationHistoryForMasterAccountUserDataRequest` | `Requests/Wallet/QueryUserDelegationHistoryForMasterAccountUserDataRequest.cs` |
| `SapiV1AssetCustodyTransferHistoryResponse` | `Models/SapiV1AssetCustodyTransferHistoryResponse.cs` |
| `QueryUserDelegationHistoryForMasterAccountUserDataError` | `Errors/QueryUserDelegationHistoryForMasterAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryUserUniversalTransferHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryUserUniversalTransferHistoryUserData(QueryUserUniversalTransferHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Type`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `type` ← `Type`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `fromSymbol` ← `FromSymbol`, `toSymbol` ← `ToSymbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetTransferResponse`
- **Error**: `ApiException<QueryUserUniversalTransferHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryUserUniversalTransferHistoryUserDataRequest` | `Requests/Wallet/QueryUserUniversalTransferHistoryUserDataRequest.cs` |
| `Type7` | `Models/Enums/Type7.cs` |
| `SapiV1AssetTransferResponse` | `Models/SapiV1AssetTransferResponse.cs` |
| `QueryUserUniversalTransferHistoryUserDataError` | `Errors/QueryUserUniversalTransferHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryUserWalletBalanceUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryUserWalletBalanceUserData(QueryUserWalletBalanceUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1AssetWalletBalanceResponse>`
- **Error**: `ApiException<QueryUserWalletBalanceUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryUserWalletBalanceUserDataRequest` | `Requests/Wallet/QueryUserWalletBalanceUserDataRequest.cs` |
| `SapiV1AssetWalletBalanceResponse` | `Models/SapiV1AssetWalletBalanceResponse.cs` |
| `QueryUserWalletBalanceUserDataError` | `Errors/QueryUserWalletBalanceUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SwitchOnOffBusdAndStableCoinsConversionUserDataUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SwitchOnOffBusdAndStableCoinsConversionUserDataUserData(SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Coin`, `Enable`
- **Query params (wire ← C#)**: `coin` ← `Coin`, `enable` ← `Enable`
- **Returns**: `object`
- **Error**: `ApiException<SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest` | `Requests/Wallet/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest.cs` |
| `SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError` | `Errors/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SystemStatusSystem

- **Signature**: `SystemStatusSystem(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1SystemStatusResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SapiV1SystemStatusResponse` | `Models/SapiV1SystemStatusResponse.cs` |

### TradeFeeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TradeFeeUserData(TradeFeeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `symbol` ← `Symbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1AssetTradeFeeResponse>`
- **Error**: `ApiException<TradeFeeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TradeFeeUserDataRequest` | `Requests/Wallet/TradeFeeUserDataRequest.cs` |
| `SapiV1AssetTradeFeeResponse` | `Models/SapiV1AssetTradeFeeResponse.cs` |
| `TradeFeeUserDataError` | `Errors/TradeFeeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### UserAssetUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `UserAssetUserData(UserAssetUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `needBtcValuation` ← `NeedBtcValuation`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV3AssetGetUserAssetResponse>`
- **Error**: `ApiException<UserAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UserAssetUserDataRequest` | `Requests/Wallet/UserAssetUserDataRequest.cs` |
| `NeedBtcValuation` | `Models/Enums/NeedBtcValuation.cs` |
| `SapiV3AssetGetUserAssetResponse` | `Models/SapiV3AssetGetUserAssetResponse.cs` |
| `UserAssetUserDataError` | `Errors/UserAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### UserUniversalTransferUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `UserUniversalTransferUserData(UserUniversalTransferUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Type`, `Asset`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `type` ← `Type`, `asset` ← `Asset`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `fromSymbol` ← `FromSymbol`, `toSymbol` ← `ToSymbol`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1AssetTransferResponse1`
- **Error**: `ApiException<UserUniversalTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UserUniversalTransferUserDataRequest` | `Requests/Wallet/UserUniversalTransferUserDataRequest.cs` |
| `Type7` | `Models/Enums/Type7.cs` |
| `SapiV1AssetTransferResponse1` | `Models/SapiV1AssetTransferResponse1.cs` |
| `UserUniversalTransferUserDataError` | `Errors/UserUniversalTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### WithdrawHistorySupportingNetworkUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `WithdrawHistorySupportingNetworkUserData(WithdrawHistorySupportingNetworkUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `coin` ← `Coin`, `withdrawOrderId` ← `WithdrawOrderId`, `status` ← `Status`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `offset` ← `Offset`, `limit` ← `Limit`, `recvWindow` ← `RecvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalWithdrawHistoryResponse>`
- **Error**: `ApiException<WithdrawHistorySupportingNetworkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `WithdrawHistorySupportingNetworkUserDataRequest` | `Requests/Wallet/WithdrawHistorySupportingNetworkUserDataRequest.cs` |
| `SapiV1CapitalWithdrawHistoryResponse` | `Models/SapiV1CapitalWithdrawHistoryResponse.cs` |
| `WithdrawHistorySupportingNetworkUserDataError` | `Errors/WithdrawHistorySupportingNetworkUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### WithdrawUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `WithdrawUserData(WithdrawUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Coin`, `Address`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `coin` ← `Coin`, `address` ← `Address`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `withdrawOrderId` ← `WithdrawOrderId`, `network` ← `Network`, `addressTag` ← `AddressTag`, `transactionFeeFlag` ← `TransactionFeeFlag`, `name` ← `Name`, `walletType` ← `WalletType`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1CapitalWithdrawApplyResponse`
- **Error**: `ApiException<WithdrawUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `WithdrawUserDataRequest` | `Requests/Wallet/WithdrawUserDataRequest.cs` |
| `SapiV1CapitalWithdrawApplyResponse` | `Models/SapiV1CapitalWithdrawApplyResponse.cs` |
| `WithdrawUserDataError` | `Errors/WithdrawUserDataError.cs` |
| `Error` | `Models/Error.cs` |

