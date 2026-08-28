using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core;
using Binance.Core.ErrorResponse;
using Binance.Core.Exceptions;
using Binance.Core.Models;
using Binance.Core.Request;
using Binance.Core.Response;
using Binance.Errors;
using Binance.Models;

namespace Binance.Api;

/// <summary>
/// Isolated User Data Stream
/// </summary>
public sealed class IsolatedMarginStream
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal IsolatedMarginStream(RawClient rawClient, Server server, AuthSchemes auth)
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
    /// <exception cref="SdkException{TResult}"> of <see cref="CloseAListenKeyUserStream3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Close out a user data stream.
    /// <para>
    /// Weight: 1
    /// </para>
    /// </remarks>
    public Task<object> CloseAListenKeyUserStream3(string? listenKey,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/userDataStream/isolated"),
            [],
            [new Param("listenKey", listenKey)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            CloseAListenKeyUserStream3ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Generate a Listen Key (USER_STREAM)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1UserDataStreamIsolatedResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Start a new user data stream.
    /// The stream will close after 60 minutes unless a keepalive is sent. If the account has an active <c>listenKey</c>, that <c>listenKey</c> will be returned and its validity will be extended for 60 minutes.
    /// <para>
    /// Weight: 1
    /// </para>
    /// </remarks>
    public Task<SapiV1UserDataStreamIsolatedResponse> GenerateAListenKeyUserStream(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/userDataStream/isolated"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1UserDataStreamIsolatedResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Ping/Keep-alive a Listen Key (USER_STREAM)
    /// </summary>
    /// <param name="listenKey">User websocket listen key</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PingKeepAliveAListenKeyUserStreamApiError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Keepalive a user data stream to prevent a time out. User data streams will close after 60 minutes. It's recommended to send a ping about every 30 minutes.
    /// <para>
    /// Weight: 1
    /// </para>
    /// </remarks>
    public Task<object> PingKeepAliveAListenKeyUserStream(string? listenKey,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/userDataStream/isolated"),
            [],
            [new Param("listenKey", listenKey)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            PingKeepAliveAListenKeyUserStreamApiErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
