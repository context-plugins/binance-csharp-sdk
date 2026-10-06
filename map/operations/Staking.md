<!-- Generated file — do not edit; regenerated with the SDK. -->

# Staking — operations

Accessor: `client.Staking` · Source: `Api/Staking.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EthStakingAccountV2UserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `EthStakingAccountV2UserData(EthStakingAccountV2UserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2EthStakingAccountResponse`
- **Error**: `ApiException<EthStakingAccountV2UserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EthStakingAccountV2UserDataRequest` | `Requests/Staking/EthStakingAccountV2UserDataRequest.cs` |
| `SapiV2EthStakingAccountResponse` | `Models/SapiV2EthStakingAccountResponse.cs` |
| `EthStakingAccountV2UserDataError` | `Errors/EthStakingAccountV2UserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetBethRewardsDistributionHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetBethRewardsDistributionHistoryUserData(GetBethRewardsDistributionHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryRewardsHistoryResponse`
- **Error**: `ApiException<GetBethRewardsDistributionHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBethRewardsDistributionHistoryUserDataRequest` | `Requests/Staking/GetBethRewardsDistributionHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryRewardsHistoryResponse` | `Models/SapiV1EthStakingEthHistoryRewardsHistoryResponse.cs` |
| `GetBethRewardsDistributionHistoryUserDataError` | `Errors/GetBethRewardsDistributionHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetCurrentEthStakingQuotaUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetCurrentEthStakingQuotaUserData(GetCurrentEthStakingQuotaUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingEthQuotaResponse`
- **Error**: `ApiException<GetCurrentEthStakingQuotaUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCurrentEthStakingQuotaUserDataRequest` | `Requests/Staking/GetCurrentEthStakingQuotaUserDataRequest.cs` |
| `SapiV1EthStakingEthQuotaResponse` | `Models/SapiV1EthStakingEthQuotaResponse.cs` |
| `GetCurrentEthStakingQuotaUserDataError` | `Errors/GetCurrentEthStakingQuotaUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetEthRedemptionHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetEthRedemptionHistoryUserData(GetEthRedemptionHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryRedemptionHistoryResponse`
- **Error**: `ApiException<GetEthRedemptionHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEthRedemptionHistoryUserDataRequest` | `Requests/Staking/GetEthRedemptionHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryRedemptionHistoryResponse` | `Models/SapiV1EthStakingEthHistoryRedemptionHistoryResponse.cs` |
| `GetEthRedemptionHistoryUserDataError` | `Errors/GetEthRedemptionHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetEthStakingHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetEthStakingHistoryUserData(GetEthStakingHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryStakingHistoryResponse`
- **Error**: `ApiException<GetEthStakingHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEthStakingHistoryUserDataRequest` | `Requests/Staking/GetEthStakingHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryStakingHistoryResponse` | `Models/SapiV1EthStakingEthHistoryStakingHistoryResponse.cs` |
| `GetEthStakingHistoryUserDataError` | `Errors/GetEthStakingHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetWbethRateHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetWbethRateHistoryUserData(GetWbethRateHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryRateHistoryResponse`
- **Error**: `ApiException<GetWbethRateHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetWbethRateHistoryUserDataRequest` | `Requests/Staking/GetWbethRateHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryRateHistoryResponse` | `Models/SapiV1EthStakingEthHistoryRateHistoryResponse.cs` |
| `GetWbethRateHistoryUserDataError` | `Errors/GetWbethRateHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetWbethRewardsHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetWbethRewardsHistoryUserData(GetWbethRewardsHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse`
- **Error**: `ApiException<GetWbethRewardsHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetWbethRewardsHistoryUserDataRequest` | `Requests/Staking/GetWbethRewardsHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse` | `Models/SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse.cs` |
| `GetWbethRewardsHistoryUserDataError` | `Errors/GetWbethRewardsHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetWbethUnwrapHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetWbethUnwrapHistoryUserData(GetWbethUnwrapHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingWbethHistoryUnwrapHistoryResponse`
- **Error**: `ApiException<GetWbethUnwrapHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetWbethUnwrapHistoryUserDataRequest` | `Requests/Staking/GetWbethUnwrapHistoryUserDataRequest.cs` |
| `SapiV1EthStakingWbethHistoryUnwrapHistoryResponse` | `Models/SapiV1EthStakingWbethHistoryUnwrapHistoryResponse.cs` |
| `GetWbethUnwrapHistoryUserDataError` | `Errors/GetWbethUnwrapHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### GetWbethWrapHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetWbethWrapHistoryUserData(GetWbethWrapHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `current` ← `Current`, `size` ← `Size`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingWbethHistoryWrapHistoryResponse`
- **Error**: `ApiException<GetWbethWrapHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetWbethWrapHistoryUserDataRequest` | `Requests/Staking/GetWbethWrapHistoryUserDataRequest.cs` |
| `SapiV1EthStakingWbethHistoryWrapHistoryResponse` | `Models/SapiV1EthStakingWbethHistoryWrapHistoryResponse.cs` |
| `GetWbethWrapHistoryUserDataError` | `Errors/GetWbethWrapHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RedeemEthTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedeemEthTrade(RedeemEthTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `asset` ← `Asset`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingEthRedeemResponse`
- **Error**: `ApiException<RedeemEthTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RedeemEthTradeRequest` | `Requests/Staking/RedeemEthTradeRequest.cs` |
| `SapiV1EthStakingEthRedeemResponse` | `Models/SapiV1EthStakingEthRedeemResponse.cs` |
| `RedeemEthTradeError` | `Errors/RedeemEthTradeError.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeEthStakingV2Trade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SubscribeEthStakingV2Trade(SubscribeEthStakingV2TradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV2EthStakingEthStakeResponse`
- **Error**: `ApiException<SubscribeEthStakingV2TradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubscribeEthStakingV2TradeRequest` | `Requests/Staking/SubscribeEthStakingV2TradeRequest.cs` |
| `SapiV2EthStakingEthStakeResponse` | `Models/SapiV2EthStakingEthStakeResponse.cs` |
| `SubscribeEthStakingV2TradeError` | `Errors/SubscribeEthStakingV2TradeError.cs` |
| `Error` | `Models/Error.cs` |

### WrapBethTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `WrapBethTrade(WrapBethTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1EthStakingWbethWrapResponse`
- **Error**: `ApiException<WrapBethTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `WrapBethTradeRequest` | `Requests/Staking/WrapBethTradeRequest.cs` |
| `SapiV1EthStakingWbethWrapResponse` | `Models/SapiV1EthStakingWbethWrapResponse.cs` |
| `WrapBethTradeError` | `Errors/WrapBethTradeError.cs` |
| `Error` | `Models/Error.cs` |

