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
using Binance.Requests.CopyTrading;

namespace Binance.Api;

/// <summary>
/// Copy Trading Endpoints
/// </summary>
public sealed class CopyTrading
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CopyTrading(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Futures Lead Trader Status(TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CopyTradingFuturesUserStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFuturesLeadTraderStatusTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Futures Lead Trader Status
    /// <para>
    /// Weight(UID): 20
    /// </para>
    /// </remarks>
    public Task<SapiV1CopyTradingFuturesUserStatusResponse> GetFuturesLeadTraderStatusTrade(GetFuturesLeadTraderStatusTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/copyTrading/futures/userStatus"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CopyTradingFuturesUserStatusResponse>(),
            GetFuturesLeadTraderStatusTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Futures Lead Trading Symbol Whitelist(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CopyTradingFuturesLeadSymbolResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFuturesLeadTradingSymbolWhitelistUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Futures Lead Trading Symbol Whitelist
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<SapiV1CopyTradingFuturesLeadSymbolResponse> GetFuturesLeadTradingSymbolWhitelistUserData(GetFuturesLeadTradingSymbolWhitelistUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/copyTrading/futures/leadSymbol"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CopyTradingFuturesLeadSymbolResponse>(),
            GetFuturesLeadTradingSymbolWhitelistUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
