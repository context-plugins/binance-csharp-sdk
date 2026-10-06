<!-- Generated file — do not edit; regenerated with the SDK. -->

# Market — operations

Accessor: `client.Market` · Source: `Api/Market.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckServerTime

- **Signature**: `CheckServerTime(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ApiV3TimeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApiV3TimeResponse` | `Models/ApiV3TimeResponse.cs` |

### CompressedAggregateTradesList

- **Signature**: `CompressedAggregateTradesList(CompressedAggregateTradesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `fromId` ← `FromId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<AggTrade>`
- **Error**: `ApiException<CompressedAggregateTradesListError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CompressedAggregateTradesListRequest` | `Requests/Market/CompressedAggregateTradesListRequest.cs` |
| `AggTrade` | `Models/AggTrade.cs` |
| `CompressedAggregateTradesListError` | `Errors/CompressedAggregateTradesListError.cs` |
| `Error` | `Models/Error.cs` |

### CurrentAveragePrice

- **Signature**: `CurrentAveragePrice(CurrentAveragePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`
- **Returns**: `ApiV3AvgPriceResponse`
- **Error**: `ApiException<CurrentAveragePriceError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CurrentAveragePriceRequest` | `Requests/Market/CurrentAveragePriceRequest.cs` |
| `ApiV3AvgPriceResponse` | `Models/ApiV3AvgPriceResponse.cs` |
| `CurrentAveragePriceError` | `Errors/CurrentAveragePriceError.cs` |
| `Error` | `Models/Error.cs` |

### ExchangeInformation

- **Signature**: `ExchangeInformation(ExchangeInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`, `permissions` ← `Permissions`
- **Returns**: `ApiV3ExchangeInfoResponse`
- **Error**: `ApiException<ExchangeInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ExchangeInformationRequest` | `Requests/Market/ExchangeInformationRequest.cs` |
| `ApiV3ExchangeInfoResponse` | `Models/ApiV3ExchangeInfoResponse.cs` |
| `ExchangeInformationError` | `Errors/ExchangeInformationError.cs` |
| `Error` | `Models/Error.cs` |

### HrTickerPriceChangeStatistics24

- **Signature**: `HrTickerPriceChangeStatistics24(HrTickerPriceChangeStatistics24Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`, `type` ← `Type`
- **Returns**: `ApiV3Ticker24HrResponse`
- **Error**: `ApiException<HrTickerPriceChangeStatistics24Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `HrTickerPriceChangeStatistics24Request` | `Requests/Market/HrTickerPriceChangeStatistics24Request.cs` |
| `TypeEnum` | `Models/Enums/TypeEnum.cs` |
| `ApiV3Ticker24HrResponse` | `Models/AnyOf/ApiV3Ticker24HrResponse.cs` |
| `HrTickerPriceChangeStatistics24Error` | `Errors/HrTickerPriceChangeStatistics24Error.cs` |
| `Error` | `Models/Error.cs` |

### KlineCandlestickData

- **Signature**: `KlineCandlestickData(KlineCandlestickDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Interval`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `interval` ← `Interval`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `timeZone` ← `TimeZone`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<IReadOnlyList<ApiV3KlinesResponse>>`
- **Error**: `ApiException<KlineCandlestickDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `KlineCandlestickDataRequest` | `Requests/Market/KlineCandlestickDataRequest.cs` |
| `Interval` | `Models/Enums/Interval.cs` |
| `ApiV3KlinesResponse` | `Models/AnyOf/ApiV3KlinesResponse.cs` |
| `KlineCandlestickDataError` | `Errors/KlineCandlestickDataError.cs` |
| `Error` | `Models/Error.cs` |

### OldTradeLookup

- **Signature**: `OldTradeLookup(OldTradeLookupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `limit` ← `Limit`, `fromId` ← `FromId`
- **Returns**: `IReadOnlyList<Trade>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OldTradeLookupRequest` | `Requests/Market/OldTradeLookupRequest.cs` |
| `Trade` | `Models/Trade.cs` |

### OrderBook

- **Signature**: `OrderBook(OrderBookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `limit` ← `Limit`
- **Returns**: `ApiV3DepthResponse`
- **Error**: `ApiException<OrderBookError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrderBookRequest` | `Requests/Market/OrderBookRequest.cs` |
| `ApiV3DepthResponse` | `Models/ApiV3DepthResponse.cs` |
| `OrderBookError` | `Errors/OrderBookError.cs` |
| `Error` | `Models/Error.cs` |

### RecentTradesList

- **Signature**: `RecentTradesList(RecentTradesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<Trade>`
- **Error**: `ApiException<RecentTradesListError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecentTradesListRequest` | `Requests/Market/RecentTradesListRequest.cs` |
| `Trade` | `Models/Trade.cs` |
| `RecentTradesListError` | `Errors/RecentTradesListError.cs` |
| `Error` | `Models/Error.cs` |

### RollingWindowPriceChangeStatistics

- **Signature**: `RollingWindowPriceChangeStatistics(RollingWindowPriceChangeStatisticsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`, `windowSize` ← `WindowSize`, `type` ← `Type`
- **Returns**: `ApiV3TickerResponse`
- **Error**: `ApiException<RollingWindowPriceChangeStatisticsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RollingWindowPriceChangeStatisticsRequest` | `Requests/Market/RollingWindowPriceChangeStatisticsRequest.cs` |
| `ApiV3TickerResponse` | `Models/ApiV3TickerResponse.cs` |
| `RollingWindowPriceChangeStatisticsError` | `Errors/RollingWindowPriceChangeStatisticsError.cs` |
| `Error` | `Models/Error.cs` |

### SymbolOrderBookTicker

- **Signature**: `SymbolOrderBookTicker(SymbolOrderBookTickerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`
- **Returns**: `ApiV3TickerBookTickerResponse`
- **Error**: `ApiException<SymbolOrderBookTickerError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SymbolOrderBookTickerRequest` | `Requests/Market/SymbolOrderBookTickerRequest.cs` |
| `ApiV3TickerBookTickerResponse` | `Models/AnyOf/ApiV3TickerBookTickerResponse.cs` |
| `SymbolOrderBookTickerError` | `Errors/SymbolOrderBookTickerError.cs` |
| `Error` | `Models/Error.cs` |

### SymbolPriceTicker

- **Signature**: `SymbolPriceTicker(SymbolPriceTickerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`
- **Returns**: `ApiV3TickerPriceResponse`
- **Error**: `ApiException<SymbolPriceTickerError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SymbolPriceTickerRequest` | `Requests/Market/SymbolPriceTickerRequest.cs` |
| `ApiV3TickerPriceResponse` | `Models/AnyOf/ApiV3TickerPriceResponse.cs` |
| `SymbolPriceTickerError` | `Errors/SymbolPriceTickerError.cs` |
| `Error` | `Models/Error.cs` |

### TestConnectivity

- **Signature**: `TestConnectivity(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

### TradingDayTicker

- **Signature**: `TradingDayTicker(TradingDayTickerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`, `timeZone` ← `TimeZone`, `type` ← `Type`
- **Returns**: `ApiV3TickerTradingDayResponse`
- **Error**: `ApiException<TradingDayTickerError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TradingDayTickerRequest` | `Requests/Market/TradingDayTickerRequest.cs` |
| `TypeEnum` | `Models/Enums/TypeEnum.cs` |
| `ApiV3TickerTradingDayResponse` | `Models/AnyOf/ApiV3TickerTradingDayResponse.cs` |
| `TradingDayTickerError` | `Errors/TradingDayTickerError.cs` |
| `Error` | `Models/Error.cs` |

### UiKlines

- **Signature**: `UiKlines(UiKlinesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Interval`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `interval` ← `Interval`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `timeZone` ← `TimeZone`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<IReadOnlyList<ApiV3UiKlinesResponse>>`
- **Error**: `ApiException<UiKlinesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UiKlinesRequest` | `Requests/Market/UiKlinesRequest.cs` |
| `Interval` | `Models/Enums/Interval.cs` |
| `ApiV3UiKlinesResponse` | `Models/AnyOf/ApiV3UiKlinesResponse.cs` |
| `UiKlinesError` | `Errors/UiKlinesError.cs` |
| `Error` | `Models/Error.cs` |

