<!-- Generated file — do not edit; regenerated with the SDK. -->

# Rebate — operations

Accessor: `client.Rebate` · Source: `Api/Rebate.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetSpotRebateHistoryRecordsUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `GetSpotRebateHistoryRecordsUserData(GetSpotRebateHistoryRecordsUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `page` ← `Page`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1RebateTaxQueryResponse`
- **Error**: `ApiException<GetSpotRebateHistoryRecordsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSpotRebateHistoryRecordsUserDataRequest` | `Requests/Rebate/GetSpotRebateHistoryRecordsUserDataRequest.cs` |
| `SapiV1RebateTaxQueryResponse` | `Models/SapiV1RebateTaxQueryResponse.cs` |
| `GetSpotRebateHistoryRecordsUserDataError` | `Errors/GetSpotRebateHistoryRecordsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

