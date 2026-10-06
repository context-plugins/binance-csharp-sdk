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
using Binance.Requests.Savings;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingPositionChangedResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ChangeFixedActivityPositionToDailyPositionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>PositionId is mandatory parameter for fixed position.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1LendingPositionChangedResponse> ChangeFixedActivityPositionToDailyPositionUserData(ChangeFixedActivityPositionToDailyPositionUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/positionChanged"),
            [],
            [
                new Param("projectId", request.ProjectId),
                new Param("lot", request.Lot),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("positionId", request.PositionId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingPositionChangedResponse>(),
            ChangeFixedActivityPositionToDailyPositionUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Fixed/Activity Project List(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingProjectListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFixedActivityProjectListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingProjectListResponse>> GetFixedActivityProjectListUserData(GetFixedActivityProjectListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/project/list"),
            [],
            [
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("status", request.Status),
                new Param("isSortAsc", request.IsSortAsc),
                new Param("sortBy", request.SortBy),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingProjectListResponse>>(),
            GetFixedActivityProjectListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Fixed/Activity Project Position (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LendingProjectPositionListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFixedActivityProjectPositionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LendingProjectPositionListResponse>> GetFixedActivityProjectPositionUserData(GetFixedActivityProjectPositionUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/project/position/list"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("projectId", request.ProjectId),
                new Param("status", request.Status),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LendingProjectPositionListResponse>>(),
            GetFixedActivityProjectPositionUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Purchase Fixed/Activity Project (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LendingCustomizedFixedPurchaseResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PurchaseFixedActivityProjectUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1LendingCustomizedFixedPurchaseResponse> PurchaseFixedActivityProjectUserData(PurchaseFixedActivityProjectUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/lending/customizedFixed/purchase"),
            [],
            [
                new Param("projectId", request.ProjectId),
                new Param("lot", request.Lot),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LendingCustomizedFixedPurchaseResponse>(),
            PurchaseFixedActivityProjectUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
