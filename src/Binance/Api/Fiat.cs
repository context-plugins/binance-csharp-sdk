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
using Binance.Requests.Fiat;

namespace Binance.Api;

/// <summary>
/// Fiat Endpoints
/// </summary>
public sealed class Fiat
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Fiat(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Fiat Deposit/Withdraw History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FiatOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FiatDepositWithdrawHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If beginTime and endTime are not sent, the recent 30-day data will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 90000
    /// </para>
    /// </remarks>
    public Task<SapiV1FiatOrdersResponse> FiatDepositWithdrawHistoryUserData(FiatDepositWithdrawHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/fiat/orders"),
            [],
            [
                new Param("transactionType", request.TransactionType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("beginTime", request.BeginTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("rows", request.Rows),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FiatOrdersResponse>(),
            FiatDepositWithdrawHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Fiat Payments History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FiatPaymentsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FiatPaymentsHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If beginTime and endTime are not sent, the recent 30-day data will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1FiatPaymentsResponse> FiatPaymentsHistoryUserData(FiatPaymentsHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/fiat/payments"),
            [],
            [
                new Param("transactionType", request.TransactionType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("beginTime", request.BeginTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("rows", request.Rows),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FiatPaymentsResponse>(),
            FiatPaymentsHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
