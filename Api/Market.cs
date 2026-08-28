using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Exceptions;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Core.Request;
using BinancePublicSpotApi.Core.Response;
using BinancePublicSpotApi.Errors;
using BinancePublicSpotApi.Models;
using BinancePublicSpotApi.Models.AnyOf;
using BinancePublicSpotApi.Models.Enums;

namespace BinancePublicSpotApi.Api;

/// <summary>
/// Market Data
/// </summary>
public sealed class Market
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Market(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// 24hr Ticker Price Change Statistics
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="symbols"></param>
    /// <param name="type">Supported values: FULL or MINI. If none provided, the default is FULL</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3Ticker24HrResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="HrTickerPriceChangeStatistics24Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// 24 hour rolling window price change statistics. Careful when accessing this with no symbol.
    /// <list type="bullet">
    ///   <item><description>If the symbol is not sent, tickers for all symbols will be returned in an array.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP):
    /// - <c>2</c> for a single symbol;
    /// - <c>80</c> when the symbol parameter is omitted;
    /// </para>
    /// </remarks>
    public Task<ApiV3Ticker24HrResponse> HrTickerPriceChangeStatistics24(string? symbol,
        string? symbols,
        TypeEnum? type,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/ticker/24hr"),
            [],
            [new Param("symbol", symbol), new Param("symbols", symbols), new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3Ticker24HrResponse>(),
            HrTickerPriceChangeStatistics24ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Check Server Time
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TimeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Test connectivity to the Rest API and get the current server time.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<ApiV3TimeResponse> CheckServerTime(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/time"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TimeResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Compressed/Aggregate Trades List
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="fromId">Trade id to fetch from. Default gets most recent trades.</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="AggTrade"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CompressedAggregateTradesListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get compressed, aggregate trades. Trades that fill at the time, from the same order, with the same price will have the quantity aggregated.
    /// - If <c>fromId</c>, <c>startTime</c>, and <c>endTime</c> are not sent, the most recent aggregate trades will be returned.
    /// - Note that if a trade has the following values, this was a duplicate aggregate trade and marked as invalid:
    /// <para>
    ///   p = '0' // price
    /// </para>
    /// <para>
    ///   q = '0' // qty
    /// </para>
    /// <para>
    ///   f = -1 // ﬁrst_trade_id
    /// </para>
    /// <para>
    ///   l = -1 // last_trade_id
    /// </para>
    /// <para>
    /// Weight(IP): 2
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<AggTrade>> CompressedAggregateTradesList(string symbol,
        long? fromId,
        long? startTime,
        long? endTime,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/aggTrades"),
            [],
            [new Param("symbol", symbol),
                new Param("fromId", fromId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<AggTrade>>(),
            CompressedAggregateTradesListErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Current Average Price
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3AvgPriceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CurrentAveragePriceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Current average price for a symbol.
    /// <para>
    /// Weight(IP): 2
    /// </para>
    /// </remarks>
    public Task<ApiV3AvgPriceResponse> CurrentAveragePrice(string symbol,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/avgPrice"),
            [],
            [new Param("symbol", symbol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3AvgPriceResponse>(),
            CurrentAveragePriceErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Exchange Information
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="symbols"></param>
    /// <param name="permissions"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3ExchangeInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ExchangeInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Current exchange trading rules and symbol information
    /// <list type="bullet">
    ///   <item><description>If any symbol provided in either symbol or symbols do not exist, the endpoint will throw an error.</description></item>
    ///   <item><description>All parameters are optional.</description></item>
    ///   <item><description>permissions can support single or multiple values (e.g. SPOT, ["MARGIN","LEVERAGED"])</description></item>
    ///   <item><description>If permissions parameter not provided, the default values will be ["SPOT","MARGIN","LEVERAGED"].
    ///     <list type="bullet">
    ///       <item><description>To display all permissions you need to specify them explicitly. (e.g. SPOT, MARGIN,...)</description></item>
    ///     </list>
    ///   </description></item>
    /// </list>
    /// <para>
    /// Examples of Symbol Permissions Interpretation from the Response:
    /// - [["A","B"]] means you may place an order if your account has either permission "A" or permission "B".
    /// - [["A"],["B"]] means you can place an order if your account has permission "A" and permission "B".
    /// - [["A"],["B","C"]] means you can place an order if your account has permission "A" and permission "B" or permission "C". (Inclusive or is applied here, not exclusive or, so your account may have both permission "B" and permission "C".)
    /// </para>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<ApiV3ExchangeInfoResponse> ExchangeInformation(string? symbol,
        string? symbols,
        string? permissions,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/exchangeInfo"),
            [],
            [new Param("symbol", symbol), new Param("symbols", symbols), new Param("permissions", permissions)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3ExchangeInfoResponse>(),
            ExchangeInformationErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Kline/Candlestick Data
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="interval">kline intervals</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="timeZone">Default: 0 (UTC)</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3KlinesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="KlineCandlestickDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Kline/candlestick bars for a symbol.
    /// Klines are uniquely identified by their open time.
    /// <list type="bullet">
    ///   <item><description>If <c>startTime</c> and <c>endTime</c> are not sent, the most recent klines are returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 2
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<IReadOnlyList<ApiV3KlinesResponse>>> KlineCandlestickData(string symbol,
        Interval interval,
        long? startTime,
        long? endTime,
        string? timeZone,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/klines"),
            [],
            [new Param("symbol", symbol),
                new Param("interval", interval),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("timeZone", timeZone),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<IReadOnlyList<ApiV3KlinesResponse>>>(),
            KlineCandlestickDataErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Old Trade Lookup
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="fromId">Trade id to fetch from. Default gets most recent trades.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Trade"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get older market trades.
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<Trade>> OldTradeLookup(string symbol,
        int? limit,
        long? fromId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/historicalTrades"),
            [],
            [new Param("symbol", symbol), new Param("limit", limit), new Param("fromId", fromId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Trade>>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Order Book
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="limit">If limit &gt; 5000, then the response will truncate to 5000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3DepthResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrderBookError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// | Limit               | Weight(IP)  |
    /// |---------------------|-------------|
    /// | 1-100               | 5           |
    /// | 101-500             | 25          |
    /// | 501-1000            | 50          |
    /// | 1001-5000           | 250         |
    /// </remarks>
    public Task<ApiV3DepthResponse> OrderBook(string symbol,
        int? limit = 100,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/depth"),
            [],
            [new Param("symbol", symbol), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3DepthResponse>(),
            OrderBookErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Recent Trades List
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Trade"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RecentTradesListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get recent trades.
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<Trade>> RecentTradesList(string symbol,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/trades"),
            [],
            [new Param("symbol", symbol), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Trade>>(),
            RecentTradesListErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Rolling window price change statistics
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="symbols"></param>
    /// <param name="windowSize">Defaults to 1d if no parameter provided. Supported windowSize values: 1m,2m....59m for minutes 1h, 2h....23h - for hours 1d...7d - for days.  Units cannot be combined (e.g. 1d2h is not allowed)</param>
    /// <param name="type">Supported values: FULL or MINI. If none provided, the default is FULL</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TickerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RollingWindowPriceChangeStatisticsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The window used to compute statistics is typically slightly wider than requested windowSize.
    /// <para>
    /// openTime for /api/v3/ticker always starts on a minute, while the closeTime is the current time of the request. As such, the effective window might be up to 1 minute wider than requested.
    /// </para>
    /// <para>
    /// E.g. If the closeTime is 1641287867099 (January 04, 2022 09:17:47:099 UTC) , and the windowSize is 1d. the openTime will be: 1641201420000 (January 3, 2022, 09:17:00 UTC)
    /// </para>
    /// <para>
    /// Weight(IP): 4 for each requested symbol regardless of windowSize.
    /// </para>
    /// <para>
    /// The weight for this request will cap at 200 once the number of symbols in the request is more than 50.
    /// </para>
    /// </remarks>
    public Task<ApiV3TickerResponse> RollingWindowPriceChangeStatistics(string? symbol,
        string? symbols,
        string? windowSize,
        string? type,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/ticker"),
            [],
            [new Param("symbol", symbol),
                new Param("symbols", symbols),
                new Param("windowSize", windowSize),
                new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TickerResponse>(),
            RollingWindowPriceChangeStatisticsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Symbol Order Book Ticker
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="symbols"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TickerBookTickerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SymbolOrderBookTickerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Best price/qty on the order book for a symbol or symbols.
    /// <list type="bullet">
    ///   <item><description>If the symbol is not sent, bookTickers for all symbols will be returned in an array.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP):
    /// - <c>2</c> for a single symbol;
    /// - <c>4</c> when the symbol parameter is omitted;
    /// </para>
    /// </remarks>
    public Task<ApiV3TickerBookTickerResponse> SymbolOrderBookTicker(string? symbol,
        string? symbols,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/ticker/bookTicker"),
            [],
            [new Param("symbol", symbol), new Param("symbols", symbols)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TickerBookTickerResponse>(),
            SymbolOrderBookTickerErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Symbol Price Ticker
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="symbols"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TickerPriceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SymbolPriceTickerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Latest price for a symbol or symbols.
    /// <list type="bullet">
    ///   <item><description>If the symbol is not sent, prices for all symbols will be returned in an array.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP):
    /// - <c>2</c> for a single symbol;
    /// - <c>4</c> when the symbol parameter is omitted;
    /// </para>
    /// </remarks>
    public Task<ApiV3TickerPriceResponse> SymbolPriceTicker(string? symbol,
        string? symbols,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/ticker/price"),
            [],
            [new Param("symbol", symbol), new Param("symbols", symbols)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TickerPriceResponse>(),
            SymbolPriceTickerErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Test Connectivity
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Test connectivity to the Rest API.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<object> TestConnectivity(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/ping"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Trading Day Ticker
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="symbols"></param>
    /// <param name="timeZone">Default: 0 (UTC)</param>
    /// <param name="type">Supported values: FULL or MINI. If none provided, the default is FULL</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TickerTradingDayResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TradingDayTickerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Price change statistics for a trading day.
    /// <para>
    /// Notes:
    /// - Supported values for timeZone:
    ///   - Hours and minutes (e.g. -1:00, 05:45)
    ///   - Only hours (e.g. 0, 8, 4)
    /// </para>
    /// <para>
    /// Weight:
    /// - <c>4</c> for each requested symbol.
    /// - The weight for this request will cap at <c>200</c> once the number of symbols in the request is more than <c>50</c>.
    /// </para>
    /// </remarks>
    public Task<ApiV3TickerTradingDayResponse> TradingDayTicker(string? symbol,
        string? symbols,
        string? timeZone,
        TypeEnum? type,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/ticker/tradingDay"),
            [],
            [new Param("symbol", symbol),
                new Param("symbols", symbols),
                new Param("timeZone", timeZone),
                new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TickerTradingDayResponse>(),
            TradingDayTickerErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// UIKlines
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="interval">kline intervals</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="timeZone">Default: 0 (UTC)</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3UiKlinesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UiKlinesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The request is similar to klines having the same parameters and response.
    /// <para>
    /// uiKlines return modified kline data, optimized for presentation of candlestick charts.
    /// </para>
    /// <para>
    /// Weight(IP): 2
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<IReadOnlyList<ApiV3UiKlinesResponse>>> UiKlines(string symbol,
        Interval interval,
        long? startTime,
        long? endTime,
        string? timeZone,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/uiKlines"),
            [],
            [new Param("symbol", symbol),
                new Param("interval", interval),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("timeZone", timeZone),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<IReadOnlyList<ApiV3UiKlinesResponse>>>(),
            UiKlinesErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
