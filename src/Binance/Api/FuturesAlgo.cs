using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core;
using Binance.Core.Exceptions;
using Binance.Core.Models;
using Binance.Core.Request;
using Binance.Core.Response;
using Binance.Errors;
using Binance.Models;
using Binance.Requests.FuturesAlgo;

namespace Binance.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelAlgoOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an active order.
    /// - You need to enable Futures Trading Permission for the api key which requests this endpoint.
    /// - Base URL: https://api.binance.com
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesOrderResponse> CancelAlgoOrderTrade(CancelAlgoOrderTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/futures/order"),
            [],
            [
                new Param("algoId", request.AlgoId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesOrderResponse>(),
            CancelAlgoOrderTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Current Algo Open Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesOpenOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryCurrentAlgoOpenOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>You need to enable Futures Trading Permission for the api key which requests this endpoint.</description></item>
    ///   <item><description>Base URL: https://api.binance.com</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesOpenOrdersResponse> QueryCurrentAlgoOpenOrdersUserData(QueryCurrentAlgoOpenOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/futures/openOrders"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesOpenOrdersResponse>(),
            QueryCurrentAlgoOpenOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Historical Algo Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesHistoricalOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryHistoricalAlgoOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>You need to enable Futures Trading Permission for the api key which requests this endpoint.</description></item>
    ///   <item><description>Base URL: https://api.binance.com</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesHistoricalOrdersResponse> QueryHistoricalAlgoOrdersUserData(QueryHistoricalAlgoOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/futures/historicalOrders"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("pageSize", request.PageSize),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesHistoricalOrdersResponse>(),
            QueryHistoricalAlgoOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Sub Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesSubOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QuerySubOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>You need to enable Futures Trading Permission for the api key which requests this endpoint.</description></item>
    ///   <item><description>Base URL: https://api.binance.com</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoFuturesSubOrdersResponse> QuerySubOrdersUserData(QuerySubOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/futures/subOrders"),
            [],
            [
                new Param("algoId", request.AlgoId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("page", request.Page),
                new Param("pageSize", request.PageSize),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesSubOrdersResponse>(),
            QuerySubOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Time-Weighted Average Price(Twap) New Order (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesNewOrderTwapResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TimeWeightedAveragePriceTwapNewOrderTradeError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1AlgoFuturesNewOrderTwapResponse> TimeWeightedAveragePriceTwapNewOrderTrade(TimeWeightedAveragePriceTwapNewOrderTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/futures/newOrderTwap"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("quantity", request.Quantity),
                new Param("duration", request.Duration),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("positionSide", request.PositionSide),
                new Param("clientAlgoId", request.ClientAlgoId),
                new Param("reduceOnly", request.ReduceOnly),
                new Param("limitPrice", request.LimitPrice),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesNewOrderTwapResponse>(),
            TimeWeightedAveragePriceTwapNewOrderTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Volume Participation(VP) New Order (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoFuturesNewOrderVpResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="VolumeParticipationVpNewOrderTradeError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1AlgoFuturesNewOrderVpResponse> VolumeParticipationVpNewOrderTrade(VolumeParticipationVpNewOrderTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/futures/newOrderVp"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("quantity", request.Quantity),
                new Param("urgency", request.Urgency),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("positionSide", request.PositionSide),
                new Param("clientAlgoId", request.ClientAlgoId),
                new Param("reduceOnly", request.ReduceOnly),
                new Param("limitPrice", request.LimitPrice),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoFuturesNewOrderVpResponse>(),
            VolumeParticipationVpNewOrderTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
