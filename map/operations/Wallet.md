<!-- Generated file — do not edit; regenerated with the SDK. -->

# Wallet — operations

Accessor: `client.Wallet` · Source: `Api/Wallet.cs` · 34 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountApiTradingStatusUserData

- **Signature**: `AccountApiTradingStatusUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AccountApiTradingStatusResponse`
- **Error**: `SdkException<AccountApiTradingStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AccountApiTradingStatusResponse` | `Models/SapiV1AccountApiTradingStatusResponse.cs` |
| `AccountApiTradingStatusUserDataError` | `Errors/AccountApiTradingStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AccountInfoUserData

- **Signature**: `AccountInfoUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AccountInfoResponse`
- **Error**: `SdkException<AccountInfoUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AccountInfoResponse` | `Models/SapiV1AccountInfoResponse.cs` |
| `AccountInfoUserDataError` | `Errors/AccountInfoUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AccountStatusUserData

- **Signature**: `AccountStatusUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AccountStatusResponse`
- **Error**: `SdkException<AccountStatusUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AccountStatusResponse` | `Models/SapiV1AccountStatusResponse.cs` |
| `AccountStatusUserDataError` | `Errors/AccountStatusUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AllCoinsInformationUserData

- **Signature**: `AllCoinsInformationUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalConfigGetallResponse>`
- **Error**: `SdkException<AllCoinsInformationUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalConfigGetallResponse` | `Models/SapiV1CapitalConfigGetallResponse.cs` |
| `AllCoinsInformationUserDataError` | `Errors/AllCoinsInformationUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AssetDetailUserData

- **Signature**: `AssetDetailUserData(long timestamp, string signature, string? asset, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `asset` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetAssetDetailResponse`
- **Error**: `SdkException<AssetDetailUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AssetAssetDetailResponse` | `Models/SapiV1AssetAssetDetailResponse.cs` |
| `AssetDetailUserDataError` | `Errors/AssetDetailUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### AssetDividendRecordUserData

- **Signature**: `AssetDividendRecordUserData(long timestamp, string signature, string? asset, long? startTime, long? endTime, long? recvWindow, int? limit = 20, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`asset` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `limit` = `20`
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetAssetDividendResponse`
- **Error**: `SdkException<AssetDividendRecordUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AssetAssetDividendResponse` | `Models/SapiV1AssetAssetDividendResponse.cs` |
| `AssetDividendRecordUserDataError` | `Errors/AssetDividendRecordUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### ConvertTransferUserData

- **Signature**: `ConvertTransferUserData(string clientTranId, string asset, double amount, string targetAsset, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `clientTranId` ← `clientTranId`, `asset` ← `asset`, `amount` ← `amount`, `targetAsset` ← `targetAsset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetConvertTransferResponse`
- **Error**: `SdkException<ConvertTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AssetConvertTransferResponse` | `Models/SapiV1AssetConvertTransferResponse.cs` |
| `ConvertTransferUserDataError` | `Errors/ConvertTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DailyAccountSnapshotUserData

- **Signature**: `DailyAccountSnapshotUserData(Type6 type, long timestamp, string signature, long? startTime, long? endTime, long? recvWindow, int? limit = 7, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `startTime` — nullable, no default → **must pass explicitly**
  - `endTime` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
  - defaults: `limit` = `7`
- **Query params (wire ← C#)**: `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AccountSnapshotResponse`
- **Error**: `SdkException<DailyAccountSnapshotUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type6` | `Models/Enums/Type6.cs` |
| `SapiV1AccountSnapshotResponse` | `Models/AnyOf/SapiV1AccountSnapshotResponse.cs` |
| `DailyAccountSnapshotUserDataError` | `Errors/DailyAccountSnapshotUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DepositAddressSupportingNetworkUserData

- **Signature**: `DepositAddressSupportingNetworkUserData(string coin, long timestamp, string signature, string? network, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `network` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `coin` ← `coin`, `timestamp` ← `timestamp`, `signature` ← `signature`, `network` ← `network`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1CapitalDepositAddressResponse`
- **Error**: `SdkException<DepositAddressSupportingNetworkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalDepositAddressResponse` | `Models/SapiV1CapitalDepositAddressResponse.cs` |
| `DepositAddressSupportingNetworkUserDataError` | `Errors/DepositAddressSupportingNetworkUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DepositHistorySupportingNetworkUserData

- **Signature**: `DepositHistorySupportingNetworkUserData(long timestamp, string signature, string? coin, int? status, long? startTime, long? endTime, int? offset, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`coin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `coin` ← `coin`, `status` ← `status`, `startTime` ← `startTime`, `endTime` ← `endTime`, `offset` ← `offset`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalDepositHisrecResponse>`
- **Error**: `SdkException<DepositHistorySupportingNetworkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalDepositHisrecResponse` | `Models/SapiV1CapitalDepositHisrecResponse.cs` |
| `DepositHistorySupportingNetworkUserDataError` | `Errors/DepositHistorySupportingNetworkUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DisableFastWithdrawSwitchUserData

- **Signature**: `DisableFastWithdrawSwitchUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `object`
- **Error**: `SdkException<DisableFastWithdrawSwitchUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DisableFastWithdrawSwitchUserDataError` | `Errors/DisableFastWithdrawSwitchUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DustLogUserData

- **Signature**: `DustLogUserData(long timestamp, string signature, AccountType? accountType, long? startTime, long? endTime, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`accountType` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `accountType` ← `accountType`, `startTime` ← `startTime`, `endTime` ← `endTime`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetDribbletResponse`
- **Error**: `SdkException<DustLogUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountType` | `Models/Enums/AccountType.cs` |
| `SapiV1AssetDribbletResponse` | `Models/SapiV1AssetDribbletResponse.cs` |
| `DustLogUserDataError` | `Errors/DustLogUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### DustTransferUserData

- **Signature**: `DustTransferUserData(IReadOnlyList<string> asset, long timestamp, string signature, AccountType? accountType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `accountType` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `asset` ← `asset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `accountType` ← `accountType`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetDustResponse`
- **Error**: `SdkException<DustTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountType` | `Models/Enums/AccountType.cs` |
| `SapiV1AssetDustResponse` | `Models/SapiV1AssetDustResponse.cs` |
| `DustTransferUserDataError` | `Errors/DustTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### EnableFastWithdrawSwitchUserData

- **Signature**: `EnableFastWithdrawSwitchUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `object`
- **Error**: `SdkException<EnableFastWithdrawSwitchUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableFastWithdrawSwitchUserDataError` | `Errors/EnableFastWithdrawSwitchUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FetchDepositAddressListWithNetworkUserData

- **Signature**: `FetchDepositAddressListWithNetworkUserData(string coin, long timestamp, string signature, string? network, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `network` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `coin` ← `coin`, `timestamp` ← `timestamp`, `signature` ← `signature`, `network` ← `network`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalDepositAddressListResponse>`
- **Error**: `SdkException<FetchDepositAddressListWithNetworkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalDepositAddressListResponse` | `Models/SapiV1CapitalDepositAddressListResponse.cs` |
| `FetchDepositAddressListWithNetworkUserDataError` | `Errors/FetchDepositAddressListWithNetworkUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FetchWithdrawAddressListUserData

- **Signature**: `FetchWithdrawAddressListUserData(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<SapiV1CapitalWithdrawAddressListResponse>`
- **Error**: `SdkException<FetchWithdrawAddressListUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalWithdrawAddressListResponse` | `Models/SapiV1CapitalWithdrawAddressListResponse.cs` |
| `FetchWithdrawAddressListUserDataError` | `Errors/FetchWithdrawAddressListUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FundingWalletUserData

- **Signature**: `FundingWalletUserData(long timestamp, string signature, string? asset, NeedBtcValuation? needBtcValuation, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `asset` — nullable, no default → **must pass explicitly**
  - `needBtcValuation` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `needBtcValuation` ← `needBtcValuation`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1AssetGetFundingAssetResponse>`
- **Error**: `SdkException<FundingWalletUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NeedBtcValuation` | `Models/Enums/NeedBtcValuation.cs` |
| `SapiV1AssetGetFundingAssetResponse` | `Models/SapiV1AssetGetFundingAssetResponse.cs` |
| `FundingWalletUserDataError` | `Errors/FundingWalletUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetApiKeyPermissionUserData

- **Signature**: `GetApiKeyPermissionUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AccountApiRestrictionsResponse`
- **Error**: `SdkException<GetApiKeyPermissionUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AccountApiRestrictionsResponse` | `Models/SapiV1AccountApiRestrictionsResponse.cs` |
| `GetApiKeyPermissionUserDataError` | `Errors/GetApiKeyPermissionUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetAssetsThatCanBeConvertedIntoBnbUserData

- **Signature**: `GetAssetsThatCanBeConvertedIntoBnbUserData(long timestamp, string signature, AccountType? accountType, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `accountType` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `accountType` ← `accountType`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetDustBtcResponse`
- **Error**: `SdkException<GetAssetsThatCanBeConvertedIntoBnbUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountType` | `Models/Enums/AccountType.cs` |
| `SapiV1AssetDustBtcResponse` | `Models/SapiV1AssetDustBtcResponse.cs` |
| `GetAssetsThatCanBeConvertedIntoBnbUserDataError` | `Errors/GetAssetsThatCanBeConvertedIntoBnbUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCloudMiningPaymentAndRefundHistoryUserData

- **Signature**: `GetCloudMiningPaymentAndRefundHistoryUserData(long startTime, long endTime, long timestamp, string signature, long? tranId, string? clientTranId, string? asset, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`tranId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`, `timestamp` ← `timestamp`, `signature` ← `signature`, `tranId` ← `tranId`, `clientTranId` ← `clientTranId`, `asset` ← `asset`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse`
- **Error**: `SdkException<GetCloudMiningPaymentAndRefundHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse` | `Models/SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse.cs` |
| `GetCloudMiningPaymentAndRefundHistoryUserDataError` | `Errors/GetCloudMiningPaymentAndRefundHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetSymbolsDelistScheduleForSpotMarketData

- **Signature**: `GetSymbolsDelistScheduleForSpotMarketData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1SpotDelistScheduleResponse>`
- **Error**: `SdkException<GetSymbolsDelistScheduleForSpotMarketDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1SpotDelistScheduleResponse` | `Models/SapiV1SpotDelistScheduleResponse.cs` |
| `GetSymbolsDelistScheduleForSpotMarketDataError` | `Errors/GetSymbolsDelistScheduleForSpotMarketDataError.cs` |
| `Error` | `Models/Error.cs` |

### OneClickArrivalDepositApplyUserData

- **Signature**: `OneClickArrivalDepositApplyUserData(long timestamp, string signature, long? depositId, string? txId, long? subAccountId, long? subUserId, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`depositId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `depositId` ← `depositId`, `txId` ← `txId`, `subAccountId` ← `subAccountId`, `subUserId` ← `subUserId`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1CapitalDepositCreditApplyResponse`
- **Error**: `SdkException<OneClickArrivalDepositApplyUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalDepositCreditApplyResponse` | `Models/SapiV1CapitalDepositCreditApplyResponse.cs` |
| `OneClickArrivalDepositApplyUserDataError` | `Errors/OneClickArrivalDepositApplyUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryAutoConvertingStableCoinsUserData

- **Signature**: `QueryAutoConvertingStableCoinsUserData(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SapiV1CapitalContractConvertibleCoinsResponse`
- **Error**: `SdkException<QueryAutoConvertingStableCoinsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalContractConvertibleCoinsResponse` | `Models/SapiV1CapitalContractConvertibleCoinsResponse.cs` |
| `QueryAutoConvertingStableCoinsUserDataError` | `Errors/QueryAutoConvertingStableCoinsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryConvertTransferUserData

- **Signature**: `QueryConvertTransferUserData(long startTime, long endTime, long timestamp, string signature, long? tranId, string? asset, AccountType3? accountType, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`tranId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`, `timestamp` ← `timestamp`, `signature` ← `signature`, `tranId` ← `tranId`, `asset` ← `asset`, `accountType` ← `accountType`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetConvertTransferQueryByPageResponse`
- **Error**: `SdkException<QueryConvertTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountType3` | `Models/Enums/AccountType3.cs` |
| `SapiV1AssetConvertTransferQueryByPageResponse` | `Models/SapiV1AssetConvertTransferQueryByPageResponse.cs` |
| `QueryConvertTransferUserDataError` | `Errors/QueryConvertTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryUserDelegationHistoryForMasterAccountUserData

- **Signature**: `QueryUserDelegationHistoryForMasterAccountUserData(string email, long startTime, long endTime, string asset, long timestamp, string signature, string? type, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`type` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `email` ← `email`, `startTime` ← `startTime`, `endTime` ← `endTime`, `asset` ← `asset`, `timestamp` ← `timestamp`, `signature` ← `signature`, `type` ← `type`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetCustodyTransferHistoryResponse`
- **Error**: `SdkException<QueryUserDelegationHistoryForMasterAccountUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AssetCustodyTransferHistoryResponse` | `Models/SapiV1AssetCustodyTransferHistoryResponse.cs` |
| `QueryUserDelegationHistoryForMasterAccountUserDataError` | `Errors/QueryUserDelegationHistoryForMasterAccountUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryUserUniversalTransferHistoryUserData

- **Signature**: `QueryUserUniversalTransferHistoryUserData(Type7 type, long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, string? fromSymbol, string? toSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `type` ← `type`, `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `fromSymbol` ← `fromSymbol`, `toSymbol` ← `toSymbol`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetTransferResponse`
- **Error**: `SdkException<QueryUserUniversalTransferHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type7` | `Models/Enums/Type7.cs` |
| `SapiV1AssetTransferResponse` | `Models/SapiV1AssetTransferResponse.cs` |
| `QueryUserUniversalTransferHistoryUserDataError` | `Errors/QueryUserUniversalTransferHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### QueryUserWalletBalanceUserData

- **Signature**: `QueryUserWalletBalanceUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1AssetWalletBalanceResponse>`
- **Error**: `SdkException<QueryUserWalletBalanceUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AssetWalletBalanceResponse` | `Models/SapiV1AssetWalletBalanceResponse.cs` |
| `QueryUserWalletBalanceUserDataError` | `Errors/QueryUserWalletBalanceUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SwitchOnOffBusdAndStableCoinsConversionUserDataUserData

- **Signature**: `SwitchOnOffBusdAndStableCoinsConversionUserDataUserData(string coin, bool enable, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `coin` ← `coin`, `enable` ← `enable`
- **Returns**: `object`
- **Error**: `SdkException<SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError` | `Errors/SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### SystemStatusSystem

- **Signature**: `SystemStatusSystem(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SapiV1SystemStatusResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SapiV1SystemStatusResponse` | `Models/SapiV1SystemStatusResponse.cs` |

### TradeFeeUserData

- **Signature**: `TradeFeeUserData(long timestamp, string signature, string? symbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `symbol` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `symbol` ← `symbol`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1AssetTradeFeeResponse>`
- **Error**: `SdkException<TradeFeeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1AssetTradeFeeResponse` | `Models/SapiV1AssetTradeFeeResponse.cs` |
| `TradeFeeUserDataError` | `Errors/TradeFeeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### UserAssetUserData

- **Signature**: `UserAssetUserData(long timestamp, string signature, string? asset, NeedBtcValuation? needBtcValuation, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `asset` — nullable, no default → **must pass explicitly**
  - `needBtcValuation` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `needBtcValuation` ← `needBtcValuation`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV3AssetGetUserAssetResponse>`
- **Error**: `SdkException<UserAssetUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NeedBtcValuation` | `Models/Enums/NeedBtcValuation.cs` |
| `SapiV3AssetGetUserAssetResponse` | `Models/SapiV3AssetGetUserAssetResponse.cs` |
| `UserAssetUserDataError` | `Errors/UserAssetUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### UserUniversalTransferUserData

- **Signature**: `UserUniversalTransferUserData(Type7 type, string asset, double amount, long timestamp, string signature, string? fromSymbol, string? toSymbol, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `fromSymbol` — nullable, no default → **must pass explicitly**
  - `toSymbol` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `type` ← `type`, `asset` ← `asset`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `fromSymbol` ← `fromSymbol`, `toSymbol` ← `toSymbol`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1AssetTransferResponse1`
- **Error**: `SdkException<UserUniversalTransferUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type7` | `Models/Enums/Type7.cs` |
| `SapiV1AssetTransferResponse1` | `Models/SapiV1AssetTransferResponse1.cs` |
| `UserUniversalTransferUserDataError` | `Errors/UserUniversalTransferUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### WithdrawHistorySupportingNetworkUserData

- **Signature**: `WithdrawHistorySupportingNetworkUserData(long timestamp, string signature, string? coin, string? withdrawOrderId, int? status, long? startTime, long? endTime, int? offset, int? limit, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`coin` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `coin` ← `coin`, `withdrawOrderId` ← `withdrawOrderId`, `status` ← `status`, `startTime` ← `startTime`, `endTime` ← `endTime`, `offset` ← `offset`, `limit` ← `limit`, `recvWindow` ← `recvWindow`
- **Returns**: `IReadOnlyList<SapiV1CapitalWithdrawHistoryResponse>`
- **Error**: `SdkException<WithdrawHistorySupportingNetworkUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalWithdrawHistoryResponse` | `Models/SapiV1CapitalWithdrawHistoryResponse.cs` |
| `WithdrawHistorySupportingNetworkUserDataError` | `Errors/WithdrawHistorySupportingNetworkUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### WithdrawUserData

- **Signature**: `WithdrawUserData(string coin, string address, double amount, long timestamp, string signature, string? withdrawOrderId, string? network, string? addressTag, string? name, int? walletType, long? recvWindow, bool? transactionFeeFlag = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`withdrawOrderId` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `transactionFeeFlag` = `false`
- **Query params (wire ← C#)**: `coin` ← `coin`, `address` ← `address`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `withdrawOrderId` ← `withdrawOrderId`, `network` ← `network`, `addressTag` ← `addressTag`, `transactionFeeFlag` ← `transactionFeeFlag`, `name` ← `name`, `walletType` ← `walletType`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1CapitalWithdrawApplyResponse`
- **Error**: `SdkException<WithdrawUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1CapitalWithdrawApplyResponse` | `Models/SapiV1CapitalWithdrawApplyResponse.cs` |
| `WithdrawUserDataError` | `Errors/WithdrawUserDataError.cs` |
| `Error` | `Models/Error.cs` |

