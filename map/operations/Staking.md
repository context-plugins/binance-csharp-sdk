<!-- Generated file — do not edit; regenerated with the SDK. -->

# Staking — operations

Accessor: `client.Staking` · Source: `src/Binance/Api/Staking.cs` · 12 operations

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
| `EthStakingAccountV2UserDataRequest` | `src/Binance/Requests/Staking/EthStakingAccountV2UserDataRequest.cs` |
| `SapiV2EthStakingAccountResponse` | `src/Binance/Models/SapiV2EthStakingAccountResponse.cs` |
| `EthStakingAccountV2UserDataError` | `src/Binance/Errors/EthStakingAccountV2UserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetBethRewardsDistributionHistoryUserDataRequest` | `src/Binance/Requests/Staking/GetBethRewardsDistributionHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryRewardsHistoryResponse` | `src/Binance/Models/SapiV1EthStakingEthHistoryRewardsHistoryResponse.cs` |
| `GetBethRewardsDistributionHistoryUserDataError` | `src/Binance/Errors/GetBethRewardsDistributionHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetCurrentEthStakingQuotaUserDataRequest` | `src/Binance/Requests/Staking/GetCurrentEthStakingQuotaUserDataRequest.cs` |
| `SapiV1EthStakingEthQuotaResponse` | `src/Binance/Models/SapiV1EthStakingEthQuotaResponse.cs` |
| `GetCurrentEthStakingQuotaUserDataError` | `src/Binance/Errors/GetCurrentEthStakingQuotaUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetEthRedemptionHistoryUserDataRequest` | `src/Binance/Requests/Staking/GetEthRedemptionHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryRedemptionHistoryResponse` | `src/Binance/Models/SapiV1EthStakingEthHistoryRedemptionHistoryResponse.cs` |
| `GetEthRedemptionHistoryUserDataError` | `src/Binance/Errors/GetEthRedemptionHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetEthStakingHistoryUserDataRequest` | `src/Binance/Requests/Staking/GetEthStakingHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryStakingHistoryResponse` | `src/Binance/Models/SapiV1EthStakingEthHistoryStakingHistoryResponse.cs` |
| `GetEthStakingHistoryUserDataError` | `src/Binance/Errors/GetEthStakingHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetWbethRateHistoryUserDataRequest` | `src/Binance/Requests/Staking/GetWbethRateHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryRateHistoryResponse` | `src/Binance/Models/SapiV1EthStakingEthHistoryRateHistoryResponse.cs` |
| `GetWbethRateHistoryUserDataError` | `src/Binance/Errors/GetWbethRateHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetWbethRewardsHistoryUserDataRequest` | `src/Binance/Requests/Staking/GetWbethRewardsHistoryUserDataRequest.cs` |
| `SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse` | `src/Binance/Models/SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse.cs` |
| `GetWbethRewardsHistoryUserDataError` | `src/Binance/Errors/GetWbethRewardsHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetWbethUnwrapHistoryUserDataRequest` | `src/Binance/Requests/Staking/GetWbethUnwrapHistoryUserDataRequest.cs` |
| `SapiV1EthStakingWbethHistoryUnwrapHistoryResponse` | `src/Binance/Models/SapiV1EthStakingWbethHistoryUnwrapHistoryResponse.cs` |
| `GetWbethUnwrapHistoryUserDataError` | `src/Binance/Errors/GetWbethUnwrapHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `GetWbethWrapHistoryUserDataRequest` | `src/Binance/Requests/Staking/GetWbethWrapHistoryUserDataRequest.cs` |
| `SapiV1EthStakingWbethHistoryWrapHistoryResponse` | `src/Binance/Models/SapiV1EthStakingWbethHistoryWrapHistoryResponse.cs` |
| `GetWbethWrapHistoryUserDataError` | `src/Binance/Errors/GetWbethWrapHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `RedeemEthTradeRequest` | `src/Binance/Requests/Staking/RedeemEthTradeRequest.cs` |
| `SapiV1EthStakingEthRedeemResponse` | `src/Binance/Models/SapiV1EthStakingEthRedeemResponse.cs` |
| `RedeemEthTradeError` | `src/Binance/Errors/RedeemEthTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `SubscribeEthStakingV2TradeRequest` | `src/Binance/Requests/Staking/SubscribeEthStakingV2TradeRequest.cs` |
| `SapiV2EthStakingEthStakeResponse` | `src/Binance/Models/SapiV2EthStakingEthStakeResponse.cs` |
| `SubscribeEthStakingV2TradeError` | `src/Binance/Errors/SubscribeEthStakingV2TradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `WrapBethTradeRequest` | `src/Binance/Requests/Staking/WrapBethTradeRequest.cs` |
| `SapiV1EthStakingWbethWrapResponse` | `src/Binance/Models/SapiV1EthStakingWbethWrapResponse.cs` |
| `WrapBethTradeError` | `src/Binance/Errors/WrapBethTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

