using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Exceptions;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Core.Request;
using BinancePublicSpotApi.Core.Response;
using BinancePublicSpotApi.Errors;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Api;

/// <summary>
/// User Data Stream
/// </summary>
public sealed class StreamApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal StreamApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Close a ListenKey (USER_STREAM)
    /// </summary>
    /// <param name="listenKey">User websocket listen key</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CloseAListenKeyUserStreamError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Close out a user data stream.
    /// <para>
    /// Weight: 2
    /// </para>
    /// </remarks>
    public Task<object> CloseAListenKeyUserStream(string? listenKey,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/userDataStream"),
            [],
            [new Param("listenKey", listenKey)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            CloseAListenKeyUserStreamErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create a ListenKey (USER_STREAM)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiV3UserDataStreamResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Start a new user data stream.
    /// The stream will close after 60 minutes unless a keepalive is sent. If the account has an active <c>listenKey</c>, that <c>listenKey</c> will be returned and its validity will be extended for 60 minutes.
    /// <para>
    /// Weight: 2
    /// </para>
    /// </remarks>
    public Task<ApiV3UserDataStreamResponse> CreateAListenKeyUserStream(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/userDataStream"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ApiV3UserDataStreamResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Ping/Keep-alive a ListenKey (USER_STREAM)
    /// </summary>
    /// <param name="listenKey">User websocket listen key</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PingKeepAliveAListenKeyUserStreamError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Keepalive a user data stream to prevent a time out. User data streams will close after 60 minutes. It's recommended to send a ping about every 30 minutes.
    /// <para>
    /// Weight: 2
    /// </para>
    /// </remarks>
    public Task<object> PingKeepAliveAListenKeyUserStream(string? listenKey,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v3/userDataStream"),
            [],
            [new Param("listenKey", listenKey)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            PingKeepAliveAListenKeyUserStreamErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
