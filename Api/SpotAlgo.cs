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
using Binance.Models.Enums;

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
    /// <param name="algoId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelAlgoOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an open TWAP order
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotOrderResponse> CancelAlgoOrder(long algoId,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/spot/order"),
            [],
            [new Param("algoId", algoId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoSpotOrderResponse>(),
            CancelAlgoOrderErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Current Algo Open Orders
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotOpenOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryCurrentAlgoOpenOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all open SPOT TWAP orders
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotOpenOrdersResponse> QueryCurrentAlgoOpenOrders(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/spot/openOrders"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoSpotOpenOrdersResponse>(),
            QueryCurrentAlgoOpenOrdersErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Historical Algo Orders
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="pageSize">MIN 1, MAX 100; Default 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotHistoricalOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryHistoricalAlgoOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all historical SPOT TWAP orders
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotHistoricalOrdersResponse> QueryHistoricalAlgoOrders(string symbol,
        Side side,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? page,
        string? pageSize,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/spot/historicalOrders"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("pageSize", pageSize),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoSpotHistoricalOrdersResponse>(),
            QueryHistoricalAlgoOrdersErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Sub Orders
    /// </summary>
    /// <param name="algoId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="page">Default 1</param>
    /// <param name="pageSize">MIN 1, MAX 100; Default 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotSubOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QuerySubOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get respective sub orders for a specified algoId
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotSubOrdersResponse> QuerySubOrders(long algoId,
        long timestamp,
        string signature,
        int? page,
        string? pageSize,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/spot/subOrders"),
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
            JsonResponse.Create<SapiV1AlgoSpotSubOrdersResponse>(),
            QuerySubOrdersErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Time-Weighted Average Price (Twap) New Order
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="quantity"></param>
    /// <param name="duration"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="clientAlgoId"></param>
    /// <param name="limitPrice"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AlgoSpotNewOrderTwapResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TimeWeightedAveragePriceTwapNewOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Place a new spot TWAP order with Algo service.
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1AlgoSpotNewOrderTwapResponse> TimeWeightedAveragePriceTwapNewOrder(string symbol,
        Side side,
        double quantity,
        int duration,
        long timestamp,
        string signature,
        string? clientAlgoId,
        double? limitPrice,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/algo/spot/newOrderTwap"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("quantity", quantity),
                new Param("duration", duration),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("clientAlgoId", clientAlgoId),
                new Param("limitPrice", limitPrice),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AlgoSpotNewOrderTwapResponse>(),
            TimeWeightedAveragePriceTwapNewOrderErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
