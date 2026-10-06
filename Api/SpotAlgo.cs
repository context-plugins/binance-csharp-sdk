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
using Binance.Requests.SpotAlgo;

namespace Binance.Api;

/// <summary>
/// Spot Algo Endpoints
/// </summary>
public sealed class SpotAlgo
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SpotAlgo(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel Algo Order
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelAlgoOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an open TWAP order
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotOrderResponse> CancelAlgoOrder(CancelAlgoOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/spot/order"),
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
            JsonResponse.Create<SapiV1AlgoSpotOrderResponse>(),
            CancelAlgoOrderError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Current Algo Open Orders
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotOpenOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryCurrentAlgoOpenOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all open SPOT TWAP orders
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotOpenOrdersResponse> QueryCurrentAlgoOpenOrders(QueryCurrentAlgoOpenOrdersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/spot/openOrders"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoSpotOpenOrdersResponse>(),
            QueryCurrentAlgoOpenOrdersError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Historical Algo Orders
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotHistoricalOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryHistoricalAlgoOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all historical SPOT TWAP orders
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotHistoricalOrdersResponse> QueryHistoricalAlgoOrders(QueryHistoricalAlgoOrdersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/spot/historicalOrders"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("pageSize", request.PageSize),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoSpotHistoricalOrdersResponse>(),
            QueryHistoricalAlgoOrdersError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Sub Orders
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotSubOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QuerySubOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get respective sub orders for a specified algoId
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotSubOrdersResponse> QuerySubOrders(QuerySubOrdersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/spot/subOrders"),
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
            JsonResponse.Create<SapiV1AlgoSpotSubOrdersResponse>(),
            QuerySubOrdersError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Time-Weighted Average Price (Twap) New Order
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotNewOrderTwapResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TimeWeightedAveragePriceTwapNewOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Place a new spot TWAP order with Algo service.
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotNewOrderTwapResponse> TimeWeightedAveragePriceTwapNewOrder(TimeWeightedAveragePriceTwapNewOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/algo/spot/newOrderTwap"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("quantity", request.Quantity),
                new Param("duration", request.Duration),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("clientAlgoId", request.ClientAlgoId),
                new Param("limitPrice", request.LimitPrice),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoSpotNewOrderTwapResponse>(),
            TimeWeightedAveragePriceTwapNewOrderError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
