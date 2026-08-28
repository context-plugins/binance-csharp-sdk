<!-- Generated file — do not edit; regenerated with the SDK. -->

# Market — operations

Accessor: `client.Market` · Source: `Api/Market.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckServerTime

- **Signature**: `CheckServerTime(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ApiV3TimeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApiV3TimeResponse` | `Models/ApiV3TimeResponse.cs` |

### CompressedAggregateTradesList

- **Signature**: `CompressedAggregateTradesList(string symbol, long? fromId, long? startTime, long? endTime, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`fromId` … `limit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `fromId` ← `fromId`, `startTime` ← `startTime`, `endTime` ← `endTime`, `limit` ← `limit`
- **Returns**: `IReadOnlyList<AggTrade>`
- **Error**: `SdkException<CompressedAggregateTradesListError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AggTrade` | `Models/AggTrade.cs` |
| `CompressedAggregateTradesListError` | `Errors/CompressedAggregateTradesListError.cs` |
| `Error` | `Models/Error.cs` |

### CurrentAveragePrice

- **Signature**: `CurrentAveragePrice(string symbol, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `symbol` ← `symbol`
- **Returns**: `ApiV3AvgPriceResponse`
- **Error**: `SdkException<CurrentAveragePriceError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3AvgPriceResponse` | `Models/ApiV3AvgPriceResponse.cs` |
| `CurrentAveragePriceError` | `Errors/CurrentAveragePriceError.cs` |
| `Error` | `Models/Error.cs` |

### ExchangeInformation

- **Signature**: `ExchangeInformation(string? symbol, string? symbols, string? permissions, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `symbol` — nullable, no default → **must pass explicitly**
  - `symbols` — nullable, no default → **must pass explicitly**
  - `permissions` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `symbols` ← `symbols`, `permissions` ← `permissions`
- **Returns**: `ApiV3ExchangeInfoResponse`
- **Error**: `SdkException<ExchangeInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3ExchangeInfoResponse` | `Models/ApiV3ExchangeInfoResponse.cs` |
| `ExchangeInformationError` | `Errors/ExchangeInformationError.cs` |
| `Error` | `Models/Error.cs` |

### HrTickerPriceChangeStatistics24

- **Signature**: `HrTickerPriceChangeStatistics24(string? symbol, string? symbols, TypeEnum? type, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `symbol` — nullable, no default → **must pass explicitly**
  - `symbols` — nullable, no default → **must pass explicitly**
  - `type` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `symbols` ← `symbols`, `type` ← `type`
- **Returns**: `ApiV3Ticker24HrResponse`
- **Error**: `SdkException<HrTickerPriceChangeStatistics24Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TypeEnum` | `Models/Enums/TypeEnum.cs` |
| `ApiV3Ticker24HrResponse` | `Models/AnyOf/ApiV3Ticker24HrResponse.cs` |
| `HrTickerPriceChangeStatistics24Error` | `Errors/HrTickerPriceChangeStatistics24Error.cs` |
| `Error` | `Models/Error.cs` |

### KlineCandlestickData

- **Signature**: `KlineCandlestickData(string symbol, Interval interval, long? startTime, long? endTime, string? timeZone, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`startTime` … `limit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `interval` ← `interval`, `startTime` ← `startTime`, `endTime` ← `endTime`, `timeZone` ← `timeZone`, `limit` ← `limit`
- **Returns**: `IReadOnlyList<IReadOnlyList<ApiV3KlinesResponse>>`
- **Error**: `SdkException<KlineCandlestickDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Interval` | `Models/Enums/Interval.cs` |
| `ApiV3KlinesResponse` | `Models/AnyOf/ApiV3KlinesResponse.cs` |
| `KlineCandlestickDataError` | `Errors/KlineCandlestickDataError.cs` |
| `Error` | `Models/Error.cs` |

### OldTradeLookup

- **Signature**: `OldTradeLookup(string symbol, int? limit, long? fromId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `fromId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `limit` ← `limit`, `fromId` ← `fromId`
- **Returns**: `IReadOnlyList<Trade>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Trade` | `Models/Trade.cs` |

### OrderBook

- **Signature**: `OrderBook(string symbol, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `limit` = `100`
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `limit` ← `limit`
- **Returns**: `ApiV3DepthResponse`
- **Error**: `SdkException<OrderBookError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3DepthResponse` | `Models/ApiV3DepthResponse.cs` |
| `OrderBookError` | `Errors/OrderBookError.cs` |
| `Error` | `Models/Error.cs` |

### RecentTradesList

- **Signature**: `RecentTradesList(string symbol, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `limit` ← `limit`
- **Returns**: `IReadOnlyList<Trade>`
- **Error**: `SdkException<RecentTradesListError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Trade` | `Models/Trade.cs` |
| `RecentTradesListError` | `Errors/RecentTradesListError.cs` |
| `Error` | `Models/Error.cs` |

### RollingWindowPriceChangeStatistics

- **Signature**: `RollingWindowPriceChangeStatistics(string? symbol, string? symbols, string? windowSize, string? type, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`symbol` … `type`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `symbols` ← `symbols`, `windowSize` ← `windowSize`, `type` ← `type`
- **Returns**: `ApiV3TickerResponse`
- **Error**: `SdkException<RollingWindowPriceChangeStatisticsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3TickerResponse` | `Models/ApiV3TickerResponse.cs` |
| `RollingWindowPriceChangeStatisticsError` | `Errors/RollingWindowPriceChangeStatisticsError.cs` |
| `Error` | `Models/Error.cs` |

### SymbolOrderBookTicker

- **Signature**: `SymbolOrderBookTicker(string? symbol, string? symbols, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `symbol` — nullable, no default → **must pass explicitly**
  - `symbols` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `symbols` ← `symbols`
- **Returns**: `ApiV3TickerBookTickerResponse`
- **Error**: `SdkException<SymbolOrderBookTickerError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3TickerBookTickerResponse` | `Models/AnyOf/ApiV3TickerBookTickerResponse.cs` |
| `SymbolOrderBookTickerError` | `Errors/SymbolOrderBookTickerError.cs` |
| `Error` | `Models/Error.cs` |

### SymbolPriceTicker

- **Signature**: `SymbolPriceTicker(string? symbol, string? symbols, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `symbol` — nullable, no default → **must pass explicitly**
  - `symbols` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `symbols` ← `symbols`
- **Returns**: `ApiV3TickerPriceResponse`
- **Error**: `SdkException<SymbolPriceTickerError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiV3TickerPriceResponse` | `Models/AnyOf/ApiV3TickerPriceResponse.cs` |
| `SymbolPriceTickerError` | `Errors/SymbolPriceTickerError.cs` |
| `Error` | `Models/Error.cs` |

### TestConnectivity

- **Signature**: `TestConnectivity(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

### TradingDayTicker

- **Signature**: `TradingDayTicker(string? symbol, string? symbols, string? timeZone, TypeEnum? type, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`symbol` … `type`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `symbols` ← `symbols`, `timeZone` ← `timeZone`, `type` ← `type`
- **Returns**: `ApiV3TickerTradingDayResponse`
- **Error**: `SdkException<TradingDayTickerError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TypeEnum` | `Models/Enums/TypeEnum.cs` |
| `ApiV3TickerTradingDayResponse` | `Models/AnyOf/ApiV3TickerTradingDayResponse.cs` |
| `TradingDayTickerError` | `Errors/TradingDayTickerError.cs` |
| `Error` | `Models/Error.cs` |

### UiKlines

- **Signature**: `UiKlines(string symbol, Interval interval, long? startTime, long? endTime, string? timeZone, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`startTime` … `limit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `symbol` ← `symbol`, `interval` ← `interval`, `startTime` ← `startTime`, `endTime` ← `endTime`, `timeZone` ← `timeZone`, `limit` ← `limit`
- **Returns**: `IReadOnlyList<IReadOnlyList<ApiV3UiKlinesResponse>>`
- **Error**: `SdkException<UiKlinesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Interval` | `Models/Enums/Interval.cs` |
| `ApiV3UiKlinesResponse` | `Models/AnyOf/ApiV3UiKlinesResponse.cs` |
| `UiKlinesError` | `Errors/UiKlinesError.cs` |
| `Error` | `Models/Error.cs` |

