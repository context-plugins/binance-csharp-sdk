using System;
using System.Collections.Generic;
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
using Binance.Requests.ConvertApi;

namespace Binance.Api;

/// <summary>
/// Convert Endpoints
/// </summary>
public sealed class ConvertApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ConvertApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Accept Quote (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertAcceptQuoteResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AcceptQuoteTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Accept the offered quote by quote ID.
    /// <para>
    /// Weight(UID): 500
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertAcceptQuoteResponse> AcceptQuoteTrade(AcceptQuoteTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/convert/acceptQuote"),
            [],
            [
                new Param("quoteId", request.QuoteId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertAcceptQuoteResponse>(),
            AcceptQuoteTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel limit order (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertLimitCancelOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelLimitOrderUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable users to cancel a limit order
    /// <para>
    /// Weight(UID): 200
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertLimitCancelOrderResponse> CancelLimitOrderUserData(CancelLimitOrderUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/convert/limit/cancelOrder"),
            [],
            [
                new Param("orderId", request.OrderId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertLimitCancelOrderResponse>(),
            CancelLimitOrderUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Convert Trade History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertTradeFlowResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetConvertTradeHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The max interval between startTime and endTime is 30 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertTradeFlowResponse> GetConvertTradeHistoryUserData(GetConvertTradeHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/convert/tradeFlow"),
            [],
            [
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertTradeFlowResponse>(),
            GetConvertTradeHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List All Convert Pairs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1ConvertExchangeInfoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAllConvertPairsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query for all convertible token pairs and the tokens’ respective upper/lower limits
    /// <para>
    /// Weight(IP): 3000
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1ConvertExchangeInfoResponse>> ListAllConvertPairs(ListAllConvertPairsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/convert/exchangeInfo"),
            [],
            [new Param("fromAsset", request.FromAsset), new Param("toAsset", request.ToAsset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1ConvertExchangeInfoResponse>>(),
            ListAllConvertPairsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Order status (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertOrderStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="OrderStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query order status by order ID.
    /// <para>
    /// Weight(UID): 100
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertOrderStatusResponse> OrderStatusUserData(OrderStatusUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/convert/orderStatus"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("quoteId", request.QuoteId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertOrderStatusResponse>(),
            OrderStatusUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Place limit order (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertLimitPlaceOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PlaceLimitOrderUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable users to place a limit order
    /// <list type="bullet">
    ///   <item><description>baseAsset or quoteAsset can be determined via exchangeInfo endpoint.</description></item>
    ///   <item><description>Limit price is defined from baseAsset to quoteAsset.</description></item>
    ///   <item><description>Either baseAmount or quoteAmount is used.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 500
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertLimitPlaceOrderResponse> PlaceLimitOrderUserData(PlaceLimitOrderUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/convert/limit/placeOrder"),
            [],
            [
                new Param("baseAsset", request.BaseAsset),
                new Param("quoteAsset", request.QuoteAsset),
                new Param("limitPrice", request.LimitPrice),
                new Param("side", request.Side),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("baseAmount", request.BaseAmount),
                new Param("quoteAmount", request.QuoteAmount),
                new Param("walletType", request.WalletType),
                new Param("expiredType", request.ExpiredType),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertLimitPlaceOrderResponse>(),
            PlaceLimitOrderUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query limit open orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertLimitQueryOpenOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryLimitOpenOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable users to query for all existing limit orders
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertLimitQueryOpenOrdersResponse> QueryLimitOpenOrdersUserData(QueryLimitOpenOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/convert/limit/queryOpenOrders"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertLimitQueryOpenOrdersResponse>(),
            QueryLimitOpenOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query order quantity precision per asset (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1ConvertAssetInfoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryOrderQuantityPrecisionPerAssetUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query for supported asset precision information
    /// <para>
    /// Weight(IP): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1ConvertAssetInfoResponse>> QueryOrderQuantityPrecisionPerAssetUserData(QueryOrderQuantityPrecisionPerAssetUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/convert/assetInfo"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1ConvertAssetInfoResponse>>(),
            QueryOrderQuantityPrecisionPerAssetUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Send quote request (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertGetQuoteResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SendQuoteRequestUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Request a quote for the requested token pairs
    /// <para>
    /// Weight(UID): 200
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertGetQuoteResponse> SendQuoteRequestUserData(SendQuoteRequestUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/convert/getQuote"),
            [],
            [
                new Param("fromAsset", request.FromAsset),
                new Param("toAsset", request.ToAsset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("fromAmount", request.FromAmount),
                new Param("toAmount", request.ToAmount),
                new Param("validTime", request.ValidTime),
                new Param("walletType", request.WalletType),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertGetQuoteResponse>(),
            SendQuoteRequestUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
