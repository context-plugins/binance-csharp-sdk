using System;
using System.Collections.Generic;
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

/// <summary>
/// Auto-Invest Endpoints
/// </summary>
public sealed class AutoInvest
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AutoInvest(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Change Plan Status
    /// </summary>
    /// <param name="planId"></param>
    /// <param name="status"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanEditStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ChangePlanStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Change Plan Status
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanEditStatusResponse> ChangePlanStatus(int planId,
        Status1 status,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/plan/edit-status"),
            [],
            [new Param("planId", planId),
                new Param("status", status),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanEditStatusResponse>(),
            ChangePlanStatusErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get list of plans
    /// </summary>
    /// <param name="planType"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetListOfPlansError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query plan lists
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanListResponse> GetListOfPlans(string planType,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/plan/list"),
            [],
            [new Param("planType", planType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanListResponse>(),
            GetListOfPlansErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get target asset ROI data (USER_DATA)
    /// </summary>
    /// <param name="targetAsset"></param>
    /// <param name="hisRoiType"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingAutoInvestTargetAssetRoiListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTargetAssetRoiDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// ROI return list for target asset
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingAutoInvestTargetAssetRoiListResponse>> GetTargetAssetRoiDataUserData(string targetAsset,
        string hisRoiType,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/target-asset/roi/list"),
            [],
            [new Param("targetAsset", targetAsset),
                new Param("hisRoiType", hisRoiType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingAutoInvestTargetAssetRoiListResponse>>(),
            GetTargetAssetRoiDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get target asset list (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="targetAsset"></param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestTargetAssetListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTargetAssetListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1LendingAutoInvestTargetAssetListResponse> GetTargetAssetListUserData(long timestamp,
        string signature,
        string? targetAsset,
        int? size,
        int? current,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/target-asset/list"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("targetAsset", targetAsset),
                new Param("size", size),
                new Param("current", current),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestTargetAssetListResponse>(),
            GetTargetAssetListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Index Linked Plan Rebalance Details (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingAutoInvestRebalanceHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="IndexLinkedPlanRebalanceDetailsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the history of Index Linked Plan Redemption transactions
    /// <para>
    /// Max 30 day difference between startTime and endTime
    /// If no startTime and endTime, default to show past 30 day records
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingAutoInvestRebalanceHistoryResponse>> IndexLinkedPlanRebalanceDetailsUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/rebalance/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingAutoInvestRebalanceHistoryResponse>>(),
            IndexLinkedPlanRebalanceDetailsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Index Linked Plan Redemption (TRADE)
    /// </summary>
    /// <param name="indexId">PORTFOLIO plan's Id</param>
    /// <param name="redemptionPercentage">user redeem percentage,10/20/100.</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="requestId">sourceType + unique, transactionId and requestId cannot be empty at the same time</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestRedeemResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="IndexLinkedPlanRedemptionTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To redeem index-Linked plan holdings
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestRedeemResponse> IndexLinkedPlanRedemptionTrade(long indexId,
        int redemptionPercentage,
        long timestamp,
        string signature,
        string? requestId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/redeem"),
            [],
            [new Param("indexId", indexId),
                new Param("redemptionPercentage", redemptionPercentage),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("requestId", requestId),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestRedeemResponse>(),
            IndexLinkedPlanRedemptionTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Index Linked Plan Redemption History (USER_DATA)
    /// </summary>
    /// <param name="requestId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="asset"></param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingAutoInvestRedeemHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="IndexLinkedPlanRedemptionHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the history of Index Linked Plan Redemption transactions
    /// <para>
    /// Max 30 day difference between startTime and endTime
    /// If no startTime and endTime, default to show past 30 day records
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingAutoInvestRedeemHistoryResponse>> IndexLinkedPlanRedemptionHistoryUserData(long requestId,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        string? asset,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/redeem/history"),
            [],
            [new Param("requestId", requestId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("asset", asset),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingAutoInvestRedeemHistoryResponse>>(),
            IndexLinkedPlanRedemptionHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Investment plan adjustment
    /// </summary>
    /// <param name="planId"></param>
    /// <param name="subscriptionAmount"></param>
    /// <param name="subscriptionCycle"></param>
    /// <param name="subscriptionStartTime"></param>
    /// <param name="sourceAsset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="subscriptionStartDay"></param>
    /// <param name="subscriptionStartWeekday"></param>
    /// <param name="flexibleAllowedToUse"></param>
    /// <param name="details"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanEditResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InvestmentPlanAdjustmentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Source Asset to be used for investment
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanEditResponse> InvestmentPlanAdjustment(int planId,
        double subscriptionAmount,
        SubscriptionCycle subscriptionCycle,
        int subscriptionStartTime,
        string sourceAsset,
        long timestamp,
        string signature,
        int? subscriptionStartDay,
        SubscriptionStartWeekday? subscriptionStartWeekday,
        bool? flexibleAllowedToUse,
        IReadOnlyList<Detail1>? details,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/plan/edit"),
            [],
            [new Param("planId", planId),
                new Param("subscriptionAmount", subscriptionAmount),
                new Param("subscriptionCycle", subscriptionCycle),
                new Param("subscriptionStartTime", subscriptionStartTime),
                new Param("sourceAsset", sourceAsset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("subscriptionStartDay", subscriptionStartDay),
                new Param("subscriptionStartWeekday", subscriptionStartWeekday),
                new Param("flexibleAllowedToUse", flexibleAllowedToUse),
                new Param("details", details),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanEditResponse>(),
            InvestmentPlanAdjustmentErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Investment plan creation (USER_DATA)
    /// </summary>
    /// <param name="sourceType"></param>
    /// <param name="planType"></param>
    /// <param name="subscriptionAmount"></param>
    /// <param name="subscriptionCycle"></param>
    /// <param name="subscriptionStartTime"></param>
    /// <param name="sourceAsset"></param>
    /// <param name="details"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="requestId"></param>
    /// <param name="indexId"></param>
    /// <param name="subscriptionStartDay"></param>
    /// <param name="subscriptionStartWeekday"></param>
    /// <param name="flexibleAllowedToUse"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanAddResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InvestmentPlanCreationUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Post an investment plan creation
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanAddResponse> InvestmentPlanCreationUserData(SourceType sourceType,
        PlanType planType,
        double subscriptionAmount,
        SubscriptionCycle subscriptionCycle,
        int subscriptionStartTime,
        string sourceAsset,
        IReadOnlyList<Detail1> details,
        long timestamp,
        string signature,
        string? requestId,
        long? indexId,
        int? subscriptionStartDay,
        SubscriptionStartWeekday? subscriptionStartWeekday,
        bool? flexibleAllowedToUse,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/plan/add"),
            [],
            [new Param("sourceType", sourceType),
                new Param("planType", planType),
                new Param("subscriptionAmount", subscriptionAmount),
                new Param("subscriptionCycle", subscriptionCycle),
                new Param("subscriptionStartTime", subscriptionStartTime),
                new Param("sourceAsset", sourceAsset),
                new Param("details", details),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("requestId", requestId),
                new Param("IndexId", indexId),
                new Param("subscriptionStartDay", subscriptionStartDay),
                new Param("subscriptionStartWeekday", subscriptionStartWeekday),
                new Param("flexibleAllowedToUse", flexibleAllowedToUse),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanAddResponse>(),
            InvestmentPlanCreationUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// One Time Transaction(TRADE)
    /// </summary>
    /// <param name="sourceType"></param>
    /// <param name="subscriptionAmount"></param>
    /// <param name="sourceAsset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="requestId"></param>
    /// <param name="flexibleAllowedToUse"></param>
    /// <param name="planId"></param>
    /// <param name="indexId"></param>
    /// <param name="details"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestOneOffResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OneTimeTransactionTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// One time transaction
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestOneOffResponse> OneTimeTransactionTrade(string sourceType,
        double subscriptionAmount,
        string sourceAsset,
        long timestamp,
        string signature,
        string? requestId,
        bool? flexibleAllowedToUse,
        long? planId,
        long? indexId,
        IReadOnlyList<Detail5>? details,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/one-off"),
            [],
            [new Param("sourceType", sourceType),
                new Param("subscriptionAmount", subscriptionAmount),
                new Param("sourceAsset", sourceAsset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("requestId", requestId),
                new Param("flexibleAllowedToUse", flexibleAllowedToUse),
                new Param("planId", planId),
                new Param("indexId", indexId),
                new Param("details", details),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestOneOffResponse>(),
            OneTimeTransactionTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Index Details(USER_DATA)
    /// </summary>
    /// <param name="indexId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestIndexInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryIndexDetailsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query index details
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestIndexInfoResponse> QueryIndexDetailsUserData(long indexId,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/index/info"),
            [],
            [new Param("indexId", indexId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestIndexInfoResponse>(),
            QueryIndexDetailsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Index Linked Plan Position Details(USER_DATA)
    /// </summary>
    /// <param name="indexId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestIndexUserSummaryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryIndexLinkedPlanPositionDetailsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Details on users Index-Linked plan position details
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestIndexUserSummaryResponse> QueryIndexLinkedPlanPositionDetailsUserData(long indexId,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/index/user-summary"),
            [],
            [new Param("indexId", indexId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestIndexUserSummaryResponse>(),
            QueryIndexLinkedPlanPositionDetailsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query One-Time Transaction Status (USER_DATA)
    /// </summary>
    /// <param name="transactionId"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="requestId"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestOneOffStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryOneTimeTransactionStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transaction status for one-time transaction
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestOneOffStatusResponse> QueryOneTimeTransactionStatusUserData(long transactionId,
        long timestamp,
        string signature,
        string? requestId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/one-off/status"),
            [],
            [new Param("transactionId", transactionId),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("requestId", requestId),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestOneOffStatusResponse>(),
            QueryOneTimeTransactionStatusUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query all source asset and target asset (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestAllAssetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryAllSourceAssetAndTargetAssetUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query all source assets and target assets
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestAllAssetResponse> QueryAllSourceAssetAndTargetAssetUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/all/asset"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestAllAssetResponse>(),
            QueryAllSourceAssetAndTargetAssetUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query holding details of the plan
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="planId"></param>
    /// <param name="requestId"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryHoldingDetailsOfThePlanError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query holding details of the plan
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanIdResponse> QueryHoldingDetailsOfThePlan(long timestamp,
        string signature,
        long? planId,
        string? requestId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/plan/id"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("planId", planId),
                new Param("requestId", requestId),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanIdResponse>(),
            QueryHoldingDetailsOfThePlanErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query source asset list (USER_DATA)
    /// </summary>
    /// <param name="usageType"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="targetAsset"></param>
    /// <param name="indexId"></param>
    /// <param name="flexibleAllowedToUse"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestSourceAssetListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QuerySourceAssetListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Source Asset to be used for investment
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestSourceAssetListResponse> QuerySourceAssetListUserData(string usageType,
        long timestamp,
        string signature,
        string? targetAsset,
        long? indexId,
        bool? flexibleAllowedToUse,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/source-asset/list"),
            [],
            [new Param("usageType", usageType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("targetAsset", targetAsset),
                new Param("indexId", indexId),
                new Param("flexibleAllowedToUse", flexibleAllowedToUse),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestSourceAssetListResponse>(),
            QuerySourceAssetListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query subscription transaction history
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="planId"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="targetAsset"></param>
    /// <param name="planType"></param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingAutoInvestHistoryListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QuerySubscriptionTransactionHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query subscription transaction history of a plan
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingAutoInvestHistoryListResponse>> QuerySubscriptionTransactionHistory(long timestamp,
        string signature,
        long? planId,
        long? startTime,
        long? endTime,
        long? targetAsset,
        PlanType1? planType,
        int? size,
        int? current,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/auto-invest/history/list"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("planId", planId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("targetAsset", targetAsset),
                new Param("planType", planType),
                new Param("size", size),
                new Param("current", current),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingAutoInvestHistoryListResponse>>(),
            QuerySubscriptionTransactionHistoryErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
