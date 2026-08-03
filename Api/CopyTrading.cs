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
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CopyTradingFuturesUserStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFuturesLeadTraderStatusTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Futures Lead Trader Status
    /// <para>
    /// Weight(UID): 20
    /// </para>
    /// </remarks>
    public Task<SapiV1CopyTradingFuturesUserStatusResponse> GetFuturesLeadTraderStatusTrade(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/copyTrading/futures/userStatus"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CopyTradingFuturesUserStatusResponse>(),
            GetFuturesLeadTraderStatusTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Futures Lead Trading Symbol Whitelist(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CopyTradingFuturesLeadSymbolResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFuturesLeadTradingSymbolWhitelistUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Futures Lead Trading Symbol Whitelist
    /// <para>
    /// Weight(IP): 20
    /// </para>
    /// </remarks>
    public Task<SapiV1CopyTradingFuturesLeadSymbolResponse> GetFuturesLeadTradingSymbolWhitelistUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/copyTrading/futures/leadSymbol"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CopyTradingFuturesLeadSymbolResponse>(),
            GetFuturesLeadTradingSymbolWhitelistUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
