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
    /// <param name="maxLeverage">Can only adjust 3 or 5</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginMaxLeverageResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AdjustCrossMarginMaxLeverageUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adjust cross margin max leverage
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginMaxLeverageResponse> AdjustCrossMarginMaxLeverageUserData(int maxLeverage,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/max-leverage"),
            [],
            [new Param("maxLeverage", maxLeverage),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginMaxLeverageResponse>(),
            AdjustCrossMarginMaxLeverageUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Cross margin collateral ratio (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginCrossMarginCollateralRatioResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CrossMarginCollateralRatioMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    ///
    /// Weight(IP): 100
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginCrossMarginCollateralRatioResponse>> CrossMarginCollateralRatioMarketData(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/crossMarginCollateralRatio"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginCrossMarginCollateralRatioResponse>>(),
            CrossMarginCollateralRatioMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Disable Isolated Margin Account (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginIsolatedAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DisableIsolatedMarginAccountTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disable isolated margin account for a specific symbol. Each trading pair can only be deactivated once every 24 hours .
    /// <para>
    /// Weight(UID): 300
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginIsolatedAccountResponse> DisableIsolatedMarginAccountTrade(string symbol,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/isolated/account"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginIsolatedAccountResponse>(),
            DisableIsolatedMarginAccountTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Enable Isolated Margin Account (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginIsolatedAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EnableIsolatedMarginAccountTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable isolated margin account for a specific symbol.
    /// <para>
    /// Weight(UID): 300
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginIsolatedAccountResponse> EnableIsolatedMarginAccountTrade(string symbol,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/isolated/account"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginIsolatedAccountResponse>(),
            EnableIsolatedMarginAccountTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get All Cross Margin Pairs (MARKET_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginAllPairsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAllCrossMarginPairsMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginAllPairsResponse>> GetAllCrossMarginPairsMarketData(string symbol,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/allPairs"),
            [],
            [new Param("symbol", symbol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginAllPairsResponse>>(),
            GetAllCrossMarginPairsMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get All Isolated Margin Symbol(USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginIsolatedAllPairsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAllIsolatedMarginSymbolUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginIsolatedAllPairsResponse>> GetAllIsolatedMarginSymbolUserData(string symbol,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/isolated/allPairs"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginIsolatedAllPairsResponse>>(),
            GetAllIsolatedMarginSymbolUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get All Margin Assets (MARKET_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginAllAssetsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAllMarginAssetsMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginAllAssetsResponse>> GetAllMarginAssetsMarketData(string asset,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/allAssets"),
            [],
            [new Param("asset", asset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginAllAssetsResponse>>(),
            GetAllMarginAssetsMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get BNB Burn Status(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BnbBurnStatus"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBnbBurnStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<BnbBurnStatus> GetBnbBurnStatusUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/bnbBurn"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BnbBurnStatus>(),
            GetBnbBurnStatusUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Cross Margin Transfer History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="type"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="isolatedSymbol">Isolated symbol</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCrossMarginTransferHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1MarginTransferResponse> GetCrossMarginTransferHistoryUserData(long timestamp,
        string signature,
        string? asset,
        Type2? type,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        string? isolatedSymbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/transfer"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("type", type),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("isolatedSymbol", isolatedSymbol),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginTransferResponse>(),
            GetCrossMarginTransferHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Force Liquidation Record (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="isolatedSymbol">Isolated symbol</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginForceLiquidationRecResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetForceLiquidationRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Response in descending order</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginForceLiquidationRecResponse> GetForceLiquidationRecordUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        string? isolatedSymbol,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/forceLiquidationRec"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("isolatedSymbol", isolatedSymbol),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginForceLiquidationRecResponse>(),
            GetForceLiquidationRecordUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Interest History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="isolatedSymbol">Isolated symbol</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="archived">Default: false. Set to true for archived data from 6 months ago</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginInterestHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetInterestHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1MarginInterestHistoryResponse> GetInterestHistoryUserData(long timestamp,
        string signature,
        string? asset,
        string? isolatedSymbol,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        string? archived,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/interestHistory"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("isolatedSymbol", isolatedSymbol),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("archived", archived),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginInterestHistoryResponse>(),
            GetInterestHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Small Liability Exchange Coin List (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginExchangeSmallLiabilityResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSmallLiabilityExchangeCoinListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query the coins which can be small liability exchange
    /// <para>
    /// Weight(UID): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginExchangeSmallLiabilityResponse>> GetSmallLiabilityExchangeCoinListUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/exchange-small-liability"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginExchangeSmallLiabilityResponse>>(),
            GetSmallLiabilityExchangeCoinListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Small Liability Exchange History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginExchangeSmallLiabilityHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSmallLiabilityExchangeHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Small liability Exchange History
    /// <para>
    /// Weight(UID): 100
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginExchangeSmallLiabilityHistoryResponse> GetSmallLiabilityExchangeHistoryUserData(long timestamp,
        string signature,
        int? current,
        int? size,
        long? startTime,
        long? endTime,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/exchange-small-liability-history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("current", current),
                new Param("size", size),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginExchangeSmallLiabilityHistoryResponse>(),
            GetSmallLiabilityExchangeHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Summary of Margin account (USER_DATA)
    /// </summary>
    /// <param name="email">Email Address</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginTradeCoeffResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSummaryOfMarginAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get personal margin level information
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginTradeCoeffResponse> GetSummaryOfMarginAccountUserData(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/tradeCoeff"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginTradeCoeffResponse>(),
            GetSummaryOfMarginAccountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get a future hourly interest rate (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="assets">List of assets, separated by commas, up to 20</param>
    /// <param name="isIsolated">for isolated margin or not, "TRUE", "FALSE"</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginNextHourlyInterestRateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAFutureHourlyInterestRateUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get user the next hourly estimate interest
    /// <para>
    /// Weight(UID): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginNextHourlyInterestRateResponse>> GetAFutureHourlyInterestRateUserData(long timestamp,
        string signature,
        string? assets,
        IsIsolated? isIsolated,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/next-hourly-interest-rate"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("assets", assets),
                new Param("isIsolated", isIsolated),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginNextHourlyInterestRateResponse>>(),
            GetAFutureHourlyInterestRateUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get cross or isolated margin capital flow(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="symbol">Required when querying isolated data</param>
    /// <param name="type"></param>
    /// <param name="startTime">Only supports querying the data of the last 90 days</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="fromId">If fromId is set, the data with id &gt; fromId will be returned. Otherwise the latest data will be returned</param>
    /// <param name="limit">The number of data items returned each time is limited. Default 500; Max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginCapitalFlowResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCrossOrIsolatedMarginCapitalFlowUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get cross or isolated margin capital flow
    /// <para>
    /// Weight(IP): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginCapitalFlowResponse>> GetCrossOrIsolatedMarginCapitalFlowUserData(long timestamp,
        string signature,
        string? asset,
        string? symbol,
        Type3? type,
        long? startTime,
        long? endTime,
        long? fromId,
        long? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/capital-flow"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("symbol", symbol),
                new Param("type", type),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("fromId", fromId),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginCapitalFlowResponse>>(),
            GetCrossOrIsolatedMarginCapitalFlowUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get tokens or symbols delist schedule for cross margin and isolated margin (MARKET_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginDelistScheduleResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get tokens or symbols delist schedule for cross margin and isolated margin
    /// <para>
    /// Weight(IP): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginDelistScheduleResponse>> GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/delist-schedule"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginDelistScheduleResponse>>(),
            GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin Account Cancel OCO (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="orderListId">Order list id</param>
    /// <param name="listClientOrderId">A unique Id for the entire orderList</param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MarginOcoOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginAccountCancelOcoTradeError"/> when the server returns an error response.</exception>
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
    public Task<MarginOcoOrder> MarginAccountCancelOcoTrade(string symbol,
        long timestamp,
        string signature,
        IsIsolated? isIsolated,
        long? orderListId,
        string? listClientOrderId,
        string? newClientOrderId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/orderList"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("orderListId", orderListId),
                new Param("listClientOrderId", listClientOrderId),
                new Param("newClientOrderId", newClientOrderId),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<MarginOcoOrder>(),
            MarginAccountCancelOcoTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin Account Cancel Order (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="orderId">Order id</param>
    /// <param name="origClientOrderId">Order id from client</param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MarginOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginAccountCancelOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an active order for margin account.
    /// <para>
    /// Either <c>orderId</c> or <c>origClientOrderId</c> must be sent.
    /// </para>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<MarginOrder> MarginAccountCancelOrderTrade(string symbol,
        long timestamp,
        string signature,
        IsIsolated? isIsolated,
        long? orderId,
        string? origClientOrderId,
        string? newClientOrderId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/order"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("orderId", orderId),
                new Param("origClientOrderId", origClientOrderId),
                new Param("newClientOrderId", newClientOrderId),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<MarginOrder>(),
            MarginAccountCancelOrderTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin Account Cancel all Open Orders on a Symbol (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginOpenOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginAccountCancelAllOpenOrdersOnASymbolTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Cancels all active orders on a symbol for margin account.</description></item>
    ///   <item><description>This includes OCO orders.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginOpenOrdersResponse>> MarginAccountCancelAllOpenOrdersOnASymbolTrade(string symbol,
        long timestamp,
        string signature,
        IsIsolated? isIsolated,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/openOrders"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginOpenOrdersResponse>>(),
            MarginAccountCancelAllOpenOrdersOnASymbolTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin Account New OCO (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="quantity"></param>
    /// <param name="price">Order price</param>
    /// <param name="stopPrice"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="listClientOrderId">A unique Id for the entire orderList</param>
    /// <param name="limitClientOrderId">A unique Id for the limit order</param>
    /// <param name="limitIcebergQty"></param>
    /// <param name="stopClientOrderId">A unique Id for the stop loss/stop loss limit leg</param>
    /// <param name="stopLimitPrice">If provided, stopLimitTimeInForce is required.</param>
    /// <param name="stopIcebergQty"></param>
    /// <param name="stopLimitTimeInForce"></param>
    /// <param name="newOrderRespType">Set the response JSON.</param>
    /// <param name="sideEffectType">Default <c>NO_SIDE_EFFECT</c></param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderOcoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginAccountNewOcoTradeError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1MarginOrderOcoResponse> MarginAccountNewOcoTrade(string symbol,
        Side side,
        double quantity,
        double price,
        double stopPrice,
        long timestamp,
        string signature,
        IsIsolated? isIsolated,
        string? listClientOrderId,
        string? limitClientOrderId,
        double? limitIcebergQty,
        string? stopClientOrderId,
        double? stopLimitPrice,
        double? stopIcebergQty,
        StopLimitTimeInForce? stopLimitTimeInForce,
        NewOrderRespType? newOrderRespType,
        SideEffectType? sideEffectType,
        SelfTradePreventionMode? selfTradePreventionMode,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/order/oco"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("quantity", quantity),
                new Param("price", price),
                new Param("stopPrice", stopPrice),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("listClientOrderId", listClientOrderId),
                new Param("limitClientOrderId", limitClientOrderId),
                new Param("limitIcebergQty", limitIcebergQty),
                new Param("stopClientOrderId", stopClientOrderId),
                new Param("stopLimitPrice", stopLimitPrice),
                new Param("stopIcebergQty", stopIcebergQty),
                new Param("stopLimitTimeInForce", stopLimitTimeInForce),
                new Param("newOrderRespType", newOrderRespType),
                new Param("sideEffectType", sideEffectType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderOcoResponse>(),
            MarginAccountNewOcoTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin Account New OTO (TRADE)
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
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="listClientOrderId">Arbitrary unique ID among open order lists. Automatically generated if not sent. A new order list with the same <c>listClientOrderId</c> is accepted only when the previous one is filled or completely expired. <c>listClientOrderId</c> is distinct from the <c>workingClientOrderId</c> and the <c>pendingClientOrderId</c>.</param>
    /// <param name="newOrderRespType">Set the response JSON.</param>
    /// <param name="sideEffectType">Default <c>NO_SIDE_EFFECT</c></param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="autoRepayAtCancel">Only when MARGIN_BUY order takes effect, true means that the debt generated by the order needs to be repay after the order is cancelled. The default is true</param>
    /// <param name="workingClientOrderId">Arbitrary unique ID among open orders for the working order. Automatically generated if not sent.</param>
    /// <param name="workingTimeInForce">GTC, IOC, FOK</param>
    /// <param name="pendingClientOrderId">Arbitrary unique ID among open orders for the pending order. Automatically generated if not sent.</param>
    /// <param name="pendingPrice"></param>
    /// <param name="pendingStopPrice"></param>
    /// <param name="pendingTrailingDelta"></param>
    /// <param name="pendingIcebergQty">This can only be used if pendingTimeInForce is GTC.</param>
    /// <param name="pendingTimeInForce">GTC, IOC, FOK</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderOtoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginAccountNewOtoTradeError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1MarginOrderOtoResponse> MarginAccountNewOtoTrade(string symbol,
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
        IsIsolated? isIsolated,
        string? listClientOrderId,
        NewOrderRespType? newOrderRespType,
        SideEffectType1? sideEffectType,
        SelfTradePreventionMode? selfTradePreventionMode,
        bool? autoRepayAtCancel,
        string? workingClientOrderId,
        WorkingTimeInForce? workingTimeInForce,
        string? pendingClientOrderId,
        double? pendingPrice,
        double? pendingStopPrice,
        double? pendingTrailingDelta,
        double? pendingIcebergQty,
        PendingTimeInForce? pendingTimeInForce,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/order/oto"),
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
                new Param("isIsolated", isIsolated),
                new Param("listClientOrderId", listClientOrderId),
                new Param("newOrderRespType", newOrderRespType),
                new Param("sideEffectType", sideEffectType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("autoRepayAtCancel", autoRepayAtCancel),
                new Param("workingClientOrderId", workingClientOrderId),
                new Param("workingTimeInForce", workingTimeInForce),
                new Param("pendingClientOrderId", pendingClientOrderId),
                new Param("pendingPrice", pendingPrice),
                new Param("pendingStopPrice", pendingStopPrice),
                new Param("pendingTrailingDelta", pendingTrailingDelta),
                new Param("pendingIcebergQty", pendingIcebergQty),
                new Param("pendingTimeInForce", pendingTimeInForce)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderOtoResponse>(),
            MarginAccountNewOtoTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin Account New OTOCO (TRADE)
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
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="sideEffectType">Default <c>NO_SIDE_EFFECT</c></param>
    /// <param name="autoRepayAtCancel">Only when MARGIN_BUY order takes effect, true means that the debt generated by the order needs to be repay after the order is cancelled. The default is true</param>
    /// <param name="listClientOrderId">Arbitrary unique ID among open order lists. Automatically generated if not sent. A new order list with the same <c>listClientOrderId</c> is accepted only when the previous one is filled or completely expired. <c>listClientOrderId</c> is distinct from the <c>workingClientOrderId</c> and the <c>pendingClientOrderId</c>.</param>
    /// <param name="newOrderRespType">Set the response JSON.</param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="workingClientOrderId">Arbitrary unique ID among open orders for the working order. Automatically generated if not sent.</param>
    /// <param name="workingTimeInForce">GTC, IOC, FOK</param>
    /// <param name="pendingAboveClientOrderId">Arbitrary unique ID among open orders for the pending above order. Automatically generated if not sent.</param>
    /// <param name="pendingAbovePrice"></param>
    /// <param name="pendingAboveStopPrice"></param>
    /// <param name="pendingAboveTrailingDelta"></param>
    /// <param name="pendingAboveIcebergQty">This can only be used if pendingAboveTimeInForce is GTC.</param>
    /// <param name="pendingAboveTimeInForce"></param>
    /// <param name="pendingBelowType">Supported values: LIMIT_MAKER, STOP_LOSS, and STOP_LOSS_LIMIT</param>
    /// <param name="pendingBelowClientOrderId">Arbitrary unique ID among open orders for the pending below order. Automatically generated if not sent.</param>
    /// <param name="pendingBelowPrice"></param>
    /// <param name="pendingBelowStopPrice"></param>
    /// <param name="pendingBelowTrailingDelta"></param>
    /// <param name="pendingBelowIcebergQty">This can only be used if pendingBelowTimeInForce is GTC.</param>
    /// <param name="pendingBelowTimeInForce"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderOtocoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginAccountNewOtocoTradeError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1MarginOrderOtocoResponse> MarginAccountNewOtocoTrade(string symbol,
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
        IsIsolated? isIsolated,
        SideEffectType1? sideEffectType,
        bool? autoRepayAtCancel,
        string? listClientOrderId,
        NewOrderRespType? newOrderRespType,
        SelfTradePreventionMode? selfTradePreventionMode,
        string? workingClientOrderId,
        WorkingTimeInForce? workingTimeInForce,
        string? pendingAboveClientOrderId,
        double? pendingAbovePrice,
        double? pendingAboveStopPrice,
        double? pendingAboveTrailingDelta,
        double? pendingAboveIcebergQty,
        PendingAboveTimeInForce? pendingAboveTimeInForce,
        PendingBelowType? pendingBelowType,
        string? pendingBelowClientOrderId,
        double? pendingBelowPrice,
        double? pendingBelowStopPrice,
        double? pendingBelowTrailingDelta,
        double? pendingBelowIcebergQty,
        PendingBelowTimeInForce? pendingBelowTimeInForce,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/order/otoco"),
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
                new Param("isIsolated", isIsolated),
                new Param("sideEffectType", sideEffectType),
                new Param("autoRepayAtCancel", autoRepayAtCancel),
                new Param("listClientOrderId", listClientOrderId),
                new Param("newOrderRespType", newOrderRespType),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("workingClientOrderId", workingClientOrderId),
                new Param("workingTimeInForce", workingTimeInForce),
                new Param("pendingAboveClientOrderId", pendingAboveClientOrderId),
                new Param("pendingAbovePrice", pendingAbovePrice),
                new Param("pendingAboveStopPrice", pendingAboveStopPrice),
                new Param("pendingAboveTrailingDelta", pendingAboveTrailingDelta),
                new Param("pendingAboveIcebergQty", pendingAboveIcebergQty),
                new Param("pendingAboveTimeInForce", pendingAboveTimeInForce),
                new Param("pendingBelowType", pendingBelowType),
                new Param("pendingBelowClientOrderId", pendingBelowClientOrderId),
                new Param("pendingBelowPrice", pendingBelowPrice),
                new Param("pendingBelowStopPrice", pendingBelowStopPrice),
                new Param("pendingBelowTrailingDelta", pendingBelowTrailingDelta),
                new Param("pendingBelowIcebergQty", pendingBelowIcebergQty),
                new Param("pendingBelowTimeInForce", pendingBelowTimeInForce)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderOtocoResponse>(),
            MarginAccountNewOtocoTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin Account New Order (TRADE)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="side"></param>
    /// <param name="type">Order type</param>
    /// <param name="quantity"></param>
    /// <param name="autoRepayAtCancel"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="quoteOrderQty">Quote quantity</param>
    /// <param name="price">Order price</param>
    /// <param name="stopPrice">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
    /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default</param>
    /// <param name="icebergQty">Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order.</param>
    /// <param name="newOrderRespType">Set the response JSON.</param>
    /// <param name="sideEffectType">Default <c>NO_SIDE_EFFECT</c></param>
    /// <param name="timeInForce">Order time in force</param>
    /// <param name="selfTradePreventionMode">The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginAccountNewOrderTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Post a new order for margin account.
    /// <para>
    /// Weight(UID): 6
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginOrderResponse> MarginAccountNewOrderTrade(string symbol,
        Side side,
        Type1 type,
        double quantity,
        bool autoRepayAtCancel,
        long timestamp,
        string signature,
        IsIsolated? isIsolated,
        double? quoteOrderQty,
        double? price,
        double? stopPrice,
        string? newClientOrderId,
        double? icebergQty,
        NewOrderRespType? newOrderRespType,
        SideEffectType? sideEffectType,
        TimeInForce? timeInForce,
        SelfTradePreventionMode? selfTradePreventionMode,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/order"),
            [],
            [new Param("symbol", symbol),
                new Param("side", side),
                new Param("type", type),
                new Param("quantity", quantity),
                new Param("autoRepayAtCancel", autoRepayAtCancel),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("quoteOrderQty", quoteOrderQty),
                new Param("price", price),
                new Param("stopPrice", stopPrice),
                new Param("newClientOrderId", newClientOrderId),
                new Param("icebergQty", icebergQty),
                new Param("newOrderRespType", newOrderRespType),
                new Param("sideEffectType", sideEffectType),
                new Param("timeInForce", timeInForce),
                new Param("selfTradePreventionMode", selfTradePreventionMode),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderResponse>(),
            MarginAccountNewOrderTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin Interest Rate History (USER_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="vipLevel">Defaults to user's vip level</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginInterestRateHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginInterestRateHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The max interval between startTime and endTime is 30 days.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginInterestRateHistoryResponse>> MarginInterestRateHistoryUserData(string asset,
        long timestamp,
        string signature,
        int? vipLevel,
        long? startTime,
        long? endTime,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/interestRateHistory"),
            [],
            [new Param("asset", asset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("vipLevel", vipLevel),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginInterestRateHistoryResponse>>(),
            MarginInterestRateHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin account borrow/repay(MARGIN)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="isIsolated">TRUE for isolated margin, FALSE for crossed margin</param>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="amount"></param>
    /// <param name="type">BORROW or REPAY</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginBorrowRepayResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginAccountBorrowRepayMarginError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Margin account borrow/repay(MARGIN)
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginBorrowRepayResponse> MarginAccountBorrowRepayMargin(string asset,
        string isIsolated,
        string symbol,
        double amount,
        string type,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/borrow-repay"),
            [],
            [new Param("asset", asset),
                new Param("isIsolated", isIsolated),
                new Param("symbol", symbol),
                new Param("amount", amount),
                new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginBorrowRepayResponse>(),
            MarginAccountBorrowRepayMarginErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Margin manual liquidation(MARGIN)
    /// </summary>
    /// <param name="type"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="symbol"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginManualLiquidationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginManualLiquidationMarginError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Margin manual liquidation
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginManualLiquidationResponse>> MarginManualLiquidationMargin(Type4 type,
        long timestamp,
        string signature,
        string? symbol,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/manual-liquidation"),
            [],
            [new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("symbol", symbol)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginManualLiquidationResponse>>(),
            MarginManualLiquidationMarginErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Cross Margin Account Details (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryCrossMarginAccountDetailsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1MarginAccountResponse> QueryCrossMarginAccountDetailsUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/account"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginAccountResponse>(),
            QueryCrossMarginAccountDetailsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Cross Margin Fee Data (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="vipLevel">Defaults to user's vip level</param>
    /// <param name="coin">Coin name</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginCrossMarginDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryCrossMarginFeeDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get cross margin fee data collection with any vip level or user's current specific data as https://www.binance.com/en/margin-fee
    /// <para>
    /// Weight(IP): 1 when coin is specified; 5 when the coin parameter is omitted
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginCrossMarginDataResponse>> QueryCrossMarginFeeDataUserData(long timestamp,
        string signature,
        int? vipLevel,
        string? coin,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/crossMarginData"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("vipLevel", vipLevel),
                new Param("coin", coin),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginCrossMarginDataResponse>>(),
            QueryCrossMarginFeeDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Current Margin Order Count Usage (TRADE)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="symbol">isolated symbol, mandatory for isolated margin</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginRateLimitOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryCurrentMarginOrderCountUsageTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Displays the user's current margin order count usage for all intervals.
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginRateLimitOrderResponse>> QueryCurrentMarginOrderCountUsageTrade(long timestamp,
        string signature,
        string? isIsolated,
        string? symbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/rateLimit/order"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("symbol", symbol),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginRateLimitOrderResponse>>(),
            QueryCurrentMarginOrderCountUsageTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Enabled Isolated Margin Account Limit (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginIsolatedAccountLimitResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryEnabledIsolatedMarginAccountLimitUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query enabled isolated margin account limit.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginIsolatedAccountLimitResponse> QueryEnabledIsolatedMarginAccountLimitUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/isolated/accountLimit"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginIsolatedAccountLimitResponse>(),
            QueryEnabledIsolatedMarginAccountLimitUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Isolated Margin Account Info (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="symbols">Max 5 symbols can be sent; separated by ','</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IsolatedMarginAccountInfo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryIsolatedMarginAccountInfoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If "symbols" is not sent, all isolated assets will be returned.</description></item>
    ///   <item><description>If "symbols" is sent, only the isolated assets of the sent symbols will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IsolatedMarginAccountInfo> QueryIsolatedMarginAccountInfoUserData(long timestamp,
        string signature,
        string? symbols,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/isolated/account"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("symbols", symbols),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IsolatedMarginAccountInfo>(),
            QueryIsolatedMarginAccountInfoUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Isolated Margin Fee Data (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="vipLevel">Defaults to user's vip level</param>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginIsolatedMarginDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryIsolatedMarginFeeDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get isolated margin fee data collection with any vip level or user's current specific data as https://www.binance.com/en/margin-fee
    /// <para>
    /// Weight(IP): 1 when a single is specified; 10 when the symbol parameter is omitted
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginIsolatedMarginDataResponse>> QueryIsolatedMarginFeeDataUserData(long timestamp,
        string signature,
        int? vipLevel,
        string? symbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/isolatedMarginData"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("vipLevel", vipLevel),
                new Param("symbol", symbol),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginIsolatedMarginDataResponse>>(),
            QueryIsolatedMarginFeeDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Isolated Margin Tier Data (USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="tier">All margin tier data will be returned if tier is omitted</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginIsolatedMarginTierResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryIsolatedMarginTierDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get isolated margin tier data collection with any tier as https://www.binance.com/en/margin-data
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginIsolatedMarginTierResponse>> QueryIsolatedMarginTierDataUserData(string symbol,
        long timestamp,
        string signature,
        string? tier,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/isolatedMarginTier"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("tier", tier),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginIsolatedMarginTierResponse>>(),
            QueryIsolatedMarginTierDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Liability Coin Leverage Bracket in Cross Margin Pro Mode (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginLeverageBracketResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Liability Coin Leverage Bracket in Cross Margin Pro Mode
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginLeverageBracketResponse>> QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketData(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/leverageBracket"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginLeverageBracketResponse>>(),
            QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Margin Account's All Orders (USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="orderId">Order id</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="MarginOrderDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMarginAccountSAllOrdersUserDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<MarginOrderDetail>> QueryMarginAccountSAllOrdersUserData(string symbol,
        long timestamp,
        string signature,
        IsIsolated? isIsolated,
        long? orderId,
        long? startTime,
        long? endTime,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/allOrders"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("orderId", orderId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<MarginOrderDetail>>(),
            QueryMarginAccountSAllOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Margin Account's OCO (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="symbol">Mandatory for isolated margin, not supported for cross margin</param>
    /// <param name="orderListId">Order list id</param>
    /// <param name="origClientOrderId">Order id from client</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginOrderListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMarginAccountSOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific OCO based on provided optional parameters
    /// <list type="bullet">
    ///   <item><description>Either <c>orderListId</c> or <c>origClientOrderId</c> must be provided</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginOrderListResponse> QueryMarginAccountSOcoUserData(long timestamp,
        string signature,
        IsIsolated? isIsolated,
        string? symbol,
        long? orderListId,
        string? origClientOrderId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/orderList"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("symbol", symbol),
                new Param("orderListId", orderListId),
                new Param("origClientOrderId", origClientOrderId),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginOrderListResponse>(),
            QueryMarginAccountSOcoUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Margin Account's Open OCO (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="symbol">Mandatory for isolated margin, not supported for cross margin</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginOpenOrderListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMarginAccountSOpenOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginOpenOrderListResponse>> QueryMarginAccountSOpenOcoUserData(long timestamp,
        string signature,
        IsIsolated? isIsolated,
        string? symbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/openOrderList"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("symbol", symbol),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginOpenOrderListResponse>>(),
            QueryMarginAccountSOpenOcoUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Margin Account's Open Orders (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="MarginOrderDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMarginAccountSOpenOrdersUserDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<MarginOrderDetail>> QueryMarginAccountSOpenOrdersUserData(long timestamp,
        string signature,
        string? symbol,
        IsIsolated? isIsolated,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/openOrders"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("symbol", symbol),
                new Param("isIsolated", isIsolated),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<MarginOrderDetail>>(),
            QueryMarginAccountSOpenOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Margin Account's Order (USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="orderId">Order id</param>
    /// <param name="origClientOrderId">Order id from client</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MarginOrderDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMarginAccountSOrderUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Either <c>orderId</c> or <c>origClientOrderId</c> must be sent.</description></item>
    ///   <item><description>For some historical orders <c>cummulativeQuoteQty</c> will be &lt; 0, meaning the data is not available at this time.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<MarginOrderDetail> QueryMarginAccountSOrderUserData(string symbol,
        long timestamp,
        string signature,
        IsIsolated? isIsolated,
        long? orderId,
        string? origClientOrderId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/order"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("orderId", orderId),
                new Param("origClientOrderId", origClientOrderId),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MarginOrderDetail>(),
            QueryMarginAccountSOrderUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Margin Account's Trade List (USER_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="fromId">Trade id to fetch from. Default gets most recent trades.</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="MarginTrade"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMarginAccountSTradeListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If <c>fromId</c> is set, it will get orders &gt;= that <c>fromId</c>. Otherwise most recent trades are returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<MarginTrade>> QueryMarginAccountSTradeListUserData(string symbol,
        long timestamp,
        string signature,
        IsIsolated? isIsolated,
        long? startTime,
        long? endTime,
        long? fromId,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/myTrades"),
            [],
            [new Param("symbol", symbol),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("fromId", fromId),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<MarginTrade>>(),
            QueryMarginAccountSTradeListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Margin Account's all OCO (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isIsolated">* <c>TRUE</c> - For isolated margin * <c>FALSE</c> - Default, not for isolated margin</param>
    /// <param name="symbol">Mandatory for isolated margin, not supported for cross margin</param>
    /// <param name="fromId">If supplied, neither <c>startTime</c> or <c>endTime</c> can be provided</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">Default Value: 500; Max Value: 1000</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1MarginAllOrderListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMarginAccountSAllOcoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves all OCO for a specific margin account based on provided optional parameters
    /// <para>
    /// Weight(IP): 200
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1MarginAllOrderListResponse>> QueryMarginAccountSAllOcoUserData(long timestamp,
        string signature,
        IsIsolated? isIsolated,
        string? symbol,
        string? fromId,
        long? startTime,
        long? endTime,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/allOrderList"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isIsolated", isIsolated),
                new Param("symbol", symbol),
                new Param("fromId", fromId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1MarginAllOrderListResponse>>(),
            QueryMarginAccountSAllOcoUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Margin Available Inventory (USER_DATA)
    /// </summary>
    /// <param name="type"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginAvailableInventoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMarginAvailableInventoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Margin available Inventory query
    /// <para>
    /// Weight(UID): 50
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginAvailableInventoryResponse> QueryMarginAvailableInventoryUserData(Type4 type,
        long timestamp,
        string signature,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/available-inventory"),
            [],
            [new Param("type", type), new Param("timestamp", timestamp), new Param("signature", signature)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginAvailableInventoryResponse>(),
            QueryMarginAvailableInventoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Margin PriceIndex (MARKET_DATA)
    /// </summary>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginPriceIndexResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMarginPriceIndexMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1MarginPriceIndexResponse> QueryMarginPriceIndexMarketData(string symbol,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/priceIndex"),
            [],
            [new Param("symbol", symbol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginPriceIndexResponse>(),
            QueryMarginPriceIndexMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Max Borrow (USER_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isolatedSymbol">Isolated symbol</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginMaxBorrowableResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMaxBorrowUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If <c>isolatedSymbol</c> is not sent, crossed margin data will be sent.</description></item>
    ///   <item><description><c>borrowLimit</c> is also available from https://www.binance.com/en/margin-fee</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginMaxBorrowableResponse> QueryMaxBorrowUserData(string asset,
        long timestamp,
        string signature,
        string? isolatedSymbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/maxBorrowable"),
            [],
            [new Param("asset", asset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isolatedSymbol", isolatedSymbol),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginMaxBorrowableResponse>(),
            QueryMaxBorrowUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Max Transfer-Out Amount (USER_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isolatedSymbol">Isolated symbol</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginMaxTransferableResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryMaxTransferOutAmountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If <c>isolatedSymbol</c> is not sent, crossed margin data will be sent.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<SapiV1MarginMaxTransferableResponse> QueryMaxTransferOutAmountUserData(string asset,
        long timestamp,
        string signature,
        string? isolatedSymbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/maxTransferable"),
            [],
            [new Param("asset", asset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isolatedSymbol", isolatedSymbol),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginMaxTransferableResponse>(),
            QueryMaxTransferOutAmountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query borrow/repay records in Margin account(USER_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="type">BORROW or REPAY</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="isolatedSymbol">Isolated symbol</param>
    /// <param name="txId">tranId in POST /sapi/v1/margin/loan</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MarginBorrowRepayResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryBorrowRepayRecordsInMarginAccountUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1MarginBorrowRepayResponse1> QueryBorrowRepayRecordsInMarginAccountUserData(string asset,
        string type,
        long timestamp,
        string signature,
        string? isolatedSymbol,
        long? txId,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/margin/borrow-repay"),
            [],
            [new Param("asset", asset),
                new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("isolatedSymbol", isolatedSymbol),
                new Param("txId", txId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MarginBorrowRepayResponse1>(),
            QueryBorrowRepayRecordsInMarginAccountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Toggle BNB Burn On Spot Trade And Margin Interest (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="spotBnbBurn">Determines whether to use BNB to pay for trading fees on SPOT</param>
    /// <param name="interestBnbBurn">Determines whether to use BNB to pay for margin loan's interest</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BnbBurnStatus"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>"spotBNBBurn" and "interestBNBBurn" should be sent at least one.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<BnbBurnStatus> ToggleBnbBurnOnSpotTradeAndMarginInterestUserData(long timestamp,
        string signature,
        SpotBnbBurn? spotBnbBurn,
        InterestBnbBurn? interestBnbBurn,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/bnbBurn"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("spotBNBBurn", spotBnbBurn),
                new Param("interestBNBBurn", interestBnbBurn),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<BnbBurnStatus>(),
            ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
