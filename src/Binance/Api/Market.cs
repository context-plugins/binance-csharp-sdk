using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core;
using Binance.Core.ErrorResponse;
using Binance.Core.Exceptions;
using Binance.Core.Models;
using Binance.Core.Request;
using Binance.Core.Response;
using Binance.Errors;
using Binance.Models;
using Binance.Models.AnyOf;
using Binance.Requests.Market;

namespace Binance.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3Ticker24HrResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="HrTickerPriceChangeStatistics24Error"/> when the server returns an error response.</exception>
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
    public Task<ApiV3Ticker24HrResponse> HrTickerPriceChangeStatistics24(HrTickerPriceChangeStatistics24Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/ticker/24hr"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("symbols", request.Symbols),
                new Param("type", request.Type),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3Ticker24HrResponse>(),
            HrTickerPriceChangeStatistics24Error.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Check Server Time
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TimeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Test connectivity to the Rest API and get the current server time.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<ApiV3TimeResponse> CheckServerTime(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/time"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TimeResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Compressed/Aggregate Trades List
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="AggTrade"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CompressedAggregateTradesListError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<AggTrade>> CompressedAggregateTradesList(CompressedAggregateTradesListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/aggTrades"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("fromId", request.FromId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<AggTrade>>(),
            CompressedAggregateTradesListError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Current Average Price
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3AvgPriceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CurrentAveragePriceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Current average price for a symbol.
    /// <para>
    /// Weight(IP): 2
    /// </para>
    /// </remarks>
    public Task<ApiV3AvgPriceResponse> CurrentAveragePrice(CurrentAveragePriceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/avgPrice"),
            [],
            [new Param("symbol", request.Symbol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3AvgPriceResponse>(),
            CurrentAveragePriceError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Exchange Information
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3ExchangeInfoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ExchangeInformationError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3ExchangeInfoResponse> ExchangeInformation(ExchangeInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/exchangeInfo"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("symbols", request.Symbols),
                new Param("permissions", request.Permissions),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3ExchangeInfoResponse>(),
            ExchangeInformationError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Kline/Candlestick Data
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3KlinesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="KlineCandlestickDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<IReadOnlyList<ApiV3KlinesResponse>>> KlineCandlestickData(KlineCandlestickDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/klines"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("interval", request.Interval),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("timeZone", request.TimeZone),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<IReadOnlyList<ApiV3KlinesResponse>>>(),
            KlineCandlestickDataError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Old Trade Lookup
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Trade"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get older market trades.
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<Trade>> OldTradeLookup(OldTradeLookupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/historicalTrades"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("limit", request.Limit),
                new Param("fromId", request.FromId),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Trade>>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Order Book
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3DepthResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="OrderBookError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// | Limit               | Weight(IP)  |
    /// |---------------------|-------------|
    /// | 1-100               | 5           |
    /// | 101-500             | 25          |
    /// | 501-1000            | 50          |
    /// | 1001-5000           | 250         |
    /// </remarks>
    public Task<ApiV3DepthResponse> OrderBook(OrderBookRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/depth"),
            [],
            [new Param("symbol", request.Symbol), new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3DepthResponse>(),
            OrderBookError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Recent Trades List
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Trade"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RecentTradesListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get recent trades.
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<Trade>> RecentTradesList(RecentTradesListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/trades"),
            [],
            [new Param("symbol", request.Symbol), new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Trade>>(),
            RecentTradesListError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Rolling window price change statistics
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TickerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RollingWindowPriceChangeStatisticsError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3TickerResponse> RollingWindowPriceChangeStatistics(RollingWindowPriceChangeStatisticsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/ticker"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("symbols", request.Symbols),
                new Param("windowSize", request.WindowSize),
                new Param("type", request.Type),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TickerResponse>(),
            RollingWindowPriceChangeStatisticsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Symbol Order Book Ticker
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TickerBookTickerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SymbolOrderBookTickerError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3TickerBookTickerResponse> SymbolOrderBookTicker(SymbolOrderBookTickerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/ticker/bookTicker"),
            [],
            [new Param("symbol", request.Symbol), new Param("symbols", request.Symbols)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TickerBookTickerResponse>(),
            SymbolOrderBookTickerError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Symbol Price Ticker
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TickerPriceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SymbolPriceTickerError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3TickerPriceResponse> SymbolPriceTicker(SymbolPriceTickerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/ticker/price"),
            [],
            [new Param("symbol", request.Symbol), new Param("symbols", request.Symbols)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TickerPriceResponse>(),
            SymbolPriceTickerError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Test Connectivity
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Test connectivity to the Rest API.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<object> TestConnectivity(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/ping"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Trading Day Ticker
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3TickerTradingDayResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TradingDayTickerError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3TickerTradingDayResponse> TradingDayTicker(TradingDayTickerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/ticker/tradingDay"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("symbols", request.Symbols),
                new Param("timeZone", request.TimeZone),
                new Param("type", request.Type),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3TickerTradingDayResponse>(),
            TradingDayTickerError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UIKlines
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3UiKlinesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UiKlinesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The request is similar to klines having the same parameters and response.
    /// <para>
    /// uiKlines return modified kline data, optimized for presentation of candlestick charts.
    /// </para>
    /// <para>
    /// Weight(IP): 2
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<IReadOnlyList<ApiV3UiKlinesResponse>>> UiKlines(UiKlinesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/uiKlines"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("interval", request.Interval),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("timeZone", request.TimeZone),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<IReadOnlyList<ApiV3UiKlinesResponse>>>(),
            UiKlinesError.Response,
            [],
            requestOptions,
            cancellationToken);
}
