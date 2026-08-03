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

public sealed class DualInvestment
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DualInvestment(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Change Auto-Compound status(USER_DATA)
    /// </summary>
    /// <param name="positionId">Get positionId from /sapi/v1/dci/product/positions</param>
    /// <param name="autoCompoundPlan">NONE: switch off the plan, STANDARD: standard plan, ADVANCED: advanced plan;</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductAutoCompoundEditStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ChangeAutoCompoundStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Change Auto-Compound status
    /// <list type="bullet">
    ///   <item><description>15:31 ~ 16:00 UTC+8 This function is disabled</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// <para>
    /// Rate Limit: Maximum 1 time/s per account
    /// </para>
    /// </remarks>
    public Task<SapiV1DciProductAutoCompoundEditStatusResponse> ChangeAutoCompoundStatusUserData(long positionId,
        AutoCompoundPlan autoCompoundPlan,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/dci/product/auto_compound/edit-status"),
            [],
            [new Param("positionId", positionId),
                new Param("autoCompoundPlan", autoCompoundPlan),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductAutoCompoundEditStatusResponse>(),
            ChangeAutoCompoundStatusUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Check Dual Investment accounts(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductAccountsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckDualInvestmentAccountsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Check Dual Investment accounts
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1DciProductAccountsResponse> CheckDualInvestmentAccountsUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/dci/product/accounts"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductAccountsResponse>(),
            CheckDualInvestmentAccountsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Dual Investment positions(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="status">- PENDING: Products are purchasing, will give results later; - PURCHASE_SUCCESS: purchase successfully; - SETTLED: Products are finish settling; - PURCHASE_FAIL: fail to purchase; - REFUNDING: refund ongoing; - REFUND_SUCCESS: refund to spot account successfully; - SETTLING: Products are settling. If don't fill this field, will response all the position status.</param>
    /// <param name="pageSize">MIN 1, MAX 100; Default 100</param>
    /// <param name="pageIndex">Page number, default is first page, start form 1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductPositionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDualInvestmentPositionsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Dual Investment positions (batch)
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1DciProductPositionsResponse> GetDualInvestmentPositionsUserData(long timestamp,
        string signature,
        Status2? status,
        string? pageSize,
        int? pageIndex,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/dci/product/positions"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("status", status),
                new Param("pageSize", pageSize),
                new Param("pageIndex", pageIndex),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductPositionsResponse>(),
            GetDualInvestmentPositionsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Dual Investment product list(USER_DATA)
    /// </summary>
    /// <param name="optionType">Input CALL or PUT</param>
    /// <param name="exercisedCoin">Target exercised asset, e.g.: if you subscribe to a high sell product (call option), you should input:   - optionType: CALL,   - exercisedCoin: USDT,   - investCoin: BNB;  if you subscribe to a low buy product (put option), you should input:   - optionType: PUT,   - exercisedCoin: BNB,   - investCoin: USDT;</param>
    /// <param name="investCoin">Asset used for subscribing, e.g.: if you subscribe to a high sell product (call option), you should input:   - optionType: CALL,   - exercisedCoin: USDT,   - investCoin: BNB;  if you subscribe to a low buy product (put option), you should input:   - optionType: PUT,   - exercisedCoin: BNB,   - investCoin: USDT;</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="pageSize">MIN 1, MAX 100; Default 100</param>
    /// <param name="pageIndex">Page number, default is first page, start form 1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDualInvestmentProductListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Dual Investment product list
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1DciProductListResponse> GetDualInvestmentProductListUserData(OptionType optionType,
        string exercisedCoin,
        string investCoin,
        long timestamp,
        string signature,
        string? pageSize,
        int? pageIndex,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/dci/product/list"),
            [],
            [new Param("optionType", optionType),
                new Param("exercisedCoin", exercisedCoin),
                new Param("investCoin", investCoin),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("pageSize", pageSize),
                new Param("pageIndex", pageIndex),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductListResponse>(),
            GetDualInvestmentProductListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe Dual Investment products(USER_DATA)
    /// </summary>
    /// <param name="id">get id from /sapi/v1/dci/product/list</param>
    /// <param name="orderId">get orderId from /sapi/v1/dci/product/list</param>
    /// <param name="depositAmount"></param>
    /// <param name="autoCompoundPlan">NONE: switch off the plan, STANDARD: standard plan, ADVANCED: advanced plan;</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductSubscribeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubscribeDualInvestmentProductsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Subscribe Dual Investment products
    /// <list type="bullet">
    ///   <item><description><c>Products are not available.</c> means that the APR changes to lower value, or the orders are not available.</description></item>
    ///   <item><description><c>Failed</c> is a system or network errors.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1DciProductSubscribeResponse> SubscribeDualInvestmentProductsUserData(string id,
        string orderId,
        double depositAmount,
        AutoCompoundPlan autoCompoundPlan,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/dci/product/subscribe"),
            [],
            [new Param("id", id),
                new Param("orderId", orderId),
                new Param("depositAmount", depositAmount),
                new Param("autoCompoundPlan", autoCompoundPlan),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductSubscribeResponse>(),
            SubscribeDualInvestmentProductsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
