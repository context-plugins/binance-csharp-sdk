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
using Binance.Requests.AutoInvest;

namespace Binance.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanEditStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ChangePlanStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Change Plan Status
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanEditStatusResponse> ChangePlanStatus(ChangePlanStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/plan/edit-status"),
            [],
            [
                new Param("planId", request.PlanId),
                new Param("status", request.Status),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanEditStatusResponse>(),
            ChangePlanStatusError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get list of plans
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetListOfPlansError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query plan lists
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanListResponse> GetListOfPlans(GetListOfPlansRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/plan/list"),
            [],
            [
                new Param("planType", request.PlanType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanListResponse>(),
            GetListOfPlansError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get target asset ROI data (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingAutoInvestTargetAssetRoiListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTargetAssetRoiDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// ROI return list for target asset
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingAutoInvestTargetAssetRoiListResponse>> GetTargetAssetRoiDataUserData(GetTargetAssetRoiDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/target-asset/roi/list"),
            [],
            [
                new Param("targetAsset", request.TargetAsset),
                new Param("hisRoiType", request.HisRoiType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingAutoInvestTargetAssetRoiListResponse>>(),
            GetTargetAssetRoiDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get target asset list (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestTargetAssetListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTargetAssetListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1LendingAutoInvestTargetAssetListResponse> GetTargetAssetListUserData(GetTargetAssetListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/target-asset/list"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("targetAsset", request.TargetAsset),
                new Param("size", request.Size),
                new Param("current", request.Current),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestTargetAssetListResponse>(),
            GetTargetAssetListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Index Linked Plan Rebalance Details (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingAutoInvestRebalanceHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="IndexLinkedPlanRebalanceDetailsUserDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<SapiV1LendingAutoInvestRebalanceHistoryResponse>> IndexLinkedPlanRebalanceDetailsUserData(IndexLinkedPlanRebalanceDetailsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/rebalance/history"),
            [],
            [
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
            JsonResponse.Create<IReadOnlyList<SapiV1LendingAutoInvestRebalanceHistoryResponse>>(),
            IndexLinkedPlanRebalanceDetailsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Index Linked Plan Redemption (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestRedeemResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="IndexLinkedPlanRedemptionTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To redeem index-Linked plan holdings
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestRedeemResponse> IndexLinkedPlanRedemptionTrade(IndexLinkedPlanRedemptionTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/redeem"),
            [],
            [
                new Param("indexId", request.IndexId),
                new Param("redemptionPercentage", request.RedemptionPercentage),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("requestId", request.RequestId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestRedeemResponse>(),
            IndexLinkedPlanRedemptionTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Index Linked Plan Redemption History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingAutoInvestRedeemHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="IndexLinkedPlanRedemptionHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<SapiV1LendingAutoInvestRedeemHistoryResponse>> IndexLinkedPlanRedemptionHistoryUserData(IndexLinkedPlanRedemptionHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/redeem/history"),
            [],
            [
                new Param("requestId", request.RequestId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("asset", request.Asset),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingAutoInvestRedeemHistoryResponse>>(),
            IndexLinkedPlanRedemptionHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Investment plan adjustment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanEditResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="InvestmentPlanAdjustmentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Source Asset to be used for investment
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanEditResponse> InvestmentPlanAdjustment(InvestmentPlanAdjustmentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/plan/edit"),
            [],
            [
                new Param("planId", request.PlanId),
                new Param("subscriptionAmount", request.SubscriptionAmount),
                new Param("subscriptionCycle", request.SubscriptionCycle),
                new Param("subscriptionStartTime", request.SubscriptionStartTime),
                new Param("sourceAsset", request.SourceAsset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("subscriptionStartDay", request.SubscriptionStartDay),
                new Param("subscriptionStartWeekday", request.SubscriptionStartWeekday),
                new Param("flexibleAllowedToUse", request.FlexibleAllowedToUse),
                new Param("details", request.Details),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanEditResponse>(),
            InvestmentPlanAdjustmentError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Investment plan creation (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanAddResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="InvestmentPlanCreationUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Post an investment plan creation
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanAddResponse> InvestmentPlanCreationUserData(InvestmentPlanCreationUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/plan/add"),
            [],
            [
                new Param("sourceType", request.SourceType),
                new Param("planType", request.PlanType),
                new Param("subscriptionAmount", request.SubscriptionAmount),
                new Param("subscriptionCycle", request.SubscriptionCycle),
                new Param("subscriptionStartTime", request.SubscriptionStartTime),
                new Param("sourceAsset", request.SourceAsset),
                new Param("details", request.Details),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("requestId", request.RequestId),
                new Param("IndexId", request.IndexId),
                new Param("subscriptionStartDay", request.SubscriptionStartDay),
                new Param("subscriptionStartWeekday", request.SubscriptionStartWeekday),
                new Param("flexibleAllowedToUse", request.FlexibleAllowedToUse),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanAddResponse>(),
            InvestmentPlanCreationUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// One Time Transaction(TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestOneOffResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="OneTimeTransactionTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// One time transaction
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestOneOffResponse> OneTimeTransactionTrade(OneTimeTransactionTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/one-off"),
            [],
            [
                new Param("sourceType", request.SourceType),
                new Param("subscriptionAmount", request.SubscriptionAmount),
                new Param("sourceAsset", request.SourceAsset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("requestId", request.RequestId),
                new Param("flexibleAllowedToUse", request.FlexibleAllowedToUse),
                new Param("planId", request.PlanId),
                new Param("indexId", request.IndexId),
                new Param("details", request.Details),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestOneOffResponse>(),
            OneTimeTransactionTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Index Details(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestIndexInfoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryIndexDetailsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query index details
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestIndexInfoResponse> QueryIndexDetailsUserData(QueryIndexDetailsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/index/info"),
            [],
            [
                new Param("indexId", request.IndexId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestIndexInfoResponse>(),
            QueryIndexDetailsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Index Linked Plan Position Details(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestIndexUserSummaryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryIndexLinkedPlanPositionDetailsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Details on users Index-Linked plan position details
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestIndexUserSummaryResponse> QueryIndexLinkedPlanPositionDetailsUserData(QueryIndexLinkedPlanPositionDetailsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/index/user-summary"),
            [],
            [
                new Param("indexId", request.IndexId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestIndexUserSummaryResponse>(),
            QueryIndexLinkedPlanPositionDetailsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query One-Time Transaction Status (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestOneOffStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryOneTimeTransactionStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transaction status for one-time transaction
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestOneOffStatusResponse> QueryOneTimeTransactionStatusUserData(QueryOneTimeTransactionStatusUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/one-off/status"),
            [],
            [
                new Param("transactionId", request.TransactionId),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("requestId", request.RequestId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestOneOffStatusResponse>(),
            QueryOneTimeTransactionStatusUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query all source asset and target asset (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestAllAssetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryAllSourceAssetAndTargetAssetUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query all source assets and target assets
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestAllAssetResponse> QueryAllSourceAssetAndTargetAssetUserData(QueryAllSourceAssetAndTargetAssetUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/all/asset"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestAllAssetResponse>(),
            QueryAllSourceAssetAndTargetAssetUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query holding details of the plan
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestPlanIdResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryHoldingDetailsOfThePlanError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query holding details of the plan
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestPlanIdResponse> QueryHoldingDetailsOfThePlan(QueryHoldingDetailsOfThePlanRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/plan/id"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("planId", request.PlanId),
                new Param("requestId", request.RequestId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestPlanIdResponse>(),
            QueryHoldingDetailsOfThePlanError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query source asset list (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingAutoInvestSourceAssetListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QuerySourceAssetListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Source Asset to be used for investment
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingAutoInvestSourceAssetListResponse> QuerySourceAssetListUserData(QuerySourceAssetListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/source-asset/list"),
            [],
            [
                new Param("usageType", request.UsageType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("targetAsset", request.TargetAsset),
                new Param("indexId", request.IndexId),
                new Param("flexibleAllowedToUse", request.FlexibleAllowedToUse),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingAutoInvestSourceAssetListResponse>(),
            QuerySourceAssetListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query subscription transaction history
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingAutoInvestHistoryListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QuerySubscriptionTransactionHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query subscription transaction history of a plan
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingAutoInvestHistoryListResponse>> QuerySubscriptionTransactionHistory(QuerySubscriptionTransactionHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/auto-invest/history/list"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("planId", request.PlanId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("targetAsset", request.TargetAsset),
                new Param("planType", request.PlanType),
                new Param("size", request.Size),
                new Param("current", request.Current),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingAutoInvestHistoryListResponse>>(),
            QuerySubscriptionTransactionHistoryError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
