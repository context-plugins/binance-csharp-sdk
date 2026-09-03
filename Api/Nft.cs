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

namespace BinancePublicSpotApi.Api;

/// <summary>
/// NFT Endpoints
/// </summary>
public sealed class Nft
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Nft(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get NFT Asset (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="limit">Default 50, Max 50</param>
    /// <param name="page">Default 1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1NftUserGetAssetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetNftAssetUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 3000
    /// </remarks>
    public Task<SapiV1NftUserGetAssetResponse> GetNftAssetUserData(long timestamp,
        string signature,
        int? limit,
        int? page,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/nft/user/getAsset"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("limit", limit),
                new Param("page", page),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1NftUserGetAssetResponse>(),
            GetNftAssetUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get NFT Deposit History(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">Default 50, Max 50</param>
    /// <param name="page">Default 1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1NftHistoryDepositResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetNftDepositHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The max interval between startTime and endTime is 90 days.</description></item>
    ///   <item><description>If startTime and endTime are not sent, the recent 7 days' data will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1NftHistoryDepositResponse> GetNftDepositHistoryUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? limit,
        int? page,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/nft/history/deposit"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("page", page),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1NftHistoryDepositResponse>(),
            GetNftDepositHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get NFT Transaction History (USER_DATA)
    /// </summary>
    /// <param name="orderType">0: purchase order, 1: sell order, 2: royalty income, 3: primary market order, 4: mint fee</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">Default 50, Max 50</param>
    /// <param name="page">Default 1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1NftHistoryTransactionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetNftTransactionHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The max interval between startTime and endTime is 90 days.</description></item>
    ///   <item><description>If startTime and endTime are not sent, the recent 7 days' data will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1NftHistoryTransactionsResponse> GetNftTransactionHistoryUserData(int orderType,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? limit,
        int? page,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/nft/history/transactions"),
            [],
            [new Param("orderType", orderType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("page", page),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1NftHistoryTransactionsResponse>(),
            GetNftTransactionHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get NFT Withdraw History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">Default 50, Max 50</param>
    /// <param name="page">Default 1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1NftHistoryWithdrawResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetNftWithdrawHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The max interval between startTime and endTime is 90 days.</description></item>
    ///   <item><description>If startTime and endTime are not sent, the recent 7 days' data will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1NftHistoryWithdrawResponse> GetNftWithdrawHistoryUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? limit,
        int? page,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/nft/history/withdraw"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("page", page),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1NftHistoryWithdrawResponse>(),
            GetNftWithdrawHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
