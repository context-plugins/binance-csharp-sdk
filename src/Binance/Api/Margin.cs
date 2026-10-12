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
using Binance.Requests.Margin;

namespace Binance.Api;

/// <summary>
/// Margin Account/Trade
/// </summary>
public sealed class Margin
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Margin(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Adjust cross margin max leverage (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginMaxLeverageResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AdjustCrossMarginMaxLeverageUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adjust cross margin max leverage
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginMaxLeverageResponse> AdjustCrossMarginMaxLeverageUserData(AdjustCrossMarginMaxLeverageUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/max-leverage"),
            [],
            [
                new Param("maxLeverage", request.MaxLeverage),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginMaxLeverageResponse>(),
            AdjustCrossMarginMaxLeverageUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cross margin collateral ratio (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginCrossMarginCollateralRatioResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CrossMarginCollateralRatioMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 100
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginCrossMarginCollateralRatioResponse>> CrossMarginCollateralRatioMarketData(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/crossMarginCollateralRatio"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginCrossMarginCollateralRatioResponse>>(),
            CrossMarginCollateralRatioMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Disable Isolated Margin Account (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginIsolatedAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DisableIsolatedMarginAccountTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disable isolated margin account for a specific symbol. Each trading pair can only be deactivated once every 24 hours .
    /// <para>
    /// Weight(UID): 300
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginIsolatedAccountResponse> DisableIsolatedMarginAccountTrade(DisableIsolatedMarginAccountTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/isolated/account"),
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
            JsonResponse.Create<SapiV1MarginIsolatedAccountResponse>(),
            DisableIsolatedMarginAccountTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Enable Isolated Margin Account (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginIsolatedAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EnableIsolatedMarginAccountTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable isolated margin account for a specific symbol.
    /// <para>
    /// Weight(UID): 300
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginIsolatedAccountResponse> EnableIsolatedMarginAccountTrade(EnableIsolatedMarginAccountTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/isolated/account"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginIsolatedAccountResponse>(),
            EnableIsolatedMarginAccountTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get All Cross Margin Pairs (MARKET_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginAllPairsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAllCrossMarginPairsMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginAllPairsResponse>> GetAllCrossMarginPairsMarketData(GetAllCrossMarginPairsMarketDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/allPairs"),
            [],
            [new Param("symbol", request.Symbol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginAllPairsResponse>>(),
            GetAllCrossMarginPairsMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get All Isolated Margin Symbol(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginIsolatedAllPairsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAllIsolatedMarginSymbolUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginIsolatedAllPairsResponse>> GetAllIsolatedMarginSymbolUserData(GetAllIsolatedMarginSymbolUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/isolated/allPairs"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginIsolatedAllPairsResponse>>(),
            GetAllIsolatedMarginSymbolUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get All Margin Assets (MARKET_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginAllAssetsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAllMarginAssetsMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginAllAssetsResponse>> GetAllMarginAssetsMarketData(GetAllMarginAssetsMarketDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/allAssets"),
            [],
            [new Param("asset", request.Asset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginAllAssetsResponse>>(),
            GetAllMarginAssetsMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get BNB Burn Status(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BnbBurnStatus"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBnbBurnStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<BnbBurnStatus> GetBnbBurnStatusUserData(GetBnbBurnStatusUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/bnbBurn"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BnbBurnStatus>(),
            GetBnbBurnStatusUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Cross Margin Transfer History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCrossMarginTransferHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Response in descending order</description></item>
    ///   <item><description>Returns data for last 7 days by default</description></item>
    ///   <item><description>Set <c>archived</c> to <c>true</c> to query data from 6 months ago</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginTransferResponse> GetCrossMarginTransferHistoryUserData(GetCrossMarginTransferHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/transfer"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("type", request.Type),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("isolatedSymbol", request.IsolatedSymbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginTransferResponse>(),
            GetCrossMarginTransferHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Force Liquidation Record (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginForceLiquidationRecResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetForceLiquidationRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Response in descending order</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginForceLiquidationRecResponse> GetForceLiquidationRecordUserData(GetForceLiquidationRecordUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/forceLiquidationRec"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("isolatedSymbol", request.IsolatedSymbol),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginForceLiquidationRecResponse>(),
            GetForceLiquidationRecordUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Interest History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginInterestHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInterestHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Response in descending order</description></item>
    ///   <item><description>If <c>isolatedSymbol</c> is not sent, crossed margin data will be returned</description></item>
    ///   <item><description>Set <c>archived</c> to <c>true</c> to query data from 6 months ago</description></item>
    ///   <item><description><c>type</c> in response has 4 enums:
    ///     <list type="bullet">
    ///       <item><description><c>PERIODIC</c> interest charged per hour</description></item>
    ///       <item><description><c>ON_BORROW</c> first interest charged on borrow</description></item>
    ///       <item><description><c>PERIODIC_CONVERTED</c> interest charged per hour converted into BNB</description></item>
    ///       <item><description><c>ON_BORROW_CONVERTED</c> first interest charged on borrow converted into BNB</description></item>
    ///     </list>
    ///   </description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginInterestHistoryResponse> GetInterestHistoryUserData(GetInterestHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/interestHistory"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("isolatedSymbol", request.IsolatedSymbol),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("archived", request.Archived),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginInterestHistoryResponse>(),
            GetInterestHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Small Liability Exchange Coin List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginExchangeSmallLiabilityResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSmallLiabilityExchangeCoinListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query the coins which can be small liability exchange
    /// <para>
    /// Weight(UID): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginExchangeSmallLiabilityResponse>> GetSmallLiabilityExchangeCoinListUserData(GetSmallLiabilityExchangeCoinListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/exchange-small-liability"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginExchangeSmallLiabilityResponse>>(),
            GetSmallLiabilityExchangeCoinListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Small Liability Exchange History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginExchangeSmallLiabilityHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSmallLiabilityExchangeHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Small liability Exchange History
    /// <para>
    /// Weight(UID): 100
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginExchangeSmallLiabilityHistoryResponse> GetSmallLiabilityExchangeHistoryUserData(GetSmallLiabilityExchangeHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/exchange-small-liability-history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginExchangeSmallLiabilityHistoryResponse>(),
            GetSmallLiabilityExchangeHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Summary of Margin account (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginTradeCoeffResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSummaryOfMarginAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get personal margin level information
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginTradeCoeffResponse> GetSummaryOfMarginAccountUserData(GetSummaryOfMarginAccountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/tradeCoeff"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginTradeCoeffResponse>(),
            GetSummaryOfMarginAccountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a future hourly interest rate (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginNextHourlyInterestRateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAFutureHourlyInterestRateUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get user the next hourly estimate interest
    /// <para>
    /// Weight(UID): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginNextHourlyInterestRateResponse>> GetAFutureHourlyInterestRateUserData(GetAFutureHourlyInterestRateUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/next-hourly-interest-rate"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("assets", request.Assets),
                new Param("isIsolated", request.IsIsolated),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginNextHourlyInterestRateResponse>>(),
            GetAFutureHourlyInterestRateUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get cross or isolated margin capital flow(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginCapitalFlowResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCrossOrIsolatedMarginCapitalFlowUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get cross or isolated margin capital flow
    /// <para>
    /// Weight(IP): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginCapitalFlowResponse>> GetCrossOrIsolatedMarginCapitalFlowUserData(GetCrossOrIsolatedMarginCapitalFlowUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/capital-flow"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("symbol", request.Symbol),
                new Param("type", request.Type),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("fromId", request.FromId),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginCapitalFlowResponse>>(),
            GetCrossOrIsolatedMarginCapitalFlowUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get tokens or symbols delist schedule for cross margin and isolated margin (MARKET_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginDelistScheduleResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get tokens or symbols delist schedule for cross margin and isolated margin
    /// <para>
    /// Weight(IP): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginDelistScheduleResponse>> GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData(GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/delist-schedule"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginDelistScheduleResponse>>(),
            GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin Account Cancel OCO (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MarginOcoOrder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginAccountCancelOcoTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an entire Order List for a margin account
    /// <list type="bullet">
    ///   <item><description>Canceling an individual leg will cancel the entire OCO</description></item>
    ///   <item><description>Either <c>orderListId</c> or <c>listClientOrderId</c> must be provided</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 1
    /// </para>
    /// </remarks>
    public Task<MarginOcoOrder> MarginAccountCancelOcoTrade(MarginAccountCancelOcoTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/orderList"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("orderListId", request.OrderListId),
                new Param("listClientOrderId", request.ListClientOrderId),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<MarginOcoOrder>(),
            MarginAccountCancelOcoTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin Account Cancel Order (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MarginOrder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginAccountCancelOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an active order for margin account.
    /// <para>
    /// Either <c>orderId</c> or <c>origClientOrderId</c> must be sent.
    /// </para>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<MarginOrder> MarginAccountCancelOrderTrade(MarginAccountCancelOrderTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/order"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("orderId", request.OrderId),
                new Param("origClientOrderId", request.OrigClientOrderId),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<MarginOrder>(),
            MarginAccountCancelOrderTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin Account Cancel all Open Orders on a Symbol (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginOpenOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginAccountCancelAllOpenOrdersOnASymbolTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Cancels all active orders on a symbol for margin account.</description></item>
    ///   <item><description>This includes OCO orders.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginOpenOrdersResponse>> MarginAccountCancelAllOpenOrdersOnASymbolTrade(MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/openOrders"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginOpenOrdersResponse>>(),
            MarginAccountCancelAllOpenOrdersOnASymbolTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin Account New OCO (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderOcoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginAccountNewOcoTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Send in a new OCO for a margin account
    /// <list type="bullet">
    ///   <item><description>Price Restrictions:
    ///     <list type="bullet">
    ///       <item><description>SELL: Limit Price &gt; Last Price &gt; Stop Price</description></item>
    ///       <item><description>BUY: Limit Price &lt; Last Price &lt; Stop Price</description></item>
    ///     </list>
    ///   </description></item>
    ///   <item><description>Quantity Restrictions:
    ///     <list type="bullet">
    ///       <item><description>Both legs must have the same quantity</description></item>
    ///       <item><description>ICEBERG quantities however do not have to be the same.</description></item>
    ///     </list>
    ///   </description></item>
    ///   <item><description>Order Rate Limit
    ///     <list type="bullet">
    ///       <item><description>OCO counts as 2 orders against the order rate limit.</description></item>
    ///     </list>
    ///   </description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 6
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginOrderOcoResponse> MarginAccountNewOcoTrade(MarginAccountNewOcoTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/order/oco"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("quantity", request.Quantity),
                new Param("price", request.Price),
                new Param("stopPrice", request.StopPrice),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("listClientOrderId", request.ListClientOrderId),
                new Param("limitClientOrderId", request.LimitClientOrderId),
                new Param("limitIcebergQty", request.LimitIcebergQty),
                new Param("stopClientOrderId", request.StopClientOrderId),
                new Param("stopLimitPrice", request.StopLimitPrice),
                new Param("stopIcebergQty", request.StopIcebergQty),
                new Param("stopLimitTimeInForce", request.StopLimitTimeInForce),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("sideEffectType", request.SideEffectType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderOcoResponse>(),
            MarginAccountNewOcoTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin Account New OTO (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderOtoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginAccountNewOtoTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Post a new <c>OTO</c> order for margin account:
    /// - An <c>OTO</c> (One-Triggers-the-Other) is an order list comprised of 2 orders
    /// - The first order is called the working order and must be <c>LIMIT</c> or <c>LIMIT_MAKER</c>. Initially, only the working order goes on the order book.
    /// - The second order is called the pending order. It can be any order type except for <c>MARKET</c> orders using parameter <c>quoteOrderQty</c>. The pending order is only placed on the order book when the working order gets fully filled.
    /// - If either the working order or the pending order is cancelled individually, the other order in the order list will also be canceled or expired.
    /// - When the order list is placed, if the working order gets immediately fully filled, the placement response will show the working order as <c>FILLED</c> but the pending order will still appear as <c>PENDING_NEW</c>. You need to query the status of the pending order again to see its updated status.
    /// - OTOs add 2 orders to the unfilled order count, <c>EXCHANGE_MAX_NUM_ORDERS</c> filter and <c>MAX_NUM_ORDERS</c> filter.
    /// <para>
    /// Weight(UID): 6
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginOrderOtoResponse> MarginAccountNewOtoTrade(MarginAccountNewOtoTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/order/oto"),
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
                new Param("isIsolated", request.IsIsolated),
                new Param("listClientOrderId", request.ListClientOrderId),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("sideEffectType", request.SideEffectType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("autoRepayAtCancel", request.AutoRepayAtCancel),
                new Param("workingClientOrderId", request.WorkingClientOrderId),
                new Param("workingTimeInForce", request.WorkingTimeInForce),
                new Param("pendingClientOrderId", request.PendingClientOrderId),
                new Param("pendingPrice", request.PendingPrice),
                new Param("pendingStopPrice", request.PendingStopPrice),
                new Param("pendingTrailingDelta", request.PendingTrailingDelta),
                new Param("pendingIcebergQty", request.PendingIcebergQty),
                new Param("pendingTimeInForce", request.PendingTimeInForce),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderOtoResponse>(),
            MarginAccountNewOtoTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin Account New OTOCO (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderOtocoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginAccountNewOtocoTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Post a new <c>OTOCO</c> order for margin account:
    /// - An <c>OTOCO</c> (One-Triggers-the-Other-Cancel-the-Other) is an order list comprised of 3 orders
    /// - The first order is called the working order and must be <c>LIMIT</c> or <c>LIMIT_MAKER</c>. Initially, only the working order goes on the order book.
    ///   - The behavior of the working order is the same as the <c>OTO</c>.
    /// - <c>OTOCO</c> has 2 pending orders (pending above and pending below), forming an <c>OCO</c> pair. The pending orders are only placed on the order book when the working order gets fully filled.
    ///   - The rules of the pending above and pending below follow the same rules as the Order List <c>OCO</c>.
    /// - OTOCOs add 3 orders to the unfilled order count, <c>EXCHANGE_MAX_NUM_ORDERS</c> filter and <c>MAX_NUM_ORDERS</c> filter.
    /// <para>
    /// Weight(UID): 6
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginOrderOtocoResponse> MarginAccountNewOtocoTrade(MarginAccountNewOtocoTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/order/otoco"),
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
                new Param("isIsolated", request.IsIsolated),
                new Param("sideEffectType", request.SideEffectType),
                new Param("autoRepayAtCancel", request.AutoRepayAtCancel),
                new Param("listClientOrderId", request.ListClientOrderId),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("workingClientOrderId", request.WorkingClientOrderId),
                new Param("workingTimeInForce", request.WorkingTimeInForce),
                new Param("pendingAboveClientOrderId", request.PendingAboveClientOrderId),
                new Param("pendingAbovePrice", request.PendingAbovePrice),
                new Param("pendingAboveStopPrice", request.PendingAboveStopPrice),
                new Param("pendingAboveTrailingDelta", request.PendingAboveTrailingDelta),
                new Param("pendingAboveIcebergQty", request.PendingAboveIcebergQty),
                new Param("pendingAboveTimeInForce", request.PendingAboveTimeInForce),
                new Param("pendingBelowType", request.PendingBelowType),
                new Param("pendingBelowClientOrderId", request.PendingBelowClientOrderId),
                new Param("pendingBelowPrice", request.PendingBelowPrice),
                new Param("pendingBelowStopPrice", request.PendingBelowStopPrice),
                new Param("pendingBelowTrailingDelta", request.PendingBelowTrailingDelta),
                new Param("pendingBelowIcebergQty", request.PendingBelowIcebergQty),
                new Param("pendingBelowTimeInForce", request.PendingBelowTimeInForce),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderOtocoResponse>(),
            MarginAccountNewOtocoTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin Account New Order (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginAccountNewOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Post a new order for margin account.
    /// <para>
    /// Weight(UID): 6
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginOrderResponse> MarginAccountNewOrderTrade(MarginAccountNewOrderTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/order"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("side", request.Side),
                new Param("type", request.Type),
                new Param("quantity", request.Quantity),
                new Param("autoRepayAtCancel", request.AutoRepayAtCancel),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("quoteOrderQty", request.QuoteOrderQty),
                new Param("price", request.Price),
                new Param("stopPrice", request.StopPrice),
                new Param("newClientOrderId", request.NewClientOrderId),
                new Param("icebergQty", request.IcebergQty),
                new Param("newOrderRespType", request.NewOrderRespType),
                new Param("sideEffectType", request.SideEffectType),
                new Param("timeInForce", request.TimeInForce),
                new Param("selfTradePreventionMode", request.SelfTradePreventionMode),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderResponse>(),
            MarginAccountNewOrderTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin Interest Rate History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginInterestRateHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginInterestRateHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The max interval between startTime and endTime is 30 days.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginInterestRateHistoryResponse>> MarginInterestRateHistoryUserData(MarginInterestRateHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/interestRateHistory"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("vipLevel", request.VipLevel),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginInterestRateHistoryResponse>>(),
            MarginInterestRateHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin account borrow/repay(MARGIN)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginBorrowRepayResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginAccountBorrowRepayMarginError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Margin account borrow/repay(MARGIN)
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginBorrowRepayResponse> MarginAccountBorrowRepayMargin(MarginAccountBorrowRepayMarginRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/borrow-repay"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("isIsolated", request.IsIsolated),
                new Param("symbol", request.Symbol),
                new Param("amount", request.Amount),
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginBorrowRepayResponse>(),
            MarginAccountBorrowRepayMarginError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin manual liquidation(MARGIN)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginManualLiquidationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginManualLiquidationMarginError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Margin manual liquidation
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginManualLiquidationResponse>> MarginManualLiquidationMargin(MarginManualLiquidationMarginRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/manual-liquidation"),
            [],
            [
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("symbol", request.Symbol),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginManualLiquidationResponse>>(),
            MarginManualLiquidationMarginError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Cross Margin Account Details (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryCrossMarginAccountDetailsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1MarginAccountResponse> QueryCrossMarginAccountDetailsUserData(QueryCrossMarginAccountDetailsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/account"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginAccountResponse>(),
            QueryCrossMarginAccountDetailsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Cross Margin Fee Data (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginCrossMarginDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryCrossMarginFeeDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get cross margin fee data collection with any vip level or user's current specific data as https://www.binance.com/en/margin-fee
    /// <para>
    /// Weight(IP): 1 when coin is specified; 5 when the coin parameter is omitted
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginCrossMarginDataResponse>> QueryCrossMarginFeeDataUserData(QueryCrossMarginFeeDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/crossMarginData"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("vipLevel", request.VipLevel),
                new Param("coin", request.Coin),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginCrossMarginDataResponse>>(),
            QueryCrossMarginFeeDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Current Margin Order Count Usage (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginRateLimitOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryCurrentMarginOrderCountUsageTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Displays the user's current margin order count usage for all intervals.
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginRateLimitOrderResponse>> QueryCurrentMarginOrderCountUsageTrade(QueryCurrentMarginOrderCountUsageTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/rateLimit/order"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("symbol", request.Symbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginRateLimitOrderResponse>>(),
            QueryCurrentMarginOrderCountUsageTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Enabled Isolated Margin Account Limit (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginIsolatedAccountLimitResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryEnabledIsolatedMarginAccountLimitUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query enabled isolated margin account limit.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginIsolatedAccountLimitResponse> QueryEnabledIsolatedMarginAccountLimitUserData(QueryEnabledIsolatedMarginAccountLimitUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/isolated/accountLimit"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginIsolatedAccountLimitResponse>(),
            QueryEnabledIsolatedMarginAccountLimitUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Isolated Margin Account Info (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IsolatedMarginAccountInfo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryIsolatedMarginAccountInfoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If "symbols" is not sent, all isolated assets will be returned.</description></item>
    ///   <item><description>If "symbols" is sent, only the isolated assets of the sent symbols will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IsolatedMarginAccountInfo> QueryIsolatedMarginAccountInfoUserData(QueryIsolatedMarginAccountInfoUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/isolated/account"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("symbols", request.Symbols),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IsolatedMarginAccountInfo>(),
            QueryIsolatedMarginAccountInfoUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Isolated Margin Fee Data (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginIsolatedMarginDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryIsolatedMarginFeeDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get isolated margin fee data collection with any vip level or user's current specific data as https://www.binance.com/en/margin-fee
    /// <para>
    /// Weight(IP): 1 when a single is specified; 10 when the symbol parameter is omitted
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginIsolatedMarginDataResponse>> QueryIsolatedMarginFeeDataUserData(QueryIsolatedMarginFeeDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/isolatedMarginData"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("vipLevel", request.VipLevel),
                new Param("symbol", request.Symbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginIsolatedMarginDataResponse>>(),
            QueryIsolatedMarginFeeDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Isolated Margin Tier Data (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginIsolatedMarginTierResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryIsolatedMarginTierDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get isolated margin tier data collection with any tier as https://www.binance.com/en/margin-data
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginIsolatedMarginTierResponse>> QueryIsolatedMarginTierDataUserData(QueryIsolatedMarginTierDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/isolatedMarginTier"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("tier", request.Tier),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginIsolatedMarginTierResponse>>(),
            QueryIsolatedMarginTierDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Liability Coin Leverage Bracket in Cross Margin Pro Mode (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginLeverageBracketResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Liability Coin Leverage Bracket in Cross Margin Pro Mode
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginLeverageBracketResponse>> QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/leverageBracket"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginLeverageBracketResponse>>(),
            QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Margin Account's All Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="MarginOrderDetail"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMarginAccountSAllOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If <c>orderId</c> is set, it will get orders &gt;= that orderId. Otherwise most recent orders are returned.</description></item>
    ///   <item><description>For some historical orders <c>cummulativeQuoteQty</c> will be &lt; 0, meaning the data is not available at this time.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 200
    /// </para>
    /// <para>
    /// Request Limit: 60 times/min per IP
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<MarginOrderDetail>> QueryMarginAccountSAllOrdersUserData(QueryMarginAccountSAllOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/allOrders"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("orderId", request.OrderId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<MarginOrderDetail>>(),
            QueryMarginAccountSAllOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Margin Account's OCO (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMarginAccountSOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific OCO based on provided optional parameters
    /// <list type="bullet">
    ///   <item><description>Either <c>orderListId</c> or <c>origClientOrderId</c> must be provided</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginOrderListResponse> QueryMarginAccountSOcoUserData(QueryMarginAccountSOcoUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/orderList"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("symbol", request.Symbol),
                new Param("orderListId", request.OrderListId),
                new Param("origClientOrderId", request.OrigClientOrderId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderListResponse>(),
            QueryMarginAccountSOcoUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Margin Account's Open OCO (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginOpenOrderListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMarginAccountSOpenOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginOpenOrderListResponse>> QueryMarginAccountSOpenOcoUserData(QueryMarginAccountSOpenOcoUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/openOrderList"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("symbol", request.Symbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginOpenOrderListResponse>>(),
            QueryMarginAccountSOpenOcoUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Margin Account's Open Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="MarginOrderDetail"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMarginAccountSOpenOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If the <c>symbol</c> is not sent, orders for all symbols will be returned in an array.</description></item>
    ///   <item><description>When all symbols are returned, the number of requests counted against the rate limiter is equal to the number of symbols currently trading on the exchange</description></item>
    ///   <item><description>If isIsolated ="TRUE", symbol must be sent.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<MarginOrderDetail>> QueryMarginAccountSOpenOrdersUserData(QueryMarginAccountSOpenOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/openOrders"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("symbol", request.Symbol),
                new Param("isIsolated", request.IsIsolated),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<MarginOrderDetail>>(),
            QueryMarginAccountSOpenOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Margin Account's Order (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MarginOrderDetail"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMarginAccountSOrderUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Either <c>orderId</c> or <c>origClientOrderId</c> must be sent.</description></item>
    ///   <item><description>For some historical orders <c>cummulativeQuoteQty</c> will be &lt; 0, meaning the data is not available at this time.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<MarginOrderDetail> QueryMarginAccountSOrderUserData(QueryMarginAccountSOrderUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/order"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("orderId", request.OrderId),
                new Param("origClientOrderId", request.OrigClientOrderId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MarginOrderDetail>(),
            QueryMarginAccountSOrderUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Margin Account's Trade List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="MarginTrade"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMarginAccountSTradeListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If <c>fromId</c> is set, it will get orders &gt;= that <c>fromId</c>. Otherwise most recent trades are returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<MarginTrade>> QueryMarginAccountSTradeListUserData(QueryMarginAccountSTradeListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/myTrades"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("fromId", request.FromId),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<MarginTrade>>(),
            QueryMarginAccountSTradeListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Margin Account's all OCO (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginAllOrderListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMarginAccountSAllOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves all OCO for a specific margin account based on provided optional parameters
    /// <para>
    /// Weight(IP): 200
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginAllOrderListResponse>> QueryMarginAccountSAllOcoUserData(QueryMarginAccountSAllOcoUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/allOrderList"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isIsolated", request.IsIsolated),
                new Param("symbol", request.Symbol),
                new Param("fromId", request.FromId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginAllOrderListResponse>>(),
            QueryMarginAccountSAllOcoUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Margin Available Inventory (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginAvailableInventoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMarginAvailableInventoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Margin available Inventory query
    /// <para>
    /// Weight(UID): 50
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginAvailableInventoryResponse> QueryMarginAvailableInventoryUserData(QueryMarginAvailableInventoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/available-inventory"),
            [],
            [
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginAvailableInventoryResponse>(),
            QueryMarginAvailableInventoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Margin PriceIndex (MARKET_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginPriceIndexResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMarginPriceIndexMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1MarginPriceIndexResponse> QueryMarginPriceIndexMarketData(QueryMarginPriceIndexMarketDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/priceIndex"),
            [],
            [new Param("symbol", request.Symbol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginPriceIndexResponse>(),
            QueryMarginPriceIndexMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Max Borrow (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginMaxBorrowableResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMaxBorrowUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If <c>isolatedSymbol</c> is not sent, crossed margin data will be sent.</description></item>
    ///   <item><description><c>borrowLimit</c> is also available from https://www.binance.com/en/margin-fee</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginMaxBorrowableResponse> QueryMaxBorrowUserData(QueryMaxBorrowUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/maxBorrowable"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isolatedSymbol", request.IsolatedSymbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginMaxBorrowableResponse>(),
            QueryMaxBorrowUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Max Transfer-Out Amount (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginMaxTransferableResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMaxTransferOutAmountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If <c>isolatedSymbol</c> is not sent, crossed margin data will be sent.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginMaxTransferableResponse> QueryMaxTransferOutAmountUserData(QueryMaxTransferOutAmountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/maxTransferable"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isolatedSymbol", request.IsolatedSymbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginMaxTransferableResponse>(),
            QueryMaxTransferOutAmountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query borrow/repay records in Margin account(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginBorrowRepayResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryBorrowRepayRecordsInMarginAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query borrow/repay records in Margin account
    /// <list type="bullet">
    ///   <item><description>txId or startTime must be sent. txId takes precedence. Response in descending order</description></item>
    ///   <item><description>If an asset is sent, data within 30 days before endTime; If an asset is not sent, data within 7 days before endTime</description></item>
    ///   <item><description>If neither startTime nor endTime is sent, the recent 7-day data will be returned.</description></item>
    ///   <item><description>startTime set as endTime - 7 days by default, endTime set as current time by default</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginBorrowRepayResponse1> QueryBorrowRepayRecordsInMarginAccountUserData(QueryBorrowRepayRecordsInMarginAccountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/margin/borrow-repay"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("isolatedSymbol", request.IsolatedSymbol),
                new Param("txId", request.TxId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginBorrowRepayResponse1>(),
            QueryBorrowRepayRecordsInMarginAccountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Toggle BNB Burn On Spot Trade And Margin Interest (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BnbBurnStatus"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>"spotBNBBurn" and "interestBNBBurn" should be sent at least one.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<BnbBurnStatus> ToggleBnbBurnOnSpotTradeAndMarginInterestUserData(ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/bnbBurn"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("spotBNBBurn", request.SpotBnbBurn),
                new Param("interestBNBBurn", request.InterestBnbBurn),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<BnbBurnStatus>(),
            ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
