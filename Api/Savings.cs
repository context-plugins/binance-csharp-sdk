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
/// Savings Endpoints
/// </summary>
public sealed class Savings
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Savings(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Change Fixed/Activity Position to Daily Position (USER_DATA)
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="lot"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="positionId"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingPositionChangedResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ChangeFixedActivityPositionToDailyPositionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>PositionId is mandatory parameter for fixed position.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingPositionChangedResponse> ChangeFixedActivityPositionToDailyPositionUserData(string projectId,
        string lot,
        long timestamp,
        string signature,
        string? positionId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/positionChanged"),
            [],
            [new Param("projectId", projectId),
                new Param("lot", lot),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("positionId", positionId),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingPositionChangedResponse>(),
            ChangeFixedActivityPositionToDailyPositionUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Fixed/Activity Project List(USER_DATA)
    /// </summary>
    /// <param name="type"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="status">Default <c>ALL</c></param>
    /// <param name="isSortAsc">default "true"</param>
    /// <param name="sortBy">Default <c>START_TIME</c></param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingProjectListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFixedActivityProjectListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingProjectListResponse>> GetFixedActivityProjectListUserData(Type8 type,
        long timestamp,
        string signature,
        string? asset,
        Status? status,
        bool? isSortAsc,
        SortBy? sortBy,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/project/list"),
            [],
            [new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("status", status),
                new Param("isSortAsc", isSortAsc),
                new Param("sortBy", sortBy),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingProjectListResponse>>(),
            GetFixedActivityProjectListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Fixed/Activity Project Position (USER_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="projectId"></param>
    /// <param name="status">Default <c>ALL</c></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingProjectPositionListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFixedActivityProjectPositionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingProjectPositionListResponse>> GetFixedActivityProjectPositionUserData(string asset,
        long timestamp,
        string signature,
        string? projectId,
        Status? status,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/project/position/list"),
            [],
            [new Param("asset", asset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("projectId", projectId),
                new Param("status", status),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingProjectPositionListResponse>>(),
            GetFixedActivityProjectPositionUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Purchase Fixed/Activity Project (USER_DATA)
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="lot"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingCustomizedFixedPurchaseResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PurchaseFixedActivityProjectUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1LendingCustomizedFixedPurchaseResponse> PurchaseFixedActivityProjectUserData(string projectId,
        string lot,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/lending/customizedFixed/purchase"),
            [],
            [new Param("projectId", projectId),
                new Param("lot", lot),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingCustomizedFixedPurchaseResponse>(),
            PurchaseFixedActivityProjectUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
