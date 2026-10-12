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
using Binance.Requests.Blvt;

namespace Binance.Api;

/// <summary>
/// Binance Leveraged Tokens Endpoints
/// </summary>
public sealed class Blvt
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Blvt(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BLVT Info (MARKET_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1BlvtTokenInfoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BlvtInfoMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1BlvtTokenInfoResponse>> BlvtInfoMarketData(BlvtInfoMarketDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/blvt/tokenInfo"),
            [],
            [new Param("tokenName", request.TokenName)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1BlvtTokenInfoResponse>>(),
            BlvtInfoMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BLVT User Limit Info (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1BlvtUserLimitResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BlvtUserLimitInfoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1BlvtUserLimitResponse>> BlvtUserLimitInfoUserData(BlvtUserLimitInfoUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/blvt/userLimit"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("tokenName", request.TokenName),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1BlvtUserLimitResponse>>(),
            BlvtUserLimitInfoUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Subscription Record (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1BlvtSubscribeRecordResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QuerySubscriptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Only the data of the latest 90 days is available</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1BlvtSubscribeRecordResponse> QuerySubscriptionRecordUserData(QuerySubscriptionRecordUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/blvt/subscribe/record"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("tokenName", request.TokenName),
                new Param("id", request.Id),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1BlvtSubscribeRecordResponse>(),
            QuerySubscriptionRecordUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Redeem BLVT (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1BlvtRedeemResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RedeemBlvtUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1BlvtRedeemResponse> RedeemBlvtUserData(RedeemBlvtUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/blvt/redeem"),
            [],
            [
                new Param("tokenName", request.TokenName),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1BlvtRedeemResponse>(),
            RedeemBlvtUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Redemption Record (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1BlvtRedeemRecordResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RedemptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Only the data of the latest 90 days is available</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1BlvtRedeemRecordResponse>> RedemptionRecordUserData(RedemptionRecordUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/blvt/redeem/record"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("tokenName", request.TokenName),
                new Param("id", request.Id),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1BlvtRedeemRecordResponse>>(),
            RedemptionRecordUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Subscribe BLVT (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1BlvtSubscribeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubscribeBlvtUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1BlvtSubscribeResponse> SubscribeBlvtUserData(SubscribeBlvtUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/blvt/subscribe"),
            [],
            [
                new Param("tokenName", request.TokenName),
                new Param("cost", request.Cost),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1BlvtSubscribeResponse>(),
            SubscribeBlvtUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
