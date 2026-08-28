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
using Binance.Models.Enums;

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
    /// <param name="quoteId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertAcceptQuoteResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AcceptQuoteTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Accept the offered quote by quote ID.
    /// <para>
    /// Weight(UID): 500
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertAcceptQuoteResponse> AcceptQuoteTrade(string quoteId,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/convert/acceptQuote"),
            [],
            [new Param("quoteId", quoteId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertAcceptQuoteResponse>(),
            AcceptQuoteTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel limit order (USER_DATA)
    /// </summary>
    /// <param name="orderId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertLimitCancelOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelLimitOrderUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable users to cancel a limit order
    /// <para>
    /// Weight(UID): 200
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertLimitCancelOrderResponse> CancelLimitOrderUserData(long orderId,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/convert/limit/cancelOrder"),
            [],
            [new Param("orderId", orderId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertLimitCancelOrderResponse>(),
            CancelLimitOrderUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Convert Trade History (USER_DATA)
    /// </summary>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="limit">default 100, max 1000</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertTradeFlowResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetConvertTradeHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The max interval between startTime and endTime is 30 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertTradeFlowResponse> GetConvertTradeHistoryUserData(long startTime,
        long endTime,
        long timestamp,
        string signature,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/convert/tradeFlow"),
            [],
            [new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertTradeFlowResponse>(),
            GetConvertTradeHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List All Convert Pairs
    /// </summary>
    /// <param name="fromAsset">User spends coin</param>
    /// <param name="toAsset">User receives coin</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1ConvertExchangeInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAllConvertPairsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query for all convertible token pairs and the tokens’ respective upper/lower limits
    /// <para>
    /// Weight(IP): 3000
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1ConvertExchangeInfoResponse>> ListAllConvertPairs(string? fromAsset,
        string? toAsset,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/convert/exchangeInfo"),
            [],
            [new Param("fromAsset", fromAsset), new Param("toAsset", toAsset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1ConvertExchangeInfoResponse>>(),
            ListAllConvertPairsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Order status (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId"></param>
    /// <param name="quoteId"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertOrderStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrderStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query order status by order ID.
    /// <para>
    /// Weight(UID): 100
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertOrderStatusResponse> OrderStatusUserData(long timestamp,
        string signature,
        string? orderId,
        string? quoteId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/convert/orderStatus"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("quoteId", quoteId),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertOrderStatusResponse>(),
            OrderStatusUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Place limit order (USER_DATA)
    /// </summary>
    /// <param name="baseAsset"></param>
    /// <param name="quoteAsset"></param>
    /// <param name="limitPrice">Symbol limit price (from baseAsset to quoteAsset)</param>
    /// <param name="side"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="baseAmount">Base asset amount. (One of baseAmount or quoteAmount is required)</param>
    /// <param name="quoteAmount">Quote asset amount. (One of baseAmount or quoteAmount is required)</param>
    /// <param name="walletType">SPOT or FUNDING or SPOT_FUNDING. It is to use which type of assets. Default is SPOT.</param>
    /// <param name="expiredType">1_D, 3_D, 7_D, 30_D (D means day)</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertLimitPlaceOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PlaceLimitOrderUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1ConvertLimitPlaceOrderResponse> PlaceLimitOrderUserData(string baseAsset,
        string quoteAsset,
        double limitPrice,
        Side side,
        long timestamp,
        string signature,
        double? baseAmount,
        double? quoteAmount,
        WalletType? walletType,
        ExpiredType? expiredType,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/convert/limit/placeOrder"),
            [],
            [new Param("baseAsset", baseAsset),
                new Param("quoteAsset", quoteAsset),
                new Param("limitPrice", limitPrice),
                new Param("side", side),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("baseAmount", baseAmount),
                new Param("quoteAmount", quoteAmount),
                new Param("walletType", walletType),
                new Param("expiredType", expiredType),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertLimitPlaceOrderResponse>(),
            PlaceLimitOrderUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query limit open orders (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertLimitQueryOpenOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryLimitOpenOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable users to query for all existing limit orders
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertLimitQueryOpenOrdersResponse> QueryLimitOpenOrdersUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/convert/limit/queryOpenOrders"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertLimitQueryOpenOrdersResponse>(),
            QueryLimitOpenOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query order quantity precision per asset (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1ConvertAssetInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryOrderQuantityPrecisionPerAssetUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query for supported asset precision information
    /// <para>
    /// Weight(IP): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1ConvertAssetInfoResponse>> QueryOrderQuantityPrecisionPerAssetUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/convert/assetInfo"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1ConvertAssetInfoResponse>>(),
            QueryOrderQuantityPrecisionPerAssetUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Send quote request (USER_DATA)
    /// </summary>
    /// <param name="fromAsset"></param>
    /// <param name="toAsset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="fromAmount">When specified, it is the amount you will be debited after the conversion</param>
    /// <param name="toAmount">When specified, it is the amount you will be debited after the conversion</param>
    /// <param name="validTime">10s, 30s, 1m, 2m, default 10s</param>
    /// <param name="walletType">SPOT or FUNDING. Default is SPOT</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ConvertGetQuoteResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SendQuoteRequestUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Request a quote for the requested token pairs
    /// <para>
    /// Weight(UID): 200
    /// </para>
    /// </remarks>
    public Task<SapiV1ConvertGetQuoteResponse> SendQuoteRequestUserData(string fromAsset,
        string toAsset,
        long timestamp,
        string signature,
        double? fromAmount,
        double? toAmount,
        string? validTime,
        string? walletType,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/convert/getQuote"),
            [],
            [new Param("fromAsset", fromAsset),
                new Param("toAsset", toAsset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("fromAmount", fromAmount),
                new Param("toAmount", toAmount),
                new Param("validTime", validTime),
                new Param("walletType", walletType),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ConvertGetQuoteResponse>(),
            SendQuoteRequestUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
