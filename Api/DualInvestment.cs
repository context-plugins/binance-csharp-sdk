using System;
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
using Binance.Requests.DualInvestment;

namespace Binance.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductAutoCompoundEditStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ChangeAutoCompoundStatusUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1DciProductAutoCompoundEditStatusResponse> ChangeAutoCompoundStatusUserData(ChangeAutoCompoundStatusUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/dci/product/auto_compound/edit-status"),
            [],
            [
                new Param("positionId", request.PositionId),
                new Param("autoCompoundPlan", request.AutoCompoundPlan),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductAutoCompoundEditStatusResponse>(),
            ChangeAutoCompoundStatusUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Check Dual Investment accounts(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductAccountsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CheckDualInvestmentAccountsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Check Dual Investment accounts
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1DciProductAccountsResponse> CheckDualInvestmentAccountsUserData(CheckDualInvestmentAccountsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/dci/product/accounts"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductAccountsResponse>(),
            CheckDualInvestmentAccountsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Dual Investment positions(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductPositionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDualInvestmentPositionsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Dual Investment positions (batch)
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1DciProductPositionsResponse> GetDualInvestmentPositionsUserData(GetDualInvestmentPositionsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/dci/product/positions"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("status", request.Status),
                new Param("pageSize", request.PageSize),
                new Param("pageIndex", request.PageIndex),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductPositionsResponse>(),
            GetDualInvestmentPositionsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Dual Investment product list(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDualInvestmentProductListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Dual Investment product list
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1DciProductListResponse> GetDualInvestmentProductListUserData(GetDualInvestmentProductListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/dci/product/list"),
            [],
            [
                new Param("optionType", request.OptionType),
                new Param("exercisedCoin", request.ExercisedCoin),
                new Param("investCoin", request.InvestCoin),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("pageSize", request.PageSize),
                new Param("pageIndex", request.PageIndex),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductListResponse>(),
            GetDualInvestmentProductListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Subscribe Dual Investment products(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1DciProductSubscribeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubscribeDualInvestmentProductsUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1DciProductSubscribeResponse> SubscribeDualInvestmentProductsUserData(SubscribeDualInvestmentProductsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/dci/product/subscribe"),
            [],
            [
                new Param("id", request.Id),
                new Param("orderId", request.OrderId),
                new Param("depositAmount", request.DepositAmount),
                new Param("autoCompoundPlan", request.AutoCompoundPlan),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1DciProductSubscribeResponse>(),
            SubscribeDualInvestmentProductsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
