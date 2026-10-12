<!-- Generated file — do not edit; regenerated with the SDK. -->

# Wallet — operations

Accessor: `client.Wallet` · Source: `src/Binance/Api/Wallet.cs` · 34 operations

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
| `AccountApiTradingStatusUserDataRequest` | `src/Binance/Requests/Wallet/AccountApiTradingStatusUserDataRequest.cs` |
| `SapiV1AccountApiTradingStatusResponse` | `src/Binance/Models/SapiV1AccountApiTradingStatusResponse.cs` |
| `AccountApiTradingStatusUserDataError` | `src/Binance/Errors/AccountApiTradingStatusUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `AccountInfoUserDataRequest` | `src/Binance/Requests/Wallet/AccountInfoUserDataRequest.cs` |
| `SapiV1AccountInfoResponse` | `src/Binance/Models/SapiV1AccountInfoResponse.cs` |
| `AccountInfoUserDataError` | `src/Binance/Errors/AccountInfoUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `AccountStatusUserDataRequest` | `src/Binance/Requests/Wallet/AccountStatusUserDataRequest.cs` |
| `SapiV1AccountStatusResponse` | `src/Binance/Models/SapiV1AccountStatusResponse.cs` |
| `AccountStatusUserDataError` | `src/Binance/Errors/AccountStatusUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `AllCoinsInformationUserDataRequest` | `src/Binance/Requests/Wallet/AllCoinsInformationUserDataRequest.cs` |
| `SapiV1CapitalConfigGetallResponse` | `src/Binance/Models/SapiV1CapitalConfigGetallResponse.cs` |
| `AllCoinsInformationUserDataError` | `src/Binance/Errors/AllCoinsInformationUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `AssetDetailUserDataRequest` | `src/Binance/Requests/Wallet/AssetDetailUserDataRequest.cs` |
| `SapiV1AssetAssetDetailResponse` | `src/Binance/Models/SapiV1AssetAssetDetailResponse.cs` |
| `AssetDetailUserDataError` | `src/Binance/Errors/AssetDetailUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `AssetDividendRecordUserDataRequest` | `src/Binance/Requests/Wallet/AssetDividendRecordUserDataRequest.cs` |
| `SapiV1AssetAssetDividendResponse` | `src/Binance/Models/SapiV1AssetAssetDividendResponse.cs` |
| `AssetDividendRecordUserDataError` | `src/Binance/Errors/AssetDividendRecordUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `ConvertTransferUserDataRequest` | `src/Binance/Requests/Wallet/ConvertTransferUserDataRequest.cs` |
| `SapiV1AssetConvertTransferResponse` | `src/Binance/Models/SapiV1AssetConvertTransferResponse.cs` |
| `ConvertTransferUserDataError` | `src/Binance/Errors/ConvertTransferUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `DailyAccountSnapshotUserDataRequest` | `src/Binance/Requests/Wallet/DailyAccountSnapshotUserDataRequest.cs` |
| `Type6` | `src/Binance/Models/Enums/Type6.cs` |
| `SapiV1AccountSnapshotResponse` | `src/Binance/Models/AnyOf/SapiV1AccountSnapshotResponse.cs` |
| `DailyAccountSnapshotUserDataError` | `src/Binance/Errors/DailyAccountSnapshotUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `DepositAddressSupportingNetworkUserDataRequest` | `src/Binance/Requests/Wallet/DepositAddressSupportingNetworkUserDataRequest.cs` |
| `SapiV1CapitalDepositAddressResponse` | `src/Binance/Models/SapiV1CapitalDepositAddressResponse.cs` |
| `DepositAddressSupportingNetworkUserDataError` | `src/Binance/Errors/DepositAddressSupportingNetworkUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `DepositHistorySupportingNetworkUserDataRequest` | `src/Binance/Requests/Wallet/DepositHistorySupportingNetworkUserDataRequest.cs` |
| `SapiV1CapitalDepositHisrecResponse` | `src/Binance/Models/SapiV1CapitalDepositHisrecResponse.cs` |
| `DepositHistorySupportingNetworkUserDataError` | `src/Binance/Errors/DepositHistorySupportingNetworkUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `DisableFastWithdrawSwitchUserDataRequest` | `src/Binance/Requests/Wallet/DisableFastWithdrawSwitchUserDataRequest.cs` |
| `DisableFastWithdrawSwitchUserDataError` | `src/Binance/Errors/DisableFastWithdrawSwitchUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `DustLogUserDataRequest` | `src/Binance/Requests/Wallet/DustLogUserDataRequest.cs` |
| `AccountType` | `src/Binance/Models/Enums/AccountType.cs` |
| `SapiV1AssetDribbletResponse` | `src/Binance/Models/SapiV1AssetDribbletResponse.cs` |
| `DustLogUserDataError` | `src/Binance/Errors/DustLogUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `DustTransferUserDataRequest` | `src/Binance/Requests/Wallet/DustTransferUserDataRequest.cs` |
| `AccountType` | `src/Binance/Models/Enums/AccountType.cs` |
| `SapiV1AssetDustResponse` | `src/Binance/Models/SapiV1AssetDustResponse.cs` |
| `DustTransferUserDataError` | `src/Binance/Errors/DustTransferUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `EnableFastWithdrawSwitchUserDataRequest` | `src/Binance/Requests/Wallet/EnableFastWithdrawSwitchUserDataRequest.cs` |
| `EnableFastWithdrawSwitchUserDataError` | `src/Binance/Errors/EnableFastWithdrawSwitchUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `FetchDepositAddressListWithNetworkUserDataRequest` | `src/Binance/Requests/Wallet/FetchDepositAddressListWithNetworkUserDataRequest.cs` |
| `SapiV1CapitalDepositAddressListResponse` | `src/Binance/Models/SapiV1CapitalDepositAddressListResponse.cs` |
| `FetchDepositAddressListWithNetworkUserDataError` | `src/Binance/Errors/FetchDepositAddressListWithNetworkUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### FetchWithdrawAddressListUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FetchWithdrawAddressListUserData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<SapiV1CapitalWithdrawAddressListResponse>`
- **Error**: `ApiException<FetchWithdrawAddressListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalWithdrawAddressListResponse` | `src/Binance/Models/SapiV1CapitalWithdrawAddressListResponse.cs` |
| `FetchWithdrawAddressListUserDataError` | `src/Binance/Errors/FetchWithdrawAddressListUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `FundingWalletUserDataRequest` | `src/Binance/Requests/Wallet/FundingWalletUserDataRequest.cs` |
| `NeedBtcValuation` | `src/Binance/Models/Enums/NeedBtcValuation.cs` |
| `SapiV1AssetGetFundingAssetResponse` | `src/Binance/Models/SapiV1AssetGetFundingAssetResponse.cs` |
| `FundingWalletUserDataError` | `src/Binance/Errors/FundingWalletUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetApiKeyPermissionUserDataRequest` | `src/Binance/Requests/Wallet/GetApiKeyPermissionUserDataRequest.cs` |
| `SapiV1AccountApiRestrictionsResponse` | `src/Binance/Models/SapiV1AccountApiRestrictionsResponse.cs` |
| `GetApiKeyPermissionUserDataError` | `src/Binance/Errors/GetApiKeyPermissionUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetAssetsThatCanBeConvertedIntoBnbUserDataRequest` | `src/Binance/Requests/Wallet/GetAssetsThatCanBeConvertedIntoBnbUserDataRequest.cs` |
| `AccountType` | `src/Binance/Models/Enums/AccountType.cs` |
| `SapiV1AssetDustBtcResponse` | `src/Binance/Models/SapiV1AssetDustBtcResponse.cs` |
| `GetAssetsThatCanBeConvertedIntoBnbUserDataError` | `src/Binance/Errors/GetAssetsThatCanBeConvertedIntoBnbUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetCloudMiningPaymentAndRefundHistoryUserDataRequest` | `src/Binance/Requests/Wallet/GetCloudMiningPaymentAndRefundHistoryUserDataRequest.cs` |
| `SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse` | `src/Binance/Models/SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse.cs` |
| `GetCloudMiningPaymentAndRefundHistoryUserDataError` | `src/Binance/Errors/GetCloudMiningPaymentAndRefundHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetSymbolsDelistScheduleForSpotMarketDataRequest` | `src/Binance/Requests/Wallet/GetSymbolsDelistScheduleForSpotMarketDataRequest.cs` |
| `SapiV1SpotDelistScheduleResponse` | `src/Binance/Models/SapiV1SpotDelistScheduleResponse.cs` |
| `GetSymbolsDelistScheduleForSpotMarketDataError` | `src/Binance/Errors/GetSymbolsDelistScheduleForSpotMarketDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `OneClickArrivalDepositApplyUserDataRequest` | `src/Binance/Requests/Wallet/OneClickArrivalDepositApplyUserDataRequest.cs` |
| `SapiV1CapitalDepositCreditApplyResponse` | `src/Binance/Models/SapiV1CapitalDepositCreditApplyResponse.cs` |
| `OneClickArrivalDepositApplyUserDataError` | `src/Binance/Errors/OneClickArrivalDepositApplyUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### QueryAutoConvertingStableCoinsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryAutoConvertingStableCoinsUserData(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1CapitalContractConvertibleCoinsResponse`
- **Error**: `ApiException<QueryAutoConvertingStableCoinsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalContractConvertibleCoinsResponse` | `src/Binance/Models/SapiV1CapitalContractConvertibleCoinsResponse.cs` |
| `QueryAutoConvertingStableCoinsUserDataError` | `src/Binance/Errors/QueryAutoConvertingStableCoinsUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `QueryConvertTransferUserDataRequest` | `src/Binance/Requests/Wallet/QueryConvertTransferUserDataRequest.cs` |
| `AccountType3` | `src/Binance/Models/Enums/AccountType3.cs` |
| `SapiV1AssetConvertTransferQueryByPageResponse` | `src/Binance/Models/SapiV1AssetConvertTransferQueryByPageResponse.cs` |
| `QueryConvertTransferUserDataError` | `src/Binance/Errors/QueryConvertTransferUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `QueryUserDelegationHistoryForMasterAccountUserDataRequest` | `src/Binance/Requests/Wallet/QueryUserDelegationHistoryForMasterAccountUserDataRequest.cs` |
| `SapiV1AssetCustodyTransferHistoryResponse` | `src/Binance/Models/SapiV1AssetCustodyTransferHistoryResponse.cs` |
| `QueryUserDelegationHistoryForMasterAccountUserDataError` | `src/Binance/Errors/QueryUserDelegationHistoryForMasterAccountUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `QueryUserUniversalTransferHistoryUserDataRequest` | `src/Binance/Requests/Wallet/QueryUserUniversalTransferHistoryUserDataRequest.cs` |
| `Type7` | `src/Binance/Models/Enums/Type7.cs` |
| `SapiV1AssetTransferResponse` | `src/Binance/Models/SapiV1AssetTransferResponse.cs` |
| `QueryUserUniversalTransferHistoryUserDataError` | `src/Binance/Errors/QueryUserUniversalTransferHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `QueryUserWalletBalanceUserDataRequest` | `src/Binance/Requests/Wallet/QueryUserWalletBalanceUserDataRequest.cs` |
| `SapiV1AssetWalletBalanceResponse` | `src/Binance/Models/SapiV1AssetWalletBalanceResponse.cs` |
| `QueryUserWalletBalanceUserDataError` | `src/Binance/Errors/QueryUserWalletBalanceUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest` | `src/Binance/Requests/Wallet/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest.cs` |
| `SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError` | `src/Binance/Errors/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SystemStatusSystem

- **Signature**: `SystemStatusSystem(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SapiV1SystemStatusResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SapiV1SystemStatusResponse` | `src/Binance/Models/SapiV1SystemStatusResponse.cs` |

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
| `TradeFeeUserDataRequest` | `src/Binance/Requests/Wallet/TradeFeeUserDataRequest.cs` |
| `SapiV1AssetTradeFeeResponse` | `src/Binance/Models/SapiV1AssetTradeFeeResponse.cs` |
| `TradeFeeUserDataError` | `src/Binance/Errors/TradeFeeUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `UserAssetUserDataRequest` | `src/Binance/Requests/Wallet/UserAssetUserDataRequest.cs` |
| `NeedBtcValuation` | `src/Binance/Models/Enums/NeedBtcValuation.cs` |
| `SapiV3AssetGetUserAssetResponse` | `src/Binance/Models/SapiV3AssetGetUserAssetResponse.cs` |
| `UserAssetUserDataError` | `src/Binance/Errors/UserAssetUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `UserUniversalTransferUserDataRequest` | `src/Binance/Requests/Wallet/UserUniversalTransferUserDataRequest.cs` |
| `Type7` | `src/Binance/Models/Enums/Type7.cs` |
| `SapiV1AssetTransferResponse1` | `src/Binance/Models/SapiV1AssetTransferResponse1.cs` |
| `UserUniversalTransferUserDataError` | `src/Binance/Errors/UserUniversalTransferUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `WithdrawHistorySupportingNetworkUserDataRequest` | `src/Binance/Requests/Wallet/WithdrawHistorySupportingNetworkUserDataRequest.cs` |
| `SapiV1CapitalWithdrawHistoryResponse` | `src/Binance/Models/SapiV1CapitalWithdrawHistoryResponse.cs` |
| `WithdrawHistorySupportingNetworkUserDataError` | `src/Binance/Errors/WithdrawHistorySupportingNetworkUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `WithdrawUserDataRequest` | `src/Binance/Requests/Wallet/WithdrawUserDataRequest.cs` |
| `SapiV1CapitalWithdrawApplyResponse` | `src/Binance/Models/SapiV1CapitalWithdrawApplyResponse.cs` |
| `WithdrawUserDataError` | `src/Binance/Errors/WithdrawUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

