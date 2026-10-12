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
using Binance.Requests.SimpleEarn;

namespace Binance.Api;

/// <summary>
/// Simple Earn Endpoints
/// </summary>
public sealed class SimpleEarn
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SimpleEarn(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Collateral Record (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCollateralRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse> GetCollateralRecordUserData(GetCollateralRecordUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/history/collateralRecord"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("productId", request.ProductId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse>(),
            GetCollateralRecordUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Flexible Personal Left Quota (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFlexiblePersonalLeftQuotaUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse> GetFlexiblePersonalLeftQuotaUserData(GetFlexiblePersonalLeftQuotaUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/personalLeftQuota"),
            [],
            [
                new Param("productId", request.ProductId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse>(),
            GetFlexiblePersonalLeftQuotaUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Flexible Product Position (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexiblePositionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFlexibleProductPositionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexiblePositionResponse> GetFlexibleProductPositionUserData(GetFlexibleProductPositionUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/position"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("productId", request.ProductId),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexiblePositionResponse>(),
            GetFlexibleProductPositionUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Flexible Redemption Record (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFlexibleRedemptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse> GetFlexibleRedemptionRecordUserData(GetFlexibleRedemptionRecordUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/history/redemptionRecord"),
            [],
            [
                new Param("productId", request.ProductId),
                new Param("redeemId", request.RedeemId),
                new Param("asset", request.Asset),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse>(),
            GetFlexibleRedemptionRecordUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Flexible Rewards History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFlexibleRewardsHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse> GetFlexibleRewardsHistoryUserData(GetFlexibleRewardsHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/history/rewardsRecord"),
            [],
            [
                new Param("type", request.Type),
                new Param("productId", request.ProductId),
                new Param("asset", request.Asset),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse>(),
            GetFlexibleRewardsHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Flexible Subscription Preview (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFlexibleSubscriptionPreviewUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse> GetFlexibleSubscriptionPreviewUserData(GetFlexibleSubscriptionPreviewUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/subscriptionPreview"),
            [],
            [
                new Param("productId", request.ProductId),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse>(),
            GetFlexibleSubscriptionPreviewUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Flexible Subscription Record (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFlexibleSubscriptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse> GetFlexibleSubscriptionRecordUserData(GetFlexibleSubscriptionRecordUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/history/subscriptionRecord"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("productId", request.ProductId),
                new Param("purchaseId", request.PurchaseId),
                new Param("asset", request.Asset),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse>(),
            GetFlexibleSubscriptionRecordUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Locked Personal Left Quota (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedPersonalLeftQuotaResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLockedPersonalLeftQuotaUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedPersonalLeftQuotaResponse> GetLockedPersonalLeftQuotaUserData(GetLockedPersonalLeftQuotaUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/personalLeftQuota"),
            [],
            [
                new Param("projectId", request.ProjectId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedPersonalLeftQuotaResponse>(),
            GetLockedPersonalLeftQuotaUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Locked Product Position (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedPositionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLockedProductPositionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedPositionResponse> GetLockedProductPositionUserData(GetLockedProductPositionUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/position"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("positionId", request.PositionId),
                new Param("projectId", request.ProjectId),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedPositionResponse>(),
            GetLockedProductPositionUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Locked Redemption Record (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLockedRedemptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse> GetLockedRedemptionRecordUserData(GetLockedRedemptionRecordUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/history/redemptionRecord"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("positionId", request.PositionId),
                new Param("redeemId", request.RedeemId),
                new Param("asset", request.Asset),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse>(),
            GetLockedRedemptionRecordUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Locked Rewards History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedHistoryRewardsRecordResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLockedRewardsHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedHistoryRewardsRecordResponse> GetLockedRewardsHistoryUserData(GetLockedRewardsHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/history/rewardsRecord"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("positionId", request.PositionId),
                new Param("asset", request.Asset),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedHistoryRewardsRecordResponse>(),
            GetLockedRewardsHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Locked Subscription Preview (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SimpleEarnLockedSubscriptionPreviewResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLockedSubscriptionPreviewUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SimpleEarnLockedSubscriptionPreviewResponse>> GetLockedSubscriptionPreviewUserData(GetLockedSubscriptionPreviewUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/subscriptionPreview"),
            [],
            [
                new Param("projectId", request.ProjectId),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("autoSubscribe", request.AutoSubscribe),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SimpleEarnLockedSubscriptionPreviewResponse>>(),
            GetLockedSubscriptionPreviewUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Locked Subscription Record (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLockedSubscriptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse> GetLockedSubscriptionRecordUserData(GetLockedSubscriptionRecordUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/history/subscriptionRecord"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("purchaseId", request.PurchaseId),
                new Param("asset", request.Asset),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse>(),
            GetLockedSubscriptionRecordUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Rate History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetRateHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse> GetRateHistoryUserData(GetRateHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/history/rateHistory"),
            [],
            [
                new Param("productId", request.ProductId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse>(),
            GetRateHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Simple Earn Flexible Product List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSimpleEarnFlexibleProductListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get available Simple Earn flexible product list
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleListResponse> GetSimpleEarnFlexibleProductListUserData(GetSimpleEarnFlexibleProductListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/list"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleListResponse>(),
            GetSimpleEarnFlexibleProductListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Simple Earn Locked Product List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSimpleEarnLockedProductListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedListResponse> GetSimpleEarnLockedProductListUserData(GetSimpleEarnLockedProductListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/list"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedListResponse>(),
            GetSimpleEarnLockedProductListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Redeem Flexible Product (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleRedeemResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RedeemFlexibleProductTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// <para>
    /// Rate Limit: 1/3s per account
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleRedeemResponse> RedeemFlexibleProductTrade(RedeemFlexibleProductTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/redeem"),
            [],
            [
                new Param("productId", request.ProductId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("redeemAll", request.RedeemAll),
                new Param("amount", request.Amount),
                new Param("destAccount", request.DestAccount),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleRedeemResponse>(),
            RedeemFlexibleProductTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Redeem Locked Product (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedRedeemResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RedeemLockedProductTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// <para>
    /// Rate Limit: 1/3s per account
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedRedeemResponse> RedeemLockedProductTrade(RedeemLockedProductTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/redeem"),
            [],
            [
                new Param("positionId", request.PositionId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedRedeemResponse>(),
            RedeemLockedProductTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Set Flexible Auto Subscribe (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SetFlexibleAutoSubscribeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse> SetFlexibleAutoSubscribeUserData(SetFlexibleAutoSubscribeUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/setAutoSubscribe"),
            [],
            [
                new Param("productId", request.ProductId),
                new Param("autoSubscribe", request.AutoSubscribe),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse>(),
            SetFlexibleAutoSubscribeUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Set Locked Auto Subscribe (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedSetAutoSubscribeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SetLockedAutoSubscribeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedSetAutoSubscribeResponse> SetLockedAutoSubscribeUserData(SetLockedAutoSubscribeUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/setAutoSubscribe"),
            [],
            [
                new Param("positionId", request.PositionId),
                new Param("autoSubscribe", request.AutoSubscribe),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedSetAutoSubscribeResponse>(),
            SetLockedAutoSubscribeUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Set Locked Product Redeem Option(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedSetRedeemOptionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SetLockedProductRedeemOptionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set redeem option for Locked product
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedSetRedeemOptionResponse> SetLockedProductRedeemOptionUserData(SetLockedProductRedeemOptionUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/setRedeemOption"),
            [],
            [
                new Param("positionId", request.PositionId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("redeemTo", request.RedeemTo),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedSetRedeemOptionResponse>(),
            SetLockedProductRedeemOptionUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Simple Account (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SimpleAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnAccountResponse> SimpleAccountUserData(SimpleAccountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/account"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnAccountResponse>(),
            SimpleAccountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Subscribe Flexible Product (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleSubscribeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubscribeFlexibleProductTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// <para>
    /// Rate Limit: 1/3s per account
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleSubscribeResponse> SubscribeFlexibleProductTrade(SubscribeFlexibleProductTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/flexible/subscribe"),
            [],
            [
                new Param("productId", request.ProductId),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("autoSubscribe", request.AutoSubscribe),
                new Param("sourceAccount", request.SourceAccount),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleSubscribeResponse>(),
            SubscribeFlexibleProductTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Subscribe Locked Product (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedSubscribeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubscribeLockedProductTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// <para>
    /// Rate Limit: 1/3s per account
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedSubscribeResponse> SubscribeLockedProductTrade(SubscribeLockedProductTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/simple-earn/locked/subscribe"),
            [],
            [
                new Param("projectId", request.ProjectId),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("autoSubscribe", request.AutoSubscribe),
                new Param("sourceAccount", request.SourceAccount),
                new Param("redeemTo", request.RedeemTo),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedSubscribeResponse>(),
            SubscribeLockedProductTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
