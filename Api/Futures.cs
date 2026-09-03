using System;
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
    /// <param name="asset"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FuturesTransferResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFutureAccountTransactionHistoryListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1FuturesTransferResponse1> GetFutureAccountTransactionHistoryListUserData(string asset,
        long startTime,
        long timestamp,
        string signature,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/futures/transfer"),
            [],
            [new Param("asset", asset),
                new Param("startTime", startTime),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FuturesTransferResponse1>(),
            GetFutureAccountTransactionHistoryListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Future TickLevel Orderbook Historical Data Download Link (USER_DATA)
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataType"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FuturesHistDataLinkResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1FuturesHistDataLinkResponse> GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData(string symbol,
        DataTypeEnum dataType,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/futures/histDataLink"),
            [],
            [new Param("symbol", symbol),
                new Param("dataType", dataType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FuturesHistDataLinkResponse>(),
            GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// New Future Account Transfer (USER_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="type">1: transfer from spot account to USDT-Ⓜ futures account. 2: transfer from USDT-Ⓜ futures account to spot account. 3: transfer from spot account to COIN-Ⓜ futures account. 4: transfer from COIN-Ⓜ futures account to spot account.</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FuturesTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="NewFutureAccountTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Execute transfer between spot account and futures account.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1FuturesTransferResponse> NewFutureAccountTransferUserData(string asset,
        double amount,
        long type,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/futures/transfer"),
            [],
            [new Param("asset", asset),
                new Param("amount", amount),
                new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FuturesTransferResponse>(),
            NewFutureAccountTransferUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
