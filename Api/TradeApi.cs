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
using Binance.Models.AnyOf;
using Binance.Models.Enums;

namespace Binance.Api;

/// <summary>
/// Account/Trade
/// </summary>
public sealed class TradeApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TradeApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Account Information (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Account"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AccountInformationUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get current account information.
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<Account> AccountInformationUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/account"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Account>(),
            AccountInformationUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Account Trade List (USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">This can only be used in combination with symbol.</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="fromId">Trade id to fetch from. Default gets most recent trades.</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="MyTrade"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AccountTradeListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get trades for a specific account and symbol.
    /// <para>
    /// If <c>fromId</c> is set, it will get id &gt;= that <c>fromId</c>. Otherwise most recent orders are returned.
    /// </para>
    /// <para>
    /// The time between startTime and endTime can't be longer than 24 hours.
    /// These are the supported combinations of all parameters:
    /// </para>
    /// <para>
    ///   symbol
    /// </para>
    /// <para>
    ///   symbol + orderId
    /// </para>
    /// <para>
    ///   symbol + startTime
    /// </para>
    /// <para>
    ///   symbol + endTime
    /// </para>
    /// <para>
    ///   symbol + fromId
    /// </para>
    /// <para>
    ///   symbol + startTime + endTime
    /// </para>
    /// <para>
    ///   symbol+ orderId + fromId
    /// </para>
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<MyTrade>> AccountTradeListUserData(string symbol,
        long timestamp,
        string signature,
        long? orderId,
        long? startTime,
        long? endTime,
        long? fromId,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/myTrades"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("fromId", fromId),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<MyTrade>>(),
            AccountTradeListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// All Orders (USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order id</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="OrderDetails"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AllOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all account orders; active, canceled, or filled..
    /// <list type="bullet">
    ///   <item><description>If <c>orderId</c> is set, it will get orders &gt;= that <c>orderId</c>. Otherwise most recent orders are returned.</description></item>
    ///   <item><description>For some historical orders <c>cummulativeQuoteQty</c> will be &lt; 0, meaning the data is not available at this time.</description></item>
    ///   <item><description>If <c>startTime</c> and/or <c>endTime</c> provided, <c>orderId</c> is not required</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<OrderDetails>> AllOrdersUserData(string symbol,
        long timestamp,
        string signature,
        long? orderId,
        long? startTime,
        long? endTime,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/allOrders"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<OrderDetails>>(),
            AllOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel OCO (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderListId">Order list id</param>
    /// <param name="listClientOrderId">A unique Id for the entire orderList</param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OcoOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelOcoTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an entire Order List
    /// <para>
    /// Canceling an individual leg will cancel the entire OCO
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<OcoOrder> CancelOcoTrade(string symbol,
        long timestamp,
        string signature,
        long? orderListId,
        string? listClientOrderId,
        string? newClientOrderId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/orderList"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderListId", orderListId),
                new Param("listClientOrderId", listClientOrderId),
                new Param("newClientOrderId", newClientOrderId),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<OcoOrder>(),
            CancelOcoTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel Order (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order id</param>
    /// <param name="origClientOrderId">Order id from client</param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="cancelRestrictions"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an active order.
    /// <para>
    /// Either <c>orderId</c> or <c>origClientOrderId</c> must be sent.
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<Order> CancelOrderTrade(string symbol,
        long timestamp,
        string signature,
        long? orderId,
        string? origClientOrderId,
        string? newClientOrderId,
        CancelRestrictions? cancelRestrictions,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/order"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("origClientOrderId", origClientOrderId),
                new Param("newClientOrderId", newClientOrderId),
                new Param("cancelRestrictions", cancelRestrictions),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<Order>(),
            CancelOrderTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel all Open Orders on a Symbol (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3OpenOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelAllOpenOrdersOnASymbolTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels all active orders on a symbol.
    /// This includes OCO orders.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<ApiV3OpenOrdersResponse>> CancelAllOpenOrdersOnASymbolTrade(string symbol,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/openOrders"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3OpenOrdersResponse>>(),
            CancelAllOpenOrdersOnASymbolTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel an Existing Order and Send a New Order (Trade)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="type">Order type</param>
    /// <param name="cancelReplaceMode">- <c>STOP_ON_FAILURE</c> If the cancel request fails, the new order placement will not be attempted. - <c>ALLOW_FAILURES</c> If new order placement will be attempted even if cancel request fails.</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="cancelRestrictions"></param>
    /// <param name="timeInForce">Order time in force</param>
    /// <param name="quantity">Order quantity</param>
    /// <param name="quoteOrderQty">Quote quantity</param>
    /// <param name="price">Order price</param>
    /// <param name="cancelNewClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="cancelOrigClientOrderId">Either the cancelOrigClientOrderId or cancelOrderId must be provided. If both are provided, cancelOrderId takes precedence.</param>
    /// <param name="cancelOrderId">Either the cancelOrigClientOrderId or cancelOrderId must be provided. If both are provided, cancelOrderId takes precedence.</param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="strategyId"></param>
    /// <param name="strategyType">The value cannot be less than 1000000.</param>
    /// <param name="stopPrice">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
    /// <param name="trailingDelta">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
    /// <param name="icebergQty">Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order.</param>
    /// <param name="newOrderRespType">Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.</param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderCancelReplaceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelAnExistingOrderAndSendANewOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels an existing order and places a new order on the same symbol.
    /// <para>
    /// Filters and Order Count are evaluated before the processing of the cancellation and order placement occurs.
    /// </para>
    /// <para>
    /// A new order that was not attempted (i.e. when newOrderResult: NOT_ATTEMPTED), will still increase the order count by 1.
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<ApiV3OrderCancelReplaceResponse> CancelAnExistingOrderAndSendANewOrderTrade(string symbol,
        Side side,
        Type1 type,
        string cancelReplaceMode,
        long timestamp,
        string signature,
        CancelRestrictions? cancelRestrictions,
        TimeInForce? timeInForce,
        double? quantity,
        double? quoteOrderQty,
        double? price,
        string? cancelNewClientOrderId,
        string? cancelOrigClientOrderId,
        long? cancelOrderId,
        string? newClientOrderId,
        long? strategyId,
        long? strategyType,
        double? stopPrice,
        double? trailingDelta,
        double? icebergQty,
        NewOrderRespType? newOrderRespType,
        SelfTradePreventionMode? selfTradePreventionMode,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/order/cancelReplace"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("type", type),
                new Param("cancelReplaceMode", cancelReplaceMode),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("cancelRestrictions", cancelRestrictions),
                new Param("timeInForce", timeInForce),
                new Param("quantity", quantity),
                new Param("quoteOrderQty", quoteOrderQty),
                new Param("price", price),
                new Param("cancelNewClientOrderId", cancelNewClientOrderId),
                new Param("cancelOrigClientOrderId", cancelOrigClientOrderId),
                new Param("cancelOrderId", cancelOrderId),
                new Param("newClientOrderId", newClientOrderId),
                new Param("strategyId", strategyId),
                new Param("strategyType", strategyType),
                new Param("stopPrice", stopPrice),
                new Param("trailingDelta", trailingDelta),
                new Param("icebergQty", icebergQty),
                new Param("newOrderRespType", newOrderRespType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderCancelReplaceResponse>(),
            CancelAnExistingOrderAndSendANewOrderTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Current Open Orders (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="OrderDetails"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CurrentOpenOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all open orders on a symbol. Careful when accessing this with no symbol.
    /// <para>
    /// Weight(IP):
    /// - <c>6</c> for a single symbol;
    /// - <c>80</c> when the symbol parameter is omitted;
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<OrderDetails>> CurrentOpenOrdersUserData(long timestamp,
        string signature,
        string? symbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/openOrders"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("symbol", symbol),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<OrderDetails>>(),
            CurrentOpenOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// New Order (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="type">Order type</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="timeInForce">Order time in force</param>
    /// <param name="quantity">Order quantity</param>
    /// <param name="quoteOrderQty">Quote quantity</param>
    /// <param name="price">Order price</param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="strategyId"></param>
    /// <param name="strategyType">The value cannot be less than 1000000.</param>
    /// <param name="stopPrice">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
    /// <param name="trailingDelta">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
    /// <param name="icebergQty">Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order.</param>
    /// <param name="newOrderRespType">Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.</param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="NewOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Send in a new order.
    /// <list type="bullet">
    ///   <item><description><c>LIMIT_MAKER</c> are <c>LIMIT</c> orders that will be rejected if they would immediately match and trade as a taker.</description></item>
    ///   <item><description><c>STOP_LOSS</c> and <c>TAKE_PROFIT</c> will execute a <c>MARKET</c> order when the <c>stopPrice</c> is reached.</description></item>
    ///   <item><description>Any <c>LIMIT</c> or <c>LIMIT_MAKER</c> type order can be made an iceberg order by sending an <c>icebergQty</c>.</description></item>
    ///   <item><description>Any order with an <c>icebergQty</c> MUST have <c>timeInForce</c> set to <c>GTC</c>.</description></item>
    ///   <item><description><c>MARKET</c> orders using <c>quantity</c> specifies how much a user wants to buy or sell based on the market price.</description></item>
    ///   <item><description><c>MARKET</c> orders using <c>quoteOrderQty</c> specifies the amount the user wants to spend (when buying) or receive (when selling) of the quote asset; the correct quantity will be determined based on the market liquidity and <c>quoteOrderQty</c>.</description></item>
    ///   <item><description><c>MARKET</c> orders using <c>quoteOrderQty</c> will not break <c>LOT_SIZE</c> filter rules; the order will execute a quantity that will have the notional value as close as possible to <c>quoteOrderQty</c>.</description></item>
    ///   <item><description>same <c>newClientOrderId</c> can be accepted only when the previous one is filled, otherwise the order will be rejected.</description></item>
    /// </list>
    /// <para>
    /// Trigger order price rules against market price for both <c>MARKET</c> and <c>LIMIT</c> versions:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Price above market price: <c>STOP_LOSS</c> <c>BUY</c>, <c>TAKE_PROFIT</c> <c>SELL</c></description></item>
    ///   <item><description>Price below market price: <c>STOP_LOSS</c> <c>SELL</c>, <c>TAKE_PROFIT</c> <c>BUY</c></description></item>
    /// </list>
    /// <para>
    ///
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<ApiV3OrderResponse> NewOrderTrade(string symbol,
        Side side,
        Type1 type,
        long timestamp,
        string signature,
        TimeInForce? timeInForce,
        double? quantity,
        double? quoteOrderQty,
        double? price,
        string? newClientOrderId,
        long? strategyId,
        long? strategyType,
        double? stopPrice,
        double? trailingDelta,
        double? icebergQty,
        NewOrderRespType? newOrderRespType,
        SelfTradePreventionMode? selfTradePreventionMode,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/order"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("timeInForce", timeInForce),
                new Param("quantity", quantity),
                new Param("quoteOrderQty", quoteOrderQty),
                new Param("price", price),
                new Param("newClientOrderId", newClientOrderId),
                new Param("strategyId", strategyId),
                new Param("strategyType", strategyType),
                new Param("stopPrice", stopPrice),
                new Param("trailingDelta", trailingDelta),
                new Param("icebergQty", icebergQty),
                new Param("newOrderRespType", newOrderRespType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderResponse>(),
            NewOrderTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// New Order List - OTO (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="workingType">Supported values: LIMIT,LIMIT_MAKER</param>
    /// <param name="workingSide">BUY,SELL</param>
    /// <param name="workingPrice"></param>
    /// <param name="workingQuantity">Sets the quantity for the working order.</param>
    /// <param name="workingIcebergQty">This can only be used if workingTimeInForce is GTC.</param>
    /// <param name="pendingType">Supported values: Order Types Note that MARKET orders using quoteOrderQty are not supported.</param>
    /// <param name="pendingSide">BUY,SELL</param>
    /// <param name="pendingQuantity">Sets the quantity for the pending order.</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="listClientOrderId">Arbitrary unique ID among open order lists. Automatically generated if not sent. A new order list with the same <c>listClientOrderId</c> is accepted only when the previous one is filled or completely expired. <c>listClientOrderId</c> is distinct from the <c>workingClientOrderId</c> and the <c>pendingClientOrderId</c>.</param>
    /// <param name="newOrderRespType">Set the response JSON.</param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="workingClientOrderId">Arbitrary unique ID among open orders for the working order. Automatically generated if not sent.</param>
    /// <param name="workingTimeInForce">GTC, IOC, FOK</param>
    /// <param name="workingStrategyId">Arbitrary numeric value identifying the working order within an order strategy.</param>
    /// <param name="workingStrategyType">Arbitrary numeric value identifying the working order strategy. Values smaller than 1000000 are reserved and cannot be used.</param>
    /// <param name="pendingClientOrderId">Arbitrary unique ID among open orders for the pending order. Automatically generated if not sent.</param>
    /// <param name="pendingPrice"></param>
    /// <param name="pendingStopPrice"></param>
    /// <param name="pendingTrailingDelta"></param>
    /// <param name="pendingIcebergQty">This can only be used if pendingTimeInForce is GTC.</param>
    /// <param name="pendingTimeInForce">GTC, IOC, FOK</param>
    /// <param name="pendingStrategyId">Arbitrary numeric value identifying the pending order within an order strategy.</param>
    /// <param name="pendingStrategyType">Arbitrary numeric value identifying the pending order strategy. Values smaller than 1000000 are reserved and cannot be used.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderListOtoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="NewOrderListOtoTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Places an <c>OTO</c>.
    /// - An <c>OTO</c> (One-Triggers-the-Other) is an order list comprised of 2 orders.
    /// - The first order is called the working order and must be <c>LIMIT</c> or <c>LIMIT_MAKER</c>. Initially, only the working order goes on the order book.
    /// - The second order is called the pending order. It can be any order type except for <c>MARKET</c> orders using parameter <c>quoteOrderQty</c>. The pending order is only placed on the order book when the working order gets fully filled.
    /// - If either the working order or the pending order is cancelled individually, the other order in the order list will also be canceled or expired.
    /// - When the order list is placed, if the working order gets immediately fully filled, the placement response will show the working order as <c>FILLED</c> but the pending order will still appear as <c>PENDING_NEW</c>. You need to query the status of the pending order again to see its updated status.
    /// - OTOs add 2 orders to the unfilled order count, <c>EXCHANGE_MAX_NUM_ORDERS</c> filter and <c>MAX_NUM_ORDERS</c> filter.
    /// <para>
    /// Weight: 1
    /// </para>
    /// </remarks>
    public Task<ApiV3OrderListOtoResponse> NewOrderListOtoTrade(string symbol,
        WorkingType workingType,
        WorkingSide workingSide,
        double workingPrice,
        double workingQuantity,
        double workingIcebergQty,
        PendingType pendingType,
        PendingSide pendingSide,
        double pendingQuantity,
        long timestamp,
        string signature,
        string? listClientOrderId,
        NewOrderRespType? newOrderRespType,
        SelfTradePreventionMode? selfTradePreventionMode,
        string? workingClientOrderId,
        WorkingTimeInForce? workingTimeInForce,
        double? workingStrategyId,
        long? workingStrategyType,
        string? pendingClientOrderId,
        double? pendingPrice,
        double? pendingStopPrice,
        double? pendingTrailingDelta,
        double? pendingIcebergQty,
        PendingTimeInForce? pendingTimeInForce,
        double? pendingStrategyId,
        long? pendingStrategyType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/orderList/oto"),
            [],
            [new Param("symbol", symbol),
                new Param("workingType", workingType),
                new Param("workingSide", workingSide),
                new Param("workingPrice", workingPrice),
                new Param("workingQuantity", workingQuantity),
                new Param("workingIcebergQty", workingIcebergQty),
                new Param("pendingType", pendingType),
                new Param("pendingSide", pendingSide),
                new Param("pendingQuantity", pendingQuantity),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("listClientOrderId", listClientOrderId),
                new Param("newOrderRespType", newOrderRespType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("workingClientOrderId", workingClientOrderId),
                new Param("workingTimeInForce", workingTimeInForce),
                new Param("workingStrategyId", workingStrategyId),
                new Param("workingStrategyType", workingStrategyType),
                new Param("pendingClientOrderId", pendingClientOrderId),
                new Param("pendingPrice", pendingPrice),
                new Param("pendingStopPrice", pendingStopPrice),
                new Param("pendingTrailingDelta", pendingTrailingDelta),
                new Param("pendingIcebergQty", pendingIcebergQty),
                new Param("pendingTimeInForce", pendingTimeInForce),
                new Param("pendingStrategyId", pendingStrategyId),
                new Param("pendingStrategyType", pendingStrategyType)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderListOtoResponse>(),
            NewOrderListOtoTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// New Order List - OTOCO (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="workingType">Supported values: LIMIT,LIMIT_MAKER</param>
    /// <param name="workingSide">BUY,SELL</param>
    /// <param name="workingPrice"></param>
    /// <param name="workingQuantity">Sets the quantity for the working order.</param>
    /// <param name="workingIcebergQty">This can only be used if workingTimeInForce is GTC.</param>
    /// <param name="pendingSide">BUY,SELL</param>
    /// <param name="pendingQuantity">Sets the quantity for the pending order.</param>
    /// <param name="pendingAboveType">Supported values: LIMIT_MAKER, STOP_LOSS, and STOP_LOSS_LIMIT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="listClientOrderId">Arbitrary unique ID among open order lists. Automatically generated if not sent. A new order list with the same <c>listClientOrderId</c> is accepted only when the previous one is filled or completely expired. <c>listClientOrderId</c> is distinct from the <c>workingClientOrderId</c> and the <c>pendingClientOrderId</c>.</param>
    /// <param name="newOrderRespType">Set the response JSON.</param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="workingClientOrderId">Arbitrary unique ID among open orders for the working order. Automatically generated if not sent.</param>
    /// <param name="workingTimeInForce">GTC, IOC, FOK</param>
    /// <param name="workingStrategyId">Arbitrary numeric value identifying the working order within an order strategy.</param>
    /// <param name="workingStrategyType">Arbitrary numeric value identifying the working order strategy. Values smaller than 1000000 are reserved and cannot be used.</param>
    /// <param name="pendingAboveClientOrderId">Arbitrary unique ID among open orders for the pending above order. Automatically generated if not sent.</param>
    /// <param name="pendingAbovePrice"></param>
    /// <param name="pendingAboveStopPrice"></param>
    /// <param name="pendingAboveTrailingDelta"></param>
    /// <param name="pendingAboveIcebergQty">This can only be used if pendingAboveTimeInForce is GTC.</param>
    /// <param name="pendingAboveTimeInForce"></param>
    /// <param name="pendingAboveStrategyId">Arbitrary numeric value identifying the pending above order within an order strategy.</param>
    /// <param name="pendingAboveStrategyType">Arbitrary numeric value identifying the pending above order strategy. Values smaller than 1000000 are reserved and cannot be used.</param>
    /// <param name="pendingBelowType">Supported values: LIMIT_MAKER, STOP_LOSS, and STOP_LOSS_LIMIT</param>
    /// <param name="pendingBelowClientOrderId">Arbitrary unique ID among open orders for the pending below order. Automatically generated if not sent.</param>
    /// <param name="pendingBelowPrice"></param>
    /// <param name="pendingBelowStopPrice"></param>
    /// <param name="pendingBelowTrailingDelta"></param>
    /// <param name="pendingBelowIcebergQty">This can only be used if pendingBelowTimeInForce is GTC.</param>
    /// <param name="pendingBelowTimeInForce"></param>
    /// <param name="pendingBelowStrategyId">Arbitrary numeric value identifying the pending below order within an order strategy.</param>
    /// <param name="pendingBelowStrategyType">Arbitrary numeric value identifying the pending below order strategy. Values smaller than 1000000 are reserved and cannot be used.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderListOtocoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="NewOrderListOtocoTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Place an <c>OTOCO</c>.
    /// - An <c>OTOCO</c> (One-Triggers-One-Cancels-the-Other) is an order list comprised of 3 orders.
    /// - The first order is called the working order and must be <c>LIMIT</c> or <c>LIMIT_MAKER</c>. Initially, only the working order goes on the order book.
    ///   - The behavior of the working order is the same as the <c>OTO</c>.
    /// - <c>OTOCO</c> has 2 pending orders (pending above and pending below), forming an <c>OCO</c> pair. The pending orders are only placed on the order book when the working order gets fully filled.
    ///   - The rules of the pending above and pending below follow the same rules as the Order List <c>OCO</c>.
    /// - OTOCOs add 3 orders against the unfilled order count, <c>EXCHANGE_MAX_NUM_ORDERS</c> filter, and <c>MAX_NUM_ORDERS</c> filter.
    /// <para>
    /// Weight: 1
    /// </para>
    /// </remarks>
    public Task<ApiV3OrderListOtocoResponse> NewOrderListOtocoTrade(string symbol,
        WorkingType workingType,
        WorkingSide workingSide,
        double workingPrice,
        double workingQuantity,
        double workingIcebergQty,
        PendingSide pendingSide,
        double pendingQuantity,
        PendingAboveType pendingAboveType,
        long timestamp,
        string signature,
        string? listClientOrderId,
        NewOrderRespType? newOrderRespType,
        SelfTradePreventionMode? selfTradePreventionMode,
        string? workingClientOrderId,
        WorkingTimeInForce? workingTimeInForce,
        double? workingStrategyId,
        long? workingStrategyType,
        string? pendingAboveClientOrderId,
        double? pendingAbovePrice,
        double? pendingAboveStopPrice,
        double? pendingAboveTrailingDelta,
        double? pendingAboveIcebergQty,
        PendingAboveTimeInForce? pendingAboveTimeInForce,
        double? pendingAboveStrategyId,
        long? pendingAboveStrategyType,
        PendingBelowType? pendingBelowType,
        string? pendingBelowClientOrderId,
        double? pendingBelowPrice,
        double? pendingBelowStopPrice,
        double? pendingBelowTrailingDelta,
        double? pendingBelowIcebergQty,
        PendingBelowTimeInForce? pendingBelowTimeInForce,
        double? pendingBelowStrategyId,
        long? pendingBelowStrategyType,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/orderList/otoco"),
            [],
            [new Param("symbol", symbol),
                new Param("workingType", workingType),
                new Param("workingSide", workingSide),
                new Param("workingPrice", workingPrice),
                new Param("workingQuantity", workingQuantity),
                new Param("workingIcebergQty", workingIcebergQty),
                new Param("pendingSide", pendingSide),
                new Param("pendingQuantity", pendingQuantity),
                new Param("pendingAboveType", pendingAboveType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("listClientOrderId", listClientOrderId),
                new Param("newOrderRespType", newOrderRespType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("workingClientOrderId", workingClientOrderId),
                new Param("workingTimeInForce", workingTimeInForce),
                new Param("workingStrategyId", workingStrategyId),
                new Param("workingStrategyType", workingStrategyType),
                new Param("pendingAboveClientOrderId", pendingAboveClientOrderId),
                new Param("pendingAbovePrice", pendingAbovePrice),
                new Param("pendingAboveStopPrice", pendingAboveStopPrice),
                new Param("pendingAboveTrailingDelta", pendingAboveTrailingDelta),
                new Param("pendingAboveIcebergQty", pendingAboveIcebergQty),
                new Param("pendingAboveTimeInForce", pendingAboveTimeInForce),
                new Param("pendingAboveStrategyId", pendingAboveStrategyId),
                new Param("pendingAboveStrategyType", pendingAboveStrategyType),
                new Param("pendingBelowType", pendingBelowType),
                new Param("pendingBelowClientOrderId", pendingBelowClientOrderId),
                new Param("pendingBelowPrice", pendingBelowPrice),
                new Param("pendingBelowStopPrice", pendingBelowStopPrice),
                new Param("pendingBelowTrailingDelta", pendingBelowTrailingDelta),
                new Param("pendingBelowIcebergQty", pendingBelowIcebergQty),
                new Param("pendingBelowTimeInForce", pendingBelowTimeInForce),
                new Param("pendingBelowStrategyId", pendingBelowStrategyId),
                new Param("pendingBelowStrategyType", pendingBelowStrategyType),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderListOtocoResponse>(),
            NewOrderListOtocoTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// New Order list - OCO (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="quantity"></param>
    /// <param name="aboveType">Supported values : <c>STOP_LOSS_LIMIT</c>, <c>STOP_LOSS</c>, <c>LIMIT_MAKER</c></param>
    /// <param name="belowType">Supported values : <c>STOP_LOSS_LIMIT</c>, <c>STOP_LOSS</c>, <c>LIMIT_MAKER</c></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="listClientOrderId">Arbitrary unique ID among open order lists. Automatically generated if not sent. A new order list with the same <c>listClientOrderId</c> is accepted only when the previous one is filled or completely expired. <c>listClientOrderId</c> is distinct from the <c>aboveClientOrderId</c> and the <c>belowCLientOrderId</c>.</param>
    /// <param name="aboveClientOrderId">Arbitrary unique ID among open orders for the above order. Automatically generated if not sent</param>
    /// <param name="aboveIcebergQty">Note that this can only be used if <c>aboveTimeInForce</c> is <c>GTC</c>.</param>
    /// <param name="abovePrice"></param>
    /// <param name="aboveStopPrice">Can be used if <c>aboveType</c> is <c>STOP_LOSS</c> or <c>STOP_LOSS_LIMIT</c>. Either <c>aboveStopPrice</c> or <c>aboveTrailingDelta</c> or both, must be specified.</param>
    /// <param name="aboveTrailingDelta"></param>
    /// <param name="aboveTimeInForce">Required if the <c>aboveType</c> is <c>STOP_LOSS_LIMIT</c>.</param>
    /// <param name="aboveStrategyId">Arbitrary numeric value identifying the above order within an order strategy.</param>
    /// <param name="aboveStrategyType">Arbitrary numeric value identifying the above order strategy. Values smaller than 1000000 are reserved and cannot be used.</param>
    /// <param name="belowClientOrderId">Arbitrary unique ID among open orders for the below order. Automatically generated if not sent</param>
    /// <param name="belowIcebergQty">Note that this can only be used if <c>belowTimeInForce</c> is <c>GTC</c>.</param>
    /// <param name="belowPrice">Can be used if <c>belowType</c> is <c>STOP_LOSS_LIMIT</c> or <c>LIMIT_MAKER</c> to specify the limit price.</param>
    /// <param name="belowStopPrice">Can be used if <c>belowType</c> is <c>STOP_LOSS</c> or <c>STOP_LOSS_LIMIT</c>. Either <c>belowStopPrice</c> or <c>belowTrailingDelta</c> or both, must be specified.</param>
    /// <param name="belowTrailingDelta"></param>
    /// <param name="belowTimeInForce">Required if the <c>belowType</c> is <c>STOP_LOSS_LIMIT</c>.</param>
    /// <param name="belowStrategyId">Arbitrary numeric value identifying the below order within an order strategy.</param>
    /// <param name="belowStrategyType">Arbitrary numeric value identifying the below order strategy. Values smaller than 1000000 are reserved and cannot be used.</param>
    /// <param name="newOrderRespType">Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.</param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderListOcoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="NewOrderListOcoTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Send in an one-cancels-the-other (OCO) pair, where activation of one order immediately cancels the other.
    /// <list type="bullet">
    ///   <item><description>An <c>OCO</c> has 2 orders called the above order and below order.</description></item>
    ///   <item><description>One of the orders must be a <c>LIMIT_MAKER</c> order and the other must be <c>STOP_LOSS</c> or<c>STOP_LOSS_LIMIT</c> order.</description></item>
    ///   <item><description>Price restrictions:
    ///     <list type="bullet">
    ///       <item><description>If the <c>OCO</c> is on the <c>SELL</c> side: <c>LIMIT_MAKER</c> price &gt; Last Traded Price &gt; stopPrice</description></item>
    ///       <item><description>If the <c>OCO</c> is on the <c>BUY</c> side: <c>LIMIT_MAKER</c> price &lt; Last Traded Price &lt; stopPrice</description></item>
    ///     </list>
    ///   </description></item>
    ///   <item><description>OCOs add 2 orders to the unfilled order count, <c>EXCHANGE_MAX_ORDERS</c> filter, and the <c>MAX_NUM_ORDERS</c> filter.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<ApiV3OrderListOcoResponse> NewOrderListOcoTrade(string symbol,
        Side side,
        double quantity,
        string aboveType,
        string belowType,
        long timestamp,
        string signature,
        string? listClientOrderId,
        string? aboveClientOrderId,
        double? aboveIcebergQty,
        double? abovePrice,
        double? aboveStopPrice,
        double? aboveTrailingDelta,
        AboveTimeInForce? aboveTimeInForce,
        double? aboveStrategyId,
        long? aboveStrategyType,
        string? belowClientOrderId,
        double? belowIcebergQty,
        double? belowPrice,
        double? belowStopPrice,
        double? belowTrailingDelta,
        BelowTimeInForce? belowTimeInForce,
        double? belowStrategyId,
        long? belowStrategyType,
        NewOrderRespType? newOrderRespType,
        SelfTradePreventionMode? selfTradePreventionMode,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/orderList/oco"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("quantity", quantity),
                new Param("aboveType", aboveType),
                new Param("belowType", belowType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("listClientOrderId", listClientOrderId),
                new Param("aboveClientOrderId", aboveClientOrderId),
                new Param("aboveIcebergQty", aboveIcebergQty),
                new Param("abovePrice", abovePrice),
                new Param("aboveStopPrice", aboveStopPrice),
                new Param("aboveTrailingDelta", aboveTrailingDelta),
                new Param("aboveTimeInForce", aboveTimeInForce),
                new Param("aboveStrategyId", aboveStrategyId),
                new Param("aboveStrategyType", aboveStrategyType),
                new Param("belowClientOrderId", belowClientOrderId),
                new Param("belowIcebergQty", belowIcebergQty),
                new Param("belowPrice", belowPrice),
                new Param("belowStopPrice", belowStopPrice),
                new Param("belowTrailingDelta", belowTrailingDelta),
                new Param("belowTimeInForce", belowTimeInForce),
                new Param("belowStrategyId", belowStrategyId),
                new Param("belowStrategyType", belowStrategyType),
                new Param("newOrderRespType", newOrderRespType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderListOcoResponse>(),
            NewOrderListOcoTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// New order using SOR (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="type">Order type</param>
    /// <param name="quantity"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="timeInForce">Order time in force</param>
    /// <param name="price"></param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="strategyId"></param>
    /// <param name="strategyType">The value cannot be less than 1000000.</param>
    /// <param name="icebergQty">Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order.</param>
    /// <param name="newOrderRespType">Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.</param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3SorOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="NewOrderUsingSorTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 6
    /// </remarks>
    public Task<ApiV3SorOrderResponse> NewOrderUsingSorTrade(string symbol,
        Side side,
        Type1 type,
        double quantity,
        long timestamp,
        string signature,
        TimeInForce? timeInForce,
        double? price,
        string? newClientOrderId,
        long? strategyId,
        long? strategyType,
        double? icebergQty,
        NewOrderRespType? newOrderRespType,
        SelfTradePreventionMode? selfTradePreventionMode,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/sor/order"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("type", type),
                new Param("quantity", quantity),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("timeInForce", timeInForce),
                new Param("price", price),
                new Param("newClientOrderId", newClientOrderId),
                new Param("strategyId", strategyId),
                new Param("strategyType", strategyType),
                new Param("icebergQty", icebergQty),
                new Param("newOrderRespType", newOrderRespType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3SorOrderResponse>(),
            NewOrderUsingSorTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Allocations (USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="fromAllocationId"></param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="orderId">Order id</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3MyAllocationsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryAllocationsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves allocations resulting from SOR order placement.
    /// <para>
    /// Weight: 20
    /// </para>
    /// <para>
    /// Supported parameter combinations:
    /// Parameters                               Response
    /// symbol                                   allocations from oldest to newest
    /// symbol + startTime                       oldest allocations since startTime
    /// symbol + endTime                         newest allocations until endTime
    /// symbol + startTime + endTime             allocations within the time range
    /// symbol + fromAllocationId               allocations by allocation ID
    /// symbol + orderId                         allocations related to an order starting with oldest
    /// symbol + orderId + fromAllocationId     allocations related to an order by allocation ID
    /// </para>
    /// <para>
    /// Note: The time between startTime and endTime can't be longer than 24 hours.
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<ApiV3MyAllocationsResponse>> QueryAllocationsUserData(string symbol,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        long? fromAllocationId,
        int? limit,
        long? orderId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/myAllocations"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("fromAllocationId", fromAllocationId),
                new Param("limit", limit),
                new Param("orderId", orderId),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3MyAllocationsResponse>>(),
            QueryAllocationsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Commission Rates (USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3AccountCommissionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryCommissionRatesUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get current account commission rates.
    /// <para>
    /// Weight: 20
    /// </para>
    /// </remarks>
    public Task<ApiV3AccountCommissionResponse> QueryCommissionRatesUserData(string symbol,
        long timestamp,
        string signature,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/account/commission"),
            [],
            [new Param("symbol", symbol), new Param("timestamp", timestamp), new Param("signature", signature)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3AccountCommissionResponse>(),
            QueryCommissionRatesUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Current Order Count Usage (TRADE)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3RateLimitOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryCurrentOrderCountUsageTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Displays the user's current order count usage for all intervals.
    /// <para>
    /// Weight(IP): 40
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<ApiV3RateLimitOrderResponse>> QueryCurrentOrderCountUsageTrade(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/rateLimit/order"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3RateLimitOrderResponse>>(),
            QueryCurrentOrderCountUsageTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query OCO (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderListId">Order list id</param>
    /// <param name="origClientOrderId">Order id from client</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific OCO based on provided optional parameters
    /// <para>
    /// Weight(IP): 4
    /// </para>
    /// </remarks>
    public Task<ApiV3OrderListResponse> QueryOcoUserData(long timestamp,
        string signature,
        long? orderListId,
        string? origClientOrderId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/orderList"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderListId", orderListId),
                new Param("origClientOrderId", origClientOrderId),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderListResponse>(),
            QueryOcoUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Open OCO (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3OpenOrderListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryOpenOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 6
    /// </remarks>
    public Task<IReadOnlyList<ApiV3OpenOrderListResponse>> QueryOpenOcoUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/openOrderList"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3OpenOrderListResponse>>(),
            QueryOpenOcoUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Order (USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order id</param>
    /// <param name="origClientOrderId">Order id from client</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrderDetails"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryOrderUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Check an order's status.
    /// <list type="bullet">
    ///   <item><description>Either <c>orderId</c> or <c>origClientOrderId</c> must be sent.</description></item>
    ///   <item><description>For some historical orders <c>cummulativeQuoteQty</c> will be &lt; 0, meaning the data is not available at this time.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 4
    /// </para>
    /// </remarks>
    public Task<OrderDetails> QueryOrderUserData(string symbol,
        long timestamp,
        string signature,
        long? orderId,
        string? origClientOrderId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/order"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("origClientOrderId", origClientOrderId),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OrderDetails>(),
            QueryOrderUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Prevented Matches
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="preventedMatchId"></param>
    /// <param name="orderId">Order id</param>
    /// <param name="fromPreventedMatchId"></param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3MyPreventedMatchesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryPreventedMatchesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Displays the list of orders that were expired because of STP.
    /// <para>
    /// For additional information on what a Prevented match is, as well as Self Trade Prevention (STP), please refer to our STP FAQ page.
    /// </para>
    /// <para>
    /// These are the combinations supported:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>symbol + preventedMatchId</description></item>
    ///   <item><description>symbol + orderId</description></item>
    ///   <item><description>symbol + orderId + fromPreventedMatchId (limit will default to 500)</description></item>
    ///   <item><description>symbol + orderId + fromPreventedMatchId + limit</description></item>
    /// </list>
    /// <para>
    /// Weight(IP):
    /// </para>
    /// <para>
    /// Case                               Weight
    /// If symbol is invalid:             2
    /// Querying by preventedMatchId:     2
    /// Querying by orderId:               20
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<ApiV3MyPreventedMatchesResponse>> QueryPreventedMatches(string symbol,
        long timestamp,
        string signature,
        long? preventedMatchId,
        long? orderId,
        long? fromPreventedMatchId,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/myPreventedMatches"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("preventedMatchId", preventedMatchId),
                new Param("orderId", orderId),
                new Param("fromPreventedMatchId", fromPreventedMatchId),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3MyPreventedMatchesResponse>>(),
            QueryPreventedMatchesErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query all OCO (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="fromId">Trade id to fetch from. Default gets most recent trades.</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3AllOrderListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryAllOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves all OCO based on provided optional parameters
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<ApiV3AllOrderListResponse>> QueryAllOcoUserData(long timestamp,
        string signature,
        long? fromId,
        long? startTime,
        long? endTime,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/allOrderList"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("fromId", fromId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3AllOrderListResponse>>(),
            QueryAllOcoUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Test New Order (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="type">Order type</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="timeInForce">Order time in force</param>
    /// <param name="quantity">Order quantity</param>
    /// <param name="quoteOrderQty">Quote quantity</param>
    /// <param name="price">Order price</param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="strategyId"></param>
    /// <param name="strategyType">The value cannot be less than 1000000.</param>
    /// <param name="stopPrice">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
    /// <param name="trailingDelta">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
    /// <param name="icebergQty">Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order.</param>
    /// <param name="newOrderRespType">Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="computeCommissionRates">Default: false</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TestNewOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Test new order creation and signature/recvWindow long.
    /// Creates and validates a new order but does not send it into the matching engine.
    /// <para>
    /// Weight(IP):
    ///   - Without computeCommissionRates: <c>1</c>
    ///   - With computeCommissionRates: <c>20</c>
    /// </para>
    /// </remarks>
    public Task<object> TestNewOrderTrade(string symbol,
        Side side,
        Type1 type,
        long timestamp,
        string signature,
        TimeInForce? timeInForce,
        double? quantity,
        double? quoteOrderQty,
        double? price,
        string? newClientOrderId,
        long? strategyId,
        long? strategyType,
        double? stopPrice,
        double? trailingDelta,
        double? icebergQty,
        NewOrderRespType? newOrderRespType,
        long? recvWindow,
        bool? computeCommissionRates,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/order/test"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("timeInForce", timeInForce),
                new Param("quantity", quantity),
                new Param("quoteOrderQty", quoteOrderQty),
                new Param("price", price),
                new Param("newClientOrderId", newClientOrderId),
                new Param("strategyId", strategyId),
                new Param("strategyType", strategyType),
                new Param("stopPrice", stopPrice),
                new Param("trailingDelta", trailingDelta),
                new Param("icebergQty", icebergQty),
                new Param("newOrderRespType", newOrderRespType),
                new Param("recvWindow", recvWindow),
                new Param("computeCommissionRates", computeCommissionRates)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            TestNewOrderTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Test new order using SOR (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="type">Order type</param>
    /// <param name="quantity"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="timeInForce">Order time in force</param>
    /// <param name="price"></param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="strategyId"></param>
    /// <param name="strategyType">The value cannot be less than 1000000.</param>
    /// <param name="icebergQty">Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order.</param>
    /// <param name="newOrderRespType">Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.</param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="computeCommissionRates">Default: false</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TestNewOrderUsingSorTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Test new order creation and signature/recvWindow using smart order routing (SOR).
    /// Creates and validates a new order but does not send it into the matching engine.
    /// <para>
    /// Weight(IP):
    ///   - Without computeCommissionRates: <c>1</c>
    ///   - With computeCommissionRates: <c>20</c>
    /// </para>
    /// </remarks>
    public Task<object> TestNewOrderUsingSorTrade(string symbol,
        Side side,
        Type1 type,
        double quantity,
        long timestamp,
        string signature,
        TimeInForce? timeInForce,
        double? price,
        string? newClientOrderId,
        long? strategyId,
        long? strategyType,
        double? icebergQty,
        NewOrderRespType? newOrderRespType,
        SelfTradePreventionMode? selfTradePreventionMode,
        bool? computeCommissionRates,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/sor/order/test"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("type", type),
                new Param("quantity", quantity),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("timeInForce", timeInForce),
                new Param("price", price),
                new Param("newClientOrderId", newClientOrderId),
                new Param("strategyId", strategyId),
                new Param("strategyType", strategyType),
                new Param("icebergQty", icebergQty),
                new Param("newOrderRespType", newOrderRespType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("computeCommissionRates", computeCommissionRates),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            TestNewOrderUsingSorTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
