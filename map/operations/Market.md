<!-- Generated file — do not edit; regenerated with the SDK. -->

# Market — operations

Accessor: `client.Market` · Source: `src/Binance/Api/Market.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckServerTime

- **Signature**: `CheckServerTime(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ApiV3TimeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApiV3TimeResponse` | `src/Binance/Models/ApiV3TimeResponse.cs` |

### CompressedAggregateTradesList

- **Signature**: `CompressedAggregateTradesList(CompressedAggregateTradesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `fromId` ← `FromId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<AggTrade>`
- **Error**: `ApiException<CompressedAggregateTradesListError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CompressedAggregateTradesListRequest` | `src/Binance/Requests/Market/CompressedAggregateTradesListRequest.cs` |
| `AggTrade` | `src/Binance/Models/AggTrade.cs` |
| `CompressedAggregateTradesListError` | `src/Binance/Errors/CompressedAggregateTradesListError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### CurrentAveragePrice

- **Signature**: `CurrentAveragePrice(CurrentAveragePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`
- **Returns**: `ApiV3AvgPriceResponse`
- **Error**: `ApiException<CurrentAveragePriceError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CurrentAveragePriceRequest` | `src/Binance/Requests/Market/CurrentAveragePriceRequest.cs` |
| `ApiV3AvgPriceResponse` | `src/Binance/Models/ApiV3AvgPriceResponse.cs` |
| `CurrentAveragePriceError` | `src/Binance/Errors/CurrentAveragePriceError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### ExchangeInformation

- **Signature**: `ExchangeInformation(ExchangeInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`, `permissions` ← `Permissions`
- **Returns**: `ApiV3ExchangeInfoResponse`
- **Error**: `ApiException<ExchangeInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ExchangeInformationRequest` | `src/Binance/Requests/Market/ExchangeInformationRequest.cs` |
| `ApiV3ExchangeInfoResponse` | `src/Binance/Models/ApiV3ExchangeInfoResponse.cs` |
| `ExchangeInformationError` | `src/Binance/Errors/ExchangeInformationError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### HrTickerPriceChangeStatistics24

- **Signature**: `HrTickerPriceChangeStatistics24(HrTickerPriceChangeStatistics24Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`, `type` ← `Type`
- **Returns**: `ApiV3Ticker24HrResponse`
- **Error**: `ApiException<HrTickerPriceChangeStatistics24Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `HrTickerPriceChangeStatistics24Request` | `src/Binance/Requests/Market/HrTickerPriceChangeStatistics24Request.cs` |
| `TypeEnum` | `src/Binance/Models/Enums/TypeEnum.cs` |
| `ApiV3Ticker24HrResponse` | `src/Binance/Models/AnyOf/ApiV3Ticker24HrResponse.cs` |
| `HrTickerPriceChangeStatistics24Error` | `src/Binance/Errors/HrTickerPriceChangeStatistics24Error.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### KlineCandlestickData

- **Signature**: `KlineCandlestickData(KlineCandlestickDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Interval`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `interval` ← `Interval`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `timeZone` ← `TimeZone`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<IReadOnlyList<ApiV3KlinesResponse>>`
- **Error**: `ApiException<KlineCandlestickDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `KlineCandlestickDataRequest` | `src/Binance/Requests/Market/KlineCandlestickDataRequest.cs` |
| `Interval` | `src/Binance/Models/Enums/Interval.cs` |
| `ApiV3KlinesResponse` | `src/Binance/Models/AnyOf/ApiV3KlinesResponse.cs` |
| `KlineCandlestickDataError` | `src/Binance/Errors/KlineCandlestickDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### OldTradeLookup

- **Signature**: `OldTradeLookup(OldTradeLookupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `limit` ← `Limit`, `fromId` ← `FromId`
- **Returns**: `IReadOnlyList<Trade>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OldTradeLookupRequest` | `src/Binance/Requests/Market/OldTradeLookupRequest.cs` |
| `Trade` | `src/Binance/Models/Trade.cs` |

### OrderBook

- **Signature**: `OrderBook(OrderBookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `limit` ← `Limit`
- **Returns**: `ApiV3DepthResponse`
- **Error**: `ApiException<OrderBookError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrderBookRequest` | `src/Binance/Requests/Market/OrderBookRequest.cs` |
| `ApiV3DepthResponse` | `src/Binance/Models/ApiV3DepthResponse.cs` |
| `OrderBookError` | `src/Binance/Errors/OrderBookError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### RecentTradesList

- **Signature**: `RecentTradesList(RecentTradesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<Trade>`
- **Error**: `ApiException<RecentTradesListError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecentTradesListRequest` | `src/Binance/Requests/Market/RecentTradesListRequest.cs` |
| `Trade` | `src/Binance/Models/Trade.cs` |
| `RecentTradesListError` | `src/Binance/Errors/RecentTradesListError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### RollingWindowPriceChangeStatistics

- **Signature**: `RollingWindowPriceChangeStatistics(RollingWindowPriceChangeStatisticsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`, `windowSize` ← `WindowSize`, `type` ← `Type`
- **Returns**: `ApiV3TickerResponse`
- **Error**: `ApiException<RollingWindowPriceChangeStatisticsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RollingWindowPriceChangeStatisticsRequest` | `src/Binance/Requests/Market/RollingWindowPriceChangeStatisticsRequest.cs` |
| `ApiV3TickerResponse` | `src/Binance/Models/ApiV3TickerResponse.cs` |
| `RollingWindowPriceChangeStatisticsError` | `src/Binance/Errors/RollingWindowPriceChangeStatisticsError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SymbolOrderBookTicker

- **Signature**: `SymbolOrderBookTicker(SymbolOrderBookTickerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`
- **Returns**: `ApiV3TickerBookTickerResponse`
- **Error**: `ApiException<SymbolOrderBookTickerError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SymbolOrderBookTickerRequest` | `src/Binance/Requests/Market/SymbolOrderBookTickerRequest.cs` |
| `ApiV3TickerBookTickerResponse` | `src/Binance/Models/AnyOf/ApiV3TickerBookTickerResponse.cs` |
| `SymbolOrderBookTickerError` | `src/Binance/Errors/SymbolOrderBookTickerError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### SymbolPriceTicker

- **Signature**: `SymbolPriceTicker(SymbolPriceTickerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `symbols` ← `Symbols`
- **Returns**: `ApiV3TickerPriceResponse`
- **Error**: `ApiException<SymbolPriceTickerError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SymbolPriceTickerRequest` | `src/Binance/Requests/Market/SymbolPriceTickerRequest.cs` |
| `ApiV3TickerPriceResponse` | `src/Binance/Models/AnyOf/ApiV3TickerPriceResponse.cs` |
| `SymbolPriceTickerError` | `src/Binance/Errors/SymbolPriceTickerError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

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
| `TradingDayTickerRequest` | `src/Binance/Requests/Market/TradingDayTickerRequest.cs` |
| `TypeEnum` | `src/Binance/Models/Enums/TypeEnum.cs` |
| `ApiV3TickerTradingDayResponse` | `src/Binance/Models/AnyOf/ApiV3TickerTradingDayResponse.cs` |
| `TradingDayTickerError` | `src/Binance/Errors/TradingDayTickerError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### UiKlines

- **Signature**: `UiKlines(UiKlinesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Symbol`, `Interval`
- **Query params (wire ← C#)**: `symbol` ← `Symbol`, `interval` ← `Interval`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `timeZone` ← `TimeZone`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<IReadOnlyList<ApiV3UiKlinesResponse>>`
- **Error**: `ApiException<UiKlinesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UiKlinesRequest` | `src/Binance/Requests/Market/UiKlinesRequest.cs` |
| `Interval` | `src/Binance/Models/Enums/Interval.cs` |
| `ApiV3UiKlinesResponse` | `src/Binance/Models/AnyOf/ApiV3UiKlinesResponse.cs` |
| `UiKlinesError` | `src/Binance/Errors/UiKlinesError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

