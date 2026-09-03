<!-- Generated file — do not edit; regenerated with the SDK. -->

# Staking — operations

Accessor: `client.Staking` · Source: `Api/Staking.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EthStakingAccountV2UserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EthStakingAccountV2UserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2EthStakingAccountResponse`
- **Error**: `SdkException<EthStakingAccountV2UserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2EthStakingAccountResponse` | `Models/SapiV2EthStakingAccountResponse.cs` |
| `EthStakingAccountV2UserDataError` | `Errors/EthStakingAccountV2UserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetBethRewardsDistributionHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetBethRewardsDistributionHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryRewardsHistoryResponse`
- **Error**: `SdkException<GetBethRewardsDistributionHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingEthHistoryRewardsHistoryResponse` | `Models/SapiV1EthStakingEthHistoryRewardsHistoryResponse.cs` |
| `GetBethRewardsDistributionHistoryUserDataError` | `Errors/GetBethRewardsDistributionHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCurrentEthStakingQuotaUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCurrentEthStakingQuotaUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingEthQuotaResponse`
- **Error**: `SdkException<GetCurrentEthStakingQuotaUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingEthQuotaResponse` | `Models/SapiV1EthStakingEthQuotaResponse.cs` |
| `GetCurrentEthStakingQuotaUserDataError` | `Errors/GetCurrentEthStakingQuotaUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetEthRedemptionHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetEthRedemptionHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryRedemptionHistoryResponse`
- **Error**: `SdkException<GetEthRedemptionHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingEthHistoryRedemptionHistoryResponse` | `Models/SapiV1EthStakingEthHistoryRedemptionHistoryResponse.cs` |
| `GetEthRedemptionHistoryUserDataError` | `Errors/GetEthRedemptionHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetEthStakingHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetEthStakingHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryStakingHistoryResponse`
- **Error**: `SdkException<GetEthStakingHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingEthHistoryStakingHistoryResponse` | `Models/SapiV1EthStakingEthHistoryStakingHistoryResponse.cs` |
| `GetEthStakingHistoryUserDataError` | `Errors/GetEthStakingHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetWbethRateHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetWbethRateHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryRateHistoryResponse`
- **Error**: `SdkException<GetWbethRateHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingEthHistoryRateHistoryResponse` | `Models/SapiV1EthStakingEthHistoryRateHistoryResponse.cs` |
| `GetWbethRateHistoryUserDataError` | `Errors/GetWbethRateHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetWbethRewardsHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetWbethRewardsHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse`
- **Error**: `SdkException<GetWbethRewardsHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse` | `Models/SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse.cs` |
| `GetWbethRewardsHistoryUserDataError` | `Errors/GetWbethRewardsHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetWbethUnwrapHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetWbethUnwrapHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingWbethHistoryUnwrapHistoryResponse`
- **Error**: `SdkException<GetWbethUnwrapHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingWbethHistoryUnwrapHistoryResponse` | `Models/SapiV1EthStakingWbethHistoryUnwrapHistoryResponse.cs` |
| `GetWbethUnwrapHistoryUserDataError` | `Errors/GetWbethUnwrapHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetWbethWrapHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetWbethWrapHistoryUserData(long timestamp, string signature, long? startTime, long? endTime, int? current, int? size, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `current` ← `current`, `size` ← `size`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingWbethHistoryWrapHistoryResponse`
- **Error**: `SdkException<GetWbethWrapHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingWbethHistoryWrapHistoryResponse` | `Models/SapiV1EthStakingWbethHistoryWrapHistoryResponse.cs` |
| `GetWbethWrapHistoryUserDataError` | `Errors/GetWbethWrapHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RedeemEthTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedeemEthTrade(double amount, long timestamp, string signature, string? asset, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `asset` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `asset` ← `asset`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingEthRedeemResponse`
- **Error**: `SdkException<RedeemEthTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingEthRedeemResponse` | `Models/SapiV1EthStakingEthRedeemResponse.cs` |
| `RedeemEthTradeError` | `Errors/RedeemEthTradeError.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeEthStakingV2Trade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubscribeEthStakingV2Trade(double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV2EthStakingEthStakeResponse`
- **Error**: `SdkException<SubscribeEthStakingV2TradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV2EthStakingEthStakeResponse` | `Models/SapiV2EthStakingEthStakeResponse.cs` |
| `SubscribeEthStakingV2TradeError` | `Errors/SubscribeEthStakingV2TradeError.cs` |
| `Error` | `Models/Error.cs` |

### WrapBethTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `WrapBethTrade(double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1EthStakingWbethWrapResponse`
- **Error**: `SdkException<WrapBethTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1EthStakingWbethWrapResponse` | `Models/SapiV1EthStakingWbethWrapResponse.cs` |
| `WrapBethTradeError` | `Errors/WrapBethTradeError.cs` |
| `Error` | `Models/Error.cs` |

