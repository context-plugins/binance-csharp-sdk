<!-- Generated file — do not edit; regenerated with the SDK. -->

# Fiat — operations

Accessor: `client.Fiat` · Source: `Api/Fiat.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### FiatDepositWithdrawHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FiatDepositWithdrawHistoryUserData(int transactionType, long timestamp, string signature, long? beginTime, long? endTime, int? page, int? rows, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`beginTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `transactionType` ← `transactionType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `beginTime` ← `beginTime`, `endTime` ← `endTime`, `page` ← `page`, `rows` ← `rows`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1FiatOrdersResponse`
- **Error**: `SdkException<FiatDepositWithdrawHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1FiatOrdersResponse` | `Models/SapiV1FiatOrdersResponse.cs` |
| `FiatDepositWithdrawHistoryUserDataError` | `Errors/FiatDepositWithdrawHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FiatPaymentsHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FiatPaymentsHistoryUserData(int transactionType, long timestamp, string signature, long? beginTime, long? endTime, int? page, int? rows, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`beginTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `transactionType` ← `transactionType`, `timestamp` ← `timestamp`, `signature` ← `signature`, `beginTime` ← `beginTime`, `endTime` ← `endTime`, `page` ← `page`, `rows` ← `rows`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1FiatPaymentsResponse`
- **Error**: `SdkException<FiatPaymentsHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1FiatPaymentsResponse` | `Models/SapiV1FiatPaymentsResponse.cs` |
| `FiatPaymentsHistoryUserDataError` | `Errors/FiatPaymentsHistoryUserDataError.cs` |
| `Error` | `Models/Error.cs` |

