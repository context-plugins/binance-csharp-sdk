<!-- Generated file — do not edit; regenerated with the SDK. -->

# Rebate — operations

Accessor: `client.Rebate` · Source: `Api/Rebate.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetSpotRebateHistoryRecordsUserData

- **Signature**: `GetSpotRebateHistoryRecordsUserData(long timestamp, string signature, long? startTime, long? endTime, int? page, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`startTime` … `recvWindow`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `startTime` ← `startTime`, `endTime` ← `endTime`, `page` ← `page`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1RebateTaxQueryResponse`
- **Error**: `SdkException<GetSpotRebateHistoryRecordsUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1RebateTaxQueryResponse` | `Models/SapiV1RebateTaxQueryResponse.cs` |
| `GetSpotRebateHistoryRecordsUserDataError` | `Errors/GetSpotRebateHistoryRecordsUserDataError.cs` |
| `Error` | `Models/Error.cs` |

