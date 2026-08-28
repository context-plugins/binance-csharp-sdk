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
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="productId"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCollateralRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse> GetCollateralRecordUserData(long timestamp,
        string signature,
        string? productId,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/history/collateralRecord"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("productId", productId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse>(),
            GetCollateralRecordUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Flexible Personal Left Quota (USER_DATA)
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFlexiblePersonalLeftQuotaUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse> GetFlexiblePersonalLeftQuotaUserData(string productId,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/personalLeftQuota"),
            [],
            [new Param("productId", productId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse>(),
            GetFlexiblePersonalLeftQuotaUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Flexible Product Position (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="productId"></param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexiblePositionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFlexibleProductPositionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexiblePositionResponse> GetFlexibleProductPositionUserData(long timestamp,
        string signature,
        string? asset,
        string? productId,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/position"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("productId", productId),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexiblePositionResponse>(),
            GetFlexibleProductPositionUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Flexible Redemption Record (USER_DATA)
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="redeemId"></param>
    /// <param name="asset"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFlexibleRedemptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse> GetFlexibleRedemptionRecordUserData(string? productId,
        string? redeemId,
        string? asset,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/history/redemptionRecord"),
            [],
            [new Param("productId", productId),
                new Param("redeemId", redeemId),
                new Param("asset", asset),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistoryRedemptionRecordResponse>(),
            GetFlexibleRedemptionRecordUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Flexible Rewards History (USER_DATA)
    /// </summary>
    /// <param name="type">"BONUS", "REALTIME", "REWARDS"</param>
    /// <param name="productId"></param>
    /// <param name="asset"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFlexibleRewardsHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse> GetFlexibleRewardsHistoryUserData(string type,
        string? productId,
        string? asset,
        long? startTime,
        long? endTime,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/history/rewardsRecord"),
            [],
            [new Param("type", type),
                new Param("productId", productId),
                new Param("asset", asset),
                new Param("startTime", startTime),
                new Param("endTime", endTime)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse>(),
            GetFlexibleRewardsHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Flexible Subscription Preview (USER_DATA)
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFlexibleSubscriptionPreviewUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse> GetFlexibleSubscriptionPreviewUserData(string productId,
        double amount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/subscriptionPreview"),
            [],
            [new Param("productId", productId),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse>(),
            GetFlexibleSubscriptionPreviewUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Flexible Subscription Record (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="productId"></param>
    /// <param name="purchaseId"></param>
    /// <param name="asset"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFlexibleSubscriptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse> GetFlexibleSubscriptionRecordUserData(long timestamp,
        string signature,
        string? productId,
        string? purchaseId,
        string? asset,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/history/subscriptionRecord"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("productId", productId),
                new Param("purchaseId", purchaseId),
                new Param("asset", asset),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse>(),
            GetFlexibleSubscriptionRecordUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Locked Personal Left Quota (USER_DATA)
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedPersonalLeftQuotaResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLockedPersonalLeftQuotaUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedPersonalLeftQuotaResponse> GetLockedPersonalLeftQuotaUserData(string projectId,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/personalLeftQuota"),
            [],
            [new Param("projectId", projectId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedPersonalLeftQuotaResponse>(),
            GetLockedPersonalLeftQuotaUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Locked Product Position (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="positionId"></param>
    /// <param name="projectId"></param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedPositionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLockedProductPositionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedPositionResponse> GetLockedProductPositionUserData(long timestamp,
        string signature,
        string? asset,
        string? positionId,
        string? projectId,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/position"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("positionId", positionId),
                new Param("projectId", projectId),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedPositionResponse>(),
            GetLockedProductPositionUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Locked Redemption Record (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="positionId"></param>
    /// <param name="redeemId"></param>
    /// <param name="asset"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLockedRedemptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse> GetLockedRedemptionRecordUserData(long timestamp,
        string signature,
        string? positionId,
        string? redeemId,
        string? asset,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/history/redemptionRecord"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("positionId", positionId),
                new Param("redeemId", redeemId),
                new Param("asset", asset),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedHistoryRedemptionRecordResponse>(),
            GetLockedRedemptionRecordUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Locked Rewards History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="positionId"></param>
    /// <param name="asset"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedHistoryRewardsRecordResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLockedRewardsHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedHistoryRewardsRecordResponse> GetLockedRewardsHistoryUserData(long timestamp,
        string signature,
        string? positionId,
        string? asset,
        long? startTime,
        long? endTime,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/history/rewardsRecord"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("positionId", positionId),
                new Param("asset", asset),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedHistoryRewardsRecordResponse>(),
            GetLockedRewardsHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Locked Subscription Preview (USER_DATA)
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="autoSubscribe">true or false, default true.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SimpleEarnLockedSubscriptionPreviewResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLockedSubscriptionPreviewUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SimpleEarnLockedSubscriptionPreviewResponse>> GetLockedSubscriptionPreviewUserData(string projectId,
        double amount,
        long timestamp,
        string signature,
        bool? autoSubscribe,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/subscriptionPreview"),
            [],
            [new Param("projectId", projectId),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("autoSubscribe", autoSubscribe),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SimpleEarnLockedSubscriptionPreviewResponse>>(),
            GetLockedSubscriptionPreviewUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Locked Subscription Record (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="purchaseId"></param>
    /// <param name="asset"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLockedSubscriptionRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse> GetLockedSubscriptionRecordUserData(long timestamp,
        string signature,
        string? purchaseId,
        string? asset,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/history/subscriptionRecord"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("purchaseId", purchaseId),
                new Param("asset", asset),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse>(),
            GetLockedSubscriptionRecordUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Rate History (USER_DATA)
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetRateHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse> GetRateHistoryUserData(string productId,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/history/rateHistory"),
            [],
            [new Param("productId", productId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse>(),
            GetRateHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Simple Earn Flexible Product List (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSimpleEarnFlexibleProductListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get available Simple Earn flexible product list
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleListResponse> GetSimpleEarnFlexibleProductListUserData(long timestamp,
        string signature,
        string? asset,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/list"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleListResponse>(),
            GetSimpleEarnFlexibleProductListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Simple Earn Locked Product List (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSimpleEarnLockedProductListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedListResponse> GetSimpleEarnLockedProductListUserData(long timestamp,
        string signature,
        string? asset,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/list"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedListResponse>(),
            GetSimpleEarnLockedProductListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Redeem Flexible Product (TRADE)
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="redeemAll">true or false, default to false</param>
    /// <param name="amount">if redeemAll is false, amount is mandatory</param>
    /// <param name="destAccount">SPOT,FUND,ALL, default SPOT</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleRedeemResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RedeemFlexibleProductTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// <para>
    /// Rate Limit: 1/3s per account
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleRedeemResponse> RedeemFlexibleProductTrade(string productId,
        long timestamp,
        string signature,
        bool? redeemAll,
        double? amount,
        string? destAccount,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/redeem"),
            [],
            [new Param("productId", productId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("redeemAll", redeemAll),
                new Param("amount", amount),
                new Param("destAccount", destAccount),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleRedeemResponse>(),
            RedeemFlexibleProductTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Redeem Locked Product (TRADE)
    /// </summary>
    /// <param name="positionId">1234</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedRedeemResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RedeemLockedProductTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// <para>
    /// Rate Limit: 1/3s per account
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedRedeemResponse> RedeemLockedProductTrade(string positionId,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/redeem"),
            [],
            [new Param("positionId", positionId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedRedeemResponse>(),
            RedeemLockedProductTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Set Flexible Auto Subscribe (USER_DATA)
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="autoSubscribe">true or false</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetFlexibleAutoSubscribeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse> SetFlexibleAutoSubscribeUserData(string productId,
        bool autoSubscribe,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/setAutoSubscribe"),
            [],
            [new Param("productId", productId),
                new Param("autoSubscribe", autoSubscribe),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse>(),
            SetFlexibleAutoSubscribeUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Set Locked Auto Subscribe (USER_DATA)
    /// </summary>
    /// <param name="positionId"></param>
    /// <param name="autoSubscribe">true or false</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedSetAutoSubscribeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetLockedAutoSubscribeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedSetAutoSubscribeResponse> SetLockedAutoSubscribeUserData(string positionId,
        bool autoSubscribe,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/setAutoSubscribe"),
            [],
            [new Param("positionId", positionId),
                new Param("autoSubscribe", autoSubscribe),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedSetAutoSubscribeResponse>(),
            SetLockedAutoSubscribeUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Set Locked Product Redeem Option(USER_DATA)
    /// </summary>
    /// <param name="positionId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="redeemTo">SPOT,FLEXIBLE, default FLEXIBLE</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedSetRedeemOptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetLockedProductRedeemOptionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set redeem option for Locked product
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedSetRedeemOptionResponse> SetLockedProductRedeemOptionUserData(string positionId,
        long timestamp,
        string signature,
        RedeemTo? redeemTo,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/setRedeemOption"),
            [],
            [new Param("positionId", positionId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("redeemTo", redeemTo),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedSetRedeemOptionResponse>(),
            SetLockedProductRedeemOptionUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Simple Account (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SimpleAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1SimpleEarnAccountResponse> SimpleAccountUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/account"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnAccountResponse>(),
            SimpleAccountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe Flexible Product (TRADE)
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="autoSubscribe">true or false, default true.</param>
    /// <param name="sourceAccount">SPOT,FUND,ALL, default SPOT</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnFlexibleSubscribeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubscribeFlexibleProductTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// <para>
    /// Rate Limit: 1/3s per account
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnFlexibleSubscribeResponse> SubscribeFlexibleProductTrade(string productId,
        double amount,
        long timestamp,
        string signature,
        bool? autoSubscribe,
        string? sourceAccount,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/flexible/subscribe"),
            [],
            [new Param("productId", productId),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("autoSubscribe", autoSubscribe),
                new Param("sourceAccount", sourceAccount),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnFlexibleSubscribeResponse>(),
            SubscribeFlexibleProductTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe Locked Product (TRADE)
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="autoSubscribe">true or false, default true.</param>
    /// <param name="sourceAccount">SPOT,FUND,ALL, default SPOT</param>
    /// <param name="redeemTo">SPOT,FLEXIBLE, default FLEXIBLE</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SimpleEarnLockedSubscribeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubscribeLockedProductTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// <para>
    /// Rate Limit: 1/3s per account
    /// </para>
    /// </remarks>
    public Task<SapiV1SimpleEarnLockedSubscribeResponse> SubscribeLockedProductTrade(string projectId,
        double amount,
        long timestamp,
        string signature,
        bool? autoSubscribe,
        string? sourceAccount,
        RedeemTo? redeemTo,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/simple-earn/locked/subscribe"),
            [],
            [new Param("projectId", projectId),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("autoSubscribe", autoSubscribe),
                new Param("sourceAccount", sourceAccount),
                new Param("redeemTo", redeemTo),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SimpleEarnLockedSubscribeResponse>(),
            SubscribeLockedProductTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
