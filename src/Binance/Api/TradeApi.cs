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
using Binance.Requests.TradeApi;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Account"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountInformationUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get current account information.
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<Account> AccountInformationUserData(AccountInformationUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/account"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Account>(),
            AccountInformationUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Account Trade List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="MyTrade"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountTradeListUserDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<MyTrade>> AccountTradeListUserData(AccountTradeListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/myTrades"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("fromId", request.FromId),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<MyTrade>>(),
            AccountTradeListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// All Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="OrderDetails"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AllOrdersUserDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<OrderDetails>> AllOrdersUserData(AllOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/allOrders"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<OrderDetails>>(),
            AllOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel OCO (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OcoOrder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelOcoTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an entire Order List
    /// <para>
    /// Canceling an individual leg will cancel the entire OCO
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<OcoOrder> CancelOcoTrade(CancelOcoTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/orderList"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderListId", request.OrderListId),
                new Param("listClientOrderId", request.ListClientOrderId),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<OcoOrder>(),
            CancelOcoTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel Order (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an active order.
    /// <para>
    /// Either <c>orderId</c> or <c>origClientOrderId</c> must be sent.
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<Order> CancelOrderTrade(CancelOrderTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/order"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("origClientOrderId", request.OrigClientOrderId),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("cancelRestrictions", request.CancelRestrictions),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<Order>(),
            CancelOrderTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel all Open Orders on a Symbol (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3OpenOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelAllOpenOrdersOnASymbolTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels all active orders on a symbol.
    /// This includes OCO orders.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<ApiV3OpenOrdersResponse>> CancelAllOpenOrdersOnASymbolTrade(CancelAllOpenOrdersOnASymbolTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/openOrders"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3OpenOrdersResponse>>(),
            CancelAllOpenOrdersOnASymbolTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel an Existing Order and Send a New Order (Trade)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderCancelReplaceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelAnExistingOrderAndSendANewOrderTradeError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3OrderCancelReplaceResponse> CancelAnExistingOrderAndSendANewOrderTrade(CancelAnExistingOrderAndSendANewOrderTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/order/cancelReplace"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("type", request.Type),
                new Param("cancelReplaceMode", request.CancelReplaceMode),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("cancelRestrictions", request.CancelRestrictions),
                new Param("timeInForce", request.TimeInForce),
                new Param("quantity", request.Quantity),
                new Param("quoteOrderQty", request.QuoteOrderQty),
                new Param("price", request.Price),
                new Param("cancelNewClientOrderId", request.CancelNewClientOrderId),
                new Param("cancelOrigClientOrderId", request.CancelOrigClientOrderId),
                new Param("cancelOrderId", request.CancelOrderId),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("strategyId", request.StrategyId),
                new Param("strategyType", request.StrategyType),
                new Param("stopPrice", request.StopPrice),
                new Param("trailingDelta", request.TrailingDelta),
                new Param("icebergQty", request.IcebergQty),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderCancelReplaceResponse>(),
            CancelAnExistingOrderAndSendANewOrderTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Current Open Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="OrderDetails"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CurrentOpenOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all open orders on a symbol. Careful when accessing this with no symbol.
    /// <para>
    /// Weight(IP):
    /// - <c>6</c> for a single symbol;
    /// - <c>80</c> when the symbol parameter is omitted;
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<OrderDetails>> CurrentOpenOrdersUserData(CurrentOpenOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/openOrders"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("symbol", request.Symbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<OrderDetails>>(),
            CurrentOpenOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// New Order (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="NewOrderTradeError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3OrderResponse> NewOrderTrade(NewOrderTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/order"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("timeInForce", request.TimeInForce),
                new Param("quantity", request.Quantity),
                new Param("quoteOrderQty", request.QuoteOrderQty),
                new Param("price", request.Price),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("strategyId", request.StrategyId),
                new Param("strategyType", request.StrategyType),
                new Param("stopPrice", request.StopPrice),
                new Param("trailingDelta", request.TrailingDelta),
                new Param("icebergQty", request.IcebergQty),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderResponse>(),
            NewOrderTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// New Order List - OTO (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderListOtoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="NewOrderListOtoTradeError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3OrderListOtoResponse> NewOrderListOtoTrade(NewOrderListOtoTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/orderList/oto"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("workingType", request.WorkingType),
                new Param("workingSide", request.WorkingSide),
                new Param("workingPrice", request.WorkingPrice),
                new Param("workingQuantity", request.WorkingQuantity),
                new Param("workingIcebergQty", request.WorkingIcebergQty),
                new Param("pendingType", request.PendingType),
                new Param("pendingSide", request.PendingSide),
                new Param("pendingQuantity", request.PendingQuantity),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("listClientOrderId", request.ListClientOrderId),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("workingClientOrderId", request.WorkingClientOrderId),
                new Param("workingTimeInForce", request.WorkingTimeInForce),
                new Param("workingStrategyId", request.WorkingStrategyId),
                new Param("workingStrategyType", request.WorkingStrategyType),
                new Param("pendingClientOrderId", request.PendingClientOrderId),
                new Param("pendingPrice", request.PendingPrice),
                new Param("pendingStopPrice", request.PendingStopPrice),
                new Param("pendingTrailingDelta", request.PendingTrailingDelta),
                new Param("pendingIcebergQty", request.PendingIcebergQty),
                new Param("pendingTimeInForce", request.PendingTimeInForce),
                new Param("pendingStrategyId", request.PendingStrategyId),
                new Param("pendingStrategyType", request.PendingStrategyType),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderListOtoResponse>(),
            NewOrderListOtoTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// New Order List - OTOCO (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderListOtocoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="NewOrderListOtocoTradeError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3OrderListOtocoResponse> NewOrderListOtocoTrade(NewOrderListOtocoTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/orderList/otoco"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("workingType", request.WorkingType),
                new Param("workingSide", request.WorkingSide),
                new Param("workingPrice", request.WorkingPrice),
                new Param("workingQuantity", request.WorkingQuantity),
                new Param("workingIcebergQty", request.WorkingIcebergQty),
                new Param("pendingSide", request.PendingSide),
                new Param("pendingQuantity", request.PendingQuantity),
                new Param("pendingAboveType", request.PendingAboveType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("listClientOrderId", request.ListClientOrderId),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("workingClientOrderId", request.WorkingClientOrderId),
                new Param("workingTimeInForce", request.WorkingTimeInForce),
                new Param("workingStrategyId", request.WorkingStrategyId),
                new Param("workingStrategyType", request.WorkingStrategyType),
                new Param("pendingAboveClientOrderId", request.PendingAboveClientOrderId),
                new Param("pendingAbovePrice", request.PendingAbovePrice),
                new Param("pendingAboveStopPrice", request.PendingAboveStopPrice),
                new Param("pendingAboveTrailingDelta", request.PendingAboveTrailingDelta),
                new Param("pendingAboveIcebergQty", request.PendingAboveIcebergQty),
                new Param("pendingAboveTimeInForce", request.PendingAboveTimeInForce),
                new Param("pendingAboveStrategyId", request.PendingAboveStrategyId),
                new Param("pendingAboveStrategyType", request.PendingAboveStrategyType),
                new Param("pendingBelowType", request.PendingBelowType),
                new Param("pendingBelowClientOrderId", request.PendingBelowClientOrderId),
                new Param("pendingBelowPrice", request.PendingBelowPrice),
                new Param("pendingBelowStopPrice", request.PendingBelowStopPrice),
                new Param("pendingBelowTrailingDelta", request.PendingBelowTrailingDelta),
                new Param("pendingBelowIcebergQty", request.PendingBelowIcebergQty),
                new Param("pendingBelowTimeInForce", request.PendingBelowTimeInForce),
                new Param("pendingBelowStrategyId", request.PendingBelowStrategyId),
                new Param("pendingBelowStrategyType", request.PendingBelowStrategyType),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderListOtocoResponse>(),
            NewOrderListOtocoTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// New Order list - OCO (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderListOcoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="NewOrderListOcoTradeError"/> when the server returns an error response.</exception>
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
    public Task<ApiV3OrderListOcoResponse> NewOrderListOcoTrade(NewOrderListOcoTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/orderList/oco"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("quantity", request.Quantity),
                new Param("aboveType", request.AboveType),
                new Param("belowType", request.BelowType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("listClientOrderId", request.ListClientOrderId),
                new Param("aboveClientOrderId", request.AboveClientOrderId),
                new Param("aboveIcebergQty", request.AboveIcebergQty),
                new Param("abovePrice", request.AbovePrice),
                new Param("aboveStopPrice", request.AboveStopPrice),
                new Param("aboveTrailingDelta", request.AboveTrailingDelta),
                new Param("aboveTimeInForce", request.AboveTimeInForce),
                new Param("aboveStrategyId", request.AboveStrategyId),
                new Param("aboveStrategyType", request.AboveStrategyType),
                new Param("belowClientOrderId", request.BelowClientOrderId),
                new Param("belowIcebergQty", request.BelowIcebergQty),
                new Param("belowPrice", request.BelowPrice),
                new Param("belowStopPrice", request.BelowStopPrice),
                new Param("belowTrailingDelta", request.BelowTrailingDelta),
                new Param("belowTimeInForce", request.BelowTimeInForce),
                new Param("belowStrategyId", request.BelowStrategyId),
                new Param("belowStrategyType", request.BelowStrategyType),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderListOcoResponse>(),
            NewOrderListOcoTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// New order using SOR (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3SorOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="NewOrderUsingSorTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 6
    /// </remarks>
    public Task<ApiV3SorOrderResponse> NewOrderUsingSorTrade(NewOrderUsingSorTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/sor/order"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("type", request.Type),
                new Param("quantity", request.Quantity),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("timeInForce", request.TimeInForce),
                new Param("price", request.Price),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("strategyId", request.StrategyId),
                new Param("strategyType", request.StrategyType),
                new Param("icebergQty", request.IcebergQty),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3SorOrderResponse>(),
            NewOrderUsingSorTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Allocations (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3MyAllocationsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryAllocationsUserDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<ApiV3MyAllocationsResponse>> QueryAllocationsUserData(QueryAllocationsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/myAllocations"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("fromAllocationId", request.FromAllocationId),
                new Param("limit", request.Limit),
                new Param("orderId", request.OrderId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3MyAllocationsResponse>>(),
            QueryAllocationsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Commission Rates (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3AccountCommissionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryCommissionRatesUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get current account commission rates.
    /// <para>
    /// Weight: 20
    /// </para>
    /// </remarks>
    public Task<ApiV3AccountCommissionResponse> QueryCommissionRatesUserData(QueryCommissionRatesUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/account/commission"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3AccountCommissionResponse>(),
            QueryCommissionRatesUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Current Order Count Usage (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3RateLimitOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryCurrentOrderCountUsageTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Displays the user's current order count usage for all intervals.
    /// <para>
    /// Weight(IP): 40
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<ApiV3RateLimitOrderResponse>> QueryCurrentOrderCountUsageTrade(QueryCurrentOrderCountUsageTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/rateLimit/order"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3RateLimitOrderResponse>>(),
            QueryCurrentOrderCountUsageTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query OCO (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3OrderListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific OCO based on provided optional parameters
    /// <para>
    /// Weight(IP): 4
    /// </para>
    /// </remarks>
    public Task<ApiV3OrderListResponse> QueryOcoUserData(QueryOcoUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/orderList"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderListId", request.OrderListId),
                new Param("origClientOrderId", request.OrigClientOrderId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3OrderListResponse>(),
            QueryOcoUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Open OCO (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3OpenOrderListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryOpenOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 6
    /// </remarks>
    public Task<IReadOnlyList<ApiV3OpenOrderListResponse>> QueryOpenOcoUserData(QueryOpenOcoUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/openOrderList"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3OpenOrderListResponse>>(),
            QueryOpenOcoUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Order (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrderDetails"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryOrderUserDataError"/> when the server returns an error response.</exception>
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
    public Task<OrderDetails> QueryOrderUserData(QueryOrderUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/order"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("origClientOrderId", request.OrigClientOrderId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OrderDetails>(),
            QueryOrderUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Prevented Matches
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3MyPreventedMatchesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryPreventedMatchesError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<ApiV3MyPreventedMatchesResponse>> QueryPreventedMatches(QueryPreventedMatchesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/myPreventedMatches"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("preventedMatchId", request.PreventedMatchId),
                new Param("orderId", request.OrderId),
                new Param("fromPreventedMatchId", request.FromPreventedMatchId),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3MyPreventedMatchesResponse>>(),
            QueryPreventedMatchesError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query all OCO (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ApiV3AllOrderListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryAllOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves all OCO based on provided optional parameters
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<ApiV3AllOrderListResponse>> QueryAllOcoUserData(QueryAllOcoUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/allOrderList"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("fromId", request.FromId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ApiV3AllOrderListResponse>>(),
            QueryAllOcoUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Test New Order (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TestNewOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Test new order creation and signature/recvWindow long.
    /// Creates and validates a new order but does not send it into the matching engine.
    /// <para>
    /// Weight(IP):
    ///   - Without computeCommissionRates: <c>1</c>
    ///   - With computeCommissionRates: <c>20</c>
    /// </para>
    /// </remarks>
    public Task<object> TestNewOrderTrade(TestNewOrderTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/order/test"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("timeInForce", request.TimeInForce),
                new Param("quantity", request.Quantity),
                new Param("quoteOrderQty", request.QuoteOrderQty),
                new Param("price", request.Price),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("strategyId", request.StrategyId),
                new Param("strategyType", request.StrategyType),
                new Param("stopPrice", request.StopPrice),
                new Param("trailingDelta", request.TrailingDelta),
                new Param("icebergQty", request.IcebergQty),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("recvWindow", request.RecvWindow),
                new Param("computeCommissionRates", request.ComputeCommissionRates),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            TestNewOrderTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Test new order using SOR (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TestNewOrderUsingSorTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Test new order creation and signature/recvWindow using smart order routing (SOR).
    /// Creates and validates a new order but does not send it into the matching engine.
    /// <para>
    /// Weight(IP):
    ///   - Without computeCommissionRates: <c>1</c>
    ///   - With computeCommissionRates: <c>20</c>
    /// </para>
    /// </remarks>
    public Task<object> TestNewOrderUsingSorTrade(TestNewOrderUsingSorTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/v3/sor/order/test"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("type", request.Type),
                new Param("quantity", request.Quantity),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("timeInForce", request.TimeInForce),
                new Param("price", request.Price),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("strategyId", request.StrategyId),
                new Param("strategyType", request.StrategyType),
                new Param("icebergQty", request.IcebergQty),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("computeCommissionRates", request.ComputeCommissionRates),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            TestNewOrderUsingSorTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
