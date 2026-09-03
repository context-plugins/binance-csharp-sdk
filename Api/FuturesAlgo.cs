using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core;
using BinancePublicSpotApi.Core.Exceptions;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Core.Request;
using BinancePublicSpotApi.Core.Response;
using BinancePublicSpotApi.Errors;
using BinancePublicSpotApi.Models;
using BinancePublicSpotApi.Models.Enums;

namespace BinancePublicSpotApi.Api;

/// <summary>
/// Futures Algo Endpoints
/// </summary>
public sealed class FuturesAlgo
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FuturesAlgo(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel Algo Order(TRADE)
    /// </summary>
    /// <param name="algoId">Eg. 14511</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelAlgoOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an active order.
    /// - You need to enable Futures Trading Permission for the api key which requests this endpoint.
    /// - Base URL: https://api.binance.com
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesOrderResponse> CancelAlgoOrderTrade(long algoId,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/futures/order"),
            [],
            [new Param("algoId", algoId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesOrderResponse>(),
            CancelAlgoOrderTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Current Algo Open Orders (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesOpenOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryCurrentAlgoOpenOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>You need to enable Futures Trading Permission for the api key which requests this endpoint.</description></item>
    ///   <item><description>Base URL: https://api.binance.com</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesOpenOrdersResponse> QueryCurrentAlgoOpenOrdersUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/futures/openOrders"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesOpenOrdersResponse>(),
            QueryCurrentAlgoOpenOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Historical Algo Orders (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="pageSize">MIN 1, MAX 100; Default 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesHistoricalOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryHistoricalAlgoOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>You need to enable Futures Trading Permission for the api key which requests this endpoint.</description></item>
    ///   <item><description>Base URL: https://api.binance.com</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesHistoricalOrdersResponse> QueryHistoricalAlgoOrdersUserData(long timestamp,
        string signature,
        string? symbol,
        Side? side,
        long? startTime,
        long? endTime,
        int? page,
        string? pageSize,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/futures/historicalOrders"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("symbol", symbol),
                new Param("side", side),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("pageSize", pageSize),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesHistoricalOrdersResponse>(),
            QueryHistoricalAlgoOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Sub Orders (USER_DATA)
    /// </summary>
    /// <param name="algoId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="page">Default 1</param>
    /// <param name="pageSize">MIN 1, MAX 100; Default 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesSubOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QuerySubOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>You need to enable Futures Trading Permission for the api key which requests this endpoint.</description></item>
    ///   <item><description>Base URL: https://api.binance.com</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesSubOrdersResponse> QuerySubOrdersUserData(long algoId,
        long timestamp,
        string signature,
        int? page,
        string? pageSize,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/futures/subOrders"),
            [],
            [new Param("algoId", algoId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("page", page),
                new Param("pageSize", pageSize),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesSubOrdersResponse>(),
            QuerySubOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Time-Weighted Average Price(Twap) New Order (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="quantity">Quantity of base asset; The notional (quantity * mark price(base asset)) must be more than the equivalent of 10,000 USDT and less than the equivalent of 1,000,000 USDT</param>
    /// <param name="duration">Duration for TWAP orders in seconds. [300, 86400];Less than 5min =&gt; defaults to 5 min; Greater than 24h =&gt; defaults to 24h</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="positionSide">Default BOTH for One-way Mode ; LONG or SHORT for Hedge Mode. It must be sent in Hedge Mode.</param>
    /// <param name="clientAlgoId">A unique id among Algo orders (length should be 32 characters)， If it is not sent, we will give default value</param>
    /// <param name="reduceOnly">'true' or 'false'. Default 'false'; Cannot be sent in Hedge Mode; Cannot be sent when you open a position</param>
    /// <param name="limitPrice">Limit price of the order; If it is not sent, will place order by market price by default</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesNewOrderTwapResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TimeWeightedAveragePriceTwapNewOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Send in a Twap new order. Only support on USDⓈ-M Contracts.
    /// <para>
    /// You need to enable Futures Trading Permission for the api key which requests this endpoint.
    /// Base URL: https://api.binance.com
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Total Algo open orders max allowed: 10 orders.</description></item>
    ///   <item><description>Leverage of symbols and position mode will be the same as your futures account settings. You can set up through the trading page or fapi.</description></item>
    ///   <item><description>Receiving "success": true does not mean that your order will be executed. Please use the query order endpoints(GET sapi/v1/algo/futures/openOrders or GET sapi/v1/algo/futures/historicalOrders) to check the order status. For example: Your futures balance is insufficient, or open position with reduce only or position side is inconsistent with your own setting. In these cases you will receive "success": true, but the order status will be expired after we check it.</description></item>
    ///   <item><description>quantity * 60 / duration should be larger than minQty</description></item>
    ///   <item><description>duration cannot be less than 5 mins or more than 24 hours.</description></item>
    ///   <item><description>For delivery contracts, TWAP end time should be one hour earlier than the delivery time of the symbol.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesNewOrderTwapResponse> TimeWeightedAveragePriceTwapNewOrderTrade(string symbol,
        Side side,
        double quantity,
        long duration,
        long timestamp,
        string signature,
        PositionSide? positionSide,
        string? clientAlgoId,
        bool? reduceOnly,
        double? limitPrice,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/futures/newOrderTwap"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("quantity", quantity),
                new Param("duration", duration),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("positionSide", positionSide),
                new Param("clientAlgoId", clientAlgoId),
                new Param("reduceOnly", reduceOnly),
                new Param("limitPrice", limitPrice),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesNewOrderTwapResponse>(),
            TimeWeightedAveragePriceTwapNewOrderTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Volume Participation(VP) New Order (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="quantity">Quantity of base asset; The notional (quantity * mark price(base asset)) must be more than the equivalent of 10,000 USDT and less than the equivalent of 1,000,000 USDT</param>
    /// <param name="urgency">Represent the relative speed of the current execution; ENUM: LOW, MEDIUM, HIGH</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="positionSide">Default BOTH for One-way Mode ; LONG or SHORT for Hedge Mode. It must be sent in Hedge Mode.</param>
    /// <param name="clientAlgoId">A unique id among Algo orders (length should be 32 characters)， If it is not sent, we will give default value</param>
    /// <param name="reduceOnly">'true' or 'false'. Default 'false'; Cannot be sent in Hedge Mode; Cannot be sent when you open a position</param>
    /// <param name="limitPrice">Limit price of the order; If it is not sent, will place order by market price by default</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesNewOrderVpResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VolumeParticipationVpNewOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Send in a VP new order. Only support on USDⓈ-M Contracts.
    /// <list type="bullet">
    ///   <item><description>You need to enable <c>Futures Trading Permission</c> for the api key which requests this endpoint.</description></item>
    ///   <item><description>Base URL: https://api.binance.com</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Total Algo open orders max allowed: 10 orders.</description></item>
    ///   <item><description>Leverage of symbols and position mode will be the same as your futures account settings. You can set up through the trading page or fapi.</description></item>
    ///   <item><description>Receiving "success": true does not mean that your order will be executed. Please use the query order endpoints(GET sapi/v1/algo/futures/openOrders or GET sapi/v1/algo/futures/historicalOrders) to check the order status. For example: Your futures balance is insufficient, or open position with reduce only or position side is inconsistent with your own setting. In these cases you will receive "success": true, but the order status will be expired after we check it.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesNewOrderVpResponse> VolumeParticipationVpNewOrderTrade(string symbol,
        Side side,
        double quantity,
        Urgency urgency,
        long timestamp,
        string signature,
        PositionSide? positionSide,
        string? clientAlgoId,
        bool? reduceOnly,
        double? limitPrice,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/futures/newOrderVp"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("quantity", quantity),
                new Param("urgency", urgency),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("positionSide", positionSide),
                new Param("clientAlgoId", clientAlgoId),
                new Param("reduceOnly", reduceOnly),
                new Param("limitPrice", limitPrice),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesNewOrderVpResponse>(),
            VolumeParticipationVpNewOrderTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
