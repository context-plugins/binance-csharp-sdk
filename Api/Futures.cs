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
using Binance.Requests.Futures;

namespace Binance.Api;

/// <summary>
/// Futures Endpoints
/// </summary>
public sealed class Futures
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Futures(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Future Account Transaction History List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FuturesTransferResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFutureAccountTransactionHistoryListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1FuturesTransferResponse1> GetFutureAccountTransactionHistoryListUserData(GetFutureAccountTransactionHistoryListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/futures/transfer"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("startTime", request.StartTime),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FuturesTransferResponse1>(),
            GetFutureAccountTransactionHistoryListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Future TickLevel Orderbook Historical Data Download Link (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FuturesHistDataLinkResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1FuturesHistDataLinkResponse> GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData(GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/futures/histDataLink"),
            [],
            [
                new Param("symbol", request.Symbol),
                new Param("dataType", request.DataType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FuturesHistDataLinkResponse>(),
            GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// New Future Account Transfer (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FuturesTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="NewFutureAccountTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Execute transfer between spot account and futures account.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1FuturesTransferResponse> NewFutureAccountTransferUserData(NewFutureAccountTransferUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/futures/transfer"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FuturesTransferResponse>(),
            NewFutureAccountTransferUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
