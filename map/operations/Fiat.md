<!-- Generated file — do not edit; regenerated with the SDK. -->

# Fiat — operations

Accessor: `client.Fiat` · Source: `src/Binance/Api/Fiat.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### FiatDepositWithdrawHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FiatDepositWithdrawHistoryUserData(FiatDepositWithdrawHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransactionType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `transactionType` ← `TransactionType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `beginTime` ← `BeginTime`, `endTime` ← `EndTime`, `page` ← `Page`, `rows` ← `Rows`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1FiatOrdersResponse`
- **Error**: `ApiException<FiatDepositWithdrawHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FiatDepositWithdrawHistoryUserDataRequest` | `src/Binance/Requests/Fiat/FiatDepositWithdrawHistoryUserDataRequest.cs` |
| `SapiV1FiatOrdersResponse` | `src/Binance/Models/SapiV1FiatOrdersResponse.cs` |
| `FiatDepositWithdrawHistoryUserDataError` | `src/Binance/Errors/FiatDepositWithdrawHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### FiatPaymentsHistoryUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FiatPaymentsHistoryUserData(FiatPaymentsHistoryUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransactionType`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `transactionType` ← `TransactionType`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `beginTime` ← `BeginTime`, `endTime` ← `EndTime`, `page` ← `Page`, `rows` ← `Rows`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1FiatPaymentsResponse`
- **Error**: `ApiException<FiatPaymentsHistoryUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FiatPaymentsHistoryUserDataRequest` | `src/Binance/Requests/Fiat/FiatPaymentsHistoryUserDataRequest.cs` |
| `SapiV1FiatPaymentsResponse` | `src/Binance/Models/SapiV1FiatPaymentsResponse.cs` |
| `FiatPaymentsHistoryUserDataError` | `src/Binance/Errors/FiatPaymentsHistoryUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

